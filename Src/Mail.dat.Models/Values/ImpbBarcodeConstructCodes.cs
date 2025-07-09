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
	/// These are the allowed values for the property ImpbBarcodeConstructCode (SFB-1005).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "sfb", FieldCode = "SFB-1005")]
	public class ImpbBarcodeConstructCodes : MaildatValues 
	{
		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "sfb";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "SFB-1005";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = " ", FileExtension = "sfb", Description = "Not Applicable", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = " ", FileExtension = "sfb", Description = "Not Applicable", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = " ", FileExtension = "sfb", Description = "Not Applicable", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "sfb", Description = "C01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "sfb", Description = "C01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "sfb", Description = "C01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "sfb", Description = "C02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "sfb", Description = "C02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "sfb", Description = "C02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "sfb", Description = "C03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "sfb", Description = "C03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "sfb", Description = "C03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "sfb", Description = "C04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "sfb", Description = "C04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "sfb", Description = "C04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "sfb", Description = "C05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "sfb", Description = "C05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "sfb", Description = "C05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "sfb", Description = "C06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "sfb", Description = "C06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "sfb", Description = "C06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "sfb", Description = "C07", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "sfb", Description = "C07", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "sfb", Description = "C07", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "sfb", Description = "C08", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "sfb", Description = "C08", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "sfb", Description = "C08", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "sfb", Description = "C09", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "sfb", Description = "C09", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "sfb", Description = "C09", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "sfb", Description = "C10", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "sfb", Description = "C10", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "sfb", Description = "C10", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "sfb", Description = "N01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "sfb", Description = "N01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "sfb", Description = "N01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "sfb", Description = "N02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "sfb", Description = "N02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "sfb", Description = "N02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "sfb", Description = "N03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "sfb", Description = "N03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "sfb", Description = "N03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "sfb", Description = "N04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "sfb", Description = "N04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "sfb", Description = "N04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "sfb", Description = "N05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "sfb", Description = "N05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "sfb", Description = "N05", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "sfb", Description = "N06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P", FileExtension = "sfb", Description = "N06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P", FileExtension = "sfb", Description = "N06", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Q", FileExtension = "sfb", Description = "L01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Q", FileExtension = "sfb", Description = "L01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Q", FileExtension = "sfb", Description = "L01", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "sfb", Description = "L02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "sfb", Description = "L02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "sfb", Description = "L02", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "sfb", Description = "L03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "sfb", Description = "L03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "sfb", Description = "L03", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "sfb", Description = "L04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "sfb", Description = "L04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "sfb", Description = "L04", FieldCode = "SFB-1005", FieldName = "ImpbBarcodeConstructCode" });
		}
	}
}