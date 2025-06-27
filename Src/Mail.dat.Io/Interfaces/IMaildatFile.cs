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
namespace Mail.dat.Io
{
	/// <summary>
	/// Represents a Mail.dat file and provides methods and properties for interacting with it.
	/// </summary>
	/// <remarks>A Mail.dat file is a collection of files used in the mailing industry to exchange mailing
	/// information. This interface provides functionality to check the file's existence, access its properties, and
	/// perform operations such as zipping and unzipping.</remarks>
	public interface IMaildatFile
	{
		/// <summary>
		/// Gets a value indicating whether the specified resource or entity exists.
		/// </summary>
		bool Exists { get; }

		/// <summary>
		/// Gets the file path associated with the current operation.
		/// </summary>
		string FilePath { get; }

		/// <summary>
		/// Gets a value indicating whether the content is compressed.
		/// </summary>
		bool IsZipped { get; }

		/// <summary>
		/// Gets the file path to the header file associated with the current operation.
		/// </summary>
		string HeaderFilePath { get; }

		/// <summary>
		/// Retrieves the name of a file with the specified extension.
		/// </summary>
		/// <param name="extension">The file extension to filter by. Must include the leading period (e.g., ".txt").</param>
		/// <returns>The name of the file with the specified extension, or <see langword="null"/> if no matching file is found.</returns>
		string GetFile(string extension);

		/// <summary>
		/// Gets the path to the directory where the contents of the archive have been extracted.
		/// </summary>
		string UnzippedDirectory { get; }

		/// <summary>
		/// Extracts the contents of a compressed file to the specified target directory.
		/// </summary>
		/// <param name="targetDirectory">The path to the directory where the contents will be extracted. Must not be null or empty.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the extraction
		/// succeeds; otherwise, <see langword="false"/>.</returns>
		Task<bool> Unzip(string targetDirectory);

		/// <summary>
		/// Compresses the current data into a zip archive and saves it to the specified file path.
		/// </summary>
		/// <remarks>Ensure that the specified file path is valid and that the application has write permissions to
		/// the target location.</remarks>
		/// <param name="targetFilePath">The full path, including the file name, where the zip archive will be saved. Must not be null or empty.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the compression
		/// succeeds; otherwise, <see langword="false"/>.</returns>
		Task<bool> Zip(string targetFilePath);
	}
}
