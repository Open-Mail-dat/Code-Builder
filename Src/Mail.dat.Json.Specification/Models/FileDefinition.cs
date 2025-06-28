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
	/// Represents a Mail.dat file definition, including its name, extension, summary, description, and record definitions.
	/// </summary>
	[DebuggerDisplay("FileName = {FileName}, FileExtension = {FileExtension}")]
	public class FileDefinition
	{
		/// <summary>
		/// Gets or sets the title of the file.
		/// </summary>
		[JsonProperty("file")]
		public string FileName { get; set; }

		/// <summary>
		/// Gets or sets the 3-character extension of the file.
		/// </summary>
		[JsonProperty("fileExtension")]
		public string FileExtension { get; set; }

		/// <summary>
		/// Gets or sets a short summary of the purpose of the file.
		/// </summary>
		[JsonProperty("fileSummary")]
		public string FileSummary { get; set; }

		/// <summary>
		/// Gets or sets a detailed description of the purpose of the file.
		/// </summary>
		[JsonProperty("fileDescription")]
		public string FileDescription { get; set; }

		/// <summary>
		/// Gets or sets the collection of record definitions for this file.
		/// </summary>
		[JsonProperty("recordDefinitions")]
		public List<RecordDefinition> RecordDefinitions { get; set; } = [];
	}
}
