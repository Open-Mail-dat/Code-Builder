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
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Quantity/rates per 3 or 5 digit in each container.
	/// </summary>
	public interface ICqt : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CQT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (CQT-1034)
		/// Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must
		/// be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force
		/// new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their
		/// fields the same (except the CQT Database ID). It is also permitted to merge records when their
		/// fields are the same.
		/// </summary>
		int CqtDatabaseId { get; set; }

		/// <summary>
		/// Container ID (CQT-1006)
		/// </summary>
		int ContainerId { get; set; }

		/// <summary>
		/// 3 Digit / 5 Digit Container Division (CQT-1007)
		/// 3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit
		/// represents those pieces within the container to a single 3 or 5 Digit; not presuming this set of
		/// pieces to be all of those going to the destination of the container. For example: Carrier Route Sack
		/// is described in one 3 Digit or 5 Digit Container Quantity Record; however, likely multiple records
		/// required to describe a Residual tray. there is generally no finer Zone or Destination Entry
		/// discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A
		/// value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record
		/// represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5
		/// Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those
		/// cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify
		/// the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting
		/// needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see
		/// following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN =
		/// (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; generate additional 5 Digit
		/// records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C
		/// use 5 Digit Division). In the event that no postal code is available, then the following default
		/// 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US =
		/// USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code)
		/// International: Use ISO3166 (2 position alpha Country Code).
		/// </summary>
		string ThreeDigit5DigitContainerDivision { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (CQT-1003)
		/// This ID will be used by the computer controlled equipment at the mailing facility to manufacture the
		/// specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists
		/// within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique.
		/// Must have some value, even if single edition.
		/// </summary>
		string MailPieceUnitId { get; set; }

		/// <summary>
		/// Zone (CQT-1101)
		/// Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for
		/// more information.
		/// </summary>
		string Zone { get; set; }

		/// <summary>
		/// Destination Entry (CQT-1105)
		/// </summary>
		string DestinationEntry { get; set; }

		/// <summary>
		/// Rate Category (CQT-1008)
		/// </summary>
		string RateCategory { get; set; }

		/// <summary>
		/// Barcode Discount Or Surcharge Indicator (CQT-1009)
		/// For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard
		/// parcels that are not barcoded.
		/// </summary>
		string BarcodeDiscountOrSurchargeIndicator { get; set; }

		/// <summary>
		/// Periodicals: Sub/ Non-Sub/ Requester Indicator (CQT-1010)
		/// Applicable to Periodicals.
		/// </summary>
		string PeriodicalsSubNonSubRequesterIndicator { get; set; }

		/// <summary>
		/// Periodicals: Not County/In County (CQT-1011)
		/// Applicable to Periodicals.
		/// </summary>
		string PeriodicalsNotCountyInCounty { get; set; }

		/// <summary>
		/// Number of Copies (CQT-1102)
		/// Total copies within the specified 3 or 5 digit of this record within the specific container.
		/// </summary>
		int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CQT-1103)
		/// Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number
		/// of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).
		/// </summary>
		int NumberOfPieces { get; set; }

		/// <summary>
		/// Periodicals Co-Palletization Discount Indicator (CQT-1107)
		/// Value is set if new co-palletized piece; does not mean piece qualifies for rate.
		/// </summary>
		string PeriodicalsCoPalletizationDiscountIndicator { get; set; }

		/// <summary>
		/// Container Charge Allocation (CQT-1111)
		/// Proportion, rounded This field is to be used for denoting the proportion of cost of its container
		/// that it's carrying.
		/// </summary>
		decimal? ContainerChargeAllocation { get; set; }

		/// <summary>
		/// Service Level Indicator (CQT-1112)
		/// </summary>
		string ServiceLevelIndicator { get; set; }

		/// <summary>
		/// Simplified Address Indicator (CQT-1113)
		/// </summary>
		string SimplifiedAddressIndicator { get; set; }

		/// <summary>
		/// CQT Record Status (CQT-2000)
		/// O, D, I, U.
		/// </summary>
		string CqtRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CQT-1106)
		/// Reserved for future use.
		/// </summary>
		string ReserveCqt1106 { get; set; }

		/// <summary>
		/// Closing Character (CQT-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}