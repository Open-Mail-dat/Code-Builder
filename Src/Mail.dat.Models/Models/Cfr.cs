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
	/// Provides the fee information that is present on the Certificate of Mail Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cfr", File = "Certification of Mailing Services Fee Record", Summary = "Is used to capture the service fee information.", Description = "Provides the fee information that is present on the Certificate of Mail Forms.", LineLength = 115, ClosingCharacter = "#")]
	[Table("Cfr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 28)]
	public partial class Cfr : MaildatEntity, ICfr 
	{
		/// <summary>
		/// Job ID (CFR-1001)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CFR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CFR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CFR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Piece ID (CFR-1003)
		/// Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this
		/// record may be replaced by SFR.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1003", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this record may be replaced by SFR.", Type = "string", Format = "zfillnumeric", References = "CDR-1003")]
		[Column("PieceID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("CFR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PieceID { get; set; }

		/// <summary>
		/// Service Type (CFR-1004)
		/// If, applicable *The dimension is under consideration and range to be defined in USPS documentation.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1004", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable *The dimension is under consideration and range to be defined in USPS documentation.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceType", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[AllowedValues("A", "B", "B2", "B3", "C", "C2", "CA", "CD", "D", "DP", "E", "E2", "EB", "F", "F2", "H", "HM", "HZ", "J", "J2", "K", "L", "L1", "L2", "L3", "L4", "PP", "PR", "SC", "U", "V", "X", "Y", "Z1", "Z2")]
		[Comment("CFR-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (CFR-1101)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z =
		/// Reserve.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1101", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z = Reserve.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceAdditionalType", Order = 6, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "C", "D", "F", "G", "H")]
		[Comment("CFR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (CFR-1102)
		/// Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1102", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceStatedValue", Order = 7, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1102")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (CFR-1103)
		/// Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for
		/// the one or more fees or charges noted above.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1103", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for the one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceFee", Order = 8, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (CFR-1104)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1104", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job and Segment. Cannot mix services of two different IDs within the same record.", Type = "string", Format = "zfillnumeric")]
		[Column("SpecialFeesChargesServicesID", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(22)]
		[Comment("CFR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SpecialFeesChargesServicesID { get; set; }

		/// <summary>
		/// Amount Due (CFR-1105)
		/// Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1105", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AmountDue", Order = 10, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CFR-1105")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? AmountDue { get; set; }

		/// <summary>
		/// Flex Option A (CFR-1106)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1106", FieldName = "Flex Option A", Start = 88, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 11, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CFR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1107", FieldName = "Flex Option B", Start = 90, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 12, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CFR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1108", FieldName = "Flex Option C", Start = 92, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CFR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CFR-1109)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1109", FieldName = "Reserve", Start = 94, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveCFR1109", Order = 14, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CFR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveCFR1109 { get; set; }

		/// <summary>
		/// CFR Record Status (CFR-2000)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-2000", FieldName = "CFR Record Status", Start = 114, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CFRRecordStatus", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CFR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CFRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CFR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-9999", FieldName = "Closing Character", Start = 115, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CFR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Cfr, string>(p => p.JobID, returnValue);
			this.CertificateOfMailingHeaderID = line.ParseForImport<Cfr, string>(p => p.CertificateOfMailingHeaderID, returnValue);
			this.PieceID = line.ParseForImport<Cfr, string>(p => p.PieceID, returnValue);
			this.ServiceType = line.ParseForImport<Cfr, string>(p => p.ServiceType, returnValue);
			this.ServiceAdditionalType = line.ParseForImport<Cfr, string>(p => p.ServiceAdditionalType, returnValue);
			this.ServiceStatedValue = line.ParseForImport<Cfr, decimal?>(p => p.ServiceStatedValue, returnValue);
			this.ServiceFee = line.ParseForImport<Cfr, decimal?>(p => p.ServiceFee, returnValue);
			this.SpecialFeesChargesServicesID = line.ParseForImport<Cfr, string>(p => p.SpecialFeesChargesServicesID, returnValue);
			this.AmountDue = line.ParseForImport<Cfr, decimal?>(p => p.AmountDue, returnValue);
			this.FlexOptionA = line.ParseForImport<Cfr, string>(p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Cfr, string>(p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Cfr, string>(p => p.FlexOptionC, returnValue);
			this.ReserveCFR1109 = line.ParseForImport<Cfr, string>(p => p.ReserveCFR1109, returnValue);
			this.CFRRecordStatus = line.ParseForImport<Cfr, string>(p => p.CFRRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cfr, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Cfr, string>(p => p.JobID));
			sb.Append(this.CertificateOfMailingHeaderID.FormatForExport<Cfr, string>(p => p.CertificateOfMailingHeaderID));
			sb.Append(this.PieceID.FormatForExport<Cfr, string>(p => p.PieceID));
			sb.Append(this.ServiceType.FormatForExport<Cfr, string>(p => p.ServiceType));
			sb.Append(this.ServiceAdditionalType.FormatForExport<Cfr, string>(p => p.ServiceAdditionalType));
			sb.Append(this.ServiceStatedValue.FormatForExport<Cfr, decimal?>(p => p.ServiceStatedValue));
			sb.Append(this.ServiceFee.FormatForExport<Cfr, decimal?>(p => p.ServiceFee));
			sb.Append(this.SpecialFeesChargesServicesID.FormatForExport<Cfr, string>(p => p.SpecialFeesChargesServicesID));
			sb.Append(this.AmountDue.FormatForExport<Cfr, decimal?>(p => p.AmountDue));
			sb.Append(this.FlexOptionA.FormatForExport<Cfr, string>(p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Cfr, string>(p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Cfr, string>(p => p.FlexOptionC));
			sb.Append(this.ReserveCFR1109.FormatForExport<Cfr, string>(p => p.ReserveCFR1109));
			sb.Append(this.CFRRecordStatus.FormatForExport<Cfr, string>(p => p.CFRRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Cfr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}