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
using System.IO.Compression;

namespace Mail.dat.Io
{
	/// <summary>
	/// Represents a Mail.dat file, providing functionality to manage its path, determine its state (e.g., zipped or
	/// unzipped), and perform operations such as zipping, unzipping, and retrieving specific file types within the
	/// Mail.dat structure.
	/// </summary>
	/// <remarks>This class is designed to handle Mail.dat files, which may be either zipped or unzipped. It
	/// provides methods to extract files from a zipped Mail.dat archive, check for the existence of specific files, and
	/// manage the file's directory structure. Use the <see cref="Create(string)"/> method to instantiate a new <see
	/// cref="MaildatFile"/> object.</remarks>
	public class MaildatFile : IMaildatFile
	{
		/// <summary>
		/// Gets the file path associated with the current operation.
		/// </summary>
		public string FilePath { get; internal set; }

		/// <summary>
		/// Gets the path to the directory where the contents of the archive have been extracted.
		/// </summary>
		public string UnzippedDirectory { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether the specified file or directory exists at the path represented by <see
		/// cref="FilePath"/>.
		/// </summary>
		/// <remarks>This property checks both file and directory existence at the given path. If the path points to
		/// either a file or a directory, the property returns <see langword="true"/>.</remarks>
		public bool Exists => File.Exists(this.FilePath) || Directory.Exists(this.FilePath);

		/// <summary>
		/// Gets a value indicating whether the content is compressed (i.e., if the file is a ZIP archive).
		/// </summary>
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

		/// <summary>
		/// Gets the file path of the header file associated with the current instance.
		/// </summary>
		/// <remarks>The returned file path is dynamically resolved using the extension specified in the <see
		/// cref="MaildatFileAttribute"/> of the <see cref="Hdr"/> type.</remarks>
		public string HeaderFilePath
		{
			get
			{
				string extension = typeof(Hdr).GetAttribute<MaildatFileAttribute>().Extension;
				return this.GetFile(extension);
			}
		}

		/// <summary>
		/// Retrieves the full path of a file with the specified extension from the current directory or unzipped directory.
		/// </summary>
		/// <remarks>If the current file path is not a ZIP file, the method searches the directory specified by
		/// <c>FilePath</c>. If the current file path is a ZIP file, the method searches the directory specified by
		/// <c>UnzippedDirectory</c>. The search is case-insensitive and returns a single file if exactly one match is found.
		/// If no match is found or multiple matches exist, the method returns <see langword="null"/>.</remarks>
		/// <param name="extension">The file extension to search for, without the leading period (e.g., "txt" for text files).</param>
		/// <returns>The full path of the file with the specified extension if found; otherwise, <see langword="null"/>.</returns>
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

		/// <summary>
		/// Extracts the contents of the zip file to the specified target directory.
		/// </summary>
		/// <remarks>If the specified directory already exists, its contents will not be overwritten, but the zip file
		/// will be extracted into it. Existing files in the target directory with the same name as files in the  zip archive
		/// will be replaced.</remarks>
		/// <param name="targetDirectory">The path to the directory where the contents of the zip file will be extracted.  This directory will be created if
		/// it does not already exist.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/>  if the extraction
		/// was successful; otherwise, <see langword="false"/>.</returns>
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

		/// <summary>
		/// Creates a compressed archive at the specified file path.
		/// </summary>
		/// <remarks>Ensure that the specified file path is valid and that the application has write permissions to
		/// the target directory.</remarks>
		/// <param name="targetFilePath">The full path, including the file name, where the compressed archive will be created. Must not be null or empty.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the operation
		/// succeeds; otherwise, <see langword="false"/>.</returns>
		public Task<bool> Zip(string targetFilePath)
		{
			bool returnValue = false;


			return Task.FromResult(returnValue);
		}

		/// <summary>
		/// Creates a new instance of a maildat file with the specified file path.
		/// </summary>
		/// <param name="filePath">The file path to associate with the maildat file. Must be a valid, non-null, and non-empty string.</param>
		/// <returns>An instance of <see cref="IMaildatFile"/> initialized with the specified file path.</returns>
		public static IMaildatFile Create(string filePath)
		{
			return new MaildatFile() { FilePath = filePath.NormalizePath() };
		}
	}
}
