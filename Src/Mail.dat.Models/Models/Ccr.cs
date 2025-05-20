// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
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
	/// Allows mailers to identify surcharges, incentive and specific contents that are part of the mail
	/// piece.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "ccr", File = "Component Characteristics Record", Summary = "Characteristics of a component.", Description = "Allows mailers to identify surcharges, incentive and specific contents that are part of the mail piece.")]
	[Table("Ccr", Schema = "Maildat")]
	public partial class Ccr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (CCR-1001)
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Component ID (CCR-1004)
		/// Unique Record ID - foreign Key to CPT.
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique Record ID - foreign Key to CPT.", Type = "string", Format = "zfillnumeric", References = "CPT-1004")]
		[Column("ComponentID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string ComponentID { get; set; }

		/// <summary>
		/// Characteristic Type (CCR-1005)
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1005", FieldName = "Characteristic Type", Start = 17, Length = 1, Required = true, Key = true, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CharacteristicType", Order = 3)]
		[Required]
		[Key]
		[MaxLength(1)]
		[AllowedValues("A", "C", "F", "I")]
		public string CharacteristicType { get; set; }

		/// <summary>
		/// Characteristic (CCR-1002)
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1002", FieldName = "Characteristic", Start = 18, Length = 2, Required = true, Key = true, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("Characteristic", Order = 4)]
		[Required]
		[Key]
		[MaxLength(2)]
		[AllowedValues("0X", "1X", "2X", "3X", "4X", "5X", "6X", "7X", "8X", "9X", "CB", "CC", "CT", "DC", "EB", "EN", "FA", "FG", "IT", "IV", "MG", "MM", "NF", "NP", "P1", "P2", "P3", "P4", "P5", "PI", "PM", "PP", "RR", "RT", "SS", "ST")]
		public string Characteristic { get; set; }

		/// <summary>
		/// Pre-Denominated Maximum Credit Amount (CCR-1101)
		/// Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the
		/// postage amount. The postage amount representing the pieces associated with the component record.
		/// Should be used in conjunction with the CCR for Credit Redemption. If left blank, then do not apply
		/// any limit to the credit amount used.
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1101", FieldName = "Pre-Denominated Maximum Credit Amount", Start = 20, Length = 11, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the postage amount. The postage amount representing the pieces associated with the component record. Should be used in conjunction with the CCR for Credit Redemption. If left blank, then do not apply any limit to the credit amount used.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("PreDenominatedMaximumCreditAmount", Order = 5)]
		public decimal PreDenominatedMaximumCreditAmount { get; set; }

		/// <summary>
		/// Reserve (CCR-1102)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-1102", FieldName = "Reserve", Start = 31, Length = 20, Required = false, Key = false, Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 6)]
		[MaxLength(20)]
		public string ReserveCCR1102 { get; set; }

		/// <summary>
		/// CCR Record Status (CCR-2000)
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-2000", FieldName = "CCR Record Status", Start = 51, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CCRRecordStatus", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string CCRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CCR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "ccr", FieldCode = "CCR-9999", FieldName = "Closing Character", Start = 52, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 8)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}