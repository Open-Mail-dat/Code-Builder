// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 29th, 2025.
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
	/// Provides piece level detail required of full service mailings; when used instead of the Piece Detail
	/// file, acts as an extension of the PQT file.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "pbc", File = "Piece Barcode Record", Summary = "Piece barcode details.", Description = "Provides piece level detail required of full service mailings; when used instead of the Piece Detail file, acts as an extension of the PQT file.", LineLength = 70, ClosingCharacter = "#")]
	[Table("Pbc", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 15)]
	public partial class Pbc : MaildatEntity, IPbc 
	{
		/// <summary>
		/// Job ID (PBC-1001)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PBC-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// PBC Unique ID (PBC-1002)
		/// Uniquely identifies each PBC record.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1002", FieldName = "PBC Unique ID", Start = 9, Length = 9, Required = true, Key = true, DataType = "N", Description = "Uniquely identifies each PBC record.", Type = "integer", Format = "zfill")]
		[Column("PBCUniqueID", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PBC-1002")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int PBCUniqueID { get; set; }

		/// <summary>
		/// CQT Database ID (PBC-1034)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1034", FieldName = "CQT Database ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("PBC-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PBC-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1012", FieldName = "Package ID", Start = 26, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[Column("PackageID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PBC-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageID { get; set; }

		/// <summary>
		/// Barcode (PBC-1122)
		/// IMb® or IMpb®.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1122", FieldName = "Barcode", Start = 32, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "IMb® or IMpb®.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 6, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("PBC-1122")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string Barcode { get; set; }

		/// <summary>
		/// Wasted or Shortage Piece Indicator (PBC-1117)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1117", FieldName = "Wasted or Shortage Piece Indicator", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("WastedOrShortagePieceIndicator", Order = 7, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "S", "T", "W", "X")]
		[Comment("PBC-1117")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string WastedOrShortagePieceIndicator { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (PBC-1118)
		/// Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1118", FieldName = "IMpb® Barcode Construct Code", Start = 67, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used.  This code identifies which combination of ZIP, MID, and serial number is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("PBC-1118")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// MID in IMb® is Move Update Supplier (PBC-1119)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-1119", FieldName = "MID in IMb® is Move Update Supplier", Start = 68, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MIDInIMbIsMoveUpdateSupplier", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("PBC-1119")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MIDInIMbIsMoveUpdateSupplier { get; set; }

		/// <summary>
		/// PBC Record Status (PBC-2000)
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-2000", FieldName = "PBC Record Status", Start = 69, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PBCRecordStatus", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PBC-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PBCRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (PBC-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pbc", FieldCode = "PBC-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PBC-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Pbc, string>(p => p.JobID, returnValue);
			this.PBCUniqueID = line.ParseForImport<Pbc, int>(p => p.PBCUniqueID, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Pbc, int>(p => p.CQTDatabaseID, returnValue);
			this.PackageID = line.ParseForImport<Pbc, string>(p => p.PackageID, returnValue);
			this.Barcode = line.ParseForImport<Pbc, string>(p => p.Barcode, returnValue);
			this.WastedOrShortagePieceIndicator = line.ParseForImport<Pbc, string>(p => p.WastedOrShortagePieceIndicator, returnValue);
			this.IMpbBarcodeConstructCode = line.ParseForImport<Pbc, string>(p => p.IMpbBarcodeConstructCode, returnValue);
			this.MIDInIMbIsMoveUpdateSupplier = line.ParseForImport<Pbc, string>(p => p.MIDInIMbIsMoveUpdateSupplier, returnValue);
			this.PBCRecordStatus = line.ParseForImport<Pbc, string>(p => p.PBCRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pbc, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Pbc, string>(p => p.JobID));
			sb.Append(this.PBCUniqueID.FormatForExport<Pbc, int>(p => p.PBCUniqueID));
			sb.Append(this.CQTDatabaseID.FormatForExport<Pbc, int>(p => p.CQTDatabaseID));
			sb.Append(this.PackageID.FormatForExport<Pbc, string>(p => p.PackageID));
			sb.Append(this.Barcode.FormatForExport<Pbc, string>(p => p.Barcode));
			sb.Append(this.WastedOrShortagePieceIndicator.FormatForExport<Pbc, string>(p => p.WastedOrShortagePieceIndicator));
			sb.Append(this.IMpbBarcodeConstructCode.FormatForExport<Pbc, string>(p => p.IMpbBarcodeConstructCode));
			sb.Append(this.MIDInIMbIsMoveUpdateSupplier.FormatForExport<Pbc, string>(p => p.MIDInIMbIsMoveUpdateSupplier));
			sb.Append(this.PBCRecordStatus.FormatForExport<Pbc, string>(p => p.PBCRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Pbc, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}