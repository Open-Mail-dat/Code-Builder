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
	/// These are the allowed values for the property MailDatPresentationCategory (HDR-1154).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "hdr", FieldCode = "HDR-1154")]
	public class MailDatPresentationCategories : MaildatValues 
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
			return "HDR-1154";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "hdr", Description = "Consolidated Internal Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "hdr", Description = "Consolidated Internal Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "hdr", Description = "Consolidated Internal Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "hdr", Description = "Consolidated External Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "hdr", Description = "Consolidated External Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "hdr", Description = "Consolidated External Copal Job with MLOCR and Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "hdr", Description = "Informed Delivery", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "hdr", Description = "Informed Delivery", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "hdr", Description = "Informed Delivery", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "hdr", Description = "MLOCR", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "hdr", Description = "MLOCR", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "hdr", Description = "MLOCR", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "hdr", Description = "Single Piece", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "hdr", Description = "Single Piece", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "hdr", Description = "Single Piece", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "hdr", Description = "Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "hdr", Description = "Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "hdr", Description = "Conventional Presort", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "hdr", Description = "Certificate of Mailing", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "hdr", Description = "Certificate of Mailing", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "hdr", Description = "Certificate of Mailing", FieldCode = "HDR-1154", FieldName = "MailDatPresentationCategory" });
		}
	}
}