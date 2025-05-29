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
	/// Records identify third party move update entities that should be invoiced.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "epd", File = "Extra Piece Detail Record", Summary = "CRID for Move update charges.", Description = "Records identify third party move update entities that should be invoiced.", LineLength = 45, ClosingCharacter = "#")]
	[Table("Epd", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 21)]
	public partial class Epd : MaildatEntity, IEpd 
	{
		/// <summary>
		/// Job ID (EPD-1001)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("EPD-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (EPD-1002)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1002", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("EPD-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PieceID { get; set; }

		/// <summary>
		/// CRID Type (EPD-1003)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1003", FieldName = "CRID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CRIDType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("M", "U")]
		[Comment("EPD-1003")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CRIDType { get; set; }

		/// <summary>
		/// CRID (EPD-1101)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify,
		/// space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-1101", FieldName = "CRID", Start = 32, Length = 12, Required = true, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the role of this party. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("CRID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(12)]
		[Comment("EPD-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CRID { get; set; }

		/// <summary>
		/// EPD Record Status (EPD-2000)
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-2000", FieldName = "EPD Record Status", Start = 44, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("EPDRecordStatus", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("EPD-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string EPDRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (EPD-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "epd", FieldCode = "EPD-9999", FieldName = "Closing Character", Start = 45, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("EPD-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Epd, string>(p => p.JobID, returnValue);
			this.PieceID = line.ParseForImport<Epd, string>(p => p.PieceID, returnValue);
			this.CRIDType = line.ParseForImport<Epd, string>(p => p.CRIDType, returnValue);
			this.CRID = line.ParseForImport<Epd, string>(p => p.CRID, returnValue);
			this.EPDRecordStatus = line.ParseForImport<Epd, string>(p => p.EPDRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Epd, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Epd, string>(p => p.JobID));
			sb.Append(this.PieceID.FormatForExport<Epd, string>(p => p.PieceID));
			sb.Append(this.CRIDType.FormatForExport<Epd, string>(p => p.CRIDType));
			sb.Append(this.CRID.FormatForExport<Epd, string>(p => p.CRID));
			sb.Append(this.EPDRecordStatus.FormatForExport<Epd, string>(p => p.EPDRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Epd, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}