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
		/// O, D, I, U.
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