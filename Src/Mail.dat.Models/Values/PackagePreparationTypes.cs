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
	/// These are the allowed values for the property PackagePreparationType (PQT-1115).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "pqt", FieldCode = "PQT-1115")]
	public class PackagePreparationTypes : MaildatValues 
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
			return "PQT-1115";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "pqt", Description = "Not Applicable", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "pqt", Description = "Not Applicable", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "pqt", Description = "Loose", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "pqt", Description = "Loose", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "pqt", Description = "Package/Bundle", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "pqt", Description = "Package/Bundle", FieldCode = "PQT-1115", FieldName = "PackagePreparationType" });
		}
	}
}