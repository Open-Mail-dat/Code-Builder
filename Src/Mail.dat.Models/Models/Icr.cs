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
	/// Relates containers to associated ink jet output tapes/files.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "icr", File = "IJ/C RELATIONSHIP RECORD", Summary = "Relates containers to associated ink jet output tapes/files.", Description = "Relates containers to associated ink jet output tapes/files.", LineLength = 82, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "icr", File = "IJ/C RELATIONSHIP RECORD", Summary = "Relates containers to associated ink jet output tapes/files.", Description = "Relates containers to associated ink jet output tapes/files.", LineLength = 82, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "icr", File = "IJ/C RELATIONSHIP RECORD", Summary = "Relates containers to associated ink jet output tapes/files.", Description = "Relates containers to associated ink jet output tapes/files.", LineLength = 82, ClosingCharacter = "#")]
	[MaildatImport(Order = 13, Version = "23-1")]
	[MaildatImport(Order = 13, Version = "24-1")]
	[MaildatImport(Order = 13, Version = "25-1")]
	[Table("Icr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Icr : MaildatEntity, IIcr 
	{
		/// <summary>
		/// Job ID (ICR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("ICR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// File Name (ICR-1101)
		/// The agreed file name describing the content of the single transmitted file within which this
		/// container exists.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1101", FieldName = "File Name", Start = 9, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "The agreed file name describing the content of the single Transmitted file within which this container exists.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1101", FieldName = "File Name", Start = 9, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "The agreed file name describing the content of the single Transmitted file within which this container exists.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1101", FieldName = "File Name", Start = 9, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "The agreed file name describing the content of the single transmitted file within which this container exists.", Type = "string", Format = "leftjustify")]
		[Column("FileName", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("ICR-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string FileName { get; set; }

		/// <summary>
		/// Tape ID (ICR-1102)
		/// The identifying A/N string for the tape within which this container exists. Use arbitrary sequence
		/// number if non-inkjet transmission.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1102", FieldName = "Tape ID", Start = 39, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence number if non- Inkjet transmission.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1102", FieldName = "Tape ID", Start = 39, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence number if non- Inkjet transmission.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1102", FieldName = "Tape ID", Start = 39, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The identifying A/N string for the tape within which this container exists. Use arbitrary sequence number if non-inkjet transmission.", Type = "string", Format = "zfillnumeric")]
		[Column("TapeId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("ICR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string TapeId { get; set; }

		/// <summary>
		/// Container ID (ICR-1006)
		/// See Container Summary File's Container ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1006", FieldName = "Container ID", Start = 45, Length = 6, Required = true, Key = true, DataType = "N", Description = "See Container Summary File's Container ID definition.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1006", FieldName = "Container ID", Start = 45, Length = 6, Required = true, Key = true, DataType = "N", Description = "See Container Summary File's Container ID definition.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1006", FieldName = "Container ID", Start = 45, Length = 6, Required = true, Key = true, DataType = "N", Description = "See Container Summary File's Container ID definition.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerId", Order = 5, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("ICR-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerId { get; set; }

		/// <summary>
		/// Beginning Record (ICR-1103)
		/// The record number of the first address on the file/tape that is for the container defined within
		/// this record.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1103", FieldName = "Beginning Record", Start = 51, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the first address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1103", FieldName = "Beginning Record", Start = 51, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the first address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1103", FieldName = "Beginning Record", Start = 51, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the first address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("BeginningRecord", Order = 6, TypeName = "INTEGER")]
		[Comment("ICR-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? BeginningRecord { get; set; }

		/// <summary>
		/// Ending Record (ICR-1104)
		/// The record number of the last address on the file/tape that is for the container defined within this
		/// record.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1104", FieldName = "Ending Record", Start = 59, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the last address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1104", FieldName = "Ending Record", Start = 59, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the last address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1104", FieldName = "Ending Record", Start = 59, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the last address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("EndingRecord", Order = 7, TypeName = "INTEGER")]
		[Comment("ICR-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? EndingRecord { get; set; }

		/// <summary>
		/// ICR Record Status (ICR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-2000", FieldName = "ICR Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-2000", FieldName = "ICR Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-2000", FieldName = "ICR Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("IcrRecordStatus", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("ICR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(IcrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string IcrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (ICR-1105)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-1105", FieldName = "Reserve", Start = 68, Length = 14, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-1105", FieldName = "Reserve", Start = 68, Length = 14, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-1105", FieldName = "Reserve", Start = 68, Length = 14, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveIcr1105", Order = 9, TypeName = "TEXT")]
		[MaxLength(14)]
		[Comment("ICR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveIcr1105 { get; set; }

		/// <summary>
		/// Closing Character (ICR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "icr", FieldCode = "ICR-9999", FieldName = "Closing Character", Start = 82, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "icr", FieldCode = "ICR-9999", FieldName = "Closing Character", Start = 82, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "icr", FieldCode = "ICR-9999", FieldName = "Closing Character", Start = 82, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("ICR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Icr, string>(version, p => p.JobId, returnValue);
			this.FileName = line.ParseForImport<Icr, string>(version, p => p.FileName, returnValue);
			this.TapeId = line.ParseForImport<Icr, string>(version, p => p.TapeId, returnValue);
			this.ContainerId = line.ParseForImport<Icr, int>(version, p => p.ContainerId, returnValue);
			this.BeginningRecord = line.ParseForImport<Icr, int?>(version, p => p.BeginningRecord, returnValue);
			this.EndingRecord = line.ParseForImport<Icr, int?>(version, p => p.EndingRecord, returnValue);
			this.IcrRecordStatus = line.ParseForImport<Icr, string>(version, p => p.IcrRecordStatus, returnValue);
			this.ReserveIcr1105 = line.ParseForImport<Icr, string>(version, p => p.ReserveIcr1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Icr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Icr, string>(version, p => p.JobId));
			sb.Append(this.FileName.FormatForExport<Icr, string>(version, p => p.FileName));
			sb.Append(this.TapeId.FormatForExport<Icr, string>(version, p => p.TapeId));
			sb.Append(this.ContainerId.FormatForExport<Icr, int>(version, p => p.ContainerId));
			sb.Append(this.BeginningRecord.FormatForExport<Icr, int?>(version, p => p.BeginningRecord));
			sb.Append(this.EndingRecord.FormatForExport<Icr, int?>(version, p => p.EndingRecord));
			sb.Append(this.IcrRecordStatus.FormatForExport<Icr, string>(version, p => p.IcrRecordStatus));
			sb.Append(this.ReserveIcr1105.FormatForExport<Icr, string>(version, p => p.ReserveIcr1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Icr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}