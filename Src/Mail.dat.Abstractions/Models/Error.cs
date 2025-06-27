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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mail.dat
{
	/// <summary>
	/// Represents an error record in the Mail.dat system.
	/// </summary>
	[PrimaryKey("Id")]
	public partial class Error : MaildatEntity, IError
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the process.
		/// </summary>
		[MaxLength(100)]
		[Column(Order = 1)]
		public string Process { get; set; }

		/// <summary>
		/// Gets or sets the file identifier.
		/// </summary>
		[MaxLength(3)]
		[Column(Order = 2)]
		public string File { get; set; }

		/// <summary>
		/// Gets or sets the name of the field associated with this entity.
		/// </summary>
		[Column(Order = 3)]
		public string FieldName { get; set; }

		/// <summary>
		/// Gets or sets the code that uniquely identifies the field.
		/// </summary>
		[Column(Order = 4)]
		public string FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the data type associated with the entity.
		/// </summary>
		[Column(Order = 5)]
		public string DataType { get; set; }

		/// <summary>
		/// Gets or sets the type associated with the entity.
		/// </summary>
		[Column(Order = 6)]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the line number associated with the entity.
		/// </summary>
		[Column(Order = 7)]
		public int LineNumber { get; set; }

		/// <summary>
		/// Gets or sets the starting position of an item or entity within a sequence or collection.
		/// </summary>
		[Column(Order = 8)]
		public int StartPosition { get; set; }

		/// <summary>
		/// Gets or sets the length of the item.
		/// </summary>
		[Column(Order = 8)]
		public int Length { get; set; }

		/// <summary>
		/// Gets or sets the value associated with this entity.
		/// </summary>
		[Column(Order = 10)]
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the error message associated with this entity.
		/// </summary>
		[Column(Order = 11)]
		public string ErrorMessage { get; set; }
	}
}