using System.Diagnostics;
using System.Text;
using Humanizer;
using Mail.dat;
using Mail.dat.Io;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Test
{
	internal class Program
	{
		static async Task<int> Main(string[] args)
		{
			bool import = true;

			if (import)
			{
				await AnsiConsole.Progress()
				.AutoClear(false)
				.AutoRefresh(true)
				.Columns(
				[
						new TaskDescriptionColumn(),    // Task description
                    new ProgressBarColumn(),        // Progress bar
                    new PercentageColumn(),         // Percentage
                    new ElapsedTimeColumn(),        // Elapsed time
                    new SpinnerColumn(),            // Spinner
					new LineCountColumn(),          // Line count
				])
				.UseRenderHook((renderable, tasks) => RenderHook(tasks, renderable))
				.StartAsync(async ctx =>
				{
					//
					// Create a progress task. This is used to track the progress of the import.
					//
					IDictionary<string, ProgressTask> tasks = new Dictionary<string, ProgressTask>();

					//
					// Create an IMailFile instance. This is used to track the Mail.dat
					// zip file and individul files within the zip file.
					//
					IMaildatFile file = MaildatFile.Create($"Z:/Downloads/52850001-25-1.zip");

					//
					// Create temporary path to unzip the files.
					//
					DirectoryInfo tempPath = new($"{Path.GetTempPath()}{Path.GetFileNameWithoutExtension(file.FilePath)}");

					//
					// Provide a full path to the database file. This is used to create the database
					//
					string databasePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/0000000001.db";

					//
					// Create a new import instance . This is used to import the Mail.dat files.
					//
					IMaildatImport import = MaildatImport.Create(
					(item) =>
					{
						lock (tasks)
						{
							switch (item.ItemAction)
							{
								case ProgressMessageType.Completed:
									{
										//
										// Stop the last task.
										//
										if (!tasks.Last().Value.IsFinished)
										{
											tasks.Last().Value.Value(1.0);
										}

										tasks.Last().Value.StopTask();
									}
									break;
								case ProgressMessageType.Message:
									{
										//
										// Stop the last task.
										//
										if (!tasks.Last().Value.IsFinished)
										{
											tasks.Last().Value.Value(1.0);
											tasks.Last().Value.StopTask();
										}

										//
										// Create and start a new task
										//
										ProgressTask task = ctx.AddTask($"[white]{item.Message}[/]");
										tasks.Add($"{tasks.Count}", task);
										task.IsIndeterminate = true;
										task.MaxValue(1.0);
										task.StartTask();
									}
									break;
								case ProgressMessageType.ImportExport:
									{
										double percentage = item.ItemIndex / item.ItemCount;

										if (tasks.ContainsKey(item.ItemName))
										{
											//
											// Update the progress bar.
											//
											tasks[item.ItemName].Value(item.ItemIndex);

											if (item.ItemIndex >= item.ItemCount)
											{
												tasks[item.ItemName].StopTask();
											}
										}
										else
										{
											//
											// Create a new progress bar.
											//
											ProgressTask task = ctx.AddTask($"[white]Importing[/] [yellow]{item.ItemName.Replace(" Record", "")}[/]");
											tasks.Add(item.ItemName, task);
											tasks[item.ItemName].StartTask();
											tasks[item.ItemName].MaxValue(item.ItemCount);
											tasks[item.ItemName].Increment(percentage);
										}
									}
									break;
								default:
									break;
							}
						}

						return Task.CompletedTask;
					});

					//
					// Create a cancellation token source. This is used to cancel the import if needed.
					//
					CancellationTokenSource cancellationTokenSource = new();

					//
					// Create the import options. This is used to specify the file to import,
					// the target directory, and the database path.
					//
					IImportOptions importOptions = new ImportOptions()
					{
						File = file,
						TargetDirectory = tempPath.FullName,
						DatabasePath = databasePath,
						CancellationToken = cancellationTokenSource.Token,
						SkipPbcFile = true
					};

					//
					// Import the Mail.dat.files. This will unzip the files, create the database, and import the data.
					//
					Stopwatch stopwatch = new();
					stopwatch.Start();
					(bool result, MaildatContext context) = await import.ImportAsync(importOptions);
					stopwatch.Stop();

					AnsiConsole.MarkupLine($"Import completed in [yellow]{stopwatch.Elapsed.Humanize()}[/].");

					//
					// Check for errors.
					//
					int totalErrors = context.Errors.Count();

					if (totalErrors > 0)
					{
						AnsiConsole.MarkupLine($"[yellow]There were [white]{totalErrors}[/] errors during import.[/]");

						var errorsByFile = context.Errors.GroupBy(x => x.File).Select(g => new { File = g.Key, Count = g.Count() }).ToList();

						foreach (var error in errorsByFile)
						{
							AnsiConsole.MarkupLine($"\t[white]{error.File}[/] - [red]{error.Count}[/] errors.");
						}
					}
					else
					{
						AnsiConsole.MarkupLine($"[green]No errors during import.[/]");
					}

					//
					// Dispose the context.
					//
					context.Dispose();
				});
			}
			else
			{
				await AnsiConsole.Progress()
				.AutoClear(false)
				.AutoRefresh(true)
				.Columns(
				[
					new TaskDescriptionColumn(),    // Task description
                    new ProgressBarColumn(),        // Progress bar
                    new PercentageColumn(),         // Percentage
                    new ElapsedTimeColumn(),        // Elapsed time
                    new SpinnerColumn(),            // Spinner
					new LineCountColumn(),          // Line count
				])
				.UseRenderHook((renderable, tasks) => RenderHook(tasks, renderable))
				.StartAsync(async ctx =>
				{
					//
					// Create a progress task. This is used to track the progress of the import.
					//
					IDictionary<string, ProgressTask> tasks = new Dictionary<string, ProgressTask>();

					//
					// Create an IMailFile instance. This is used to track the Mail.dat
					// zip file and individul files within the zip file.
					//
					IMaildatFile file = MaildatFile.Create($"Z:/Desktop/Export/52850001.zip");

					//
					// Provide a full path to the database file. This is used to create the database
					//
					string databasePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/0000000001.db";

					//
					// Create a new import instance . This is used to import the Mail.dat files.
					//
					IMaildatExport export = MaildatExport.Create(
					(item) =>
					{
						lock (tasks)
						{
							switch (item.ItemAction)
							{
								case ProgressMessageType.Completed:
									{
										//
										// Stop the last task.
										//
										if (!tasks.Last().Value.IsFinished)
										{
											tasks.Last().Value.Value(1.0);
											tasks.Last().Value.StopTask();
										}

										AnsiConsole.MarkupLine($"[white]{item.Message}[/]");
									}
									break;
								case ProgressMessageType.Message:
									{
										//
										// Stop the last task.
										//
										if (!tasks.Last().Value.IsFinished)
										{
											tasks.Last().Value.Value(1.0);
											tasks.Last().Value.StopTask();
										}

										//
										// Create and start a new task
										//
										ProgressTask task = ctx.AddTask($"[white]{item.Message}[/]");
										tasks.Add($"{tasks.Count}", task);
										task.IsIndeterminate = true;
										task.MaxValue(1.0);
										task.StartTask();
									}
									break;
								case ProgressMessageType.ImportExport:
									{
										double percentage = item.ItemIndex / item.ItemCount;

										if (tasks.ContainsKey(item.ItemName))
										{
											//
											// Update the progress bar.
											//
											tasks[item.ItemName].Value(item.ItemIndex);

											if (item.ItemIndex >= item.ItemCount)
											{
												tasks[item.ItemName].StopTask();
											}
										}
										else
										{
											//
											// Create a new progress bar.
											//
											ProgressTask task = ctx.AddTask($"[white]Exporting[/] [yellow]{item.ItemName.Replace(" Record", "")}[/]");

											tasks.Add(item.ItemName, task);
											tasks[item.ItemName].StartTask();
											tasks[item.ItemName].MaxValue(item.ItemCount);
											tasks[item.ItemName].Increment(percentage);
										}
									}
									break;
								default:
									break;
							}
						}

						return Task.CompletedTask;
					});

					//
					// Create a cancellation token source. This is used to cancel the import if needed.
					//
					CancellationTokenSource cancellationTokenSource = new();

					//
					// Create the import options. This is used to specify the file to import,
					// the target directory, and the database path.
					//
					IExportOptions exportOptions = new ExportOptions()
					{
						File = file,
						DatabasePath = databasePath,
						Encoding = new UTF8Encoding(false),
						CancellationToken = cancellationTokenSource.Token
					};

					//
					// Import the Mail.dat.files. This will unzip the files, create the database, and import the data.
					//
					Stopwatch stopwatch = new();
					stopwatch.Start();
					bool result = await export.ExportAsync(exportOptions);
					stopwatch.Stop();

					AnsiConsole.MarkupLine($"Export completed in [yellow]{stopwatch.Elapsed.Humanize()}[/].");
				});
			}

			return 0;
		}

		private static IRenderable RenderHook(IReadOnlyList<ProgressTask> tasks, IRenderable renderable)
		{
			//
			// Create a header.
			//
			Panel header = new Panel("Progress").Expand().RoundedBorder().BorderColor(Color.SkyBlue1);

			return new Rows(header, renderable);
		}
	}
}
