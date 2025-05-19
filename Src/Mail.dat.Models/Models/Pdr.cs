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
	/// Provides piece level detail required of full service mailings; has additional capabilities beyond
	/// the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT
	/// file.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "pdr", File = "Piece Detail Record", Summary = "Quantity, rate, weight, and destination per piece (manifest).", Description = "Provides piece level detail required of full service mailings; has additional capabilities beyond the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT file.")]
	[Table("Pdr", Schema = "Maildat")]
	public partial class Pdr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (PDR-1001)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (PDR-1034)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 2)]
		[Required]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PDR-1012)
		/// The unique code for this package within this container. note: may use XXXXXX, if no packages
		/// created.).
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container. note: may use XXXXXX, if no packages created.).", Type = "string", Format = "zfillnumeric")]
		[Column("PackageID", Order = 3)]
		[Required]
		[MaxLength(6)]
		public string PackageID { get; set; }

		/// <summary>
		/// Piece ID (PDR-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1018", FieldName = "Piece ID", Start = 23, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("PieceID", Order = 4)]
		[Required]
		[Key]
		[MaxLength(22)]
		public string PieceID { get; set; }

		/// <summary>
		/// Piece Barcode (PDR-1108)
		/// Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If
		/// specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1108", FieldName = "Piece Barcode", Start = 45, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("PieceBarcode", Order = 5)]
		[MaxLength(11)]
		public string PieceBarcode { get; set; }

		/// <summary>
		/// Line-Of-Travel Sequence Number (PDR-1114)
		/// Specific piece's L.O.T.-relative sequence number within ZIP+4.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1114", FieldName = "Line-Of-Travel Sequence Number", Start = 56, Length = 4, Required = false, Key = false, DataType = "N", Description = "Specific piece's L.O.T.-relative sequence number within ZIP+4.", Type = "integer", Format = "zfill")]
		[Column("LineOfTravelSequenceNumber", Order = 6)]
		public int LineOfTravelSequenceNumber { get; set; }

		/// <summary>
		/// Line-Of-Travel Seq. Direction Code (PDR-1115)
		/// Piece's LOT-relative code, if carrier walk its block-face ascending order.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1115", FieldName = "Line-Of-Travel Seq. Direction Code", Start = 60, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Piece's LOT-relative code, if carrier walk its block-face ascending order.", Type = "enum", Format = "leftjustify")]
		[Column("LineOfTravelSeqDirectionCode", Order = 7)]
		[MaxLength(1)]
		[AllowedValues("A", "D")]
		public string LineOfTravelSeqDirectionCode { get; set; }

		/// <summary>
		/// Walk Sequence Number (PDR-1116)
		/// Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1116", FieldName = "Walk Sequence Number", Start = 61, Length = 5, Required = false, Key = false, DataType = "N", Description = "Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceNumber", Order = 8)]
		public int WalkSequenceNumber { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PDR-1117)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 9)]
		[MaxLength(1)]
		[AllowedValues("S", "T", "W", "X")]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IM™ Barcode (PDR-1122)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1122", FieldName = "IM™ Barcode", Start = 67, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone.", Type = "string", Format = "leftjustify")]
		[Column("IMBarcode", Order = 10)]
		[MaxLength(34)]
		public string IMBarcode { get; set; }

		/// <summary>
		/// Machine ID (PDR-1124)
		/// Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field
		/// allows participants to identify the machine which applied the barcode on the mailpiece.  When
		/// completed, this field will allow attribution of barcode quality to a single machine during the
		/// Seamless Acceptance postage assessment process.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1124", FieldName = "Machine ID", Start = 101, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field allows participants to identify the machine which applied the barcode on the mailpiece.  When completed, this field will allow attribution of barcode quality to a single machine during the Seamless Acceptance postage assessment process.", Type = "string", Format = "leftjustify")]
		[Column("MachineID", Order = 11)]
		[MaxLength(4)]
		public string MachineID { get; set; }

		/// <summary>
		/// Mailer ID of Barcode Applicator (PDR-1126)
		/// USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to
		/// each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional
		/// information used to attribute barcode  quality. Only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1126", FieldName = "Mailer ID of Barcode Applicator", Start = 105, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional information used to attribute barcode  quality. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfBarcodeApplicator", Order = 12)]
		[MaxLength(9)]
		public string MailerIDOfBarcodeApplicator { get; set; }

		/// <summary>
		/// Move Update Method (PDR-1127)
		/// This field is used to identify Move Update method at the postage statement level.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1127", FieldName = "Move Update Method", Start = 114, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[Column("MoveUpdateMethod", Order = 13)]
		[MaxLength(1)]
		[AllowedValues("0", "1", "2", "4", "5", "6", "7", "8")]
		public string MoveUpdateMethod { get; set; }

		/// <summary>
		/// ACS Key Line Data (PDR-1129)
		/// Remove formatting characters as needed to make the data fit in this sixteen byte field.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1129", FieldName = "ACS Key Line Data", Start = 115, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Remove formatting characters as needed to make the data fit in this sixteen byte field.", Type = "string", Format = "leftjustify")]
		[Column("ACSKeyLineData", Order = 14)]
		[MaxLength(16)]
		public string ACSKeyLineData { get; set; }

		/// <summary>
		/// Carrier Route (PDR-1130)
		/// USPS Carrier Route code.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1130", FieldName = "Carrier Route", Start = 131, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "USPS Carrier Route code.", Type = "string", Format = "leftjustify")]
		[Column("CarrierRoute", Order = 15)]
		[MaxLength(4)]
		public string CarrierRoute { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PDR-1131)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1131", FieldName = "IMpb® Barcode Construct Code", Start = 135, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 16)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PDR-1132)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1132", FieldName = "MID in IMb® is Move Update Supplier", Start = 136, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MIDInIMbIsMoveUpdateSupplier", Order = 17)]
		[MaxLength(1)]
		[AllowedValues("Y")]
		public string MIDInIMbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PDR Record Status (PDR-2000)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-2000", FieldName = "PDR Record Status", Start = 137, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PDRRecordStatus", Order = 18)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string PDRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-9999", FieldName = "Closing Character", Start = 138, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 19)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}