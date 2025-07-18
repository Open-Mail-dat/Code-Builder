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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property ClassOfMail (CBR-1102).
	/// </summary>
	[MaildatVersions("24-1", "25-1")]
	[MaildatFieldLink(File = "cbr", FieldCode = "CBR-1102")]
	public class ClassOfMails : MaildatValues 
	{
		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cbr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CBR-1102";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "24-1", Key = "1", FileExtension = "cbr", Description = "First Class", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1", FileExtension = "cbr", Description = "First Class", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "3", FileExtension = "cbr", Description = "Std Mail", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "3", FileExtension = "cbr", Description = "Std Mail", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4", FileExtension = "cbr", Description = "Pkg Services", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4", FileExtension = "cbr", Description = "Pkg Services", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "9", FileExtension = "cbr", Description = "Other", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "9", FileExtension = "cbr", Description = "Other", FieldCode = "CBR-1102", FieldName = "ClassOfMail" });
		}
	}
}