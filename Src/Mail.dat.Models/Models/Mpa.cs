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
	/// Descriptions of the mailer's permit and account information.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "mpa", File = "Mailer Postage Account Record", Summary = "Descriptions of the mailer's permit and account information.", Description = "Descriptions of the mailer's permit and account information.")]
	[Table("Mpa", Schema = "Maildat")]
	public partial class Mpa : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (MPA-1001)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// MPA Unique Sequence/Grouping ID (MPA-1002)
		/// Unique identifier for the respective MPA within an MPU Establishes the set of MPU pieces on one
		/// Postage Statement.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1002", FieldName = "MPA Unique Sequence/Grouping ID", Start = 9, Length = 10, Required = true, Key = true, DataType = "A/N", Description = "Unique identifier for the respective MPA within an MPU Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "leftjustify")]
		[Column("MPAUniqueSequenceGroupingID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(10)]
		public string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// MPA Description (MPA-1101)
		/// Describes the MPA.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1101", FieldName = "MPA Description", Start = 19, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Describes the MPA.", Type = "string", Format = "leftjustify")]
		[Column("MPADescription", Order = 3)]
		[MaxLength(30)]
		public string MPADescription { get; set; }

		/// <summary>
		/// USPS Publication Number (MPA-1102)
		/// Left Justify, Numeric only, value in Postage Payment Method field Negates need for alpha in this
		/// field. (Note: In the event of a Periodicals Pending, the Publication Number field will be blank and
		/// the below Permit Number field will be used.) Should not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1102", FieldName = "USPS Publication Number", Start = 49, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "Left Justify, Numeric only, value in Postage Payment Method field Negates need for alpha in this field. (Note: In the event of a Periodicals Pending, the Publication Number field will be blank and the below Permit Number field will be used.) Should not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("USPSPublicationNumber", Order = 4)]
		[MaxLength(9)]
		public string USPSPublicationNumber { get; set; }

		/// <summary>
		/// Permit Number (MPA-1103)
		/// Left Justified, In the event of a Periodicals Pending, the Publication Number field will be blank
		/// and this Permit Number field will be used. Should not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1103", FieldName = "Permit Number", Start = 58, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Left Justified, In the event of a Periodicals Pending, the Publication Number field will be blank and this Permit Number field will be used. Should not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("PermitNumber", Order = 5)]
		[MaxLength(8)]
		public string PermitNumber { get; set; }

		/// <summary>
		/// Permit ZIP+4 (MPA-1106)
		/// (ex: 543219876 or A1A1A1___) (International: left justify, blank pad: 54321----).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1106", FieldName = "Permit ZIP+4", Start = 66, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "(ex: 543219876 or A1A1A1___) (International: left justify, blank pad: 54321----).", Type = "string", Format = "leftjustify")]
		[Column("PermitZIP4", Order = 6)]
		[MaxLength(9)]
		public string PermitZIP4 { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num (MPA-1107)
		/// Number used by local USPS for client identification. This field can be used to Let the Postal
		/// Service know what permit numbers are included in the mailing That the Mail.dat® file represents.
		/// This field is used for identifying what Permits are being used for the entire job in an MLOCR
		/// environment. Should Not be zero padded.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1107", FieldName = "Mail Owner's Lcl Permit Ref Num/Int'l Bill Num", Start = 75, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Number used by local USPS for client identification. This field can be used to Let the Postal Service know what permit numbers are included in the mailing That the Mail.dat® file represents. This field is used for identifying what Permits are being used for the entire job in an MLOCR environment. Should Not be zero padded.", Type = "string", Format = "leftjustify")]
		[Column("MailOwnerSLclPermitRefNumIntLBillNum", Order = 7)]
		[MaxLength(8)]
		public string MailOwnerSLclPermitRefNumIntLBillNum { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num - Type (MPA-1108)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1108", FieldName = "Mail Owner's Lcl Permit Ref Num/Int'l Bill Num - Type", Start = 83, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailOwnerSLclPermitRefNumIntLBillNumType", Order = 8)]
		[MaxLength(1)]
		[AllowedValues("G", "H", "M", "P", "S", "V")]
		public string MailOwnerSLclPermitRefNumIntLBillNumType { get; set; }

		/// <summary>
		/// Postage Payment Option (MPA-1109)
		/// PostalOne! uses value of C = CPP. In this case to identify if Periodicals is used in the Centralized
		/// processing (delayed payment).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1109", FieldName = "Postage Payment Option", Start = 84, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "PostalOne! uses value of C = CPP. In this case to identify if Periodicals is used in the Centralized processing (delayed payment).", Type = "enum", Format = "leftjustify")]
		[Column("PostagePaymentOption", Order = 9)]
		[MaxLength(1)]
		[AllowedValues("B", "C", "D", "O", "T", "V")]
		public string PostagePaymentOption { get; set; }

		/// <summary>
		/// Customer Reference ID (MPA-1110)
		/// Left justify, space added.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1110", FieldName = "Customer Reference ID", Start = 85, Length = 40, Required = false, Key = false, DataType = "A/N", Description = "Left justify, space added.", Type = "string", Format = "leftjustify")]
		[Column("CustomerReferenceID", Order = 10)]
		[MaxLength(40)]
		public string CustomerReferenceID { get; set; }

		/// <summary>
		/// Postage Payment Method (MPA-1111)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1111", FieldName = "Postage Payment Method", Start = 125, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PostagePaymentMethod", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "C", "G", "H", "I", "L", "M", "P", "S", "T")]
		public string PostagePaymentMethod { get; set; }

		/// <summary>
		/// Federal Agency Cost Code (MPA-1114)
		/// This five-digit field may include leading zeros, is optional, and displays on the postage Statements
		/// for Official Mail (Government).
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1114", FieldName = "Federal Agency Cost Code", Start = 126, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "This five-digit field may include leading zeros, is optional, and displays on the postage Statements for Official Mail (Government).", Type = "string", Format = "leftjustify")]
		[Column("FederalAgencyCostCode", Order = 12)]
		[MaxLength(5)]
		public string FederalAgencyCostCode { get; set; }

		/// <summary>
		/// Non-Profit Authorization Number (MPA-1115)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1115", FieldName = "Non-Profit Authorization Number", Start = 131, Length = 10, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("NonProfitAuthorizationNumber", Order = 13)]
		[MaxLength(10)]
		public string NonProfitAuthorizationNumber { get; set; }

		/// <summary>
		/// Title (MPA-1117)
		/// Publication Title.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1117", FieldName = "Title", Start = 141, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Publication Title.", Type = "string", Format = "leftjustify")]
		[Column("Title", Order = 14)]
		[MaxLength(30)]
		public string Title { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (MPA-1121)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1121", FieldName = "Mailer ID of Mail Owner", Start = 171, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfMailOwner", Order = 15)]
		[MaxLength(9)]
		public string MailerIDOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (MPA-1122)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1122", FieldName = "CRID of Mail Owner", Start = 180, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRIDOfMailOwner", Order = 16)]
		[MaxLength(12)]
		public string CRIDOfMailOwner { get; set; }

		/// <summary>
		/// Mailer ID of Preparer (MPA-1123)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1123", FieldName = "Mailer ID of Preparer", Start = 192, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("MailerIDOfPreparer", Order = 17)]
		[MaxLength(9)]
		public string MailerIDOfPreparer { get; set; }

		/// <summary>
		/// CRID of Preparer (MPA-1124)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1124", FieldName = "CRID of Preparer", Start = 201, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRIDOfPreparer", Order = 18)]
		[MaxLength(12)]
		public string CRIDOfPreparer { get; set; }

		/// <summary>
		/// User Option Field (MPA-1126)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1126", FieldName = "User Option Field", Start = 213, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 19)]
		[MaxLength(20)]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Payment Account Number (MPA-1127)
		/// The Payment Account Number is used for Mail Anywhere and is different from the Permit Number and
		/// will be initially used in addition to the Permit Number. In the Future, this field may replace the
		/// Permit information. This field should not be zero Padded. This field is required for Mail Anywhere,
		/// otherwise it can be blank.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1127", FieldName = "Payment Account Number", Start = 233, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "The Payment Account Number is used for Mail Anywhere and is different from the Permit Number and will be initially used in addition to the Permit Number. In the Future, this field may replace the Permit information. This field should not be zero Padded. This field is required for Mail Anywhere, otherwise it can be blank.", Type = "string", Format = "leftjustify")]
		[Column("PaymentAccountNumber", Order = 20)]
		[MaxLength(20)]
		public string PaymentAccountNumber { get; set; }

		/// <summary>
		/// MPA Record Status (MPA-2000)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-2000", FieldName = "MPA Record Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MPARecordStatus", Order = 21)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string MPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (MPA-1116)
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-1116", FieldName = "Reserve", Start = 254, Length = 44, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 22)]
		[MaxLength(44)]
		public string ReserveMPA1116 { get; set; }

		/// <summary>
		/// Closing Character (MPA-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "mpa", FieldCode = "MPA-9999", FieldName = "Closing Character", Start = 298, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 23)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}