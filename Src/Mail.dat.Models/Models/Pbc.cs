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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
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
	/// Piece barcode details. Provides piece level detail required of full service mailings; when used
	/// instead of the Piece Detail file, acts as an extension of the PQT file.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "pbc", File = "Piece Barcode Record", Summary = "Piece barcode details.", Description = "Piece barcode details. Provides piece level detail required of full service mailings; when used instead of the Piece Detail file, acts as an extension of the PQT file.", LineLength = 70, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "pbc", File = "Piece Barcode Record", Summary = "Piece barcode details.", Description = "Piece barcode details. Provides piece level detail required of full service mailings; when used instead of the Piece Detail file, acts as an extension of the PQT file.", LineLength = 70, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "pbc", File = "Piece Barcode Record", Summary = "Piece barcode details.", Description = "Piece barcode details. Provides piece level detail required of full service mailings; when used instead of the Piece Detail file, acts as an extension of the PQT file.", LineLength = 70, ClosingCharacter = "#")]
	[MaildatImport(Order = 15, Version = "23-1")]
	[MaildatImport(Order = 15, Version = "24-1")]
	[MaildatImport(Order = 15, Version = "25-1")]
	[Table("Pbc", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Pbc : MaildatEntity, IPbc 
	{
		/// <summary>
		/// Job ID (PBC-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PBC-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// PBC Unique ID (PBC-1002)
		/// Uniquely identifies each PBC record.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1002", FieldName = "PBC Unique ID", Start = 9, Length = 9, Required = true, Key = true, DataType = "N", Description = "Uniquely identifies each PBC record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1002", FieldName = "PBC Unique ID", Start = 9, Length = 9, Required = true, Key = true, DataType = "N", Description = "Uniquely identifies each PBC record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1002", FieldName = "PBC Unique ID", Start = 9, Length = 9, Required = true, Key = true, DataType = "N", Description = "Uniquely identifies each PBC record.", Type = "integer", Format = "zfill")]
		[Column("PbcUniqueId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PBC-1002")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int PbcUniqueId { get; set; }

		/// <summary>
		/// CQT Database ID (PBC-1034)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1034", FieldName = "CQT Database ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1034", FieldName = "CQT Database ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1034", FieldName = "CQT Database ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("PBC-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Package ID (PBC-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1012", FieldName = "Package ID", Start = 26, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1012", FieldName = "Package ID", Start = 26, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1012", FieldName = "Package ID", Start = 26, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[Column("PackageId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PBC-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageId { get; set; }

		/// <summary>
		/// Barcode (PBC-1122)
		/// IMb® or IMpb®.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1122", FieldName = "Barcode", Start = 32, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "IMb® or IMpb®.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1122", FieldName = "Barcode", Start = 32, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "IMb® or IMpb®.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1122", FieldName = "Barcode", Start = 32, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "IMb® or IMpb®.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 6, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("PBC-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Barcode { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PBC-1117)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 7, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "S", "T", "W", "X")]
		[Comment("PBC-1117")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(WastedOrShortagePieceIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PBC-1118)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1118", FieldName = "IMpb® Barcode Construct Code", Start = 67, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1118", FieldName = "IMpb® Barcode Construct Code", Start = 67, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1118", FieldName = "IMpb® Barcode Construct Code", Start = 67, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("ImpbBarcodeConstructCode", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("PBC-1118")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ImpbBarcodeConstructCodes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PBC-1119)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-1119", FieldName = "MID in IMb® is Move Update Supplier", Start = 68, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-1119", FieldName = "MID in IMb® is Move Update Supplier", Start = 68, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-1119", FieldName = "MID in IMb® is Move Update Supplier", Start = 68, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MidInImbIsMoveUpdateSupplier", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("PBC-1119")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MidInImbIsMoveUpdateSuppliers))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MidInImbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PBC Record Status (PBC-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-2000", FieldName = "PBC Record Status", Start = 69, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-2000", FieldName = "PBC Record Status", Start = 69, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-2000", FieldName = "PBC Record Status", Start = 69, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("PbcRecordStatus", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PBC-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PbcRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PbcRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PBC-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pbc", FieldCode = "PBC-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pbc", FieldCode = "PBC-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pbc", FieldCode = "PBC-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PBC-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Pbc, string>(version, p => p.JobId, returnValue);
			this.PbcUniqueId = line.ParseForImport<Pbc, int>(version, p => p.PbcUniqueId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Pbc, int>(version, p => p.CqtDatabaseId, returnValue);
			this.PackageId = line.ParseForImport<Pbc, string>(version, p => p.PackageId, returnValue);
			this.Barcode = line.ParseForImport<Pbc, string>(version, p => p.Barcode, returnValue);
			this.WastedOrShortagePieceIndicator = line.ParseForImport<Pbc, string>(version, p => p.WastedOrShortagePieceIndicator, returnValue);
			this.ImpbBarcodeConstructCode = line.ParseForImport<Pbc, string>(version, p => p.ImpbBarcodeConstructCode, returnValue);
			this.MidInImbIsMoveUpdateSupplier = line.ParseForImport<Pbc, string>(version, p => p.MidInImbIsMoveUpdateSupplier, returnValue);
			this.PbcRecordStatus = line.ParseForImport<Pbc, string>(version, p => p.PbcRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pbc, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Pbc, string>(version, p => p.JobId));
			sb.Append(this.PbcUniqueId.FormatForExport<Pbc, int>(version, p => p.PbcUniqueId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Pbc, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.PackageId.FormatForExport<Pbc, string>(version, p => p.PackageId));
			sb.Append(this.Barcode.FormatForExport<Pbc, string>(version, p => p.Barcode));
			sb.Append(this.WastedOrShortagePieceIndicator.FormatForExport<Pbc, string>(version, p => p.WastedOrShortagePieceIndicator));
			sb.Append(this.ImpbBarcodeConstructCode.FormatForExport<Pbc, string>(version, p => p.ImpbBarcodeConstructCode));
			sb.Append(this.MidInImbIsMoveUpdateSupplier.FormatForExport<Pbc, string>(version, p => p.MidInImbIsMoveUpdateSupplier));
			sb.Append(this.PbcRecordStatus.FormatForExport<Pbc, string>(version, p => p.PbcRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Pbc, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}