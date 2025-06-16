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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Quantity and destination per package.
	/// </summary>
	public interface IPqt : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (PQT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (PQT-1034)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		int CqtDatabaseId { get; set; }

		/// <summary>
		/// Package ID (PQT-1012)
		/// The unique code for this package within this container.
		/// </summary>
		string PackageId { get; set; }

		/// <summary>
		/// Package ZIP Code (PQT-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. For a Package Service parcel presort the Parcel Piece is the package; therefore, populate
		/// with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP
		/// or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if
		/// for U.S. Domestic International: (ex: FRCDGA = FR CDG A).
		/// </summary>
		string PackageZipCode { get; set; }

		/// <summary>
		/// Package Carrier Route (PQT-1101)
		/// Example: C999, R999, B999, H999 as applicable.
		/// </summary>
		string PackageCarrierRoute { get; set; }

		/// <summary>
		/// Package Level (PQT-1102)
		/// See Below.
		/// </summary>
		string PackageLevel { get; set; }

		/// <summary>
		/// Number of Copies (PQT-1103)
		/// Number of copies within the specific package.
		/// </summary>
		int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (PQT-1104)
		/// Number of pieces within this specific package. Note: First record within Firm Package or Multi-Piece
		/// Parcel has Piece Count = 1 subsequent records within same Package the piece count = 0 (see Scenarios
		/// for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than
		/// copies in some Periodical or 4C mailings).
		/// </summary>
		int NumberOfPieces { get; set; }

		/// <summary>
		/// Bundle Charge Allocation (PQT-1113)
		/// 9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the
		/// proportion of cost of its bundle that it's carrying.
		/// </summary>
		decimal? BundleChargeAllocation { get; set; }

		/// <summary>
		/// Combo-Pack ID (PQT-1114)
		/// The unique code for this combo-pack within this package.
		/// </summary>
		string ComboPackId { get; set; }

		/// <summary>
		/// PQT Record Status (PQT-2000)
		/// O, D, I, U.
		/// </summary>
		string PqtRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PQT-1105)
		/// Reserved for future use.
		/// </summary>
		string ReservePqt1105 { get; set; }

		/// <summary>
		/// Closing Character (PQT-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }

		/// <summary>
		/// Package Preparation Type (PQT-1115)
		/// Populate in the scenario when CSM Tray Preparation Type is set to M = Mixed).
		/// </summary>
		string PackagePreparationType { get; set; }
	}
}