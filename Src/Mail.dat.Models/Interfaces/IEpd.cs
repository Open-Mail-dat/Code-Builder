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
	/// CRID for Move update charges. Records identify third party move update entities that should be
	/// invoiced.
	/// </summary>
	public interface IEpd : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (EPD-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Piece ID (EPD-1002)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		string PieceId { get; set; }

		/// <summary>
		/// CRID Type (EPD-1003)
		/// </summary>
		string CridType { get; set; }

		/// <summary>
		/// CRID (EPD-1101)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Only digits 0
		/// - 9 acceptable.
		/// </summary>
		string Crid { get; set; }

		/// <summary>
		/// EPD Record Status (EPD-2000)
		/// </summary>
		string EpdRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (EPD-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}