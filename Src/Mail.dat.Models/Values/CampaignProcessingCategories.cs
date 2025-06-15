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
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property CampaignProcessingCategory (RMS-1014).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "rms", FieldCode = "RMS-1014")]
	public class CampaignProcessingCategories : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "rms";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "RMS-1014";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "CD", FileExtension = "rms", Description = "Card", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CD", FileExtension = "rms", Description = "Card", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CD", FileExtension = "rms", Description = "Card", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CM", FileExtension = "rms", Description = "Custom Mail", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CM", FileExtension = "rms", Description = "Custom Mail", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CM", FileExtension = "rms", Description = "Custom Mail", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "DM", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "DM", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "DM", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FL", FileExtension = "rms", Description = "Flat", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FL", FileExtension = "rms", Description = "Flat", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FL", FileExtension = "rms", Description = "Flat", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "IR", FileExtension = "rms", Description = "Nonstandard Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "IR", FileExtension = "rms", Description = "Nonstandard Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "IR", FileExtension = "rms", Description = "Nonstandard Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "LT", FileExtension = "rms", Description = "Letter", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "LT", FileExtension = "rms", Description = "Letter", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "LT", FileExtension = "rms", Description = "Letter", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MP", FileExtension = "rms", Description = "Machinable Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MP", FileExtension = "rms", Description = "Machinable Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "MP", FileExtension = "rms", Description = "Machinable Parcel", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "NP", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "NP", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PF", FileExtension = "rms", Description = "Parcel, First Class", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PF", FileExtension = "rms", Description = "Parcel, First Class", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PF", FileExtension = "rms", Description = "Parcel, First Class", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PK", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PK", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PK", FileExtension = "rms", Description = "Reserve", FieldCode = "RMS-1014", FieldName = "CampaignProcessingCategory" });
		}
	}
}