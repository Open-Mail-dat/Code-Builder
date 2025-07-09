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
// This code was auto-generated on July 8th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Detail for each Walk Sequence prepared Carrier Route. Provide detail to verify Saturation or High
	/// Density mailings.
	/// </summary>
	public interface IWsr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (WSR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Segment ID (WSR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		string SegmentId { get; set; }

		/// <summary>
		/// Package ZIP Code (WSR-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. See package Quantity File's Package Zip Code field's definition.
		/// </summary>
		string PackageZipCode { get; set; }

		/// <summary>
		/// Package CR Number (WSR-1014)
		/// Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.
		/// </summary>
		string PackageCRNumber { get; set; }

		/// <summary>
		/// Co-Palletization Code (WSR-1015)
		/// Used to differentiate carrier route mail going to the same ZIP and Route that was coded and
		/// presorted independently, to allow association of Walk Sequence records with particular MPU records
		/// (*.mpu). For Co-palletization, it creates an efficient means to differentiate each of the possible
		/// job and sub-job entities within a co-palletization set-up. Can also be used to differentiate between
		/// simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for
		/// job swhere this additional level of detail is not needed.
		/// </summary>
		string CoPalletizationCode { get; set; }

		/// <summary>
		/// Walk Sequence Type (WSR-1101)
		/// This field indicates whether the calculation of Saturation Walk Sequence eligibility is based upon
		/// the number of Total addresses or Residential Only addresses within the route.
		/// </summary>
		string WalkSequenceType { get; set; }

		/// <summary>
		/// Walk Sequence Stops (WSR-1102)
		/// The number of unique addresses (not pieces delivered) for the carrier when delivering this specific
		/// route within the saturation eligible mailing. This value represents the total stops incurred while
		/// the applicable carrier route within this package is delivered. Walk Sequence Stops for this Carrier
		/// Route.
		/// </summary>
		int WalkSequenceStops { get; set; }

		/// <summary>
		/// Walk Sequence Denominator (WSR-1103)
		/// Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in
		/// the CR. Cannot be zero.
		/// </summary>
		int WalkSequenceDenominator { get; set; }

		/// <summary>
		/// Walk Sequence Database Date (WSR-1104)
		/// The date of the database from which the walk sequence was secured.
		/// </summary>
		DateOnly WalkSequenceDatabaseDate { get; set; }

		/// <summary>
		/// WSR Record Status (WSR-2000)
		/// O, D, I, U.
		/// </summary>
		string WsrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (WSR-1105)
		/// Reserved for future use.
		/// </summary>
		string ReserveWsr1105 { get; set; }

		/// <summary>
		/// Closing Character (WSR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}