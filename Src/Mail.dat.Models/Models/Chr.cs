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
	/// Is used to capture the header information that is present on the Certificate of Mailing Form.
	/// Provides the header information that is present on the Certificate of Mailing Forms.
	/// </summary>
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "chr", File = "Certificate of Mailing Header record", Summary = "Is used to capture the header information that is present on the Certificate of Mailing Form.", Description = "Is used to capture the header information that is present on the Certificate of Mailing Form. Provides the header information that is present on the Certificate of Mailing Forms.", LineLength = 347, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "chr", File = "Certificate of Mailing Header record", Summary = "Is used to capture the header information that is present on the Certificate of Mailing Form.", Description = "Is used to capture the header information that is present on the Certificate of Mailing Form. Provides the header information that is present on the Certificate of Mailing Forms.", LineLength = 386, ClosingCharacter = "#")]
	[MaildatImport(Order = 25, Version = "24-1")]
	[MaildatImport(Order = 25, Version = "25-1")]
	[Table("Chr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("24-1", "25-1")]
	public partial class Chr : MaildatEntity, IChr 
	{
		/// <summary>
		/// Job ID (CHR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CHR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Certificate of Mailing Header ID (CHR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1002", FieldName = "Certificate of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1002", FieldName = "Certificate of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric")]
		[Column("CertificateOfMailingHeaderId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CHR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// Form Type (CHR-1101)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1101", FieldName = "Form Type", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1101", FieldName = "Form Type", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("FormType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F")]
		[Comment("CHR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(FormTypes))]
		[MaildatVersions("24-1", "25-1")]
		public string FormType { get; set; }

		/// <summary>
		/// Sender Tracking ID (CHR-1102)
		/// Unique ID generated by the sender.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1102", FieldName = "Sender Tracking ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Unique ID generated by the sender.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1102", FieldName = "Sender Tracking ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Unique ID generated by the sender.", Type = "string", Format = "zfillnumeric")]
		[Column("SenderTrackingId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("CHR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string SenderTrackingId { get; set; }

		/// <summary>
		/// Presort Mailing Job ID (CHR-1103)
		/// Job ID of Presort Mailing.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1103", FieldName = "Presort Mailing Job ID", Start = 26, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID of Presort Mailing.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1103", FieldName = "Presort Mailing Job ID", Start = 26, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID of Presort Mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("PresortMailingJobId", Order = 6, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("CHR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string PresortMailingJobId { get; set; }

		/// <summary>
		/// Presort Mailing User License Code (CHR-1104)
		/// ULC documented in the Presort Mailing job referenced by Presort Mailing Job ID.  Must - begin with
		/// an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1104", FieldName = "Presort Mailing User License Code", Start = 34, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC documented in the Presort Mailing job referenced by Presort Mailing Job ID.  Must - begin with an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1104", FieldName = "Presort Mailing User License Code", Start = 34, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC documented in the Presort Mailing job referenced by Presort Mailing Job ID.  Must - begin with an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[Column("PresortMailingUserLicenseCode", Order = 7, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("CHR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string PresortMailingUserLicenseCode { get; set; }

		/// <summary>
		/// Mail Owner Contact Name (CHR-1105)
		/// Ex: John Smith. Name of individual for contact support for this Form.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1105", FieldName = "Mail Owner Contact Name", Start = 38, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support for this Form.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1105", FieldName = "Mail Owner Contact Name", Start = 38, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support for this Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerContactName", Order = 8, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerContactName { get; set; }

		/// <summary>
		/// Mail Owner Company Name (CHR-1106)
		/// Name of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1106", FieldName = "Mail Owner Company Name", Start = 88, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Name of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1106", FieldName = "Mail Owner Company Name", Start = 88, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Name of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCompanyName", Order = 9, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerCompanyName { get; set; }

		/// <summary>
		/// Mail Owner Secondary Address (CHR-1107)
		/// Secondary Address of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1107", FieldName = "Mail Owner Secondary Address", Start = 138, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1107", FieldName = "Mail Owner Secondary Address", Start = 138, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerSecondaryAddress", Order = 10, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerSecondaryAddress { get; set; }

		/// <summary>
		/// Mail Owner Primary Address (CHR-1108)
		/// Primary Address of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1108", FieldName = "Mail Owner Primary Address", Start = 188, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Primary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1108", FieldName = "Mail Owner Primary Address", Start = 188, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Primary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerPrimaryAddress", Order = 11, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerPrimaryAddress { get; set; }

		/// <summary>
		/// Mail Owner City (CHR-1109)
		/// City of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1109", FieldName = "Mail Owner City", Start = 238, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "City of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1109", FieldName = "Mail Owner City", Start = 238, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "City of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCity", Order = 12, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CHR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerCity { get; set; }

		/// <summary>
		/// Mail Owner State (CHR-1110)
		/// State of Organization that owns the records and the Form. Required for addresses in the United
		/// States.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1110", FieldName = "Mail Owner State", Start = 268, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "State of Organization that owns the records and the Form. Required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1110", FieldName = "Mail Owner State", Start = 268, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "State of Organization that owns the records and the Form. Required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerState", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerState { get; set; }

		/// <summary>
		/// Mail Owner Postal Code (CHR-1111)
		/// ZIP Code or Postal Code of Organization that owns the records and the Form. Left Justify; numeric
		/// values of the applicable 5-Digit, or 9-Digit, Barcode for the specific piece. If specifying a
		/// 5-digit barcode, then leave the rest of the field blank.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1111", FieldName = "Mail Owner Postal Code", Start = 270, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of Organization that owns the records and the Form. Left Justify; numeric values of the applicable 5-Digit, or 9-Digit, Barcode for the specific piece. If specifying a 5-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1111", FieldName = "Mail Owner Postal Code", Start = 270, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of Organization that owns the records and the Form. Left Justify; numeric values of the applicable 5-Digit, or 9-Digit, Barcode for the specific piece. If specifying a 5-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerPostalCode", Order = 14, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CHR-1111")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerPostalCode { get; set; }

		/// <summary>
		/// Mail Owner Province or State - International (CHR-1112)
		/// Province or State of owner's address.  Applicable for international addresses.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1112", FieldName = "Mail Owner Province or State - International", Start = 279, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province or State of owner's address.  Applicable for international addresses.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1112", FieldName = "Mail Owner Province or State - International", Start = 279, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province or State of owner's address.  Applicable for international addresses.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerProvinceOrStateInternational", Order = 15, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CHR-1112")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerProvinceOrStateInternational { get; set; }

		/// <summary>
		/// Mail Owner Country Code (CHR-1113)
		/// Country Code of owner's address.  When required populated with two-character ISO Country Code. Used
		/// for international addresses only.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1113", FieldName = "Mail Owner Country Code", Start = 299, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of owner's address.  When required populated with two-character ISO Country Code. Used for international addresses only.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1113", FieldName = "Mail Owner Country Code", Start = 299, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of owner's address.  When required populated with two-character ISO Country Code. Used for international addresses only.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCountryCode", Order = 16, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1113")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MailOwnerCountryCode { get; set; }

		/// <summary>
		/// Mailing Date (CHR-1114)
		/// The date on which postage is paid to the USPS and verification is completed.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1114", FieldName = "Mailing Date", Start = 301, Length = 8, Required = false, Key = false, DataType = "N", Description = "The date on which postage is paid to the USPS and verification is completed.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1114", FieldName = "Mailing Date", Start = 301, Length = 8, Required = false, Key = false, DataType = "N", Description = "The date on which postage is paid to the USPS and verification is completed.", Type = "date", Format = "YYYYMMDD")]
		[Column("MailingDate", Order = 17, TypeName = "TEXT")]
		[Comment("CHR-1114")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("24-1", "25-1")]
		public DateOnly? MailingDate { get; set; }

		/// <summary>
		/// Certificate Status (CHR-1115)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1115", FieldName = "Certificate Status", Start = 309, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1115", FieldName = "Certificate Status", Start = 309, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateStatus", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "C", "R")]
		[Comment("CHR-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CertificateStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateStatus { get; set; }

		/// <summary>
		/// MPA ID (CHR-1116)
		/// Identify the permit paying for the Certificate of Mailing fees.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1116", FieldName = "MPA ID", Start = 310, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Identify the permit paying for the Certificate of Mailing fees.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1116", FieldName = "MPA ID", Start = 310, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Identify the permit paying for the Certificate of Mailing fees.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[Column("MpaId", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("CHR-1116")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string MpaId { get; set; }

		/// <summary>
		/// Flex Option A (CHR-1117)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1117", FieldName = "Flex Option A", Start = 320, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1117", FieldName = "Flex Option A", Start = 359, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 20, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1117")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CHR-1118)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1118", FieldName = "Flex Option B", Start = 322, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1118", FieldName = "Flex Option B", Start = 361, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 21, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1118")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CHR-1119)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1119", FieldName = "Flex Option C", Start = 324, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1119", FieldName = "Flex Option C", Start = 363, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 22, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1119")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CHR-1120)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-1120", FieldName = "Reserve", Start = 326, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1120", FieldName = "Reserve", Start = 365, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveChr1120", Order = 23, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CHR-1120")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ReserveChr1120 { get; set; }

		/// <summary>
		/// CHR Record Status (CHR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-2000", FieldName = "CHR Record Status", Start = 346, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-2000", FieldName = "CHR Record Status", Start = 385, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("ChrRecordStatus", Order = 24, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CHR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ChrRecordStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string ChrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CHR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "chr", FieldCode = "CHR-9999", FieldName = "Closing Character", Start = 347, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-9999", FieldName = "Closing Character", Start = 386, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 25, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CHR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Verification Facility Name (CHR-1121)
		/// Name of Mailing Facility where verification occurs.
		/// </summary>
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1121", FieldName = "Verification Facility Name", Start = 320, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Name of Mailing Facility where verification occurs.", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityName", Order = 26, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CHR-1121")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("25-1")]
		public string VerificationFacilityName { get; set; }

		/// <summary>
		/// Verification Facility ZIP Code (CHR-1122)
		/// ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the
		/// DMU).
		/// </summary>
		[MaildatField(Version = "25-1", Extension = "chr", FieldCode = "CHR-1122", FieldName = "Verification Facility ZIP Code", Start = 350, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the DMU).", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityZipCode", Order = 27, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CHR-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("25-1")]
		public string VerificationFacilityZipCode { get; set; }

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Chr, string>(version, p => p.JobId, returnValue);
			this.CertificateOfMailingHeaderId = line.ParseForImport<Chr, string>(version, p => p.CertificateOfMailingHeaderId, returnValue);
			this.FormType = line.ParseForImport<Chr, string>(version, p => p.FormType, returnValue);
			this.SenderTrackingId = line.ParseForImport<Chr, string>(version, p => p.SenderTrackingId, returnValue);
			this.PresortMailingJobId = line.ParseForImport<Chr, string>(version, p => p.PresortMailingJobId, returnValue);
			this.PresortMailingUserLicenseCode = line.ParseForImport<Chr, string>(version, p => p.PresortMailingUserLicenseCode, returnValue);
			this.MailOwnerContactName = line.ParseForImport<Chr, string>(version, p => p.MailOwnerContactName, returnValue);
			this.MailOwnerCompanyName = line.ParseForImport<Chr, string>(version, p => p.MailOwnerCompanyName, returnValue);
			this.MailOwnerSecondaryAddress = line.ParseForImport<Chr, string>(version, p => p.MailOwnerSecondaryAddress, returnValue);
			this.MailOwnerPrimaryAddress = line.ParseForImport<Chr, string>(version, p => p.MailOwnerPrimaryAddress, returnValue);
			this.MailOwnerCity = line.ParseForImport<Chr, string>(version, p => p.MailOwnerCity, returnValue);
			this.MailOwnerState = line.ParseForImport<Chr, string>(version, p => p.MailOwnerState, returnValue);
			this.MailOwnerPostalCode = line.ParseForImport<Chr, string>(version, p => p.MailOwnerPostalCode, returnValue);
			this.MailOwnerProvinceOrStateInternational = line.ParseForImport<Chr, string>(version, p => p.MailOwnerProvinceOrStateInternational, returnValue);
			this.MailOwnerCountryCode = line.ParseForImport<Chr, string>(version, p => p.MailOwnerCountryCode, returnValue);
			this.MailingDate = line.ParseForImport<Chr, DateOnly?>(version, p => p.MailingDate, returnValue);
			this.CertificateStatus = line.ParseForImport<Chr, string>(version, p => p.CertificateStatus, returnValue);
			this.MpaId = line.ParseForImport<Chr, string>(version, p => p.MpaId, returnValue);
			this.FlexOptionA = line.ParseForImport<Chr, string>(version, p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Chr, string>(version, p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Chr, string>(version, p => p.FlexOptionC, returnValue);
			this.ReserveChr1120 = line.ParseForImport<Chr, string>(version, p => p.ReserveChr1120, returnValue);
			this.ChrRecordStatus = line.ParseForImport<Chr, string>(version, p => p.ChrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Chr, string>(version, p => p.ClosingCharacter, returnValue);
			this.VerificationFacilityName = line.ParseForImport<Chr, string>(version, p => p.VerificationFacilityName, returnValue);
			this.VerificationFacilityZipCode = line.ParseForImport<Chr, string>(version, p => p.VerificationFacilityZipCode, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Chr, string>(version, p => p.JobId));
			sb.Append(this.CertificateOfMailingHeaderId.FormatForExport<Chr, string>(version, p => p.CertificateOfMailingHeaderId));
			sb.Append(this.FormType.FormatForExport<Chr, string>(version, p => p.FormType));
			sb.Append(this.SenderTrackingId.FormatForExport<Chr, string>(version, p => p.SenderTrackingId));
			sb.Append(this.PresortMailingJobId.FormatForExport<Chr, string>(version, p => p.PresortMailingJobId));
			sb.Append(this.PresortMailingUserLicenseCode.FormatForExport<Chr, string>(version, p => p.PresortMailingUserLicenseCode));
			sb.Append(this.MailOwnerContactName.FormatForExport<Chr, string>(version, p => p.MailOwnerContactName));
			sb.Append(this.MailOwnerCompanyName.FormatForExport<Chr, string>(version, p => p.MailOwnerCompanyName));
			sb.Append(this.MailOwnerSecondaryAddress.FormatForExport<Chr, string>(version, p => p.MailOwnerSecondaryAddress));
			sb.Append(this.MailOwnerPrimaryAddress.FormatForExport<Chr, string>(version, p => p.MailOwnerPrimaryAddress));
			sb.Append(this.MailOwnerCity.FormatForExport<Chr, string>(version, p => p.MailOwnerCity));
			sb.Append(this.MailOwnerState.FormatForExport<Chr, string>(version, p => p.MailOwnerState));
			sb.Append(this.MailOwnerPostalCode.FormatForExport<Chr, string>(version, p => p.MailOwnerPostalCode));
			sb.Append(this.MailOwnerProvinceOrStateInternational.FormatForExport<Chr, string>(version, p => p.MailOwnerProvinceOrStateInternational));
			sb.Append(this.MailOwnerCountryCode.FormatForExport<Chr, string>(version, p => p.MailOwnerCountryCode));
			sb.Append(this.MailingDate.FormatForExport<Chr, DateOnly?>(version, p => p.MailingDate));
			sb.Append(this.CertificateStatus.FormatForExport<Chr, string>(version, p => p.CertificateStatus));
			sb.Append(this.MpaId.FormatForExport<Chr, string>(version, p => p.MpaId));
			sb.Append(this.FlexOptionA.FormatForExport<Chr, string>(version, p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Chr, string>(version, p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Chr, string>(version, p => p.FlexOptionC));
			sb.Append(this.ReserveChr1120.FormatForExport<Chr, string>(version, p => p.ReserveChr1120));
			sb.Append(this.ChrRecordStatus.FormatForExport<Chr, string>(version, p => p.ChrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Chr, string>(version, p => p.ClosingCharacter));
			sb.Append(this.VerificationFacilityName.FormatForExport<Chr, string>(version, p => p.VerificationFacilityName));
			sb.Append(this.VerificationFacilityZipCode.FormatForExport<Chr, string>(version, p => p.VerificationFacilityZipCode));
			
			return Task.FromResult(sb.ToString());
		}
	}
}