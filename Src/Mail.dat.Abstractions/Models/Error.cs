//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
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
// LICENSE (GNU Lesser General Public License)
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
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
	/// 
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

		[MaxLength(100)]
		[Column(Order = 1)]
		public string Process { get; set; }

		[MaxLength(3)]
		[Column(Order = 2)]
		public string File { get; set; }

		[Column(Order = 3)]
		public string FieldName { get; set; }

		[Column(Order = 4)]
		public string FieldCode { get; set; }

		[Column(Order = 5)]
		public string DataType { get; set; }

		[Column(Order = 6)]
		public string Type { get; set; }

		[Column(Order = 7)]
		public int LineNumber { get; set; }

		[Column(Order = 8)]
		public int StartPosition { get; set; }

		[Column(Order = 8)]
		public int Length { get; set; }

		[Column(Order = 10)]
		public string Value { get; set; }

		[Column(Order = 11)]
		public string ErrorMessage { get; set; }
	}
}