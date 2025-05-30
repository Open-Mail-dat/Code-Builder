using System.Diagnostics;
using System.Text;
using Diamond.Core.CommandLine.Model;
using Humanizer;
using Mail.dat.Io;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Mail.dat.ExportCommand
{
	internal class ExportCommandHandler : ModelCommand<CommandOptions>
	{
		public ExportCommandHandler(ILogger<ExportCommandHandler> logger)
			: base(logger, "export", "Export a Mail.dat from a Sqlite database.")
		{
		}

		protected override async Task<int> OnHandleCommand(CommandOptions options)
		{
			int returnValue = 0;

			if (options.SourceFilePath.Exists)
			{
				AnsiConsole.Clear();

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
					IMaildatFile file = MaildatFile.Create(options.TargetFilePath.FullName);

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
								case ProgressMessageType.Start:
									{
										//
										// Determine the text to show on screen for the task.
										//
										string description = item.WillShowProgress ?
															$"[white]Importing[/] [yellow]{item.ItemName.Replace(" Record", "")}[/]" :
															$"[white]{item.Message}[/]";

										//
										// Create and start a new task
										//
										ProgressTask task = ctx.AddTask(description);

										if (item.WillShowProgress)
										{
											task.IsIndeterminate = false;
											task.StartTask();
											task.MaxValue(item.ItemCount);
										}
										else
										{
											task.IsIndeterminate = true;
											task.MaxValue(1.0);
										}

										tasks.Add(item.ItemName, task);
										task.StartTask();
									}
									break;
								case ProgressMessageType.Progress:
									if (tasks.ContainsKey(item.ItemName))
									{
										ProgressTask task = tasks[item.ItemName];
										task.Value(item.ItemIndex);
									}
									break;
								case ProgressMessageType.Completed:
									if (tasks.ContainsKey(item.ItemName))
									{
										ProgressTask task = tasks[item.ItemName];

										if (item.WillShowProgress)
										{
											task.Value(item.ItemIndex);
										}
										else
										{
											task.Value(1.0);
										}

										task.StopTask();
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
						TargetFile = file,
						SourceFile = options.SourceFilePath.FullName,
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
			else
			{
				AnsiConsole.MarkupLine($"[red]The file '{options.SourceFilePath.FullName}' does not exist.[/]");
				returnValue = 1;
			}

			return returnValue;
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
