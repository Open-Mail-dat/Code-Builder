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
	/// These are the allowed values for the property PostageAdjustmentFileStatus (HDR-1147).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "hdr", FieldCode = "HDR-1147")]
	public class PostageAdjustmentFileStatuses : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "hdr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "HDR-1147";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "hdr", Description = "Change Individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "hdr", Description = "Change Individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "hdr", Description = "Change Individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "hdr", Description = "Delete Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "hdr", Description = "Delete Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "hdr", Description = "Delete Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "hdr", Description = "None Transmitted", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "hdr", Description = "None Transmitted", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "hdr", Description = "None Transmitted", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "hdr", Description = "Original", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "hdr", Description = "Original", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "hdr", Description = "Original", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "hdr", Description = "Replace Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "hdr", Description = "Replace Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "hdr", Description = "Replace Entire File", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "hdr", Description = "Update individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "hdr", Description = "Update individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "hdr", Description = "Update individual Records", FieldCode = "HDR-1147", FieldName = "PostageAdjustmentFileStatus" });
		}
	}
}