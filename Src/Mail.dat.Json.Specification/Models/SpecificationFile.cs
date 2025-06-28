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
using Newtonsoft.Json;

namespace Mail.dat.Json.Specification
{
	/// <summary>
	/// Represents a specification file containing version information and a collection of file definitions.
	/// </summary>
	/// <remarks>This class is designed to manage metadata and configuration details for a specification file.  It
	/// provides access to version information and a collection of file definitions, which are  automatically ordered by
	/// file extension when retrieved.</remarks>
	[DebuggerDisplay("Version = {Version}, File Count = {Files.Length}")]
	public class SpecificationFile
	{
		/// <summary>
		/// Gets or sets the version information for the current object.
		/// </summary>
		[JsonProperty("version")]
		public VersionInfo Version { get; set; }

		
		/// <summary>
		/// Gets or sets the collection of file definitions, ordered by file extension when retrieved.
		/// </summary>
		[JsonProperty("files")]
		public FileDefinition[] Files { get; set; }
	}
}
