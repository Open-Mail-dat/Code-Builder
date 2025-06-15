using System.IO.MemoryMappedFiles;
using EFCore.BulkExtensions;
using Mail.dat.Io.Models;

namespace Mail.dat.Io
{
	internal class SingleFileImporter
	{
		public ProgressAsyncDelegate ProgressUpdateAsync { get; set; }

		public async Task<bool> ImportAsync<T>(IImportOptions options, string version, MaildatContext context, CancellationToken cancellationToken) where T : class, IMaildatEntity, new()
		{
			bool returnValue = true;

			//
			// Get the MaildatFileAttribute attribute.
			//
			MaildatFileAttribute classAttribute = typeof(T).GetAttribute<MaildatFileAttribute>();

			if (classAttribute != null && !(classAttribute.Extension == "pbc" && options.SkipPbc))
			{
				//
				// Get the header file
				//
				string extension = classAttribute.Extension;
				string filePath = options.SourceFile.GetFile(extension);

				if (File.Exists(filePath))
				{
					//
					// Get the line ending character(s). These can be empty.
					//
					string lineEndingCharacters = filePath.DetectLineEnding();
					int lineLength = classAttribute.LineLength + lineEndingCharacters.Length;

					//
					// Get the line count. This is used to update the progress bar.
					//
					int lineCount = (int)(new FileInfo(filePath)).Length / lineLength;

					//
					// Create  list for the modesl, they will
					// all be bulk inserted at the end.
					//
					List<T> modelBuffer = new(lineCount);
					List<Error> errorBuffer = [];

					//
					// Bulk inert cofiguration.
					//
					BulkConfig bc = new()
					{
						PreserveInsertOrder = false
					};

					//
					// Send the start progress update.
					//
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Start, WillShowProgress = true, ItemSource = filePath, ItemIndex = 1, ItemCount = lineCount, Context = classAttribute });

					//
					// Create a memory-mapped file to read the file in parallel.
					//
					using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(filePath, FileMode.Open, null))
					{
						//
						// Create a counter to keep track of the number of lines processed.
						//
						int processedCount = 0;

						//
						// Use Parallel.For to read the file in parallel.
						//
						Parallel.For(0, lineCount, async (lineNumber) =>
						{
							//
							// Calculate the offset for the line in the file.
							//
							long offset = lineNumber * lineLength;

							//
							// Create a view accessor for the line in the file.
							//
							using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor(offset, lineLength, MemoryMappedFileAccess.Read))
							{
								//
								// Create a buffer to read the file line into.
								//
								byte[] buffer = new byte[lineLength];

								//
								// Read the line from the file.
								//
								accessor.ReadArray(0, buffer, 0, lineLength);

								//
								// Increment the line counter for each line read.
								//
								Interlocked.Increment(ref processedCount);

								if (cancellationToken.IsCancellationRequested)
								{
									//
									// The import was cancelled. Break out of the loop.
									//
									await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Import", ItemAction = ProgressMessageType.Completed, Message = "Import cancelled.", Context = classAttribute });
								}
								else
								{
									//
									// Create the new model.
									//
									T model = new();

									//
									// Load the data into the model.
									//
									ILoadError[] loadErrors = await model.ImportDataAsync(version, lineNumber + 1, buffer.AsSpan());

									if (options.FavorMemoryOverPerformance)
									{
										lock (modelBuffer)
										{
											if (modelBuffer.Count > options.MaxRecordsInMemory)
											{
												modelBuffer.Add(model);
												context.BulkInsert(modelBuffer, bulkConfig: bc);
												modelBuffer.Clear();
											}
											else
											{
												//
												// Add the model to the context.
												//
												modelBuffer.Add(model);
											}
										}
									}
									else
									{
										lock (modelBuffer)
										{
											//
											// Add the model to the context.
											//
											modelBuffer.Add(model);
										}
									}

									//
									// Check for errors.
									//
									if (loadErrors.Length != 0)
									{
										//
										// Load the errors into the context.
										//
										errorBuffer.AddRange((from tbl in loadErrors
															  select new Error
															  {
																  Process = "Import",
																  File = extension,
																  FieldName = tbl.Attribute.FieldName,
																  FieldCode = tbl.Attribute.FieldCode,
																  DataType = tbl.Attribute.DataType,
																  Type = tbl.Attribute.Type,
																  StartPosition = tbl.Attribute.Start,
																  Length = tbl.Attribute.Length,
																  Value = tbl.Value,
																  ErrorMessage = tbl.ErrorMessage,
																  LineNumber = lineNumber
															  }).Select(m => m));
									}

									//
									// Send a progress update.
									//
									await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Progress, WillShowProgress = true, ItemSource = filePath, ItemIndex = processedCount, ItemCount = lineCount, Context = classAttribute });
								}
							}
						});
					}

					//
					// Using the EFCore.BulkExtensions.Sqlite package to perform a bulk insert
					// to improve performacne.
					//
					if (modelBuffer.Count > 0)
					{
						await context.BulkInsertAsync(modelBuffer, bulkConfig: bc, cancellationToken: cancellationToken);
					}

					//
					// Check for errors and insert them into the context.
					//
					if (errorBuffer.Count > 0)
					{
						//
						// Add the errors to the context.
						//
						await context.BulkInsertAsync(errorBuffer, bulkConfig: bc, cancellationToken: cancellationToken);
					}

					//
					// Send the completed update.
					//
					_ = this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Completed, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineCount, ItemCount = lineCount, Context = classAttribute });
				}
			}

			return returnValue;
		}

		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdateAsync?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}