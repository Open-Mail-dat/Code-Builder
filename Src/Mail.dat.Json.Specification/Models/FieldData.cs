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
using Newtonsoft.Json;

namespace Mail.dat.Json.Specification
{
	/// <summary>
	/// Represents a data structure containing metadata and associated values for a specific field.
	/// </summary>
	/// <remarks>This class is used to encapsulate information about a field, including its type, format, precision,
	/// references, and associated key-value pairs. It is commonly used in scenarios where structured  metadata and values
	/// need to be stored and processed.</remarks>
	public class FieldData
	{
		/// <summary>
		/// Gets or sets the type of the object represented as a string.
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the format of the data as a string.
		/// </summary>
		[JsonProperty("format")]
		public string Format { get; set; }

		/// <summary>
		/// Gets or sets the precision level for numerical values.
		/// </summary>
		[JsonProperty("precision")]
		public int? Precision { get; set; }

		/// <summary>
		/// Gets or sets the list of references associated with the object.
		/// </summary>
		[JsonProperty("references")]
		public List<string> References { get; set; } = [];

		/// <summary>
		/// Gets or sets a dictionary containing key-value pairs representing the values associated with this object.
		/// </summary>
		[JsonProperty("values")]
		public Dictionary<string, string> Values { get; set; } = [];
	}
}
