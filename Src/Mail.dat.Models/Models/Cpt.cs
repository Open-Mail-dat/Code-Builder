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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
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
	/// A description of the applicable component.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "cpt", File = "Component Record", Summary = "A description of the applicable component.", Description = "A description of the applicable component.", LineLength = 264, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "cpt", File = "Component Record", Summary = "A description of the applicable component.", Description = "A description of the applicable component.", LineLength = 264, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "cpt", File = "Component Record", Summary = "A description of the applicable component.", Description = "A description of the applicable component.", LineLength = 264, ClosingCharacter = "#")]
	[MaildatImport(Order = 6, Version = "23-1")]
	[MaildatImport(Order = 6, Version = "24-1")]
	[MaildatImport(Order = 6, Version = "25-1")]
	[Table("Cpt", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Cpt : MaildatEntity, ICpt 
	{
		/// <summary>
		/// Job ID (CPT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CPT-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Component ID (CPT-1004)
		/// See MPU/C Component ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See MPU/C Component ID definition.", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See MPU/C Component ID definition.", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "See MPU/C Component ID definition.", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[Column("ComponentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CPT-1004")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentId { get; set; }

		/// <summary>
		/// Component Description (CPT-1101)
		/// This is a unique name or code for each specific sub- or whole-portion of the mail piece. This field,
		/// if used, can carry an absolute reference to the Component in question while the Component ID is
		/// practical shorthand for reference to the Component's role within the mailing facilities postage
		/// analysis. Left justify. If used, must have some value, even if single edition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1101", FieldName = "Component Description", Start = 17, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific sub- or whole-portion of The mail piece. This field, if used, can carry an absolute reference to The Component in question while the Component ID is practical shorthand For reference to the Component's role within the mailing facilities postage Analysis. Left justify. If used, must have some value, even if single edition.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1101", FieldName = "Component Description", Start = 17, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific sub- or whole-portion of The mail piece. This field, if used, can carry an absolute reference to The Component in question while the Component ID is practical shorthand For reference to the Component's role within the mailing facilities postage Analysis. Left justify. If used, must have some value, even if single edition.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1101", FieldName = "Component Description", Start = 17, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific sub- or whole-portion of the mail piece. This field, if used, can carry an absolute reference to the Component in question while the Component ID is practical shorthand for reference to the Component's role within the mailing facilities postage analysis. Left justify. If used, must have some value, even if single edition.", Type = "string", Format = "leftjustify")]
		[Column("ComponentDescription", Order = 4, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CPT-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentDescription { get; set; }

		/// <summary>
		/// Component - Weight (CPT-1102)
		/// 99v9999; pounds, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1102", FieldName = "Component - Weight", Start = 47, Length = 6, Required = true, Key = false, DataType = "N", Description = "99v9999; pounds, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1102", FieldName = "Component - Weight", Start = 47, Length = 6, Required = true, Key = false, DataType = "N", Description = "99v9999; pounds, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1102", FieldName = "Component - Weight", Start = 47, Length = 6, Required = true, Key = false, DataType = "N", Description = "99v9999; pounds, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentWeight", Order = 5, TypeName = "NUMERIC")]
		[Required]
		[Precision(4)]
		[Comment("CPT-1102")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal ComponentWeight { get; set; }

		/// <summary>
		/// Component - Weight: Source (CPT-1103)
		/// Source of Piece Weight.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1103", FieldName = "Component - Weight: Source", Start = 53, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1103", FieldName = "Component - Weight: Source", Start = 53, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1103", FieldName = "Component - Weight: Source", Start = 53, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentWeightSource", Order = 6, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("A", "C", "L", "P")]
		[Comment("CPT-1103")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentWeightSources))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentWeightSource { get; set; }

		/// <summary>
		/// Component - Weight: Status (CPT-1104)
		/// Status of weight data.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1104", FieldName = "Component - Weight: Status", Start = 54, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1104", FieldName = "Component - Weight: Status", Start = 54, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1104", FieldName = "Component - Weight: Status", Start = 54, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentWeightStatus", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("F", "M", "N", "P")]
		[Comment("CPT-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentWeightStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentWeightStatus { get; set; }

		/// <summary>
		/// Component - Length (CPT-1105)
		/// Length of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1105", FieldName = "Component - Length", Start = 55, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy 999v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1105", FieldName = "Component - Length", Start = 55, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy 999v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1105", FieldName = "Component - Length", Start = 55, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentLength", Order = 8, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("CPT-1105")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ComponentLength { get; set; }

		/// <summary>
		/// Component - Width (CPT-1106)
		/// Width of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1106", FieldName = "Component - Width", Start = 62, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1106", FieldName = "Component - Width", Start = 62, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1106", FieldName = "Component - Width", Start = 62, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentWidth", Order = 9, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("CPT-1106")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ComponentWidth { get; set; }

		/// <summary>
		/// Component - Thickness (CPT-1107)
		/// Thickness of a copy; inches, rounded 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1107", FieldName = "Component - Thickness", Start = 68, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1107", FieldName = "Component - Thickness", Start = 68, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1107", FieldName = "Component - Thickness", Start = 68, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy; inches, rounded 99v9999; inches, rounded (decimal point implied).", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ComponentThickness", Order = 10, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("CPT-1107")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ComponentThickness { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage (CPT-1108)
		/// Ad percentage of a copy, rounded Example (if there is a two page Periodical supplement having 50% Ad
		/// and the Periodical is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the
		/// supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum
		/// is 40.40% Field is necessary for Periodicals Enclosures.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1108", FieldName = "Component - Periodical Ad Percentage", Start = 74, Length = 5, Required = false, Key = false, DataType = "N", Description = "Ad percentage of a copy 999v99, rounded (decimal point implied) Example (if there is a two page Periodical supplement having 50% Ad and the Periodical Is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1108", FieldName = "Component - Periodical Ad Percentage", Start = 74, Length = 5, Required = false, Key = false, DataType = "N", Description = "Ad percentage of a copy 999v99, rounded (decimal point implied) Example (if there is a two page Periodical supplement having 50% Ad and the Periodical Is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1108", FieldName = "Component - Periodical Ad Percentage", Start = 74, Length = 5, Required = false, Key = false, DataType = "N", Description = "Ad percentage of a copy, rounded Example (if there is a two page Periodical supplement having 50% Ad and the Periodical is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ComponentPeriodicalAdPercentage", Order = 11, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CPT-1108")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ComponentPeriodicalAdPercentage { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage: Status (CPT-1109)
		/// Status of % data.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1109", FieldName = "Component - Periodical Ad Percentage: Status", Start = 79, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of % data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1109", FieldName = "Component - Periodical Ad Percentage: Status", Start = 79, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of % data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1109", FieldName = "Component - Periodical Ad Percentage: Status", Start = 79, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of % data.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentPeriodicalAdPercentageStatus", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("F", "N", "P")]
		[Comment("CPT-1109")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentPeriodicalAdPercentageStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentPeriodicalAdPercentageStatus { get; set; }

		/// <summary>
		/// Component - Class (CPT-1110)
		/// The Postal Class of this Mail Piece Unit within Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1110", FieldName = "Component - Class", Start = 80, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1110", FieldName = "Component - Class", Start = 80, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1110", FieldName = "Component - Class", Start = 80, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentClass", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "9", "P", "X")]
		[Comment("CPT-1110")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentClasses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentClass { get; set; }

		/// <summary>
		/// Component - Rate Type (CPT-1111)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1111", FieldName = "Component - Rate Type", Start = 81, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1111", FieldName = "Component - Rate Type", Start = 81, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1111", FieldName = "Component - Rate Type", Start = 81, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ComponentRateType", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("B", "C", "D", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "E", "E1", "E2", "E7", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "T1", "T2", "T3", "T4", "T5", "W", "X", "Y", "Z")]
		[Comment("CPT-1111")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentRateTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentRateType { get; set; }

		/// <summary>
		/// Component -Processing Category (CPT-1112)
		/// See MPU Processing Category for details.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1112", FieldName = "Component -Processing Category", Start = 83, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See MPU Processing Category for details.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1112", FieldName = "Component -Processing Category", Start = 83, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See MPU Processing Category for details.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1112", FieldName = "Component -Processing Category", Start = 83, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See MPU Processing Category for details.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentProcessingCategory", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("2", "D", "N", "R", "T")]
		[Comment("CPT-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentProcessingCategories))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentProcessingCategory { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (CPT-1148)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1148", FieldName = "Mailer ID of Mail Owner", Start = 85, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1148", FieldName = "Mailer ID of Mail Owner", Start = 85, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1148", FieldName = "Mailer ID of Mail Owner", Start = 85, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIdOfMailOwner", Order = 16, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CPT-1148")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailerIdOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (CPT-1149)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1149", FieldName = "CRID of Mail Owner", Start = 94, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1149", FieldName = "CRID of Mail Owner", Start = 94, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1149", FieldName = "CRID of Mail Owner", Start = 94, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CridOfMailOwner", Order = 17, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("CPT-1149")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CridOfMailOwner { get; set; }

		/// <summary>
		/// Periodical Ad% Treatment (CPT-1138)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1138", FieldName = "Periodical Ad% Treatment", Start = 106, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1138", FieldName = "Periodical Ad% Treatment", Start = 106, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1138", FieldName = "Periodical Ad% Treatment", Start = 106, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalAdTreatment", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("B", "N", "S")]
		[Comment("CPT-1138")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PeriodicalAdTreatments))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalAdTreatment { get; set; }

		/// <summary>
		/// Periodical Volume Number (CPT-1139)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1139", FieldName = "Periodical Volume Number", Start = 107, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1139", FieldName = "Periodical Volume Number", Start = 107, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1139", FieldName = "Periodical Volume Number", Start = 107, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("PeriodicalVolumeNumber", Order = 19, TypeName = "TEXT")]
		[MaxLength(5)]
		[Comment("CPT-1139")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalVolumeNumber { get; set; }

		/// <summary>
		/// Periodical Issue Number (CPT-1140)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1140", FieldName = "Periodical Issue Number", Start = 112, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1140", FieldName = "Periodical Issue Number", Start = 112, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1140", FieldName = "Periodical Issue Number", Start = 112, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("PeriodicalIssueNumber", Order = 20, TypeName = "TEXT")]
		[MaxLength(6)]
		[Comment("CPT-1140")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalIssueNumber { get; set; }

		/// <summary>
		/// Periodical Issue Date (CPT-1141)
		/// YYYYMMDD- date on which periodical is issued (can't be all zeros).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1141", FieldName = "Periodical Issue Date", Start = 118, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD- date on which periodical is issued (can't be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1141", FieldName = "Periodical Issue Date", Start = 118, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD- date on which periodical is issued (can't be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1141", FieldName = "Periodical Issue Date", Start = 118, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD- date on which periodical is issued (can't be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("PeriodicalIssueDate", Order = 21, TypeName = "TEXT")]
		[Comment("CPT-1141")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly? PeriodicalIssueDate { get; set; }

		/// <summary>
		/// Periodical Frequency (CPT-1142)
		/// Number of times published per year.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1142", FieldName = "Periodical Frequency", Start = 126, Length = 3, Required = false, Key = false, DataType = "N", Description = "Number of times published per year.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1142", FieldName = "Periodical Frequency", Start = 126, Length = 3, Required = false, Key = false, DataType = "N", Description = "Number of times published per year.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1142", FieldName = "Periodical Frequency", Start = 126, Length = 3, Required = false, Key = false, DataType = "N", Description = "Number of times published per year.", Type = "integer", Format = "zfill")]
		[Column("PeriodicalFrequency", Order = 22, TypeName = "INTEGER")]
		[Comment("CPT-1142")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? PeriodicalFrequency { get; set; }

		/// <summary>
		/// Equivalent User License Code (CPT-1144)
		/// User license code of a component of common weight and ad %. Used in conjunction with Equivalent Job
		/// ID and Equivalent Component ID to link together components with common book weight and ad %.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1144", FieldName = "Equivalent User License Code", Start = 129, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User license code of a component of common weight and ad %. Used in Conjunction with Equivalent Job ID and Equivalent Component ID to link Together components with common book weight and ad %.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1144", FieldName = "Equivalent User License Code", Start = 129, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User license code of a component of common weight and ad %. Used in Conjunction with Equivalent Job ID and Equivalent Component ID to link Together components with common book weight and ad %.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1144", FieldName = "Equivalent User License Code", Start = 129, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User license code of a component of common weight and ad %. Used in conjunction with Equivalent Job ID and Equivalent Component ID to link together components with common book weight and ad %.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentUserLicenseCode", Order = 23, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("CPT-1144")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EquivalentUserLicenseCode { get; set; }

		/// <summary>
		/// Equivalent Mail.dat Job ID (CPT-1145)
		/// See above note.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1145", FieldName = "Equivalent Mail.dat Job ID", Start = 133, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See above note.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1145", FieldName = "Equivalent Mail.dat Job ID", Start = 133, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See above note.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1145", FieldName = "Equivalent Mail.dat Job ID", Start = 133, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See above note.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentMailDatJobId", Order = 24, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("CPT-1145")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EquivalentMailDatJobId { get; set; }

		/// <summary>
		/// Equivalent Component ID (CPT-1146)
		/// See note for Equivalent User License Code field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1146", FieldName = "Equivalent Component ID", Start = 141, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See note for Equivalent User License Code field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1146", FieldName = "Equivalent Component ID", Start = 141, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See note for Equivalent User License Code field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1146", FieldName = "Equivalent Component ID", Start = 141, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "See note for Equivalent User License Code field.", Type = "string", Format = "leftjustify")]
		[Column("EquivalentComponentId", Order = 25, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("CPT-1146")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EquivalentComponentId { get; set; }

		/// <summary>
		/// Equivalent Component Type (CPT-1151)
		/// Only to be used for periodical mailings when Equivalent fields have values in them.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1151", FieldName = "Equivalent Component Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Only to be used for periodical mailings when Equivalent fields have values in them.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1151", FieldName = "Equivalent Component Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Only to be used for periodical mailings when Equivalent fields have values in them.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1151", FieldName = "Equivalent Component Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Only to be used for periodical mailings when Equivalent fields have values in them.", Type = "enum", Format = "leftjustify")]
		[Column("EquivalentComponentType", Order = 26, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "B", "W")]
		[Comment("CPT-1151")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(EquivalentComponentTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EquivalentComponentType { get; set; }

		/// <summary>
		/// Ad % Basis (CPT-1152)
		/// 9999v99 implied 2 decimal places.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1152", FieldName = "Ad % Basis", Start = 150, Length = 6, Required = false, Key = false, DataType = "N", Description = "9999v99 implied 2 decimal places.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1152", FieldName = "Ad % Basis", Start = 150, Length = 6, Required = false, Key = false, DataType = "N", Description = "9999v99 implied 2 decimal places.", Type = "decimal", Format = "zfill", Precision = 2)]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1152", FieldName = "Ad % Basis", Start = 150, Length = 6, Required = false, Key = false, DataType = "N", Description = "9999v99 implied 2 decimal places.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AdBasis", Order = 27, TypeName = "NUMERIC")]
		[Precision(2)]
		[Comment("CPT-1152")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? AdBasis { get; set; }

		/// <summary>
		/// Component Title (CPT-1147)
		/// Title information A more appropriate place for title information.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1147", FieldName = "Component Title", Start = 156, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Title information A more appropriate place for title information.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1147", FieldName = "Component Title", Start = 156, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Title information A more appropriate place for title information.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1147", FieldName = "Component Title", Start = 156, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Title information A more appropriate place for title information.", Type = "string", Format = "leftjustify")]
		[Column("ComponentTitle", Order = 28, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CPT-1147")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentTitle { get; set; }

		/// <summary>
		/// Standard Parcel Type (CPT-1156)
		/// See definition in MPU.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1156", FieldName = "Standard Parcel Type", Start = 186, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "See definition in MPU.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1156", FieldName = "Standard Parcel Type", Start = 186, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "See definition in MPU.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1156", FieldName = "Standard Parcel Type", Start = 186, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "See definition in MPU.", Type = "enum", Format = "leftjustify")]
		[Column("StandardParcelType", Order = 29, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "F", "H", "L", "M", "P", "S")]
		[Comment("CPT-1156")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(StandardParcelTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string StandardParcelType { get; set; }

		/// <summary>
		/// Approved Piece Design Type (CPT-1157)
		/// Indicator for CSR or PCSC ruling type.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1157", FieldName = "Approved Piece Design Type", Start = 187, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Indicator for CSR or PCSC ruling type.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1157", FieldName = "Approved Piece Design Type", Start = 187, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Indicator for CSR or PCSC ruling type.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1157", FieldName = "Approved Piece Design Type", Start = 187, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Indicator for CSR or PCSC ruling type.", Type = "enum", Format = "leftjustify")]
		[Column("ApprovedPieceDesignType", Order = 30, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("C", "P")]
		[Comment("CPT-1157")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ApprovedPieceDesignTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ApprovedPieceDesignType { get; set; }

		/// <summary>
		/// Approved Piece Design (CPT-1158)
		/// The CSR or PCSC ruling number approving the mailing of a specific style/design of mail piece. These
		/// new designs could include but not limited to automation, non-rectangular, non-paper mail pieces.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1158", FieldName = "Approved Piece Design", Start = 188, Length = 7, Required = false, Key = false, DataType = "N", Description = "The CSR or PCSC ruling number approving the mailing of a specific Style/design of mail piece. These new designs could include but not Limited to automation, non-rectangular, non-paper mail pieces.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1158", FieldName = "Approved Piece Design", Start = 188, Length = 7, Required = false, Key = false, DataType = "N", Description = "The CSR or PCSC ruling number approving the mailing of a specific Style/design of mail piece. These new designs could include but not Limited to automation, non-rectangular, non-paper mail pieces.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1158", FieldName = "Approved Piece Design", Start = 188, Length = 7, Required = false, Key = false, DataType = "N", Description = "The CSR or PCSC ruling number approving the mailing of a specific style/design of mail piece. These new designs could include but not limited to automation, non-rectangular, non-paper mail pieces.", Type = "integer", Format = "zfill")]
		[Column("ApprovedPieceDesign", Order = 31, TypeName = "INTEGER")]
		[Comment("CPT-1158")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? ApprovedPieceDesign { get; set; }

		/// <summary>
		/// User Option Field (CPT-1150)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1150", FieldName = "User Option Field", Start = 195, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1150", FieldName = "User Option Field", Start = 195, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1150", FieldName = "User Option Field", Start = 195, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 32, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CPT-1150")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserOptionField { get; set; }

		/// <summary>
		/// CPT Record Status (CPT-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-2000", FieldName = "CPT Record Status", Start = 215, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-2000", FieldName = "CPT Record Status", Start = 215, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-2000", FieldName = "CPT Record Status", Start = 215, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CptRecordStatus", Order = 33, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CPT-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CptRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CptRecordStatus { get; set; }

		/// <summary>
		/// eMailpiece Sample Group ID (CPT-1159)
		/// This USPS-assigned id, will be used to uniquely identify a group of mailpiece samples loaded to USPS
		/// Business Customer Gateway and referenced here for promotion eligibility. Left Justify. Field Format
		/// will be validated by PostalOne!.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1159", FieldName = "EMailpiece Sample Group ID", Start = 216, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, will be used to uniquely identify a group of Mailpiece samples loaded to USPS Business Customer Gateway and Referenced here for promotion eligibility. Left Justify. Field Format will Be validated by PostalOne!.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1159", FieldName = "EMailpiece Sample Group ID", Start = 216, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, will be used to uniquely identify a group of Mailpiece samples loaded to USPS Business Customer Gateway and Referenced here for promotion eligibility. Left Justify. Field Format will Be validated by PostalOne!.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1159", FieldName = "EMailpiece Sample Group ID", Start = 216, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, will be used to uniquely identify a group of mailpiece samples loaded to USPS Business Customer Gateway and referenced here for promotion eligibility. Left Justify. Field Format will be validated by PostalOne!.", Type = "string", Format = "leftjustify")]
		[Column("EMailpieceSampleGroupId", Order = 34, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("CPT-1159")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EMailpieceSampleGroupId { get; set; }

		/// <summary>
		/// Reserve (CPT-1130)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-1130", FieldName = "Reserve", Start = 240, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-1130", FieldName = "Reserve", Start = 240, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-1130", FieldName = "Reserve", Start = 240, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCpt1130", Order = 35, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("CPT-1130")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveCpt1130 { get; set; }

		/// <summary>
		/// Closing Character (CPT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cpt", FieldCode = "CPT-9999", FieldName = "Closing Character", Start = 264, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cpt", FieldCode = "CPT-9999", FieldName = "Closing Character", Start = 264, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cpt", FieldCode = "CPT-9999", FieldName = "Closing Character", Start = 264, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 36, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CPT-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Cpt, string>(version, p => p.JobId, returnValue);
			this.ComponentId = line.ParseForImport<Cpt, string>(version, p => p.ComponentId, returnValue);
			this.ComponentDescription = line.ParseForImport<Cpt, string>(version, p => p.ComponentDescription, returnValue);
			this.ComponentWeight = line.ParseForImport<Cpt, decimal>(version, p => p.ComponentWeight, returnValue);
			this.ComponentWeightSource = line.ParseForImport<Cpt, string>(version, p => p.ComponentWeightSource, returnValue);
			this.ComponentWeightStatus = line.ParseForImport<Cpt, string>(version, p => p.ComponentWeightStatus, returnValue);
			this.ComponentLength = line.ParseForImport<Cpt, decimal?>(version, p => p.ComponentLength, returnValue);
			this.ComponentWidth = line.ParseForImport<Cpt, decimal?>(version, p => p.ComponentWidth, returnValue);
			this.ComponentThickness = line.ParseForImport<Cpt, decimal?>(version, p => p.ComponentThickness, returnValue);
			this.ComponentPeriodicalAdPercentage = line.ParseForImport<Cpt, decimal?>(version, p => p.ComponentPeriodicalAdPercentage, returnValue);
			this.ComponentPeriodicalAdPercentageStatus = line.ParseForImport<Cpt, string>(version, p => p.ComponentPeriodicalAdPercentageStatus, returnValue);
			this.ComponentClass = line.ParseForImport<Cpt, string>(version, p => p.ComponentClass, returnValue);
			this.ComponentRateType = line.ParseForImport<Cpt, string>(version, p => p.ComponentRateType, returnValue);
			this.ComponentProcessingCategory = line.ParseForImport<Cpt, string>(version, p => p.ComponentProcessingCategory, returnValue);
			this.MailerIdOfMailOwner = line.ParseForImport<Cpt, string>(version, p => p.MailerIdOfMailOwner, returnValue);
			this.CridOfMailOwner = line.ParseForImport<Cpt, string>(version, p => p.CridOfMailOwner, returnValue);
			this.PeriodicalAdTreatment = line.ParseForImport<Cpt, string>(version, p => p.PeriodicalAdTreatment, returnValue);
			this.PeriodicalVolumeNumber = line.ParseForImport<Cpt, string>(version, p => p.PeriodicalVolumeNumber, returnValue);
			this.PeriodicalIssueNumber = line.ParseForImport<Cpt, string>(version, p => p.PeriodicalIssueNumber, returnValue);
			this.PeriodicalIssueDate = line.ParseForImport<Cpt, DateOnly?>(version, p => p.PeriodicalIssueDate, returnValue);
			this.PeriodicalFrequency = line.ParseForImport<Cpt, int?>(version, p => p.PeriodicalFrequency, returnValue);
			this.EquivalentUserLicenseCode = line.ParseForImport<Cpt, string>(version, p => p.EquivalentUserLicenseCode, returnValue);
			this.EquivalentMailDatJobId = line.ParseForImport<Cpt, string>(version, p => p.EquivalentMailDatJobId, returnValue);
			this.EquivalentComponentId = line.ParseForImport<Cpt, string>(version, p => p.EquivalentComponentId, returnValue);
			this.EquivalentComponentType = line.ParseForImport<Cpt, string>(version, p => p.EquivalentComponentType, returnValue);
			this.AdBasis = line.ParseForImport<Cpt, decimal?>(version, p => p.AdBasis, returnValue);
			this.ComponentTitle = line.ParseForImport<Cpt, string>(version, p => p.ComponentTitle, returnValue);
			this.StandardParcelType = line.ParseForImport<Cpt, string>(version, p => p.StandardParcelType, returnValue);
			this.ApprovedPieceDesignType = line.ParseForImport<Cpt, string>(version, p => p.ApprovedPieceDesignType, returnValue);
			this.ApprovedPieceDesign = line.ParseForImport<Cpt, int?>(version, p => p.ApprovedPieceDesign, returnValue);
			this.UserOptionField = line.ParseForImport<Cpt, string>(version, p => p.UserOptionField, returnValue);
			this.CptRecordStatus = line.ParseForImport<Cpt, string>(version, p => p.CptRecordStatus, returnValue);
			this.EMailpieceSampleGroupId = line.ParseForImport<Cpt, string>(version, p => p.EMailpieceSampleGroupId, returnValue);
			this.ReserveCpt1130 = line.ParseForImport<Cpt, string>(version, p => p.ReserveCpt1130, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cpt, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Cpt, string>(version, p => p.JobId));
			sb.Append(this.ComponentId.FormatForExport<Cpt, string>(version, p => p.ComponentId));
			sb.Append(this.ComponentDescription.FormatForExport<Cpt, string>(version, p => p.ComponentDescription));
			sb.Append(this.ComponentWeight.FormatForExport<Cpt, decimal>(version, p => p.ComponentWeight));
			sb.Append(this.ComponentWeightSource.FormatForExport<Cpt, string>(version, p => p.ComponentWeightSource));
			sb.Append(this.ComponentWeightStatus.FormatForExport<Cpt, string>(version, p => p.ComponentWeightStatus));
			sb.Append(this.ComponentLength.FormatForExport<Cpt, decimal?>(version, p => p.ComponentLength));
			sb.Append(this.ComponentWidth.FormatForExport<Cpt, decimal?>(version, p => p.ComponentWidth));
			sb.Append(this.ComponentThickness.FormatForExport<Cpt, decimal?>(version, p => p.ComponentThickness));
			sb.Append(this.ComponentPeriodicalAdPercentage.FormatForExport<Cpt, decimal?>(version, p => p.ComponentPeriodicalAdPercentage));
			sb.Append(this.ComponentPeriodicalAdPercentageStatus.FormatForExport<Cpt, string>(version, p => p.ComponentPeriodicalAdPercentageStatus));
			sb.Append(this.ComponentClass.FormatForExport<Cpt, string>(version, p => p.ComponentClass));
			sb.Append(this.ComponentRateType.FormatForExport<Cpt, string>(version, p => p.ComponentRateType));
			sb.Append(this.ComponentProcessingCategory.FormatForExport<Cpt, string>(version, p => p.ComponentProcessingCategory));
			sb.Append(this.MailerIdOfMailOwner.FormatForExport<Cpt, string>(version, p => p.MailerIdOfMailOwner));
			sb.Append(this.CridOfMailOwner.FormatForExport<Cpt, string>(version, p => p.CridOfMailOwner));
			sb.Append(this.PeriodicalAdTreatment.FormatForExport<Cpt, string>(version, p => p.PeriodicalAdTreatment));
			sb.Append(this.PeriodicalVolumeNumber.FormatForExport<Cpt, string>(version, p => p.PeriodicalVolumeNumber));
			sb.Append(this.PeriodicalIssueNumber.FormatForExport<Cpt, string>(version, p => p.PeriodicalIssueNumber));
			sb.Append(this.PeriodicalIssueDate.FormatForExport<Cpt, DateOnly?>(version, p => p.PeriodicalIssueDate));
			sb.Append(this.PeriodicalFrequency.FormatForExport<Cpt, int?>(version, p => p.PeriodicalFrequency));
			sb.Append(this.EquivalentUserLicenseCode.FormatForExport<Cpt, string>(version, p => p.EquivalentUserLicenseCode));
			sb.Append(this.EquivalentMailDatJobId.FormatForExport<Cpt, string>(version, p => p.EquivalentMailDatJobId));
			sb.Append(this.EquivalentComponentId.FormatForExport<Cpt, string>(version, p => p.EquivalentComponentId));
			sb.Append(this.EquivalentComponentType.FormatForExport<Cpt, string>(version, p => p.EquivalentComponentType));
			sb.Append(this.AdBasis.FormatForExport<Cpt, decimal?>(version, p => p.AdBasis));
			sb.Append(this.ComponentTitle.FormatForExport<Cpt, string>(version, p => p.ComponentTitle));
			sb.Append(this.StandardParcelType.FormatForExport<Cpt, string>(version, p => p.StandardParcelType));
			sb.Append(this.ApprovedPieceDesignType.FormatForExport<Cpt, string>(version, p => p.ApprovedPieceDesignType));
			sb.Append(this.ApprovedPieceDesign.FormatForExport<Cpt, int?>(version, p => p.ApprovedPieceDesign));
			sb.Append(this.UserOptionField.FormatForExport<Cpt, string>(version, p => p.UserOptionField));
			sb.Append(this.CptRecordStatus.FormatForExport<Cpt, string>(version, p => p.CptRecordStatus));
			sb.Append(this.EMailpieceSampleGroupId.FormatForExport<Cpt, string>(version, p => p.EMailpieceSampleGroupId));
			sb.Append(this.ReserveCpt1130.FormatForExport<Cpt, string>(version, p => p.ReserveCpt1130));
			sb.Append(this.ClosingCharacter.FormatForExport<Cpt, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}