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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// CRID for Move update charges. Records identify third party move update entities that should be
	/// invoiced.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "epd", File = "Extra Piece Detail", Summary = "CRID for Move update charges.", Description = "CRID for Move update charges. Records identify third party move update entities that should be invoiced.", LineLength = 45, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "epd", File = "Extra Piece Detail", Summary = "CRID for Move update charges.", Description = "CRID for Move update charges. Records identify third party move update entities that should be invoiced.", LineLength = 45, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "epd", File = "Extra Piece Detail", Summary = "CRID for Move update charges.", Description = "CRID for Move update charges. Records identify third party move update entities that should be invoiced.", LineLength = 45, ClosingCharacter = "#")]
	[MaildatImport(Order = 21, Version = "23-1")]
	[MaildatImport(Order = 21, Version = "24-1")]
	[MaildatImport(Order = 21, Version = "25-1")]
	[Table("Epd", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Epd : MaildatEntity, IEpd 
	{
		/// <summary>
		/// Job ID (EPD-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("EPD-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Piece ID (EPD-1002)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-1002", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-1002", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-1002", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("EPD-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// CRID Type (EPD-1003)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-1003", FieldName = "CRID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-1003", FieldName = "CRID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-1003", FieldName = "CRID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CridType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("M", "U")]
		[Comment("EPD-1003")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CridTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CridType { get; set; }

		/// <summary>
		/// CRID (EPD-1101)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Only digits 0
		/// - 9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-1004", FieldName = "CRID", Start = 32, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-1101", FieldName = "CRID", Start = 32, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-1101", FieldName = "CRID", Start = 32, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("Crid", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(12)]
		[Comment("EPD-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Crid { get; set; }

		/// <summary>
		/// EPD Record Status (EPD-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-2000", FieldName = "EPD Record Status", Start = 44, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-2000", FieldName = "EPD Record Status", Start = 44, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-2000", FieldName = "EPD Record Status", Start = 44, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("EpdRecordStatus", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("EPD-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(EpdRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EpdRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (EPD-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "epd", FieldCode = "EPD-9999", FieldName = "Closing Character", Start = 45, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "epd", FieldCode = "EPD-9999", FieldName = "Closing Character", Start = 45, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "epd", FieldCode = "EPD-9999", FieldName = "Closing Character", Start = 45, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("EPD-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Epd, string>(version, p => p.JobId, returnValue);
			this.PieceId = line.ParseForImport<Epd, string>(version, p => p.PieceId, returnValue);
			this.CridType = line.ParseForImport<Epd, string>(version, p => p.CridType, returnValue);
			this.Crid = line.ParseForImport<Epd, string>(version, p => p.Crid, returnValue);
			this.EpdRecordStatus = line.ParseForImport<Epd, string>(version, p => p.EpdRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Epd, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Epd, string>(version, p => p.JobId));
			sb.Append(this.PieceId.FormatForExport<Epd, string>(version, p => p.PieceId));
			sb.Append(this.CridType.FormatForExport<Epd, string>(version, p => p.CridType));
			sb.Append(this.Crid.FormatForExport<Epd, string>(version, p => p.Crid));
			sb.Append(this.EpdRecordStatus.FormatForExport<Epd, string>(version, p => p.EpdRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Epd, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}