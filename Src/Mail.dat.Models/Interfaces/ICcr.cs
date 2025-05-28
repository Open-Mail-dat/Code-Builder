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
	/// Allows mailers to identify surcharges, incentive and specific contents that are part of the mail
	/// piece.
	/// </summary>
	public interface ICcr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CCR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Component ID (CCR-1004)
		/// Unique Record ID - foreign Key to CPT.
		/// </summary>
		string ComponentID { get; set; }

		/// <summary>
		/// Characteristic Type (CCR-1005)
		/// </summary>
		string CharacteristicType { get; set; }

		/// <summary>
		/// Characteristic (CCR-1002)
		/// </summary>
		string Characteristic { get; set; }

		/// <summary>
		/// Pre-Denominated Maximum Credit Amount (CCR-1101)
		/// Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the
		/// postage amount. The postage amount representing the pieces associated with the component record.
		/// Should be used in conjunction with the CCR for Credit Redemption. If left blank, then do not apply
		/// any limit to the credit amount used.
		/// </summary>
		decimal? PreDenominatedMaximumCreditAmount { get; set; }

		/// <summary>
		/// Reserve (CCR-1102)
		/// Reserved for future use.
		/// </summary>
		string ReserveCCR1102 { get; set; }

		/// <summary>
		/// CCR Record Status (CCR-2000)
		/// </summary>
		string CCRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CCR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}