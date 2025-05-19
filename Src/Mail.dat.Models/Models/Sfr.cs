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
	/// Records specific ancillary fees (linked to the .PDR or .PBC). To be only used for extra services.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "sfr", File = "Special Fees/Charges Record", Summary = "Special fees and charges (linked to .PDR).", Description = "Records specific ancillary fees (linked to the .PDR or .PBC). To be only used for extra services.")]
	[Table("Sfr", Schema = "Maildat")]
	public partial class Sfr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (SFR-1001)
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (SFR-1006)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1006", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 2)]
		[Required]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Piece ID (SFR-1018)
		/// Unique ID of individual piece within a mailing.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1018", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing.", Type = "enum", Format = "leftjustify")]
		[Column("PieceID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(22)]
		[AllowedValues("PBC", "PDR")]
		public string PieceID { get; set; }

		/// <summary>
		/// Service Type (SFR-1019)
		/// If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each
		/// Representing an Extra Service associated to the mailpiece.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1019", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each Representing an Extra Service associated to the mailpiece.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceType", Order = 4)]
		[Required]
		[Key]
		[MaxLength(2)]
		[AllowedValues("A", "B", "B2", "B3", "C", "C2", "CA", "CD", "D", "DP", "E", "E2", "EB", "F", "F2", "H", "HM", "HZ", "J", "J2", "K", "L", "L1", "L2", "L3", "L4", "L5", "L6", "NP", "PP", "PR", "SC", "U", "V", "X", "Y", "Z1", "Z2")]
		public string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (SFR-1121)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested:.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1121", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested:.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceAdditionalType", Order = 5)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z")]
		public string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (SFR-1101)
		/// 99999999v99; dollars/cents, rounded (decimal implied). The Value of the single piece noted when
		/// applying for the Special Service.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1101", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "99999999v99; dollars/cents, rounded (decimal implied). The Value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceStatedValue", Order = 6)]
		public decimal ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (SFR-1102)
		/// 99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents incurred in costs
		/// for the specific Piece for one or more fees or charges noted above.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1102", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents incurred in costs for the specific Piece for one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceFee", Order = 7)]
		public decimal ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (SFR-1103)
		/// Long Number unique for this set of services within the Job And Segment. Cannot mix services of two
		/// different IDs Within the same record.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1103", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job And Segment. Cannot mix services of two different IDs Within the same record.", Type = "string", Format = "zfillnumeric")]
		[Column("SpecialFeesChargesServicesID", Order = 8)]
		[Required]
		[MaxLength(22)]
		public string SpecialFeesChargesServicesID { get; set; }

		/// <summary>
		/// Amount Due (SFR-1120)
		/// 99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents to be collected
		/// for the COD service For specific piece upon delivery.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1120", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "99999v99; dollars/cents, rounded (decimal implied). Actual Postal dollars & cents to be collected for the COD service For specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AmountDue", Order = 9)]
		public decimal AmountDue { get; set; }

		/// <summary>
		/// SFR Record Status (SFR-2000)
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-2000", FieldName = "SFR Record Status", Start = 88, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SFRRecordStatus", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string SFRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SFR-1104)
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-1104", FieldName = "Reserve", Start = 89, Length = 4, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 11)]
		[MaxLength(4)]
		public string ReserveSFR1104 { get; set; }

		/// <summary>
		/// Closing Character (SFR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "sfr", FieldCode = "SFR-9999", FieldName = "Closing Character", Start = 93, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 12)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}