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
	/// These are the allowed values for the property SnrRecordStatus (SNR-2000).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "snr", FieldCode = "SNR-2000")]
	public class SnrRecordStatuses : MaildatValues 
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
			return "SNR-2000";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "snr", Description = "Delete", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "snr", Description = "Delete", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "snr", Description = "Delete", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "snr", Description = "Insert", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "snr", Description = "Insert", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "snr", Description = "Insert", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "snr", Description = "Original", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "snr", Description = "Original", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "snr", Description = "Original", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "snr", Description = "Update", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "snr", Description = "Update", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "snr", Description = "Update", FieldCode = "SNR-2000", FieldName = "SnrRecordStatus" });
		}
	}
}