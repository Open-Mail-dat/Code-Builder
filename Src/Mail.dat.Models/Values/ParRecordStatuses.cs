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
	/// These are the allowed values for the property ParRecordStatus (PAR-2000).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "par", FieldCode = "PAR-2000")]
	public class ParRecordStatuses : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "par";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "PAR-2000";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "par", Description = "Delete", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "par", Description = "Delete", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "par", Description = "Delete", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "par", Description = "Insert", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "par", Description = "Insert", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "par", Description = "Insert", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "par", Description = "Original", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "par", Description = "Original", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "par", Description = "Original", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "par", Description = "Update", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "par", Description = "Update", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "par", Description = "Update", FieldCode = "PAR-2000", FieldName = "ParRecordStatus" });
		}
	}
}