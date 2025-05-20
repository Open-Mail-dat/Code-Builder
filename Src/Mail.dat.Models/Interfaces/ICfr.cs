// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using Diamond.Core.Repository;

namespace Mail.dat
{
	/// <summary>
	/// Provides the fee information that is present on the Certificate of Mail Forms.
	/// </summary>
	public interface ICfr : IEntity<int>
	{
		/// <summary>
		/// Job ID (CFR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CFR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Piece ID (CFR-1003)
		/// Unique ID of individual piece within mailing. Only linked to COM Detail Record. In the future this
		/// record may be replaced by SFR.
		/// </summary>
		string PieceID { get; set; }

		/// <summary>
		/// Service Type (CFR-1004)
		/// If, applicable *The dimension is under consideration and range to be defined in USPS documentation.
		/// </summary>
		string ServiceType { get; set; }

		/// <summary>
		/// Service Additional Type (CFR-1101)
		/// Populate for USPS Tracking Plus to represent the length the retention is requested: B,E, I - Z =
		/// Reserve.
		/// </summary>
		string ServiceAdditionalType { get; set; }

		/// <summary>
		/// Service Stated Value (CFR-1102)
		/// Dollars/cents, rounded The value of the single piece noted when applying for the Special Service.
		/// </summary>
		decimal ServiceStatedValue { get; set; }

		/// <summary>
		/// Service Fee (CFR-1103)
		/// Dollars/cents, rounded Actual Postal dollars & cents incurred in costs for the specific piece for
		/// the one or more fees or charges noted above.
		/// </summary>
		decimal ServiceFee { get; set; }

		/// <summary>
		/// Special Fees/Charges Services ID (CFR-1104)
		/// Long Number unique for this set of services within the Job and Segment. Cannot mix services of two
		/// different IDs within the same record.
		/// </summary>
		string SpecialFeesChargesServicesID { get; set; }

		/// <summary>
		/// Amount Due (CFR-1105)
		/// Dollars/cents, rounded Actual Postal dollars & cents to be collected for the COD service for
		/// specific piece upon delivery.
		/// </summary>
		decimal AmountDue { get; set; }

		/// <summary>
		/// Flex Option A (CFR-1106)
		/// Reserve Option.
		/// </summary>
		string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CFR-1107)
		/// Reserve Option.
		/// </summary>
		string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CFR-1108)
		/// Reserve Option.
		/// </summary>
		string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CFR-1109)
		/// </summary>
		string ReserveCFR1109 { get; set; }

		/// <summary>
		/// CFR Record Status (CFR-2000)
		/// </summary>
		string CFRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CFR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}