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
	/// Barcode for special services. Provides barcode for special fees.
	/// </summary>
	public interface ISfb : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (SFB-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Piece ID (SFB-1018)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		string PieceId { get; set; }

		/// <summary>
		/// Barcode Type (SFB-1004)
		/// </summary>
		string BarcodeType { get; set; }

		/// <summary>
		/// Barcode (SFB-1003)
		/// IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode
		/// (IMb® or IMpb®) that has been added to the piece.
		/// </summary>
		string Barcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (SFB-1005)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// SFB Record Status (SFB-2000)
		/// </summary>
		string SfbRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (SFB-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}