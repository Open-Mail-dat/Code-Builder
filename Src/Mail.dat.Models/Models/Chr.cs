// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 30th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.3
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Provides the header information that is present on the Certificate of Mailing Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "chr", File = "Certificate of Mailing Header Record", Summary = "Is used to capture the header information that is present on the Certificate of Mailing Form.", Description = "Provides the header information that is present on the Certificate of Mailing Forms.", LineLength = 386, ClosingCharacter = "#")]
	[Table("Chr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 25)]
	public partial class Chr : MaildatEntity, IChr 
	{
		/// <summary>
		/// Job ID (CHR-1001)
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CHR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate of Mailing Header ID (CHR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1002", FieldName = "Certificate of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric")]
		[Column("CertificateOfMailingHeaderID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CHR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Form Type (CHR-1101)
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1101", FieldName = "Form Type", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("FormType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F")]
		[Comment("CHR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string FormType { get; set; }

		/// <summary>
		/// Sender Tracking ID (CHR-1102)
		/// Unique ID generated by the sender.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1102", FieldName = "Sender Tracking ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Unique ID generated by the sender.", Type = "string", Format = "zfillnumeric")]
		[Column("SenderTrackingID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("CHR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SenderTrackingID { get; set; }

		/// <summary>
		/// Presort Mailing Job ID (CHR-1103)
		/// Job ID of Presort Mailing.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1103", FieldName = "Presort Mailing Job ID", Start = 26, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID of Presort Mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("PresortMailingJobID", Order = 6, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("CHR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PresortMailingJobID { get; set; }

		/// <summary>
		/// Presort Mailing User License Code (CHR-1104)
		/// ULC documented in the Presort Mailing job referenced by Presort Mailing Job ID.  Must - begin with
		/// an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1104", FieldName = "Presort Mailing User License Code", Start = 34, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC documented in the Presort Mailing job referenced by Presort Mailing Job ID.  Must - begin with an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[Column("PresortMailingUserLicenseCode", Order = 7, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("CHR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PresortMailingUserLicenseCode { get; set; }

		/// <summary>
		/// Mail Owner Contact Name (CHR-1105)
		/// Ex: John Smith. Name of individual for contact support for this Form.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1105", FieldName = "Mail Owner Contact Name", Start = 38, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support for this Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerContactName", Order = 8, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerContactName { get; set; }

		/// <summary>
		/// Mail Owner Company Name (CHR-1106)
		/// Name of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1106", FieldName = "Mail Owner Company Name", Start = 88, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Name of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCompanyName", Order = 9, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerCompanyName { get; set; }

		/// <summary>
		/// Mail Owner Secondary Address (CHR-1107)
		/// Secondary Address of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1107", FieldName = "Mail Owner Secondary Address", Start = 138, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerSecondaryAddress", Order = 10, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerSecondaryAddress { get; set; }

		/// <summary>
		/// Mail Owner Primary Address (CHR-1108)
		/// Primary Address of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1108", FieldName = "Mail Owner Primary Address", Start = 188, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Primary Address of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerPrimaryAddress", Order = 11, TypeName = "TEXT")]
		[MaxLength(50)]
		[Comment("CHR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerPrimaryAddress { get; set; }

		/// <summary>
		/// Mail Owner City (CHR-1109)
		/// City of Organization that owns the records and the Form.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1109", FieldName = "Mail Owner City", Start = 238, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "City of Organization that owns the records and the Form.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCity", Order = 12, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CHR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerCity { get; set; }

		/// <summary>
		/// Mail Owner State (CHR-1110)
		/// State of Organization that owns the records and the Form. Required for addresses in the United
		/// States.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1110", FieldName = "Mail Owner State", Start = 268, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "State of Organization that owns the records and the Form. Required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerState", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerState { get; set; }

		/// <summary>
		/// Mail Owner Postal Code (CHR-1111)
		/// ZIP Code or Postal Code of Organization that owns the records and the Form. Left Justify; numeric
		/// values of the applicable 5-Digit, or 9-Digit, Barcode for the specific piece. If specifying a
		/// 5-digit barcode, then leave the rest of the field blank.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1111", FieldName = "Mail Owner Postal Code", Start = 270, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of Organization that owns the records and the Form. Left Justify; numeric values of the applicable 5-Digit, or 9-Digit, Barcode for the specific piece. If specifying a 5-digit barcode, then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerPostalCode", Order = 14, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CHR-1111")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerPostalCode { get; set; }

		/// <summary>
		/// Mail Owner Province or State - International (CHR-1112)
		/// Province or State of owner's address.  Applicable for international addresses.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1112", FieldName = "Mail Owner Province or State - International", Start = 279, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province or State of owner's address.  Applicable for international addresses.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerProvinceOrStateInternational", Order = 15, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CHR-1112")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerProvinceOrStateInternational { get; set; }

		/// <summary>
		/// Mail Owner Country Code (CHR-1113)
		/// Country Code of owner's address.  When required populated with two-character ISO Country Code. Used
		/// for international addresses only.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1113", FieldName = "Mail Owner Country Code", Start = 299, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of owner's address.  When required populated with two-character ISO Country Code. Used for international addresses only.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerCountryCode", Order = 16, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1113")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerCountryCode { get; set; }

		/// <summary>
		/// Mailing Date (CHR-1114)
		/// The date on which postage is paid to the USPS and verification is completed.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1114", FieldName = "Mailing Date", Start = 301, Length = 8, Required = false, Key = false, DataType = "N", Description = "The date on which postage is paid to the USPS and verification is completed.", Type = "date", Format = "YYYYMMDD")]
		[Column("MailingDate", Order = 17, TypeName = "TEXT")]
		[Comment("CHR-1114")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? MailingDate { get; set; }

		/// <summary>
		/// Certificate Status (CHR-1115)
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1115", FieldName = "Certificate Status", Start = 309, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateStatus", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "C", "R")]
		[Comment("CHR-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CertificateStatus { get; set; }

		/// <summary>
		/// MPA ID (CHR-1116)
		/// Identify the permit paying for the Certificate of Mailing fees.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1116", FieldName = "MPA ID", Start = 310, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Identify the permit paying for the Certificate of Mailing fees.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[Column("MPAID", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("CHR-1116")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MPAID { get; set; }

		/// <summary>
		/// Verification Facility Name (CHR-1121)
		/// Name of Mailing Facility where verification occurs.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1121", FieldName = "Verification Facility Name", Start = 320, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Name of Mailing Facility where verification occurs.", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityName", Order = 20, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CHR-1121")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string VerificationFacilityName { get; set; }

		/// <summary>
		/// Verification Facility ZIP Code (CHR-1122)
		/// ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the
		/// DMU).
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1122", FieldName = "Verification Facility ZIP Code", Start = 350, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the DMU).", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityZIPCode", Order = 21, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CHR-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string VerificationFacilityZIPCode { get; set; }

		/// <summary>
		/// Flex Option A (CHR-1117)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1117", FieldName = "Flex Option A", Start = 359, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 22, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1117")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CHR-1118)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1118", FieldName = "Flex Option B", Start = 361, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 23, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1118")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CHR-1119)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1119", FieldName = "Flex Option C", Start = 363, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 24, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CHR-1119")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CHR-1120)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-1120", FieldName = "Reserve", Start = 365, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "reserve", Format = "leftjustify")]
		[Column("ReserveCHR1120", Order = 25, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CHR-1120")]
		[TypeConverter(typeof(MaildatReserveConverter))]
		public string ReserveCHR1120 { get; set; }

		/// <summary>
		/// CHR Record Status (CHR-2000)
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-2000", FieldName = "CHR Record Status", Start = 385, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CHRRecordStatus", Order = 26, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CHR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CHRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CHR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "chr", FieldCode = "CHR-9999", FieldName = "Closing Character", Start = 386, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 27, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CHR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Chr, string>(p => p.JobID, returnValue);
			this.CertificateOfMailingHeaderID = line.ParseForImport<Chr, string>(p => p.CertificateOfMailingHeaderID, returnValue);
			this.FormType = line.ParseForImport<Chr, string>(p => p.FormType, returnValue);
			this.SenderTrackingID = line.ParseForImport<Chr, string>(p => p.SenderTrackingID, returnValue);
			this.PresortMailingJobID = line.ParseForImport<Chr, string>(p => p.PresortMailingJobID, returnValue);
			this.PresortMailingUserLicenseCode = line.ParseForImport<Chr, string>(p => p.PresortMailingUserLicenseCode, returnValue);
			this.MailOwnerContactName = line.ParseForImport<Chr, string>(p => p.MailOwnerContactName, returnValue);
			this.MailOwnerCompanyName = line.ParseForImport<Chr, string>(p => p.MailOwnerCompanyName, returnValue);
			this.MailOwnerSecondaryAddress = line.ParseForImport<Chr, string>(p => p.MailOwnerSecondaryAddress, returnValue);
			this.MailOwnerPrimaryAddress = line.ParseForImport<Chr, string>(p => p.MailOwnerPrimaryAddress, returnValue);
			this.MailOwnerCity = line.ParseForImport<Chr, string>(p => p.MailOwnerCity, returnValue);
			this.MailOwnerState = line.ParseForImport<Chr, string>(p => p.MailOwnerState, returnValue);
			this.MailOwnerPostalCode = line.ParseForImport<Chr, string>(p => p.MailOwnerPostalCode, returnValue);
			this.MailOwnerProvinceOrStateInternational = line.ParseForImport<Chr, string>(p => p.MailOwnerProvinceOrStateInternational, returnValue);
			this.MailOwnerCountryCode = line.ParseForImport<Chr, string>(p => p.MailOwnerCountryCode, returnValue);
			this.MailingDate = line.ParseForImport<Chr, DateOnly?>(p => p.MailingDate, returnValue);
			this.CertificateStatus = line.ParseForImport<Chr, string>(p => p.CertificateStatus, returnValue);
			this.MPAID = line.ParseForImport<Chr, string>(p => p.MPAID, returnValue);
			this.VerificationFacilityName = line.ParseForImport<Chr, string>(p => p.VerificationFacilityName, returnValue);
			this.VerificationFacilityZIPCode = line.ParseForImport<Chr, string>(p => p.VerificationFacilityZIPCode, returnValue);
			this.FlexOptionA = line.ParseForImport<Chr, string>(p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Chr, string>(p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Chr, string>(p => p.FlexOptionC, returnValue);
			this.ReserveCHR1120 = line.ParseForImport<Chr, string>(p => p.ReserveCHR1120, returnValue);
			this.CHRRecordStatus = line.ParseForImport<Chr, string>(p => p.CHRRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Chr, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Chr, string>(p => p.JobID));
			sb.Append(this.CertificateOfMailingHeaderID.FormatForExport<Chr, string>(p => p.CertificateOfMailingHeaderID));
			sb.Append(this.FormType.FormatForExport<Chr, string>(p => p.FormType));
			sb.Append(this.SenderTrackingID.FormatForExport<Chr, string>(p => p.SenderTrackingID));
			sb.Append(this.PresortMailingJobID.FormatForExport<Chr, string>(p => p.PresortMailingJobID));
			sb.Append(this.PresortMailingUserLicenseCode.FormatForExport<Chr, string>(p => p.PresortMailingUserLicenseCode));
			sb.Append(this.MailOwnerContactName.FormatForExport<Chr, string>(p => p.MailOwnerContactName));
			sb.Append(this.MailOwnerCompanyName.FormatForExport<Chr, string>(p => p.MailOwnerCompanyName));
			sb.Append(this.MailOwnerSecondaryAddress.FormatForExport<Chr, string>(p => p.MailOwnerSecondaryAddress));
			sb.Append(this.MailOwnerPrimaryAddress.FormatForExport<Chr, string>(p => p.MailOwnerPrimaryAddress));
			sb.Append(this.MailOwnerCity.FormatForExport<Chr, string>(p => p.MailOwnerCity));
			sb.Append(this.MailOwnerState.FormatForExport<Chr, string>(p => p.MailOwnerState));
			sb.Append(this.MailOwnerPostalCode.FormatForExport<Chr, string>(p => p.MailOwnerPostalCode));
			sb.Append(this.MailOwnerProvinceOrStateInternational.FormatForExport<Chr, string>(p => p.MailOwnerProvinceOrStateInternational));
			sb.Append(this.MailOwnerCountryCode.FormatForExport<Chr, string>(p => p.MailOwnerCountryCode));
			sb.Append(this.MailingDate.FormatForExport<Chr, DateOnly?>(p => p.MailingDate));
			sb.Append(this.CertificateStatus.FormatForExport<Chr, string>(p => p.CertificateStatus));
			sb.Append(this.MPAID.FormatForExport<Chr, string>(p => p.MPAID));
			sb.Append(this.VerificationFacilityName.FormatForExport<Chr, string>(p => p.VerificationFacilityName));
			sb.Append(this.VerificationFacilityZIPCode.FormatForExport<Chr, string>(p => p.VerificationFacilityZIPCode));
			sb.Append(this.FlexOptionA.FormatForExport<Chr, string>(p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Chr, string>(p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Chr, string>(p => p.FlexOptionC));
			sb.Append(this.ReserveCHR1120.FormatForExport<Chr, string>(p => p.ReserveCHR1120));
			sb.Append(this.CHRRecordStatus.FormatForExport<Chr, string>(p => p.CHRRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Chr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}