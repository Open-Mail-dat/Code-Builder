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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property MoveUpdateMethod (PDR-1127).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "pdr", FieldCode = "PDR-1127")]
	public class MoveUpdateMethods : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "pdr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "PDR-1127";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "0", FileExtension = "pdr", Description = "None", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "0", FileExtension = "pdr", Description = "None", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "0", FileExtension = "pdr", Description = "None", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "1", FileExtension = "pdr", Description = "ACS", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "1", FileExtension = "pdr", Description = "ACS", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1", FileExtension = "pdr", Description = "ACS", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "2", FileExtension = "pdr", Description = "NCOALink", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "2", FileExtension = "pdr", Description = "NCOALink", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "2", FileExtension = "pdr", Description = "NCOALink", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "4", FileExtension = "pdr", Description = "Mailer Move Update Process Certification/Alternative method( 99% rule, legal restraint, 100% newly acquired from addressee)", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4", FileExtension = "pdr", Description = "Mailer Move Update Process Certification/Alternative method( 99% rule, legal restraint, 100% newly acquired from addressee)", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4", FileExtension = "pdr", Description = "Mailer Move Update Process Certification/Alternative method( 99% rule, legal restraint, 100% newly acquired from addressee)", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "5", FileExtension = "pdr", Description = "Ancillary Service Endorsements", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "5", FileExtension = "pdr", Description = "Ancillary Service Endorsements", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "5", FileExtension = "pdr", Description = "Ancillary Service Endorsements", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "6", FileExtension = "pdr", Description = "Multiple", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "6", FileExtension = "pdr", Description = "Multiple", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "6", FileExtension = "pdr", Description = "Multiple", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "7", FileExtension = "pdr", Description = "Simplified/Occupant/Exceptional/Alternative Address Format - No move update method needed for this code", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "7", FileExtension = "pdr", Description = "Simplified/Occupant/Exceptional/Alternative Address Format - No move update method needed for this code", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "7", FileExtension = "pdr", Description = "Simplified/Occupant/Exceptional/Alternative Address Format - No move update method needed for this code", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "8", FileExtension = "pdr", Description = "OneCode ACS™", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "8", FileExtension = "pdr", Description = "OneCode ACS™", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "8", FileExtension = "pdr", Description = "OneCode ACS™", FieldCode = "PDR-1127", FieldName = "MoveUpdateMethod" });
		}
	}
}