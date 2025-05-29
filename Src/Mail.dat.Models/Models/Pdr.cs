// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 27th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Provides piece level detail required of full service mailings; has additional capabilities beyond
	/// the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT
	/// file.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "pdr", File = "Piece Detail Record", Summary = "Quantity, rate, weight, and destination per piece (manifest).", Description = "Provides piece level detail required of full service mailings; has additional capabilities beyond the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT file.", LineLength = 138, ClosingCharacter = "#")]
	[Table("Pdr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 14)]
	public partial class Pdr : MaildatEntity, IPdr 
	{
		/// <summary>
		/// Job ID (PDR-1001)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PDR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (PDR-1034)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 3, TypeName = "INTEGER")]
		[Required]
		[Comment("PDR-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PDR-1012)
		/// The unique code for this package within this container. note: may use XXXXXX, if no packages
		/// created.).
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container. note: may use XXXXXX, if no packages created.).", Type = "string", Format = "zfillnumeric")]
		[Column("PackageID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PDR-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageID { get; set; }

		/// <summary>
		/// Piece ID (PDR-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1018", FieldName = "Piece ID", Start = 23, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("PieceID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("PDR-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PieceID { get; set; }

		/// <summary>
		/// Piece Barcode (PDR-1108)
		/// Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If
		/// specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1108", FieldName = "Piece Barcode", Start = 45, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("PieceBarcode", Order = 6, TypeName = "TEXT")]
		[MaxLength(11)]
		[Comment("PDR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PieceBarcode { get; set; }

		/// <summary>
		/// Line-Of-Travel Sequence Number (PDR-1114)
		/// Specific piece's L.O.T.-relative sequence number within ZIP+4.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1114", FieldName = "Line-Of-Travel Sequence Number", Start = 56, Length = 4, Required = false, Key = false, DataType = "N", Description = "Specific piece's L.O.T.-relative sequence number within ZIP+4.", Type = "integer", Format = "zfill")]
		[Column("LineOfTravelSequenceNumber", Order = 7, TypeName = "INTEGER")]
		[Comment("PDR-1114")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? LineOfTravelSequenceNumber { get; set; }

		/// <summary>
		/// Line-Of-Travel Seq. Direction Code (PDR-1115)
		/// Piece's LOT-relative code, if carrier walk its block-face ascending order.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1115", FieldName = "Line-Of-Travel Seq. Direction Code", Start = 60, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Piece's LOT-relative code, if carrier walk its block-face ascending order.", Type = "enum", Format = "leftjustify")]
		[Column("LineOfTravelSeqDirectionCode", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "D")]
		[Comment("PDR-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string LineOfTravelSeqDirectionCode { get; set; }

		/// <summary>
		/// Walk Sequence Number (PDR-1116)
		/// Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1116", FieldName = "Walk Sequence Number", Start = 61, Length = 5, Required = false, Key = false, DataType = "N", Description = "Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceNumber", Order = 9, TypeName = "INTEGER")]
		[Comment("PDR-1116")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? WalkSequenceNumber { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PDR-1117)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 10, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "S", "T", "W", "X")]
		[Comment("PDR-1117")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IM™ Barcode (PDR-1122)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1122", FieldName = "IM™ Barcode", Start = 67, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone.", Type = "string", Format = "leftjustify")]
		[Column("IMBarcode", Order = 11, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("PDR-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string IMBarcode { get; set; }

		/// <summary>
		/// Machine ID (PDR-1124)
		/// Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field
		/// allows participants to identify the machine which applied the barcode on the mailpiece.  When
		/// completed, this field will allow attribution of barcode quality to a single machine during the
		/// Seamless Acceptance postage assessment process.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1124", FieldName = "Machine ID", Start = 101, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field allows participants to identify the machine which applied the barcode on the mailpiece.  When completed, this field will allow attribution of barcode quality to a single machine during the Seamless Acceptance postage assessment process.", Type = "string", Format = "leftjustify")]
		[Column("MachineID", Order = 12, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PDR-1124")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MachineID { get; set; }

		/// <summary>
		/// Mailer ID of Barcode Applicator (PDR-1126)
		/// USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to
		/// each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional
		/// information used to attribute barcode  quality. Only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1126", FieldName = "Mailer ID of Barcode Applicator", Start = 105, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional information used to attribute barcode  quality. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfBarcodeApplicator", Order = 13, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("PDR-1126")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailerIDOfBarcodeApplicator { get; set; }

		/// <summary>
		/// Move Update Method (PDR-1127)
		/// This field is used to identify Move Update method at the postage statement level.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1127", FieldName = "Move Update Method", Start = 114, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[Column("MoveUpdateMethod", Order = 14, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("0", "1", "2", "4", "5", "6", "7", "8")]
		[Comment("PDR-1127")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MoveUpdateMethod { get; set; }

		/// <summary>
		/// ACS Key Line Data (PDR-1129)
		/// Remove formatting characters as needed to make the data fit in this sixteen byte field.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1129", FieldName = "ACS Key Line Data", Start = 115, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Remove formatting characters as needed to make the data fit in this sixteen byte field.", Type = "string", Format = "leftjustify")]
		[Column("ACSKeyLineData", Order = 15, TypeName = "TEXT")]
		[MaxLength(16)]
		[Comment("PDR-1129")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ACSKeyLineData { get; set; }

		/// <summary>
		/// Carrier Route (PDR-1130)
		/// USPS Carrier Route code.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1130", FieldName = "Carrier Route", Start = 131, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "USPS Carrier Route code.", Type = "string", Format = "leftjustify")]
		[Column("CarrierRoute", Order = 16, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PDR-1130")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CarrierRoute { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PDR-1131)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1131", FieldName = "IMpb® Barcode Construct Code", Start = 135, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 17, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("PDR-1131")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PDR-1132)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-1132", FieldName = "MID in IMb® is Move Update Supplier", Start = 136, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MIDInIMbIsMoveUpdateSupplier", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("PDR-1132")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MIDInIMbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PDR Record Status (PDR-2000)
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-2000", FieldName = "PDR Record Status", Start = 137, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PDRRecordStatus", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PDR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PDRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pdr", FieldCode = "PDR-9999", FieldName = "Closing Character", Start = 138, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 20, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PDR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Pdr, string>(p => p.JobID, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Pdr, int>(p => p.CQTDatabaseID, returnValue);
			this.PackageID = line.ParseForImport<Pdr, string>(p => p.PackageID, returnValue);
			this.PieceID = line.ParseForImport<Pdr, string>(p => p.PieceID, returnValue);
			this.PieceBarcode = line.ParseForImport<Pdr, string>(p => p.PieceBarcode, returnValue);
			this.LineOfTravelSequenceNumber = line.ParseForImport<Pdr, int?>(p => p.LineOfTravelSequenceNumber, returnValue);
			this.LineOfTravelSeqDirectionCode = line.ParseForImport<Pdr, string>(p => p.LineOfTravelSeqDirectionCode, returnValue);
			this.WalkSequenceNumber = line.ParseForImport<Pdr, int?>(p => p.WalkSequenceNumber, returnValue);
			this.WastedOrShortagePieceIndicator = line.ParseForImport<Pdr, string>(p => p.WastedOrShortagePieceIndicator, returnValue);
			this.IMBarcode = line.ParseForImport<Pdr, string>(p => p.IMBarcode, returnValue);
			this.MachineID = line.ParseForImport<Pdr, string>(p => p.MachineID, returnValue);
			this.MailerIDOfBarcodeApplicator = line.ParseForImport<Pdr, string>(p => p.MailerIDOfBarcodeApplicator, returnValue);
			this.MoveUpdateMethod = line.ParseForImport<Pdr, string>(p => p.MoveUpdateMethod, returnValue);
			this.ACSKeyLineData = line.ParseForImport<Pdr, string>(p => p.ACSKeyLineData, returnValue);
			this.CarrierRoute = line.ParseForImport<Pdr, string>(p => p.CarrierRoute, returnValue);
			this.IMpbBarcodeConstructCode = line.ParseForImport<Pdr, string>(p => p.IMpbBarcodeConstructCode, returnValue);
			this.MIDInIMbIsMoveUpdateSupplier = line.ParseForImport<Pdr, string>(p => p.MIDInIMbIsMoveUpdateSupplier, returnValue);
			this.PDRRecordStatus = line.ParseForImport<Pdr, string>(p => p.PDRRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pdr, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Pdr, string>(p => p.JobID));
			sb.Append(this.CQTDatabaseID.FormatForExport<Pdr, int>(p => p.CQTDatabaseID));
			sb.Append(this.PackageID.FormatForExport<Pdr, string>(p => p.PackageID));
			sb.Append(this.PieceID.FormatForExport<Pdr, string>(p => p.PieceID));
			sb.Append(this.PieceBarcode.FormatForExport<Pdr, string>(p => p.PieceBarcode));
			sb.Append(this.LineOfTravelSequenceNumber.FormatForExport<Pdr, int?>(p => p.LineOfTravelSequenceNumber));
			sb.Append(this.LineOfTravelSeqDirectionCode.FormatForExport<Pdr, string>(p => p.LineOfTravelSeqDirectionCode));
			sb.Append(this.WalkSequenceNumber.FormatForExport<Pdr, int?>(p => p.WalkSequenceNumber));
			sb.Append(this.WastedOrShortagePieceIndicator.FormatForExport<Pdr, string>(p => p.WastedOrShortagePieceIndicator));
			sb.Append(this.IMBarcode.FormatForExport<Pdr, string>(p => p.IMBarcode));
			sb.Append(this.MachineID.FormatForExport<Pdr, string>(p => p.MachineID));
			sb.Append(this.MailerIDOfBarcodeApplicator.FormatForExport<Pdr, string>(p => p.MailerIDOfBarcodeApplicator));
			sb.Append(this.MoveUpdateMethod.FormatForExport<Pdr, string>(p => p.MoveUpdateMethod));
			sb.Append(this.ACSKeyLineData.FormatForExport<Pdr, string>(p => p.ACSKeyLineData));
			sb.Append(this.CarrierRoute.FormatForExport<Pdr, string>(p => p.CarrierRoute));
			sb.Append(this.IMpbBarcodeConstructCode.FormatForExport<Pdr, string>(p => p.IMpbBarcodeConstructCode));
			sb.Append(this.MIDInIMbIsMoveUpdateSupplier.FormatForExport<Pdr, string>(p => p.MIDInIMbIsMoveUpdateSupplier));
			sb.Append(this.PDRRecordStatus.FormatForExport<Pdr, string>(p => p.PDRRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Pdr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}