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
	/// These are the allowed values for the property MailPieceUnitProcessingCategory (MPU-1113).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpu", FieldCode = "MPU-1113")]
	public class MailPieceUnitProcessingCategories : MaildatValues 
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
			return "MPU-1113";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "CD", FileExtension = "mpu", Description = "Card", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CD", FileExtension = "mpu", Description = "Card", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CD", FileExtension = "mpu", Description = "Card", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CM", FileExtension = "mpu", Description = "Custom Mail", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CM", FileExtension = "mpu", Description = "Custom Mail", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CM", FileExtension = "mpu", Description = "Custom Mail", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FL", FileExtension = "mpu", Description = "Flat", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FL", FileExtension = "mpu", Description = "Flat", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FL", FileExtension = "mpu", Description = "Flat", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "IR", FileExtension = "mpu", Description = "Nonstandard Parcels", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "IR", FileExtension = "mpu", Description = "Nonstandard Parcels", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "IR", FileExtension = "mpu", Description = "Nonstandard Parcels", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "LT", FileExtension = "mpu", Description = "Letter", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "LT", FileExtension = "mpu", Description = "Letter", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "LT", FileExtension = "mpu", Description = "Letter", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MP", FileExtension = "mpu", Description = "Machinable Parcel", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MP", FileExtension = "mpu", Description = "Machinable Parcel", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "MP", FileExtension = "mpu", Description = "Machinable Parcel", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "NP", FileExtension = "mpu", Description = "Reserve", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "NP", FileExtension = "mpu", Description = "Reserve", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PF", FileExtension = "mpu", Description = "Parcel, First Class", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PF", FileExtension = "mpu", Description = "Parcel, First Class", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PF", FileExtension = "mpu", Description = "Parcel, First Class", FieldCode = "MPU-1113", FieldName = "MailPieceUnitProcessingCategory" });
		}
	}
}