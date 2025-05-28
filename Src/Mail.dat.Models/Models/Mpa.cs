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
	/// Descriptions of the mailer's permit and account information.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "mpa", File = "Mailer Postage Account Record", Summary = "Descriptions of the mailer's permit and account information.", Description = "Descriptions of the mailer's permit and account information.", LineLength = 298, ClosingCharacter = "#")]
	[Table("Mpa", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 5)]
	public partial class Mpa : MaildatEntity, IMpa 
	{
		/// <summary>
		/// Job ID (MPA-1001)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MPA-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// MPA Unique Sequence/Grouping ID (MPA-1002)
		/// Unique identifier for the respective MPA within an MPU Establishes the set of MPU pieces on one
		/// Postage Statement.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1002", FieldName = "MPA Unique Sequence/Grouping ID", Start = 9, Length = 10, Required = true, Key = true, DataType = "A/N", Description = "Unique identifier for the respective MPA within an MPU Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "leftjustify")]
		[Column("MPAUniqueSequenceGroupingID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(10)]
		[Comment("MPA-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// MPA Description (MPA-1101)
		/// Describes the MPA.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1101", FieldName = "MPA Description", Start = 19, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Describes the MPA.", Type = "string", Format = "leftjustify")]
		[Column("MPADescription", Order = 4, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("MPA-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MPADescription { get; set; }

		/// <summary>
		/// USPS Publication Number (MPA-1102)
		/// Left Justify, Numeric only, value in Postage Payment Method field Negates need for alpha in this
		/// field. (Note: In the event of a Periodicals Pending, the Publication Number field will be blank and
		/// the below Permit Number field will be used.) Should not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1102", FieldName = "USPS Publication Number", Start = 49, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "Left Justify, Numeric only, value in Postage Payment Method field Negates need for alpha in this field. (Note: In the event of a Periodicals Pending, the Publication Number field will be blank and the below Permit Number field will be used.) Should not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("USPSPublicationNumber", Order = 5, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("MPA-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string USPSPublicationNumber { get; set; }

		/// <summary>
		/// Permit Number (MPA-1103)
		/// Left Justified, In the event of a Periodicals Pending, the Publication Number field will be blank
		/// and this Permit Number field will be used. Should not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1103", FieldName = "Permit Number", Start = 58, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Left Justified, In the event of a Periodicals Pending, the Publication Number field will be blank and this Permit Number field will be used. Should not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("PermitNumber", Order = 6, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("MPA-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PermitNumber { get; set; }

		/// <summary>
		/// Permit ZIP+4 (MPA-1106)
		/// (ex: 543219876 or A1A1A1___) (International: left justify, blank pad: 54321----).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1106", FieldName = "Permit ZIP+4", Start = 66, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "(ex: 543219876 or A1A1A1___) (International: left justify, blank pad: 54321----).", Type = "string", Format = "leftjustify")]
		[Column("PermitZIP4", Order = 7, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("MPA-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PermitZIP4 { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num (MPA-1107)
		/// Number used by local USPS for client identification. This field can be used to Let the Postal
		/// Service know what permit numbers are included in the mailing That the Mail.dat® file represents.
		/// This field is used for identifying what Permits are being used for the entire job in an MLOCR
		/// environment. Should Not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1107", FieldName = "Mail Owner's Lcl Permit Ref Num/Int'l Bill Num", Start = 75, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Number used by local USPS for client identification. This field can be used to Let the Postal Service know what permit numbers are included in the mailing That the Mail.dat® file represents. This field is used for identifying what Permits are being used for the entire job in an MLOCR environment. Should Not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerSLclPermitRefNumIntLBillNum", Order = 8, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("MPA-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailOwnerSLclPermitRefNumIntLBillNum { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num - Type (MPA-1108)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1108", FieldName = "Mail Owner's Lcl Permit Ref Num/Int'l Bill Num - Type", Start = 83, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MailOwnerSLclPermitRefNumIntLBillNumType", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("G", "H", "M", "P", "S", "V")]
		[Comment("MPA-1108")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MailOwnerSLclPermitRefNumIntLBillNumType { get; set; }

		/// <summary>
		/// Postage Payment Option (MPA-1109)
		/// PostalOne! uses value of C = CPP. In this case to identify if Periodicals is used in the Centralized
		/// processing (delayed payment).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1109", FieldName = "Postage Payment Option", Start = 84, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "PostalOne! uses value of C = CPP. In this case to identify if Periodicals is used in the Centralized processing (delayed payment).", Type = "enum", Format = "leftjustify")]
		[Column("PostagePaymentOption", Order = 10, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("B", "C", "D", "O", "T", "V")]
		[Comment("MPA-1109")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PostagePaymentOption { get; set; }

		/// <summary>
		/// Customer Reference ID (MPA-1110)
		/// Left justify, space added.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1110", FieldName = "Customer Reference ID", Start = 85, Length = 40, Required = false, Key = false, DataType = "A/N", Description = "Left justify, space added.", Type = "string", Format = "leftjustify")]
		[Column("CustomerReferenceID", Order = 11, TypeName = "TEXT")]
		[MaxLength(40)]
		[Comment("MPA-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CustomerReferenceID { get; set; }

		/// <summary>
		/// Postage Payment Method (MPA-1111)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1111", FieldName = "Postage Payment Method", Start = 125, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PostagePaymentMethod", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "C", "G", "H", "I", "L", "M", "P", "S", "T")]
		[Comment("MPA-1111")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PostagePaymentMethod { get; set; }

		/// <summary>
		/// Federal Agency Cost Code (MPA-1114)
		/// This five-digit field may include leading zeros, is optional, and displays on the postage Statements
		/// for Official Mail (Government).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1114", FieldName = "Federal Agency Cost Code", Start = 126, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "This five-digit field may include leading zeros, is optional, and displays on the postage Statements for Official Mail (Government).", Type = "string", Format = "leftjustify")]
		[Column("FederalAgencyCostCode", Order = 13, TypeName = "TEXT")]
		[MaxLength(5)]
		[Comment("MPA-1114")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FederalAgencyCostCode { get; set; }

		/// <summary>
		/// Non-Profit Authorization Number (MPA-1115)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1115", FieldName = "Non-Profit Authorization Number", Start = 131, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("NonProfitAuthorizationNumber", Order = 14, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("MPA-1115")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string NonProfitAuthorizationNumber { get; set; }

		/// <summary>
		/// Title (MPA-1117)
		/// Publication Title.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1117", FieldName = "Title", Start = 141, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Publication Title.", Type = "string", Format = "leftjustify")]
		[Column("Title", Order = 15, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("MPA-1117")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string Title { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (MPA-1121)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1121", FieldName = "Mailer ID of Mail Owner", Start = 171, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfMailOwner", Order = 16, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("MPA-1121")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailerIDOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (MPA-1122)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1122", FieldName = "CRID of Mail Owner", Start = 180, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRIDOfMailOwner", Order = 17, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("MPA-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CRIDOfMailOwner { get; set; }

		/// <summary>
		/// Mailer ID of Preparer (MPA-1123)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1123", FieldName = "Mailer ID of Preparer", Start = 192, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfPreparer", Order = 18, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("MPA-1123")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailerIDOfPreparer { get; set; }

		/// <summary>
		/// CRID of Preparer (MPA-1124)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1124", FieldName = "CRID of Preparer", Start = 201, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRIDOfPreparer", Order = 19, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("MPA-1124")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CRIDOfPreparer { get; set; }

		/// <summary>
		/// User Option Field (MPA-1126)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1126", FieldName = "User Option Field", Start = 213, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 20, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("MPA-1126")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Payment Account Number (MPA-1127)
		/// The Payment Account Number is used for Mail Anywhere and is different from the Permit Number and
		/// will be initially used in addition to the Permit Number. In the Future, this field may replace the
		/// Permit information. This field should not be zero Padded. This field is required for Mail Anywhere,
		/// otherwise it can be blank.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1127", FieldName = "Payment Account Number", Start = 233, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "The Payment Account Number is used for Mail Anywhere and is different from the Permit Number and will be initially used in addition to the Permit Number. In the Future, this field may replace the Permit information. This field should not be zero Padded. This field is required for Mail Anywhere, otherwise it can be blank.", Type = "string", Format = "leftjustify")]
		[Column("PaymentAccountNumber", Order = 21, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("MPA-1127")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PaymentAccountNumber { get; set; }

		/// <summary>
		/// MPA Record Status (MPA-2000)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-2000", FieldName = "MPA Record Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MPARecordStatus", Order = 22, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("MPA-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (MPA-1116)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1116", FieldName = "Reserve", Start = 254, Length = 44, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveMPA1116", Order = 23, TypeName = "TEXT")]
		[MaxLength(44)]
		[Comment("MPA-1116")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveMPA1116 { get; set; }

		/// <summary>
		/// Closing Character (MPA-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-9999", FieldName = "Closing Character", Start = 298, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 24, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("MPA-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Mpa, string>(p => p.JobID, returnValue);
			this.MPAUniqueSequenceGroupingID = line.ParseForImport<Mpa, string>(p => p.MPAUniqueSequenceGroupingID, returnValue);
			this.MPADescription = line.ParseForImport<Mpa, string>(p => p.MPADescription, returnValue);
			this.USPSPublicationNumber = line.ParseForImport<Mpa, string>(p => p.USPSPublicationNumber, returnValue);
			this.PermitNumber = line.ParseForImport<Mpa, string>(p => p.PermitNumber, returnValue);
			this.PermitZIP4 = line.ParseForImport<Mpa, string>(p => p.PermitZIP4, returnValue);
			this.MailOwnerSLclPermitRefNumIntLBillNum = line.ParseForImport<Mpa, string>(p => p.MailOwnerSLclPermitRefNumIntLBillNum, returnValue);
			this.MailOwnerSLclPermitRefNumIntLBillNumType = line.ParseForImport<Mpa, string>(p => p.MailOwnerSLclPermitRefNumIntLBillNumType, returnValue);
			this.PostagePaymentOption = line.ParseForImport<Mpa, string>(p => p.PostagePaymentOption, returnValue);
			this.CustomerReferenceID = line.ParseForImport<Mpa, string>(p => p.CustomerReferenceID, returnValue);
			this.PostagePaymentMethod = line.ParseForImport<Mpa, string>(p => p.PostagePaymentMethod, returnValue);
			this.FederalAgencyCostCode = line.ParseForImport<Mpa, string>(p => p.FederalAgencyCostCode, returnValue);
			this.NonProfitAuthorizationNumber = line.ParseForImport<Mpa, string>(p => p.NonProfitAuthorizationNumber, returnValue);
			this.Title = line.ParseForImport<Mpa, string>(p => p.Title, returnValue);
			this.MailerIDOfMailOwner = line.ParseForImport<Mpa, string>(p => p.MailerIDOfMailOwner, returnValue);
			this.CRIDOfMailOwner = line.ParseForImport<Mpa, string>(p => p.CRIDOfMailOwner, returnValue);
			this.MailerIDOfPreparer = line.ParseForImport<Mpa, string>(p => p.MailerIDOfPreparer, returnValue);
			this.CRIDOfPreparer = line.ParseForImport<Mpa, string>(p => p.CRIDOfPreparer, returnValue);
			this.UserOptionField = line.ParseForImport<Mpa, string>(p => p.UserOptionField, returnValue);
			this.PaymentAccountNumber = line.ParseForImport<Mpa, string>(p => p.PaymentAccountNumber, returnValue);
			this.MPARecordStatus = line.ParseForImport<Mpa, string>(p => p.MPARecordStatus, returnValue);
			this.ReserveMPA1116 = line.ParseForImport<Mpa, string>(p => p.ReserveMPA1116, returnValue);
			this.ClosingCharacter = line.ParseForImport<Mpa, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Mpa, string>(p => p.JobID));
			sb.Append(this.MPAUniqueSequenceGroupingID.FormatForExport<Mpa, string>(p => p.MPAUniqueSequenceGroupingID));
			sb.Append(this.MPADescription.FormatForExport<Mpa, string>(p => p.MPADescription));
			sb.Append(this.USPSPublicationNumber.FormatForExport<Mpa, string>(p => p.USPSPublicationNumber));
			sb.Append(this.PermitNumber.FormatForExport<Mpa, string>(p => p.PermitNumber));
			sb.Append(this.PermitZIP4.FormatForExport<Mpa, string>(p => p.PermitZIP4));
			sb.Append(this.MailOwnerSLclPermitRefNumIntLBillNum.FormatForExport<Mpa, string>(p => p.MailOwnerSLclPermitRefNumIntLBillNum));
			sb.Append(this.MailOwnerSLclPermitRefNumIntLBillNumType.FormatForExport<Mpa, string>(p => p.MailOwnerSLclPermitRefNumIntLBillNumType));
			sb.Append(this.PostagePaymentOption.FormatForExport<Mpa, string>(p => p.PostagePaymentOption));
			sb.Append(this.CustomerReferenceID.FormatForExport<Mpa, string>(p => p.CustomerReferenceID));
			sb.Append(this.PostagePaymentMethod.FormatForExport<Mpa, string>(p => p.PostagePaymentMethod));
			sb.Append(this.FederalAgencyCostCode.FormatForExport<Mpa, string>(p => p.FederalAgencyCostCode));
			sb.Append(this.NonProfitAuthorizationNumber.FormatForExport<Mpa, string>(p => p.NonProfitAuthorizationNumber));
			sb.Append(this.Title.FormatForExport<Mpa, string>(p => p.Title));
			sb.Append(this.MailerIDOfMailOwner.FormatForExport<Mpa, string>(p => p.MailerIDOfMailOwner));
			sb.Append(this.CRIDOfMailOwner.FormatForExport<Mpa, string>(p => p.CRIDOfMailOwner));
			sb.Append(this.MailerIDOfPreparer.FormatForExport<Mpa, string>(p => p.MailerIDOfPreparer));
			sb.Append(this.CRIDOfPreparer.FormatForExport<Mpa, string>(p => p.CRIDOfPreparer));
			sb.Append(this.UserOptionField.FormatForExport<Mpa, string>(p => p.UserOptionField));
			sb.Append(this.PaymentAccountNumber.FormatForExport<Mpa, string>(p => p.PaymentAccountNumber));
			sb.Append(this.MPARecordStatus.FormatForExport<Mpa, string>(p => p.MPARecordStatus));
			sb.Append(this.ReserveMPA1116.FormatForExport<Mpa, string>(p => p.ReserveMPA1116));
			sb.Append(this.ClosingCharacter.FormatForExport<Mpa, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}