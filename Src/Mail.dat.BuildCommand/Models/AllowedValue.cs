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
	/// Represents a key-value pair with an associated version, used to define an allowed value in a specific context.
	/// </summary>
	/// <remarks>This class is typically used to store and manage configuration or validation data, where each
	/// allowed value is identified by a unique key, its corresponding value, and an optional version for tracking
	/// changes.</remarks>
	public class AllowedValue
	{
		/// <summary>
		/// Gets or sets the version information for the application or component.
		/// </summary>
		public VersionInfo Version { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier associated with the object.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the value represented by this instance.
		/// </summary>
		public string Value { get; set; }
	}
}
