// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Provides the fee information that is present on the Certificate of Mail Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cfr", File = "Certification of Mailing Services Fee Record", Summary = "Is used to capture the service fee information.", Description = "Provides the fee information that is present on the Certificate of Mail Forms.")]
	[Table("Cfr", Schema = "Maildat")]
	public partial class Cfr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (CFR-1001)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CFR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Piece ID (CFR-1003)
		/// Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this
		/// record may be replaced by SFR.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1003", FieldName = "Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this record may be replaced by SFR.", Type = "string", Format = "zfillnumeric", References = "CDR-1003")]
		[Column("PieceID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(22)]
		public string PieceID { get; set; }

		/// <summary>
		/// Service Type (CFR-1004)
		/// If, applicable *The dimension is under consideration and range to be defined in USPS documentation.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1004", FieldName = "Service Type", Start = 39, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "If, applicable *The dimension is under consideration and range to be defined in USPS documentation.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceType", Order = 4)]
		[Required]
		[Key]
		[MaxLength(2)]
		[AllowedValues("A", "B", "B2", "B3", "C", "C2", "CA", "CD", "D", "DP", "E", "E2", "EB", "F", "F2", "H", "HM", "HZ", "J", "J2", "K", "L", "L1", "L2", "L3", "L4", "PP", "PR", "SC", "U", "V", "X", "Y", "Z1", "Z2")]
		public string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (CFR-1101)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z =
		/// Reserve.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1101", FieldName = "Service Additional Type", Start = 41, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z = Reserve.", Type = "enum", Format = "leftjustify")]
		[Column("ServiceAdditionalType", Order = 5)]
		[MaxLength(1)]
		[AllowedValues("A", "C", "D", "F", "G", "H")]
		public string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (CFR-1102)
		/// Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1102", FieldName = "Service Stated Value", Start = 42, Length = 10, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceStatedValue", Order = 6)]
		public decimal ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (CFR-1103)
		/// Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for
		/// the one or more fees or charges noted above.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1103", FieldName = "Service Fee", Start = 52, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for the one or more fees or charges noted above.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("ServiceFee", Order = 7)]
		public decimal ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (CFR-1104)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1104", FieldName = "Special Fees/Charges Services ID", Start = 59, Length = 22, Required = true, Key = false, DataType = "A/N", Description = "Long Number unique for this set of services within the Job and Segment. Cannot mix services of two different IDs within the same record.", Type = "string", Format = "zfillnumeric")]
		[Column("SpecialFeesChargesServicesID", Order = 8)]
		[Required]
		[MaxLength(22)]
		public string SpecialFeesChargesServicesID { get; set; }

		/// <summary>
		/// Amount Due (CFR-1105)
		/// Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1105", FieldName = "Amount Due", Start = 81, Length = 7, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for specific piece upon delivery.", Type = "decimal", Format = "zfill", Precision = 2)]
		[Column("AmountDue", Order = 9)]
		public decimal AmountDue { get; set; }

		/// <summary>
		/// Flex Option A (CFR-1106)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1106", FieldName = "Flex Option A", Start = 88, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 10)]
		[MaxLength(2)]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CFR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1107", FieldName = "Flex Option B", Start = 90, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 11)]
		[MaxLength(2)]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CFR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1108", FieldName = "Flex Option C", Start = 92, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 12)]
		[MaxLength(2)]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CFR-1109)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-1109", FieldName = "Reserve", Start = 94, Length = 20, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 13)]
		[MaxLength(20)]
		public string ReserveCFR1109 { get; set; }

		/// <summary>
		/// CFR Record Status (CFR-2000)
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-2000", FieldName = "CFR Record Status", Start = 114, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CFRRecordStatus", Order = 14)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string CFRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CFR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cfr", FieldCode = "CFR-9999", FieldName = "Closing Character", Start = 115, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 15)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}