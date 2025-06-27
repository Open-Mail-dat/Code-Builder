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
	/// Defines the interface for exporting maildat files.
	/// </summary>
	public interface IMaildatExport
	{
		/// <summary>
		/// Exports data asynchronously based on the specified export options.
		/// </summary>
		/// <remarks>The export operation is performed asynchronously and may involve I/O operations. Ensure that the
		/// provided <paramref name="options"/> object is properly configured to avoid errors.</remarks>
		/// <param name="options">The export options that define the configuration and parameters for the export operation. Cannot be <see
		/// langword="null"/>.</param>
		/// <returns>A task that represents the asynchronous export operation. The task result is <see langword="true"/> if the export
		/// completes successfully; otherwise, <see langword="false"/>.</returns>
		Task<bool> ExportAsync(IExportOptions options);
	}
}
