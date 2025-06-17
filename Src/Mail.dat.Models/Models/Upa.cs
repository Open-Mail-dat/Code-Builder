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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Un-coded parcels address record (linked to PDR). Un-Coded Parcel Address file: records addresses for
	/// the un-coded parcels. (Links with .pdr ONLY).
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "upa", File = "un-coded parcels address", Summary = "Un-coded parcels address record (linked to PDR).", Description = "Un-coded parcels address record (linked to PDR). Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).", LineLength = 135, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "upa", File = "un-coded parcels address", Summary = "Un-coded parcels address record (linked to PDR).", Description = "Un-coded parcels address record (linked to PDR). Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).", LineLength = 135, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "upa", File = "un-coded parcels address", Summary = "Un-coded parcels address record (linked to PDR).", Description = "Un-coded parcels address record (linked to PDR). Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).", LineLength = 135, ClosingCharacter = "#")]
	[MaildatImport(Order = 20, Version = "23-1")]
	[MaildatImport(Order = 20, Version = "24-1")]
	[MaildatImport(Order = 20, Version = "25-1")]
	[Table("Upa", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Upa : MaildatEntity, IUpa 
	{
		/// <summary>
		/// Job ID (UPA-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("UPA-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Piece ID (UPA-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018")]
		[Column("PieceId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("UPA-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceId { get; set; }

		/// <summary>
		/// CQT Database ID (UPA-1034)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1034", FieldName = "CQT Database ID", Start = 31, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1034", FieldName = "CQT Database ID", Start = 31, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1034", FieldName = "CQT Database ID", Start = 31, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("UPA-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Address (UPA-1102)
		/// Address line to be used for population of shipping services file.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1102", FieldName = "Address", Start = 39, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address line to be used for population of shipping services file.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1102", FieldName = "Address", Start = 39, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address line to be used for population of shipping services file.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1102", FieldName = "Address", Start = 39, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address line to be used for population of shipping services file.", Type = "string", Format = "leftjustify")]
		[Column("Address", Order = 5, TypeName = "TEXT")]
		[MaxLength(47)]
		[Comment("UPA-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Address { get; set; }

		/// <summary>
		/// Additional Address (UPA-1103)
		/// Address 2 line to be used for Secondary Address or Urbanization information.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1103", FieldName = "Additional Address", Start = 86, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address 2 line to be used for Secondary Address or Urbanization information.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1103", FieldName = "Additional Address", Start = 86, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address 2 line to be used for Secondary Address or Urbanization information.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1103", FieldName = "Additional Address", Start = 86, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address 2 line to be used for Secondary Address or Urbanization information.", Type = "string", Format = "leftjustify")]
		[Column("AdditionalAddress", Order = 6, TypeName = "TEXT")]
		[MaxLength(47)]
		[Comment("UPA-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string AdditionalAddress { get; set; }

		/// <summary>
		/// UPA Record Status (UPA-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-2000", FieldName = "UPA Record Status", Start = 133, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-2000", FieldName = "UPA Record Status", Start = 133, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-2000", FieldName = "UPA Record Status", Start = 133, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("UParecordStatus", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("UPA-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(UParecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UParecordStatus { get; set; }

		/// <summary>
		/// Reserve (UPA-1120)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-1120", FieldName = "Reserve", Start = 134, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-1120", FieldName = "Reserve", Start = 134, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-1120", FieldName = "Reserve", Start = 134, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveUpa1120", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("UPA-1120")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveUpa1120 { get; set; }

		/// <summary>
		/// Closing Character (UPA-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "upa", FieldCode = "UPA-9999", FieldName = "Closing Character", Start = 135, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "upa", FieldCode = "UPA-9999", FieldName = "Closing Character", Start = 135, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "upa", FieldCode = "UPA-9999", FieldName = "Closing Character", Start = 135, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("UPA-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Upa, string>(version, p => p.JobId, returnValue);
			this.PieceId = line.ParseForImport<Upa, string>(version, p => p.PieceId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Upa, int>(version, p => p.CqtDatabaseId, returnValue);
			this.Address = line.ParseForImport<Upa, string>(version, p => p.Address, returnValue);
			this.AdditionalAddress = line.ParseForImport<Upa, string>(version, p => p.AdditionalAddress, returnValue);
			this.UParecordStatus = line.ParseForImport<Upa, string>(version, p => p.UParecordStatus, returnValue);
			this.ReserveUpa1120 = line.ParseForImport<Upa, string>(version, p => p.ReserveUpa1120, returnValue);
			this.ClosingCharacter = line.ParseForImport<Upa, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Upa, string>(version, p => p.JobId));
			sb.Append(this.PieceId.FormatForExport<Upa, string>(version, p => p.PieceId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Upa, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.Address.FormatForExport<Upa, string>(version, p => p.Address));
			sb.Append(this.AdditionalAddress.FormatForExport<Upa, string>(version, p => p.AdditionalAddress));
			sb.Append(this.UParecordStatus.FormatForExport<Upa, string>(version, p => p.UParecordStatus));
			sb.Append(this.ReserveUpa1120.FormatForExport<Upa, string>(version, p => p.ReserveUpa1120));
			sb.Append(this.ClosingCharacter.FormatForExport<Upa, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}