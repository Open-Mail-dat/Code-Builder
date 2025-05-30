// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 30th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.3
// 

namespace Mail.dat
{
	/// <summary>
	/// Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).
	/// </summary>
	public interface IUpa : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (UPA-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Piece ID (UPA-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		string PieceID { get; set; }

		/// <summary>
		/// CQT Database ID (UPA-1034)
		/// </summary>
		int CQTDatabaseID { get; set; }

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
		string UPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (UPA-1120)
		/// </summary>
		string ReserveUPA1120 { get; set; }

		/// <summary>
		/// Closing Character (UPA-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}