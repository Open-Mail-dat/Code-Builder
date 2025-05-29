using EFCore.BulkExtensions;
using Mail.dat.Io.Models;

namespace Mail.dat.Io
{
	internal class FileImporter
	{
		public ProgressAsyncDelegate ProgressUpdateAsync { get; set; }

		public async Task<bool> ImportAsync<T>(IImportOptions options, MaildatContext context, CancellationToken cancellationToken) where T : class, IMaildatEntity, new()
		{
			bool returnValue = true;

			//
			// Get the MaildatFileAttribute attribute.
			//
			MaildatFileAttribute classAttribute = typeof(T).GetAttribute<MaildatFileAttribute>();

			if (classAttribute != null && !(classAttribute.Extension == "pbc" && options.SkipPbcFile))
			{
				//
				// Get the header file
				//
				int lineLength = classAttribute.LineLength;
				string extension = classAttribute.Extension;
				string closingCharacter = classAttribute.ClosingCharacter;
				string name = classAttribute.File;
				string filePath = options.File.GetFile(extension);

				if (File.Exists(filePath))
				{
					//
					// Get the line ending character(s). These can be empty.
					//
					string lineEndingCharacters = filePath.DetectLineEnding();

					//
					// Get the line count. This is used to update the progress bar.
					//
					int lineCount = (int)(new FileInfo(filePath)).Length / (lineLength + lineEndingCharacters.Length);

					//
					// Open the file for reading.
					//
					using (FileStream io = new(filePath, FileMode.Open, FileAccess.Read))
					{
						//
						// Read the file in binary mode.
						//
						using (BinaryReader reader = new(io))
						{
							//
							// Create  list for the modesl, they will
							// all be bulk inserted at the end.
							//
							List<T> models = new(lineCount);

							await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Start, WillShowProgress = true, ItemSource = filePath, ItemIndex = 1, ItemCount = lineCount, Context = classAttribute });

							//
							// Loop through the file and read each line.
							//
							await foreach ((int lineNumber, byte[] buffer) in reader.ReadMaildatFileAsync(lineLength, lineEndingCharacters, closingCharacter, cancellationToken))
							{
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
									ILoadError[] errors = await model.ImportDataAsync(lineNumber, buffer.AsSpan());

									//
									// Add the model to the context.
									//
									models.Add(model);

									//
									// Check for errors.
									//
									if (errors.Length != 0)
									{
										//
										// Load the errors into the context.
										//
										context.Errors.AddRange((from tbl in errors
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
																 }).Select(m => m.Touch()).ToList());
									}

									//
									// Send a progress update.
									//
									await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Progress, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineNumber, ItemCount = lineCount, Context = classAttribute });
								}
							}

							//
							// Using the EFCore.BulkExtensions.Sqlite package to perform a bulk insert
							// to improve performacne.
							//
							await context.BulkInsertAsync(models, cancellationToken: cancellationToken);

							//
							// Send the completed update.
							//
							_ = this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Completed, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineCount, ItemCount = lineCount, Context = classAttribute });
						}
					}
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