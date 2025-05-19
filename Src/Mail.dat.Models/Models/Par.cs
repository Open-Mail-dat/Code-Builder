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
	/// Notes technique and reports postage adjustment per container.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "par", File = "Postage Adjustment Record", Summary = "Technique and amount for adjustment per container.", Description = "Notes technique and reports postage adjustment per container.")]
	[Table("Par", Schema = "Maildat")]
	public partial class Par : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (PAR-1001)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (PAR-1002)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(4)]
		public string SegmentID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (PAR-1003)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(5)]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Component ID (PAR-1004)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "MCR-1004")]
		[Column("ComponentID", Order = 4)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string ComponentID { get; set; }

		/// <summary>
		/// Sequence Number (PAR-1024)
		/// A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1024", FieldName = "Sequence Number", Start = 26, Length = 3, Required = true, Key = true, DataType = "N", Description = "A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.", Type = "integer", Format = "zfill")]
		[Column("SequenceNumber", Order = 5)]
		[Required]
		[Key]
		public int SequenceNumber { get; set; }

		/// <summary>
		/// Date (PAR-1101)
		/// Adjustment Date.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1101", FieldName = "Date", Start = 29, Length = 8, Required = true, Key = false, DataType = "N", Description = "Adjustment Date.", Type = "date", Format = "YYYYMMDD")]
		[Column("Date", Order = 6)]
		[Required]
		public DateOnly Date { get; set; }

		/// <summary>
		/// Adjustment Type (PAR-1102)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1102", FieldName = "Adjustment Type", Start = 37, Length = 2, Required = true, Key = false, DataType = "N", Type = "enum", Format = "zfill")]
		[Column("AdjustmentType", Order = 7)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("01", "02", "03", "04")]
		public string AdjustmentType { get; set; }

		/// <summary>
		/// Adjustment Amount (PAR-1103)
		/// Dollars.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1103", FieldName = "Adjustment Amount", Start = 39, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("AdjustmentAmount", Order = 8)]
		[Required]
		public decimal AdjustmentAmount { get; set; }

		/// <summary>
		/// Credit/Debit Indicator (PAR-1104)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1104", FieldName = "Credit/Debit Indicator", Start = 48, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CreditDebitIndicator", Order = 9)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D")]
		public string CreditDebitIndicator { get; set; }

		/// <summary>
		/// Total Pieces Affected (PAR-1106)
		/// (0 [zero] is a permitted value).
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1106", FieldName = "Total Pieces Affected", Start = 49, Length = 8, Required = false, Key = false, DataType = "N", Description = "(0 [zero] is a permitted value).", Type = "integer", Format = "zfill")]
		[Column("TotalPiecesAffected", Order = 10)]
		public int TotalPiecesAffected { get; set; }

		/// <summary>
		/// User Comments (PAR-1105)
		/// Free form field for user notes.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1105", FieldName = "User Comments", Start = 57, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Free form field for user notes.", Type = "string", Format = "leftjustify")]
		[Column("UserComments", Order = 11)]
		[MaxLength(19)]
		public string UserComments { get; set; }

		/// <summary>
		/// Adjustment Status (PAR-1108)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1108", FieldName = "Adjustment Status", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("AdjustmentStatus", Order = 12)]
		[MaxLength(1)]
		[AllowedValues("C", "P", "R", "T", "X")]
		public string AdjustmentStatus { get; set; }

		/// <summary>
		/// MPA - Unique Sequence/Grouping ID (PAR-1109)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1109", FieldName = "MPA - Unique Sequence/Grouping ID", Start = 77, Length = 10, Required = true, Key = false, DataType = "A/N", Type = "string", Format = "zfillnumeric")]
		[Column("MPAUniqueSequenceGroupingID", Order = 13)]
		[Required]
		[MaxLength(10)]
		public string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// User Option Field (PAR-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1129", FieldName = "User Option Field", Start = 87, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 14)]
		[MaxLength(20)]
		public string UserOptionField { get; set; }

		/// <summary>
		/// PAR Record Status (PAR-2000)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-2000", FieldName = "PAR Record Status", Start = 107, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PARRecordStatus", Order = 15)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string PARRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PAR-1107)
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-1107", FieldName = "Reserve", Start = 108, Length = 20, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 16)]
		[MaxLength(20)]
		public string ReservePAR1107 { get; set; }

		/// <summary>
		/// Closing Character (PAR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "par", FieldCode = "PAR-9999", FieldName = "Closing Character", Start = 128, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 17)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}