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