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
using System.Diagnostics;

namespace Mail.dat.Json.Specification
{
	/// <summary>
	/// Represents an orderable file with an associated extension and position within a collection.
	/// </summary>
	/// <remarks>This class is typically used to manage files in a collection where both the file type (via its
	/// extension) and its position in the collection are important.</remarks>
	[DebuggerDisplay("Extension = {Extension}, Ordinal = {Ordinal}")]
	public class FileOrder
	{
		/// <summary>
		/// Gets or sets the file extension, including the leading period (e.g., ".txt").
		/// </summary>
		public string Extension { get; set; }

		/// <summary>
		/// Gets or sets the zero-based position of the item within a collection.
		/// </summary>
		public int Ordinal { get; set; }
	}
}
