//
// Copyright (c) 2025 Open Mail.dat
//
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
//
// This code was auto-generated on June 14th, 2025.
// by the Open Mail.dat Code Generator.
//
// Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Special fees and charges (linked to .PDR). Records specific ancillary fees (linked to the .PDR or
	/// .PBC). To be only used for extra services.
	/// </summary>
	public interface ISfr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (SFR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (SFR-1006)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		int CqtDatabaseId { get; set; }

		/// <summary>
		/// Piece ID (SFR-1018)
		/// Unique ID of individual piece within a mailing.
		/// </summary>
		string PieceId { get; set; }

		/// <summary>
		/// Service Type (SFR-1019)
		/// If, applicable; Left Justify; Space Added Multiple records can be added per piece in PDR or PBC each
		/// representing an Extra Service associated to the mailpiece.
		/// </summary>
		string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (SFR-1121)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested:.
		/// </summary>
		string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (SFR-1101)
		/// Dollars/cents, rounded. The value of the single piece noted when applying for the Special Service.
		/// </summary>
		decimal? ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (SFR-1102)
		/// Dollars/cents, rounded. Actual Postal dollars & cents incurred in costs for the specific piece for
		/// one or more fees or charges noted above.
		/// </summary>
		decimal ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (SFR-1103)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		string SpecialFeesChargesServicesId { get; set; }

		/// <summary>
		/// Amount Due (SFR-1120)
		/// Dollars/cents, rounded. Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		decimal? AmountDue { get; set; }

		/// <summary>
		/// SFR Record Status (SFR-2000)
		/// </summary>
		string SfrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SFR-1104)
		/// Reserved for future use.
		/// </summary>
		string ReserveSfr1104 { get; set; }

		/// <summary>
		/// Closing Character (SFR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}