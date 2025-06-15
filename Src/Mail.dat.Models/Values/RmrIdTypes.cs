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
	/// These are the allowed values for the property RmrIdType (RMR-1003).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "rmr", FieldCode = "RMR-1003")]
	public class RmrIdTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "rmr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "RMR-1003";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "rmr", Description = "PBC", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "rmr", Description = "PBC", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "rmr", Description = "PBC", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "rmr", Description = "CPT", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "rmr", Description = "CPT", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "rmr", Description = "CPT", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "rmr", Description = "PDR", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "rmr", Description = "PDR", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "rmr", Description = "PDR", FieldCode = "RMR-1003", FieldName = "RmrIdType" });
		}
	}
}