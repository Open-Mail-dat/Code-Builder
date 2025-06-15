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
	/// These are the allowed values for the property PrincipalProcessingCategory (SEG-1103).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "seg", FieldCode = "SEG-1103")]
	public class PrincipalProcessingCategories : MaildatValues 
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
			return "SEG-1103";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "CD", FileExtension = "seg", Description = "Card", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CD", FileExtension = "seg", Description = "Card", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CD", FileExtension = "seg", Description = "Card", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CM", FileExtension = "seg", Description = "Custom Mail", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CM", FileExtension = "seg", Description = "Custom Mail", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CM", FileExtension = "seg", Description = "Custom Mail", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FL", FileExtension = "seg", Description = "Flat", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FL", FileExtension = "seg", Description = "Flat", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FL", FileExtension = "seg", Description = "Flat", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "IR", FileExtension = "seg", Description = "Nonstandard Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "IR", FileExtension = "seg", Description = "Nonstandard Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "IR", FileExtension = "seg", Description = "Nonstandard Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "LT", FileExtension = "seg", Description = "Letter", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "LT", FileExtension = "seg", Description = "Letter", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "LT", FileExtension = "seg", Description = "Letter", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MP", FileExtension = "seg", Description = "Machinable Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MP", FileExtension = "seg", Description = "Machinable Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "MP", FileExtension = "seg", Description = "Machinable Parcel", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "NP", FileExtension = "seg", Description = "Reserve", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "NP", FileExtension = "seg", Description = "Reserve", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PF", FileExtension = "seg", Description = "Parcel, First Class", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PF", FileExtension = "seg", Description = "Parcel, First Class", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PF", FileExtension = "seg", Description = "Parcel, First Class", FieldCode = "SEG-1103", FieldName = "PrincipalProcessingCategory" });
		}
	}
}