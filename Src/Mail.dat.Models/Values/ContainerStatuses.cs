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
	/// These are the allowed values for the property ContainerStatus (CSM-1124).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "csm", FieldCode = "CSM-1124")]
	public class ContainerStatuses : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "csm";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CSM-1124";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "csm", Description = "Not closed", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "csm", Description = "Not closed", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "csm", Description = "Not closed", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "csm", Description = "Cancel", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "csm", Description = "Cancel", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "csm", Description = "Cancel", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "csm", Description = "Delete", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "csm", Description = "Delete", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "csm", Description = "Delete", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "csm", Description = "Preliminary postage statement", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "csm", Description = "Preliminary postage statement", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "csm", Description = "Preliminary postage statement", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "csm", Description = "Ready to pay", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "csm", Description = "Ready to pay", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "csm", Description = "Ready to pay", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "csm", Description = "Transportation Information Updated", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "csm", Description = "Transportation Information Updated", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "csm", Description = "Transportation Information Updated", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "csm", Description = "Paid", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "csm", Description = "Paid", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "csm", Description = "Paid", FieldCode = "CSM-1124", FieldName = "ContainerStatus" });
		}
	}
}