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
	/// Un-coded parcels address record (linked to PDR). Un-Coded Parcel Address file: records addresses for
	/// the un-coded parcels. (Links with .pdr ONLY).
	/// </summary>
	public interface IUpa : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (UPA-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Piece ID (UPA-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		string PieceId { get; set; }

		/// <summary>
		/// CQT Database ID (UPA-1034)
		/// </summary>
		int CqtDatabaseId { get; set; }

		/// <summary>
		/// Address (UPA-1102)
		/// Address line to be used for population of shipping services file.
		/// </summary>
		string Address { get; set; }

		/// <summary>
		/// Additional Address (UPA-1103)
		/// Address 2 line to be used for Secondary Address or Urbanization information.
		/// </summary>
		string AdditionalAddress { get; set; }

		/// <summary>
		/// UPA Record Status (UPA-2000)
		/// </summary>
		string UParecordStatus { get; set; }

		/// <summary>
		/// Reserve (UPA-1120)
		/// Reserved for future use.
		/// </summary>
		string ReserveUpa1120 { get; set; }

		/// <summary>
		/// Closing Character (UPA-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}