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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
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
	/// Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.
	/// Provides the bulk form information that is present on the Certificate of Mailing Forms.
	/// </summary>
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "cbr", File = "Certificate of Mailing Bulk Record", Summary = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.", Description = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms. Provides the bulk form information that is present on the Certificate of Mailing Forms.", LineLength = 99, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "cbr", File = "Certificate of Mailing Bulk Record", Summary = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.", Description = "Is used to capture the bulk form information that is present on the Certificate of Mailing Forms. Provides the bulk form information that is present on the Certificate of Mailing Forms.", LineLength = 99, ClosingCharacter = "#")]
	[MaildatImport(Order = 26, Version = "24-1")]
	[MaildatImport(Order = 26, Version = "25-1")]
	[Table("Cbr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("24-1", "25-1")]
	public partial class Cbr : MaildatEntity, ICbr 
	{
		/// <summary>
		/// Job ID (CBR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CBR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// Bulk Record ID (CBR-1003)
		/// Unique ID of the Certificate of Mailing Bulk Record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1003", FieldName = "Bulk Record ID", Start = 17, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Bulk.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1003", FieldName = "Bulk Record ID", Start = 17, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Bulk Record.", Type = "string", Format = "zfillnumeric")]
		[Column("BulkRecordId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CBR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string BulkRecordId { get; set; }

		/// <summary>
		/// Number of Identical Pieces (CBR-1101)
		/// Total identical pieces represented by this record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1101", FieldName = "Number of Identical Pieces", Start = 25, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total identical pieces represented by this record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1101", FieldName = "Number of Identical Pieces", Start = 25, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total identical pieces represented by this record.", Type = "integer", Format = "zfill")]
		[Column("NumberOfIdenticalPieces", Order = 5, TypeName = "INTEGER")]
		[Required]
		[Comment("CBR-1101")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("24-1", "25-1")]
		public int NumberOfIdenticalPieces { get; set; }

		/// <summary>
		/// Class of Mail (CBR-1102)
		/// The Postal Class of pieces included in this record.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1102", FieldName = "Class of Mail", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of pieces included in this record.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1102", FieldName = "Class of Mail", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The Postal Class of pieces included in this record.", Type = "enum", Format = "leftjustify")]
		[Column("ClassOfMail", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "3", "4", "9")]
		[Comment("CBR-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ClassOfMails))]
		[MaildatVersions("24-1", "25-1")]
		public string ClassOfMail { get; set; }

		/// <summary>
		/// Number of Pieces to the Pound (CBR-1103)
		/// Number of pieces per pound.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1103", FieldName = "Number of Pieces to the Pound", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "Number of pieces per pound.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1103", FieldName = "Number of Pieces to the Pound", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "Number of pieces per pound.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("NumberOfPiecesToThePound", Order = 7, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("CBR-1103")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal NumberOfPiecesToThePound { get; set; }

		/// <summary>
		/// Total Number of Pounds (CBR-1104)
		/// Pounds International = Gross Weight.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1104", FieldName = "Total Number of Pounds", Start = 42, Length = 12, Required = true, Key = false, DataType = "N", Description = "Pounds International = Gross Weight.", Type = "decimal", Format = "zfill", Precision = 4)]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1104", FieldName = "Total Number of Pounds", Start = 42, Length = 12, Required = true, Key = false, DataType = "N", Description = "Pounds International = Gross Weight.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("TotalNumberOfPounds", Order = 8, TypeName = "NUMERIC")]
		[Required]
		[Precision(4)]
		[Comment("CBR-1104")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal TotalNumberOfPounds { get; set; }

		/// <summary>
		/// Fee Paid (CBR-1105)
		/// Fee for Certificate of Bulk Mailing; dollars.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1105", FieldName = "Fee Paid", Start = 54, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Bulk Mailing; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1105", FieldName = "Fee Paid", Start = 54, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Bulk Mailing; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("FeePaid", Order = 9, TypeName = "NUMERIC")]
		[Precision(3)]
		[Comment("CBR-1105")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal? FeePaid { get; set; }

		/// <summary>
		/// Total Postage Paid for Mailpieces (CBR-1106)
		/// Dollars.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1106", FieldName = "Total Postage Paid for Mailpieces", Start = 63, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1106", FieldName = "Total Postage Paid for Mailpieces", Start = 63, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("TotalPostagePaidForMailpieces", Order = 10, TypeName = "NUMERIC")]
		[Required]
		[Precision(3)]
		[Comment("CBR-1106")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("24-1", "25-1")]
		public decimal TotalPostagePaidForMailpieces { get; set; }

		/// <summary>
		/// Flex Option A (CBR-1107)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1107", FieldName = "Flex Option A", Start = 72, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1107", FieldName = "Flex Option A", Start = 72, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 11, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CBR-1108)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1108", FieldName = "Flex Option B", Start = 74, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1108", FieldName = "Flex Option B", Start = 74, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 12, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CBR-1109)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1109", FieldName = "Flex Option C", Start = 76, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1109", FieldName = "Flex Option C", Start = 76, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 13, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CBR-1109")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CBR-1110)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-1110", FieldName = "Reserve", Start = 78, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-1110", FieldName = "Reserve", Start = 78, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCbr1110", Order = 14, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CBR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ReserveCbr1110 { get; set; }

		/// <summary>
		/// CBR Record Status (CBR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-2000", FieldName = "CBR Record Status", Start = 98, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-2000", FieldName = "CBR Record Status", Start = 98, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CbrRecordStatus", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CBR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CbrRecordStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CbrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CBR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "cbr", FieldCode = "CBR-9999", FieldName = "Closing Character", Start = 99, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cbr", FieldCode = "CBR-9999", FieldName = "Closing Character", Start = 99, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CBR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Cbr, string>(version, p => p.JobId, returnValue);
			this.CertificateOfMailingHeaderId = line.ParseForImport<Cbr, string>(version, p => p.CertificateOfMailingHeaderId, returnValue);
			this.BulkRecordId = line.ParseForImport<Cbr, string>(version, p => p.BulkRecordId, returnValue);
			this.NumberOfIdenticalPieces = line.ParseForImport<Cbr, int>(version, p => p.NumberOfIdenticalPieces, returnValue);
			this.ClassOfMail = line.ParseForImport<Cbr, string>(version, p => p.ClassOfMail, returnValue);
			this.NumberOfPiecesToThePound = line.ParseForImport<Cbr, decimal>(version, p => p.NumberOfPiecesToThePound, returnValue);
			this.TotalNumberOfPounds = line.ParseForImport<Cbr, decimal>(version, p => p.TotalNumberOfPounds, returnValue);
			this.FeePaid = line.ParseForImport<Cbr, decimal?>(version, p => p.FeePaid, returnValue);
			this.TotalPostagePaidForMailpieces = line.ParseForImport<Cbr, decimal>(version, p => p.TotalPostagePaidForMailpieces, returnValue);
			this.FlexOptionA = line.ParseForImport<Cbr, string>(version, p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.ParseForImport<Cbr, string>(version, p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.ParseForImport<Cbr, string>(version, p => p.FlexOptionC, returnValue);
			this.ReserveCbr1110 = line.ParseForImport<Cbr, string>(version, p => p.ReserveCbr1110, returnValue);
			this.CbrRecordStatus = line.ParseForImport<Cbr, string>(version, p => p.CbrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cbr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Cbr, string>(version, p => p.JobId));
			sb.Append(this.CertificateOfMailingHeaderId.FormatForExport<Cbr, string>(version, p => p.CertificateOfMailingHeaderId));
			sb.Append(this.BulkRecordId.FormatForExport<Cbr, string>(version, p => p.BulkRecordId));
			sb.Append(this.NumberOfIdenticalPieces.FormatForExport<Cbr, int>(version, p => p.NumberOfIdenticalPieces));
			sb.Append(this.ClassOfMail.FormatForExport<Cbr, string>(version, p => p.ClassOfMail));
			sb.Append(this.NumberOfPiecesToThePound.FormatForExport<Cbr, decimal>(version, p => p.NumberOfPiecesToThePound));
			sb.Append(this.TotalNumberOfPounds.FormatForExport<Cbr, decimal>(version, p => p.TotalNumberOfPounds));
			sb.Append(this.FeePaid.FormatForExport<Cbr, decimal?>(version, p => p.FeePaid));
			sb.Append(this.TotalPostagePaidForMailpieces.FormatForExport<Cbr, decimal>(version, p => p.TotalPostagePaidForMailpieces));
			sb.Append(this.FlexOptionA.FormatForExport<Cbr, string>(version, p => p.FlexOptionA));
			sb.Append(this.FlexOptionB.FormatForExport<Cbr, string>(version, p => p.FlexOptionB));
			sb.Append(this.FlexOptionC.FormatForExport<Cbr, string>(version, p => p.FlexOptionC));
			sb.Append(this.ReserveCbr1110.FormatForExport<Cbr, string>(version, p => p.ReserveCbr1110));
			sb.Append(this.CbrRecordStatus.FormatForExport<Cbr, string>(version, p => p.CbrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Cbr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}