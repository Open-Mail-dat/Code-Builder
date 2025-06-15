//
// Copyright (c) 2025 Open Mail.dat
//
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
//
// This code was auto-generated on June 14th, 2025.
// by the Open Mail.dat Code Generator.
//
// Author: Daniel M porrey
//
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Special fees and charges (linked to .PDR). Records specific ancillary fees (linked to the .PDR or
	/// .PBC). To be only used for extra services.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "sfr", File = "Special Fees/Charges Record", Summary = "Special fees and charges (linked to .PDR).", Description = "Special fees and charges (linked to .PDR).", LineLength = 93, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.3", Extension = "sfr", File = "Special Fees/Charges Record", Summary = "Special fees and charges (linked to .PDR).", Description = "Special fees and charges (linked to .PDR). Records specific ancillary fees (linked to the .PDR or .PBC). To be only used for extra services.", LineLength = 93, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "sfr", File = "Special Fees/Charges Record", Summary = "Special fees and charges (linked to .PDR).", Description = "Special fees and charges (linked to .PDR). Records specific ancillary fees (linked to the .PDR or .PBC). To be only used for extra services.", LineLength = 93, ClosingCharacter = "#")]
	[MaildatImport(Order = 16, Version = "23-1")]
	[MaildatImport(Order = 16, Version = "24-1")]
	[MaildatImport(Order = 16, Version = "25-1")]
	[Table("Sfr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Sfr : MaildatEntity, ISfr 
	{
		/// <summary>
		/// Job ID (SFR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See Header File's Job ID definition.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("SFR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (SFR-1006)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1006", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1006", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1006", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[Comment("SFR-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Piece ID (SFR-1018)
		/// Unique ID of individual piece within a mailing.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1018", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1018", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018,PBC-1002")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1018", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018,PBC-1002")]
		[Column("PieceId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("SFR-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// Service Type (SFR-1019)
		/// If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each
		/// representing an Extra Service associated to the mailpiece.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1019", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each Representing an Extra Service associated to the mailpiece.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1019", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each Representing an Extra Service associated to the mailpiece.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1019", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each representing an Extra Service associated to the mailpiece.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceType", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[AllowedValues("A", "B", "B2", "B3", "C", "C2", "CA", "CD", "D", "DP", "E", "E2", "EB", "F", "F2", "H", "HM", "HZ", "J", "J2", "K", "L", "L1", "L2", "L3", "L4", "L5", "L6", "NP", "PP", "PR", "SC", "U", "V", "X", "Y", "Z1", "Z2")]
		[Comment("SFR-1019")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ServiceTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (SFR-1121)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested:.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1121", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested:.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1121", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested:.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1121", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested:.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceAdditionalType", Order = 6, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z")]
		[Comment("SFR-1121")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ServiceAdditionalTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (SFR-1101)
		/// Dollars/cents, rounded. The value of the single piece noted when applying for the Special Service.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1101", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "99999999v99; dollars/cents, rounded (decimal implied). The Value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1101", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "99999999v99; dollars/cents, rounded (decimal implied). The Value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1101", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded. The value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceStatedValue", Order = 7, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("SFR-1101")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (SFR-1102)
		/// Dollars/cents, rounded. Actual Postal dollars & cents incurred in costs for the specific piece for
		/// one or more fees or charges noted above.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1102", FieldName = "Service Fee", Start = 52, Length = 7, Required = true, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents incurred in costs for the specific Piece for one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1102", FieldName = "Service Fee", Start = 52, Length = 7, Required = true, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents incurred in costs for the specific Piece for one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1102", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded. Actual Postal dollars & cents incurred in costs for the specific piece for one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceFee", Order = 8, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("SFR-1102")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (SFR-1103)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1103", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job And Segment. Cannot mix services of two different IDs Within the same record.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1103", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job And Segment. Cannot mix services of two different IDs Within the same record.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1103", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job and Segment. Cannot mix services of two different IDs within the same record.", Type = "string", Format = "zfillnumeric")]
		[Column("SpecialFeesChargesServicesId", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(22)]
		[Comment("SFR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SpecialFeesChargesServicesId { get; set; }

		/// <summary>
		/// Amount Due (SFR-1120)
		/// Dollars/cents, rounded. Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1120", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents to be collected for the COD service For specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1120", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents to be collected for the COD service For specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1120", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded. Actual Postal dollars & cents to be collected for the COD service for specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AmountDue", Order = 10, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("SFR-1120")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? AmountDue { get; set; }

		/// <summary>
		/// SFR Record Status (SFR-2000)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-2000", FieldName = "SFR Record Status", Start = 88, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-2000", FieldName = "SFR Record Status", Start = 88, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-2000", FieldName = "SFR Record Status", Start = 88, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SfrRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("SFR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SfrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SfrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SFR-1104)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-1104", FieldName = "Reserve", Start = 89, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-1104", FieldName = "Reserve", Start = 89, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-1104", FieldName = "Reserve", Start = 89, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveSfr1104", Order = 12, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("SFR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveSfr1104 { get; set; }

		/// <summary>
		/// Closing Character (SFR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfr", FieldCode = "SFR-9999", FieldName = "Closing Character", Start = 93, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfr", FieldCode = "SFR-9999", FieldName = "Closing Character", Start = 93, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfr", FieldCode = "SFR-9999", FieldName = "Closing Character", Start = 93, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("SFR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Sfr, string>(version, p => p.JobId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Sfr, int>(version, p => p.CqtDatabaseId, returnValue);
			this.PieceId = line.ParseForImport<Sfr, string>(version, p => p.PieceId, returnValue);
			this.ServiceType = line.ParseForImport<Sfr, string>(version, p => p.ServiceType, returnValue);
			this.ServiceAdditionalType = line.ParseForImport<Sfr, string>(version, p => p.ServiceAdditionalType, returnValue);
			this.ServiceStatedValue = line.ParseForImport<Sfr, decimal?>(version, p => p.ServiceStatedValue, returnValue);
			this.ServiceFee = line.ParseForImport<Sfr, decimal>(version, p => p.ServiceFee, returnValue);
			this.SpecialFeesChargesServicesId = line.ParseForImport<Sfr, string>(version, p => p.SpecialFeesChargesServicesId, returnValue);
			this.AmountDue = line.ParseForImport<Sfr, decimal?>(version, p => p.AmountDue, returnValue);
			this.SfrRecordStatus = line.ParseForImport<Sfr, string>(version, p => p.SfrRecordStatus, returnValue);
			this.ReserveSfr1104 = line.ParseForImport<Sfr, string>(version, p => p.ReserveSfr1104, returnValue);
			this.ClosingCharacter = line.ParseForImport<Sfr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Sfr, string>(version, p => p.JobId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Sfr, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.PieceId.FormatForExport<Sfr, string>(version, p => p.PieceId));
			sb.Append(this.ServiceType.FormatForExport<Sfr, string>(version, p => p.ServiceType));
			sb.Append(this.ServiceAdditionalType.FormatForExport<Sfr, string>(version, p => p.ServiceAdditionalType));
			sb.Append(this.ServiceStatedValue.FormatForExport<Sfr, decimal?>(version, p => p.ServiceStatedValue));
			sb.Append(this.ServiceFee.FormatForExport<Sfr, decimal>(version, p => p.ServiceFee));
			sb.Append(this.SpecialFeesChargesServicesId.FormatForExport<Sfr, string>(version, p => p.SpecialFeesChargesServicesId));
			sb.Append(this.AmountDue.FormatForExport<Sfr, decimal?>(version, p => p.AmountDue));
			sb.Append(this.SfrRecordStatus.FormatForExport<Sfr, string>(version, p => p.SfrRecordStatus));
			sb.Append(this.ReserveSfr1104.FormatForExport<Sfr, string>(version, p => p.ReserveSfr1104));
			sb.Append(this.ClosingCharacter.FormatForExport<Sfr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}