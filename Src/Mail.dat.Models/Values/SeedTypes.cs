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
	/// These are the allowed values for the property SeedType (SNR-1104).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "snr", FieldCode = "SNR-1104")]
	public class SeedTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "snr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "SNR-1104";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "snr", Description = "Both R + C", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "snr", Description = "Both R + C", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "snr", Description = "Both R + C", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "snr", Description = "Standard Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "snr", Description = "Standard Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "snr", Description = "Standard Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "snr", Description = "Traditional Response Seed", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "snr", Description = "Traditional Response Seed", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "snr", Description = "Traditional Response Seed", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "snr", Description = "Smart Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "snr", Description = "Smart Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "snr", Description = "Smart Confirm", FieldCode = "SNR-1104", FieldName = "SeedType" });
		}
	}
}