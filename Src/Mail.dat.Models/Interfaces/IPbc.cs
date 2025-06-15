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
		/// </summary>
		string PbcRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PBC-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}