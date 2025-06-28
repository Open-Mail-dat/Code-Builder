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
	/// Represents a field definition within a Mail.dat file, including its code, name, position, length, and metadata.
	/// </summary>
	[DebuggerDisplay("FieldCode = {FieldCode}, FieldName = {FieldName}, Start = {Start}, Length = {Length}")]
	public class RecordDefinition
	{
		/// <summary>
		/// Gets or sets the unique identifier for the field. The characters before the hyphen signify the file, and the characters after uniquely identify the field.
		/// </summary>
		[JsonProperty("fieldCode")]
		public string FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the human-readable name for the field.
		/// </summary>
		[JsonProperty("fieldName")]
		public string FieldName { get; set; }

		/// <summary>
		/// Gets or sets the 1-based position of the beginning of the field in the fixed-width format.
		/// </summary>
		[JsonProperty("start")]
		public int Start { get; set; }

		/// <summary>
		/// Gets or sets the number of characters the field occupies in the fixed-width format.
		/// </summary>
		[JsonProperty("length")]
		public int Length { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field must contain data (true) or can contain all spaces (false).
		/// </summary>
		[JsonProperty("required")]
		public bool Required { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field must be unique among all records.
		/// </summary>
		[JsonProperty("key")]
		public bool Key { get; set; }

		/// <summary>
		/// Gets or sets the data type of the field (e.g., numeric only or alphanumeric).
		/// </summary>
		[JsonProperty("dataType")]
		public string DataType { get; set; }

		/// <summary>
		/// Gets or sets the description lines providing information about the field and its uses.
		/// </summary>
		[JsonProperty("description")]
		public List<string> Description { get; set; } = [];

		/// <summary>
		/// Gets or sets the data metadata for the field, such as type, format, precision, and references.
		/// </summary>
		[JsonProperty("data")]
		public FieldData Data { get; set; } = new();

		/// <summary>
		/// Gets or sets the default value that should be supplied if one is not provided.
		/// </summary>
		[JsonProperty("default")]
		public string Default { get; set; }
	}
}
