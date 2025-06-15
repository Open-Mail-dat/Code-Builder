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
	/// These are the allowed values for the property MailPieceUnitClass (MPU-1111).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpu", FieldCode = "MPU-1111")]
	public class MailPieceUnitClasses : MaildatValues 
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
			return "MPU-1111";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "1", FileExtension = "mpu", Description = "First Class", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "1", FileExtension = "mpu", Description = "First Class", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1", FileExtension = "mpu", Description = "First Class", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "2", FileExtension = "mpu", Description = "Periodicals", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "2", FileExtension = "mpu", Description = "Periodicals", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "2", FileExtension = "mpu", Description = "Periodicals", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "3", FileExtension = "mpu", Description = "Std Mail", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "3", FileExtension = "mpu", Description = "Std Mail", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "3", FileExtension = "mpu", Description = "Std Mail", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "4", FileExtension = "mpu", Description = "Pkg Services", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4", FileExtension = "mpu", Description = "Pkg Services", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4", FileExtension = "mpu", Description = "Pkg Services", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "5", FileExtension = "mpu", Description = "Per Pending", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "5", FileExtension = "mpu", Description = "Per Pending", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "5", FileExtension = "mpu", Description = "Per Pending", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "9", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "9", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "9", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1111", FieldName = "MailPieceUnitClass" });
		}
	}
}