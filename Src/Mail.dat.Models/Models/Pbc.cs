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
	/// Provides piece level detail required of full service mailings; when used instead of the Piece Detail
	/// file, acts as an extension of the PQT file.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "pbc", File = "Piece Barcode Record", Summary = "Piece barcode details.", Description = "Provides piece level detail required of full service mailings; when used instead of the Piece Detail file, acts as an extension of the PQT file.")]
	[Table("Pbc", Schema = "Maildat")]
	public partial class Pbc : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (PBC-1001)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// PBC Unique ID (PBC-1002)
		/// Uniquely identifies each PBC record.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1002", FieldName = "PBC Unique ID", Start = 9, Length = 9, Required = true, Key = true, DataType = "N", Description = "Uniquely identifies each PBC record.", Type = "integer", Format = "zfill")]
		[Column("PBCUniqueID", Order = 2)]
		[Required]
		[Key]
		public int PBCUniqueID { get; set; }

		/// <summary>
		/// CQT Database ID (PBC-1034)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1034", FieldName = "CQT Database ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "N", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 3)]
		[Required]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PBC-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1012", FieldName = "Package ID", Start = 26, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[Column("PackageID", Order = 4)]
		[Required]
		[MaxLength(6)]
		public string PackageID { get; set; }

		/// <summary>
		/// Barcode (PBC-1122)
		/// IMb® or IMpb®.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1122", FieldName = "Barcode", Start = 32, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "IMb® or IMpb®.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 5)]
		[MaxLength(34)]
		public string Barcode { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PBC-1117)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 6)]
		[MaxLength(1)]
		[AllowedValues("S", "T", "W", "X")]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PBC-1118)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1118", FieldName = "IMpb® Barcode Construct Code", Start = 67, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 7)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PBC-1119)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1119", FieldName = "MID in IMb® is Move Update Supplier", Start = 68, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MIDInIMbIsMoveUpdateSupplier", Order = 8)]
		[MaxLength(1)]
		[AllowedValues("Y")]
		public string MIDInIMbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PBC Record Status (PBC-2000)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-2000", FieldName = "PBC Record Status", Start = 69, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PBCRecordStatus", Order = 9)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string PBCRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PBC-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}