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
using System.ComponentModel.DataAnnotations.Schema;
using Diamond.Core.Repository;

namespace Mail.dat
{
	/// <summary>
	/// Represents the base class for entities in the Mail.dat system, providing common functionality  for importing and
	/// exporting data associated with Mail.dat records.
	/// </summary>
	/// <remarks>This abstract class serves as a foundation for Mail.dat entities, encapsulating shared properties 
	/// and methods for handling data import and export operations. Derived classes can override the  <see
	/// cref="OnImportDataAsync"/> and <see cref="OnExportDataAsync"/> methods to implement  custom behavior for specific
	/// entity types.</remarks>
	public abstract class MaildatEntity : Entity, IMaildatEntity
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the line number in the file associated with this record.
		/// </summary>
		[Column("FileLineNumber", Order = 1)]
		public int FileLineNumber { get; set; }

		/// <summary>
		/// Imports data asynchronously by processing a single line of input.
		/// </summary>
		/// <remarks>This method delegates the actual import logic to the <see cref="OnImportDataAsync"/> method,
		/// which can be overridden in derived classes to customize the import behavior. Callers should handle any errors
		/// returned in the result to ensure data integrity.</remarks>
		/// <param name="version">The version of the data format being imported. This value determines how the input line is interpreted.</param>
		/// <param name="lineNumber">The line number of the input data, used for tracking or error reporting purposes. Must be a non-negative integer.</param>
		/// <param name="line">A read-only span of bytes representing the data to be imported. The content and encoding of the data must conform
		/// to the specified <paramref name="version"/>.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is an array of <see cref="ILoadError"/>
		/// objects,  where each element describes an error encountered during the import process. If no errors occur, the
		/// array will be empty.</returns>
		public virtual Task<ILoadError[]> ImportDataAsync(string version,int lineNumber, ReadOnlySpan<byte> line)
		{
			return this.OnImportDataAsync(version, lineNumber, line);
		}

		/// <summary>
		/// Exports data in the specified format version asynchronously.
		/// </summary>
		/// <remarks>The specific behavior of the export operation, including the format and content of the exported
		/// data, depends on the implementation of the method.</remarks>
		/// <param name="version">The version of the data format to use for the export. This value determines the structure and content of the
		/// exported data.</param>
		/// <returns>A task that represents the asynchronous operation. The task result contains the exported data as a string.</returns>
		public virtual Task<string> ExportDataAsync(string version)
		{
			return this.OnExportDataAsync(version);
		}

		/// <summary>
		/// Handles the import of a single line of data during a data loading operation.
		/// </summary>
		/// <remarks>This method is intended to be overridden in a derived class to provide custom logic for 
		/// processing individual lines of data. The default implementation returns an empty array,  indicating no
		/// errors.</remarks>
		/// <param name="version">The version of the data format being imported.</param>
		/// <param name="lineNumber">The line number of the data being processed, starting from 1.</param>
		/// <param name="line">A read-only span of bytes representing the data content of the line.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is an array of  <see cref="ILoadError"/>
		/// objects indicating any errors encountered while processing the line.  If no errors occur, the array will be empty.</returns>
		protected virtual Task<ILoadError[]> OnImportDataAsync(string version, int lineNumber, ReadOnlySpan<byte> line)
		{
			return Task.FromResult<ILoadError[]>([]);
		}

		/// <summary>
		/// Exports data in the specified format version.
		/// </summary>
		/// <remarks>This method is intended to be overridden in a derived class to provide custom export logic.  The
		/// default implementation returns <see langword="null"/>.</remarks>
		/// <param name="version">The version of the data format to use for the export. This value determines the structure and content of the
		/// exported data.</param>
		/// <returns>A task that represents the asynchronous operation. The task result contains the exported data as a string,  or
		/// <see langword="null"/> if no data is available for export.</returns>
		protected virtual Task<string> OnExportDataAsync(string version)
		{
			return Task.FromResult<string>(null);
		}
	}
}
