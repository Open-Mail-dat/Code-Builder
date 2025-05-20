// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 1.0.0
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Records identify third party move update entities that should be invoiced.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "epd", File = "Extra Piece Detail Record", Summary = "CRID for Move update charges.", Description = "Records identify third party move update entities that should be invoiced.")]
	[Table("Epd", Schema = "Maildat")]
	public partial class Epd : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (EPD-1001)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (EPD-1002)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1002", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(22)]
		public string PieceID { get; set; }

		/// <summary>
		/// CRID Type (EPD-1003)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1003", FieldName = "CRID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CRIDType", Order = 3)]
		[Required]
		[Key]
		[MaxLength(1)]
		[AllowedValues("M", "U")]
		public string CRIDType { get; set; }

		/// <summary>
		/// CRID (EPD-1101)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify,
		/// space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1101", FieldName = "CRID", Start = 32, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRID", Order = 4)]
		[Required]
		[MaxLength(12)]
		public string CRID { get; set; }

		/// <summary>
		/// EPD Record Status (EPD-2000)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-2000", FieldName = "EPD Record Status", Start = 44, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("EPDRecordStatus", Order = 5)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string EPDRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (EPD-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-9999", FieldName = "Closing Character", Start = 45, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}