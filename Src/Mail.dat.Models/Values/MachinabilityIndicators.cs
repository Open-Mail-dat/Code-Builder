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
	/// These are the allowed values for the property MachinabilityIndicator (MPU-1123).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpu", FieldCode = "MPU-1123")]
	public class MachinabilityIndicators : MaildatValues 
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
			return "MPU-1123";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "mpu", Description = "Not Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "mpu", Description = "Not Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "mpu", Description = "Not Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "mpu", Description = "Flat Machinable on UFSM 1000", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "mpu", Description = "Flat Machinable on UFSM 1000", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "mpu", Description = "Flat Machinable on UFSM 1000", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Y", FileExtension = "mpu", Description = "Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Y", FileExtension = "mpu", Description = "Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Y", FileExtension = "mpu", Description = "Machinable", FieldCode = "MPU-1123", FieldName = "MachinabilityIndicator" });
		}
	}
}