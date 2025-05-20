// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Provides barcode for special fees.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "sfb", File = "Special Barcode Record", Summary = "Barcode for special services.", Description = "Provides barcode for special fees.")]
	[Table("Sfb", Schema = "Maildat")]
	public partial class Sfb : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (SFB-1001)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (SFB-1018)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(22)]
		public string PieceID { get; set; }

		/// <summary>
		/// Barcode Type (SFB-1004)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1004", FieldName = "Barcode Type", Start = 31, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeType", Order = 3)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("E", "F")]
		public string BarcodeType { get; set; }

		/// <summary>
		/// Barcode (SFB-1003)
		/// IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode
		/// (IMb® or IMpb®) that has been added to the piece.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1003", FieldName = "Barcode", Start = 32, Length = 34, Required = true, Key = false, DataType = "A/N", Description = "IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode (IMb® or IMpb®) that has been added to the piece.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 4)]
		[Required]
		[MaxLength(34)]
		public string Barcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (SFB-1005)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1005", FieldName = "IMpb® Barcode Construct Code", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 5)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// SFB Record Status (SFB-2000)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-2000", FieldName = "SFB Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SFBRecordStatus", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string SFBRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (SFB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-9999", FieldName = "Closing Character", Start = 68, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}