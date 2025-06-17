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
	/// These are the allowed values for the property ContainerLevel (CSM-1104).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "csm", FieldCode = "CSM-1104")]
	public class ContainerLevels : MaildatValues 
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
			return "CSM-1104";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "csm", Description = "CR-Direct (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "csm", Description = "CR-Direct (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "csm", Description = "CR-Direct (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AA", FileExtension = "csm", Description = "AADC (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AA", FileExtension = "csm", Description = "AADC (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AA", FileExtension = "csm", Description = "AADC (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AB", FileExtension = "csm", Description = "Mixed ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AB", FileExtension = "csm", Description = "Mixed ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AB", FileExtension = "csm", Description = "Mixed ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AC", FileExtension = "csm", Description = "Mixed AADC (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AC", FileExtension = "csm", Description = "Mixed AADC (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AC", FileExtension = "csm", Description = "Mixed AADC (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AD", FileExtension = "csm", Description = "ASF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AD", FileExtension = "csm", Description = "ASF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AD", FileExtension = "csm", Description = "ASF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AE", FileExtension = "csm", Description = "NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AE", FileExtension = "csm", Description = "NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AE", FileExtension = "csm", Description = "NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AF", FileExtension = "csm", Description = "Protected NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AF", FileExtension = "csm", Description = "Protected NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AF", FileExtension = "csm", Description = "Protected NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AG", FileExtension = "csm", Description = "Mixed NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AG", FileExtension = "csm", Description = "Mixed NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AG", FileExtension = "csm", Description = "Mixed NDC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AH", FileExtension = "csm", Description = "Origin MxADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AH", FileExtension = "csm", Description = "Origin MxADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AH", FileExtension = "csm", Description = "Origin MxADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AI", FileExtension = "csm", Description = "Protected ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AI", FileExtension = "csm", Description = "Protected ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AI", FileExtension = "csm", Description = "Protected ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AJ", FileExtension = "csm", Description = "Single Piece (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AJ", FileExtension = "csm", Description = "Single Piece (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AJ", FileExtension = "csm", Description = "Single Piece (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AK", FileExtension = "csm", Description = "MXDS - Mixed Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AK", FileExtension = "csm", Description = "MXDS - Mixed Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AK", FileExtension = "csm", Description = "MXDS - Mixed Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AL", FileExtension = "csm", Description = "MXDA - Mixed Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AL", FileExtension = "csm", Description = "MXDA - Mixed Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AL", FileExtension = "csm", Description = "MXDA - Mixed Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AM", FileExtension = "csm", Description = "Working CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AM", FileExtension = "csm", Description = "Working CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AM", FileExtension = "csm", Description = "Working CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AN", FileExtension = "csm", Description = "Single Piece CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AN", FileExtension = "csm", Description = "Single Piece CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AN", FileExtension = "csm", Description = "Single Piece CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AO", FileExtension = "csm", Description = "Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AO", FileExtension = "csm", Description = "Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AO", FileExtension = "csm", Description = "Surface CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AP", FileExtension = "csm", Description = "Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AP", FileExtension = "csm", Description = "Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AP", FileExtension = "csm", Description = "Air CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AQ", FileExtension = "csm", Description = "Local CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AQ", FileExtension = "csm", Description = "Local CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AQ", FileExtension = "csm", Description = "Local CSA FCM Only (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AR", FileExtension = "csm", Description = "Origin SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AR", FileExtension = "csm", Description = "Origin SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AR", FileExtension = "csm", Description = "Origin SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AS", FileExtension = "csm", Description = "Origin Mixed ADC Surface (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AS", FileExtension = "csm", Description = "Origin Mixed ADC Surface (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AS", FileExtension = "csm", Description = "Origin Mixed ADC Surface (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AT", FileExtension = "csm", Description = "Mixed ADC Air (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AT", FileExtension = "csm", Description = "Mixed ADC Air (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AT", FileExtension = "csm", Description = "Mixed ADC Air (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AU", FileExtension = "csm", Description = "Protected Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AU", FileExtension = "csm", Description = "Protected Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AU", FileExtension = "csm", Description = "Protected Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AV", FileExtension = "csm", Description = "Protected Mixed NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AV", FileExtension = "csm", Description = "Protected Mixed NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AV", FileExtension = "csm", Description = "Protected Mixed NDC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AW", FileExtension = "csm", Description = "Protected Origin Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AW", FileExtension = "csm", Description = "Protected Origin Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "AW", FileExtension = "csm", Description = "Protected Origin Mixed ADC (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "csm", Description = "Mixed CR in 5 Digit (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "csm", Description = "Mixed CR in 5 Digit (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "csm", Description = "Mixed CR in 5 Digit (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "csm", Description = "Mixed CR in 3 Digit (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "csm", Description = "Mixed CR in 3 Digit (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "csm", Description = "Mixed CR in 3 Digit (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "csm", Description = "CR - 5D Scheme (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "csm", Description = "CR - 5D Scheme (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "csm", Description = "CR - 5D Scheme (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "csm", Description = "5 Digit (Auto/Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "csm", Description = "5 Digit (Auto/Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "csm", Description = "5 Digit (Auto/Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "csm", Description = "5 Digit (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "csm", Description = "5 Digit (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "csm", Description = "5 Digit (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "csm", Description = "5 Digit (Presort Only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "csm", Description = "5 Digit (Presort Only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "csm", Description = "5 Digit (Presort Only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "csm", Description = "5 Digit (Barcode only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "csm", Description = "5 Digit (Barcode only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "csm", Description = "5 Digit (Barcode only) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "csm", Description = "Metro Scheme (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "csm", Description = "5D Scheme (Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "csm", Description = "5D Scheme (Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "csm", Description = "5D Scheme (Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "csm", Description = "5D Scheme (Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "csm", Description = "5D Scheme (Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "csm", Description = "5D Scheme (Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "csm", Description = "Other (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "csm", Description = "Other (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "csm", Description = "Other (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "csm", Description = "5D Scheme (Barcode) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "csm", Description = "5D Scheme (Barcode) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "csm", Description = "5D Scheme (Barcode) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Q", FileExtension = "csm", Description = "5D Scheme (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Q", FileExtension = "csm", Description = "5D Scheme (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Q", FileExtension = "csm", Description = "5D Scheme (Merged) (T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "csm", Description = "3 Digit (Auto, Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "csm", Description = "3 Digit (Auto, Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "csm", Description = "3 Digit (Auto, Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "csm", Description = "3 Digit (Barcode) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "csm", Description = "3 Digit (Barcode) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "csm", Description = "3 Digit (Barcode) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "csm", Description = "3 Digit (Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "csm", Description = "3 Digit (Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "csm", Description = "3 Digit (Presort) (S, T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "csm", Description = "3 Digit (CR, Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "csm", Description = "3 Digit (CR, Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "csm", Description = "3 Digit (CR, Auto, Presort) (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "V", FileExtension = "csm", Description = "3 Digit Scheme (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "V", FileExtension = "csm", Description = "3 Digit Scheme (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "V", FileExtension = "csm", Description = "3 Digit Scheme (T)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "csm", Description = "SCF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "csm", Description = "SCF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "csm", Description = "SCF (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Y", FileExtension = "csm", Description = "Protected SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Y", FileExtension = "csm", Description = "Protected SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Y", FileExtension = "csm", Description = "Protected SCF (P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z", FileExtension = "csm", Description = "ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z", FileExtension = "csm", Description = "ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z", FileExtension = "csm", Description = "ADC (S, T, P)", FieldCode = "CSM-1104", FieldName = "ContainerLevel" });
		}
	}
}