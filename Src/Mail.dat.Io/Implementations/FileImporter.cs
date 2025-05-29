using System.IO.MemoryMappedFiles;
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
				string extension = classAttribute.Extension;
				string filePath = options.File.GetFile(extension);

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
					List<T> models = new(lineCount);
					List<Error> errors = [];

					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Start, WillShowProgress = true, ItemSource = filePath, ItemIndex = 1, ItemCount = lineCount, Context = classAttribute });

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
									ILoadError[] loadErrors = await model.ImportDataAsync(lineNumber, buffer.AsSpan());

									//
									// Add the model to the context.
									//
									models.Add(model);

									//
									// Check for errors.
									//
									if (loadErrors.Length != 0)
									{
										//
										// Load the errors into the context.
										//
										errors.AddRange((from tbl in loadErrors
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
														 }).Select(m => m.Touch()));
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
					await context.BulkInsertAsync(models, cancellationToken: cancellationToken);

					//
					// Check for errors and insert them into the context.
					//
					if (errors.Count > 0)
					{
						//
						// Add the errors to the context.
						//
						await context.BulkInsertAsync(errors, cancellationToken: cancellationToken);
					}

					//
					// Send the completed update.
					//
					_ = this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Completed, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineCount, ItemCount = lineCount, Context = classAttribute });

					//
					// Open the file for reading.
					//
					//using (FileStream io = new(filePath, FileMode.Open, FileAccess.Read))
					//{
					//	//
					//	// Read the file in binary mode.
					//	//
					//	using (BinaryReader reader = new(io))
					//	{
					//		//
					//		// Create  list for the modesl, they will
					//		// all be bulk inserted at the end.
					//		//
					//		List<T> models = new(lineCount);

					//		await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Start, WillShowProgress = true, ItemSource = filePath, ItemIndex = 1, ItemCount = lineCount, Context = classAttribute });

					//		//
					//		// Loop through the file and read each line.
					//		//
					//		await foreach ((int lineNumber, byte[] buffer) in reader.ReadMaildatFileAsync(lineLength, lineEndingCharacters, closingCharacter, cancellationToken))
					//		{
					//			if (cancellationToken.IsCancellationRequested)
					//			{
					//				//
					//				// The import was cancelled. Break out of the loop.
					//				//
					//				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Import", ItemAction = ProgressMessageType.Completed, Message = "Import cancelled.", Context = classAttribute });
					//			}
					//			else
					//			{
					//				//
					//				// Create the new model.
					//				//
					//				T model = new();

					//				//
					//				// Load the data into the model.
					//				//
					//				ILoadError[] errors = await model.ImportDataAsync(lineNumber, buffer.AsSpan());

					//				//
					//				// Add the model to the context.
					//				//
					//				models.Add(model);

					//				//
					//				// Check for errors.
					//				//
					//				if (errors.Length != 0)
					//				{
					//					//
					//					// Load the errors into the context.
					//					//
					//					context.Errors.AddRange((from tbl in errors
					//											 select new Error
					//											 {
					//												 Process = "Import",
					//												 File = extension,
					//												 FieldName = tbl.Attribute.FieldName,
					//												 FieldCode = tbl.Attribute.FieldCode,
					//												 DataType = tbl.Attribute.DataType,
					//												 Type = tbl.Attribute.Type,
					//												 StartPosition = tbl.Attribute.Start,
					//												 Length = tbl.Attribute.Length,
					//												 Value = tbl.Value,
					//												 ErrorMessage = tbl.ErrorMessage,
					//												 LineNumber = lineNumber
					//											 }).Select(m => m.Touch()).ToList());
					//				}

					//				//
					//				// Send a progress update.
					//				//
					//				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Progress, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineNumber, ItemCount = lineCount, Context = classAttribute });
					//			}
					//		}

					//		//
					//		// Using the EFCore.BulkExtensions.Sqlite package to perform a bulk insert
					//		// to improve performacne.
					//		//
					//		await context.BulkInsertAsync(models, cancellationToken: cancellationToken);

					//		//
					//		// Send the completed update.
					//		//
					//		_ = this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = name, ItemAction = ProgressMessageType.Completed, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineCount, ItemCount = lineCount, Context = classAttribute });
					//	}
					//}
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