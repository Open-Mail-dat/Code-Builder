using Mail.dat.Io.Models;

namespace Mail.dat.Io
{
	internal class FileImporter
	{
		public ProgressUpdateAsyncDelegate ProgressUpdateAsync { get; set; }

		public async Task<bool> ImportAsync<T>(IImportOptions options, MaildatContext context, CancellationToken cancellationToken) where T : class, IMaildatEntity, new()
		{
			bool returnValue = false;

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
							// Loop through the file and read each line.
							//
							await foreach ((int lineNumber, byte[] buffer) in reader.ReadMaildatFileAsync(lineLength, lineEndingCharacters, closingCharacter, cancellationToken))
							{

								if (cancellationToken.IsCancellationRequested)
								{
									//
									// The import was cancelled. Break out of the loop.
									//
									await this.FireProgressUpdateAsync(new ImportMessage() { Type = ImportMessageType.Message, Message = "Import cancelled." });
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
									ILoadError[] errors = model.LoadData(lineNumber, buffer);

									//
									// Add the model to the context.
									//
									lock (context)
									{
										context.Add(model.Touch());
									}

									//
									// Check for errors.
									//
									if (errors.Length != 0)
									{
										//
										// Load the errors into the context.
										//
										foreach (ILoadError error in errors)
										{
											//
											// Build the import error model.
											//
											ImportError ie = new()
											{
												File = extension,
												FieldName = error.Attribute.FieldName,
												FieldCode = error.Attribute.FieldCode,
												DataType = error.Attribute.DataType,
												Type = error.Attribute.Type,
												StartPosition = error.Attribute.Start,
												Length = error.Attribute.Length,
												Value = error.Value,
												ErrorMessage = error.ErrorMessage,
												LineNumber = lineNumber
											};

											//
											// Add it to the context.
											//
											lock (context)
											{
												context.Add(ie.Touch());
											}
										}
									}

									//
									// Send a progress update.
									//
									await this.FireProgressUpdateAsync(new ImportMessage() { Type = ImportMessageType.Progress, Name = name, File = filePath, LineNumber = lineNumber, LineCount = lineCount });
								}
							}

							if (options.SaveMode == SaveModeType.SaveAfterEachFile)
							{								
								//
								// Save the changes to the database.
								//
								lock (context)
								{
									context.SaveChanges();
								}
							}
						}
					}
				}
			}

			return returnValue;
		}

		protected Task FireProgressUpdateAsync(IImportMessage message)
		{
			this.ProgressUpdateAsync?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}