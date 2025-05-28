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
	/// Notes technique and reports postage adjustment per container.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "par", File = "Postage Adjustment Record", Summary = "Technique and amount for adjustment per container.", Description = "Notes technique and reports postage adjustment per container.", LineLength = 128, ClosingCharacter = "#")]
	[Table("Par", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 18)]
	public partial class Par : MaildatEntity, IPar 
	{
		/// <summary>
		/// Job ID (PAR-1001)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PAR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (PAR-1002)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("PAR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SegmentID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (PAR-1003)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("PAR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Component ID (PAR-1004)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[Column("ComponentID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PAR-1004")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ComponentID { get; set; }

		/// <summary>
		/// Sequence Number (PAR-1024)
		/// A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1024", FieldName = "Sequence Number", Start = 26, Length = 3, Required = true, Key = true, DataType = "N", Description = "A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.", Type = "integer", Format = "zfill")]
		[Column("SequenceNumber", Order = 6, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PAR-1024")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int SequenceNumber { get; set; }

		/// <summary>
		/// Date (PAR-1101)
		/// Adjustment Date.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1101", FieldName = "Date", Start = 29, Length = 8, Required = true, Key = false, DataType = "N", Description = "Adjustment Date.", Type = "date", Format = "YYYYMMDD")]
		[Column("Date", Order = 7, TypeName = "TEXT")]
		[Required]
		[Comment("PAR-1101")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly Date { get; set; }

		/// <summary>
		/// Adjustment Type (PAR-1102)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1102", FieldName = "Adjustment Type", Start = 37, Length = 2, Required = true, Key = false, DataType = "N", Description = "", Type = "enum", Format = "zfill")]
		[Column("AdjustmentType", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("01", "02", "03", "04")]
		[Comment("PAR-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string AdjustmentType { get; set; }

		/// <summary>
		/// Adjustment Amount (PAR-1103)
		/// Dollars.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1103", FieldName = "Adjustment Amount", Start = 39, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("AdjustmentAmount", Order = 9, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("PAR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal AdjustmentAmount { get; set; }

		/// <summary>
		/// Credit/Debit Indicator (PAR-1104)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1104", FieldName = "Credit/Debit Indicator", Start = 48, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CreditDebitIndicator", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D")]
		[Comment("PAR-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CreditDebitIndicator { get; set; }

		/// <summary>
		/// Total Pieces Affected (PAR-1106)
		/// (0 [zero] is a permitted value).
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1106", FieldName = "Total Pieces Affected", Start = 49, Length = 8, Required = false, Key = false, DataType = "N", Description = "(0 [zero] is a permitted value).", Type = "integer", Format = "zfill")]
		[Column("TotalPiecesAffected", Order = 11, TypeName = "INTEGER")]
		[Comment("PAR-1106")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? TotalPiecesAffected { get; set; }

		/// <summary>
		/// User Comments (PAR-1105)
		/// Free form field for user notes.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1105", FieldName = "User Comments", Start = 57, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Free form field for user notes.", Type = "string", Format = "leftjustify")]
		[Column("UserComments", Order = 12, TypeName = "TEXT")]
		[MaxLength(19)]
		[Comment("PAR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string UserComments { get; set; }

		/// <summary>
		/// Adjustment Status (PAR-1108)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1108", FieldName = "Adjustment Status", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("AdjustmentStatus", Order = 13, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "C", "P", "R", "T", "X")]
		[Comment("PAR-1108")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string AdjustmentStatus { get; set; }

		/// <summary>
		/// MPA - Unique Sequence/Grouping ID (PAR-1109)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1109", FieldName = "MPA - Unique Sequence/Grouping ID", Start = 77, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric")]
		[Column("MPAUniqueSequenceGroupingID", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("PAR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// User Option Field (PAR-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1129", FieldName = "User Option Field", Start = 87, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 15, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("PAR-1129")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string UserOptionField { get; set; }

		/// <summary>
		/// PAR Record Status (PAR-2000)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-2000", FieldName = "PAR Record Status", Start = 107, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PARRecordStatus", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PAR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PARRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PAR-1107)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1107", FieldName = "Reserve", Start = 108, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReservePAR1107", Order = 17, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("PAR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReservePAR1107 { get; set; }

		/// <summary>
		/// Closing Character (PAR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-9999", FieldName = "Closing Character", Start = 128, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 18, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PAR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Par, string>(p => p.JobID, returnValue);
			this.SegmentID = line.ParseForImport<Par, string>(p => p.SegmentID, returnValue);
			this.MailPieceUnitID = line.ParseForImport<Par, string>(p => p.MailPieceUnitID, returnValue);
			this.ComponentID = line.ParseForImport<Par, string>(p => p.ComponentID, returnValue);
			this.SequenceNumber = line.ParseForImport<Par, int>(p => p.SequenceNumber, returnValue);
			this.Date = line.ParseForImport<Par, DateOnly>(p => p.Date, returnValue);
			this.AdjustmentType = line.ParseForImport<Par, string>(p => p.AdjustmentType, returnValue);
			this.AdjustmentAmount = line.ParseForImport<Par, decimal>(p => p.AdjustmentAmount, returnValue);
			this.CreditDebitIndicator = line.ParseForImport<Par, string>(p => p.CreditDebitIndicator, returnValue);
			this.TotalPiecesAffected = line.ParseForImport<Par, int?>(p => p.TotalPiecesAffected, returnValue);
			this.UserComments = line.ParseForImport<Par, string>(p => p.UserComments, returnValue);
			this.AdjustmentStatus = line.ParseForImport<Par, string>(p => p.AdjustmentStatus, returnValue);
			this.MPAUniqueSequenceGroupingID = line.ParseForImport<Par, string>(p => p.MPAUniqueSequenceGroupingID, returnValue);
			this.UserOptionField = line.ParseForImport<Par, string>(p => p.UserOptionField, returnValue);
			this.PARRecordStatus = line.ParseForImport<Par, string>(p => p.PARRecordStatus, returnValue);
			this.ReservePAR1107 = line.ParseForImport<Par, string>(p => p.ReservePAR1107, returnValue);
			this.ClosingCharacter = line.ParseForImport<Par, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Par, string>(p => p.JobID));
			sb.Append(this.SegmentID.FormatForExport<Par, string>(p => p.SegmentID));
			sb.Append(this.MailPieceUnitID.FormatForExport<Par, string>(p => p.MailPieceUnitID));
			sb.Append(this.ComponentID.FormatForExport<Par, string>(p => p.ComponentID));
			sb.Append(this.SequenceNumber.FormatForExport<Par, int>(p => p.SequenceNumber));
			sb.Append(this.Date.FormatForExport<Par, DateOnly>(p => p.Date));
			sb.Append(this.AdjustmentType.FormatForExport<Par, string>(p => p.AdjustmentType));
			sb.Append(this.AdjustmentAmount.FormatForExport<Par, decimal>(p => p.AdjustmentAmount));
			sb.Append(this.CreditDebitIndicator.FormatForExport<Par, string>(p => p.CreditDebitIndicator));
			sb.Append(this.TotalPiecesAffected.FormatForExport<Par, int?>(p => p.TotalPiecesAffected));
			sb.Append(this.UserComments.FormatForExport<Par, string>(p => p.UserComments));
			sb.Append(this.AdjustmentStatus.FormatForExport<Par, string>(p => p.AdjustmentStatus));
			sb.Append(this.MPAUniqueSequenceGroupingID.FormatForExport<Par, string>(p => p.MPAUniqueSequenceGroupingID));
			sb.Append(this.UserOptionField.FormatForExport<Par, string>(p => p.UserOptionField));
			sb.Append(this.PARRecordStatus.FormatForExport<Par, string>(p => p.PARRecordStatus));
			sb.Append(this.ReservePAR1107.FormatForExport<Par, string>(p => p.ReservePAR1107));
			sb.Append(this.ClosingCharacter.FormatForExport<Par, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}