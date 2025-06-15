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
	/// These are the allowed values for the property FormType (CHR-1101).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "chr", FieldCode = "CHR-1101")]
	public class FormTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "chr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CHR-1101";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "chr", Description = "PS Form 3606-D (Bulk Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "chr", Description = "PS Form 3606-D (Bulk Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "chr", Description = "PS Form 3606-D (Bulk Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "chr", Description = "PS Form 3665 (Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "chr", Description = "PS Form 3665 (Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "chr", Description = "PS Form 3665 (Certificate of Mailing)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "chr", Description = "PS Form 3877 (Firm Book for Accountable Mail)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "chr", Description = "PS Form 3877 (Firm Book for Accountable Mail)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "chr", Description = "PS Form 3877 (Firm Book for Accountable Mail)", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "chr", Description = "Reserved", FieldCode = "CHR-1101", FieldName = "FormType" });
		}
	}
}