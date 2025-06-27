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
	/// Defines a contract for importing Mail.dat files into a processing context.
	/// </summary>
	/// <remarks>This interface provides a method to import Mail.dat files using the specified options.  The result
	/// indicates whether the import was successful and provides a context object  containing details about the imported
	/// data.</remarks>
	public interface IMaildatImport
	{
		/// <summary>
		/// Imports data asynchronously based on the specified import options.
		/// </summary>
		/// <remarks>The method performs an asynchronous import operation using the provided options. The caller can
		/// use the  returned <MaildatContext> to access details about the imported data. If the import fails, the 
		/// <MaildatContext> may be <null>.</remarks>
		/// <param name="options">The options that configure the import operation. This parameter cannot be null.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is a tuple where the first value is a  <bool>
		/// indicating whether the import was successful, and the second value is a  <MaildatContext> containing the context
		/// of the imported data.</returns>
		Task<(bool, MaildatContext)> ImportAsync(IImportOptions options);
	}
}
