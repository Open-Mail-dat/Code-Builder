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
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Reference-able Mail to provide digital content at the piece or version level. Records identify
	/// digital campaigns and enhances capabilities of the USPS Informed Delivery program.
	/// </summary>
	public interface IRmr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (RMR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// RMR ID (RMR-1002)
		/// Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record
		/// should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right
		/// justify and zero fill; PDR - Piece ID; CPT - Component ID.
		/// </summary>
		string RmrId { get; set; }

		/// <summary>
		/// RMR ID Type (RMR-1003)
		/// Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record
		/// (CPT, PDR/PBC) that the RMR ID (this record) represents.
		/// </summary>
		string RmrIdType { get; set; }

		/// <summary>
		/// RMS ID (RMR-1009)
		/// RMS ID of the Campaign Summary record.
		/// </summary>
		string RmsId { get; set; }

		/// <summary>
		/// RMR Content Type (RMR-1004)
		/// Field to capture the type of RMR content. RMR content can either be a URL of a media image that is
		/// supported by browsers or a target URL that will be placed as a Hyperlink for the media/image.
		/// </summary>
		string RmrContentType { get; set; }

		/// <summary>
		/// CQT Database ID (RMR-1010)
		/// See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR.
		/// Field must be blank for RMR ID type of Component.
		/// </summary>
		int? CqtDatabaseId { get; set; }

		/// <summary>
		/// RMR Value (RMR-1005)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		string RmrValue { get; set; }

		/// <summary>
		/// RMR Template Code (RMR-1008)
		/// RMR Template Code, one of many templates provided by Postal Service, Possible values can be A
		/// through Z.
		/// </summary>
		string RmrTemplateCode { get; set; }

		/// <summary>
		/// Reserve (RMR-1011)
		/// Reserved for future use.
		/// </summary>
		string ReserveRmr1011 { get; set; }

		/// <summary>
		/// RMR Record Status (RMR-2000)
		/// O, D, I, U.
		/// </summary>
		string RmrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}