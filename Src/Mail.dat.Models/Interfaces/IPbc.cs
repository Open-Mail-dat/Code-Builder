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
	/// Piece barcode details. Provides piece level detail required of full service mailings; when used
	/// instead of the Piece Detail file, acts as an extension of the PQT file.
	/// </summary>
	public interface IPbc : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (PBC-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// PBC Unique ID (PBC-1002)
		/// Uniquely identifies each PBC record.
		/// </summary>
		int PbcUniqueId { get; set; }

		/// <summary>
		/// CQT Database ID (PBC-1034)
		/// </summary>
		int CqtDatabaseId { get; set; }

		/// <summary>
		/// Package ID (PBC-1012)
		/// The unique code for this package within this container.
		/// </summary>
		string PackageId { get; set; }

		/// <summary>
		/// Barcode (PBC-1122)
		/// IMb® or IMpb®.
		/// </summary>
		string Barcode { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PBC-1117)
		/// </summary>
		string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PBC-1118)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PBC-1119)
		/// </summary>
		string MidInImbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PBC Record Status (PBC-2000)
		/// O, D, I, U.
		/// </summary>
		string PbcRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PBC-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}