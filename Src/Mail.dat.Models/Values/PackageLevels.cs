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
// This code was auto-generated on July 8th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property PackageLevel (PQT-1102).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "pqt", FieldCode = "PQT-1102")]
	public class PackageLevels : MaildatValues 
	{
		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "pqt";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "PQT-1102";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "9", FileExtension = "pqt", Description = "Other", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "9", FileExtension = "pqt", Description = "Other", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "9", FileExtension = "pqt", Description = "Other", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "pqt", Description = "Firm", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "pqt", Description = "Firm", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "pqt", Description = "Firm", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "pqt", Description = "Carrier Route", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "pqt", Description = "Carrier Route", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "pqt", Description = "Carrier Route", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "pqt", Description = "5 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "pqt", Description = "5 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "pqt", Description = "5 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "pqt", Description = "Unique 3-Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "pqt", Description = "Unique 3-Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "pqt", Description = "Unique 3-Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "pqt", Description = "3 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "pqt", Description = "3 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "pqt", Description = "3 Digit", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "pqt", Description = "ADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "pqt", Description = "ADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "pqt", Description = "ADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "pqt", Description = "AADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "pqt", Description = "AADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "pqt", Description = "AADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "pqt", Description = "Origin MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "pqt", Description = "Origin MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "pqt", Description = "Origin MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "pqt", Description = "MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "pqt", Description = "MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "pqt", Description = "MxADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "pqt", Description = "MxAADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "pqt", Description = "MxAADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "pqt", Description = "MxAADC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "pqt", Description = "Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "pqt", Description = "Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "pqt", Description = "Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "pqt", Description = "Multi-pc Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "pqt", Description = "Multi-pc Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "pqt", Description = "Multi-pc Parcel", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "pqt", Description = "3-D Scheme", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "pqt", Description = "3-D Scheme", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "pqt", Description = "3-D Scheme", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "pqt", Description = "5-D Scheme + L007", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "pqt", Description = "5-D Scheme + L007", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "pqt", Description = "5-D Scheme + L007", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "V", FileExtension = "pqt", Description = "NDC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "V", FileExtension = "pqt", Description = "NDC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "V", FileExtension = "pqt", Description = "NDC", FieldCode = "PQT-1102", FieldName = "PackageLevel" });
		}
	}
}