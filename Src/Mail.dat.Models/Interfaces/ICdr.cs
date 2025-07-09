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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Is used to capture the Detail information that is present on the Certificate of Mail Forms. Provide
	/// the detailed information that is present on the Certificate of Mail Forms.
	/// </summary>
	public interface ICdr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CDR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CDR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// COM Piece ID (CDR-1003)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		string ComPieceId { get; set; }

		/// <summary>
		/// Firm Specific ID (CDR-1101)
		/// Submitter's unique ID of the record.
		/// </summary>
		string FirmSpecificId { get; set; }

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
		/// Set for Future Use - Unique ID of individual piece within a mailing.
		/// </summary>
		string PieceId { get; set; }

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
		string ReserveCdr1119 { get; set; }

		/// <summary>
		/// CDR Record Status (CDR-2000)
		/// O, D, I, U.
		/// </summary>
		string CdrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CDR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}