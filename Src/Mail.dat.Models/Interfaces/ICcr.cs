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
	/// Characteristics of a component. Allows mailers to identify surcharges, incentive and specific
	/// contents that are part of the mail piece.
	/// </summary>
	public interface ICcr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CCR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Component ID (CCR-1004)
		/// Unique Record ID - foreign Key to CPT.
		/// </summary>
		string ComponentId { get; set; }

		/// <summary>
		/// Characteristic Type (CCR-1005)
		/// </summary>
		string CharacteristicType { get; set; }

		/// <summary>
		/// Characteristic (CCR-1002)
		/// </summary>
		string Characteristic { get; set; }

		/// <summary>
		/// CCR Record Status (CCR-2000)
		/// </summary>
		string CcrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CCR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }

		/// <summary>
		/// Pre-Denominated Maximum Credit Amount (CCR-1101)
		/// Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the
		/// postage amount. The postage amount representing the pieces associated with the component record.
		/// Should be used in conjunction with the CCR for Credit Redemption. If the field is blank or zero
		/// filled, do not apply any limit to the credit amount used. Note: multiple components may be tied to
		/// one/same Permit in MPA record Note: if the need is to entirely remove the Credit Redemption, remove
		/// the CCR record claiming the Credit Redemption or populate the field with the minimum value
		/// (00000000001), as a zero filled will not limit the credit amount used.
		/// </summary>
		decimal? PreDenominatedMaximumCreditAmount { get; set; }

		/// <summary>
		/// Reserve (CCR-1102)
		/// Reserved for future use.
		/// </summary>
		string ReserveCcr1102 { get; set; }
	}
}