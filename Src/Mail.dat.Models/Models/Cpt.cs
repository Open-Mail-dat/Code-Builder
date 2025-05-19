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
	/// A description of the applicable component.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cpt", File = "Component Record", Summary = "A description of the applicable component.", Description = "A description of the applicable component.")]
	[Table("Cpt", Schema = "Maildat")]
	public partial class Cpt : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (CPT-1001)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Component ID (CPT-1004)
		/// See MPU/C Component ID definition.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See MPU/C Component ID definition.", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[Column("ComponentID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string ComponentID { get; set; }

		/// <summary>
		/// Component Description (CPT-1101)
		/// This is a unique name or code for each specific sub- or whole-portion of The mail piece. This field,
		/// if used, can carry an absolute reference to The Component in question while the Component ID is
		/// practical shorthand For reference to the Component's role within the mailing facilities postage
		/// Analysis. Left justify. If used, must have some value, even if single edition.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1101", FieldName = "Component Description", Start = 17, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific sub- or whole-portion of The mail piece. This field, if used, can carry an absolute reference to The Component in question while the Component ID is practical shorthand For reference to the Component's role within the mailing facilities postage Analysis. Left justify. If used, must have some value, even if single edition.", Type = "string", Format = "leftjustify")]
		[Column("ComponentDescription", Order = 3)]
		[MaxLength(30)]
		public string ComponentDescription { get; set; }

		/// <summary>
		/// Component - Weight (CPT-1102)
		/// 99v9999; pounds, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1102", FieldName = "Component - Weight", Start = 47, Length = 6, Required = true, Key = false, DataType = "N", Description = "99v9999; pounds, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentWeight", Order = 4)]
		[Required]
		public decimal ComponentWeight { get; set; }

		/// <summary>
		/// Component - Weight: Source (CPT-1103)
		/// Source of Piece Weight.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1103", FieldName = "Component - Weight: Source", Start = 53, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentWeightSource", Order = 5)]
		[MaxLength(1)]
		[AllowedValues("A", "C", "L", "P")]
		public string ComponentWeightSource { get; set; }

		/// <summary>
		/// Component - Weight: Status (CPT-1104)
		/// Status of weight data.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1104", FieldName = "Component - Weight: Status", Start = 54, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentWeightStatus", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("F", "M", "N", "P")]
		public string ComponentWeightStatus { get; set; }

		/// <summary>
		/// Component - Length (CPT-1105)
		/// Length of a copy 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1105", FieldName = "Component - Length", Start = 55, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy 999v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentLength", Order = 7)]
		public decimal ComponentLength { get; set; }

		/// <summary>
		/// Component - Width (CPT-1106)
		/// Width of a copy 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1106", FieldName = "Component - Width", Start = 62, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentWidth", Order = 8)]
		public decimal ComponentWidth { get; set; }

		/// <summary>
		/// Component - Thickness (CPT-1107)
		/// Thickness of a copy 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1107", FieldName = "Component - Thickness", Start = 68, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentThickness", Order = 9)]
		public decimal ComponentThickness { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage (CPT-1108)
		/// Ad percentage of a copy 999v99, rounded (decimal point implied) Example (if there is a two page
		/// Periodical supplement having 50% Ad and the Periodical Is 48 pages having 40% Ad, then in the
		/// mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the
		/// Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1108", FieldName = "Component - Periodical Ad Percentage", Start = 74, Length = 5, Required = false, Key = false, DataType = "N", Description = "Ad percentage of a copy 999v99, rounded (decimal point implied) Example (if there is a two page Periodical supplement having 50% Ad and the Periodical Is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ComponentPeriodicalAdPercentage", Order = 10)]
		public decimal ComponentPeriodicalAdPercentage { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage: Status (CPT-1109)
		/// Status of % data.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1109", FieldName = "Component - Periodical Ad Percentage: Status", Start = 79, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of % data.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentPeriodicalAdPercentageStatus", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("F", "N", "P")]
		public string ComponentPeriodicalAdPercentageStatus { get; set; }

		/// <summary>
		/// Component - Class (CPT-1110)
		/// The Postal Class of this Mail Piece Unit within Mail.dat.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1110", FieldName = "Component - Class", Start = 80, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentClass", Order = 12)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "9", "P", "X")]
		public string ComponentClass { get; set; }

		/// <summary>
		/// Component - Rate Type (CPT-1111)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1111", FieldName = "Component - Rate Type", Start = 81, Length = 2, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ComponentRateType", Order = 13)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("B", "C", "D", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "E", "E1", "E2", "E7", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "R", "S", "T", "T1", "T2", "T3", "T4", "T5", "W", "X", "Y", "Z")]
		public string ComponentRateType { get; set; }

		/// <summary>
		/// Component -Processing Category (CPT-1112)
		/// See MPU Processing Category for details.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1112", FieldName = "Component -Processing Category", Start = 83, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See MPU Processing Category for details.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentProcessingCategory", Order = 14)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("2", "D", "N", "R", "T")]
		public string ComponentProcessingCategory { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (CPT-1148)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1148", FieldName = "Mailer ID of Mail Owner", Start = 85, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "integer", Format = "leftjustify")]
		[Column("MailerIDOfMailOwner", Order = 15)]
		public int MailerIDOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (CPT-1149)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1149", FieldName = "CRID of Mail Owner", Start = 94, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "integer", Format = "leftjustify")]
		[Column("CRIDOfMailOwner", Order = 16)]
		public int CRIDOfMailOwner { get; set; }

		/// <summary>
		/// Periodical Ad% Treatment (CPT-1138)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1138", FieldName = "Periodical Ad% Treatment", Start = 106, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalAdTreatment", Order = 17)]
		[MaxLength(1)]
		[AllowedValues("B", "N", "S")]
		public string PeriodicalAdTreatment { get; set; }

		/// <summary>
		/// Periodical Volume Number (CPT-1139)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1139", FieldName = "Periodical Volume Number", Start = 107, Length = 5, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("PeriodicalVolumeNumber", Order = 18)]
		[MaxLength(5)]
		public string PeriodicalVolumeNumber { get; set; }

		/// <summary>
		/// Periodical Issue Number (CPT-1140)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1140", FieldName = "Periodical Issue Number", Start = 112, Length = 6, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("PeriodicalIssueNumber", Order = 19)]
		[MaxLength(6)]
		public string PeriodicalIssueNumber { get; set; }

		/// <summary>
		/// Periodical Issue Date (CPT-1141)
		/// YYYYMMDD- date on which periodical is issued (can't be all zeros).
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1141", FieldName = "Periodical Issue Date", Start = 118, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD- date on which periodical is issued (can't be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("PeriodicalIssueDate", Order = 20)]
		public DateOnly PeriodicalIssueDate { get; set; }

		/// <summary>
		/// Periodical Frequency (CPT-1142)
		/// Number of times published per year.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1142", FieldName = "Periodical Frequency", Start = 126, Length = 3, Required = false, Key = false, DataType = "N", Description = "Number of times published per year.", Type = "integer", Format = "zfill")]
		[Column("PeriodicalFrequency", Order = 21)]
		public int PeriodicalFrequency { get; set; }

		/// <summary>
		/// Equivalent User License Code (CPT-1144)
		/// User license code of a component of common weight and ad %. Used in Conjunction with Equivalent Job
		/// ID and Equivalent Component ID to link Together components with common book weight and ad %.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1144", FieldName = "Equivalent User License Code", Start = 129, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User license code of a component of common weight and ad %. Used in Conjunction with Equivalent Job ID and Equivalent Component ID to link Together components with common book weight and ad %.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentUserLicenseCode", Order = 22)]
		[MaxLength(4)]
		public string EquivalentUserLicenseCode { get; set; }

		/// <summary>
		/// Equivalent Mail.dat Job ID (CPT-1145)
		/// See above note.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1145", FieldName = "Equivalent Mail.dat Job ID", Start = 133, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See above note.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentMailDatJobID", Order = 23)]
		[MaxLength(8)]
		public string EquivalentMailDatJobID { get; set; }

		/// <summary>
		/// Equivalent Component ID (CPT-1146)
		/// See note for Equivalent User License Code field.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1146", FieldName = "Equivalent Component ID", Start = 141, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See note for Equivalent User License Code field.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentComponentID", Order = 24)]
		[MaxLength(8)]
		public string EquivalentComponentID { get; set; }

		/// <summary>
		/// Equivalent Component Type (CPT-1151)
		/// Only to be used for periodical mailings when Equivalent fields have values in them.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1151", FieldName = "Equivalent Component Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Only to be used for periodical mailings when Equivalent fields have values in them.", Type = "enum", Format = "leftjustify")]
		[Column("EquivalentComponentType", Order = 25)]
		[MaxLength(1)]
		[AllowedValues("B", "W")]
		public string EquivalentComponentType { get; set; }

		/// <summary>
		/// Ad % Basis (CPT-1152)
		/// 9999v99 implied 2 decimal places.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1152", FieldName = "Ad % Basis", Start = 150, Length = 6, Required = false, Key = false, DataType = "N", Description = "9999v99 implied 2 decimal places.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AdBasis", Order = 26)]
		public decimal AdBasis { get; set; }

		/// <summary>
		/// Component Title (CPT-1147)
		/// Title information A more appropriate place for title information.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1147", FieldName = "Component Title", Start = 156, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Title information A more appropriate place for title information.", Type = "string", Format = "leftjustify")]
		[Column("ComponentTitle", Order = 27)]
		[MaxLength(30)]
		public string ComponentTitle { get; set; }

		/// <summary>
		/// Standard Parcel Type (CPT-1156)
		/// See definition in MPU.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1156", FieldName = "Standard Parcel Type", Start = 186, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "See definition in MPU.", Type = "enum", Format = "leftjustify")]
		[Column("StandardParcelType", Order = 28)]
		[MaxLength(1)]
		[AllowedValues("F", "L", "M", "S")]
		public string StandardParcelType { get; set; }

		/// <summary>
		/// Approved Piece Design Type (CPT-1157)
		/// Indicator for CSR or PCSC ruling type.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1157", FieldName = "Approved Piece Design Type", Start = 187, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Indicator for CSR or PCSC ruling type.", Type = "enum", Format = "leftjustify")]
		[Column("ApprovedPieceDesignType", Order = 29)]
		[MaxLength(1)]
		[AllowedValues("C", "P")]
		public string ApprovedPieceDesignType { get; set; }

		/// <summary>
		/// Approved Piece Design (CPT-1158)
		/// The CSR or PCSC ruling number approving the mailing of a specific Style/design of mail piece. These
		/// new designs could include but not Limited to automation, non-rectangular, non-paper mail pieces.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1158", FieldName = "Approved Piece Design", Start = 188, Length = 7, Required = false, Key = false, DataType = "N", Description = "The CSR or PCSC ruling number approving the mailing of a specific Style/design of mail piece. These new designs could include but not Limited to automation, non-rectangular, non-paper mail pieces.", Type = "integer", Format = "zfill")]
		[Column("ApprovedPieceDesign", Order = 30)]
		public int ApprovedPieceDesign { get; set; }

		/// <summary>
		/// User Option Field (CPT-1150)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1150", FieldName = "User Option Field", Start = 195, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 31)]
		[MaxLength(20)]
		public string UserOptionField { get; set; }

		/// <summary>
		/// CPT Record Status (CPT-2000)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-2000", FieldName = "CPT Record Status", Start = 215, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CPTRecordStatus", Order = 32)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string CPTRecordStatus { get; set; }

		/// <summary>
		/// eMailpiece Sample Group ID (CPT-1159)
		/// This USPS-assigned id, will be used to uniquely identify a group of Mailpiece samples loaded to USPS
		/// Business Customer Gateway and Referenced here for promotion eligibility. Left Justify. Field Format
		/// will Be validated by PostalOne!.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1159", FieldName = "EMailpiece Sample Group ID", Start = 216, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, will be used to uniquely identify a group of Mailpiece samples loaded to USPS Business Customer Gateway and Referenced here for promotion eligibility. Left Justify. Field Format will Be validated by PostalOne!.", Type = "string", Format = "leftjustify")]
		[Column("EMailpieceSampleGroupID", Order = 33)]
		[MaxLength(24)]
		public string EMailpieceSampleGroupID { get; set; }

		/// <summary>
		/// Reserve (CPT-1130)
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-1130", FieldName = "Reserve", Start = 240, Length = 24, Required = false, Key = false, DataType = "A/N", Type = "reserve", Format = "leftjustify")]
		[Column("Reserve", Order = 34)]
		[MaxLength(24)]
		public string ReserveCPT1130 { get; set; }

		/// <summary>
		/// Closing Character (CPT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cpt", FieldCode = "CPT-9999", FieldName = "Closing Character", Start = 264, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 35)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}