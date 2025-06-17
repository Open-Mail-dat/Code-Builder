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
	/// Technique and amount for adjustment per container. Notes technique and reports postage adjustment
	/// per container.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "par", File = "Postage Adjustment Record", Summary = "Technique and amount for adjustment per container.", Description = "Technique and amount for adjustment per container. Notes technique and reports postage adjustment per container.", LineLength = 128, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "par", File = "Postage Adjustment Record", Summary = "Technique and amount for adjustment per container.", Description = "Technique and amount for adjustment per container. Notes technique and reports postage adjustment per container.", LineLength = 128, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "par", File = "Postage Adjustment Record", Summary = "Technique and amount for adjustment per container.", Description = "Technique and amount for adjustment per container. Notes technique and reports postage adjustment per container.", LineLength = 128, ClosingCharacter = "#")]
	[MaildatImport(Order = 18, Version = "23-1")]
	[MaildatImport(Order = 18, Version = "24-1")]
	[MaildatImport(Order = 18, Version = "25-1")]
	[Table("Par", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Par : MaildatEntity, IPar 
	{
		/// <summary>
		/// Job ID (PAR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PAR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Segment ID (PAR-1002)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("PAR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (PAR-1003)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("PAR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitId { get; set; }

		/// <summary>
		/// Component ID (PAR-1004)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[Column("ComponentId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PAR-1004")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentId { get; set; }

		/// <summary>
		/// Sequence Number (PAR-1024)
		/// A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1024", FieldName = "Sequence Number", Start = 26, Length = 3, Required = true, Key = true, DataType = "N", Description = "A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1024", FieldName = "Sequence Number", Start = 26, Length = 3, Required = true, Key = true, DataType = "N", Description = "A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1024", FieldName = "Sequence Number", Start = 26, Length = 3, Required = true, Key = true, DataType = "N", Description = "A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.", Type = "integer", Format = "zfill")]
		[Column("SequenceNumber", Order = 6, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PAR-1024")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int SequenceNumber { get; set; }

		/// <summary>
		/// Date (PAR-1101)
		/// Adjustment Date (cannot be all zeros).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1101", FieldName = "Date", Start = 29, Length = 8, Required = true, Key = false, DataType = "N", Description = "Adjustment Date.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1101", FieldName = "Date", Start = 29, Length = 8, Required = true, Key = false, DataType = "N", Description = "Adjustment Date.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1101", FieldName = "Date", Start = 29, Length = 8, Required = true, Key = false, DataType = "N", Description = "Adjustment Date (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("Date", Order = 7, TypeName = "TEXT")]
		[Required]
		[Comment("PAR-1101")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly Date { get; set; }

		/// <summary>
		/// Adjustment Type (PAR-1102)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1102", FieldName = "Adjustment Type", Start = 37, Length = 2, Required = true, Key = false, DataType = "N", Description = "", Type = "enum", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1102", FieldName = "Adjustment Type", Start = 37, Length = 2, Required = true, Key = false, DataType = "N", Description = "", Type = "enum", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1102", FieldName = "Adjustment Type", Start = 37, Length = 2, Required = true, Key = false, DataType = "N", Description = "", Type = "enum", Format = "zfill")]
		[Column("AdjustmentType", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("01", "02", "03", "04")]
		[Comment("PAR-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(AdjustmentTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string AdjustmentType { get; set; }

		/// <summary>
		/// Adjustment Amount (PAR-1103)
		/// Dollars.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1103", FieldName = "Adjustment Amount", Start = 39, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1103", FieldName = "Adjustment Amount", Start = 39, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1103", FieldName = "Adjustment Amount", Start = 39, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("AdjustmentAmount", Order = 9, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("PAR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal AdjustmentAmount { get; set; }

		/// <summary>
		/// Credit/Debit Indicator (PAR-1104)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1104", FieldName = "Credit/Debit Indicator", Start = 48, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1104", FieldName = "Credit/Debit Indicator", Start = 48, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1104", FieldName = "Credit/Debit Indicator", Start = 48, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CreditDebitIndicator", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D")]
		[Comment("PAR-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CreditDebitIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CreditDebitIndicator { get; set; }

		/// <summary>
		/// Total Pieces Affected (PAR-1106)
		/// (0 [zero] is a permitted value).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1106", FieldName = "Total Pieces Affected", Start = 49, Length = 8, Required = false, Key = false, DataType = "N", Description = "(0 [zero] is a permitted value).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1106", FieldName = "Total Pieces Affected", Start = 49, Length = 8, Required = false, Key = false, DataType = "N", Description = "(0 [zero] is a permitted value).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1106", FieldName = "Total Pieces Affected", Start = 49, Length = 8, Required = false, Key = false, DataType = "N", Description = "(0 [zero] is a permitted value).", Type = "integer", Format = "zfill")]
		[Column("TotalPiecesAffected", Order = 11, TypeName = "INTEGER")]
		[Comment("PAR-1106")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? TotalPiecesAffected { get; set; }

		/// <summary>
		/// User Comments (PAR-1105)
		/// Free form field for user notes.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1105", FieldName = "User Comments", Start = 57, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Free form field for user notes.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1105", FieldName = "User Comments", Start = 57, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Free form field for user notes.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1105", FieldName = "User Comments", Start = 57, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Free form field for user notes.", Type = "string", Format = "leftjustify")]
		[Column("UserComments", Order = 12, TypeName = "TEXT")]
		[MaxLength(19)]
		[Comment("PAR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserComments { get; set; }

		/// <summary>
		/// Adjustment Status (PAR-1108)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1108", FieldName = "Adjustment Status", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1108", FieldName = "Adjustment Status", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1108", FieldName = "Adjustment Status", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("AdjustmentStatus", Order = 13, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "C", "P", "R", "T", "X")]
		[Comment("PAR-1108")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(AdjustmentStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string AdjustmentStatus { get; set; }

		/// <summary>
		/// MPA - Unique Sequence/Grouping ID (PAR-1109)
		/// Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one
		/// Postage Statement.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1109", FieldName = "MPA - Unique Sequence/Grouping ID", Start = 77, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1109", FieldName = "MPA - Unique Sequence/Grouping ID", Start = 77, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1109", FieldName = "MPA - Unique Sequence/Grouping ID", Start = 77, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "zfillnumeric")]
		[Column("MpaUniqueSequenceGroupingId", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("PAR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpaUniqueSequenceGroupingId { get; set; }

		/// <summary>
		/// User Option Field (PAR-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1129", FieldName = "User Option Field", Start = 87, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1129", FieldName = "User Option Field", Start = 87, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1129", FieldName = "User Option Field", Start = 87, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 15, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("PAR-1129")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserOptionField { get; set; }

		/// <summary>
		/// PAR Record Status (PAR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-2000", FieldName = "PAR Record Status", Start = 107, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-2000", FieldName = "PAR Record Status", Start = 107, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-2000", FieldName = "PAR Record Status", Start = 107, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("ParRecordStatus", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PAR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ParRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ParRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PAR-1107)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-1107", FieldName = "Reserve", Start = 108, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-1107", FieldName = "Reserve", Start = 108, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-1107", FieldName = "Reserve", Start = 108, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReservePar1107", Order = 17, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("PAR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReservePar1107 { get; set; }

		/// <summary>
		/// Closing Character (PAR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "par", FieldCode = "PAR-9999", FieldName = "Closing Character", Start = 128, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "par", FieldCode = "PAR-9999", FieldName = "Closing Character", Start = 128, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "par", FieldCode = "PAR-9999", FieldName = "Closing Character", Start = 128, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 18, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PAR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Par, string>(version, p => p.JobId, returnValue);
			this.SegmentId = line.ParseForImport<Par, string>(version, p => p.SegmentId, returnValue);
			this.MailPieceUnitId = line.ParseForImport<Par, string>(version, p => p.MailPieceUnitId, returnValue);
			this.ComponentId = line.ParseForImport<Par, string>(version, p => p.ComponentId, returnValue);
			this.SequenceNumber = line.ParseForImport<Par, int>(version, p => p.SequenceNumber, returnValue);
			this.Date = line.ParseForImport<Par, DateOnly>(version, p => p.Date, returnValue);
			this.AdjustmentType = line.ParseForImport<Par, string>(version, p => p.AdjustmentType, returnValue);
			this.AdjustmentAmount = line.ParseForImport<Par, decimal>(version, p => p.AdjustmentAmount, returnValue);
			this.CreditDebitIndicator = line.ParseForImport<Par, string>(version, p => p.CreditDebitIndicator, returnValue);
			this.TotalPiecesAffected = line.ParseForImport<Par, int?>(version, p => p.TotalPiecesAffected, returnValue);
			this.UserComments = line.ParseForImport<Par, string>(version, p => p.UserComments, returnValue);
			this.AdjustmentStatus = line.ParseForImport<Par, string>(version, p => p.AdjustmentStatus, returnValue);
			this.MpaUniqueSequenceGroupingId = line.ParseForImport<Par, string>(version, p => p.MpaUniqueSequenceGroupingId, returnValue);
			this.UserOptionField = line.ParseForImport<Par, string>(version, p => p.UserOptionField, returnValue);
			this.ParRecordStatus = line.ParseForImport<Par, string>(version, p => p.ParRecordStatus, returnValue);
			this.ReservePar1107 = line.ParseForImport<Par, string>(version, p => p.ReservePar1107, returnValue);
			this.ClosingCharacter = line.ParseForImport<Par, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Par, string>(version, p => p.JobId));
			sb.Append(this.SegmentId.FormatForExport<Par, string>(version, p => p.SegmentId));
			sb.Append(this.MailPieceUnitId.FormatForExport<Par, string>(version, p => p.MailPieceUnitId));
			sb.Append(this.ComponentId.FormatForExport<Par, string>(version, p => p.ComponentId));
			sb.Append(this.SequenceNumber.FormatForExport<Par, int>(version, p => p.SequenceNumber));
			sb.Append(this.Date.FormatForExport<Par, DateOnly>(version, p => p.Date));
			sb.Append(this.AdjustmentType.FormatForExport<Par, string>(version, p => p.AdjustmentType));
			sb.Append(this.AdjustmentAmount.FormatForExport<Par, decimal>(version, p => p.AdjustmentAmount));
			sb.Append(this.CreditDebitIndicator.FormatForExport<Par, string>(version, p => p.CreditDebitIndicator));
			sb.Append(this.TotalPiecesAffected.FormatForExport<Par, int?>(version, p => p.TotalPiecesAffected));
			sb.Append(this.UserComments.FormatForExport<Par, string>(version, p => p.UserComments));
			sb.Append(this.AdjustmentStatus.FormatForExport<Par, string>(version, p => p.AdjustmentStatus));
			sb.Append(this.MpaUniqueSequenceGroupingId.FormatForExport<Par, string>(version, p => p.MpaUniqueSequenceGroupingId));
			sb.Append(this.UserOptionField.FormatForExport<Par, string>(version, p => p.UserOptionField));
			sb.Append(this.ParRecordStatus.FormatForExport<Par, string>(version, p => p.ParRecordStatus));
			sb.Append(this.ReservePar1107.FormatForExport<Par, string>(version, p => p.ReservePar1107));
			sb.Append(this.ClosingCharacter.FormatForExport<Par, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}