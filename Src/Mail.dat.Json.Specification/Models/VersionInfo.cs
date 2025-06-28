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
	/// Represents version information for an entity, including major version and revision details.
	/// </summary>
	/// <remarks>This class is typically used to encapsulate versioning details for objects or entities that require
	/// version tracking. The <see cref="Major"/> property indicates the primary version, while the <see cref="Revision"/>
	/// property provides additional granularity for identifying specific revisions.</remarks>
	[DebuggerDisplay("Major = {Major}, Revision = {Revision}")]
	public class VersionInfo
	{
		/// <summary>
		/// Gets or sets the major version of the entity.
		/// </summary>
		[JsonProperty("major")]
		public string Major { get; set; }

		/// <summary>
		/// Gets or sets the revision identifier for the object.
		/// </summary>
		[JsonProperty("revision")]
		public string Revision { get; set; }
	}
}
