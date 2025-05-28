// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 27th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 

namespace Mail.dat
{
	/// <summary>
	/// Records identify a summary of campaigns that can be tied to barcode records.
	/// </summary>
	public interface IRms : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (RMS-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// RMS ID (RMS-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		string RMSID { get; set; }

		/// <summary>
		/// Reserve (RMS-1009)
		/// </summary>
		string ReserveRMS1009 { get; set; }

		/// <summary>
		/// Campaign Title (RMS-1003)
		/// Title of Campaign. Displays internally on the Informed Delivery Administrative console and in the
		/// Informed Delivery Mailer Portal. Note: Refer to the PostalOne! Mail.dat Tech Specification for more
		/// information on populating this field.
		/// </summary>
		string CampaignTitle { get; set; }

		/// <summary>
		/// Campaign Code (RMS-1004)
		/// Campaign Code further identifies subsets of a Campaign and must be unique for each distinct set of
		/// Campaign elements. The same Campaign Code may Be used across multiple jobs to update campaign Serial
		/// ranges, as long as the Start date of campaign is In the future and campaign is in Submitted status.
		/// When submitting across multiple jobs, all campaign Elements must match prior job submissions. Note:
		/// Refer to the PostalOne! Mail.dat Tech Specifications for more information on populating this field.
		/// </summary>
		string CampaignCode { get; set; }

		/// <summary>
		/// Campaign Serial Grouping (RMS-1005)
		/// The below two values are supported at this time: C= IMb® in continuous serial range with
		/// non-personalized campaigns. This supports Informed Delivery in identifying when an IMb® serial range
		/// can be used to create a campaign. S= Saturation campaign data using ZIP11s supplied by the Mailer in
		/// the PDR file. This type of Campaign can only be used with Saturation mailings. This supports
		/// Informed Delivery in identifying campaign data as Saturation campaigns.
		/// </summary>
		string CampaignSerialGrouping { get; set; }

		/// <summary>
		/// Display Name (RMS-1006)
		/// Display Name of campaign for the consumer portal and for the consumer emails.
		/// </summary>
		string DisplayName { get; set; }

		/// <summary>
		/// Date Start (RMS-1007)
		/// YYYYMMDD Start Date when the Referenceable Mail Content can be used. Default to blank spaces when no
		/// constraint requested, Cannot be all zeroes.
		/// </summary>
		DateOnly? DateStart { get; set; }

		/// <summary>
		/// Date End (RMS-1008)
		/// YYYYMMDD End Date when the Referenceable Mail Content can be used. Default to blank spaces when no
		/// constraint requested, Cannot be all zeroes.
		/// </summary>
		DateOnly? DateEnd { get; set; }

		/// <summary>
		/// Campaign Sharing Indicator (RMS-1010)
		/// Enables the mailer to determine whether to display sharing options to consumer recipients of the
		/// Informed Delivery campaign.
		/// </summary>
		string CampaignSharingIndicator { get; set; }

		/// <summary>
		/// Campaign Target URL Parameters Indicator (RMS-1011)
		/// Enables the mailer to determine whether to add tracking parameters to the Informed Delivery
		/// campaign's target URL.
		/// </summary>
		string CampaignTargetURLParametersIndicator { get; set; }

		/// <summary>
		/// Campaign Mail Owner CRID (RMS-1012)
		/// Populate with the CRID of the Mail Owner linked to the mailpieces for which the campaign is being
		/// created.
		/// </summary>
		string CampaignMailOwnerCRID { get; set; }

		/// <summary>
		/// Campaign Mail Preparer CRID (RMS-1013)
		/// Populate with the CRID of the Mail Preparer linked to the mailpieces for which the campaign is being
		/// created.
		/// </summary>
		string CampaignMailPreparerCRID { get; set; }

		/// <summary>
		/// Campaign Processing Category (RMS-1014)
		/// The processing category for which this campaign is eligible.
		/// </summary>
		string CampaignProcessingCategory { get; set; }

		/// <summary>
		/// Flex Option A (RMS-1015)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (RMS-1016)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (RMS-1017)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		string FlexOptionC { get; set; }

		/// <summary>
		/// Flex Option D (RMS-1018)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		string FlexOptionD { get; set; }

		/// <summary>
		/// Flex Option E (RMS-1019)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		string FlexOptionE { get; set; }

		/// <summary>
		/// Reserve (RMS-1020)
		/// </summary>
		string ReserveRMS1020 { get; set; }

		/// <summary>
		/// RMS Record Status (RMS-2000)
		/// </summary>
		string RMSRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMS-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}