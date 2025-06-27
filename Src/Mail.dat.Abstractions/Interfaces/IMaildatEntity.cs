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
using Diamond.Core.Repository;

namespace Mail.dat
{
	/// <summary>
	/// Represents a Mail.dat entity that can import and export data in a specific format.
	/// </summary>
	/// <remarks>This interface defines methods for importing and exporting data for Mail.dat entities,  as well as
	/// a property to track the file line number associated with the entity. Implementations are expected to handle data
	/// parsing and formatting based on the provided version.</remarks>
	public interface IMaildatEntity : IEntity<int>
	{
		/// <summary>
		/// Gets or sets the line number in the file associated with the current operation or context.
		/// </summary>
		int FileLineNumber { get; set; }

		/// <summary>
		/// Asynchronously imports data from a specified line of input and returns any errors encountered during the process.
		/// </summary>
		/// <remarks>This method processes a single line of input data in the specified format version. Ensure that
		/// the input data adheres to the expected format for the given version to avoid errors. The method is designed to
		/// handle large volumes of data efficiently by working with spans.</remarks>
		/// <param name="version">The version of the data format being imported. This determines how the input is interpreted.</param>
		/// <param name="lineNumber">The line number of the input data, used for error reporting and tracking.</param>
		/// <param name="line">A read-only span of bytes representing the line of input data to be processed.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is an array of <see cref="ILoadError"/> objects
		/// containing details of any errors encountered during the import. If no errors occur, the array will be empty.</returns>
		Task<ILoadError[]> ImportDataAsync(string version, int lineNumber, ReadOnlySpan<byte> line);

		/// <summary>
		/// Exports data in the specified format version asynchronously.
		/// </summary>
		/// <remarks>Use this method to export data in a specific format version. Ensure that the provided version is
		/// supported by the system. The returned string contains the exported data, which can be saved or processed
		/// further.</remarks>
		/// <param name="version">The version of the data format to use for the export. This value must be a valid version string.</param>
		/// <returns>A task that represents the asynchronous operation. The task result contains the exported data as a string.</returns>
		Task<string> ExportDataAsync(string version);
	}
}