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
using System.ComponentModel.DataAnnotations;

namespace Mail.dat.ImportCommand
{
	internal class CommandOptions
	{
		/// <summary>
		/// Gets or sets the full path to the Mail.dat file to import.
		/// </summary>
		/// <remarks>This property is required and must be set before attempting to process the file.</remarks>
		[Required]
		[Display(Order = 1, Name = "source-file-path", ShortName = "s", Description = "Specifies the full path to the Mail.dat file to import. The path should point to a ZIP file to the HDR file.")]
		public FileInfo SourceFilePath { get; set; }

		/// <summary>
		/// Gets or sets the full target file path for the SQLite database.
		/// </summary>
		/// <remarks>This property is required and must be set to a valid file path. The file path should point to the
		/// location where the SQLite database will be created or accessed.</remarks>
		[Required]
		[Display(Order = 2, Name = "target-file-path", ShortName = "t", Description = "Specifies the full target file path for the Sqlite database.")]
		public FileInfo TargetFilePath { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to skip the PBC file during import.
		/// </summary>
		[Display(Order = 3, Name = "skip-pbc", ShortName = "p", Description = "Specifies whether or not to skip the PBC file on import. The default is false.")]
		public bool SkipPbc { get; set; } = false;

		/// <summary>
		/// Gets or sets a value indicating whether to prioritize memory usage over performance.
		/// </summary>
		[Display(Order = 4, Name = "favor-memory-over-performance", ShortName = "f", Description = "Uses less memory at the cost of performance. When true, the import will take about 40% lobger but use much less memory. The default is false.")]
		public bool FavorMemoryOverPerformance { get; set; } = false;

		/// <summary>
		/// Gets or sets the maximum number of records held in memory before writing to the database and clearing memory.
		/// </summary>
		/// <remarks>This property is relevant only when the "favor-memory-over-performance" setting is enabled.
		/// Adjust this value based on  the application's memory constraints and performance requirements.</remarks>
		[Display(Order = 5, Name = "max-records-in-memory", ShortName = "m", Description = "When favor-memory-over-performance = true, sets the maxmimum number of records held in memory before writing to the databae and clearing memory. Smaller numbers uses less memory but result in slower performance. Higher numbers will use more memory but increase performance. The default is 10,000.")]
		public int MaxRecordsInMemory { get; set; } = 10_000;
	}
}