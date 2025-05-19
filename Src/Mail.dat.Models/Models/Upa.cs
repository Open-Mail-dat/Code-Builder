// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 18th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 1.0.0
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "upa", File = "Un-Coded Parcels Address Record", Summary = "Un-coded parcels address record (linked to PDR).", Description = "Un-Coded Parcel Address file: records addresses for the un-coded parcels. (Links with .pdr ONLY).")]
	[Table("Upa", Schema = "Maildat")]
	public partial class Upa : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (UPA-1001)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (UPA-1018)
		/// Unique ID of individual piece within mailing.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within mailing.", Type = "string", Format = "zfillnumeric", References = "PDR-1018")]
		[Column("PieceID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(22)]
		public string PieceID { get; set; }

		/// <summary>
		/// CQT Database ID (UPA-1034)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1034", FieldName = "CQT Database ID", Start = 31, Length = 8, Required = true, Key = false, DataType = "N", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 3)]
		[Required]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Address (UPA-1102)
		/// Address line to be used for population of shipping services file.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1102", FieldName = "Address", Start = 39, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address line to be used for population of shipping services file.", Type = "string", Format = "leftjustify")]
		[Column("Address", Order = 4)]
		[MaxLength(47)]
		public string Address { get; set; }

		/// <summary>
		/// Additional Address (UPA-1103)
		/// Address 2 line to be used for Secondary Address or Urbanization information.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1103", FieldName = "Additional Address", Start = 86, Length = 47, Required = false, Key = false, DataType = "A/N", Description = "Address 2 line to be used for Secondary Address or Urbanization information.", Type = "string", Format = "leftjustify")]
		[Column("AdditionalAddress", Order = 5)]
		[MaxLength(47)]
		public string AdditionalAddress { get; set; }

		/// <summary>
		/// UPA Record Status (UPA-2000)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-2000", FieldName = "UPA Record Status", Start = 133, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("UPARecordStatus", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string UPARecordStatus { get; set; }

		/// <summary>
		/// Reserve (UPA-1120)
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-1120", FieldName = "Reserve", Start = 134, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 7)]
		[MaxLength(1)]
		public string ReserveUPA1120 { get; set; }

		/// <summary>
		/// Closing Character (UPA-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "upa", FieldCode = "UPA-9999", FieldName = "Closing Character", Start = 135, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 8)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}