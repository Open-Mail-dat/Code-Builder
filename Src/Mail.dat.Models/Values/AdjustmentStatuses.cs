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
	/// These are the allowed values for the property AdjustmentStatus (PAR-1108).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "par", FieldCode = "PAR-1108")]
	public class AdjustmentStatuses : MaildatValues 
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
			return "PAR-1108";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "par", Description = "Not Closed", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "par", Description = "Not Closed", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "par", Description = "Not Closed", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "par", Description = "Cancel", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "par", Description = "Cancel", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "par", Description = "Cancel", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "par", Description = "Preliminary Postage Statement", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "par", Description = "Preliminary Postage Statement", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "par", Description = "Preliminary Postage Statement", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "par", Description = "Ready To Pay", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "par", Description = "Ready To Pay", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "par", Description = "Ready To Pay", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "par", Description = "Transportation Information Update, if after R", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "par", Description = "Transportation Information Update, if after R", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "par", Description = "Transportation Information Update, if after R", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "par", Description = "Paid", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "par", Description = "Paid", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "par", Description = "Paid", FieldCode = "PAR-1108", FieldName = "AdjustmentStatus" });
		}
	}
}