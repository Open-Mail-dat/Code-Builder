//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.Diagnostics;
using Diamond.Core.CommandLine.Model;
using Diamond.Core.System.TemporaryFolder;
using Humanizer;
using Humanizer.Localisation;
using Mail.dat.Io;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Mail.dat.ImportCommand
{
	/// <summary>
	/// Handles the "import" command, which imports a Mail.dat file into a SQLite database.
	/// </summary>
	/// <remarks>This command performs the following operations: <list type="bullet"> <item><description>Validates
	/// the existence of the source file specified in the command options.</description></item> <item><description>Displays
	/// a progress bar to track the import process.</description></item> <item><description>Unzips the source file,
	/// processes its contents, and imports the data into a database.</description></item> <item><description>Reports any
	/// errors encountered during the import process, grouped by file.</description></item> </list> If the source file does
	/// not exist, the command logs an error and exits with a non-zero status code.  Otherwise, it performs the import and
	/// logs the results, including any discrepancies between expected  and actual record counts.</remarks>
	internal class ImportCommandHandler : ModelCommand<CommandOptions>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportCommandHandler"/> class.
		/// </summary>
		/// <param name="logger">The logger instance used to log messages and diagnostics for the command handler.</param>
		public ImportCommandHandler(ILogger<ImportCommandHandler> logger)
			: base(logger, "import", "Import a Mail.dat into a Sqlite database.")
		{
		}

		/// <summary>
		/// Handles the execution of the command with the specified options.
		/// </summary>
		/// <remarks>This method performs the following operations: <list type="bullet"> <item><description>Validates
		/// the existence of the source file specified in the options.</description></item> <item><description>Displays a
		/// progress bar to track the import process.</description></item> <item><description>Unzips the source file,
		/// processes its contents, and imports the data into a database.</description></item> <item><description>Reports any
		/// errors encountered during the import process, grouped by file.</description></item> </list> If the source file
		/// does not exist, the method logs an error message and returns 1. Otherwise, it performs the import and logs the
		/// results, including any discrepancies between expected and actual record counts.</remarks>
		/// <param name="options">The options provided for the command execution, including file paths and import settings.</param>
		/// <returns>An integer representing the result of the command execution. Returns 0 if the operation completes successfully;
		/// otherwise, returns 1 if the source file does not exist or an error occurs.</returns>
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
						new TaskDescriptionColumn(),	// Task description
						new ProgressBarColumn(),		// Progress bar
						new PercentageColumn(),			// Percentage
						new ElapsedTimeColumn(),		// Elapsed time
						new SpinnerColumn(),			// Spinner
						new LineCountColumn()           // Line count
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
						IMaildatFile file = MaildatFile.Create(options.SourceFilePath.FullName);

						//
						// Create temporary path to unzip the files.
						//
						using ITemporaryFolder temporaryFolder = new TemporaryFolder();

						//
						// Create a new import instance. This is used to import the Mail.dat files.
						//
						IMaildatImport import = MaildatImport.Create(
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
						IImportOptions importOptions = new ImportOptions()
						{
							SourceFile = file,
							TemporaryDirectory = temporaryFolder.FullPath,
							TargetFile = options.TargetFilePath.FullName,
							CancellationToken = cancellationTokenSource.Token,
							SkipPbc = options.SkipPbc,
							FavorMemoryOverPerformance = options.FavorMemoryOverPerformance,
							MaxRecordsInMemory = options.MaxRecordsInMemory
						};

						//
						// Import the Mail.dat.files. This will unzip the files, create the database, and import the data.
						//
						Stopwatch stopwatch = new();
						stopwatch.Start();
						(bool result, MaildatContext context) = await import.ImportAsync(importOptions);
						stopwatch.Stop();

						AnsiConsole.MarkupLine($"Import completed in [yellow]{stopwatch.Elapsed.Humanize(minUnit: TimeUnit.Second)}[/].");

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
							AnsiConsole.MarkupLine($"Header count: {context.Hdr.Count()}.");

							Hdr current = context.Hdr.Where(t => t.HeaderHistoryStatus == "C").SingleOrDefault();

							if (current != null)
							{
								AnsiConsole.MarkupLine($"SEG count: Expected: {current.SegmentRecordCount:#,###}, Actual {context.Seg.Count():#,###}.");
								AnsiConsole.MarkupLine($"MCR count: Expected: {current.MpuCRelationshipRecordCount:#,###}, Actual {context.Mcr.Count():#,###}.");
								AnsiConsole.MarkupLine($"CPT count: Expected: {current.ComponentRecordCount:#,###}, Actual {context.Cpt.Count():#,###}.");
								AnsiConsole.MarkupLine($"MPU count: Expected: {current.MailPieceUnitRecordCount:#,###}, Actual {context.Mpu.Count():#,###}.");
								AnsiConsole.MarkupLine($"MPA count: Expected: {current.MailerPostageAccountRecordCount:#,###}, Actual {context.Mpa.Count():#,###}.");
								AnsiConsole.MarkupLine($"PQT count: Expected: {current.PackageQuantityRecordCount:#,###}, Actual {context.Pqt.Count():#,###}.");
								AnsiConsole.MarkupLine($"CSM count: Expected: {current.ContainerSummaryRecordCount:#,###}, Actual {context.Csm.Count():#,###}.");
								AnsiConsole.MarkupLine($"CQT count: Expected: {current.ContainerQuantityRecordCount:#,###}, Actual {context.Cqt.Count():#,###}.");			
								AnsiConsole.MarkupLine($"PBC count: Expected: {current.PieceBarcodeRecordCount:#,###}, Actual {context.Pbc.Count():#,###}.");
								AnsiConsole.MarkupLine($"OCI count: Expected: {current.OriginalContainerIdentificationRecordCount:#,###}, Actual {context.Oci.Count():#,###}.");
							}
						}

						//
						// Dispose the context.
						//
						context.Dispose();
					});
			}
			else
			{
				AnsiConsole.MarkupLine($"[red]The file '{options.SourceFilePath.FullName}' does not exist.[/]");
				returnValue = 1;
			}

			return returnValue;
		}

		/// <summary>
		/// Renders a custom progress display by combining a header and the provided renderable content.
		/// </summary>
		/// <remarks>The header panel is styled with a rounded border and a sky-blue border color. The method combines
		/// the header and the provided renderable content into a single layout using a <see cref="Rows"/>
		/// container.</remarks>
		/// <param name="tasks">A read-only list of progress tasks. This parameter is currently unused but may be utilized in future
		/// implementations.</param>
		/// <param name="renderable">The renderable content to display below the header. Cannot be null.</param>
		/// <returns>A composite renderable object that includes a header panel labeled "Progress" and the provided renderable content.</returns>
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
