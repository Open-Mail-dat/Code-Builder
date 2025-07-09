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
using System.Text;
using Diamond.Core.CommandLine.Model;
using Humanizer;
using Mail.dat.Io;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Mail.dat.ExportCommand
{
	/// <summary>
	/// Represents a command handler for exporting a Mail.dat file from a Sqlite database.
	/// </summary>
	internal class ExportCommandHandler : ModelCommand<CommandOptions>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExportCommandHandler"/> class.
		/// </summary>
		/// <param name="logger">The logger instance for logging information.</param>
		public ExportCommandHandler(ILogger<ExportCommandHandler> logger)
			: base(logger, "export", "Export a Mail.dat from a Sqlite database.")
		{
		}

		/// <summary>
		/// Handles the execution of the command with the specified options.
		/// </summary>
		/// <remarks>This method processes the specified source file, displaying progress information in the console.
		/// If the source file does not exist, an error message is displayed, and the method returns an exit code of
		/// 1.</remarks>
		/// <param name="options">The options provided for the command execution, including file paths and other parameters.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is an integer indicating the exit code: 0 if
		/// the operation completes successfully; otherwise, 1 if an error occurs.</returns>
		protected override async Task<int> OnHandleCommand(CommandOptions options)
		{
			int returnValue = 0;

			//
			// Check if the source file exists. If it does, proceed with the export.
			//
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
				//
				// If the source file does not exist, display an error message.
				//
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
