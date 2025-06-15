using Mail.dat.Io.Models;

namespace Mail.dat.Io
{
	internal class SingleFileExporter
	{
		public ProgressAsyncDelegate ProgressUpdateAsync { get; set; }

		public async Task<bool> ExportAsync<T>(IExportOptions options, string version, Type entityType, IQueryable<IMaildatEntity> items, CancellationToken cancellationToken) where T : class, IMaildatEntity, new()
		{
			bool returnValue = true;

			int lineCount = items.Count();

			if (lineCount > 0)
			{
				//
				// Get the MaildatFileAttribute attribute.
				//
				MaildatFileAttribute classAttribute = typeof(T).GetAttribute<MaildatFileAttribute>();

				//
				// Get the path for the export file.
				//
				string filePath = $"{Path.GetDirectoryName(options.TargetFile.FilePath)}/{Path.GetFileNameWithoutExtension(options.TargetFile.FilePath)}.{classAttribute.Extension}";
				DirectoryInfo targetDirectoy = new(options.TargetFile.FilePath);

				//
				// Create the target directory if it does not exist.
				//
				if (!targetDirectoy.Exists)
				{
					targetDirectoy.Create();
				}

				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Start, WillShowProgress = true, ItemSource = filePath, ItemIndex = 1, ItemCount = lineCount });

				//
				// Delete the target file if it exists.
				//
				if (File.Exists(filePath))
				{
					File.Delete(filePath);
				}

				//
				// Open the file for reading.
				//
				using (FileStream io = new(filePath, FileMode.CreateNew, FileAccess.Write))
				{
					//
					// Write the file in binary mode.
					//
					using (StreamWriter writer = new(io, options.Encoding))
					{
						int lineNumber = 1;

						foreach (IMaildatEntity item in items.OrderBy(t => t.FileLineNumber))
						{
							string line = await item.ExportDataAsync(version) + options.LineTerminator;
							writer.Write(line);

							//
							// Send a progress update.
							//
							await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Progress, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineNumber++, ItemCount = lineCount });
						}

						await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = classAttribute.File, ItemAction = ProgressMessageType.Completed, WillShowProgress = true, ItemSource = filePath, ItemIndex = lineCount, ItemCount = lineCount });
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