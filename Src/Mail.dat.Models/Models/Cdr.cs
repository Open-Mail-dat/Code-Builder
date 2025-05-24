// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 23rd, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Mail.dat
{
	/// <summary>
	/// Provide the detailed information that is present on the Certificate of Mail Forms.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cdr", File = "Certificate of Mailing Detail Record", Summary = "Is used to capture the Detail information that is present on the Certificate of Mail Forms.", Description = "Provide the detailed information that is present on the Certificate of Mail Forms.", LineLength = 395, ClosingCharacter = "#")]
	[Table("Cdr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	public partial class Cdr : MaildatEntity
	{
		/// <summary>
		/// Job ID (CDR-1001)
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CDR-1001")]
		public string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CDR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1002", FieldName = "Certificate Of Mailing Header ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of the Certificate of Mailing Header Record.", Type = "string", Format = "zfillnumeric", References = "CHR-1002")]
		[Column("CertificateOfMailingHeaderID", Order = 3)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CDR-1002")]
		public string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// COM Piece ID (CDR-1003)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1003", FieldName = "COM Piece ID", Start = 17, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric")]
		[Column("COMPieceID", Order = 4)]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("CDR-1003")]
		public string COMPieceID { get; set; }

		/// <summary>
		/// Firm Specific ID (CDR-1101)
		/// Submitter's unique ID of the record.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1101", FieldName = "Firm Specific ID", Start = 39, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Submitter's unique ID of the record.", Type = "string", Format = "leftjustify")]
		[Column("FirmSpecificID", Order = 5)]
		[Required]
		[MaxLength(30)]
		[Comment("CDR-1101")]
		public string FirmSpecificID { get; set; }

		/// <summary>
		/// USPS Tracking Number (CDR-1102)
		/// To be used for IM™ barcode or IMpb barcode.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1102", FieldName = "USPS Tracking Number", Start = 69, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode or IMpb barcode.", Type = "string", Format = "leftjustify")]
		[Column("USPSTrackingNumber", Order = 6)]
		[MaxLength(34)]
		[Comment("CDR-1102")]
		public string USPSTrackingNumber { get; set; }

		/// <summary>
		/// Recipient Name (CDR-1103)
		/// Name of Recipient.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1103", FieldName = "Recipient Name", Start = 103, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Name of Recipient.", Type = "string", Format = "leftjustify")]
		[Column("RecipientName", Order = 7)]
		[Required]
		[MaxLength(50)]
		[Comment("CDR-1103")]
		public string RecipientName { get; set; }

		/// <summary>
		/// Secondary Address (CDR-1104)
		/// Secondary address of recipient.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1104", FieldName = "Secondary Address", Start = 153, Length = 50, Required = false, Key = false, DataType = "A/N", Description = "Secondary address of recipient.", Type = "string", Format = "leftjustify")]
		[Column("SecondaryAddress", Order = 8)]
		[MaxLength(50)]
		[Comment("CDR-1104")]
		public string SecondaryAddress { get; set; }

		/// <summary>
		/// Primary Address (CDR-1105)
		/// Primary address of recipient.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1105", FieldName = "Primary Address", Start = 203, Length = 50, Required = true, Key = false, DataType = "A/N", Description = "Primary address of recipient.", Type = "string", Format = "leftjustify")]
		[Column("PrimaryAddress", Order = 9)]
		[Required]
		[MaxLength(50)]
		[Comment("CDR-1105")]
		public string PrimaryAddress { get; set; }

		/// <summary>
		/// City (CDR-1106)
		/// City of recipient.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1106", FieldName = "City", Start = 253, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "City of recipient.", Type = "string", Format = "leftjustify")]
		[Column("City", Order = 10)]
		[Required]
		[MaxLength(30)]
		[Comment("CDR-1106")]
		public string City { get; set; }

		/// <summary>
		/// State (CDR-1107)
		/// State of recipient. Two-character state code, required for addresses in the United States.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1107", FieldName = "State", Start = 283, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "State of recipient. Two-character state code, required for addresses in the United States.", Type = "string", Format = "leftjustify")]
		[Column("State", Order = 11)]
		[Required]
		[MaxLength(2)]
		[Comment("CDR-1107")]
		public string State { get; set; }

		/// <summary>
		/// Postal Code (CDR-1108)
		/// ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit
		/// Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of
		/// the field blank.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1108", FieldName = "Postal Code", Start = 285, Length = 11, Required = true, Key = false, DataType = "A/N", Description = "ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of the field blank.", Type = "string", Format = "leftjustify")]
		[Column("PostalCode", Order = 12)]
		[Required]
		[MaxLength(11)]
		[Comment("CDR-1108")]
		public string PostalCode { get; set; }

		/// <summary>
		/// Province or State - International (CDR-1109)
		/// Province of recipient's address. State or Province Code or Name. Applicable for international
		/// addresses only.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1109", FieldName = "Province or State - International", Start = 296, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Province of recipient's address. State or Province Code or Name. Applicable for international addresses only.", Type = "string", Format = "leftjustify")]
		[Column("ProvinceOrStateInternational", Order = 13)]
		[MaxLength(20)]
		[Comment("CDR-1109")]
		public string ProvinceOrStateInternational { get; set; }

		/// <summary>
		/// Country Code (CDR-1110)
		/// Country Code of recipient's address.  When required populated with two-character ISO Country Code.
		/// Used for international addresses.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1110", FieldName = "Country Code", Start = 316, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Country Code of recipient's address.  When required populated with two-character ISO Country Code. Used for international addresses.", Type = "string", Format = "leftjustify")]
		[Column("CountryCode", Order = 14)]
		[MaxLength(2)]
		[Comment("CDR-1110")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Postage (CDR-1111)
		/// Dollars.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1111", FieldName = "Postage", Start = 318, Length = 9, Required = true, Key = false, DataType = "N", Description = "Dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("Postage", Order = 15)]
		[Required]
		[Precision(3)]
		[Comment("CDR-1111")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal Postage { get; set; }

		/// <summary>
		/// Fee (CDR-1112)
		/// Fee for Certificate of Mailing;  dollars.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1112", FieldName = "Fee", Start = 327, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Certificate of Mailing;  dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("Fee", Order = 16)]
		[Precision(3)]
		[Comment("CDR-1112")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal Fee { get; set; }

		/// <summary>
		/// PAL Fee Indicator (CDR-1113)
		/// (Weight is NOT over).
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1113", FieldName = "PAL Fee Indicator", Start = 336, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "(Weight is NOT over).", Type = "enum", Format = "leftjustify")]
		[Column("PALFeeIndicator", Order = 17)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E")]
		[Comment("CDR-1113")]
		public string PALFeeIndicator { get; set; }

		/// <summary>
		/// PAL Fee Amount (CDR-1114)
		/// Fee for Parcel Airlift; dollars.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1114", FieldName = "PAL Fee Amount", Start = 337, Length = 9, Required = false, Key = false, DataType = "N", Description = "Fee for Parcel Airlift; dollars.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("PALFeeAmount", Order = 18)]
		[Precision(3)]
		[Comment("CDR-1114")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal PALFeeAmount { get; set; }

		/// <summary>
		/// Piece ID (CDR-1115)
		/// Set for Future Use - Unique ID of individual piece within a mailing. One of the following two values
		/// can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID, zero fill prior to
		/// numeric, if numeric only.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1115", FieldName = "Piece ID", Start = 346, Length = 22, Required = false, Key = false, DataType = "A/N", Description = "Set for Future Use - Unique ID of individual piece within a mailing. One of the following two values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID, zero fill prior to numeric, if numeric only.", Type = "string", Format = "leftjustify", References = "PDR-1018,PBC-1002")]
		[Column("PieceID", Order = 19)]
		[MaxLength(22)]
		[Comment("CDR-1115")]
		public string PieceID { get; set; }

		/// <summary>
		/// Flex Option A (CDR-1116)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1116", FieldName = "Flex Option A", Start = 368, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 20)]
		[MaxLength(2)]
		[Comment("CDR-1116")]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CDR-1117)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1117", FieldName = "Flex Option B", Start = 370, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 21)]
		[MaxLength(2)]
		[Comment("CDR-1117")]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CDR-1118)
		/// Reserve Option.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1118", FieldName = "Flex Option C", Start = 372, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserve Option.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 22)]
		[MaxLength(2)]
		[Comment("CDR-1118")]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CDR-1119)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-1119", FieldName = "Reserve", Start = 374, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCDR1119", Order = 23)]
		[MaxLength(20)]
		[Comment("CDR-1119")]
		public string ReserveCDR1119 { get; set; }

		/// <summary>
		/// CDR Record Status (CDR-2000)
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-2000", FieldName = "CDR Record Status", Start = 394, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CDRRecordStatus", Order = 24)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CDR-2000")]
		public string CDRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cdr", FieldCode = "CDR-9999", FieldName = "Closing Character", Start = 395, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 25)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CDR-9999")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override ILoadError[] OnLoadData(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.FileLineNumber = fileLineNumber;
			this.JobID = line.Parse<Cdr, string>(p => p.JobID, returnValue);
			this.CertificateOfMailingHeaderID = line.Parse<Cdr, string>(p => p.CertificateOfMailingHeaderID, returnValue);
			this.COMPieceID = line.Parse<Cdr, string>(p => p.COMPieceID, returnValue);
			this.FirmSpecificID = line.Parse<Cdr, string>(p => p.FirmSpecificID, returnValue);
			this.USPSTrackingNumber = line.Parse<Cdr, string>(p => p.USPSTrackingNumber, returnValue);
			this.RecipientName = line.Parse<Cdr, string>(p => p.RecipientName, returnValue);
			this.SecondaryAddress = line.Parse<Cdr, string>(p => p.SecondaryAddress, returnValue);
			this.PrimaryAddress = line.Parse<Cdr, string>(p => p.PrimaryAddress, returnValue);
			this.City = line.Parse<Cdr, string>(p => p.City, returnValue);
			this.State = line.Parse<Cdr, string>(p => p.State, returnValue);
			this.PostalCode = line.Parse<Cdr, string>(p => p.PostalCode, returnValue);
			this.ProvinceOrStateInternational = line.Parse<Cdr, string>(p => p.ProvinceOrStateInternational, returnValue);
			this.CountryCode = line.Parse<Cdr, string>(p => p.CountryCode, returnValue);
			this.Postage = line.Parse<Cdr, decimal>(p => p.Postage, returnValue);
			this.Fee = line.Parse<Cdr, decimal>(p => p.Fee, returnValue);
			this.PALFeeIndicator = line.Parse<Cdr, string>(p => p.PALFeeIndicator, returnValue);
			this.PALFeeAmount = line.Parse<Cdr, decimal>(p => p.PALFeeAmount, returnValue);
			this.PieceID = line.Parse<Cdr, string>(p => p.PieceID, returnValue);
			this.FlexOptionA = line.Parse<Cdr, string>(p => p.FlexOptionA, returnValue);
			this.FlexOptionB = line.Parse<Cdr, string>(p => p.FlexOptionB, returnValue);
			this.FlexOptionC = line.Parse<Cdr, string>(p => p.FlexOptionC, returnValue);
			this.ReserveCDR1119 = line.Parse<Cdr, string>(p => p.ReserveCDR1119, returnValue);
			this.CDRRecordStatus = line.Parse<Cdr, string>(p => p.CDRRecordStatus, returnValue);
			this.ClosingCharacter = line.Parse<Cdr, string>(p => p.ClosingCharacter, returnValue);
			
			return returnValue.ToArray();
		}
	}
}