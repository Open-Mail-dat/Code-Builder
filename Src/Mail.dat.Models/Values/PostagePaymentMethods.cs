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
	/// These are the allowed values for the property PostagePaymentMethod (MPA-1111).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpa", FieldCode = "MPA-1111")]
	public class PostagePaymentMethods : MaildatValues 
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
			return "MPA-1111";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "mpa", Description = "Alt Del", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "mpa", Description = "Alt Del", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "mpa", Description = "Alt Del", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "mpa", Description = "Metered: Correc", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "mpa", Description = "Metered: Correc", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "mpa", Description = "Metered: Correct", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "mpa", Description = "Gov't - Fed (use Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "mpa", Description = "Gov't - Fed (use Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "mpa", Description = "Gov't - Fed (use Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "mpa", Description = "Cash", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "mpa", Description = "Cash", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "mpa", Description = "Cash", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "mpa", Description = "Partial Permit Imprin", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "mpa", Description = "Partial Permit Imprin", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "mpa", Description = "Partial Permit Imprint", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "mpa", Description = "Metered: Lowest", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "mpa", Description = "Metered: Lowest", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "mpa", Description = "Metered: Lowest", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "mpa", Description = "Metered: Neither", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "mpa", Description = "Metered: Neither", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "mpa", Description = "Metered: Neither", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "mpa", Description = "Permit", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "mpa", Description = "Permit", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "mpa", Description = "Permit", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "mpa", Description = "Stamp", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "mpa", Description = "Stamp", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "mpa", Description = "Stamp", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "mpa", Description = "Per Pend (using Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "mpa", Description = "Per Pend (using Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "mpa", Description = "Per Pend (using Permit)", FieldCode = "MPA-1111", FieldName = "PostagePaymentMethod" });
		}
	}
}