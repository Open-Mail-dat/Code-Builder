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

namespace Mail.dat.Io
{
	/// <summary>
	/// Defines the options used to configure the import process for a maildat file.
	/// </summary>
	/// <remarks>This interface provides properties to specify the source file, target file, temporary directory,
	/// logging behavior, and other settings that influence the import process. Implementations of this interface are
	/// expected to encapsulate all necessary configuration for the import operation.</remarks>
	public interface IImportOptions
	{
		/// <summary>
		/// Gets or sets the source file associated with the maildat operation.
		/// </summary>
		/// <remarks>The source file is used as the input for maildat-related operations. Ensure that the file is
		/// properly initialized and accessible before setting this property.</remarks>
		IMaildatFile SourceFile { get; set; }

		/// <summary>
		/// Gets or sets the path to the temporary directory used for storing intermediate or temporary files.
		/// </summary>
		string TemporaryDirectory { get; set; }

		/// <summary>
		/// Gets or sets the path to the target file.
		/// </summary>
		string TargetFile { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the PBC (Piece barcode details) step should be skipped.
		/// </summary>
		bool SkipPbc { get; set; }

		/// <summary>
		/// Gets or sets the logger used to record messages and events related to import options.
		/// </summary>
		ILogger<IImportOptions> Logger { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="System.Threading.CancellationToken"/> used to signal cancellation of an operation.
		/// </summary>
		CancellationToken CancellationToken { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the system should prioritize memory usage over performance.
		/// </summary>
		/// <remarks>This property allows the caller to control the trade-off between memory efficiency and
		/// performance.  Setting this to <see langword="true"/> may result in slower operations but reduced memory
		/// consumption,  while setting it to <see langword="false"/> may improve performance at the cost of higher memory
		/// usage.</remarks>
		bool FavorMemoryOverPerformance { get; set; }

		/// <summary>
		/// Gets or sets the maximum number of records that can be held in memory at a given time.
		/// </summary>
		int MaxRecordsInMemory { get; set; }
	}
}
