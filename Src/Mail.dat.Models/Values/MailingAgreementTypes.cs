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
	/// These are the allowed values for the property MailingAgreementType (SEG-1139).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "seg", FieldCode = "SEG-1139")]
	public class MailingAgreementTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "seg";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "SEG-1139";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "seg", Description = "Not Applicable", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "seg", Description = "Not Applicable", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "seg", Description = "Not Applicable", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "seg", Description = "Alternate Mailing System", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "seg", Description = "Alternate Mailing System", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "seg", Description = "Alternate Mailing System", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "seg", Description = "Optional Procedure", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "seg", Description = "Optional Procedure", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "seg", Description = "Optional Procedure", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "seg", Description = "Reserved", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "seg", Description = "Reserved", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "seg", Description = "Reserved", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "seg", Description = "Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "seg", Description = "Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "seg", Description = "Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "seg", Description = "Combined Mail", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "seg", Description = "Combined Mail", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "seg", Description = "Combined Mail", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "seg", Description = "Combined and Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "seg", Description = "Combined and Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "seg", Description = "Combined and Value Added", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "seg", Description = "Manifest Mailing Itemized", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "seg", Description = "Manifest Mailing Itemized", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "seg", Description = "Manifest Mailing Itemized", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "seg", Description = "Manifest Mailing Batch", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "seg", Description = "Manifest Mailing Batch", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "seg", Description = "Manifest Mailing Batch", FieldCode = "SEG-1139", FieldName = "MailingAgreementType" });
		}
	}
}