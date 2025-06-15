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
	/// These are the allowed values for the property ContainerType (CSM-1005).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "csm", FieldCode = "CSM-1005")]
	public class ContainerTypes : MaildatValues 
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
			return "CSM-1005";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "1", FileExtension = "csm", Description = "#1 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "1", FileExtension = "csm", Description = "#1 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1", FileExtension = "csm", Description = "#1 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "2", FileExtension = "csm", Description = "#2 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "2", FileExtension = "csm", Description = "#2 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "2", FileExtension = "csm", Description = "#2 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "3", FileExtension = "csm", Description = "#3 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "3", FileExtension = "csm", Description = "#3 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "3", FileExtension = "csm", Description = "#3 Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "4", FileExtension = "csm", Description = "01V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4", FileExtension = "csm", Description = "01V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4", FileExtension = "csm", Description = "01V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "5", FileExtension = "csm", Description = "03V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "5", FileExtension = "csm", Description = "03V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "5", FileExtension = "csm", Description = "03V Sack", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "csm", Description = "EIRS 61P - Hamper, Large Plastic", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "csm", Description = "EIRS 61P - Hamper, Large Plastic", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "csm", Description = "EIRS 61P - Hamper, Large Plastic", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AB", FileExtension = "csm", Description = "Air Box", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AB", FileExtension = "csm", Description = "Air Box", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AB", FileExtension = "csm", Description = "Air Box", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "csm", Description = "Bedload", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "csm", Description = "Bedload", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "csm", Description = "Bedload", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "csm", Description = "EIRS 84C - Collapsible Wire Container", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "csm", Description = "EIRS 84C - Collapsible Wire Container", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "csm", Description = "EIRS 84C - Collapsible Wire Container", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CT", FileExtension = "csm", Description = "Carton", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CT", FileExtension = "csm", Description = "Carton", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CT", FileExtension = "csm", Description = "Carton", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "csm", Description = "EIRS 68 - Eastern Region Mail Container w/Web Door", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "csm", Description = "EIRS 68 - Eastern Region Mail Container w/Web Door", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "csm", Description = "EIRS 68 - Eastern Region Mail Container w/Web Door", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "csm", Description = "EMM Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "csm", Description = "EMM Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "csm", Description = "EMM Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "csm", Description = "Flat Tub", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "csm", Description = "Flat Tub", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "csm", Description = "Flat Tub", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "csm", Description = "EIRS 66 - General Purpose Mail Container w/Gate", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "csm", Description = "EIRS 66 - General Purpose Mail Container w/Gate", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "csm", Description = "EIRS 66 - General Purpose Mail Container w/Gate", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "csm", Description = "EIRS 61 - Hamper, Large Canvas", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "csm", Description = "EIRS 61 - Hamper, Large Canvas", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "csm", Description = "EIRS 61 - Hamper, Large Canvas", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "csm", Description = "Logical Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "csm", Description = "Logical Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "csm", Description = "Logical Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "csm", Description = "Logical Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "csm", Description = "Logical Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "csm", Description = "Logical Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "csm", Description = "1' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "csm", Description = "1' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "csm", Description = "1' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "csm", Description = "Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "csm", Description = "Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "csm", Description = "Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "csm", Description = "EIRS 84 - Wire Container Rigid", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "csm", Description = "EIRS 84 - Wire Container Rigid", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "csm", Description = "EIRS 84 - Wire Container Rigid", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "csm", Description = "Sack (general)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "csm", Description = "Sack (general)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "csm", Description = "Sack (general)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "csm", Description = "2' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "csm", Description = "2' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "csm", Description = "2' Tray", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "csm", Description = "Unit Load Device", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "csm", Description = "Unit Load Device", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "csm", Description = "Unit Load Device", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "V", FileExtension = "csm", Description = "Sack (Virtual)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "V", FileExtension = "csm", Description = "Sack (Virtual)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "V", FileExtension = "csm", Description = "Sack (Virtual)", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "W", FileExtension = "csm", Description = "Walled Unit", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "W", FileExtension = "csm", Description = "Walled Unit", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "W", FileExtension = "csm", Description = "Walled Unit", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z", FileExtension = "csm", Description = "User Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z", FileExtension = "csm", Description = "User Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z", FileExtension = "csm", Description = "User Pallet", FieldCode = "CSM-1005", FieldName = "ContainerType" });
		}
	}
}