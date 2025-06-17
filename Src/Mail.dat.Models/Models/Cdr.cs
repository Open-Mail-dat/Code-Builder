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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
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
	/// Is used to capture the Detail information that is present on the Certificate of Mail Forms. Provide
	/// the detailed information that is present on the Certificate of Mail Forms.
	/// </summary>
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "cdr", File = "Certificate of Mailing Detail Record", Summary = "Is used to capture the Detail information that is present on the Certificate of Mail Forms.", Description = "Is used to capture the Detail information that is present on the Certificate of Mail Forms. Provide the detailed information that is present on the Certificate of Mail Forms.", LineLength = 395, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "cdr", File = "Certificate of Mailing Detail Record", Summary = "Is used to capture the Detail information that is present on the Certificate of Mail Forms.", Description = "Is used to capture the Detail information that is present on the Certificate of Mail Forms. Provide the detailed information that is present on the Certificate of Mail Forms.", LineLength = 395, ClosingCharacter = "#")]
	[MaildatImport(Order = 27, Version = "24-1")]
	[MaildatImport(Order = 27, Version = "25-1")]
	[Table("Cdr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("24-1", "25-1")]
	public partial class Cdr : MaildatEntity, ICdr 
	{
		/// <summary>
		/// Job ID (CDR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CDR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CDR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CDR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// COM Piece ID (CDR-1003)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1003", FieldName = "COM Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1003", FieldName = "COM Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("ComPieceId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("CDR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ComPieceId { get; set; }

		/// <summary>
		/// Firm Specific ID (CDR-1101)
		/// Submitter's unique ID of the record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1101", FieldName = "Firm Specific ID", Start = 39, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Submitter's unique ID of the record.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1101", FieldName = "Firm Specific ID", Start = 39, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Submitter's unique ID of the record.", Type = "string", Format = "leftjustify")]
		[Column("FirmSpecificId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("CDR-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FirmSpecificId { get; set; }

		/// <summary>
		/// USPS Tracking Number (CDR-1102)
		/// To be used for IM™ barcode or IMpb barcode.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1102", FieldName = "USPS Tracking Number", Start = 69, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode or IMpb barcode.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1102", FieldName = "USPS Tracking Number", Start = 69, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode or IMpb barcode.", Type = "string", Format = "leftjustify")]
		[Column("USPSTrackingNumber", Order = 6, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("CDR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string USPSTrackingNumber { get; set; }

		/// <summary>
		/// Recipient Name (CDR-1103)
		/// Name of Recipient.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1103", FieldName = "Recipient Name", Start = 103, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Name of Recipient.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1103", FieldName = "Recipient Name", Start = 103, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Name of Recipient.", Type = "string", Format = "leftjustify")]
		[Column("RecipientName", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(50)]
		[Comment("CDR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string RecipientName { get; set; }

		/// <summary>
		/// Secondary Address (CDR-1104)
		/// Secondary address of recipient.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1104", FieldName = "Secondary Address", Start = 153, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary address of recipient.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1104", FieldName = "Secondary Address", Start = 153, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary address of recipient.", Type = "string", Format = "leftjustify")]
		[Column("SecondaryAddress", Order = 8, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CDR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string SecondaryAddress { get; set; }

		/// <summary>
		/// Primary Address (CDR-1105)
		/// Primary address of recipient.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1105", FieldName = "Primary Address", Start = 203, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Primary address of recipient.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1105", FieldName = "Primary Address", Start = 203, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Primary address of recipient.", Type = "string", Format = "leftjustify")]
		[Column("PrimaryAddress", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(50)]
		[Comment("CDR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string PrimaryAddress { get; set; }

		/// <summary>
		/// City (CDR-1106)
		/// City of recipient.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1106", FieldName = "City", Start = 253, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "City of recipient.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1106", FieldName = "City", Start = 253, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "City of recipient.", Type = "string", Format = "leftjustify")]
		[Column("City", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("CDR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string City { get; set; }

		/// <summary>
		/// State (CDR-1107)
		/// State of recipient. Two-character state code, required for addresses in the United States.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1107", FieldName = "State", Start = 283, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "State of recipient. Two-character state code, required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1107", FieldName = "State", Start = 283, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "State of recipient. Two-character state code, required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[Column("State", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[Comment("CDR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string State { get; set; }

		/// <summary>
		/// Postal Code (CDR-1108)
		/// ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit
		/// Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of
		/// the field blank.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1108", FieldName = "Postal Code", Start = 285, Length = 11, Required = true, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1108", FieldName = "Postal Code", Start = 285, Length = 11, Required = true, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("PostalCode", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(11)]
		[Comment("CDR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string PostalCode { get; set; }

		/// <summary>
		/// Province or State - International (CDR-1109)
		/// Province of recipient's address. State or Province Code or Name. Applicable for international
		/// addresses only.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1109", FieldName = "Province or State - International", Start = 296, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province of recipient's address. State or Province Code or Name. Applicable for international addresses only.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1109", FieldName = "Province or State - International", Start = 296, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province of recipient's address. State or Province Code or Name. Applicable for international addresses only.", Type = "string", Format = "leftjustify")]
		[Column("ProvinceOrStateInternational", Order = 13, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CDR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ProvinceOrStateInternational { get; set; }

		/// <summary>
		/// Country Code (CDR-1110)
		/// Country Code of recipient's address.  When required populated with two-character ISO Country Code.
		/// Used for international addresses.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1110", FieldName = "Country Code", Start = 316, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of recipient's address.  When required populated with two-character ISO Country Code. Used for international addresses.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1110", FieldName = "Country Code", Start = 316, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of recipient's address.  When required populated with two-character ISO Country Code. Used for international addresses.", Type = "string", Format = "leftjustify")]
		[Column("CountryCode", Order = 14, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CDR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Postage (CDR-1111)
		/// Dollars.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1111", FieldName = "Postage", Start = 318, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1111", FieldName = "Postage", Start = 318, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("Postage", Order = 15, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("CDR-1111")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal Postage { get; set; }

		/// <summary>
		/// Fee (CDR-1112)
		/// Fee for Certificate of Mailing;  dollars.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1112", FieldName = "Fee", Start = 327, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Mailing;  dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1112", FieldName = "Fee", Start = 327, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Mailing;  dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("Fee", Order = 16, TypeName = "NUMERIC")]
		[Precision(3)]
		[Comment("CDR-1112")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? Fee { get; set; }

		/// <summary>
		/// PAL Fee Indicator (CDR-1113)
		/// (Weight is NOT over).
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1113", FieldName = "PAL Fee Indicator", Start = 336, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "(Weight is NOT over).", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1113", FieldName = "PAL Fee Indicator", Start = 336, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "(Weight is NOT over).", Type = "enum", Format = "leftjustify")]
		[Column("PALFeeIndicator", Order = 17, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E")]
		[Comment("CDR-1113")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PALFeeIndicators))]
		[MaildatVersions("24-1", "25-1")]
		public string PALFeeIndicator { get; set; }

		/// <summary>
		/// PAL Fee Amount (CDR-1114)
		/// Fee for Parcel Airlift; dollars.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1114", FieldName = "PAL Fee Amount", Start = 337, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Parcel Airlift; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1114", FieldName = "PAL Fee Amount", Start = 337, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Parcel Airlift; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("PALFeeAmount", Order = 18, TypeName = "NUMERIC")]
		[Precision(3)]
		[Comment("CDR-1114")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? PALFeeAmount { get; set; }

		/// <summary>
		/// Piece ID (CDR-1115)
		/// Set for Future Use - Unique ID of individual piece within a mailing.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1115", FieldName = "Piece ID", Start = 346, Length = 22, Required = false, Key = false, DataType = "A/N", Description = "Set for Future Use - Unique ID of individual piece within a mailing. One of the following two values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID, zero fill prior to numeric, if numeric only.", Type = "string", Format = "zfillnumeric", References = "PDR-1018,PBC-1002")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1115", FieldName = "Piece ID", Start = 346, Length = 22, Required = false, Key = false, DataType = "A/N", Description = "Set for Future Use - Unique ID of individual piece within a mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018,PBC-1002")]
		[Column("PieceId", Order = 19, TypeName = "TEXT")]
		[MaxLength(22)]
		[Comment("CDR-1115")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// Flex Option A (CDR-1116)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1116", FieldName = "Flex Option A", Start = 368, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1116", FieldName = "Flex Option A", Start = 368, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 20, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CDR-1116")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CDR-1117)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1117", FieldName = "Flex Option B", Start = 370, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1117", FieldName = "Flex Option B", Start = 370, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 21, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CDR-1117")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CDR-1118)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1118", FieldName = "Flex Option C", Start = 372, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1118", FieldName = "Flex Option C", Start = 372, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 22, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CDR-1118")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CDR-1119)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-1119", FieldName = "Reserve", Start = 374, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-1119", FieldName = "Reserve", Start = 374, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCdr1119", Order = 23, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CDR-1119")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ReserveCdr1119 { get; set; }

		/// <summary>
		/// CDR Record Status (CDR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-2000", FieldName = "CDR Record Status", Start = 394, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-2000", FieldName = "CDR Record Status", Start = 394, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CdrRecordStatus", Order = 24, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CDR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CdrRecordStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CdrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cdr", FieldCode = "CDR-9999", FieldName = "Closing Character", Start = 395, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cdr", FieldCode = "CDR-9999", FieldName = "Closing Character", Start = 395, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 25, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CDR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Cdr, string>(version, p => p.JobId, returnValue);
			this.CertificateOfMailingHeaderId = line.ParseForImport<Cdr, string>(version, p => p.CertificateOfMailingHeaderId, returnValue);
			this.ComPieceId = line.ParseForImport<Cdr, string>(version, p => p.ComPieceId, returnValue);
			this.FirmSpecificId = line.ParseForImport<Cdr, string>(version, p => p.FirmSpecificId, returnValue);
			this.USPSTrackingNumber = line.ParseForImport<Cdr, string>(version, p => p.USPSTrackingNumber, returnValue);
			this.RecipientName = line.ParseForImport<Cdr, string>(version, p => p.RecipientName, returnValue);
			this.SecondaryAddress = line.ParseForImport<Cdr, string>(version, p => p.SecondaryAddress, returnValue);
			this.PrimaryAddress = line.ParseForImport<Cdr, string>(version, p => p.PrimaryAddress, returnValue);
			this.City = line.ParseForImport<Cdr, string>(version, p => p.City, returnValue);
			this.State = line.ParseForImport<Cdr, string>(version, p => p.State, returnValue);
			this.PostalCode = line.ParseForImport<Cdr, string>(version, p => p.PostalCode, returnValue);
			this.ProvinceOrStateInternational = line.ParseForImport<Cdr, string>(version, p => p.ProvinceOrStateInternational, returnValue);
			this.CountryCode = line.ParseForImport<Cdr, string>(version, p => p.CountryCode, returnValue);
			this.Postage = line.ParseForImport<Cdr, decimal>(version, p => p.Postage, returnValue);
			this.Fee = line.ParseForImport<Cdr, decimal?>(version, p => p.Fee, returnValue);
			this.PALFeeIndicator = line.ParseForImport<Cdr, string>(version, p => p.PALFeeIndicator, returnValue);
			this.PALFeeAmount = line.ParseForImport<Cdr, decimal?>(version, p => p.PALFeeAmount, returnValue);
			this.PieceId = line.ParseForImport<Cdr, string>(version, p => p.PieceId, returnValue);
			this.FlexOptionA = line.ParseForImport<Cdr, string>(version, p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Cdr, string>(version, p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Cdr, string>(version, p => p.FlexOptionC, returnValue);
			this.ReserveCdr1119 = line.ParseForImport<Cdr, string>(version, p => p.ReserveCdr1119, returnValue);
			this.CdrRecordStatus = line.ParseForImport<Cdr, string>(version, p => p.CdrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cdr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Cdr, string>(version, p => p.JobId));
			sb.Append(this.CertificateOfMailingHeaderId.FormatForExport<Cdr, string>(version, p => p.CertificateOfMailingHeaderId));
			sb.Append(this.ComPieceId.FormatForExport<Cdr, string>(version, p => p.ComPieceId));
			sb.Append(this.FirmSpecificId.FormatForExport<Cdr, string>(version, p => p.FirmSpecificId));
			sb.Append(this.USPSTrackingNumber.FormatForExport<Cdr, string>(version, p => p.USPSTrackingNumber));
			sb.Append(this.RecipientName.FormatForExport<Cdr, string>(version, p => p.RecipientName));
			sb.Append(this.SecondaryAddress.FormatForExport<Cdr, string>(version, p => p.SecondaryAddress));
			sb.Append(this.PrimaryAddress.FormatForExport<Cdr, string>(version, p => p.PrimaryAddress));
			sb.Append(this.City.FormatForExport<Cdr, string>(version, p => p.City));
			sb.Append(this.State.FormatForExport<Cdr, string>(version, p => p.State));
			sb.Append(this.PostalCode.FormatForExport<Cdr, string>(version, p => p.PostalCode));
			sb.Append(this.ProvinceOrStateInternational.FormatForExport<Cdr, string>(version, p => p.ProvinceOrStateInternational));
			sb.Append(this.CountryCode.FormatForExport<Cdr, string>(version, p => p.CountryCode));
			sb.Append(this.Postage.FormatForExport<Cdr, decimal>(version, p => p.Postage));
			sb.Append(this.Fee.FormatForExport<Cdr, decimal?>(version, p => p.Fee));
			sb.Append(this.PALFeeIndicator.FormatForExport<Cdr, string>(version, p => p.PALFeeIndicator));
			sb.Append(this.PALFeeAmount.FormatForExport<Cdr, decimal?>(version, p => p.PALFeeAmount));
			sb.Append(this.PieceId.FormatForExport<Cdr, string>(version, p => p.PieceId));
			sb.Append(this.FlexOptionA.FormatForExport<Cdr, string>(version, p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Cdr, string>(version, p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Cdr, string>(version, p => p.FlexOptionC));
			sb.Append(this.ReserveCdr1119.FormatForExport<Cdr, string>(version, p => p.ReserveCdr1119));
			sb.Append(this.CdrRecordStatus.FormatForExport<Cdr, string>(version, p => p.CdrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Cdr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}