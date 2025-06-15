//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
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
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.IO.Compression;

namespace Mail.dat.Io
{
	public class MaildatFile : IMaildatFile
	{
		public string FilePath { get; internal set; }
		public string UnzippedDirectory { get; internal set; }
		public bool Exists => File.Exists(this.FilePath) || Directory.Exists(this.FilePath);

		public bool IsZipped
		{
			get
			{
				bool returnValue = false;

				if (Path.GetExtension(this.FilePath).ToLower().Equals(".zip"))
				{
					if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
					{
						DirectoryInfo dir = new(this.UnzippedDirectory);
						returnValue = !dir.GetFiles().Where(t => t.Extension == ".hdr").Any();
					}
					else
					{
						returnValue = true;
					}
				}
				else
				{
					returnValue = false;
				}

				return returnValue;
			}
		}

		public string HeaderFilePath
		{
			get
			{
				string extension = typeof(Hdr).GetAttribute<MaildatFileAttribute>().Extension;
				return this.GetFile(extension);
			}
		}

		public string GetFile(string extension)
		{
			string returnValue = null;

			if (!Path.GetExtension(this.FilePath).ToLower().Equals(".zip"))
			{
				if (!string.IsNullOrWhiteSpace(this.FilePath))
				{
					DirectoryInfo dir = new(this.FilePath);

					if (dir.Exists)
					{
						returnValue = dir.GetFiles().Where(t => t.Extension.Equals($".{extension}", StringComparison.CurrentCultureIgnoreCase)).Select(t => t.FullName).SingleOrDefault();
					}
				}
			}
			else
			{
				if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
				{
					DirectoryInfo dir = new(this.UnzippedDirectory);

					if (dir.Exists)
					{
						returnValue = dir.GetFiles().Where(t => t.Extension.Equals($".{extension}", StringComparison.CurrentCultureIgnoreCase)).Select(t => t.FullName).SingleOrDefault();
					}
				}
			}

			return returnValue.NormalizePath();
		}

		public Task<bool> Unzip(string targetDirectory)
		{
			bool returnValue = false;

			//
			// Save the unzip path.
			//
			this.UnzippedDirectory = targetDirectory;

			if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
			{
				DirectoryInfo dir = new(this.UnzippedDirectory);
				dir.Create();
				ZipFile.ExtractToDirectory(this.FilePath, targetDirectory, true);
				returnValue = true;
			}

			return Task.FromResult(returnValue);
		}

		public Task<bool> Zip(string targetFilePath)
		{
			bool returnValue = false;


			return Task.FromResult(returnValue);
		}

		public static IMaildatFile Create(string filePath)
		{
			return new MaildatFile() { FilePath = filePath.NormalizePath() };
		}
	}
}
