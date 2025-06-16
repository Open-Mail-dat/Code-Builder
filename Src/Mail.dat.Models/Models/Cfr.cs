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
	/// Is used to capture the service fee information. Provides the fee information that is present on the
	/// Certificate of Mail Forms.
	/// </summary>
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "cfr", File = "Certification of Mailing Services fee record", Summary = "Is used to capture the service fee information.", Description = "Is used to capture the service fee information. Provides the fee information that is present on the Certificate of Mail Forms.", LineLength = 115, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "cfr", File = "Certification of Mailing Services fee record", Summary = "Is used to capture the service fee information.", Description = "Is used to capture the service fee information. Provides the fee information that is present on the Certificate of Mail Forms.", LineLength = 115, ClosingCharacter = "#")]
	[MaildatImport(Order = 28, Version = "24-1")]
	[MaildatImport(Order = 28, Version = "25-1")]
	[Table("Cfr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("24-1", "25-1")]
	public partial class Cfr : MaildatEntity, ICfr 
	{
		/// <summary>
		/// Job ID (CFR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CFR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CFR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CFR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// COM Piece ID (CFR-1003)
		/// Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this
		/// record may be replaced by SFR.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1003", FieldName = "COM Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this record may be replaced by SFR.", Type = "string", Format = "zfillnumeric", References = "CDR-1003")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1003", FieldName = "COM Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this record may be replaced by SFR.", Type = "string", Format = "zfillnumeric", References = "CDR-1003")]
		[Column("ComPieceId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("CFR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ComPieceId { get; set; }

		/// <summary>
		/// Service Type (CFR-1004)
		/// If, applicable *The dimension is under consideration and range to be defined in USPS documentation.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1004", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable *The dimension is under consideration and range to be defined in USPS documentation.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1004", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable *The dimension is under consideration and range to be defined in USPS documentation.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceType", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[AllowedValues("A", "B", "B2", "B3", "C", "C2", "CA", "CD", "D", "DP", "E", "E2", "EB", "F", "F2", "H", "HM", "HZ", "J", "J2", "K", "L", "L1", "L2", "L3", "L4", "PP", "PR", "SC", "U", "V", "X", "Y", "Z1", "Z2")]
		[Comment("CFR-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ServiceTypes))]
		[MaildatVersions("24-1", "25-1")]
		public string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (CFR-1101)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z =
		/// Reserve.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1101", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z = Reserve.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1101", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z = Reserve.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceAdditionalType", Order = 6, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "C", "D", "F", "G", "H")]
		[Comment("CFR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ServiceAdditionalTypes))]
		[MaildatVersions("24-1", "25-1")]
		public string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (CFR-1102)
		/// Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1102", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for the one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1102", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceStatedValue", Order = 7, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1102")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (CFR-1103)
		/// Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for
		/// the one or more fees or charges noted above.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1103", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for the one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1103", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for the one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceFee", Order = 8, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (CFR-1104)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1104", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job and Segment. Cannot mix services of two different IDs within the same record.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1104", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job and Segment. Cannot mix services of two different IDs within the same record.", Type = "string", Format = "zfillnumeric")]
		[Column("SpecialFeesChargesServicesId", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(22)]
		[Comment("CFR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string SpecialFeesChargesServicesId { get; set; }

		/// <summary>
		/// Amount Due (CFR-1105)
		/// Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1105", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1105", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AmountDue", Order = 10, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1105")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? AmountDue { get; set; }

		/// <summary>
		/// Flex Option A (CFR-1106)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1106", FieldName = "Flex Option A", Start = 88, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1106", FieldName = "Flex Option A", Start = 88, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 11, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CFR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1107", FieldName = "Flex Option B", Start = 90, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1107", FieldName = "Flex Option B", Start = 90, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 12, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CFR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1108", FieldName = "Flex Option C", Start = 92, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1108", FieldName = "Flex Option C", Start = 92, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CFR-1109)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-1109", FieldName = "Reserve", Start = 94, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-1109", FieldName = "Reserve", Start = 94, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCfr1109", Order = 14, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CFR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ReserveCfr1109 { get; set; }

		/// <summary>
		/// CFR Record Status (CFR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-2000", FieldName = "CFR Record Status", Start = 114, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-2000", FieldName = "CFR Record Status", Start = 114, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CfrRecordStatus", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CFR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CfrRecordStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CfrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CFR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cfr", FieldCode = "CFR-9999", FieldName = "Closing Character", Start = 115, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cfr", FieldCode = "CFR-9999", FieldName = "Closing Character", Start = 115, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CFR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Cfr, string>(version, p => p.JobId, returnValue);
			this.CertificateOfMailingHeaderId = line.ParseForImport<Cfr, string>(version, p => p.CertificateOfMailingHeaderId, returnValue);
			this.ComPieceId = line.ParseForImport<Cfr, string>(version, p => p.ComPieceId, returnValue);
			this.ServiceType = line.ParseForImport<Cfr, string>(version, p => p.ServiceType, returnValue);
			this.ServiceAdditionalType = line.ParseForImport<Cfr, string>(version, p => p.ServiceAdditionalType, returnValue);
			this.ServiceStatedValue = line.ParseForImport<Cfr, decimal?>(version, p => p.ServiceStatedValue, returnValue);
			this.ServiceFee = line.ParseForImport<Cfr, decimal?>(version, p => p.ServiceFee, returnValue);
			this.SpecialFeesChargesServicesId = line.ParseForImport<Cfr, string>(version, p => p.SpecialFeesChargesServicesId, returnValue);
			this.AmountDue = line.ParseForImport<Cfr, decimal?>(version, p => p.AmountDue, returnValue);
			this.FlexOptionA = line.ParseForImport<Cfr, string>(version, p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Cfr, string>(version, p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Cfr, string>(version, p => p.FlexOptionC, returnValue);
			this.ReserveCfr1109 = line.ParseForImport<Cfr, string>(version, p => p.ReserveCfr1109, returnValue);
			this.CfrRecordStatus = line.ParseForImport<Cfr, string>(version, p => p.CfrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cfr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Cfr, string>(version, p => p.JobId));
			sb.Append(this.CertificateOfMailingHeaderId.FormatForExport<Cfr, string>(version, p => p.CertificateOfMailingHeaderId));
			sb.Append(this.ComPieceId.FormatForExport<Cfr, string>(version, p => p.ComPieceId));
			sb.Append(this.ServiceType.FormatForExport<Cfr, string>(version, p => p.ServiceType));
			sb.Append(this.ServiceAdditionalType.FormatForExport<Cfr, string>(version, p => p.ServiceAdditionalType));
			sb.Append(this.ServiceStatedValue.FormatForExport<Cfr, decimal?>(version, p => p.ServiceStatedValue));
			sb.Append(this.ServiceFee.FormatForExport<Cfr, decimal?>(version, p => p.ServiceFee));
			sb.Append(this.SpecialFeesChargesServicesId.FormatForExport<Cfr, string>(version, p => p.SpecialFeesChargesServicesId));
			sb.Append(this.AmountDue.FormatForExport<Cfr, decimal?>(version, p => p.AmountDue));
			sb.Append(this.FlexOptionA.FormatForExport<Cfr, string>(version, p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Cfr, string>(version, p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Cfr, string>(version, p => p.FlexOptionC));
			sb.Append(this.ReserveCfr1109.FormatForExport<Cfr, string>(version, p => p.ReserveCfr1109));
			sb.Append(this.CfrRecordStatus.FormatForExport<Cfr, string>(version, p => p.CfrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Cfr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}