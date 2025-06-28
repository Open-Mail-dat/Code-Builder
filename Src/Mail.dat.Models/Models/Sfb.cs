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
// This code was auto-generated on June 28th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Barcode for special services. Provides barcode for special fees.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "sfb", File = "Special Barcode Record", Summary = "Barcode for special services.", Description = "Barcode for special services. Provides barcode for special fees.", LineLength = 68, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "sfb", File = "Special Barcode Record", Summary = "Barcode for special services.", Description = "Barcode for special services. Provides barcode for special fees.", LineLength = 68, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "sfb", File = "Special Barcode Record", Summary = "Barcode for special services.", Description = "Barcode for special services. Provides barcode for special fees.", LineLength = 68, ClosingCharacter = "#")]
	[MaildatImport(Order = 17, Version = "23-1")]
	[MaildatImport(Order = 17, Version = "24-1")]
	[MaildatImport(Order = 17, Version = "25-1")]
	[Table("Sfb", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Sfb : MaildatEntity, ISfb 
	{
		/// <summary>
		/// Job ID (SFB-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("SFB-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Piece ID (SFB-1018)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("SFB-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// Barcode Type (SFB-1004)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-1004", FieldName = "Barcode Type", Start = 31, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-1004", FieldName = "Barcode Type", Start = 31, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-1004", FieldName = "Barcode Type", Start = 31, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("E", "F")]
		[Comment("SFB-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(BarcodeTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string BarcodeType { get; set; }

		/// <summary>
		/// Barcode (SFB-1003)
		/// IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode
		/// (IMb® or IMpb®) that has been added to the piece.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-1003", FieldName = "Barcode", Start = 32, Length = 34, Required = true, Key = false, DataType = "A/N", Description = "IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode (IMb® or IMpb®) that has been added to the piece.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-1003", FieldName = "Barcode", Start = 32, Length = 34, Required = true, Key = false, DataType = "A/N", Description = "IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode (IMb® or IMpb®) that has been added to the piece.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-1003", FieldName = "Barcode", Start = 32, Length = 34, Required = true, Key = false, DataType = "A/N", Description = "IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode (IMb® or IMpb®) that has been added to the piece.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(34)]
		[Comment("SFB-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Barcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (SFB-1005)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-1005", FieldName = "IMpb® Barcode Construct Code", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-1005", FieldName = "IMpb® Barcode Construct Code", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-1005", FieldName = "IMpb® Barcode Construct Code", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("ImpbBarcodeConstructCode", Order = 6, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("SFB-1005")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ImpbBarcodeConstructCodes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// SFB Record Status (SFB-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-2000", FieldName = "SFB Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-2000", FieldName = "SFB Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-2000", FieldName = "SFB Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("SfbRecordStatus", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("SFB-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SfbRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SfbRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (SFB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "sfb", FieldCode = "SFB-9999", FieldName = "Closing Character", Start = 68, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "sfb", FieldCode = "SFB-9999", FieldName = "Closing Character", Start = 68, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "sfb", FieldCode = "SFB-9999", FieldName = "Closing Character", Start = 68, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("SFB-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Sfb, string>(version, p => p.JobId, returnValue);
			this.PieceId = line.ParseForImport<Sfb, string>(version, p => p.PieceId, returnValue);
			this.BarcodeType = line.ParseForImport<Sfb, string>(version, p => p.BarcodeType, returnValue);
			this.Barcode = line.ParseForImport<Sfb, string>(version, p => p.Barcode, returnValue);
			this.ImpbBarcodeConstructCode = line.ParseForImport<Sfb, string>(version, p => p.ImpbBarcodeConstructCode, returnValue);
			this.SfbRecordStatus = line.ParseForImport<Sfb, string>(version, p => p.SfbRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Sfb, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Sfb, string>(version, p => p.JobId));
			sb.Append(this.PieceId.FormatForExport<Sfb, string>(version, p => p.PieceId));
			sb.Append(this.BarcodeType.FormatForExport<Sfb, string>(version, p => p.BarcodeType));
			sb.Append(this.Barcode.FormatForExport<Sfb, string>(version, p => p.Barcode));
			sb.Append(this.ImpbBarcodeConstructCode.FormatForExport<Sfb, string>(version, p => p.ImpbBarcodeConstructCode));
			sb.Append(this.SfbRecordStatus.FormatForExport<Sfb, string>(version, p => p.SfbRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Sfb, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}