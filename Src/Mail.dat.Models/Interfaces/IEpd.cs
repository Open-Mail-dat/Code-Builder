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
// This code was auto-generated on June 28th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
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
		/// O, D, I, U.
		/// </summary>
		string EpdRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (EPD-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}