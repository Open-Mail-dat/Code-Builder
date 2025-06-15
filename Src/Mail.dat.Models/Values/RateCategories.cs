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
	/// These are the allowed values for the property RateCategory (CQT-1008).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "cqt", FieldCode = "CQT-1008")]
	public class RateCategories : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cqt";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CQT-1008";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "cqt", Description = "Saturation - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "cqt", Description = "Saturation - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "cqt", Description = "Saturation - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A1", FileExtension = "cqt", Description = "Non-Automation Saturation - ECR (Standard Mail, also used for EDDM Simplified Address)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A1", FileExtension = "cqt", Description = "Non-Automation Saturation - ECR (Standard Mail, also used for EDDM Simplified Address)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A1", FileExtension = "cqt", Description = "Non-Automation Saturation - ECR (Standard Mail, also used for EDDM Simplified Address)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "cqt", Description = "High Density - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "cqt", Description = "High Density - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "cqt", Description = "High Density - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B1", FileExtension = "cqt", Description = "Non Automation High Density - ECR (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B1", FileExtension = "cqt", Description = "Non Automation High Density - ECR (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B1", FileExtension = "cqt", Description = "Non Automation High Density - ECR (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "cqt", Description = "High Density Plus - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "cqt", Description = "High Density Plus - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "cqt", Description = "High Density Plus - ECR", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C1", FileExtension = "cqt", Description = "Non Automation High Density Plus - ECR (Standard Mail Letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C1", FileExtension = "cqt", Description = "Non Automation High Density Plus - ECR (Standard Mail Letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C1", FileExtension = "cqt", Description = "Non Automation High Density Plus - ECR (Standard Mail Letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "cqt", Description = "Carrier Route", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "cqt", Description = "Carrier Route", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "cqt", Description = "Carrier Route", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D1", FileExtension = "cqt", Description = "Non Automation Basic - Carrier Route (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D1", FileExtension = "cqt", Description = "Non Automation Basic - Carrier Route (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D1", FileExtension = "cqt", Description = "Non Automation Basic - Carrier Route (Standard mail letters)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "cqt", Description = "5 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "cqt", Description = "5 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "cqt", Description = "5 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FB", FileExtension = "cqt", Description = "Firm Bundle (Not In-County)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FB", FileExtension = "cqt", Description = "Firm Bundle (Not In-County)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FB", FileExtension = "cqt", Description = "Firm Bundle (Not In-County)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FC", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FC", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FC", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FF", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FF", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FF", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FG", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FG", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FG", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FH", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FH", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FH", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FI", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FI", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FI", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FJ", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FJ", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FJ", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FN", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FN", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FN", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FS", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FS", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FS", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "cqt", Description = "5-Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "cqt", Description = "5-Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "cqt", Description = "5-Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "cqt", Description = "3 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "cqt", Description = "3 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "cqt", Description = "3 Digit Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "cqt", Description = "3 Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "cqt", Description = "3 Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "cqt", Description = "3 Digit", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "cqt", Description = "Basic Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "cqt", Description = "Basic Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "cqt", Description = "Basic Barcode", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L1", FileExtension = "cqt", Description = "AADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L1", FileExtension = "cqt", Description = "AADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L1", FileExtension = "cqt", Description = "AADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L2", FileExtension = "cqt", Description = "MxAADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L2", FileExtension = "cqt", Description = "MxAADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L2", FileExtension = "cqt", Description = "MxAADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L3", FileExtension = "cqt", Description = "ADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L3", FileExtension = "cqt", Description = "ADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L3", FileExtension = "cqt", Description = "ADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L4", FileExtension = "cqt", Description = "MxADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L4", FileExtension = "cqt", Description = "MxADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L4", FileExtension = "cqt", Description = "MxADC BC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L5", FileExtension = "cqt", Description = "ADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L5", FileExtension = "cqt", Description = "ADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L5", FileExtension = "cqt", Description = "ADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L6", FileExtension = "cqt", Description = "MxADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L6", FileExtension = "cqt", Description = "MxADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L6", FileExtension = "cqt", Description = "MxADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L7", FileExtension = "cqt", Description = "AADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L7", FileExtension = "cqt", Description = "AADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L7", FileExtension = "cqt", Description = "AADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L8", FileExtension = "cqt", Description = "MxAADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L8", FileExtension = "cqt", Description = "MxAADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L8", FileExtension = "cqt", Description = "MxAADC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "cqt", Description = "Presort (1C, 4C); In County Basic (2C); Custom Market Mail (3C)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "cqt", Description = "Presort (1C, 4C); In County Basic (2C); Custom Market Mail (3C)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "cqt", Description = "Presort (1C, 4C); In County Basic (2C); Custom Market Mail (3C)", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P7", FileExtension = "cqt", Description = "NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P7", FileExtension = "cqt", Description = "NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P7", FileExtension = "cqt", Description = "NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P8", FileExtension = "cqt", Description = "Mixed NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P8", FileExtension = "cqt", Description = "Mixed NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P8", FileExtension = "cqt", Description = "Mixed NDC", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PM", FileExtension = "cqt", Description = "SCF", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PM", FileExtension = "cqt", Description = "SCF", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PM", FileExtension = "cqt", Description = "SCF", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PO", FileExtension = "cqt", Description = "Plus One", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PO", FileExtension = "cqt", Description = "Plus One", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PO", FileExtension = "cqt", Description = "Plus One", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "cqt", Description = "Single Piece", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "cqt", Description = "Single Piece", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "cqt", Description = "Single Piece", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "SD", FileExtension = "cqt", Description = "Single-Piece/Does not meet content standards", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "SD", FileExtension = "cqt", Description = "Single-Piece/Does not meet content standards", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "SD", FileExtension = "cqt", Description = "Single-Piece/Does not meet content standards", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "cqt", Description = "Other", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "cqt", Description = "Other", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "cqt", Description = "Other", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z", FileExtension = "cqt", Description = "Reserved", FieldCode = "CQT-1008", FieldName = "RateCategory" });
		}
	}
}