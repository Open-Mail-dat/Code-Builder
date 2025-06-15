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
	/// Links new container with an original container. Allows customers to tie or link container
	/// information between Jobs from Mail.dat and Mail.XML.
	/// </summary>
	public interface IOci : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (OCI-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Container ID (OCI-1002)
		/// This file is not designed for Mother Pallets.
		/// </summary>
		int ContainerId { get; set; }

		/// <summary>
		/// Original Job ID (OCI-1101)
		/// Job Id provided in another Mailing Job.
		/// </summary>
		string OriginalJobId { get; set; }

		/// <summary>
		/// Original User License Code (OCI-1102)
		/// User License Code provided in another mailing/Job.
		/// </summary>
		string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// Original Segment ID (OCI-1103)
		/// Segment ID provided in another mailing/Job.
		/// </summary>
		string OriginalSegmentId { get; set; }

		/// <summary>
		/// Original Container ID (OCI-1104)
		/// Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.
		/// </summary>
		int OriginalContainerId { get; set; }

		/// <summary>
		/// Original Display Container ID (OCI-1105)
		/// Meaningful (external to Mail.dat) container ID as defined by specific production application; the
		/// Postal container label. Display Container ID provided in another mailing/Job.
		/// </summary>
		string OriginalDisplayContainerId { get; set; }

		/// <summary>
		/// Original Label: IM™ Container Or IM™ Tray Barcode (OCI-1106)
		/// </summary>
		string OriginalLabelImContainerOrImTrayBarcode { get; set; }

		/// <summary>
		/// Original Mail.XML Customer Group ID (OCI-1107)
		/// Mail.XML Customer Group ID provided in another Mailing Job.
		/// </summary>
		string OriginalMailXmlCustomerGroupId { get; set; }

		/// <summary>
		/// Original Mail.XML Mailing Group ID (OCI-1108)
		/// Mail.XML Mailing Group Id provided in another Mailing Job.
		/// </summary>
		string OriginalMailXmlMailingGroupId { get; set; }

		/// <summary>
		/// Original Mail.XML Container ID (OCI-1109)
		/// Mail.XML Container Id provided in another Mailing Job.
		/// </summary>
		int? OriginalMailXmlContainerId { get; set; }

		/// <summary>
		/// OCI Record Status (OCI-2000)
		/// </summary>
		string OciRecordStatus { get; set; }

		/// <summary>
		/// Reserve (OCI-1110)
		/// Reserved for future use.
		/// </summary>
		string ReserveOci1110 { get; set; }

		/// <summary>
		/// Closing Character (OCI-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}