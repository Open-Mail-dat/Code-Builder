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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Quantity, rate, weight, and destination per piece (manifest). Provides piece level detail required
	/// of full service mailings; has additional capabilities beyond the Piece Barcode file; when used
	/// instead of the Piece Barcode file, acts as an extension of the PQT file.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "pdr", File = "Piece Detail Record", Summary = "Quantity, rate, weight, and destination per piece (manifest).", Description = "Quantity, rate, weight, and destination per piece (manifest). Provides piece level detail required of full service mailings; has additional capabilities beyond the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT file.", LineLength = 138, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "pdr", File = "Piece Detail Record", Summary = "Quantity, rate, weight, and destination per piece (manifest).", Description = "Quantity, rate, weight, and destination per piece (manifest). Provides piece level detail required of full service mailings; has additional capabilities beyond the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT file.", LineLength = 138, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "pdr", File = "Piece Detail Record", Summary = "Quantity, rate, weight, and destination per piece (manifest).", Description = "Quantity, rate, weight, and destination per piece (manifest). Provides piece level detail required of full service mailings; has additional capabilities beyond the Piece Barcode file; when used instead of the Piece Barcode file, acts as an extension of the PQT file.", LineLength = 138, ClosingCharacter = "#")]
	[MaildatImport(Order = 14, Version = "23-1")]
	[MaildatImport(Order = 14, Version = "24-1")]
	[MaildatImport(Order = 14, Version = "25-1")]
	[Table("Pdr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Pdr : MaildatEntity, IPdr 
	{
		/// <summary>
		/// Job ID (PDR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PDR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (PDR-1034)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[Comment("PDR-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Package ID (PDR-1012)
		/// The unique code for this package within this container. note: may use XXXXXX, if no packages
		/// created.).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container. note: may use XXXXXX, if no packages created.).", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container. note: may use XXXXXX, if no packages created.).", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container. note: may use XXXXXX, if no packages created.).", Type = "string", Format = "zfillnumeric")]
		[Column("PackageId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PDR-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageId { get; set; }

		/// <summary>
		/// Piece ID (PDR-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1018", FieldName = "Piece ID", Start = 23, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1018", FieldName = "Piece ID", Start = 23, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1018", FieldName = "Piece ID", Start = 23, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("PieceId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("PDR-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// Piece Barcode (PDR-1108)
		/// Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If
		/// specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1108", FieldName = "Piece Barcode", Start = 45, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1108", FieldName = "Piece Barcode", Start = 45, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1108", FieldName = "Piece Barcode", Start = 45, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Numeric values of the applicable  5-Digit, 9-Digit, or  11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("PieceBarcode", Order = 6, TypeName = "TEXT")]
		[MaxLength(11)]
		[Comment("PDR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceBarcode { get; set; }

		/// <summary>
		/// Line-Of-Travel Sequence Number (PDR-1114)
		/// Specific piece's L.O.T.-relative sequence number within ZIP+4.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1114", FieldName = "Line-Of-Travel Sequence Number", Start = 56, Length = 4, Required = false, Key = false, DataType = "N", Description = "Specific piece's L.O.T.-relative sequence number within ZIP+4.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1114", FieldName = "Line-Of-Travel Sequence Number", Start = 56, Length = 4, Required = false, Key = false, DataType = "N", Description = "Specific piece's L.O.T.-relative sequence number within ZIP+4.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1114", FieldName = "Line-Of-Travel Sequence Number", Start = 56, Length = 4, Required = false, Key = false, DataType = "N", Description = "Specific piece's L.O.T.-relative sequence number within ZIP+4.", Type = "integer", Format = "zfill")]
		[Column("LineOfTravelSequenceNumber", Order = 7, TypeName = "INTEGER")]
		[Comment("PDR-1114")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? LineOfTravelSequenceNumber { get; set; }

		/// <summary>
		/// Line-Of-Travel Seq. Direction Code (PDR-1115)
		/// Piece's LOT-relative code, if carrier walk its block-face ascending order.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1115", FieldName = "Line-Of-Travel Seq. Direction Code", Start = 60, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Piece's LOT-relative code, if carrier walk its block-face ascending order.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1115", FieldName = "Line-Of-Travel Seq. Direction Code", Start = 60, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Piece's LOT-relative code, if carrier walk its block-face ascending order.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1115", FieldName = "Line-Of-Travel Seq. Direction Code", Start = 60, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Piece's LOT-relative code, if carrier walk its block-face ascending order.", Type = "enum", Format = "leftjustify")]
		[Column("LineOfTravelSeqDirectionCode", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "D")]
		[Comment("PDR-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(LineOfTravelSeqDirectionCodes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string LineOfTravelSeqDirectionCode { get; set; }

		/// <summary>
		/// Walk Sequence Number (PDR-1116)
		/// Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1116", FieldName = "Walk Sequence Number", Start = 61, Length = 5, Required = false, Key = false, DataType = "N", Description = "Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1116", FieldName = "Walk Sequence Number", Start = 61, Length = 5, Required = false, Key = false, DataType = "N", Description = "Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1116", FieldName = "Walk Sequence Number", Start = 61, Length = 5, Required = false, Key = false, DataType = "N", Description = "Relative Walk Sequence number describing ranking within the carrier's actual delivery sequence.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceNumber", Order = 9, TypeName = "INTEGER")]
		[Comment("PDR-1116")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? WalkSequenceNumber { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PDR-1117)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 10, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "S", "T", "W", "X")]
		[Comment("PDR-1117")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(WastedOrShortagePieceIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IM™ Barcode (PDR-1122)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1122", FieldName = "IM™ Barcode", Start = 67, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1122", FieldName = "IM™ Barcode", Start = 67, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1122", FieldName = "IM™ Barcode", Start = 67, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone.", Type = "string", Format = "leftjustify")]
		[Column("ImBarcode", Order = 11, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("PDR-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImBarcode { get; set; }

		/// <summary>
		/// Machine ID (PDR-1124)
		/// Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field
		/// allows participants to identify the machine which applied the barcode on the mailpiece.  When
		/// completed, this field will allow attribution of barcode quality to a single machine during the
		/// Seamless Acceptance postage assessment process.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1124", FieldName = "Machine ID", Start = 101, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field allows participants to identify the machine which applied the barcode on the mailpiece.  When completed, this field will allow attribution of barcode quality to a single machine during the Seamless Acceptance postage assessment process.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1124", FieldName = "Machine ID", Start = 101, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field allows participants to identify the machine which applied the barcode on the mailpiece.  When completed, this field will allow attribution of barcode quality to a single machine during the Seamless Acceptance postage assessment process.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1124", FieldName = "Machine ID", Start = 101, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Machine ID of the machine at mailers location printing barcodes on the mail pieces. This field allows participants to identify the machine which applied the barcode on the mailpiece.  When completed, this field will allow attribution of barcode quality to a single machine during the Seamless Acceptance postage assessment process.", Type = "string", Format = "leftjustify")]
		[Column("MachineId", Order = 12, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PDR-1124")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MachineId { get; set; }

		/// <summary>
		/// Mailer ID of Barcode Applicator (PDR-1126)
		/// USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to
		/// each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional
		/// information used to attribute barcode  quality. Only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1126", FieldName = "Mailer ID of Barcode Applicator", Start = 105, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional information used to attribute barcode  quality. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1126", FieldName = "Mailer ID of Barcode Applicator", Start = 105, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional information used to attribute barcode  quality. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1126", FieldName = "Mailer ID of Barcode Applicator", Start = 105, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned Mailer ID (MID) This field indicates through USPS MID who applied the IM™ barcode to each mail piece (e.g. Mail Owner, Mailing Agent, etc) . Completion of this field provides additional information used to attribute barcode  quality. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIdOfBarcodeApplicator", Order = 13, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("PDR-1126")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailerIdOfBarcodeApplicator { get; set; }

		/// <summary>
		/// Move Update Method (PDR-1127)
		/// This field is used to identify Move Update method at the postage statement level.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1127", FieldName = "Move Update Method", Start = 114, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1127", FieldName = "Move Update Method", Start = 114, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1127", FieldName = "Move Update Method", Start = 114, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[Column("MoveUpdateMethod", Order = 14, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("0", "1", "2", "4", "5", "6", "7", "8")]
		[Comment("PDR-1127")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MoveUpdateMethods))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MoveUpdateMethod { get; set; }

		/// <summary>
		/// ACS Key Line Data (PDR-1129)
		/// Remove formatting characters as needed to make the data fit in this sixteen byte field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1129", FieldName = "ACS Key Line Data", Start = 115, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Remove formatting characters as needed to make the data fit in this sixteen byte field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1129", FieldName = "ACS Key Line Data", Start = 115, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Remove formatting characters as needed to make the data fit in this sixteen byte field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1129", FieldName = "ACS Key Line Data", Start = 115, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Remove formatting characters as needed to make the data fit in this sixteen byte field.", Type = "string", Format = "leftjustify")]
		[Column("ACSKeyLineData", Order = 15, TypeName = "TEXT")]
		[MaxLength(16)]
		[Comment("PDR-1129")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ACSKeyLineData { get; set; }

		/// <summary>
		/// Carrier Route (PDR-1130)
		/// USPS Carrier Route code.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1130", FieldName = "Carrier Route", Start = 131, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "USPS Carrier Route code.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1130", FieldName = "Carrier Route", Start = 131, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "USPS Carrier Route code.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1130", FieldName = "Carrier Route", Start = 131, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "USPS Carrier Route code.", Type = "string", Format = "leftjustify")]
		[Column("CarrierRoute", Order = 16, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PDR-1130")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CarrierRoute { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PDR-1131)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1131", FieldName = "IMpb® Barcode Construct Code", Start = 135, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1131", FieldName = "IMpb® Barcode Construct Code", Start = 135, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1131", FieldName = "IMpb® Barcode Construct Code", Start = 135, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®.", Type = "enum", Format = "leftjustify")]
		[Column("ImpbBarcodeConstructCode", Order = 17, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("PDR-1131")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ImpbBarcodeConstructCodes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PDR-1132)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-1132", FieldName = "MID in IMb® is Move Update Supplier", Start = 136, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-1132", FieldName = "MID in IMb® is Move Update Supplier", Start = 136, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-1132", FieldName = "MID in IMb® is Move Update Supplier", Start = 136, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MidInImbIsMoveUpdateSupplier", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("PDR-1132")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MidInImbIsMoveUpdateSuppliers))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MidInImbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PDR Record Status (PDR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-2000", FieldName = "PDR Record Status", Start = 137, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-2000", FieldName = "PDR Record Status", Start = 137, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-2000", FieldName = "PDR Record Status", Start = 137, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("PdrRecordStatus", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PDR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PdrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PdrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pdr", FieldCode = "PDR-9999", FieldName = "Closing Character", Start = 138, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pdr", FieldCode = "PDR-9999", FieldName = "Closing Character", Start = 138, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pdr", FieldCode = "PDR-9999", FieldName = "Closing Character", Start = 138, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 20, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PDR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Pdr, string>(version, p => p.JobId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Pdr, int>(version, p => p.CqtDatabaseId, returnValue);
			this.PackageId = line.ParseForImport<Pdr, string>(version, p => p.PackageId, returnValue);
			this.PieceId = line.ParseForImport<Pdr, string>(version, p => p.PieceId, returnValue);
			this.PieceBarcode = line.ParseForImport<Pdr, string>(version, p => p.PieceBarcode, returnValue);
			this.LineOfTravelSequenceNumber = line.ParseForImport<Pdr, int?>(version, p => p.LineOfTravelSequenceNumber, returnValue);
			this.LineOfTravelSeqDirectionCode = line.ParseForImport<Pdr, string>(version, p => p.LineOfTravelSeqDirectionCode, returnValue);
			this.WalkSequenceNumber = line.ParseForImport<Pdr, int?>(version, p => p.WalkSequenceNumber, returnValue);
			this.WastedOrShortagePieceIndicator = line.ParseForImport<Pdr, string>(version, p => p.WastedOrShortagePieceIndicator, returnValue);
			this.ImBarcode = line.ParseForImport<Pdr, string>(version, p => p.ImBarcode, returnValue);
			this.MachineId = line.ParseForImport<Pdr, string>(version, p => p.MachineId, returnValue);
			this.MailerIdOfBarcodeApplicator = line.ParseForImport<Pdr, string>(version, p => p.MailerIdOfBarcodeApplicator, returnValue);
			this.MoveUpdateMethod = line.ParseForImport<Pdr, string>(version, p => p.MoveUpdateMethod, returnValue);
			this.ACSKeyLineData = line.ParseForImport<Pdr, string>(version, p => p.ACSKeyLineData, returnValue);
			this.CarrierRoute = line.ParseForImport<Pdr, string>(version, p => p.CarrierRoute, returnValue);
			this.ImpbBarcodeConstructCode = line.ParseForImport<Pdr, string>(version, p => p.ImpbBarcodeConstructCode, returnValue);
			this.MidInImbIsMoveUpdateSupplier = line.ParseForImport<Pdr, string>(version, p => p.MidInImbIsMoveUpdateSupplier, returnValue);
			this.PdrRecordStatus = line.ParseForImport<Pdr, string>(version, p => p.PdrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pdr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Pdr, string>(version, p => p.JobId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Pdr, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.PackageId.FormatForExport<Pdr, string>(version, p => p.PackageId));
			sb.Append(this.PieceId.FormatForExport<Pdr, string>(version, p => p.PieceId));
			sb.Append(this.PieceBarcode.FormatForExport<Pdr, string>(version, p => p.PieceBarcode));
			sb.Append(this.LineOfTravelSequenceNumber.FormatForExport<Pdr, int?>(version, p => p.LineOfTravelSequenceNumber));
			sb.Append(this.LineOfTravelSeqDirectionCode.FormatForExport<Pdr, string>(version, p => p.LineOfTravelSeqDirectionCode));
			sb.Append(this.WalkSequenceNumber.FormatForExport<Pdr, int?>(version, p => p.WalkSequenceNumber));
			sb.Append(this.WastedOrShortagePieceIndicator.FormatForExport<Pdr, string>(version, p => p.WastedOrShortagePieceIndicator));
			sb.Append(this.ImBarcode.FormatForExport<Pdr, string>(version, p => p.ImBarcode));
			sb.Append(this.MachineId.FormatForExport<Pdr, string>(version, p => p.MachineId));
			sb.Append(this.MailerIdOfBarcodeApplicator.FormatForExport<Pdr, string>(version, p => p.MailerIdOfBarcodeApplicator));
			sb.Append(this.MoveUpdateMethod.FormatForExport<Pdr, string>(version, p => p.MoveUpdateMethod));
			sb.Append(this.ACSKeyLineData.FormatForExport<Pdr, string>(version, p => p.ACSKeyLineData));
			sb.Append(this.CarrierRoute.FormatForExport<Pdr, string>(version, p => p.CarrierRoute));
			sb.Append(this.ImpbBarcodeConstructCode.FormatForExport<Pdr, string>(version, p => p.ImpbBarcodeConstructCode));
			sb.Append(this.MidInImbIsMoveUpdateSupplier.FormatForExport<Pdr, string>(version, p => p.MidInImbIsMoveUpdateSupplier));
			sb.Append(this.PdrRecordStatus.FormatForExport<Pdr, string>(version, p => p.PdrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Pdr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}