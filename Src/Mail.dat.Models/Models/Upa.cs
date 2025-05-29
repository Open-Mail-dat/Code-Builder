// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 27th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "upa", File = "Un-Coded Parcels Address Record", Summary = "Un-coded parcels address record (linked to PDR).", Description = "Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).", LineLength = 135, ClosingCharacter = "#")]
	[Table("Upa", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 20)]
	public partial class Upa : MaildatEntity, IUpa
	{
		/// <summary>
		/// Job ID (UPA-1001)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("UPA-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (UPA-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018")]
		[Column("PieceID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("UPA-1018")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PieceID { get; set; }

		/// <summary>
		/// CQT Database ID (UPA-1034)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1034", FieldName = "CQT Database ID", Start = 31, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("UPA-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Address (UPA-1102)
		/// Address line to be used for population of shipping services file.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1102", FieldName = "Address", Start = 39, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address line to be used for population of shipping services file.", Type = "string", Format = "leftjustify")]
		[Column("Address", Order = 5, TypeName = "TEXT")]
		[MaxLength(47)]
		[Comment("UPA-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string Address { get; set; }

		/// <summary>
		/// Additional Address (UPA-1103)
		/// Address 2 line to be used for Secondary Address or Urbanization information.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1103", FieldName = "Additional Address", Start = 86, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address 2 line to be used for Secondary Address or Urbanization information.", Type = "string", Format = "leftjustify")]
		[Column("AdditionalAddress", Order = 6, TypeName = "TEXT")]
		[MaxLength(47)]
		[Comment("UPA-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string AdditionalAddress { get; set; }

		/// <summary>
		/// UPA Record Status (UPA-2000)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-2000", FieldName = "UPA Record Status", Start = 133, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("UPARecordStatus", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("UPA-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string UPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (UPA-1120)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1120", FieldName = "Reserve", Start = 134, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveUPA1120", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("UPA-1120")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveUPA1120 { get; set; }

		/// <summary>
		/// Closing Character (UPA-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-9999", FieldName = "Closing Character", Start = 135, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("UPA-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];

			this.JobID = line.ParseForImport<Upa, string>(p => p.JobID, returnValue);
			this.PieceID = line.ParseForImport<Upa, string>(p => p.PieceID, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Upa, int>(p => p.CQTDatabaseID, returnValue);
			this.Address = line.ParseForImport<Upa, string>(p => p.Address, returnValue);
			this.AdditionalAddress = line.ParseForImport<Upa, string>(p => p.AdditionalAddress, returnValue);
			this.UPARecordStatus = line.ParseForImport<Upa, string>(p => p.UPARecordStatus, returnValue);
			this.ReserveUPA1120 = line.ParseForImport<Upa, string>(p => p.ReserveUPA1120, returnValue);
			this.ClosingCharacter = line.ParseForImport<Upa, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;

			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();

			sb.Append(this.JobID.FormatForExport<Upa, string>(p => p.JobID));
			sb.Append(this.PieceID.FormatForExport<Upa, string>(p => p.PieceID));
			sb.Append(this.CQTDatabaseID.FormatForExport<Upa, int>(p => p.CQTDatabaseID));
			sb.Append(this.Address.FormatForExport<Upa, string>(p => p.Address));
			sb.Append(this.AdditionalAddress.FormatForExport<Upa, string>(p => p.AdditionalAddress));
			sb.Append(this.UPARecordStatus.FormatForExport<Upa, string>(p => p.UPARecordStatus));
			sb.Append(this.ReserveUPA1120.FormatForExport<Upa, string>(p => p.ReserveUPA1120));
			sb.Append(this.ClosingCharacter.FormatForExport<Upa, string>(p => p.ClosingCharacter));

			return Task.FromResult(sb.ToString());
		}
	}
}