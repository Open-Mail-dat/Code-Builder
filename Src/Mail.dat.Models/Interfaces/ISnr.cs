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
	/// Identifies package/container of seed names within the presort.
	/// </summary>
	public interface ISnr : IEntity<int>
	{
		/// <summary>
		/// Job ID (SNR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Container ID (SNR-1006)
		/// </summary>
		int ContainerID { get; set; }

		/// <summary>
		/// Package ID (SNR-1012)
		/// The unique code for this package within this container.
		/// </summary>
		string PackageID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (SNR-1003)
		/// </summary>
		string MailPieceUnitID { get; set; }

		/// <summary>
		/// Seed Name ID (SNR-1016)
		/// Since this file is only necessary to be used in the event that a list of specific and documented
		/// names for a tracking program, then this field is populated with the supplied ID for each specific
		/// name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be
		/// tracked. General seed lists (example: all managers at the catalog) will not require feedback of this
		/// nature from the list house.
		/// </summary>
		string SeedNameID { get; set; }

		/// <summary>
		/// Version Key Code (SNR-1017)
		/// Derived from original seed information. As with the Seed Name ID, this information is derived from
		/// the supplied name/address/record data.
		/// </summary>
		string VersionKeyCode { get; set; }

		/// <summary>
		/// Seed Name Received Date (SNR-1101)
		/// The date the seed agent received the mail piece.
		/// </summary>
		DateOnly SeedNameReceivedDate { get; set; }

		/// <summary>
		/// Seed Type (SNR-1104)
		/// </summary>
		string SeedType { get; set; }

		/// <summary>
		/// Piece Barcode (SNR-1105)
		/// 5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.
		/// </summary>
		string PieceBarcode { get; set; }

		/// <summary>
		/// Reported Seed Condition (SNR-1106)
		/// The condition of the seed as received by a seed reporter.
		/// </summary>
		string ReportedSeedCondition { get; set; }

		/// <summary>
		/// IM™ Barcode (SNR-1108)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain
		/// unique for 45 days.
		/// </summary>
		string IMBarcode { get; set; }

		/// <summary>
		/// User Option Field (SNR-1110)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// SNR Record Status (SNR-2000)
		/// </summary>
		string SNRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SNR-1103)
		/// </summary>
		string ReserveSNR1103 { get; set; }

		/// <summary>
		/// Closing Character (SNR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}