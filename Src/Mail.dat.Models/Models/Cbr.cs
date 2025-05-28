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
	/// Provides the bulk form information that is present on the Certificate of Mailing Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cbr", File = "Certificate of Mailing Bulk Record", Summary = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.", Description = "Provides the bulk form information that is present on the Certificate of Mailing Forms.", LineLength = 99, ClosingCharacter = "#")]
	[Table("Cbr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 26)]
	public partial class Cbr : MaildatEntity, ICbr 
	{
		/// <summary>
		/// Job ID (CBR-1001)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "type", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CBR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Bulk Record ID (CBR-1003)
		/// Unique ID of the Certificate of Mailing Bulk Record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1003", FieldName = "Bulk Record ID", Start = 17, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Bulk Record.", Type = "string", Format = "zfillnumeric")]
		[Column("BulkRecordID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string BulkRecordID { get; set; }

		/// <summary>
		/// Number of Identical Pieces (CBR-1101)
		/// Total identical pieces represented by this record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1101", FieldName = "Number of Identical Pieces", Start = 25, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total identical pieces represented by this record.", Type = "integer", Format = "zfill")]
		[Column("NumberOfIdenticalPieces", Order = 5, TypeName = "INTEGER")]
		[Required]
		[Comment("CBR-1101")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfIdenticalPieces { get; set; }

		/// <summary>
		/// Class of Mail (CBR-1102)
		/// The Postal Class of pieces included in this record.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1102", FieldName = "Class of Mail", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of pieces included in this record.", Type = "enum", Format = "leftjustify")]
		[Column("ClassOfMail", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "3", "4", "9")]
		[Comment("CBR-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ClassOfMail { get; set; }

		/// <summary>
		/// Number of Pieces to the Pound (CBR-1103)
		/// Number of pieces per pound.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1103", FieldName = "Number of Pieces to the Pound", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "Number of pieces per pound.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("NumberOfPiecesToThePound", Order = 7, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("CBR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal NumberOfPiecesToThePound { get; set; }

		/// <summary>
		/// Total Number of Pounds (CBR-1104)
		/// Pounds International = Gross Weight.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1104", FieldName = "Total Number of Pounds", Start = 42, Length = 12, Required = true, Key = false, DataType = "N", Description = "Pounds International = Gross Weight.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("TotalNumberOfPounds", Order = 8, TypeName = "NUMERIC")]
		[Required]
		[Precision(4)]
		[Comment("CBR-1104")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal TotalNumberOfPounds { get; set; }

		/// <summary>
		/// Fee Paid (CBR-1105)
		/// Fee for Certificate of Bulk Mailing; dollars.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1105", FieldName = "Fee Paid", Start = 54, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Bulk Mailing; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("FeePaid", Order = 9, TypeName = "NUMERIC")]
		[Precision(3)]
		[Comment("CBR-1105")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? FeePaid { get; set; }

		/// <summary>
		/// Total Postage Paid for Mailpieces (CBR-1106)
		/// Dollars.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1106", FieldName = "Total Postage Paid for Mailpieces", Start = 63, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("TotalPostagePaidForMailpieces", Order = 10, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("CBR-1106")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal TotalPostagePaidForMailpieces { get; set; }

		/// <summary>
		/// Flex Option A (CBR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1107", FieldName = "Flex Option A", Start = 72, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 11, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CBR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1108", FieldName = "Flex Option B", Start = 74, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 12, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CBR-1109)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1109", FieldName = "Flex Option C", Start = 76, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CBR-1110)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-1110", FieldName = "Reserve", Start = 78, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveCBR1110", Order = 14, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CBR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveCBR1110 { get; set; }

		/// <summary>
		/// CBR Record Status (CBR-2000)
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-2000", FieldName = "CBR Record Status", Start = 98, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CBRRecordStatus", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CBR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CBRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CBR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cbr", FieldCode = "CBR-9999", FieldName = "Closing Character", Start = 99, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CBR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Cbr, string>(p => p.JobID, returnValue);
			this.CertificateOfMailingHeaderID = line.ParseForImport<Cbr, string>(p => p.CertificateOfMailingHeaderID, returnValue);
			this.BulkRecordID = line.ParseForImport<Cbr, string>(p => p.BulkRecordID, returnValue);
			this.NumberOfIdenticalPieces = line.ParseForImport<Cbr, int>(p => p.NumberOfIdenticalPieces, returnValue);
			this.ClassOfMail = line.ParseForImport<Cbr, string>(p => p.ClassOfMail, returnValue);
			this.NumberOfPiecesToThePound = line.ParseForImport<Cbr, decimal>(p => p.NumberOfPiecesToThePound, returnValue);
			this.TotalNumberOfPounds = line.ParseForImport<Cbr, decimal>(p => p.TotalNumberOfPounds, returnValue);
			this.FeePaid = line.ParseForImport<Cbr, decimal?>(p => p.FeePaid, returnValue);
			this.TotalPostagePaidForMailpieces = line.ParseForImport<Cbr, decimal>(p => p.TotalPostagePaidForMailpieces, returnValue);
			this.FlexOptionA = line.ParseForImport<Cbr, string>(p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Cbr, string>(p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Cbr, string>(p => p.FlexOptionC, returnValue);
			this.ReserveCBR1110 = line.ParseForImport<Cbr, string>(p => p.ReserveCBR1110, returnValue);
			this.CBRRecordStatus = line.ParseForImport<Cbr, string>(p => p.CBRRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cbr, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Cbr, string>(p => p.JobID));
			sb.Append(this.CertificateOfMailingHeaderID.FormatForExport<Cbr, string>(p => p.CertificateOfMailingHeaderID));
			sb.Append(this.BulkRecordID.FormatForExport<Cbr, string>(p => p.BulkRecordID));
			sb.Append(this.NumberOfIdenticalPieces.FormatForExport<Cbr, int>(p => p.NumberOfIdenticalPieces));
			sb.Append(this.ClassOfMail.FormatForExport<Cbr, string>(p => p.ClassOfMail));
			sb.Append(this.NumberOfPiecesToThePound.FormatForExport<Cbr, decimal>(p => p.NumberOfPiecesToThePound));
			sb.Append(this.TotalNumberOfPounds.FormatForExport<Cbr, decimal>(p => p.TotalNumberOfPounds));
			sb.Append(this.FeePaid.FormatForExport<Cbr, decimal?>(p => p.FeePaid));
			sb.Append(this.TotalPostagePaidForMailpieces.FormatForExport<Cbr, decimal>(p => p.TotalPostagePaidForMailpieces));
			sb.Append(this.FlexOptionA.FormatForExport<Cbr, string>(p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Cbr, string>(p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Cbr, string>(p => p.FlexOptionC));
			sb.Append(this.ReserveCBR1110.FormatForExport<Cbr, string>(p => p.ReserveCBR1110));
			sb.Append(this.CBRRecordStatus.FormatForExport<Cbr, string>(p => p.CBRRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Cbr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}