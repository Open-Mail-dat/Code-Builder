// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 29th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 

namespace Mail.dat
{
	/// <summary>
	/// Provide the detailed information that is present on the Certificate of Mail Forms.
	/// </summary>
	public interface ICdr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CDR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CDR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// COM Piece ID (CDR-1003)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		string COMPieceID { get; set; }

		/// <summary>
		/// Firm Specific ID (CDR-1101)
		/// Submitter's unique ID of the record.
		/// </summary>
		string FirmSpecificID { get; set; }

		/// <summary>
		/// USPS Tracking Number (CDR-1102)
		/// To be used for IM™ barcode or IMpb barcode.
		/// </summary>
		string USPSTrackingNumber { get; set; }

		/// <summary>
		/// Recipient Name (CDR-1103)
		/// Name of Recipient.
		/// </summary>
		string RecipientName { get; set; }

		/// <summary>
		/// Secondary Address (CDR-1104)
		/// Secondary address of recipient.
		/// </summary>
		string SecondaryAddress { get; set; }

		/// <summary>
		/// Primary Address (CDR-1105)
		/// Primary address of recipient.
		/// </summary>
		string PrimaryAddress { get; set; }

		/// <summary>
		/// City (CDR-1106)
		/// City of recipient.
		/// </summary>
		string City { get; set; }

		/// <summary>
		/// State (CDR-1107)
		/// State of recipient. Two-character state code, required for addresses in the United States.
		/// </summary>
		string State { get; set; }

		/// <summary>
		/// Postal Code (CDR-1108)
		/// ZIP Code or Postal Code of recipient; numeric values of the applicable 5-Digit, 9-Digit, or 11-Digit
		/// Barcode for the specific piece If specifying a 5-digit or 9-digit barcode,  then leave the rest of
		/// the field blank.
		/// </summary>
		string PostalCode { get; set; }

		/// <summary>
		/// Province or State - International (CDR-1109)
		/// Province of recipient's address. State or Province Code or Name. Applicable for international
		/// addresses only.
		/// </summary>
		string ProvinceOrStateInternational { get; set; }

		/// <summary>
		/// Country Code (CDR-1110)
		/// Country Code of recipient's address.  When required populated with two-character ISO Country Code.
		/// Used for international addresses.
		/// </summary>
		string CountryCode { get; set; }

		/// <summary>
		/// Postage (CDR-1111)
		/// Dollars.
		/// </summary>
		decimal Postage { get; set; }

		/// <summary>
		/// Fee (CDR-1112)
		/// Fee for Certificate of Mailing;  dollars.
		/// </summary>
		decimal? Fee { get; set; }

		/// <summary>
		/// PAL Fee Indicator (CDR-1113)
		/// (Weight is NOT over).
		/// </summary>
		string PALFeeIndicator { get; set; }

		/// <summary>
		/// PAL Fee Amount (CDR-1114)
		/// Fee for Parcel Airlift; dollars.
		/// </summary>
		decimal? PALFeeAmount { get; set; }

		/// <summary>
		/// Piece ID (CDR-1115)
		/// Set for Future Use - Unique ID of individual piece within a mailing. One of the following two values
		/// can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID, zero fill prior to
		/// numeric, if numeric only.
		/// </summary>
		string PieceID { get; set; }

		/// <summary>
		/// Flex Option A (CDR-1116)
		/// Reserve Option.
		/// </summary>
		string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CDR-1117)
		/// Reserve Option.
		/// </summary>
		string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CDR-1118)
		/// Reserve Option.
		/// </summary>
		string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CDR-1119)
		/// Reserved for future use.
		/// </summary>
		string ReserveCDR1119 { get; set; }

		/// <summary>
		/// CDR Record Status (CDR-2000)
		/// </summary>
		string CDRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CDR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}