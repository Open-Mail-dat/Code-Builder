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
	/// Provides the bulk form information that is present on the Certificate of Mailing Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cbr", File = "Certificate of Mailing Bulk Record", Summary = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.", Description = "Provides the bulk form information that is present on the Certificate of Mailing Forms.")]
	[Table("Cbr", Schema = "Maildat")]
	public partial class Cbr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (CBR-1001)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CBR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Bulk Record ID (CBR-1003)
		/// Unique ID of the Certificate of Mailing Bulk Record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1003", FieldName = "Bulk Record ID", Start = 17, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Bulk Record.", Type = "string", Format = "zfillnumeric")]
		[Column("BulkRecordID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string BulkRecordID { get; set; }

		/// <summary>
		/// Number of Identical Pieces (CBR-1101)
		/// Total identical pieces represented by this record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1101", FieldName = "Number of Identical Pieces", Start = 25, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total identical pieces represented by this record.", Type = "integer", Format = "zfill")]
		[Column("NumberOfIdenticalPieces", Order = 4)]
		[Required]
		public int NumberOfIdenticalPieces { get; set; }

		/// <summary>
		/// Class of Mail (CBR-1102)
		/// The Postal Class of pieces included in this record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1102", FieldName = "Class of Mail", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of pieces included in this record.", Type = "enum", Format = "leftjustify")]
		[Column("ClassOfMail", Order = 5)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "3", "4", "9")]
		public string ClassOfMail { get; set; }

		/// <summary>
		/// Number of Pieces to the Pound (CBR-1103)
		/// Number of pieces per pound.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1103", FieldName = "Number of Pieces to the Pound", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "Number of pieces per pound.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("NumberOfPiecesToThePound", Order = 6)]
		[Required]
		public decimal NumberOfPiecesToThePound { get; set; }

		/// <summary>
		/// Total Number of Pounds (CBR-1104)
		/// Pounds International = Gross Weight.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1104", FieldName = "Total Number of Pounds", Start = 42, Length = 12, Required = true, Key = false, DataType = "N", Description = "Pounds International = Gross Weight.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("TotalNumberOfPounds", Order = 7)]
		[Required]
		public decimal TotalNumberOfPounds { get; set; }

		/// <summary>
		/// Fee Paid (CBR-1105)
		/// Fee for Certificate of Bulk Mailing; dollars.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1105", FieldName = "Fee Paid", Start = 54, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Bulk Mailing; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("FeePaid", Order = 8)]
		public decimal FeePaid { get; set; }

		/// <summary>
		/// Total Postage Paid for Mailpieces (CBR-1106)
		/// Dollars.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1106", FieldName = "Total Postage Paid for Mailpieces", Start = 63, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("TotalPostagePaidForMailpieces", Order = 9)]
		[Required]
		public decimal TotalPostagePaidForMailpieces { get; set; }

		/// <summary>
		/// Flex Option A (CBR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1107", FieldName = "Flex Option A", Start = 72, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 10)]
		[MaxLength(2)]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CBR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1108", FieldName = "Flex Option B", Start = 74, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 11)]
		[MaxLength(2)]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CBR-1109)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1109", FieldName = "Flex Option C", Start = 76, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 12)]
		[MaxLength(2)]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CBR-1110)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1110", FieldName = "Reserve", Start = 78, Length = 20, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 13)]
		[MaxLength(20)]
		public string ReserveCBR1110 { get; set; }

		/// <summary>
		/// CBR Record Status (CBR-2000)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-2000", FieldName = "CBR Record Status", Start = 98, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CBRRecordStatus", Order = 14)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string CBRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CBR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-9999", FieldName = "Closing Character", Start = 99, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 15)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}