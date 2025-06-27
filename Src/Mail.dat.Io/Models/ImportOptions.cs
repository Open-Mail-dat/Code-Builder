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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	/// <summary>
	/// Represents the options used to configure the import process for a maildat file.
	/// </summary>
	/// <remarks>This class provides various settings to control the behavior of the import process,  including file
	/// paths, logging, cancellation, and performance-related preferences.</remarks>
	public class ImportOptions : IImportOptions
	{
		/// <summary>
		/// Gets or sets the source file associated with the maildat operation.
		/// </summary>
		public IMaildatFile SourceFile { get; set; }

		/// <summary>
		/// Gets or sets the path to the target file.
		/// </summary>
		/// <remarks>Ensure the file path is valid and accessible before setting this property.  Relative paths will
		/// be resolved based on the application's working directory.</remarks>
		public string TargetFile { get; set; }

		/// <summary>
		/// Gets or sets the path to the temporary directory used for storing intermediate or temporary files.
		/// </summary>
		/// <remarks>Ensure that the specified directory exists and is writable to avoid runtime errors when accessing
		/// or creating files in this location.</remarks>
		public string TemporaryDirectory { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="CancellationToken"/> used to propagate notification that operations should be
		/// canceled.
		/// </summary>
		public CancellationToken CancellationToken { get; set; } = CancellationToken.None;

		/// <summary>
		/// Gets or sets the logger used to log messages related to import options.
		/// </summary>
		public ILogger<IImportOptions> Logger { get; set; } = new NullLogger<IImportOptions>();

		/// <summary>
		/// Gets or sets a value indicating whether the PBC (Piece barcode details) process should be skipped.
		/// </summary>
		public bool SkipPbc { get; set; } = false;
		
		/// <summary>
		/// Gets or sets a value indicating whether the system should prioritize memory usage over performance.
		/// </summary>
		/// <remarks>When set to <see langword="true"/>, the system may use strategies that reduce memory consumption,
		/// which could result in slower execution times. Conversely, setting this property to  <see langword="false"/>
		/// prioritizes performance, potentially increasing memory usage.</remarks>
		public bool FavorMemoryOverPerformance { get; set; }

		/// <summary>
		/// Gets or sets the maximum number of records that can be stored in memory at a given time.
		/// </summary>
		/// <remarks>Adjust this value based on the application's memory constraints and performance requirements.
		/// Setting a higher value may increase memory usage, while a lower value may limit the number of records that can be
		/// processed or cached in memory.</remarks>
		public int MaxRecordsInMemory { get; set; } = 10_000;
	}
}
