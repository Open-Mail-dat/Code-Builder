//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
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