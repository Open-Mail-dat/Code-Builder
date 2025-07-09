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
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Represents a collection of file-related definitions and associated version information.
	/// </summary>
	/// <remarks>This class encapsulates a file definition and its corresponding version details. It is typically
	/// used to manage and organize metadata about files in a structured format.</remarks>
	public class FileDefinitionList
	{
		/// <summary>
		/// Gets or sets the version information for the application or component.
		/// </summary>
		public VersionInfo Version { get; set; }

		/// <summary>
		/// Gets or sets the file definition that specifies the structure and metadata of a file.
		/// </summary>
		public FileDefinition FileDefinition { get; set; }
	}
}