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
	/// Table showing relationship of MPUs to Components.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "mcr", File = "MPU / C - RELATIONSHIP RECORD", Summary = "Table showing relationship of MPUs to Components.", Description = "Table showing relationship of MPUs to Components.", LineLength = 100, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.3", Extension = "mcr", File = "MPU / C - RELATIONSHIP RECORD", Summary = "Table showing relationship of MPUs to Components.", Description = "Table showing relationship of MPUs to Components.", LineLength = 100, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "mcr", File = "MPU / C - RELATIONSHIP RECORD", Summary = "Table showing relationship of MPUs to Components.", Description = "Table showing relationship of MPUs to Components.", LineLength = 100, ClosingCharacter = "#")]
	[MaildatImport(Order = 4, Version = "23-1")]
	[MaildatImport(Order = 4, Version = "24-1")]
	[MaildatImport(Order = 4, Version = "25-1")]
	[Table("Mcr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Mcr : MaildatEntity, IMcr 
	{
		/// <summary>
		/// Job ID (MCR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See Header File's Job ID definition.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MCR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Segment ID (MCR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("MCR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MCR-1003)
		/// Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("MCR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitId { get; set; }

		/// <summary>
		/// Component ID (MCR-1004)
		/// Left justify, must have some value, even if single edition. This ID represents a specific
		/// sub-portion (or the whole, as appropriate) of one or more Mail Piece Unit Make-ups within the
		/// production of the specific mailing described by the supplied Mail.dat®  file. The originator of the
		/// Mail.dat®  file must identify any postage differentiating Components with their own record. However,
		/// if no postage affecting differentiation exists within the various parts making up a Mail Piece Unit,
		/// then the originator of the specific Mail.dat® may choose to, and probably should, only identify the
		/// necessary detail and simply clone that which is in the Mail Piece Unit ID field. Therefore, there
		/// will always be at least one Component within any Mail Piece Unit.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition. This ID represents a specific sub-portion (or the whole, as appropriate) of one Or more Mail Piece Unit Make-ups within the production of the Specific mailing described by the supplied Mail.dat®  file. The originator of the Mail.dat®  file must identify any postage Differentiating Components with their own record. However, if no Postage affecting differentiation exists within the various parts making Up a Mail Piece Unit, then the originator of the specific Mail.dat® May choose to, and probably should, only identify the necessary detail And simply clone that which is in the Mail Piece Unit ID field. Therefore, there will always be at least one Component within any Mail Piece Unit.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition. This ID represents a specific sub-portion (or the whole, as appropriate) of one Or more Mail Piece Unit Make-ups within the production of the Specific mailing described by the supplied Mail.dat®  file. The originator of the Mail.dat®  file must identify any postage Differentiating Components with their own record. However, if no Postage affecting differentiation exists within the various parts making Up a Mail Piece Unit, then the originator of the specific Mail.dat® May choose to, and probably should, only identify the necessary detail And simply clone that which is in the Mail Piece Unit ID field. Therefore, there will always be at least one Component within any Mail Piece Unit.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition. This ID represents a specific sub-portion (or the whole, as appropriate) of one or more Mail Piece Unit Make-ups within the production of the specific mailing described by the supplied Mail.dat®  file. The originator of the Mail.dat®  file must identify any postage differentiating Components with their own record. However, if no postage affecting differentiation exists within the various parts making up a Mail Piece Unit, then the originator of the specific Mail.dat® may choose to, and probably should, only identify the necessary detail and simply clone that which is in the Mail Piece Unit ID field. Therefore, there will always be at least one Component within any Mail Piece Unit.", Type = "string", Format = "zfillnumeric")]
		[Column("ComponentId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MCR-1004")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentId { get; set; }

		/// <summary>
		/// Primary MPA ID (MCR-1102)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1102", FieldName = "Primary MPA ID", Start = 26, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1102", FieldName = "Primary MPA ID", Start = 26, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1102", FieldName = "Primary MPA ID", Start = 26, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[Column("PrimaryMpaId", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("MCR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PrimaryMpaId { get; set; }

		/// <summary>
		/// Additional Postage MPA ID (MCR-1103)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1103", FieldName = "Additional Postage MPA ID", Start = 36, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1103", FieldName = "Additional Postage MPA ID", Start = 36, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1103", FieldName = "Additional Postage MPA ID", Start = 36, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[Column("AdditionalPostageMpaId", Order = 7, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("MCR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string AdditionalPostageMpaId { get; set; }

		/// <summary>
		/// Host Statement Component ID (MCR-1104)
		/// List Code.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1104", FieldName = "Host Statement Component ID", Start = 46, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "List Code.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1104", FieldName = "Host Statement Component ID", Start = 46, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "List Code.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1104", FieldName = "Host Statement Component ID", Start = 46, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "List Code.", Type = "string", Format = "zfillnumeric")]
		[Column("HostStatementComponentId", Order = 8, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("MCR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string HostStatementComponentId { get; set; }

		/// <summary>
		/// Host Indicator of Ad Computation (MCR-1105)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1105", FieldName = "Host Indicator of Ad Computation", Start = 54, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1105", FieldName = "Host Indicator of Ad Computation", Start = 54, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1105", FieldName = "Host Indicator of Ad Computation", Start = 54, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("HostIndicatorOfAdComputation", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "N", "Y")]
		[Comment("MCR-1105")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(HostIndicatorOfAdComputations))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string HostIndicatorOfAdComputation { get; set; }

		/// <summary>
		/// Postage Adjustment MPA ID (MCR-1106)
		/// This field would be used by anyone (printers and letter shops) including MLOCR vendors requiring
		/// Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA
		/// within an MPU. Establishes the set of MPU pieces on one Postage Statement.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1106", FieldName = "Postage Adjustment MPA ID", Start = 55, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "This field would be used by anyone (printers and letter shops) Including MLOCR vendors requiring Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1106", FieldName = "Postage Adjustment MPA ID", Start = 55, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "This field would be used by anyone (printers and letter shops) Including MLOCR vendors requiring Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1106", FieldName = "Postage Adjustment MPA ID", Start = 55, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "This field would be used by anyone (printers and letter shops) including MLOCR vendors requiring Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "zfillnumeric", References = "MPA-1002")]
		[Column("PostageAdjustmentMpaId", Order = 10, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("MCR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PostageAdjustmentMpaId { get; set; }

		/// <summary>
		/// MCR Record Status (MCR-2000)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-2000", FieldName = "MCR Record Status", Start = 65, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-2000", FieldName = "MCR Record Status", Start = 65, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-2000", FieldName = "MCR Record Status", Start = 65, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("McrRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("MCR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(McrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string McrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (MCR-1101)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-1101", FieldName = "Reserve", Start = 66, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-1101", FieldName = "Reserve", Start = 66, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-1101", FieldName = "Reserve", Start = 66, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveMcr1101", Order = 12, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("MCR-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveMcr1101 { get; set; }

		/// <summary>
		/// Closing Character (MCR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mcr", FieldCode = "MCR-9999", FieldName = "Closing Character", Start = 100, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mcr", FieldCode = "MCR-9999", FieldName = "Closing Character", Start = 100, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mcr", FieldCode = "MCR-9999", FieldName = "Closing Character", Start = 100, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("MCR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Mcr, string>(version, p => p.JobId, returnValue);
			this.SegmentId = line.ParseForImport<Mcr, string>(version, p => p.SegmentId, returnValue);
			this.MailPieceUnitId = line.ParseForImport<Mcr, string>(version, p => p.MailPieceUnitId, returnValue);
			this.ComponentId = line.ParseForImport<Mcr, string>(version, p => p.ComponentId, returnValue);
			this.PrimaryMpaId = line.ParseForImport<Mcr, string>(version, p => p.PrimaryMpaId, returnValue);
			this.AdditionalPostageMpaId = line.ParseForImport<Mcr, string>(version, p => p.AdditionalPostageMpaId, returnValue);
			this.HostStatementComponentId = line.ParseForImport<Mcr, string>(version, p => p.HostStatementComponentId, returnValue);
			this.HostIndicatorOfAdComputation = line.ParseForImport<Mcr, string>(version, p => p.HostIndicatorOfAdComputation, returnValue);
			this.PostageAdjustmentMpaId = line.ParseForImport<Mcr, string>(version, p => p.PostageAdjustmentMpaId, returnValue);
			this.McrRecordStatus = line.ParseForImport<Mcr, string>(version, p => p.McrRecordStatus, returnValue);
			this.ReserveMcr1101 = line.ParseForImport<Mcr, string>(version, p => p.ReserveMcr1101, returnValue);
			this.ClosingCharacter = line.ParseForImport<Mcr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Mcr, string>(version, p => p.JobId));
			sb.Append(this.SegmentId.FormatForExport<Mcr, string>(version, p => p.SegmentId));
			sb.Append(this.MailPieceUnitId.FormatForExport<Mcr, string>(version, p => p.MailPieceUnitId));
			sb.Append(this.ComponentId.FormatForExport<Mcr, string>(version, p => p.ComponentId));
			sb.Append(this.PrimaryMpaId.FormatForExport<Mcr, string>(version, p => p.PrimaryMpaId));
			sb.Append(this.AdditionalPostageMpaId.FormatForExport<Mcr, string>(version, p => p.AdditionalPostageMpaId));
			sb.Append(this.HostStatementComponentId.FormatForExport<Mcr, string>(version, p => p.HostStatementComponentId));
			sb.Append(this.HostIndicatorOfAdComputation.FormatForExport<Mcr, string>(version, p => p.HostIndicatorOfAdComputation));
			sb.Append(this.PostageAdjustmentMpaId.FormatForExport<Mcr, string>(version, p => p.PostageAdjustmentMpaId));
			sb.Append(this.McrRecordStatus.FormatForExport<Mcr, string>(version, p => p.McrRecordStatus));
			sb.Append(this.ReserveMcr1101.FormatForExport<Mcr, string>(version, p => p.ReserveMcr1101));
			sb.Append(this.ClosingCharacter.FormatForExport<Mcr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}