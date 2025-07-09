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
namespace Mail.dat.ExportCommand
{
	/// <summary>
	/// Represents the options required to execute a command, including source and target file paths.
	/// </summary>
	/// <remarks>This class is used to define the input parameters for a command-line operation.  Both the source
	/// and target file paths are required and must be valid file paths.</remarks>
	internal class CommandOptions
	{
		/// <summary>
		/// Gets or sets the full target file path for the SQLite database.
		/// </summary>
		/// <remarks>This property is required and must be set to a valid file path. The file path should point to the
		/// target SQLite database file.</remarks>
		[Required]
		[Display(Order = 1, Name = "source-file-path", ShortName = "s", Description = "Specifies the full target file path for the Sqlite database.")]
		public FileInfo SourceFilePath { get; set; }

		/// <summary>
		/// Gets or sets the full path to the Mail.dat file to export.
		/// </summary>
		/// <remarks>This property is required and must specify a valid file path.  Ensure the path points to either a
		/// ZIP file or an HDR file.</remarks>
		[Required]
		[Display(Order = 2, Name = "target-file-path", ShortName = "t", Description = "Specifies the full path to the Mail.dat file to Export. The path should point to a ZIP file or the HDR file.")]
		public FileInfo TargetFilePath { get; set; }
	}
}
