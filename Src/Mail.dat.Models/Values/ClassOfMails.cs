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
	/// These are the allowed values for the property ClassOfMail (CBR-1102).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "cbr", FieldCode = "CBR-1102")]
	public class ClassOfMails : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cbr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CBR-1102";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "1", FileExtension = "cbr", Description = "First Class", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "1", FileExtension = "cbr", Description = "First Class", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1", FileExtension = "cbr", Description = "First Class", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "3", FileExtension = "cbr", Description = "Std Mail", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "3", FileExtension = "cbr", Description = "Std Mail", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "3", FileExtension = "cbr", Description = "Std Mail", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "4", FileExtension = "cbr", Description = "Pkg Services", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4", FileExtension = "cbr", Description = "Pkg Services", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4", FileExtension = "cbr", Description = "Pkg Services", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "9", FileExtension = "cbr", Description = "Other", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "9", FileExtension = "cbr", Description = "Other", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "9", FileExtension = "cbr", Description = "Other", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
		}
	}
}