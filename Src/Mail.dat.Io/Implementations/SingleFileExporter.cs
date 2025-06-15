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
// LICENSE (GNU Lesser General Public License)
// LICENSE-GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
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