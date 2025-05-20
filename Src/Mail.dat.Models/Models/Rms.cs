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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Records identify a summary of campaigns that can be tied to barcode records.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "rms", File = "Referenceable Mail Summary Record", Summary = "Referenceable Mail Summary to provide digital Content.", Description = "Records identify a summary of campaigns that can be tied to barcode records.")]
	[Table("Rms", Schema = "Maildat")]
	public partial class Rms : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (RMS-1001)
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// RMS ID (RMS-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[Column("RMSID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string RMSID { get; set; }

		/// <summary>
		/// Reserve (RMS-1009)
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1009", FieldName = "Reserve", Start = 17, Length = 22, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 3)]
		[MaxLength(22)]
		public string ReserveRMS1009 { get; set; }

		/// <summary>
		/// Campaign Title (RMS-1003)
		/// Title of Campaign. Displays internally on the Informed Delivery Administrative console and in the
		/// Informed Delivery Mailer Portal. Note: Refer to the PostalOne! Mail.dat Tech Specification for more
		/// information on populating this field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1003", FieldName = "Campaign Title", Start = 39, Length = 40, Required = true, Key = false, DataType = "A/N", Description = "Title of Campaign. Displays internally on the Informed Delivery Administrative console and in the Informed Delivery Mailer Portal. Note: Refer to the PostalOne! Mail.dat Tech Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("CampaignTitle", Order = 4)]
		[Required]
		[MaxLength(40)]
		public string CampaignTitle { get; set; }

		/// <summary>
		/// Campaign Code (RMS-1004)
		/// Campaign Code further identifies subsets of a Campaign and must be unique for each distinct set of
		/// Campaign elements. The same Campaign Code may Be used across multiple jobs to update campaign Serial
		/// ranges, as long as the Start date of campaign is In the future and campaign is in Submitted status.
		/// When submitting across multiple jobs, all campaign Elements must match prior job submissions. Note:
		/// Refer to the PostalOne! Mail.dat Tech Specifications for more information on populating this field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1004", FieldName = "Campaign Code", Start = 79, Length = 40, Required = true, Key = false, DataType = "A/N", Description = "Campaign Code further identifies subsets of a Campaign and must be unique for each distinct set of Campaign elements. The same Campaign Code may Be used across multiple jobs to update campaign Serial ranges, as long as the Start date of campaign is In the future and campaign is in Submitted status. When submitting across multiple jobs, all campaign Elements must match prior job submissions. Note: Refer to the PostalOne! Mail.dat Tech Specifications for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("CampaignCode", Order = 5)]
		[Required]
		[MaxLength(40)]
		public string CampaignCode { get; set; }

		/// <summary>
		/// Campaign Serial Grouping (RMS-1005)
		/// The below two values are supported at this time: C= IMb® in continuous serial range with
		/// non-personalized campaigns. This supports Informed Delivery in identifying when an IMb® serial range
		/// can be used to create a campaign. S= Saturation campaign data using ZIP11s supplied by the Mailer in
		/// the PDR file. This type of Campaign can only be used with Saturation mailings. This supports
		/// Informed Delivery in identifying campaign data as Saturation campaigns.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1005", FieldName = "Campaign Serial Grouping", Start = 119, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "The below two values are supported at this time: C= IMb® in continuous serial range with non-personalized campaigns. This supports Informed Delivery in identifying when an IMb® serial range can be used to create a campaign. S= Saturation campaign data using ZIP11s supplied by the Mailer in the PDR file. This type of Campaign can only be used with Saturation mailings. This supports Informed Delivery in identifying campaign data as Saturation campaigns.", Type = "enum", Format = "leftjustify")]
		[Column("CampaignSerialGrouping", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "S")]
		public string CampaignSerialGrouping { get; set; }

		/// <summary>
		/// Display Name (RMS-1006)
		/// Display Name of campaign for the consumer portal and for the consumer emails.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1006", FieldName = "Display Name", Start = 120, Length = 40, Required = true, Key = false, DataType = "A/N", Description = "Display Name of campaign for the consumer portal and for the consumer emails.", Type = "string", Format = "leftjustify")]
		[Column("DisplayName", Order = 7)]
		[Required]
		[MaxLength(40)]
		public string DisplayName { get; set; }

		/// <summary>
		/// Date Start (RMS-1007)
		/// YYYYMMDD Start Date when the Referenceable Mail Content can be used. Default to blank spaces when no
		/// constraint requested, Cannot be all zeroes.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1007", FieldName = "Date Start", Start = 160, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD Start Date when the Referenceable Mail Content can be used. Default to blank spaces when no constraint requested, Cannot be all zeroes.", Type = "date", Format = "YYYYMMDD")]
		[Column("DateStart", Order = 8)]
		public DateOnly DateStart { get; set; }

		/// <summary>
		/// Date End (RMS-1008)
		/// YYYYMMDD End Date when the Referenceable Mail Content can be used. Default to blank spaces when no
		/// constraint requested, Cannot be all zeroes.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1008", FieldName = "Date End", Start = 168, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD End Date when the Referenceable Mail Content can be used. Default to blank spaces when no constraint requested, Cannot be all zeroes.", Type = "date", Format = "YYYYMMDD")]
		[Column("DateEnd", Order = 9)]
		public DateOnly DateEnd { get; set; }

		/// <summary>
		/// Campaign Sharing Indicator (RMS-1010)
		/// Enables the mailer to determine whether to display sharing options to consumer recipients of the
		/// Informed Delivery campaign.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1010", FieldName = "Campaign Sharing Indicator", Start = 176, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Enables the mailer to determine whether to display sharing options to consumer recipients of the Informed Delivery campaign.", Type = "enum", Format = "leftjustify")]
		[Column("CampaignSharingIndicator", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		public string CampaignSharingIndicator { get; set; }

		/// <summary>
		/// Campaign Target URL Parameters Indicator (RMS-1011)
		/// Enables the mailer to determine whether to add tracking parameters to the Informed Delivery
		/// campaign's target URL.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1011", FieldName = "Campaign Target URL Parameters Indicator", Start = 177, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Enables the mailer to determine whether to add tracking parameters to the Informed Delivery campaign's target URL.", Type = "enum", Format = "leftjustify")]
		[Column("CampaignTargetURLParametersIndicator", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		public string CampaignTargetURLParametersIndicator { get; set; }

		/// <summary>
		/// Campaign Mail Owner CRID (RMS-1012)
		/// Populate with the CRID of the Mail Owner linked to the mailpieces for which the campaign is being
		/// created.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1012", FieldName = "Campaign Mail Owner CRID", Start = 178, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "Populate with the CRID of the Mail Owner linked to the mailpieces for which the campaign is being created.", Type = "string", Format = "leftjustify")]
		[Column("CampaignMailOwnerCRID", Order = 12)]
		[Required]
		[MaxLength(12)]
		public string CampaignMailOwnerCRID { get; set; }

		/// <summary>
		/// Campaign Mail Preparer CRID (RMS-1013)
		/// Populate with the CRID of the Mail Preparer linked to the mailpieces for which the campaign is being
		/// created.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1013", FieldName = "Campaign Mail Preparer CRID", Start = 190, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Populate with the CRID of the Mail Preparer linked to the mailpieces for which the campaign is being created.", Type = "string", Format = "leftjustify")]
		[Column("CampaignMailPreparerCRID", Order = 13)]
		[MaxLength(12)]
		public string CampaignMailPreparerCRID { get; set; }

		/// <summary>
		/// Campaign Processing Category (RMS-1014)
		/// The processing category for which this campaign is eligible.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1014", FieldName = "Campaign Processing Category", Start = 202, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "The processing category for which this campaign is eligible.", Type = "enum", Format = "leftjustify")]
		[Column("CampaignProcessingCategory", Order = 14)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("CD", "CM", "DM", "FL", "IR", "LT", "MP", "PF", "PK")]
		public string CampaignProcessingCategory { get; set; }

		/// <summary>
		/// Flex Option A (RMS-1015)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1015", FieldName = "Flex Option A", Start = 204, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionA", Order = 15)]
		[MaxLength(2)]
		public string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (RMS-1016)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1016", FieldName = "Flex Option B", Start = 206, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionB", Order = 16)]
		[MaxLength(2)]
		public string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (RMS-1017)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1017", FieldName = "Flex Option C", Start = 208, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionC", Order = 17)]
		[MaxLength(2)]
		public string FlexOptionC { get; set; }

		/// <summary>
		/// Flex Option D (RMS-1018)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1018", FieldName = "Flex Option D", Start = 210, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionD", Order = 18)]
		[MaxLength(2)]
		public string FlexOptionD { get; set; }

		/// <summary>
		/// Flex Option E (RMS-1019)
		/// Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat
		/// Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this
		/// field.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1019", FieldName = "Flex Option E", Start = 212, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Reserved for Future Informed Delivery Campaign Settings. Refer to the Informed Delivery Mail.dat Mailer Guide / PostalOne! Mail.dat Technical Specification for more information on populating this field.", Type = "string", Format = "leftjustify")]
		[Column("FlexOptionE", Order = 19)]
		[MaxLength(2)]
		public string FlexOptionE { get; set; }

		/// <summary>
		/// Reserve (RMS-1020)
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-1020", FieldName = "Reserve", Start = 214, Length = 20, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 20)]
		[MaxLength(20)]
		public string ReserveRMS1020 { get; set; }

		/// <summary>
		/// RMS Record Status (RMS-2000)
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-2000", FieldName = "RMS Record Status", Start = 234, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("RMSRecordStatus", Order = 21)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string RMSRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMS-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "rms", FieldCode = "RMS-9999", FieldName = "Closing Character", Start = 235, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 22)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}