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
namespace Mail.dat
{
	/// <summary>
	/// Represents an error encountered during the loading of a value associated with a specific attribute.
	/// </summary>
	/// <remarks>This interface is used to encapsulate details about a load error, including the attribute that
	/// caused the error, the value that was being processed, and a descriptive error message.</remarks>
	public interface ILoadError
	{
		/// <summary>
		/// Gets or sets the attribute associated with the Maildat field.
		/// </summary>
		MaildatFieldAttribute Attribute { get; set; }

		/// <summary>
		/// Gets or sets the value associated with this instance.
		/// </summary>
		string Value { get; set; }

		/// <summary>
		/// Gets or sets the error message associated with the current operation or state.
		/// </summary>
		string ErrorMessage { get; set; }
	}
}
