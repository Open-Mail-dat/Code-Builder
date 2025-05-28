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

namespace Mail.dat
{
	/// <summary>
	/// Descriptions of the mailer's permit and account information.
	/// </summary>
	public interface IMpa : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (MPA-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// MPA Unique Sequence/Grouping ID (MPA-1002)
		/// Unique identifier for the respective MPA within an MPU Establishes the set of MPU pieces on one
		/// Postage Statement.
		/// </summary>
		string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// MPA Description (MPA-1101)
		/// Describes the MPA.
		/// </summary>
		string MPADescription { get; set; }

		/// <summary>
		/// USPS Publication Number (MPA-1102)
		/// Left Justify, Numeric only, value in Postage Payment Method field Negates need for alpha in this
		/// field. (Note: In the event of a Periodicals Pending, the Publication Number field will be blank and
		/// the below Permit Number field will be used.) Should not be zero padded.
		/// </summary>
		string USPSPublicationNumber { get; set; }

		/// <summary>
		/// Permit Number (MPA-1103)
		/// Left Justified, In the event of a Periodicals Pending, the Publication Number field will be blank
		/// and this Permit Number field will be used. Should not be zero padded.
		/// </summary>
		string PermitNumber { get; set; }

		/// <summary>
		/// Permit ZIP+4 (MPA-1106)
		/// (ex: 543219876 or A1A1A1___) (International: left justify, blank pad: 54321----).
		/// </summary>
		string PermitZIP4 { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num (MPA-1107)
		/// Number used by local USPS for client identification. This field can be used to Let the Postal
		/// Service know what permit numbers are included in the mailing That the Mail.dat® file represents.
		/// This field is used for identifying what Permits are being used for the entire job in an MLOCR
		/// environment. Should Not be zero padded.
		/// </summary>
		string MailOwnerSLclPermitRefNumIntLBillNum { get; set; }

		/// <summary>
		/// Mail Owner's Lcl Permit Ref Num/Int'l Bill Num - Type (MPA-1108)
		/// </summary>
		string MailOwnerSLclPermitRefNumIntLBillNumType { get; set; }

		/// <summary>
		/// Postage Payment Option (MPA-1109)
		/// PostalOne! uses value of C = CPP. In this case to identify if Periodicals is used in the Centralized
		/// processing (delayed payment).
		/// </summary>
		string PostagePaymentOption { get; set; }

		/// <summary>
		/// Customer Reference ID (MPA-1110)
		/// Left justify, space added.
		/// </summary>
		string CustomerReferenceID { get; set; }

		/// <summary>
		/// Postage Payment Method (MPA-1111)
		/// </summary>
		string PostagePaymentMethod { get; set; }

		/// <summary>
		/// Federal Agency Cost Code (MPA-1114)
		/// This five-digit field may include leading zeros, is optional, and displays on the postage Statements
		/// for Official Mail (Government).
		/// </summary>
		string FederalAgencyCostCode { get; set; }

		/// <summary>
		/// Non-Profit Authorization Number (MPA-1115)
		/// </summary>
		string NonProfitAuthorizationNumber { get; set; }

		/// <summary>
		/// Title (MPA-1117)
		/// Publication Title.
		/// </summary>
		string Title { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (MPA-1121)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string MailerIDOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (MPA-1122)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string CRIDOfMailOwner { get; set; }

		/// <summary>
		/// Mailer ID of Preparer (MPA-1123)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string MailerIDOfPreparer { get; set; }

		/// <summary>
		/// CRID of Preparer (MPA-1124)
		/// USPS assigned ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string CRIDOfPreparer { get; set; }

		/// <summary>
		/// User Option Field (MPA-1126)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// Payment Account Number (MPA-1127)
		/// The Payment Account Number is used for Mail Anywhere and is different from the Permit Number and
		/// will be initially used in addition to the Permit Number. In the Future, this field may replace the
		/// Permit information. This field should not be zero Padded. This field is required for Mail Anywhere,
		/// otherwise it can be blank.
		/// </summary>
		string PaymentAccountNumber { get; set; }

		/// <summary>
		/// MPA Record Status (MPA-2000)
		/// </summary>
		string MPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (MPA-1116)
		/// </summary>
		string ReserveMPA1116 { get; set; }

		/// <summary>
		/// Closing Character (MPA-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}