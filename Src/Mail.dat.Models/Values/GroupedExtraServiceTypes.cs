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
	/// These are the allowed values for the property GroupedExtraServiceType (MPU-1133).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpu", FieldCode = "MPU-1133")]
	public class GroupedExtraServiceTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "mpu";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "MPU-1133";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "mpu", Description = "Not Specified", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "mpu", Description = "Not Specified", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "mpu", Description = "Not Specified", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "mpu", Description = "Certificate of Bulk Mailing (3606-D)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "mpu", Description = "Certificate of Bulk Mailing (3606-D)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "mpu", Description = "Certificate of Bulk Mailing (3606-D)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "mpu", Description = "Certificate of Mailing Firm Book (3665)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "mpu", Description = "Certificate of Mailing Firm Book (3665)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "mpu", Description = "Certificate of Mailing Firm Book (3665)", FieldCode = "MPU-1133", FieldName = "GroupedExtraServiceType" });
		}
	}
}