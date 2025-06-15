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
	/// These are the allowed values for the property PostagePaymentOption (MPA-1109).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpa", FieldCode = "MPA-1109")]
	public class PostagePaymentOptions : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "mpa";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "MPA-1109";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "mpa", Description = "Billing", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "mpa", Description = "Billing", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "mpa", Description = "Billing", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "mpa", Description = "CPP", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "mpa", Description = "CPP", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "mpa", Description = "CPP", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "mpa", Description = "Debit", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "mpa", Description = "Debit", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "mpa", Description = "Debit", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "mpa", Description = "Other", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "mpa", Description = "Other", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "mpa", Description = "Other", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "mpa", Description = "CAPS/EPS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "mpa", Description = "CAPS/EPS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "mpa", Description = "CAPS/EPS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "V", FileExtension = "mpa", Description = "PVDS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "V", FileExtension = "mpa", Description = "PVDS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "V", FileExtension = "mpa", Description = "PVDS", FieldCode = "MPA-1109", FieldName = "PostagePaymentOption" });
		}
	}
}