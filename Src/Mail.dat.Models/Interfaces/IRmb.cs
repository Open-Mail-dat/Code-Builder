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
	/// Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat
	/// required files and structure. Records identify digital campaigns and enhance capabilities of the
	/// USPS Informed Delivery  program separate from the required file structure.
	/// </summary>
	public interface IRmb : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (RMB-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// RMS ID (RMB-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		string RmsId { get; set; }

		/// <summary>
		/// Barcode (RMB-1003)
		/// IMb® for Informed Delivery.
		/// </summary>
		string Barcode { get; set; }

		/// <summary>
		/// RMB Content Type (RMB-1004)
		/// Field to capture the type of RMB content. RMB content can either be a URL of a media image that is
		/// supported by browsers or a target URL that will be placed as a Hyperlink for the media/image.
		/// Details of the codes will be available in the USPS Technical Guide for Mail.dat.
		/// </summary>
		string RmbContentType { get; set; }

		/// <summary>
		/// Original Job ID (RMB-1005)
		/// Job ID provided in another mailing job.
		/// </summary>
		string OriginalJobId { get; set; }

		/// <summary>
		/// Original User License Code (RMB-1006)
		/// User License Code provided in another mailing job.
		/// </summary>
		string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// RMB Value (RMB-1007)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		string RmbValue { get; set; }

		/// <summary>
		/// RMB Template Code (RMB-1008)
		/// RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.
		/// </summary>
		string RmbTemplateCode { get; set; }

		/// <summary>
		/// RMB Record Status (RMB-2000)
		/// O, D, I, U.
		/// </summary>
		string RmbRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMB-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}