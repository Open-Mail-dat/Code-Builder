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
	/// These are the allowed values for the property ServiceAdditionalType (CFR-1101).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "cfr", FieldCode = "CFR-1101")]
	public class ServiceAdditionalTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cfr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CFR-1101";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "cfr", Description = "Not Specified", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "cfr", Description = "Not Specified", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "cfr", Description = "Not Specified", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "cfr", Description = "6 Months", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "cfr", Description = "6 Months", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "cfr", Description = "6 Months", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "cfr", Description = "1 Year", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "cfr", Description = "1 Year", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "cfr", Description = "1 Year", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "cfr", Description = "3 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "cfr", Description = "3 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "cfr", Description = "3 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "cfr", Description = "5 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "cfr", Description = "5 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "cfr", Description = "5 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "cfr", Description = "7 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "cfr", Description = "7 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "cfr", Description = "7 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "cfr", Description = "10 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "cfr", Description = "10 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "cfr", Description = "10 Years", FieldCode = "CFR-1101", FieldName = "ServiceAdditionalType" });
		}
	}
}