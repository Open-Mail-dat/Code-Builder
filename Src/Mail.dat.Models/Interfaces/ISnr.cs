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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Detail for each tracking program address. Identifies package/container of seed names within the
	/// presort.
	/// </summary>
	public interface ISnr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (SNR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Container ID (SNR-1006)
		/// </summary>
		int ContainerId { get; set; }

		/// <summary>
		/// Package ID (SNR-1012)
		/// The unique code for this package within this container.
		/// </summary>
		string PackageId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (SNR-1003)
		/// </summary>
		string MailPieceUnitId { get; set; }

		/// <summary>
		/// Seed Name ID (SNR-1016)
		/// Since this file is only necessary to be used in the event that a list of specific and documented
		/// names for a tracking program, then this field is populated with the supplied ID for each specific
		/// name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be
		/// tracked. General seed lists (example: all managers at the catalog) will not require feedback of this
		/// nature from the list house.
		/// </summary>
		string SeedNameId { get; set; }

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
		DateOnly? SeedNameReceivedDate { get; set; }

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
		string ImBarcode { get; set; }

		/// <summary>
		/// User Option Field (SNR-1110)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// SNR Record Status (SNR-2000)
		/// O, D, I, U.
		/// </summary>
		string SnrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SNR-1103)
		/// Reserved for future use.
		/// </summary>
		string ReserveSnr1103 { get; set; }

		/// <summary>
		/// Closing Character (SNR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}