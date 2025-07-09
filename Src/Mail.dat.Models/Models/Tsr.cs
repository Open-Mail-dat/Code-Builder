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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
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
	/// Provide summary of transportation trucks.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "tsr", File = "Transportation Summary Record", Summary = "Provide summary of transportation trucks.", Description = "Provide summary of transportation trucks.", LineLength = 53, ClosingCharacter = "#")]
	[MaildatImport(Order = 29, Version = "23-1")]
	[Table("Tsr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1")]
	public partial class Tsr : MaildatEntity, ITsr 
	{
		/// <summary>
		/// Job ID (TSR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("TSR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Transportation ID (TSR-1002 )
		/// Unique ID of Transportation records. (zero fill prior to numeric, if numeric only) Key field. To
		/// link to the Transportation Summary Record to all of the Transportation Detail Records Transportation
		/// Geo-data Records, and Transportation Container Records if they exist in the submission.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1002 ", FieldName = "Transportation ID", Start = 9, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of Transportation records. (zero fill prior to numeric, if numeric only) Key field. To link to the Transportation Summary Record to all of the Transportation Detail Records Transportation Geo-data Records, and Transportation Container Records if they exist in the submission.", Type = "string", Format = "zfillnumeric")]
		[Column("TransportationId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("TSR-1002 ")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1")]
		public string TransportationId { get; set; }

		/// <summary>
		/// Load / Truck Dispatch Number (TSR-1101)
		/// Value used by transportation to represent the, ransportation associated. As available, the
		/// applicable transportation information.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1101", FieldName = "Load / Truck Dispatch Number", Start = 14, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Value used by transportation to represent the, ransportation associated. As available, the applicable transportation information.", Type = "string", Format = "leftjustify")]
		[Column("LoadTruckDispatchNumber", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("TSR-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1")]
		public string LoadTruckDispatchNumber { get; set; }

		/// <summary>
		/// Target Ship Date/Time (TSR-1102)
		/// Date/Time transportation schedule to ship. In ISO-8601 Format YYYY-MM-DDThh:mm:ssTZD YYYY =
		/// four-digit year MM   = two-digit month (01=January, etc.) DD   = two-digit day of month (01 through
		/// 31) Hh   = two digits of hour (00 through 23) (am/pm NOT allowed) Mm   = two digits of minute (00
		/// through 59) Ss   = two digits of second (00 through 59) TZD  = time zone designator (Z = UTC
		/// designator Or +hh:mm or -hh:mm to express the local Time offset) Note that the T appears literally
		/// in the string, to indicate The beginning of the time element. Example: November 5, 1994, 8:15:30 am,
		/// US Eastern Standard Time. Expressed as local time: 1994-11-05T08:15:30-05:00 Expressed as UTC:
		/// 1994-11-05T13:15:30Z.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1102", FieldName = "Target Ship Date/Time", Start = 24, Length = 25, Required = false, Key = true, DataType = "A/N", Description = "Date/Time transportation schedule to ship. In ISO-8601 Format YYYY-MM-DDThh:mm:ssTZD YYYY = four-digit year MM   = two-digit month (01=January, etc.) DD   = two-digit day of month (01 through 31) Hh   = two digits of hour (00 through 23) (am/pm NOT allowed) Mm   = two digits of minute (00 through 59) Ss   = two digits of second (00 through 59) TZD  = time zone designator (Z = UTC designator Or +hh:mm or -hh:mm to express the local Time offset) Note that the T appears literally in the string, to indicate The beginning of the time element. Example: November 5, 1994, 8:15:30 am, US Eastern Standard Time. Expressed as local time: 1994-11-05T08:15:30-05:00 Expressed as UTC: 1994-11-05T13:15:30Z.", Type = "datetime", Format = "leftjustify")]
		[Column("TargetShipDateTime", Order = 5, TypeName = "TEXT")]
		[MaildatKey]
		[MaxLength(25)]
		[Comment("TSR-1102")]
		[MaildatVersions("23-1")]
		public string TargetShipDateTime { get; set; }

		/// <summary>
		/// TSR Record Status (TSR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-2000", FieldName = "TSR Record Status", Start = 49, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("TSRRecordStatus", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("TSR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TSRRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TSRRecordStatus { get; set; }

		/// <summary>
		/// Reserved (TSR-1104)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1104", FieldName = "Reserved", Start = 50, Length = 3, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("Reserved", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(3)]
		[Comment("TSR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1")]
		public string Reserved { get; set; }

		/// <summary>
		/// Closing Character (TSR-1101)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "tsr", FieldCode = "TSR-1101", FieldName = "Closing Character", Start = 53, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("TSR-1101")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Tsr, string>(version, p => p.JobId, returnValue);
			this.TransportationId = line.ParseForImport<Tsr, string>(version, p => p.TransportationId, returnValue);
			this.LoadTruckDispatchNumber = line.ParseForImport<Tsr, string>(version, p => p.LoadTruckDispatchNumber, returnValue);
			this.TargetShipDateTime = line.ParseForImport<Tsr, string>(version, p => p.TargetShipDateTime, returnValue);
			this.TSRRecordStatus = line.ParseForImport<Tsr, string>(version, p => p.TSRRecordStatus, returnValue);
			this.Reserved = line.ParseForImport<Tsr, string>(version, p => p.Reserved, returnValue);
			this.ClosingCharacter = line.ParseForImport<Tsr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Tsr, string>(version, p => p.JobId));
			sb.Append(this.TransportationId.FormatForExport<Tsr, string>(version, p => p.TransportationId));
			sb.Append(this.LoadTruckDispatchNumber.FormatForExport<Tsr, string>(version, p => p.LoadTruckDispatchNumber));
			sb.Append(this.TargetShipDateTime.FormatForExport<Tsr, string>(version, p => p.TargetShipDateTime));
			sb.Append(this.TSRRecordStatus.FormatForExport<Tsr, string>(version, p => p.TSRRecordStatus));
			sb.Append(this.Reserved.FormatForExport<Tsr, string>(version, p => p.Reserved));
			sb.Append(this.ClosingCharacter.FormatForExport<Tsr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}