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
	/// A common code for set of components in a mail piece.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "mpu", File = "Mail Piece Unit", Summary = "A common code for set of components in a mail piece.", Description = "A common code for set of components in a mail piece.", LineLength = 193, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "mpu", File = "Mail Piece Unit", Summary = "A common code for set of components in a mail piece.", Description = "A common code for set of components in a mail piece.", LineLength = 193, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "mpu", File = "Mail Piece Unit", Summary = "A common code for set of components in a mail piece.", Description = "A common code for set of components in a mail piece.", LineLength = 193, ClosingCharacter = "#")]
	[MaildatImport(Order = 3, Version = "23-1")]
	[MaildatImport(Order = 3, Version = "24-1")]
	[MaildatImport(Order = 3, Version = "25-1")]
	[Table("Mpu", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Mpu : MaildatEntity, IMpu 
	{
		/// <summary>
		/// Job ID (MPU-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MPU-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Segment ID (MPU-1002)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("MPU-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MPU-1003)
		/// Must have some value, even if single edition. This ID will be used by the computer controlled
		/// equipment at the mailing facility to manufacture the specific binding parts for this make-up within
		/// this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore,
		/// Segment/MPU is mutually exclusive. MPU alone is not unique.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Must have some value, even if single edition. This ID will be used by the computer controlled equipment at the mailing facility to manufacture The specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Must have some value, even if single edition. This ID will be used by the computer controlled equipment at the mailing facility to manufacture The specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Must have some value, even if single edition. This ID will be used by the computer controlled equipment at the mailing facility to manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique.", Type = "string", Format = "zfillnumeric")]
		[Column("MailPieceUnitId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("MPU-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitId { get; set; }

		/// <summary>
		/// Mail Piece Unit Name (MPU-1101)
		/// The name used to identify a specific marketing version within a list, bind and distribution
		/// environment. This name may be on-going as a description from issue to issue, as opposed to the job
		/// to job alpha and/or numeric Selective Bind Code that will control the binding machine. The Mail
		/// Piece Unit Name, more traditionally in Periodicals, may be a meaningful identifier; such as S-S NW
		/// Metro. Whether in Periodicals or other classes, the MPU Name field is a defined location where
		/// downstream users can find the MPU's meaningful Name for this job, regardless of the arbitrary MPU
		/// ID. If, as may often be the case in non-Periodical, there is no benefit derived from special naming
		/// then the Book Make-up Name can be the same as the MPU ID. The MPU Name will be the source for mail
		/// owner's name on Postage Payment forms or their electronic equivalents. Suggested convention for
		/// carrying the identity of the base book: - Example MPU Name Value:Exxxxxxx_BRO -- E (hard coded)
		/// stands for edition; -- xxxxxxx (only as many as necessary) represents base book edition; -- _
		/// (underline) separates edition & suffix; -- B/R/O (solo or BO or RO) --- B = Bill, R = Renewal, O=
		/// Other H = Periodicals Ride-Along - Additional Examples: E9711COM_B or E1997S_O or E01_RO.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1101", FieldName = "Mail Piece Unit Name", Start = 18, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "The name used to identify a specific marketing version within a list, bind and distribution environment. This name may be on-going as a description from issue to issue, as opposed to the job to job alpha And/or numeric Selective Bind Code that will control the binding machine.  The Mail Piece Unit Name, more traditionally in Periodicals, may be a meaningful identifier; such as S-S NW Metro. Whether in Periodicals or other classes, the MPU Name field is a defined location where downstream Users can find the MPU's meaningful Name for this job, regardless of the arbitrary MPU ID. If, as may often be the case in non-Periodical, there is no benefit derived from special naming Then the Book Make-up Name can be the same as the MPU ID. The MPU Name will be the source for mail owner's name on Postage Payment forms or their electronic equivalents.  Suggested convention for carrying the identity of the base book: - Example MPU Name Value:Exxxxxxx_BRO -- E (hard coded) stands for edition; -- xxxxxxx (only as many as necessary) represents base book edition; -- _ (underline) separates edition & suffix; -- B/R/O (solo or BO or RO) --- B = Bill, R = Renewal, O= Other H = Periodicals Ride-Along - Additional Examples: E9711COM_B or E1997S_O or E01_RO.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1101", FieldName = "Mail Piece Unit Name", Start = 18, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "The name used to identify a specific marketing version within a list, bind and distribution environment. This name may be on-going as a description from issue to issue, as opposed to the job to job alpha And/or numeric Selective Bind Code that will control the binding machine.  The Mail Piece Unit Name, more traditionally in Periodicals, may be a meaningful identifier; such as S-S NW Metro. Whether in Periodicals or other classes, the MPU Name field is a defined location where downstream Users can find the MPU's meaningful Name for this job, regardless of the arbitrary MPU ID. If, as may often be the case in non-Periodical, there is no benefit derived from special naming Then the Book Make-up Name can be the same as the MPU ID. The MPU Name will be the source for mail owner's name on Postage Payment forms or their electronic equivalents.  Suggested convention for carrying the identity of the base book: - Example MPU Name Value:Exxxxxxx_BRO -- E (hard coded) stands for edition; -- xxxxxxx (only as many as necessary) represents base book edition; -- _ (underline) separates edition & suffix; -- B/R/O (solo or BO or RO) --- B = Bill, R = Renewal, O= Other H = Periodicals Ride-Along - Additional Examples: E9711COM_B or E1997S_O or E01_RO.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1101", FieldName = "Mail Piece Unit Name", Start = 18, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "The name used to identify a specific marketing version within a list, bind and distribution environment. This name may be on-going as a description from issue to issue, as opposed to the job to job alpha and/or numeric Selective Bind Code that will control the binding machine. The Mail Piece Unit Name, more traditionally in Periodicals, may be a meaningful identifier; such as S-S NW Metro. Whether in Periodicals or other classes, the MPU Name field is a defined location where downstream users can find the MPU's meaningful Name for this job, regardless of the arbitrary MPU ID. If, as may often be the case in non-Periodical, there is no benefit derived from special naming then the Book Make-up Name can be the same as the MPU ID. The MPU Name will be the source for mail owner's name on Postage Payment forms or their electronic equivalents. Suggested convention for carrying the identity of the base book: - Example MPU Name Value:Exxxxxxx_BRO -- E (hard coded) stands for edition; -- xxxxxxx (only as many as necessary) represents base book edition; -- _ (underline) separates edition & suffix; -- B/R/O (solo or BO or RO) --- B = Bill, R = Renewal, O= Other H = Periodicals Ride-Along - Additional Examples: E9711COM_B or E1997S_O or E01_RO.", Type = "string", Format = "leftjustify")]
		[Column("MailPieceUnitName", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(12)]
		[Comment("MPU-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitName { get; set; }

		/// <summary>
		/// Mail Piece Unit Description (MPU-1102)
		/// This is a unique name or code for each specific version being created within this mailing. However,
		/// as a differentiation from the Mail Piece Unit Name, this may be a meaningful descriptor of a broader
		/// significance than just this mailing. Therefore, this field is an opportunity to have absolute, as
		/// well as of relative, information in this record. This offers information for enhanced quality
		/// assurance and reduced error. For example: A periodical has a Metro Northwest Superspot edition that
		/// is run every issue. Therefore, the Mail Piece Unit ID to drive the machine in the bindery might be B
		/// for one issue and Q a month later. However, the Mail Piece Unit Name would always be S-S NW Metro
		/// and the Mail Piece Unit Description would always be Metro Northwest Superspot A 3C campaign may not
		/// have repeating market target names; or they may. So, the Mail Piece Unit IDs for a mailing may be A,
		/// B, and C. For that campaign, the MPU Descriptions may be A, B, and C., or the MPU Descriptions could
		/// be RHF, RHS, and RHT, if those were meaningful codes carrying over from one job to another. The
		/// originator of the Mail.dat® file, as agreed by receiving mailing facilities, can choose to the
		/// finest level of detail in the preceding two fields or simply clone that which is in the Mail Piece
		/// Unit ID field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1102", FieldName = "Mail Piece Unit Description", Start = 30, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific version being created Within this mailing. However, as a differentiation from the Mail Piece Unit Name, this may be a meaningful descriptor of a broader Significance than just this mailing. Therefore, this field is an Opportunity to have absolute, as well as of relative, information in this Record. This offers information for enhanced quality assurance and Reduced error. For example: A periodical has a Metro Northwest Superspot edition That is run every issue. Therefore, the Mail Piece Unit ID to drive the Machine in the bindery might be B for one issue and Q a month Later. However, the Mail Piece Unit Name would always be S-S NW Metro and the Mail Piece Unit Description would always be Metro Northwest Superspot A 3C campaign may not have repeating market target names; or they May. So, the Mail Piece Unit IDs for a mailing may be A, B, and C. For that campaign, the MPU Descriptions may be A, B, and C., or the MPU Descriptions could be RHF, RHS, and RHT, If those were meaningful codes carrying over from one job to another. The originator of the Mail.dat® file, as agreed by receiving mailing Facilities, can choose to the finest level of detail in the preceding two Fields or simply clone that which is in the Mail Piece Unit ID field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1102", FieldName = "Mail Piece Unit Description", Start = 30, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific version being created Within this mailing. However, as a differentiation from the Mail Piece Unit Name, this may be a meaningful descriptor of a broader Significance than just this mailing. Therefore, this field is an Opportunity to have absolute, as well as of relative, information in this Record. This offers information for enhanced quality assurance and Reduced error. For example: A periodical has a Metro Northwest Superspot edition That is run every issue. Therefore, the Mail Piece Unit ID to drive the Machine in the bindery might be B for one issue and Q a month Later. However, the Mail Piece Unit Name would always be S-S NW Metro and the Mail Piece Unit Description would always be Metro Northwest Superspot A 3C campaign may not have repeating market target names; or they May. So, the Mail Piece Unit IDs for a mailing may be A, B, and C. For that campaign, the MPU Descriptions may be A, B, and C., or the MPU Descriptions could be RHF, RHS, and RHT, If those were meaningful codes carrying over from one job to another. The originator of the Mail.dat® file, as agreed by receiving mailing Facilities, can choose to the finest level of detail in the preceding two Fields or simply clone that which is in the Mail Piece Unit ID field.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1102", FieldName = "Mail Piece Unit Description", Start = 30, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "This is a unique name or code for each specific version being created within this mailing. However, as a differentiation from the Mail Piece Unit Name, this may be a meaningful descriptor of a broader significance than just this mailing. Therefore, this field is an opportunity to have absolute, as well as of relative, information in this record. This offers information for enhanced quality assurance and reduced error. For example: A periodical has a Metro Northwest Superspot edition that is run every issue. Therefore, the Mail Piece Unit ID to drive the machine in the bindery might be B for one issue and Q a month later. However, the Mail Piece Unit Name would always be S-S NW Metro and the Mail Piece Unit Description would always be Metro Northwest Superspot A 3C campaign may not have repeating market target names; or they may. So, the Mail Piece Unit IDs for a mailing may be A, B, and C. For that campaign, the MPU Descriptions may be A, B, and C., or the MPU Descriptions could be RHF, RHS, and RHT, if those were meaningful codes carrying over from one job to another. The originator of the Mail.dat® file, as agreed by receiving mailing facilities, can choose to the finest level of detail in the preceding two fields or simply clone that which is in the Mail Piece Unit ID field.", Type = "string", Format = "leftjustify")]
		[Column("MailPieceUnitDescription", Order = 6, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("MPU-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitDescription { get; set; }

		/// <summary>
		/// Mail Piece Unit - Weight (MPU-1103)
		/// Weight of a copy in pounds, rounded. Presort Facilities default to 1 ounce, if Metered Mail.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1103", FieldName = "Mail Piece Unit - Weight", Start = 60, Length = 6, Required = true, Key = false, DataType = "N", Description = "Weight of a copy in pounds, rounded. Presort Facilities default to 1 ounce, if Metered Mail.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1103", FieldName = "Mail Piece Unit - Weight", Start = 60, Length = 6, Required = true, Key = false, DataType = "N", Description = "Weight of a copy in pounds, rounded. Presort Facilities default to 1 ounce, if Metered Mail.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1103", FieldName = "Mail Piece Unit - Weight", Start = 60, Length = 6, Required = true, Key = false, DataType = "N", Description = "Weight of a copy in pounds, rounded. Presort Facilities default to 1 ounce, if Metered Mail.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("MailPieceUnitWeight", Order = 7, TypeName = "NUMERIC")]
		[Required]
		[Precision(4)]
		[Comment("MPU-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal MailPieceUnitWeight { get; set; }

		/// <summary>
		/// MPU - Weight: Source (MPU-1104)
		/// Source of Piece Weight.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1104", FieldName = "MPU - Weight: Source", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1104", FieldName = "MPU - Weight: Source", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1104", FieldName = "MPU - Weight: Source", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Source of Piece Weight.", Type = "enum", Format = "leftjustify")]
		[Column("MpuWeightSource", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("A", "C", "L", "P")]
		[Comment("MPU-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MpuWeightSources))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpuWeightSource { get; set; }

		/// <summary>
		/// MPU - Weight: Status (MPU-1105)
		/// Status of weight data.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1105", FieldName = "MPU - Weight: Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1105", FieldName = "MPU - Weight: Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1105", FieldName = "MPU - Weight: Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Status of weight data.", Type = "enum", Format = "leftjustify")]
		[Column("MpuWeightStatus", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("F", "M", "N", "P")]
		[Comment("MPU-1105")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MpuWeightStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpuWeightStatus { get; set; }

		/// <summary>
		/// Mail Piece Unit - Length (MPU-1106)
		/// Length of a copy in inches, rounded.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1106", FieldName = "Mail Piece Unit - Length", Start = 68, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1106", FieldName = "Mail Piece Unit - Length", Start = 68, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1106", FieldName = "Mail Piece Unit - Length", Start = 68, Length = 7, Required = false, Key = false, DataType = "N", Description = "Length of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("MailPieceUnitLength", Order = 10, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("MPU-1106")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? MailPieceUnitLength { get; set; }

		/// <summary>
		/// Mail Piece Unit - Width (MPU-1107)
		/// Width of a copy in inches, rounded.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1107", FieldName = "Mail Piece Unit - Width", Start = 75, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1107", FieldName = "Mail Piece Unit - Width", Start = 75, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1107", FieldName = "Mail Piece Unit - Width", Start = 75, Length = 6, Required = false, Key = false, DataType = "N", Description = "Width of a copy in inches, rounded.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("MailPieceUnitWidth", Order = 11, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("MPU-1107")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? MailPieceUnitWidth { get; set; }

		/// <summary>
		/// Mail Piece Unit - Thickness (MPU-1108)
		/// Thickness of a copy in inches.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1108", FieldName = "Mail Piece Unit - Thickness", Start = 81, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy in inches.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1108", FieldName = "Mail Piece Unit - Thickness", Start = 81, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy in inches.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1108", FieldName = "Mail Piece Unit - Thickness", Start = 81, Length = 6, Required = false, Key = false, DataType = "N", Description = "Thickness of a copy in inches.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("MailPieceUnitThickness", Order = 12, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("MPU-1108")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? MailPieceUnitThickness { get; set; }

		/// <summary>
		/// Mail Piece Unit - Class (MPU-1111)
		/// The Postal Class of this Mail Piece Unit within Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1111", FieldName = "Mail Piece Unit - Class", Start = 87, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1111", FieldName = "Mail Piece Unit - Class", Start = 87, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1111", FieldName = "Mail Piece Unit - Class", Start = 87, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of this Mail Piece Unit within Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("MailPieceUnitClass", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "9")]
		[Comment("MPU-1111")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailPieceUnitClasses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitClass { get; set; }

		/// <summary>
		/// Mail Piece Unit - Rate Type (MPU-1112)
		/// The special rate type that applies to this Mail Piece Unit.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1112", FieldName = "Mail Piece Unit - Rate Type", Start = 88, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The special rate type that applies to this Mail Piece Unit.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1112", FieldName = "Mail Piece Unit - Rate Type", Start = 88, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The special rate type that applies to this Mail Piece Unit.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1112", FieldName = "Mail Piece Unit - Rate Type", Start = 88, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The special rate type that applies to this Mail Piece Unit.", Type = "enum", Format = "leftjustify")]
		[Column("MailPieceUnitRateType", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("B", "C", "D", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "E", "E1", "E2", "E7", "F", "G", "J", "K", "L", "N", "O", "P", "R", "S", "T", "T1", "T2", "T3", "T4", "T5", "W", "X", "Y")]
		[Comment("MPU-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailPieceUnitRateTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitRateType { get; set; }

		/// <summary>
		/// Rate Schedule (MPU-1128)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1128", FieldName = "Rate Schedule", Start = 90, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1128", FieldName = "Rate Schedule", Start = 90, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1128", FieldName = "Rate Schedule", Start = 90, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("RateSchedule", Order = 15, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "N", "R")]
		[Comment("MPU-1128")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RateSchedules))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RateSchedule { get; set; }

		/// <summary>
		/// Mail Piece Unit - Processing Category (MPU-1113)
		/// The processing category for which this Mail Piece Unit is eligible.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1113", FieldName = "Mail Piece Unit - Processing Category", Start = 91, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The processing category for which this Mail Piece Unit is eligible.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1113", FieldName = "Mail Piece Unit - Processing Category", Start = 91, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The processing category for which this Mail Piece Unit is eligible.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1113", FieldName = "Mail Piece Unit - Processing Category", Start = 91, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The processing category for which this Mail Piece Unit is eligible.", Type = "enum", Format = "leftjustify")]
		[Column("MailPieceUnitProcessingCategory", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("CD", "CM", "FL", "IR", "LT", "MP", "NP", "PF")]
		[Comment("MPU-1113")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailPieceUnitProcessingCategories))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitProcessingCategory { get; set; }

		/// <summary>
		/// MPU Surcharge (MPU-1115)
		/// Surcharges applicable to the this MPU. Regarding Machinability; a single MPU will be used to
		/// describe the nature of the mail piece: - The MPU - Surcharge field to indicate overall nature of the
		/// piece's physical characteristics. - Two MPUs (and associated CPTs) may be necessary to communicate a
		/// mailing, not just CPTs.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1115", FieldName = "MPU Surcharge", Start = 93, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Surcharges applicable to the this MPU. Regarding Machinability; a single MPU will be used to describe the nature of the mail piece: - The MPU - Surcharge field to indicate overall nature of the piece's physical characteristics. - Two MPUs (and associated CPTs) may be necessary to communicate a mailing, not just CPTs.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1115", FieldName = "MPU Surcharge", Start = 93, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Surcharges applicable to the this MPU. Regarding Machinability; a single MPU will be used to describe the nature of the mail piece: - The MPU - Surcharge field to indicate overall nature of the piece's physical characteristics. - Two MPUs (and associated CPTs) may be necessary to communicate a mailing, not just CPTs.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1115", FieldName = "MPU Surcharge", Start = 93, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Surcharges applicable to the this MPU. Regarding Machinability; a single MPU will be used to describe the nature of the mail piece: - The MPU - Surcharge field to indicate overall nature of the piece's physical characteristics. - Two MPUs (and associated CPTs) may be necessary to communicate a mailing, not just CPTs.", Type = "enum", Format = "leftjustify")]
		[Column("MpuSurcharge", Order = 17, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "D", "N", "O", "Q", "R", "S", "T")]
		[Comment("MPU-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MpuSurcharges))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpuSurcharge { get; set; }

		/// <summary>
		/// Co-Palletization Code (MPU-1116)
		/// Used to differentiate carrier route mail going to the same ZIP and Route that was coded and
		/// presorted independently, to allow association with a subset of the Walk Sequence Records (*.wsr).
		/// For Co-palletization, it creates an efficient means to differentiate each of the possible job and
		/// sub-job entities within a co-palletization set-up. Can also be used to differentiate between
		/// simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for
		/// jobs where this additional level of detail is not needed.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1116", FieldName = "Co-Palletization Code", Start = 94, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to allow Association with a subset of the Walk Sequence Records (*.wsr). For Co-palletization, it creates an efficient means to differentiate Each of the possible job and sub-job entities within a co-palletization Set-up. Can also be used to differentiate between simplified and Non-simplified addressed pieces when combined in the same job. Populate with 01 for jobs where this additional level of detail is Not needed.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1116", FieldName = "Co-Palletization Code", Start = 94, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to allow Association with a subset of the Walk Sequence Records (*.wsr). For Co-palletization, it creates an efficient means to differentiate Each of the possible job and sub-job entities within a co-palletization Set-up. Can also be used to differentiate between simplified and Non-simplified addressed pieces when combined in the same job. Populate with 01 for jobs where this additional level of detail is Not needed.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1116", FieldName = "Co-Palletization Code", Start = 94, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to allow association with a subset of the Walk Sequence Records (*.wsr). For Co-palletization, it creates an efficient means to differentiate each of the possible job and sub-job entities within a co-palletization set-up. Can also be used to differentiate between simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for jobs where this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[Column("CoPalletizationCode", Order = 18, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[Comment("MPU-1116")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CoPalletizationCode { get; set; }

		/// <summary>
		/// Machinability Indicator (MPU-1123)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1123", FieldName = "Machinability Indicator", Start = 96, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1123", FieldName = "Machinability Indicator", Start = 96, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1123", FieldName = "Machinability Indicator", Start = 96, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MachinabilityIndicator", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "U", "Y")]
		[Comment("MPU-1123")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MachinabilityIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MachinabilityIndicator { get; set; }

		/// <summary>
		/// Pre-Denominated Amount (MPU-1124)
		/// Cents.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1124", FieldName = "Pre-Denominated Amount", Start = 97, Length = 5, Required = false, Key = false, DataType = "N", Description = "Cents.", Type = "decimal", Format = "zfill", Precision = 1)]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1124", FieldName = "Pre-Denominated Amount", Start = 97, Length = 5, Required = false, Key = false, DataType = "N", Description = "Cents.", Type = "decimal", Format = "zfill", Precision = 1)]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1124", FieldName = "Pre-Denominated Amount", Start = 97, Length = 5, Required = false, Key = false, DataType = "N", Description = "Cents.", Type = "decimal", Format = "zfill", Precision = 1)]
		[Column("PreDenominatedAmount", Order = 20, TypeName = "NUMERIC")]
		[Precision(1)]
		[Comment("MPU-1124")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? PreDenominatedAmount { get; set; }

		/// <summary>
		/// Postage Affixed Type (MPU-1125)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1125", FieldName = "Postage Affixed Type", Start = 102, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1125", FieldName = "Postage Affixed Type", Start = 102, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1125", FieldName = "Postage Affixed Type", Start = 102, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PostageAffixedType", Order = 21, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("M", "S")]
		[Comment("MPU-1125")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PostageAffixedTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PostageAffixedType { get; set; }

		/// <summary>
		/// Standard Parcel Type (MPU-1132)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1132", FieldName = "Standard Parcel Type", Start = 103, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1132", FieldName = "Standard Parcel Type", Start = 103, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1132", FieldName = "Standard Parcel Type", Start = 103, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("StandardParcelType", Order = 22, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "F", "H", "L", "M", "P", "S")]
		[Comment("MPU-1132")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(StandardParcelTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string StandardParcelType { get; set; }

		/// <summary>
		/// User Option Field (MPU-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1129", FieldName = "User Option Field", Start = 104, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1129", FieldName = "User Option Field", Start = 104, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1129", FieldName = "User Option Field", Start = 104, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 23, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("MPU-1129")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Move Update Supplier CRID (MPU-1130)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for compliance
		/// with USPS move update requirements. Only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1130", FieldName = "Move Update Supplier CRID", Start = 124, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for compliance with USPS move update requirements. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1130", FieldName = "Move Update Supplier CRID", Start = 124, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for compliance with USPS move update requirements. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1130", FieldName = "Move Update Supplier CRID", Start = 124, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for compliance with USPS move update requirements. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MoveUpdateSupplierCrid", Order = 24, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("MPU-1130")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MoveUpdateSupplierCrid { get; set; }

		/// <summary>
		/// Piece Uniqueness Manager CRID (MPU-1131)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for maintaining
		/// piece IMb® uniqueness. Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1131", FieldName = "Piece Uniqueness Manager CRID", Start = 136, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining piece IMb® uniqueness. Left justify, space Padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1131", FieldName = "Piece Uniqueness Manager CRID", Start = 136, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining piece IMb® uniqueness. Left justify, space Padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1131", FieldName = "Piece Uniqueness Manager CRID", Start = 136, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for maintaining piece IMb® uniqueness. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("PieceUniquenessManagerCrid", Order = 25, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("MPU-1131")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceUniquenessManagerCrid { get; set; }

		/// <summary>
		/// MPU Record Status (MPU-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-2000", FieldName = "MPU Record Status", Start = 148, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-2000", FieldName = "MPU Record Status", Start = 148, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-2000", FieldName = "MPU Record Status", Start = 148, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("MpuRecordStatus", Order = 26, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("MPU-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MpuRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpuRecordStatus { get; set; }

		/// <summary>
		/// Grouped Extra Service Type (MPU-1133)
		/// Identifies the type of Grouped Extra Service.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1133", FieldName = "Grouped Extra Service Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Identifies the type of Grouped Extra Service.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1133", FieldName = "Grouped Extra Service Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Identifies the type of Grouped Extra Service.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1133", FieldName = "Grouped Extra Service Type", Start = 149, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Identifies the type of Grouped Extra Service.", Type = "enum", Format = "leftjustify")]
		[Column("GroupedExtraServiceType", Order = 27, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "B", "F")]
		[Comment("MPU-1133")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(GroupedExtraServiceTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string GroupedExtraServiceType { get; set; }

		/// <summary>
		/// Grouped Extra Service Barcode (MPU-1134)
		/// Identifies IMpb® (Intelligent Mail Package Barcode).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1134", FieldName = "Grouped Extra Service Barcode", Start = 150, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "Identifies IMpb® (Intelligent Mail Package Barcode).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1134", FieldName = "Grouped Extra Service Barcode", Start = 150, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "Identifies IMpb® (Intelligent Mail Package Barcode).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1134", FieldName = "Grouped Extra Service Barcode", Start = 150, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "Identifies IMpb® (Intelligent Mail Package Barcode).", Type = "string", Format = "leftjustify")]
		[Column("GroupedExtraServiceBarcode", Order = 28, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("MPU-1134")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string GroupedExtraServiceBarcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (MPU-1135)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1135", FieldName = "IMpb® Barcode Construct Code", Start = 184, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1135", FieldName = "IMpb® Barcode Construct Code", Start = 184, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1135", FieldName = "IMpb® Barcode Construct Code", Start = 184, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("ImpbBarcodeConstructCode", Order = 29, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("MPU-1135")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ImpbBarcodeConstructCodes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// Reserve (MPU-1121)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-1121", FieldName = "Reserve", Start = 185, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-1121", FieldName = "Reserve", Start = 185, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-1121", FieldName = "Reserve", Start = 185, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveMpu1121", Order = 30, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("MPU-1121")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveMpu1121 { get; set; }

		/// <summary>
		/// Closing Character (MPU-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "mpu", FieldCode = "MPU-9999", FieldName = "Closing Character", Start = 193, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "mpu", FieldCode = "MPU-9999", FieldName = "Closing Character", Start = 193, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "mpu", FieldCode = "MPU-9999", FieldName = "Closing Character", Start = 193, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 31, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("MPU-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Mpu, string>(version, p => p.JobId, returnValue);
			this.SegmentId = line.ParseForImport<Mpu, string>(version, p => p.SegmentId, returnValue);
			this.MailPieceUnitId = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitId, returnValue);
			this.MailPieceUnitName = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitName, returnValue);
			this.MailPieceUnitDescription = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitDescription, returnValue);
			this.MailPieceUnitWeight = line.ParseForImport<Mpu, decimal>(version, p => p.MailPieceUnitWeight, returnValue);
			this.MpuWeightSource = line.ParseForImport<Mpu, string>(version, p => p.MpuWeightSource, returnValue);
			this.MpuWeightStatus = line.ParseForImport<Mpu, string>(version, p => p.MpuWeightStatus, returnValue);
			this.MailPieceUnitLength = line.ParseForImport<Mpu, decimal?>(version, p => p.MailPieceUnitLength, returnValue);
			this.MailPieceUnitWidth = line.ParseForImport<Mpu, decimal?>(version, p => p.MailPieceUnitWidth, returnValue);
			this.MailPieceUnitThickness = line.ParseForImport<Mpu, decimal?>(version, p => p.MailPieceUnitThickness, returnValue);
			this.MailPieceUnitClass = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitClass, returnValue);
			this.MailPieceUnitRateType = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitRateType, returnValue);
			this.RateSchedule = line.ParseForImport<Mpu, string>(version, p => p.RateSchedule, returnValue);
			this.MailPieceUnitProcessingCategory = line.ParseForImport<Mpu, string>(version, p => p.MailPieceUnitProcessingCategory, returnValue);
			this.MpuSurcharge = line.ParseForImport<Mpu, string>(version, p => p.MpuSurcharge, returnValue);
			this.CoPalletizationCode = line.ParseForImport<Mpu, string>(version, p => p.CoPalletizationCode, returnValue);
			this.MachinabilityIndicator = line.ParseForImport<Mpu, string>(version, p => p.MachinabilityIndicator, returnValue);
			this.PreDenominatedAmount = line.ParseForImport<Mpu, decimal?>(version, p => p.PreDenominatedAmount, returnValue);
			this.PostageAffixedType = line.ParseForImport<Mpu, string>(version, p => p.PostageAffixedType, returnValue);
			this.StandardParcelType = line.ParseForImport<Mpu, string>(version, p => p.StandardParcelType, returnValue);
			this.UserOptionField = line.ParseForImport<Mpu, string>(version, p => p.UserOptionField, returnValue);
			this.MoveUpdateSupplierCrid = line.ParseForImport<Mpu, string>(version, p => p.MoveUpdateSupplierCrid, returnValue);
			this.PieceUniquenessManagerCrid = line.ParseForImport<Mpu, string>(version, p => p.PieceUniquenessManagerCrid, returnValue);
			this.MpuRecordStatus = line.ParseForImport<Mpu, string>(version, p => p.MpuRecordStatus, returnValue);
			this.GroupedExtraServiceType = line.ParseForImport<Mpu, string>(version, p => p.GroupedExtraServiceType, returnValue);
			this.GroupedExtraServiceBarcode = line.ParseForImport<Mpu, string>(version, p => p.GroupedExtraServiceBarcode, returnValue);
			this.ImpbBarcodeConstructCode = line.ParseForImport<Mpu, string>(version, p => p.ImpbBarcodeConstructCode, returnValue);
			this.ReserveMpu1121 = line.ParseForImport<Mpu, string>(version, p => p.ReserveMpu1121, returnValue);
			this.ClosingCharacter = line.ParseForImport<Mpu, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Mpu, string>(version, p => p.JobId));
			sb.Append(this.SegmentId.FormatForExport<Mpu, string>(version, p => p.SegmentId));
			sb.Append(this.MailPieceUnitId.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitId));
			sb.Append(this.MailPieceUnitName.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitName));
			sb.Append(this.MailPieceUnitDescription.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitDescription));
			sb.Append(this.MailPieceUnitWeight.FormatForExport<Mpu, decimal>(version, p => p.MailPieceUnitWeight));
			sb.Append(this.MpuWeightSource.FormatForExport<Mpu, string>(version, p => p.MpuWeightSource));
			sb.Append(this.MpuWeightStatus.FormatForExport<Mpu, string>(version, p => p.MpuWeightStatus));
			sb.Append(this.MailPieceUnitLength.FormatForExport<Mpu, decimal?>(version, p => p.MailPieceUnitLength));
			sb.Append(this.MailPieceUnitWidth.FormatForExport<Mpu, decimal?>(version, p => p.MailPieceUnitWidth));
			sb.Append(this.MailPieceUnitThickness.FormatForExport<Mpu, decimal?>(version, p => p.MailPieceUnitThickness));
			sb.Append(this.MailPieceUnitClass.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitClass));
			sb.Append(this.MailPieceUnitRateType.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitRateType));
			sb.Append(this.RateSchedule.FormatForExport<Mpu, string>(version, p => p.RateSchedule));
			sb.Append(this.MailPieceUnitProcessingCategory.FormatForExport<Mpu, string>(version, p => p.MailPieceUnitProcessingCategory));
			sb.Append(this.MpuSurcharge.FormatForExport<Mpu, string>(version, p => p.MpuSurcharge));
			sb.Append(this.CoPalletizationCode.FormatForExport<Mpu, string>(version, p => p.CoPalletizationCode));
			sb.Append(this.MachinabilityIndicator.FormatForExport<Mpu, string>(version, p => p.MachinabilityIndicator));
			sb.Append(this.PreDenominatedAmount.FormatForExport<Mpu, decimal?>(version, p => p.PreDenominatedAmount));
			sb.Append(this.PostageAffixedType.FormatForExport<Mpu, string>(version, p => p.PostageAffixedType));
			sb.Append(this.StandardParcelType.FormatForExport<Mpu, string>(version, p => p.StandardParcelType));
			sb.Append(this.UserOptionField.FormatForExport<Mpu, string>(version, p => p.UserOptionField));
			sb.Append(this.MoveUpdateSupplierCrid.FormatForExport<Mpu, string>(version, p => p.MoveUpdateSupplierCrid));
			sb.Append(this.PieceUniquenessManagerCrid.FormatForExport<Mpu, string>(version, p => p.PieceUniquenessManagerCrid));
			sb.Append(this.MpuRecordStatus.FormatForExport<Mpu, string>(version, p => p.MpuRecordStatus));
			sb.Append(this.GroupedExtraServiceType.FormatForExport<Mpu, string>(version, p => p.GroupedExtraServiceType));
			sb.Append(this.GroupedExtraServiceBarcode.FormatForExport<Mpu, string>(version, p => p.GroupedExtraServiceBarcode));
			sb.Append(this.ImpbBarcodeConstructCode.FormatForExport<Mpu, string>(version, p => p.ImpbBarcodeConstructCode));
			sb.Append(this.ReserveMpu1121.FormatForExport<Mpu, string>(version, p => p.ReserveMpu1121));
			sb.Append(this.ClosingCharacter.FormatForExport<Mpu, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}