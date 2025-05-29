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
	/// Relates containers to associated ink jet output tapes/files.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "icr", File = "Ij/C Relationship Record", Summary = "Relates containers to associated ink jet output tapes/files.", Description = "Relates containers to associated ink jet output tapes/files.", LineLength = 82, ClosingCharacter = "#")]
	[Table("Icr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 13)]
	public partial class Icr : MaildatEntity, IIcr 
	{
		/// <summary>
		/// Job ID (ICR-1001)
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("ICR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// File Name (ICR-1101)
		/// The agreed file name describing the content of the single Transmitted file within which this
		/// container exists.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1101", FieldName = "File Name", Start = 9, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "The agreed file name describing the content of the single Transmitted file within which this container exists.", Type = "string", Format = "leftjustify")]
		[Column("FileName", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("ICR-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FileName { get; set; }

		/// <summary>
		/// Tape ID (ICR-1102)
		/// The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence
		/// number if non- Inkjet transmission.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1102", FieldName = "Tape ID", Start = 39, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence number if non- Inkjet transmission.", Type = "string", Format = "zfillnumeric")]
		[Column("TapeID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("ICR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string TapeID { get; set; }

		/// <summary>
		/// Container ID (ICR-1006)
		/// See Container Summary File's Container ID definition.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1006", FieldName = "Container ID", Start = 45, Length = 6, Required = true, Key = true, DataType = "N", Description = "See Container Summary File's Container ID definition.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 5, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("ICR-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int ContainerID { get; set; }

		/// <summary>
		/// Beginning Record (ICR-1103)
		/// The record number of the first address on the file/tape that is for the container defined within
		/// this record.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1103", FieldName = "Beginning Record", Start = 51, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the first address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("BeginningRecord", Order = 6, TypeName = "INTEGER")]
		[Comment("ICR-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? BeginningRecord { get; set; }

		/// <summary>
		/// Ending Record (ICR-1104)
		/// The record number of the last address on the file/tape that is for the container defined within this
		/// record.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1104", FieldName = "Ending Record", Start = 59, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the last address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("EndingRecord", Order = 7, TypeName = "INTEGER")]
		[Comment("ICR-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? EndingRecord { get; set; }

		/// <summary>
		/// ICR Record Status (ICR-2000)
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-2000", FieldName = "ICR Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ICRRecordStatus", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("ICR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ICRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (ICR-1105)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1105", FieldName = "Reserve", Start = 68, Length = 14, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveICR1105", Order = 9, TypeName = "TEXT")]
		[MaxLength(14)]
		[Comment("ICR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveICR1105 { get; set; }

		/// <summary>
		/// Closing Character (ICR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-9999", FieldName = "Closing Character", Start = 82, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("ICR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Icr, string>(p => p.JobID, returnValue);
			this.FileName = line.ParseForImport<Icr, string>(p => p.FileName, returnValue);
			this.TapeID = line.ParseForImport<Icr, string>(p => p.TapeID, returnValue);
			this.ContainerID = line.ParseForImport<Icr, int>(p => p.ContainerID, returnValue);
			this.BeginningRecord = line.ParseForImport<Icr, int?>(p => p.BeginningRecord, returnValue);
			this.EndingRecord = line.ParseForImport<Icr, int?>(p => p.EndingRecord, returnValue);
			this.ICRRecordStatus = line.ParseForImport<Icr, string>(p => p.ICRRecordStatus, returnValue);
			this.ReserveICR1105 = line.ParseForImport<Icr, string>(p => p.ReserveICR1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Icr, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Icr, string>(p => p.JobID));
			sb.Append(this.FileName.FormatForExport<Icr, string>(p => p.FileName));
			sb.Append(this.TapeID.FormatForExport<Icr, string>(p => p.TapeID));
			sb.Append(this.ContainerID.FormatForExport<Icr, int>(p => p.ContainerID));
			sb.Append(this.BeginningRecord.FormatForExport<Icr, int?>(p => p.BeginningRecord));
			sb.Append(this.EndingRecord.FormatForExport<Icr, int?>(p => p.EndingRecord));
			sb.Append(this.ICRRecordStatus.FormatForExport<Icr, string>(p => p.ICRRecordStatus));
			sb.Append(this.ReserveICR1105.FormatForExport<Icr, string>(p => p.ReserveICR1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Icr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}