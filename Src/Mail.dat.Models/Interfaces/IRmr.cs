// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 1.0.0
// 
using Diamond.Core.Repository;

namespace Mail.dat
{
	/// <summary>
	/// Records identify digital campaigns and enhances capabilities of the USPS Informed Delivery program.
	/// </summary>
	public interface IRmr : IEntity<int>
	{
		/// <summary>
		/// Job ID (RMR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// RMR ID (RMR-1002)
		/// Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record
		/// should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right
		/// justify and zero fill; PDR - Piece ID; CPT - Component ID.
		/// </summary>
		string RMRID { get; set; }

		/// <summary>
		/// RMR ID Type (RMR-1003)
		/// Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record
		/// (CPT, PDR/PBC) that the RMR ID (this record) represents.
		/// </summary>
		string RMRIDType { get; set; }

		/// <summary>
		/// RMS ID (RMR-1009)
		/// RMS ID of the Campaign Summary record.
		/// </summary>
		string RMSID { get; set; }

		/// <summary>
		/// RMR Content Type (RMR-1004)
		/// Field to capture the type of RMR content. RMR content Can either be a URL of a media image that is
		/// supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.
		/// </summary>
		string RMRContentType { get; set; }

		/// <summary>
		/// CQT Database ID (RMR-1010)
		/// See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR.
		/// Field must be blank for RMR ID type of Component.
		/// </summary>
		int CQTDatabaseID { get; set; }

		/// <summary>
		/// RMR Value (RMR-1005)
		/// Value/Content URL for the Referenceable Mail media or Target/HREF document (could be a webpage, or
		/// image/media Driven by the RMR Content Type field); Leave BLANK if piece Wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		string RMRValue { get; set; }

		/// <summary>
		/// RMR Template Code (RMR-1008)
		/// RMR Template Code, one of many templates provided by Postal Service, Possible values can be A
		/// through Z.
		/// </summary>
		string RMRTemplateCode { get; set; }

		/// <summary>
		/// Reserve (RMR-1011)
		/// </summary>
		string ReserveRMR1011 { get; set; }

		/// <summary>
		/// RMR Record Status (RMR-2000)
		/// </summary>
		string RMRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}