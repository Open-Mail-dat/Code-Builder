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
	/// These are the allowed values for the property MpaRecordStatus (MPA-2000).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpa", FieldCode = "MPA-2000")]
	public class MpaRecordStatuses : MaildatValues 
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
			return "MPA-2000";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "mpa", Description = "Delete", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "mpa", Description = "Delete", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "mpa", Description = "Delete", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "mpa", Description = "Insert", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "mpa", Description = "Insert", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "mpa", Description = "Insert", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "mpa", Description = "Original", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "mpa", Description = "Original", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "mpa", Description = "Original", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "mpa", Description = "Update", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "mpa", Description = "Update", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "mpa", Description = "Update", FieldCode = "MPA-2000", FieldName = "MpaRecordStatus" });
		}
	}
}