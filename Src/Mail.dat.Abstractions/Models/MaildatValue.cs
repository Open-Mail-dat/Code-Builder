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

namespace Mail.dat.Abstractions
{
	/// <summary>
	/// Represents a value in the Mail.dat system, including metadata such as version, key, file extension, and field
	/// details.
	/// </summary>
	/// <remarks>This class is used to store and manage information about specific Mail.dat fields, including their
	/// version, unique key, file extension, description, and field metadata. Instances of this class are typically used in
	/// contexts where Mail.dat field definitions need to be processed or referenced.</remarks>
	public class MaildatValue
	{
		/// <summary>
		/// Gets or sets the version identifier for the entity.
		/// </summary>
		[Key]
		public string Version { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for the entity.
		/// </summary>
		[Key]
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the file extension associated with the file.
		/// </summary>
		public string FileExtension { get; set; }

		/// <summary>
		/// Gets or sets the description associated with the object.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the code representing the field in the Mail.dat system.
		/// </summary>
		public string FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the name of the field in the Mail.dat system.
		/// </summary>
		public string FieldName { get; set; }
	}
}
