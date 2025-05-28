// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
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