// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 18th, 2025.
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
	/// Quantity and destination per package.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "pqt", File = "Package Quantity Record", Summary = "Quantity and destination per package.", Description = "Quantity and destination per package.")]
	[Table("Pqt", Schema = "Maildat")]
	public partial class Pqt : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (PQT-1001)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (PQT-1034)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 2)]
		[Required]
		[Key]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PQT-1012)
		/// Unique identifier for the package within the container.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "Unique identifier for the package within the container.", Type = "string", Format = "zfillnumeric")]
		[Column("PackageID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(6)]
		public string PackageID { get; set; }

		/// <summary>
		/// Package ZIP Code (PQT-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package Defined in the record. Left
		/// Justify. For a Package Service parcel presort the Parcel Piece is the package; Therefore, populate
		/// with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP
		/// or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if
		/// for U.S. Domestic International: (ex: FRCDGA = FR CDG A).
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1013", FieldName = "Package ZIP Code", Start = 23, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package Defined in the record. Left Justify. For a Package Service parcel presort the Parcel Piece is the package; Therefore, populate with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if for U.S. Domestic International: (ex: FRCDGA = FR CDG A).", Type = "string", Format = "leftjustify")]
		[Column("PackageZIPCode", Order = 4)]
		[Required]
		[MaxLength(6)]
		public string PackageZIPCode { get; set; }

		/// <summary>
		/// Package Carrier Route (PQT-1101)
		/// Example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1101", FieldName = "Package Carrier Route", Start = 29, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCarrierRoute", Order = 5)]
		[MaxLength(4)]
		public string PackageCarrierRoute { get; set; }

		/// <summary>
		/// Package Level (PQT-1102)
		/// See Below.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1102", FieldName = "Package Level", Start = 33, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Below.", Type = "enum", Format = "leftjustify")]
		[Column("PackageLevel", Order = 6)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("9", "A", "B", "C", "D", "F", "H", "I", "K", "L", "M", "R", "S", "T", "U", "V")]
		public string PackageLevel { get; set; }

		/// <summary>
		/// Number of Copies (PQT-1103)
		/// Number of copies within the specific package.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1103", FieldName = "Number of Copies", Start = 35, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of copies within the specific package.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 7)]
		[Required]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (PQT-1104)
		/// Number of pieces within this specific package. Note: First record Within Firm Package or Multi-Piece
		/// Parcel has Piece Count = 1 Subsequent records within same Package the piece count = 0 (see Scenarios
		/// for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than
		/// copies in some Periodical or 4C mailings).
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1104", FieldName = "Number of Pieces", Start = 40, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of pieces within this specific package. Note: First record Within Firm Package or Multi-Piece Parcel has Piece Count = 1 Subsequent records within same Package the piece count = 0 (see Scenarios for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than copies in some Periodical or 4C mailings).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 8)]
		[Required]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Bundle Charge Allocation (PQT-1113)
		/// 9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the
		/// proportion of cost of its bundle that it's carrying.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1113", FieldName = "Bundle Charge Allocation", Start = 45, Length = 7, Required = false, Key = false, DataType = "N", Description = "9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the proportion of cost of its bundle that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("BundleChargeAllocation", Order = 9)]
		public decimal BundleChargeAllocation { get; set; }

		/// <summary>
		/// Combo-Pack ID (PQT-1114)
		/// The unique code for this combo-pack within this package.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1114", FieldName = "Combo-Pack ID", Start = 52, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "The unique code for this combo-pack within this package.", Type = "string", Format = "leftjustify")]
		[Column("ComboPackID", Order = 10)]
		[MaxLength(6)]
		public string ComboPackID { get; set; }

		/// <summary>
		/// PQT Record Status (PQT-2000)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-2000", FieldName = "PQT Record Status", Start = 58, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PQTRecordStatus", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string PQTRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PQT-1105)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1105", FieldName = "Reserve", Start = 59, Length = 11, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 12)]
		[MaxLength(11)]
		public string ReservePQT1105 { get; set; }

		/// <summary>
		/// Closing Character (PQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}