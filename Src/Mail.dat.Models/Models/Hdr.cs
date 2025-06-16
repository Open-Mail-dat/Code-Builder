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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
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
	/// Who, what and when of this job.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "hdr", File = "Header Record", Summary = "Who, what and when of this job.", Description = "Who, what and when of this job.", LineLength = 2000, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "hdr", File = "Header Record", Summary = "Who, what and when of this job.", Description = "Who, what and when of this job.", LineLength = 2000, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "hdr", File = "Header Record", Summary = "Who, what and when of this job.", Description = "Who, what and when of this job.", LineLength = 2000, ClosingCharacter = "#")]
	[MaildatImport(Order = 1, Version = "23-1")]
	[MaildatImport(Order = 1, Version = "24-1")]
	[MaildatImport(Order = 1, Version = "25-1")]
	[Table("Hdr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Hdr : MaildatEntity, IHdr 
	{
		/// <summary>
		/// Job ID (HDR-1001)
		/// A Job ID (the Mail.dat® serial number) should be unique compared to all other supplied Job IDs
		/// provided by the same source. The Job ID assigned to any new Mail.dat® is that transmission; it is
		/// the Historical Job ID that retains the initial ID throughout its existence. Job IDs are user
		/// managed, but must remain unique within one User License Code.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "A Job ID (the Mail.dat® serial number) should be unique Compared to all other supplied Job IDs provided by the Same source. The Job ID assigned to any new Mail.dat® is Also to be applied to any Historical Header Record part of That transmission; it is the Historical Job ID that retains The initial ID throughout its existence. Job IDs are user Managed, but must remain unique within one User License Code.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "A Job ID (the Mail.dat® serial number) should be unique Compared to all other supplied Job IDs provided by the Same source. The Job ID assigned to any new Mail.dat® is Also to be applied to any Historical Header Record part of That transmission; it is the Historical Job ID that retains The initial ID throughout its existence. Job IDs are user Managed, but must remain unique within one User License Code.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "A Job ID (the Mail.dat® serial number) should be unique compared to all other supplied Job IDs provided by the same source. The Job ID assigned to any new Mail.dat® is that transmission; it is the Historical Job ID that retains the initial ID throughout its existence. Job IDs are user managed, but must remain unique within one User License Code.", Type = "string", Format = "zfillnumeric")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("HDR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Mail.dat Version (HDR-1101)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1101", FieldName = "Mail.dat Version", Start = 9, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1101", FieldName = "Mail.dat Version", Start = 9, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1101", FieldName = "Mail.dat Version", Start = 9, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MailDatVersion", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[AllowedValues("23-1", "24-1", "25-1")]
		[Comment("HDR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailDatVersions))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatVersion { get; set; }

		/// <summary>
		/// Header History Sequence Number (HDR-1025)
		/// First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this
		/// Mail.dat® as it is successively processed would have a Header with a History Sequence number = 9998,
		/// etc. Current Active Header would be next in the series, hence the record with the lowest History
		/// Sequence value. Header History Status field (see next) also denotes current active header.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1025", FieldName = "Header History Sequence Number", Start = 13, Length = 4, Required = true, Key = true, DataType = "N", Description = "First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this Mail.dat® as it is successively Processed would have a Header with a History Sequence Number = 9998, etc. Current Active Header would be next in The series, hence the record with the lowest History Sequence Value. Header History Status field (see next) also denotes Current active header.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1025", FieldName = "Header History Sequence Number", Start = 13, Length = 4, Required = true, Key = true, DataType = "N", Description = "First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this Mail.dat® as it is successively Processed would have a Header with a History Sequence Number = 9998, etc. Current Active Header would be next in The series, hence the record with the lowest History Sequence Value. Header History Status field (see next) also denotes Current active header.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1025", FieldName = "Header History Sequence Number", Start = 13, Length = 4, Required = true, Key = true, DataType = "N", Description = "First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this Mail.dat® as it is successively processed would have a Header with a History Sequence number = 9998, etc. Current Active Header would be next in the series, hence the record with the lowest History Sequence value. Header History Status field (see next) also denotes current active header.", Type = "integer", Format = "zfill")]
		[Column("HeaderHistorySequenceNumber", Order = 4, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("HDR-1025")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int HeaderHistorySequenceNumber { get; set; }

		/// <summary>
		/// Header History Status (HDR-1148)
		/// Transmit all history records with subsequent transmissions. C = Current (this .hdr record is
		/// applicable to current transmission) H = History (this .hdr record predates and is associated with,
		/// but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a
		/// specific Mail.dat® must be forwarded with that Mail.dat, or portion thereof, if such transmission
		/// occurs. As applicable, the received Header is updated by the Mail.dat® processor with an H in this
		/// field as it is passed along with the new Current Active Header to next recipient.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1148", FieldName = "Header History Status", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Transmit all history records with subsequent transmissions. C = Current (this .hdr record is applicable to current Transmission) H = History (this .hdr record predates and is Associated with, but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a Specific Mail.dat® must be forwarded with that Mail.dat, or Portion thereof, if such transmission occurs. As applicable, the Received Header is updated by the Mail.dat® processor with an H in this field as it is passed along with the new Current Active Header to next recipient.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1148", FieldName = "Header History Status", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Transmit all history records with subsequent transmissions. C = Current (this .hdr record is applicable to current Transmission) H = History (this .hdr record predates and is Associated with, but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a Specific Mail.dat® must be forwarded with that Mail.dat, or Portion thereof, if such transmission occurs. As applicable, the Received Header is updated by the Mail.dat® processor with an H in this field as it is passed along with the new Current Active Header to next recipient.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1148", FieldName = "Header History Status", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Transmit all history records with subsequent transmissions. C = Current (this .hdr record is applicable to current transmission) H = History (this .hdr record predates and is associated with, but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a specific Mail.dat® must be forwarded with that Mail.dat, or portion thereof, if such transmission occurs. As applicable, the received Header is updated by the Mail.dat® processor with an H in this field as it is passed along with the new Current Active Header to next recipient.", Type = "enum", Format = "leftjustify")]
		[Column("HeaderHistoryStatus", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "H")]
		[Comment("HDR-1148")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(HeaderHistoryStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string HeaderHistoryStatus { get; set; }

		/// <summary>
		/// Historical Job ID (HDR-1153)
		/// Populated with the applicable Job ID by party creating the currently active Header. Successive
		/// processors do not disturb this field. Successive processors will only change the Header History
		/// Status field in this record from C to H.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1153", FieldName = "Historical Job ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Populated with the applicable Job ID by party creating the currently active Header. Successive processors do not disturb this field. Successive processors will only change the Header History Status field in this record from C to H.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1153", FieldName = "Historical Job ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Populated with the applicable Job ID by party creating the currently active Header. Successive processors do not disturb this field. Successive processors will only change the Header History Status field in this record from C to H.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1153", FieldName = "Historical Job ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Populated with the applicable Job ID by party creating the currently active Header. Successive processors do not disturb this field. Successive processors will only change the Header History Status field in this record from C to H.", Type = "string", Format = "zfillnumeric")]
		[Column("HistoricalJobId", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("HDR-1153")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string HistoricalJobId { get; set; }

		/// <summary>
		/// Licensed User's Job Number (HDR-1102)
		/// The Licensed User's (who created this iteration of Mail.dat) internal Job Number.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1102", FieldName = "Licensed User's Job Number", Start = 26, Length = 25, Required = false, Key = false, DataType = "A/N", Description = "The Licensed User's (who created this iteration of Mail.dat) internal Job Number.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1102", FieldName = "Licensed User's Job Number", Start = 26, Length = 25, Required = false, Key = false, DataType = "A/N", Description = "The Licensed User's (who created this iteration of Mail.dat) internal Job Number.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1102", FieldName = "Licensed User's Job Number", Start = 26, Length = 25, Required = false, Key = false, DataType = "A/N", Description = "The Licensed User's (who created this iteration of Mail.dat) internal Job Number.", Type = "string", Format = "leftjustify")]
		[Column("LicensedUserSJobNumber", Order = 7, TypeName = "TEXT")]
		[MaxLength(25)]
		[Comment("HDR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string LicensedUserSJobNumber { get; set; }

		/// <summary>
		/// Job Name/Title & Issue (HDR-1103)
		/// Applicable Job, Title-Issue, Campaign Name, or description.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1103", FieldName = "Job Name/Title & Issue", Start = 51, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Applicable Job, Title-Issue, Campaign Name, or description.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1103", FieldName = "Job Name/Title & Issue", Start = 51, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Applicable Job, Title-Issue, Campaign Name, or description.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1103", FieldName = "Job Name/Title & Issue", Start = 51, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Applicable Job, Title-Issue, Campaign Name, or description.", Type = "string", Format = "leftjustify")]
		[Column("JobNameTitleIssue", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobNameTitleIssue { get; set; }

		/// <summary>
		/// File Source (HDR-1104)
		/// Name of the originator supplying the files.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1104", FieldName = "File Source", Start = 81, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of the originator supplying the files.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1104", FieldName = "File Source", Start = 81, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of the originator supplying the files.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1104", FieldName = "File Source", Start = 81, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of the originator supplying the files.", Type = "string", Format = "leftjustify")]
		[Column("FileSource", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1104")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string FileSource { get; set; }

		/// <summary>
		/// User License Code (HDR-1105)
		/// ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters,
		/// have no spaces, have no special characters, not be case sensitive.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1105", FieldName = "User License Code", Start = 111, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters, have no Spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1105", FieldName = "User License Code", Start = 111, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters, have no Spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1105", FieldName = "User License Code", Start = 111, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters, have no spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[Column("UserLicenseCode", Order = 10, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("HDR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserLicenseCode { get; set; }

		/// <summary>
		/// Contact Name (HDR-1106)
		/// Ex: John Smith. Name of individual for contact support at originator of this file.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1106", FieldName = "Contact Name", Start = 115, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support at originator of this file.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1106", FieldName = "Contact Name", Start = 115, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support at originator of this file.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1106", FieldName = "Contact Name", Start = 115, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support at originator of this file.", Type = "string", Format = "leftjustify")]
		[Column("ContactName", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ContactName { get; set; }

		/// <summary>
		/// Contact Telephone Number (HDR-1107)
		/// Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1107", FieldName = "Contact Telephone Number", Start = 145, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1107", FieldName = "Contact Telephone Number", Start = 145, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1107", FieldName = "Contact Telephone Number", Start = 145, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.", Type = "string", Format = "leftjustify")]
		[Column("ContactTelephoneNumber", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("HDR-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ContactTelephoneNumber { get; set; }

		/// <summary>
		/// Contact Email (HDR-1157)
		/// Email address of who created this iteration of Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1157", FieldName = "Contact Email", Start = 155, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of who created this iteration of Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1157", FieldName = "Contact Email", Start = 155, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of who created this iteration of Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1157", FieldName = "Contact Email", Start = 155, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of who created this iteration of Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("ContactEmail", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(60)]
		[Comment("HDR-1157")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ContactEmail { get; set; }

		/// <summary>
		/// Date Prepared (HDR-1108)
		/// Date originator transmitted this file.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1108", FieldName = "Date Prepared", Start = 215, Length = 8, Required = true, Key = false, DataType = "N", Description = "Date originator transmitted this file.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1108", FieldName = "Date Prepared", Start = 215, Length = 8, Required = true, Key = false, DataType = "N", Description = "Date originator transmitted this file.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1108", FieldName = "Date Prepared", Start = 215, Length = 8, Required = true, Key = false, DataType = "N", Description = "Date originator transmitted this file.", Type = "date", Format = "YYYYMMDD")]
		[Column("DatePrepared", Order = 14, TypeName = "TEXT")]
		[Required]
		[Comment("HDR-1108")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly DatePrepared { get; set; }

		/// <summary>
		/// Time Prepared (HDR-1109)
		/// (Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1109", FieldName = "Time Prepared", Start = 223, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "(Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).", Type = "time", Format = "HH:MM")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1109", FieldName = "Time Prepared", Start = 223, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "(Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).", Type = "time", Format = "HH:MM")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1109", FieldName = "Time Prepared", Start = 223, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "(Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).", Type = "time", Format = "HH:MM")]
		[Column("TimePrepared", Order = 15, TypeName = "TEXT")]
		[Required]
		[Comment("HDR-1109")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public TimeOnly TimePrepared { get; set; }

		/// <summary>
		/// Mail.dat Revision (HDR-1192)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1192", FieldName = "Mail.dat Revision", Start = 228, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1192", FieldName = "Mail.dat Revision", Start = 228, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1192", FieldName = "Mail.dat Revision", Start = 228, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MailDatRevision", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(5)]
		[AllowedValues("0.3", "0.5", "1.5")]
		[Comment("HDR-1192")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailDatRevisions))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatRevision { get; set; }

		/// <summary>
		/// Segment Record Count (HDR-1111)
		/// The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat®
		/// is an expected behavior within this specification.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1111", FieldName = "Segment Record Count", Start = 233, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat® is an Expected behavior within this specification.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1111", FieldName = "Segment Record Count", Start = 233, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat® is an Expected behavior within this specification.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1111", FieldName = "Segment Record Count", Start = 233, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat® is an expected behavior within this specification.", Type = "integer", Format = "zfill")]
		[Column("SegmentRecordCount", Order = 17, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1111")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int SegmentRecordCount { get; set; }

		/// <summary>
		/// Segment File Status (HDR-1112)
		/// In this field, and all following Status fields, O, D, R and N describe action upon an entire file. C
		/// and U indicate that only individual records are modified.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1112", FieldName = "Segment File Status", Start = 239, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "In this field, and all following Status fields, O, D, R and N Describe action upon an entire file. C and U indicate that only Individual records are modified.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1112", FieldName = "Segment File Status", Start = 239, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "In this field, and all following Status fields, O, D, R and N Describe action upon an entire file. C and U indicate that only Individual records are modified.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1112", FieldName = "Segment File Status", Start = 239, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "In this field, and all following Status fields, O, D, R and N describe action upon an entire file. C and U indicate that only individual records are modified.", Type = "enum", Format = "leftjustify")]
		[Column("SegmentFileStatus", Order = 18, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SegmentFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SegmentFileStatus { get; set; }

		/// <summary>
		/// Mail Piece Unit Record Count (HDR-1113)
		/// The number of Mail Piece Unit records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1113", FieldName = "Mail Piece Unit Record Count", Start = 240, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mail Piece Unit records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1113", FieldName = "Mail Piece Unit Record Count", Start = 240, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mail Piece Unit records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1113", FieldName = "Mail Piece Unit Record Count", Start = 240, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mail Piece Unit records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MailPieceUnitRecordCount", Order = 19, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1113")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int MailPieceUnitRecordCount { get; set; }

		/// <summary>
		/// Mail Piece Unit File Status (HDR-1114)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1114", FieldName = "Mail Piece Unit File Status", Start = 246, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1114", FieldName = "Mail Piece Unit File Status", Start = 246, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1114", FieldName = "Mail Piece Unit File Status", Start = 246, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("MailPieceUnitFileStatus", Order = 20, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1114")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailPieceUnitFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitFileStatus { get; set; }

		/// <summary>
		/// MPU / C Relationship Record Count (HDR-1115)
		/// The number of MPU / C Relationship records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1115", FieldName = "MPU / C Relationship Record Count", Start = 247, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of MPU / C Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1115", FieldName = "MPU / C Relationship Record Count", Start = 247, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of MPU / C Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1115", FieldName = "MPU / C Relationship Record Count", Start = 247, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of MPU / C Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MpuCRelationshipRecordCount", Order = 21, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1115")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int MpuCRelationshipRecordCount { get; set; }

		/// <summary>
		/// MPU / C Relationship File Status (HDR-1116)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1116", FieldName = "MPU / C Relationship File Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1116", FieldName = "MPU / C Relationship File Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1116", FieldName = "MPU / C Relationship File Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("MpuCRelationshipFileStatus", Order = 22, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1116")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MpuCRelationshipFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MpuCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Mailer Postage Account Record Count (HDR-1158)
		/// The number of Mailer's Postage Account records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1158", FieldName = "Mailer Postage Account Record Count", Start = 254, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mailer's Postage Account records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1158", FieldName = "Mailer Postage Account Record Count", Start = 254, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mailer's Postage Account records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1158", FieldName = "Mailer Postage Account Record Count", Start = 254, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mailer's Postage Account records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MailerPostageAccountRecordCount", Order = 23, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1158")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int MailerPostageAccountRecordCount { get; set; }

		/// <summary>
		/// Mailer Postage Account File Status (HDR-1159)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1159", FieldName = "Mailer Postage Account File Status", Start = 260, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1159", FieldName = "Mailer Postage Account File Status", Start = 260, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1159", FieldName = "Mailer Postage Account File Status", Start = 260, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("MailerPostageAccountFileStatus", Order = 24, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1159")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailerPostageAccountFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailerPostageAccountFileStatus { get; set; }

		/// <summary>
		/// Component Record Count (HDR-1118)
		/// The number of Component records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1118", FieldName = "Component Record Count", Start = 261, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1118", FieldName = "Component Record Count", Start = 261, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1118", FieldName = "Component Record Count", Start = 261, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ComponentRecordCount", Order = 25, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1118")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ComponentRecordCount { get; set; }

		/// <summary>
		/// Component File Status (HDR-1119)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1119", FieldName = "Component File Status", Start = 267, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1119", FieldName = "Component File Status", Start = 267, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1119", FieldName = "Component File Status", Start = 267, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentFileStatus", Order = 26, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1119")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentFileStatus { get; set; }

		/// <summary>
		/// Component Characteristic Record Count (HDR-1181)
		/// The number of Component Characteristics records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1181", FieldName = "Component Characteristic Record Count", Start = 268, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component Characteristics records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1181", FieldName = "Component Characteristic Record Count", Start = 268, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component Characteristics records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1181", FieldName = "Component Characteristic Record Count", Start = 268, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component Characteristics records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ComponentCharacteristicRecordCount", Order = 27, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1181")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ComponentCharacteristicRecordCount { get; set; }

		/// <summary>
		/// Component Characteristic File Status (HDR-1180)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1180", FieldName = "Component Characteristic File Status", Start = 274, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1180", FieldName = "Component Characteristic File Status", Start = 274, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1180", FieldName = "Component Characteristic File Status", Start = 274, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("ComponentCharacteristicFileStatus", Order = 28, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1180")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ComponentCharacteristicFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentCharacteristicFileStatus { get; set; }

		/// <summary>
		/// Container Summary Record Count (HDR-1120)
		/// The number of Container Summary records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1120", FieldName = "Container Summary Record Count", Start = 275, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Container Summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1120", FieldName = "Container Summary Record Count", Start = 275, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Container Summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1120", FieldName = "Container Summary Record Count", Start = 275, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Container Summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ContainerSummaryRecordCount", Order = 29, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1120")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerSummaryRecordCount { get; set; }

		/// <summary>
		/// Container Summary File Status (HDR-1121)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1121", FieldName = "Container Summary File Status", Start = 281, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1121", FieldName = "Container Summary File Status", Start = 281, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1121", FieldName = "Container Summary File Status", Start = 281, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("ContainerSummaryFileStatus", Order = 30, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1121")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ContainerSummaryFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ContainerSummaryFileStatus { get; set; }

		/// <summary>
		/// Container Quantity Record Count (HDR-1126)
		/// The number of Container Quantity records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1126", FieldName = "Container Quantity Record Count", Start = 282, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Container Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1126", FieldName = "Container Quantity Record Count", Start = 282, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Container Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1126", FieldName = "Container Quantity Record Count", Start = 282, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Container Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ContainerQuantityRecordCount", Order = 31, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1126")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerQuantityRecordCount { get; set; }

		/// <summary>
		/// Container Quantity File Status (HDR-1127)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1127", FieldName = "Container Quantity File Status", Start = 290, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1127", FieldName = "Container Quantity File Status", Start = 290, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1127", FieldName = "Container Quantity File Status", Start = 290, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("ContainerQuantityFileStatus", Order = 32, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1127")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ContainerQuantityFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ContainerQuantityFileStatus { get; set; }

		/// <summary>
		/// Package Quantity Record Count (HDR-1128)
		/// The number of Package Quantity records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1128", FieldName = "Package Quantity Record Count", Start = 291, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Package Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1128", FieldName = "Package Quantity Record Count", Start = 291, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Package Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1128", FieldName = "Package Quantity Record Count", Start = 291, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Package Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PackageQuantityRecordCount", Order = 33, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1128")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int PackageQuantityRecordCount { get; set; }

		/// <summary>
		/// Package Quantity File Status (HDR-1129)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1129", FieldName = "Package Quantity File Status", Start = 299, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1129", FieldName = "Package Quantity File Status", Start = 299, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1129", FieldName = "Package Quantity File Status", Start = 299, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("PackageQuantityFileStatus", Order = 34, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1129")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PackageQuantityFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageQuantityFileStatus { get; set; }

		/// <summary>
		/// Walk Sequence Record Count (HDR-1130)
		/// The number of Walk Sequence records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1130", FieldName = "Walk Sequence Record Count", Start = 300, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Walk Sequence records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1130", FieldName = "Walk Sequence Record Count", Start = 300, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Walk Sequence records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1130", FieldName = "Walk Sequence Record Count", Start = 300, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Walk Sequence records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceRecordCount", Order = 35, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1130")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int WalkSequenceRecordCount { get; set; }

		/// <summary>
		/// Walk Sequence File Status (HDR-1131)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1131", FieldName = "Walk Sequence File Status", Start = 308, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1131", FieldName = "Walk Sequence File Status", Start = 308, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1131", FieldName = "Walk Sequence File Status", Start = 308, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceFileStatus", Order = 36, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1131")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(WalkSequenceFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string WalkSequenceFileStatus { get; set; }

		/// <summary>
		/// Seed Name Record Count (HDR-1132)
		/// The number of Seed Name records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1132", FieldName = "Seed Name Record Count", Start = 309, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Seed Name records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1132", FieldName = "Seed Name Record Count", Start = 309, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Seed Name records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1132", FieldName = "Seed Name Record Count", Start = 309, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Seed Name records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SeedNameRecordCount", Order = 37, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1132")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int SeedNameRecordCount { get; set; }

		/// <summary>
		/// Seed Name File Status (HDR-1133)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1133", FieldName = "Seed Name File Status", Start = 317, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1133", FieldName = "Seed Name File Status", Start = 317, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1133", FieldName = "Seed Name File Status", Start = 317, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("SeedNameFileStatus", Order = 38, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1133")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SeedNameFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SeedNameFileStatus { get; set; }

		/// <summary>
		/// IJ / C Relationship Record Count (HDR-1136)
		/// The number of Ink Jet/Container Relationship records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1136", FieldName = "IJ / C Relationship Record Count", Start = 318, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Ink Jet/Container Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1136", FieldName = "IJ / C Relationship Record Count", Start = 318, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Ink Jet/Container Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1136", FieldName = "IJ / C Relationship Record Count", Start = 318, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Ink Jet/Container Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("IJCRelationshipRecordCount", Order = 39, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1136")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int IJCRelationshipRecordCount { get; set; }

		/// <summary>
		/// IJ / C Relationship File Status (HDR-1137)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1137", FieldName = "IJ / C Relationship File Status", Start = 326, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1137", FieldName = "IJ / C Relationship File Status", Start = 326, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1137", FieldName = "IJ / C Relationship File Status", Start = 326, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("IJCRelationshipFileStatus", Order = 40, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1137")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(IJCRelationshipFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string IJCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Piece Detail Record Count (HDR-1138)
		/// The number of Piece Detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1138", FieldName = "Piece Detail Record Count", Start = 327, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1138", FieldName = "Piece Detail Record Count", Start = 327, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1138", FieldName = "Piece Detail Record Count", Start = 327, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PieceDetailRecordCount", Order = 41, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1138")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int PieceDetailRecordCount { get; set; }

		/// <summary>
		/// Piece Detail File Status (HDR-1139)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1139", FieldName = "Piece Detail File Status", Start = 337, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1139", FieldName = "Piece Detail File Status", Start = 337, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1139", FieldName = "Piece Detail File Status", Start = 337, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("PieceDetailFileStatus", Order = 42, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1139")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PieceDetailFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceDetailFileStatus { get; set; }

		/// <summary>
		/// Piece Barcode Record Count (HDR-1178)
		/// The number of Piece barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1178", FieldName = "Piece Barcode Record Count", Start = 338, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1178", FieldName = "Piece Barcode Record Count", Start = 338, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1178", FieldName = "Piece Barcode Record Count", Start = 338, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PieceBarcodeRecordCount", Order = 43, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1178")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int PieceBarcodeRecordCount { get; set; }

		/// <summary>
		/// Piece Barcode File Status (HDR-1179)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1179", FieldName = "Piece Barcode File Status", Start = 348, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1179", FieldName = "Piece Barcode File Status", Start = 348, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1179", FieldName = "Piece Barcode File Status", Start = 348, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("PieceBarcodeFileStatus", Order = 44, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1179")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PieceBarcodeFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceBarcodeFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Record Count (HDR-1140)
		/// The number of Special Fees/Charges records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1140", FieldName = "Special Fee/Charge Record Count", Start = 349, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1140", FieldName = "Special Fee/Charge Record Count", Start = 349, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1140", FieldName = "Special Fee/Charge Record Count", Start = 349, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SpecialFeeChargeRecordCount", Order = 45, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1140")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int SpecialFeeChargeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge File Status (HDR-1141)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1141", FieldName = "Special Fee/Charge File Status", Start = 359, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1141", FieldName = "Special Fee/Charge File Status", Start = 359, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1141", FieldName = "Special Fee/Charge File Status", Start = 359, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("SpecialFeeChargeFileStatus", Order = 46, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1141")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SpecialFeeChargeFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SpecialFeeChargeFileStatus { get; set; }

		/// <summary>
		/// Postage Adjustment Record Count (HDR-1146)
		/// The number of Postage Adjustment records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1146", FieldName = "Postage Adjustment Record Count", Start = 360, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Postage Adjustment records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1146", FieldName = "Postage Adjustment Record Count", Start = 360, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Postage Adjustment records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1146", FieldName = "Postage Adjustment Record Count", Start = 360, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Postage Adjustment records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PostageAdjustmentRecordCount", Order = 47, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1146")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int PostageAdjustmentRecordCount { get; set; }

		/// <summary>
		/// Postage Adjustment File Status (HDR-1147)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1147", FieldName = "Postage Adjustment File Status", Start = 366, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1147", FieldName = "Postage Adjustment File Status", Start = 366, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1147", FieldName = "Postage Adjustment File Status", Start = 366, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("PostageAdjustmentFileStatus", Order = 48, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1147")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PostageAdjustmentFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PostageAdjustmentFileStatus { get; set; }

		/// <summary>
		/// Original Container Identification Record Count (HDR-1172)
		/// The number of Original Container Identification records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1172", FieldName = "Original Container Identification Record Count", Start = 367, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Original Container Identification records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1172", FieldName = "Original Container Identification Record Count", Start = 367, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Original Container Identification records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1172", FieldName = "Original Container Identification Record Count", Start = 367, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Original Container Identification records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("OriginalContainerIdentificationRecordCount", Order = 49, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1172")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int OriginalContainerIdentificationRecordCount { get; set; }

		/// <summary>
		/// Original Container Identification File Status (HDR-1173)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1173", FieldName = "Original Container Identification File Status", Start = 373, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1173", FieldName = "Original Container Identification File Status", Start = 373, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1173", FieldName = "Original Container Identification File Status", Start = 373, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("OriginalContainerIdentificationFileStatus", Order = 50, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1173")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(OriginalContainerIdentificationFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalContainerIdentificationFileStatus { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address Record Count (HDR-1184)
		/// The number of original Un-coded parcel address Records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1184", FieldName = "Un-Coded Parcel Address Record Count", Start = 374, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of original Un-coded parcel address Records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1184", FieldName = "Un-Coded Parcel Address Record Count", Start = 374, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of original Un-coded parcel address Records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1184", FieldName = "Un-Coded Parcel Address Record Count", Start = 374, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of original Un-coded parcel address Records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("UnCodedParcelAddressRecordCount", Order = 51, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1184")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int UnCodedParcelAddressRecordCount { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address File Status (HDR-1185)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1185", FieldName = "Un-Coded Parcel Address File Status", Start = 380, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1185", FieldName = "Un-Coded Parcel Address File Status", Start = 380, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1185", FieldName = "Un-Coded Parcel Address File Status", Start = 380, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("UnCodedParcelAddressFileStatus", Order = 52, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1185")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(UnCodedParcelAddressFileStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UnCodedParcelAddressFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Record Count (HDR-1186)
		/// The number of Special Fees/Charges Barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1186", FieldName = "Special Fee/Charge Barcode Record Count", Start = 381, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges Barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1186", FieldName = "Special Fee/Charge Barcode Record Count", Start = 381, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges Barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1186", FieldName = "Special Fee/Charge Barcode Record Count", Start = 381, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges Barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SpecialFeeChargeBarcodeRecordCount", Order = 53, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1186")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int SpecialFeeChargeBarcodeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Status (HDR-1187)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1187", FieldName = "Special Fee/Charge Barcode Status", Start = 391, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1187", FieldName = "Special Fee/Charge Barcode Status", Start = 391, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1187", FieldName = "Special Fee/Charge Barcode Status", Start = 391, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SpecialFeeChargeBarcodeStatus", Order = 54, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1187")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SpecialFeeChargeBarcodeStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SpecialFeeChargeBarcodeStatus { get; set; }

		/// <summary>
		/// Extra Piece Detail Record Count (HDR-1188)
		/// The number of Extra Piece Detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1188", FieldName = "Extra Piece Detail Record Count", Start = 392, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Extra Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1188", FieldName = "Extra Piece Detail Record Count", Start = 392, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Extra Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1188", FieldName = "Extra Piece Detail Record Count", Start = 392, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Extra Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ExtraPieceDetailRecordCount", Order = 55, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1188")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ExtraPieceDetailRecordCount { get; set; }

		/// <summary>
		/// Extra Piece Detail Status (HDR-1189)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1189", FieldName = "Extra Piece Detail Status", Start = 402, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1189", FieldName = "Extra Piece Detail Status", Start = 402, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1189", FieldName = "Extra Piece Detail Status", Start = 402, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ExtraPieceDetailStatus", Order = 56, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1189")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ExtraPieceDetailStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ExtraPieceDetailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Record Count (HDR-1190)
		/// The number of referenceable mail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1190", FieldName = "Referenceable Mail Record Count", Start = 403, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1190", FieldName = "Referenceable Mail Record Count", Start = 403, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1190", FieldName = "Referenceable Mail Record Count", Start = 403, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailRecordCount", Order = 57, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1190")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ReferenceableMailRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Status (HDR-1191)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1191", FieldName = "Referenceable Mail Status", Start = 413, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1191", FieldName = "Referenceable Mail Status", Start = 413, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1191", FieldName = "Referenceable Mail Status", Start = 413, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailStatus", Order = 58, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1191")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ReferenceableMailStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReferenceableMailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Record Count (HDR-1193)
		/// The number of referenceable mail summary records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1193", FieldName = "Referenceable Mail Summary Record Count", Start = 414, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1193", FieldName = "Referenceable Mail Summary Record Count", Start = 414, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1193", FieldName = "Referenceable Mail Summary Record Count", Start = 414, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailSummaryRecordCount", Order = 59, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1193")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ReferenceableMailSummaryRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Status (HDR-1194)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1194", FieldName = "Referenceable Mail Summary Status", Start = 424, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1194", FieldName = "Referenceable Mail Summary Status", Start = 424, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1194", FieldName = "Referenceable Mail Summary Status", Start = 424, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailSummaryStatus", Order = 60, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1194")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ReferenceableMailSummaryStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReferenceableMailSummaryStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Record Count (HDR-1195)
		/// The number of referenceable mail barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1195", FieldName = "Referenceable Mail Barcode Record Count", Start = 425, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1195", FieldName = "Referenceable Mail Barcode Record Count", Start = 425, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1195", FieldName = "Referenceable Mail Barcode Record Count", Start = 425, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailBarcodeRecordCount", Order = 61, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1195")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ReferenceableMailBarcodeRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Status (HDR-1196)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1196", FieldName = "Referenceable Mail Barcode Status", Start = 435, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1196", FieldName = "Referenceable Mail Barcode Status", Start = 435, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1196", FieldName = "Referenceable Mail Barcode Status", Start = 435, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailBarcodeStatus", Order = 62, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1196")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ReferenceableMailBarcodeStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReferenceableMailBarcodeStatus { get; set; }

		/// <summary>
		/// Transportation Summary Record Count (HDR-1197)
		/// The number of transportation summary records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1197", FieldName = "Transportation Summary Record Count", Start = 436, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of transportation summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("TransportationSummaryRecordCount", Order = 63, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1197")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1")]
		public int TransportationSummaryRecordCount { get; set; }

		/// <summary>
		/// Transportation Summary Record Status (HDR-1198)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1198", FieldName = "Transportation Summary Record Status", Start = 442, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("TransportationSummaryRecordStatus", Order = 64, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1198")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TransportationSummaryRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TransportationSummaryRecordStatus { get; set; }

		/// <summary>
		/// Transportation Geo-Data Record Count (HDR-1199)
		/// The number of certificate of mailing detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1199", FieldName = "Transportation Geo-Data Record Count", Start = 443, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("TransportationGeoDataRecordCount", Order = 65, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1199")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1")]
		public int TransportationGeoDataRecordCount { get; set; }

		/// <summary>
		/// Transportation Geo-Data Record Status (HDR-2001)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2001", FieldName = "Transportation Geo-Data Record Status", Start = 449, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("TransportationGeoDataRecordStatus", Order = 66, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-2001")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TransportationGeoDataRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TransportationGeoDataRecordStatus { get; set; }

		/// <summary>
		/// Transportation Detail Record Count (HDR-2002)
		/// The number of transportation detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2002", FieldName = "Transportation Detail Record Count", Start = 450, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of transportation detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("TransportationDetailRecordCount", Order = 67, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-2002")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1")]
		public int TransportationDetailRecordCount { get; set; }

		/// <summary>
		/// Transportation Detail Record Status (HDR-2003)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2003", FieldName = "Transportation Detail Record Status", Start = 456, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("TransportationDetailRecordStatus", Order = 68, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-2003")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TransportationDetailRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TransportationDetailRecordStatus { get; set; }

		/// <summary>
		/// Transportation Container Record Count (HDR-2004)
		/// The number of transportation container records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2004", FieldName = "Transportation Container Record Count", Start = 457, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of transportation container records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("TransportationContainerRecordCount", Order = 69, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-2004")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1")]
		public int TransportationContainerRecordCount { get; set; }

		/// <summary>
		/// Transportation Container Record Status (HDR-2005)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2005", FieldName = "Transportation Container Record Status", Start = 463, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("TransportationContainerRecordStatus", Order = 70, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-2005")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TransportationContainerRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TransportationContainerRecordStatus { get; set; }

		/// <summary>
		/// Transportation Container Status Record Count (HDR-2006)
		/// The number of transportation container records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2006", FieldName = "Transportation Container Status Record Count", Start = 464, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of transportation container records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("TransportationContainerStatusRecordCount", Order = 71, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-2006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1")]
		public int TransportationContainerStatusRecordCount { get; set; }

		/// <summary>
		/// Transportation Container Status Record Status (HDR-2007)
		/// O, D, R, N, C, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-2007", FieldName = "Transportation Container Status Record Status", Start = 470, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, R, N, C, U.", Type = "enum", Format = "leftjustify")]
		[Column("TransportationContainerStatusRecordStatus", Order = 72, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-2007")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(TransportationContainerStatusRecordStatuses))]
		[MaildatVersions("23-1")]
		public string TransportationContainerStatusRecordStatus { get; set; }

		/// <summary>
		/// Mail.dat Presentation Category (HDR-1154)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1154", FieldName = "Mail.dat Presentation Category", Start = 471, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1154", FieldName = "Mail.dat Presentation Category", Start = 476, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1154", FieldName = "Mail.dat Presentation Category", Start = 476, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MailDatPresentationCategory", Order = 73, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "E", "I", "M", "N", "P", "R")]
		[Comment("HDR-1154")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(MailDatPresentationCategories))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatPresentationCategory { get; set; }

		/// <summary>
		/// Original Software Vendor Name (HDR-1174)
		/// Originator company name of this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1174", FieldName = "Original Software Vendor Name", Start = 472, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator company name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1174", FieldName = "Original Software Vendor Name", Start = 477, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator company name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1174", FieldName = "Original Software Vendor Name", Start = 477, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator company name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVendorName", Order = 74, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1174")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalSoftwareVendorName { get; set; }

		/// <summary>
		/// Original Software Products Name (HDR-1175)
		/// Originator product name of this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1175", FieldName = "Original Software Products Name", Start = 502, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator product name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1175", FieldName = "Original Software Products Name", Start = 507, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator product name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1175", FieldName = "Original Software Products Name", Start = 507, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator product name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareProductsName", Order = 75, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1175")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalSoftwareProductsName { get; set; }

		/// <summary>
		/// Original Software Version (HDR-1176)
		/// Originator software version of this Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1176", FieldName = "Original Software Version", Start = 532, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Originator software version of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1176", FieldName = "Original Software Version", Start = 537, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Originator software version of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1176", FieldName = "Original Software Version", Start = 537, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Originator software version of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVersion", Order = 76, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("HDR-1176")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalSoftwareVersion { get; set; }

		/// <summary>
		/// Original Software Vendor's Email (HDR-1177)
		/// Originator software company email address.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1177", FieldName = "Original Software Vendor's Email", Start = 542, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Originator software company email address.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1177", FieldName = "Original Software Vendor's Email", Start = 547, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Originator software company email address.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1177", FieldName = "Original Software Vendor's Email", Start = 547, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Originator software company email address.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVendorSEmail", Order = 77, TypeName = "TEXT")]
		[Required]
		[MaxLength(60)]
		[Comment("HDR-1177")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor Name (HDR-1150)
		/// May be name of in-house proprietary software. Name of author of software creating the Mail.dat® as
		/// appended to this respective .hdr record. This may be the name of the transmitting agent, if they
		/// wrote their own proprietary home-grown software.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1150", FieldName = "Mail.dat Software Vendor Name", Start = 602, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "May be name of in-house proprietary software. Name of Author of software creating the Mail.dat® as appended to this Respective .hdr record. This may be the name of the transmitting Agent, if they wrote their own proprietary home-grown software.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1150", FieldName = "Mail.dat Software Vendor Name", Start = 607, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "May be name of in-house proprietary software. Name of Author of software creating the Mail.dat® as appended to this Respective .hdr record. This may be the name of the transmitting Agent, if they wrote their own proprietary home-grown software.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1150", FieldName = "Mail.dat Software Vendor Name", Start = 607, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "May be name of in-house proprietary software. Name of author of software creating the Mail.dat® as appended to this respective .hdr record. This may be the name of the transmitting agent, if they wrote their own proprietary home-grown software.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVendorName", Order = 78, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1150")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatSoftwareVendorName { get; set; }

		/// <summary>
		/// Mail.dat Software Product's Name (HDR-1155)
		/// Name of product creating this Header and applicable data in associated records.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1155", FieldName = "Mail.dat Software Product's Name", Start = 632, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of product creating this Header and applicable data in associated records.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1155", FieldName = "Mail.dat Software Product's Name", Start = 637, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of product creating this Header and applicable data in associated records.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1155", FieldName = "Mail.dat Software Product's Name", Start = 637, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of product creating this Header and applicable data in associated records.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareProductSName", Order = 79, TypeName = "TEXT")]
		[Required]
		[MaxLength(30)]
		[Comment("HDR-1155")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatSoftwareProductSName { get; set; }

		/// <summary>
		/// Mail.dat Software Version (HDR-1151)
		/// Version of the software creating the transmitted Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1151", FieldName = "Mail.dat Software Version", Start = 662, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Version of the software creating the transmitted Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1151", FieldName = "Mail.dat Software Version", Start = 667, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Version of the software creating the transmitted Mail.dat.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1151", FieldName = "Mail.dat Software Version", Start = 667, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Version of the software creating the transmitted Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVersion", Order = 80, TypeName = "TEXT")]
		[Required]
		[MaxLength(10)]
		[Comment("HDR-1151")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatSoftwareVersion { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor's Email (HDR-1156)
		/// Email address of party creating product named above.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1156", FieldName = "Mail.dat Software Vendor's Email", Start = 672, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of party creating product named above.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1156", FieldName = "Mail.dat Software Vendor's Email", Start = 677, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of party creating product named above.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1156", FieldName = "Mail.dat Software Vendor's Email", Start = 677, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of party creating product named above.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVendorSEmail", Order = 81, TypeName = "TEXT")]
		[Required]
		[MaxLength(60)]
		[Comment("HDR-1156")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailDatSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Reserve (HDR-1162)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1162", FieldName = "Reserve", Start = 732, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveHdr1162", Order = 82, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("HDR-1162")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1")]
		public string ReserveHdr1162 { get; set; }

		/// <summary>
		/// Zone Matrix Date (HDR-1160)
		/// (cannot be all zeros).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1160", FieldName = "Zone Matrix Date", Start = 733, Length = 8, Required = false, Key = false, DataType = "N", Description = "(cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1160", FieldName = "Zone Matrix Date", Start = 737, Length = 8, Required = false, Key = false, DataType = "N", Description = "(cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1160", FieldName = "Zone Matrix Date", Start = 737, Length = 8, Required = false, Key = false, DataType = "N", Description = "(cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("ZoneMatrixDate", Order = 83, TypeName = "TEXT")]
		[Comment("HDR-1160")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly? ZoneMatrixDate { get; set; }

		/// <summary>
		/// eDoc Sender CRID (HDR-1183)
		/// This USPS-assigned id, CRID, will be used by the USPS to uniquely identify the submitter of
		/// electronic documentation to the PostalOne! system. This field will be used to identify a new
		/// business role, called the eDoc submitter, which may be different from the mail preparer, mail owner,
		/// mail transporter, and scheduler roles. Only digits 0-9 acceptable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1183", FieldName = "EDoc Sender CRID", Start = 741, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used by the USPS to Uniquely identify the submitter of electronic documentation to the PostalOne! system. This field will be used to identify a new Business role, called the eDoc submitter, which may be different From the mail preparer, mail owner, mail transporter, and Scheduler roles.  Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1183", FieldName = "EDoc Sender CRID", Start = 745, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used by the USPS to Uniquely identify the submitter of electronic documentation to the PostalOne! system. This field will be used to identify a new Business role, called the eDoc submitter, which may be different From the mail preparer, mail owner, mail transporter, and Scheduler roles.  Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1183", FieldName = "EDoc Sender CRID", Start = 745, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used by the USPS to uniquely identify the submitter of electronic documentation to the PostalOne! system. This field will be used to identify a new business role, called the eDoc submitter, which may be different from the mail preparer, mail owner, mail transporter, and scheduler roles. Only digits 0-9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("EDocSenderCrid", Order = 84, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("HDR-1183")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string EDocSenderCrid { get; set; }

		/// <summary>
		/// Information Exchange (HDR-1182)
		/// This field is for the exchange of private information between sender and catcher.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1182", FieldName = "Information Exchange", Start = 753, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "This field is for the exchange of private information between sender and catcher.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1182", FieldName = "Information Exchange", Start = 757, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "This field is for the exchange of private information between sender and catcher.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1182", FieldName = "Information Exchange", Start = 757, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "This field is for the exchange of private information between sender and catcher.", Type = "string", Format = "leftjustify")]
		[Column("InformationExchange", Order = 85, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("HDR-1182")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string InformationExchange { get; set; }

		/// <summary>
		/// User Option Field (HDR-1152)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-1152", FieldName = "User Option Field", Start = 773, Length = 1227, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1152", FieldName = "User Option Field", Start = 777, Length = 1223, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1152", FieldName = "User Option Field", Start = 777, Length = 1223, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 86, TypeName = "TEXT")]
		[MaxLength(1227)]
		[Comment("HDR-1152")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Closing Character (HDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "hdr", FieldCode = "HDR-9999", FieldName = "Closing Character", Start = 2000, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-9999", FieldName = "Closing Character", Start = 2000, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-9999", FieldName = "Closing Character", Start = 2000, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 87, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("HDR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Certificate of Mailing Header Record Count (HDR-1201)
		/// The number of Certificate of Mailing Header records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1201", FieldName = "Certificate of Mailing Header Record Count", Start = 436, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Certificate of Mailing Header records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1201", FieldName = "Certificate of Mailing Header Record Count", Start = 436, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Certificate of Mailing Header records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingHeaderRecordCount", Order = 88, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1201")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("24-1", "25-1")]
		public int CertificateOfMailingHeaderRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Header Status (HDR-1202)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1202", FieldName = "Certificate of Mailing Header Status", Start = 442, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1202", FieldName = "Certificate of Mailing Header Status", Start = 442, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingHeaderStatus", Order = 89, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1202")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CertificateOfMailingHeaderStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingHeaderStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Record Count (HDR-1203)
		/// The number of certificate of mailing detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1203", FieldName = "Certificate of Mailing Detail Record Count", Start = 443, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1203", FieldName = "Certificate of Mailing Detail Record Count", Start = 443, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingDetailRecordCount", Order = 90, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1203")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("24-1", "25-1")]
		public int CertificateOfMailingDetailRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Status (HDR-1204)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1204", FieldName = "Certificate of Mailing Detail Status", Start = 453, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1204", FieldName = "Certificate of Mailing Detail Status", Start = 453, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingDetailStatus", Order = 91, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1204")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CertificateOfMailingDetailStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingDetailStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Record Count (HDR-1205)
		/// The number of certificate of mailing bulk records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1205", FieldName = "Certificate of Mailing Bulk Record Count", Start = 454, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing bulk records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1205", FieldName = "Certificate of Mailing Bulk Record Count", Start = 454, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing bulk records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingBulkRecordCount", Order = 92, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1205")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("24-1", "25-1")]
		public int CertificateOfMailingBulkRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Status (HDR-1206)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1206", FieldName = "Certificate of Mailing Bulk Status", Start = 464, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1206", FieldName = "Certificate of Mailing Bulk Status", Start = 464, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingBulkStatus", Order = 93, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1206")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CertificateOfMailingBulkStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingBulkStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Record Count (HDR-1207)
		/// The number of certificate of mailing services records in this Mail.dat.
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1207", FieldName = "Certificate of Mailing Services Record Count", Start = 465, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing services records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1207", FieldName = "Certificate of Mailing Services Record Count", Start = 465, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing services records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingServicesRecordCount", Order = 94, TypeName = "INTEGER")]
		[Required]
		[Comment("HDR-1207")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("24-1", "25-1")]
		public int CertificateOfMailingServicesRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Status (HDR-1208)
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "hdr", FieldCode = "HDR-1208", FieldName = "Certificate of Mailing Services Status", Start = 475, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "hdr", FieldCode = "HDR-1208", FieldName = "Certificate of Mailing Services Status", Start = 475, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingServicesStatus", Order = 95, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		[Comment("HDR-1208")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CertificateOfMailingServicesStatuses))]
		[MaildatVersions("24-1", "25-1")]
		public string CertificateOfMailingServicesStatus { get; set; }

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Hdr, string>(version, p => p.JobId, returnValue);
			this.MailDatVersion = line.ParseForImport<Hdr, string>(version, p => p.MailDatVersion, returnValue);
			this.HeaderHistorySequenceNumber = line.ParseForImport<Hdr, int>(version, p => p.HeaderHistorySequenceNumber, returnValue);
			this.HeaderHistoryStatus = line.ParseForImport<Hdr, string>(version, p => p.HeaderHistoryStatus, returnValue);
			this.HistoricalJobId = line.ParseForImport<Hdr, string>(version, p => p.HistoricalJobId, returnValue);
			this.LicensedUserSJobNumber = line.ParseForImport<Hdr, string>(version, p => p.LicensedUserSJobNumber, returnValue);
			this.JobNameTitleIssue = line.ParseForImport<Hdr, string>(version, p => p.JobNameTitleIssue, returnValue);
			this.FileSource = line.ParseForImport<Hdr, string>(version, p => p.FileSource, returnValue);
			this.UserLicenseCode = line.ParseForImport<Hdr, string>(version, p => p.UserLicenseCode, returnValue);
			this.ContactName = line.ParseForImport<Hdr, string>(version, p => p.ContactName, returnValue);
			this.ContactTelephoneNumber = line.ParseForImport<Hdr, string>(version, p => p.ContactTelephoneNumber, returnValue);
			this.ContactEmail = line.ParseForImport<Hdr, string>(version, p => p.ContactEmail, returnValue);
			this.DatePrepared = line.ParseForImport<Hdr, DateOnly>(version, p => p.DatePrepared, returnValue);
			this.TimePrepared = line.ParseForImport<Hdr, TimeOnly>(version, p => p.TimePrepared, returnValue);
			this.MailDatRevision = line.ParseForImport<Hdr, string>(version, p => p.MailDatRevision, returnValue);
			this.SegmentRecordCount = line.ParseForImport<Hdr, int>(version, p => p.SegmentRecordCount, returnValue);
			this.SegmentFileStatus = line.ParseForImport<Hdr, string>(version, p => p.SegmentFileStatus, returnValue);
			this.MailPieceUnitRecordCount = line.ParseForImport<Hdr, int>(version, p => p.MailPieceUnitRecordCount, returnValue);
			this.MailPieceUnitFileStatus = line.ParseForImport<Hdr, string>(version, p => p.MailPieceUnitFileStatus, returnValue);
			this.MpuCRelationshipRecordCount = line.ParseForImport<Hdr, int>(version, p => p.MpuCRelationshipRecordCount, returnValue);
			this.MpuCRelationshipFileStatus = line.ParseForImport<Hdr, string>(version, p => p.MpuCRelationshipFileStatus, returnValue);
			this.MailerPostageAccountRecordCount = line.ParseForImport<Hdr, int>(version, p => p.MailerPostageAccountRecordCount, returnValue);
			this.MailerPostageAccountFileStatus = line.ParseForImport<Hdr, string>(version, p => p.MailerPostageAccountFileStatus, returnValue);
			this.ComponentRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ComponentRecordCount, returnValue);
			this.ComponentFileStatus = line.ParseForImport<Hdr, string>(version, p => p.ComponentFileStatus, returnValue);
			this.ComponentCharacteristicRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ComponentCharacteristicRecordCount, returnValue);
			this.ComponentCharacteristicFileStatus = line.ParseForImport<Hdr, string>(version, p => p.ComponentCharacteristicFileStatus, returnValue);
			this.ContainerSummaryRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ContainerSummaryRecordCount, returnValue);
			this.ContainerSummaryFileStatus = line.ParseForImport<Hdr, string>(version, p => p.ContainerSummaryFileStatus, returnValue);
			this.ContainerQuantityRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ContainerQuantityRecordCount, returnValue);
			this.ContainerQuantityFileStatus = line.ParseForImport<Hdr, string>(version, p => p.ContainerQuantityFileStatus, returnValue);
			this.PackageQuantityRecordCount = line.ParseForImport<Hdr, int>(version, p => p.PackageQuantityRecordCount, returnValue);
			this.PackageQuantityFileStatus = line.ParseForImport<Hdr, string>(version, p => p.PackageQuantityFileStatus, returnValue);
			this.WalkSequenceRecordCount = line.ParseForImport<Hdr, int>(version, p => p.WalkSequenceRecordCount, returnValue);
			this.WalkSequenceFileStatus = line.ParseForImport<Hdr, string>(version, p => p.WalkSequenceFileStatus, returnValue);
			this.SeedNameRecordCount = line.ParseForImport<Hdr, int>(version, p => p.SeedNameRecordCount, returnValue);
			this.SeedNameFileStatus = line.ParseForImport<Hdr, string>(version, p => p.SeedNameFileStatus, returnValue);
			this.IJCRelationshipRecordCount = line.ParseForImport<Hdr, int>(version, p => p.IJCRelationshipRecordCount, returnValue);
			this.IJCRelationshipFileStatus = line.ParseForImport<Hdr, string>(version, p => p.IJCRelationshipFileStatus, returnValue);
			this.PieceDetailRecordCount = line.ParseForImport<Hdr, int>(version, p => p.PieceDetailRecordCount, returnValue);
			this.PieceDetailFileStatus = line.ParseForImport<Hdr, string>(version, p => p.PieceDetailFileStatus, returnValue);
			this.PieceBarcodeRecordCount = line.ParseForImport<Hdr, int>(version, p => p.PieceBarcodeRecordCount, returnValue);
			this.PieceBarcodeFileStatus = line.ParseForImport<Hdr, string>(version, p => p.PieceBarcodeFileStatus, returnValue);
			this.SpecialFeeChargeRecordCount = line.ParseForImport<Hdr, int>(version, p => p.SpecialFeeChargeRecordCount, returnValue);
			this.SpecialFeeChargeFileStatus = line.ParseForImport<Hdr, string>(version, p => p.SpecialFeeChargeFileStatus, returnValue);
			this.PostageAdjustmentRecordCount = line.ParseForImport<Hdr, int>(version, p => p.PostageAdjustmentRecordCount, returnValue);
			this.PostageAdjustmentFileStatus = line.ParseForImport<Hdr, string>(version, p => p.PostageAdjustmentFileStatus, returnValue);
			this.OriginalContainerIdentificationRecordCount = line.ParseForImport<Hdr, int>(version, p => p.OriginalContainerIdentificationRecordCount, returnValue);
			this.OriginalContainerIdentificationFileStatus = line.ParseForImport<Hdr, string>(version, p => p.OriginalContainerIdentificationFileStatus, returnValue);
			this.UnCodedParcelAddressRecordCount = line.ParseForImport<Hdr, int>(version, p => p.UnCodedParcelAddressRecordCount, returnValue);
			this.UnCodedParcelAddressFileStatus = line.ParseForImport<Hdr, string>(version, p => p.UnCodedParcelAddressFileStatus, returnValue);
			this.SpecialFeeChargeBarcodeRecordCount = line.ParseForImport<Hdr, int>(version, p => p.SpecialFeeChargeBarcodeRecordCount, returnValue);
			this.SpecialFeeChargeBarcodeStatus = line.ParseForImport<Hdr, string>(version, p => p.SpecialFeeChargeBarcodeStatus, returnValue);
			this.ExtraPieceDetailRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ExtraPieceDetailRecordCount, returnValue);
			this.ExtraPieceDetailStatus = line.ParseForImport<Hdr, string>(version, p => p.ExtraPieceDetailStatus, returnValue);
			this.ReferenceableMailRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ReferenceableMailRecordCount, returnValue);
			this.ReferenceableMailStatus = line.ParseForImport<Hdr, string>(version, p => p.ReferenceableMailStatus, returnValue);
			this.ReferenceableMailSummaryRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ReferenceableMailSummaryRecordCount, returnValue);
			this.ReferenceableMailSummaryStatus = line.ParseForImport<Hdr, string>(version, p => p.ReferenceableMailSummaryStatus, returnValue);
			this.ReferenceableMailBarcodeRecordCount = line.ParseForImport<Hdr, int>(version, p => p.ReferenceableMailBarcodeRecordCount, returnValue);
			this.ReferenceableMailBarcodeStatus = line.ParseForImport<Hdr, string>(version, p => p.ReferenceableMailBarcodeStatus, returnValue);
			this.TransportationSummaryRecordCount = line.ParseForImport<Hdr, int>(version, p => p.TransportationSummaryRecordCount, returnValue);
			this.TransportationSummaryRecordStatus = line.ParseForImport<Hdr, string>(version, p => p.TransportationSummaryRecordStatus, returnValue);
			this.TransportationGeoDataRecordCount = line.ParseForImport<Hdr, int>(version, p => p.TransportationGeoDataRecordCount, returnValue);
			this.TransportationGeoDataRecordStatus = line.ParseForImport<Hdr, string>(version, p => p.TransportationGeoDataRecordStatus, returnValue);
			this.TransportationDetailRecordCount = line.ParseForImport<Hdr, int>(version, p => p.TransportationDetailRecordCount, returnValue);
			this.TransportationDetailRecordStatus = line.ParseForImport<Hdr, string>(version, p => p.TransportationDetailRecordStatus, returnValue);
			this.TransportationContainerRecordCount = line.ParseForImport<Hdr, int>(version, p => p.TransportationContainerRecordCount, returnValue);
			this.TransportationContainerRecordStatus = line.ParseForImport<Hdr, string>(version, p => p.TransportationContainerRecordStatus, returnValue);
			this.TransportationContainerStatusRecordCount = line.ParseForImport<Hdr, int>(version, p => p.TransportationContainerStatusRecordCount, returnValue);
			this.TransportationContainerStatusRecordStatus = line.ParseForImport<Hdr, string>(version, p => p.TransportationContainerStatusRecordStatus, returnValue);
			this.MailDatPresentationCategory = line.ParseForImport<Hdr, string>(version, p => p.MailDatPresentationCategory, returnValue);
			this.OriginalSoftwareVendorName = line.ParseForImport<Hdr, string>(version, p => p.OriginalSoftwareVendorName, returnValue);
			this.OriginalSoftwareProductsName = line.ParseForImport<Hdr, string>(version, p => p.OriginalSoftwareProductsName, returnValue);
			this.OriginalSoftwareVersion = line.ParseForImport<Hdr, string>(version, p => p.OriginalSoftwareVersion, returnValue);
			this.OriginalSoftwareVendorSEmail = line.ParseForImport<Hdr, string>(version, p => p.OriginalSoftwareVendorSEmail, returnValue);
			this.MailDatSoftwareVendorName = line.ParseForImport<Hdr, string>(version, p => p.MailDatSoftwareVendorName, returnValue);
			this.MailDatSoftwareProductSName = line.ParseForImport<Hdr, string>(version, p => p.MailDatSoftwareProductSName, returnValue);
			this.MailDatSoftwareVersion = line.ParseForImport<Hdr, string>(version, p => p.MailDatSoftwareVersion, returnValue);
			this.MailDatSoftwareVendorSEmail = line.ParseForImport<Hdr, string>(version, p => p.MailDatSoftwareVendorSEmail, returnValue);
			this.ReserveHdr1162 = line.ParseForImport<Hdr, string>(version, p => p.ReserveHdr1162, returnValue);
			this.ZoneMatrixDate = line.ParseForImport<Hdr, DateOnly?>(version, p => p.ZoneMatrixDate, returnValue);
			this.EDocSenderCrid = line.ParseForImport<Hdr, string>(version, p => p.EDocSenderCrid, returnValue);
			this.InformationExchange = line.ParseForImport<Hdr, string>(version, p => p.InformationExchange, returnValue);
			this.UserOptionField = line.ParseForImport<Hdr, string>(version, p => p.UserOptionField, returnValue);
			this.ClosingCharacter = line.ParseForImport<Hdr, string>(version, p => p.ClosingCharacter, returnValue);
			this.CertificateOfMailingHeaderRecordCount = line.ParseForImport<Hdr, int>(version, p => p.CertificateOfMailingHeaderRecordCount, returnValue);
			this.CertificateOfMailingHeaderStatus = line.ParseForImport<Hdr, string>(version, p => p.CertificateOfMailingHeaderStatus, returnValue);
			this.CertificateOfMailingDetailRecordCount = line.ParseForImport<Hdr, int>(version, p => p.CertificateOfMailingDetailRecordCount, returnValue);
			this.CertificateOfMailingDetailStatus = line.ParseForImport<Hdr, string>(version, p => p.CertificateOfMailingDetailStatus, returnValue);
			this.CertificateOfMailingBulkRecordCount = line.ParseForImport<Hdr, int>(version, p => p.CertificateOfMailingBulkRecordCount, returnValue);
			this.CertificateOfMailingBulkStatus = line.ParseForImport<Hdr, string>(version, p => p.CertificateOfMailingBulkStatus, returnValue);
			this.CertificateOfMailingServicesRecordCount = line.ParseForImport<Hdr, int>(version, p => p.CertificateOfMailingServicesRecordCount, returnValue);
			this.CertificateOfMailingServicesStatus = line.ParseForImport<Hdr, string>(version, p => p.CertificateOfMailingServicesStatus, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Hdr, string>(version, p => p.JobId));
			sb.Append(this.MailDatVersion.FormatForExport<Hdr, string>(version, p => p.MailDatVersion));
			sb.Append(this.HeaderHistorySequenceNumber.FormatForExport<Hdr, int>(version, p => p.HeaderHistorySequenceNumber));
			sb.Append(this.HeaderHistoryStatus.FormatForExport<Hdr, string>(version, p => p.HeaderHistoryStatus));
			sb.Append(this.HistoricalJobId.FormatForExport<Hdr, string>(version, p => p.HistoricalJobId));
			sb.Append(this.LicensedUserSJobNumber.FormatForExport<Hdr, string>(version, p => p.LicensedUserSJobNumber));
			sb.Append(this.JobNameTitleIssue.FormatForExport<Hdr, string>(version, p => p.JobNameTitleIssue));
			sb.Append(this.FileSource.FormatForExport<Hdr, string>(version, p => p.FileSource));
			sb.Append(this.UserLicenseCode.FormatForExport<Hdr, string>(version, p => p.UserLicenseCode));
			sb.Append(this.ContactName.FormatForExport<Hdr, string>(version, p => p.ContactName));
			sb.Append(this.ContactTelephoneNumber.FormatForExport<Hdr, string>(version, p => p.ContactTelephoneNumber));
			sb.Append(this.ContactEmail.FormatForExport<Hdr, string>(version, p => p.ContactEmail));
			sb.Append(this.DatePrepared.FormatForExport<Hdr, DateOnly>(version, p => p.DatePrepared));
			sb.Append(this.TimePrepared.FormatForExport<Hdr, TimeOnly>(version, p => p.TimePrepared));
			sb.Append(this.MailDatRevision.FormatForExport<Hdr, string>(version, p => p.MailDatRevision));
			sb.Append(this.SegmentRecordCount.FormatForExport<Hdr, int>(version, p => p.SegmentRecordCount));
			sb.Append(this.SegmentFileStatus.FormatForExport<Hdr, string>(version, p => p.SegmentFileStatus));
			sb.Append(this.MailPieceUnitRecordCount.FormatForExport<Hdr, int>(version, p => p.MailPieceUnitRecordCount));
			sb.Append(this.MailPieceUnitFileStatus.FormatForExport<Hdr, string>(version, p => p.MailPieceUnitFileStatus));
			sb.Append(this.MpuCRelationshipRecordCount.FormatForExport<Hdr, int>(version, p => p.MpuCRelationshipRecordCount));
			sb.Append(this.MpuCRelationshipFileStatus.FormatForExport<Hdr, string>(version, p => p.MpuCRelationshipFileStatus));
			sb.Append(this.MailerPostageAccountRecordCount.FormatForExport<Hdr, int>(version, p => p.MailerPostageAccountRecordCount));
			sb.Append(this.MailerPostageAccountFileStatus.FormatForExport<Hdr, string>(version, p => p.MailerPostageAccountFileStatus));
			sb.Append(this.ComponentRecordCount.FormatForExport<Hdr, int>(version, p => p.ComponentRecordCount));
			sb.Append(this.ComponentFileStatus.FormatForExport<Hdr, string>(version, p => p.ComponentFileStatus));
			sb.Append(this.ComponentCharacteristicRecordCount.FormatForExport<Hdr, int>(version, p => p.ComponentCharacteristicRecordCount));
			sb.Append(this.ComponentCharacteristicFileStatus.FormatForExport<Hdr, string>(version, p => p.ComponentCharacteristicFileStatus));
			sb.Append(this.ContainerSummaryRecordCount.FormatForExport<Hdr, int>(version, p => p.ContainerSummaryRecordCount));
			sb.Append(this.ContainerSummaryFileStatus.FormatForExport<Hdr, string>(version, p => p.ContainerSummaryFileStatus));
			sb.Append(this.ContainerQuantityRecordCount.FormatForExport<Hdr, int>(version, p => p.ContainerQuantityRecordCount));
			sb.Append(this.ContainerQuantityFileStatus.FormatForExport<Hdr, string>(version, p => p.ContainerQuantityFileStatus));
			sb.Append(this.PackageQuantityRecordCount.FormatForExport<Hdr, int>(version, p => p.PackageQuantityRecordCount));
			sb.Append(this.PackageQuantityFileStatus.FormatForExport<Hdr, string>(version, p => p.PackageQuantityFileStatus));
			sb.Append(this.WalkSequenceRecordCount.FormatForExport<Hdr, int>(version, p => p.WalkSequenceRecordCount));
			sb.Append(this.WalkSequenceFileStatus.FormatForExport<Hdr, string>(version, p => p.WalkSequenceFileStatus));
			sb.Append(this.SeedNameRecordCount.FormatForExport<Hdr, int>(version, p => p.SeedNameRecordCount));
			sb.Append(this.SeedNameFileStatus.FormatForExport<Hdr, string>(version, p => p.SeedNameFileStatus));
			sb.Append(this.IJCRelationshipRecordCount.FormatForExport<Hdr, int>(version, p => p.IJCRelationshipRecordCount));
			sb.Append(this.IJCRelationshipFileStatus.FormatForExport<Hdr, string>(version, p => p.IJCRelationshipFileStatus));
			sb.Append(this.PieceDetailRecordCount.FormatForExport<Hdr, int>(version, p => p.PieceDetailRecordCount));
			sb.Append(this.PieceDetailFileStatus.FormatForExport<Hdr, string>(version, p => p.PieceDetailFileStatus));
			sb.Append(this.PieceBarcodeRecordCount.FormatForExport<Hdr, int>(version, p => p.PieceBarcodeRecordCount));
			sb.Append(this.PieceBarcodeFileStatus.FormatForExport<Hdr, string>(version, p => p.PieceBarcodeFileStatus));
			sb.Append(this.SpecialFeeChargeRecordCount.FormatForExport<Hdr, int>(version, p => p.SpecialFeeChargeRecordCount));
			sb.Append(this.SpecialFeeChargeFileStatus.FormatForExport<Hdr, string>(version, p => p.SpecialFeeChargeFileStatus));
			sb.Append(this.PostageAdjustmentRecordCount.FormatForExport<Hdr, int>(version, p => p.PostageAdjustmentRecordCount));
			sb.Append(this.PostageAdjustmentFileStatus.FormatForExport<Hdr, string>(version, p => p.PostageAdjustmentFileStatus));
			sb.Append(this.OriginalContainerIdentificationRecordCount.FormatForExport<Hdr, int>(version, p => p.OriginalContainerIdentificationRecordCount));
			sb.Append(this.OriginalContainerIdentificationFileStatus.FormatForExport<Hdr, string>(version, p => p.OriginalContainerIdentificationFileStatus));
			sb.Append(this.UnCodedParcelAddressRecordCount.FormatForExport<Hdr, int>(version, p => p.UnCodedParcelAddressRecordCount));
			sb.Append(this.UnCodedParcelAddressFileStatus.FormatForExport<Hdr, string>(version, p => p.UnCodedParcelAddressFileStatus));
			sb.Append(this.SpecialFeeChargeBarcodeRecordCount.FormatForExport<Hdr, int>(version, p => p.SpecialFeeChargeBarcodeRecordCount));
			sb.Append(this.SpecialFeeChargeBarcodeStatus.FormatForExport<Hdr, string>(version, p => p.SpecialFeeChargeBarcodeStatus));
			sb.Append(this.ExtraPieceDetailRecordCount.FormatForExport<Hdr, int>(version, p => p.ExtraPieceDetailRecordCount));
			sb.Append(this.ExtraPieceDetailStatus.FormatForExport<Hdr, string>(version, p => p.ExtraPieceDetailStatus));
			sb.Append(this.ReferenceableMailRecordCount.FormatForExport<Hdr, int>(version, p => p.ReferenceableMailRecordCount));
			sb.Append(this.ReferenceableMailStatus.FormatForExport<Hdr, string>(version, p => p.ReferenceableMailStatus));
			sb.Append(this.ReferenceableMailSummaryRecordCount.FormatForExport<Hdr, int>(version, p => p.ReferenceableMailSummaryRecordCount));
			sb.Append(this.ReferenceableMailSummaryStatus.FormatForExport<Hdr, string>(version, p => p.ReferenceableMailSummaryStatus));
			sb.Append(this.ReferenceableMailBarcodeRecordCount.FormatForExport<Hdr, int>(version, p => p.ReferenceableMailBarcodeRecordCount));
			sb.Append(this.ReferenceableMailBarcodeStatus.FormatForExport<Hdr, string>(version, p => p.ReferenceableMailBarcodeStatus));
			sb.Append(this.TransportationSummaryRecordCount.FormatForExport<Hdr, int>(version, p => p.TransportationSummaryRecordCount));
			sb.Append(this.TransportationSummaryRecordStatus.FormatForExport<Hdr, string>(version, p => p.TransportationSummaryRecordStatus));
			sb.Append(this.TransportationGeoDataRecordCount.FormatForExport<Hdr, int>(version, p => p.TransportationGeoDataRecordCount));
			sb.Append(this.TransportationGeoDataRecordStatus.FormatForExport<Hdr, string>(version, p => p.TransportationGeoDataRecordStatus));
			sb.Append(this.TransportationDetailRecordCount.FormatForExport<Hdr, int>(version, p => p.TransportationDetailRecordCount));
			sb.Append(this.TransportationDetailRecordStatus.FormatForExport<Hdr, string>(version, p => p.TransportationDetailRecordStatus));
			sb.Append(this.TransportationContainerRecordCount.FormatForExport<Hdr, int>(version, p => p.TransportationContainerRecordCount));
			sb.Append(this.TransportationContainerRecordStatus.FormatForExport<Hdr, string>(version, p => p.TransportationContainerRecordStatus));
			sb.Append(this.TransportationContainerStatusRecordCount.FormatForExport<Hdr, int>(version, p => p.TransportationContainerStatusRecordCount));
			sb.Append(this.TransportationContainerStatusRecordStatus.FormatForExport<Hdr, string>(version, p => p.TransportationContainerStatusRecordStatus));
			sb.Append(this.MailDatPresentationCategory.FormatForExport<Hdr, string>(version, p => p.MailDatPresentationCategory));
			sb.Append(this.OriginalSoftwareVendorName.FormatForExport<Hdr, string>(version, p => p.OriginalSoftwareVendorName));
			sb.Append(this.OriginalSoftwareProductsName.FormatForExport<Hdr, string>(version, p => p.OriginalSoftwareProductsName));
			sb.Append(this.OriginalSoftwareVersion.FormatForExport<Hdr, string>(version, p => p.OriginalSoftwareVersion));
			sb.Append(this.OriginalSoftwareVendorSEmail.FormatForExport<Hdr, string>(version, p => p.OriginalSoftwareVendorSEmail));
			sb.Append(this.MailDatSoftwareVendorName.FormatForExport<Hdr, string>(version, p => p.MailDatSoftwareVendorName));
			sb.Append(this.MailDatSoftwareProductSName.FormatForExport<Hdr, string>(version, p => p.MailDatSoftwareProductSName));
			sb.Append(this.MailDatSoftwareVersion.FormatForExport<Hdr, string>(version, p => p.MailDatSoftwareVersion));
			sb.Append(this.MailDatSoftwareVendorSEmail.FormatForExport<Hdr, string>(version, p => p.MailDatSoftwareVendorSEmail));
			sb.Append(this.ReserveHdr1162.FormatForExport<Hdr, string>(version, p => p.ReserveHdr1162));
			sb.Append(this.ZoneMatrixDate.FormatForExport<Hdr, DateOnly?>(version, p => p.ZoneMatrixDate));
			sb.Append(this.EDocSenderCrid.FormatForExport<Hdr, string>(version, p => p.EDocSenderCrid));
			sb.Append(this.InformationExchange.FormatForExport<Hdr, string>(version, p => p.InformationExchange));
			sb.Append(this.UserOptionField.FormatForExport<Hdr, string>(version, p => p.UserOptionField));
			sb.Append(this.ClosingCharacter.FormatForExport<Hdr, string>(version, p => p.ClosingCharacter));
			sb.Append(this.CertificateOfMailingHeaderRecordCount.FormatForExport<Hdr, int>(version, p => p.CertificateOfMailingHeaderRecordCount));
			sb.Append(this.CertificateOfMailingHeaderStatus.FormatForExport<Hdr, string>(version, p => p.CertificateOfMailingHeaderStatus));
			sb.Append(this.CertificateOfMailingDetailRecordCount.FormatForExport<Hdr, int>(version, p => p.CertificateOfMailingDetailRecordCount));
			sb.Append(this.CertificateOfMailingDetailStatus.FormatForExport<Hdr, string>(version, p => p.CertificateOfMailingDetailStatus));
			sb.Append(this.CertificateOfMailingBulkRecordCount.FormatForExport<Hdr, int>(version, p => p.CertificateOfMailingBulkRecordCount));
			sb.Append(this.CertificateOfMailingBulkStatus.FormatForExport<Hdr, string>(version, p => p.CertificateOfMailingBulkStatus));
			sb.Append(this.CertificateOfMailingServicesRecordCount.FormatForExport<Hdr, int>(version, p => p.CertificateOfMailingServicesRecordCount));
			sb.Append(this.CertificateOfMailingServicesStatus.FormatForExport<Hdr, string>(version, p => p.CertificateOfMailingServicesStatus));
			
			return Task.FromResult(sb.ToString());
		}
	}
}