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
	/// These are the allowed values for the property EntryPointForEntryDiscountFacilityType (CSM-1106).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "csm", FieldCode = "CSM-1106")]
	public class EntryPointForEntryDiscountFacilityTypes : MaildatValues 
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
			return "CSM-1106";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "csm", Description = "ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "csm", Description = "ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "csm", Description = "ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "csm", Description = "DNDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "csm", Description = "DNDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "csm", Description = "DNDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "csm", Description = "Origin SCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "csm", Description = "Origin SCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "csm", Description = "Origin SCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "csm", Description = "DDU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "csm", Description = "DDU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "csm", Description = "DDU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "csm", Description = "Origin DU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "csm", Description = "Origin DU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "csm", Description = "Origin DU", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "csm", Description = "Tran Hub", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "csm", Description = "Tran Hub", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "csm", Description = "Tran Hub", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "csm", Description = "Origin ADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "csm", Description = "Origin ADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "csm", Description = "Origin ADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "csm", Description = "Origin NDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "csm", Description = "Origin NDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "csm", Description = "Origin NDC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "csm", Description = "Origin ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "csm", Description = "Origin ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "csm", Description = "Origin ASF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "csm", Description = "Not-determined", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "csm", Description = "Not-determined", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "csm", Description = "Not-determined", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "csm", Description = "Origin", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "csm", Description = "Origin", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "csm", Description = "Origin", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "OT", FileExtension = "csm", Description = "Other", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "OT", FileExtension = "csm", Description = "Other", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "OT", FileExtension = "csm", Description = "Other", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Q", FileExtension = "csm", Description = "Origin AMF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Q", FileExtension = "csm", Description = "Origin AMF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Q", FileExtension = "csm", Description = "Origin AMF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "csm", Description = "DADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "csm", Description = "DADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "csm", Description = "DADC", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "csm", Description = "DSCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "csm", Description = "DSCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "csm", Description = "DSCF", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "csm", Description = "Orig(T-Hub Sq)", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "csm", Description = "Orig(T-Hub Sq)", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "csm", Description = "Orig(T-Hub Sq)", FieldCode = "CSM-1106", FieldName = "EntryPointForEntryDiscountFacilityType" });
		}
	}
}