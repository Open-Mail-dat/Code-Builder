// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
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
	/// Relates containers to associated ink jet output tapes/files.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "icr", File = "Ij/C Relationship Record", Summary = "Relates containers to associated ink jet output tapes/files.", Description = "Relates containers to associated ink jet output tapes/files.")]
	[Table("Icr", Schema = "Maildat")]
	public partial class Icr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (ICR-1001)
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// File Name (ICR-1101)
		/// The agreed file name describing the content of the single Transmitted file within which this
		/// container exists.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1101", FieldName = "File Name", Start = 9, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "The agreed file name describing the content of the single Transmitted file within which this container exists.", Type = "string", Format = "leftjustify")]
		[Column("FileName", Order = 2)]
		[Required]
		[MaxLength(30)]
		public string FileName { get; set; }

		/// <summary>
		/// Tape ID (ICR-1102)
		/// The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence
		/// number if non- Inkjet transmission.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1102", FieldName = "Tape ID", Start = 39, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The identifying A/N string for the tape within which this Container exists. Use arbitrary sequence number if non- Inkjet transmission.", Type = "string", Format = "zfillnumeric")]
		[Column("TapeID", Order = 3)]
		[Required]
		[MaxLength(6)]
		public string TapeID { get; set; }

		/// <summary>
		/// Container ID (ICR-1006)
		/// See Container Summary File's Container ID definition.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1006", FieldName = "Container ID", Start = 45, Length = 6, Required = true, Key = true, DataType = "N", Description = "See Container Summary File's Container ID definition.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 4)]
		[Required]
		[Key]
		public int ContainerID { get; set; }

		/// <summary>
		/// Beginning Record (ICR-1103)
		/// The record number of the first address on the file/tape that is for the container defined within
		/// this record.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1103", FieldName = "Beginning Record", Start = 51, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the first address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("BeginningRecord", Order = 5)]
		public int BeginningRecord { get; set; }

		/// <summary>
		/// Ending Record (ICR-1104)
		/// The record number of the last address on the file/tape that is for the container defined within this
		/// record.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1104", FieldName = "Ending Record", Start = 59, Length = 8, Required = false, Key = false, DataType = "N", Description = "The record number of the last address on the file/tape that is for the container defined within this record.", Type = "integer", Format = "zfill")]
		[Column("EndingRecord", Order = 6)]
		public int EndingRecord { get; set; }

		/// <summary>
		/// ICR Record Status (ICR-2000)
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-2000", FieldName = "ICR Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ICRRecordStatus", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string ICRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (ICR-1105)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-1105", FieldName = "Reserve", Start = 68, Length = 14, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 8)]
		[MaxLength(14)]
		public string ReserveICR1105 { get; set; }

		/// <summary>
		/// Closing Character (ICR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "icr", FieldCode = "ICR-9999", FieldName = "Closing Character", Start = 82, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 9)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}