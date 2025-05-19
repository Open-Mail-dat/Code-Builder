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
	/// Who, what and when of this job.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "hdr", File = "Header Record", Summary = "Who, what and when of this job.", Description = "Who, what and when of this job.")]
	[Table("Hdr", Schema = "Maildat")]
	public partial class Hdr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (HDR-1001)
		/// A Job ID (the Mail.dat® serial number) should be unique Compared to all other supplied Job IDs
		/// provided by the Same source. The Job ID assigned to any new Mail.dat® is Also to be applied to any
		/// Historical Header Record part of That transmission; it is the Historical Job ID that retains The
		/// initial ID throughout its existence. Job IDs are user Managed, but must remain unique within one
		/// User License Code.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "A Job ID (the Mail.dat® serial number) should be unique Compared to all other supplied Job IDs provided by the Same source. The Job ID assigned to any new Mail.dat® is Also to be applied to any Historical Header Record part of That transmission; it is the Historical Job ID that retains The initial ID throughout its existence. Job IDs are user Managed, but must remain unique within one User License Code.", Type = "string", Format = "zfillnumeric")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Mail.dat Version (HDR-1101)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1101", FieldName = "Mail.dat Version", Start = 9, Length = 4, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailDatVersion", Order = 2)]
		[Required]
		[MaxLength(4)]
		[AllowedValues("25-1")]
		public string MailDatVersion { get; set; }

		/// <summary>
		/// Header History Sequence Number (HDR-1025)
		/// First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this
		/// Mail.dat® as it is successively Processed would have a Header with a History Sequence Number = 9998,
		/// etc. Current Active Header would be next in The series, hence the record with the lowest History
		/// Sequence Value. Header History Status field (see next) also denotes Current active header.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1025", FieldName = "Header History Sequence Number", Start = 13, Length = 4, Required = true, Key = true, DataType = "N", Description = "First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this Mail.dat® as it is successively Processed would have a Header with a History Sequence Number = 9998, etc. Current Active Header would be next in The series, hence the record with the lowest History Sequence Value. Header History Status field (see next) also denotes Current active header.", Type = "string", Format = "zfill")]
		[Column("HeaderHistorySequenceNumber", Order = 3)]
		[Required]
		[Key]
		[MaxLength(4)]
		public string HeaderHistorySequenceNumber { get; set; }

		/// <summary>
		/// Header History Status (HDR-1148)
		/// Transmit all history records with subsequent transmissions. C = Current (this .hdr record is
		/// applicable to current Transmission) H = History (this .hdr record predates and is Associated with,
		/// but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a
		/// Specific Mail.dat® must be forwarded with that Mail.dat, or Portion thereof, if such transmission
		/// occurs. As applicable, the Received Header is updated by the Mail.dat® processor with an H in this
		/// field as it is passed along with the new Current Active Header to next recipient.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1148", FieldName = "Header History Status", Start = 17, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Transmit all history records with subsequent transmissions. C = Current (this .hdr record is applicable to current Transmission) H = History (this .hdr record predates and is Associated with, but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a Specific Mail.dat® must be forwarded with that Mail.dat, or Portion thereof, if such transmission occurs. As applicable, the Received Header is updated by the Mail.dat® processor with an H in this field as it is passed along with the new Current Active Header to next recipient.", Type = "enum", Format = "leftjustify")]
		[Column("HeaderHistoryStatus", Order = 4)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "H")]
		public string HeaderHistoryStatus { get; set; }

		/// <summary>
		/// Historical Job ID (HDR-1153)
		/// Populated with the applicable Job ID by party creating the currently active Header. Successive
		/// processors do not disturb this field. Successive processors will only change the Header History
		/// Status field in this record from C to H.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1153", FieldName = "Historical Job ID", Start = 18, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Populated with the applicable Job ID by party creating the currently active Header. Successive processors do not disturb this field. Successive processors will only change the Header History Status field in this record from C to H.", Type = "string", Format = "zfillnumeric")]
		[Column("HistoricalJobID", Order = 5)]
		[Required]
		[MaxLength(8)]
		public string HistoricalJobID { get; set; }

		/// <summary>
		/// Licensed User's Job Number (HDR-1102)
		/// The Licensed User's (who created this iteration of Mail.dat) internal Job Number.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1102", FieldName = "Licensed User's Job Number", Start = 26, Length = 25, Required = false, Key = false, DataType = "A/N", Description = "The Licensed User's (who created this iteration of Mail.dat) internal Job Number.", Type = "string", Format = "leftjustify")]
		[Column("LicensedUserSJobNumber", Order = 6)]
		[MaxLength(25)]
		public string LicensedUserSJobNumber { get; set; }

		/// <summary>
		/// Job Name/Title & Issue (HDR-1103)
		/// Applicable Job, Title-Issue, Campaign Name, or description.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1103", FieldName = "Job Name/Title & Issue", Start = 51, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Applicable Job, Title-Issue, Campaign Name, or description.", Type = "string", Format = "leftjustify")]
		[Column("JobNameTitleIssue", Order = 7)]
		[Required]
		[MaxLength(30)]
		public string JobNameTitleIssue { get; set; }

		/// <summary>
		/// File Source (HDR-1104)
		/// Name of the originator supplying the files.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1104", FieldName = "File Source", Start = 81, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of the originator supplying the files.", Type = "string", Format = "leftjustify")]
		[Column("FileSource", Order = 8)]
		[Required]
		[MaxLength(30)]
		public string FileSource { get; set; }

		/// <summary>
		/// User License Code (HDR-1105)
		/// ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters,
		/// have no Spaces, have no special characters, not be case sensitive.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1105", FieldName = "User License Code", Start = 111, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters, have no Spaces, have no special characters, not be case sensitive.", Type = "string", Format = "leftjustify")]
		[Column("UserLicenseCode", Order = 9)]
		[MaxLength(4)]
		public string UserLicenseCode { get; set; }

		/// <summary>
		/// Contact Name (HDR-1106)
		/// Ex: John Smith. Name of individual for contact support at originator of this file.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1106", FieldName = "Contact Name", Start = 115, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Ex: John Smith. Name of individual for contact support at originator of this file.", Type = "string", Format = "leftjustify")]
		[Column("ContactName", Order = 10)]
		[Required]
		[MaxLength(30)]
		public string ContactName { get; set; }

		/// <summary>
		/// Contact Telephone Number (HDR-1107)
		/// Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1107", FieldName = "Contact Telephone Number", Start = 145, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.", Type = "string", Format = "leftjustify")]
		[Column("ContactTelephoneNumber", Order = 11)]
		[Required]
		[MaxLength(10)]
		public string ContactTelephoneNumber { get; set; }

		/// <summary>
		/// Contact Email (HDR-1157)
		/// Email address of who created this iteration of Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1157", FieldName = "Contact Email", Start = 155, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of who created this iteration of Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("ContactEmail", Order = 12)]
		[Required]
		[MaxLength(60)]
		public string ContactEmail { get; set; }

		/// <summary>
		/// Date Prepared (HDR-1108)
		/// Date originator transmitted this file.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1108", FieldName = "Date Prepared", Start = 215, Length = 8, Required = true, Key = false, DataType = "N", Description = "Date originator transmitted this file.", Type = "date", Format = "YYYYMMDD")]
		[Column("DatePrepared", Order = 13)]
		[Required]
		public DateOnly DatePrepared { get; set; }

		/// <summary>
		/// Time Prepared (HDR-1109)
		/// (Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1109", FieldName = "Time Prepared", Start = 223, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "(Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).", Type = "time", Format = "HH:MM")]
		[Column("TimePrepared", Order = 14)]
		[Required]
		public TimeOnly TimePrepared { get; set; }

		/// <summary>
		/// Mail.dat Revision (HDR-1192)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1192", FieldName = "Mail.dat Revision", Start = 228, Length = 5, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailDatRevision", Order = 15)]
		[Required]
		[MaxLength(5)]
		[AllowedValues("0.2")]
		public string MailDatRevision { get; set; }

		/// <summary>
		/// Segment Record Count (HDR-1111)
		/// The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat®
		/// is an Expected behavior within this specification.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1111", FieldName = "Segment Record Count", Start = 233, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat® is an Expected behavior within this specification.", Type = "integer", Format = "zfill")]
		[Column("SegmentRecordCount", Order = 16)]
		[Required]
		public int SegmentRecordCount { get; set; }

		/// <summary>
		/// Segment File Status (HDR-1112)
		/// In this field, and all following Status fields, O, D, R and N Describe action upon an entire file. C
		/// and U indicate that only Individual records are modified.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1112", FieldName = "Segment File Status", Start = 239, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "In this field, and all following Status fields, O, D, R and N Describe action upon an entire file. C and U indicate that only Individual records are modified.", Type = "enum", Format = "leftjustify")]
		[Column("SegmentFileStatus", Order = 17)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string SegmentFileStatus { get; set; }

		/// <summary>
		/// Mail Piece Unit Record Count (HDR-1113)
		/// The number of Mail Piece Unit records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1113", FieldName = "Mail Piece Unit Record Count", Start = 240, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mail Piece Unit records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MailPieceUnitRecordCount", Order = 18)]
		[Required]
		public int MailPieceUnitRecordCount { get; set; }

		/// <summary>
		/// Mail Piece Unit File Status (HDR-1114)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1114", FieldName = "Mail Piece Unit File Status", Start = 246, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailPieceUnitFileStatus", Order = 19)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string MailPieceUnitFileStatus { get; set; }

		/// <summary>
		/// MPU / C Relationship Record Count (HDR-1115)
		/// The number of MPU / C Relationship records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1115", FieldName = "MPU / C Relationship Record Count", Start = 247, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of MPU / C Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MPUCRelationshipRecordCount", Order = 20)]
		[Required]
		public int MPUCRelationshipRecordCount { get; set; }

		/// <summary>
		/// MPU / C Relationship File Status (HDR-1116)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1116", FieldName = "MPU / C Relationship File Status", Start = 253, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MPUCRelationshipFileStatus", Order = 21)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string MPUCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Mailer Postage Account Record Count (HDR-1158)
		/// The number of Mailer's Postage Account records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1158", FieldName = "Mailer Postage Account Record Count", Start = 254, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Mailer's Postage Account records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("MailerPostageAccountRecordCount", Order = 22)]
		[Required]
		public int MailerPostageAccountRecordCount { get; set; }

		/// <summary>
		/// Mailer Postage Account File Status (HDR-1159)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1159", FieldName = "Mailer Postage Account File Status", Start = 260, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailerPostageAccountFileStatus", Order = 23)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string MailerPostageAccountFileStatus { get; set; }

		/// <summary>
		/// Component Record Count (HDR-1118)
		/// The number of Component records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1118", FieldName = "Component Record Count", Start = 261, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ComponentRecordCount", Order = 24)]
		[Required]
		public int ComponentRecordCount { get; set; }

		/// <summary>
		/// Component File Status (HDR-1119)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1119", FieldName = "Component File Status", Start = 267, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ComponentFileStatus", Order = 25)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ComponentFileStatus { get; set; }

		/// <summary>
		/// Component Characteristic Record Count (HDR-1181)
		/// The number of Component Characteristics records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1181", FieldName = "Component Characteristic Record Count", Start = 268, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Component Characteristics records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ComponentCharacteristicRecordCount", Order = 26)]
		[Required]
		public int ComponentCharacteristicRecordCount { get; set; }

		/// <summary>
		/// Component Characteristic File Status (HDR-1180)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1180", FieldName = "Component Characteristic File Status", Start = 274, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ComponentCharacteristicFileStatus", Order = 27)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ComponentCharacteristicFileStatus { get; set; }

		/// <summary>
		/// Container Summary Record Count (HDR-1120)
		/// The number of Container Summary records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1120", FieldName = "Container Summary Record Count", Start = 275, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Container Summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ContainerSummaryRecordCount", Order = 28)]
		[Required]
		public int ContainerSummaryRecordCount { get; set; }

		/// <summary>
		/// Container Summary File Status (HDR-1121)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1121", FieldName = "Container Summary File Status", Start = 281, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ContainerSummaryFileStatus", Order = 29)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ContainerSummaryFileStatus { get; set; }

		/// <summary>
		/// Container Quantity Record Count (HDR-1126)
		/// The number of Container Quantity records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1126", FieldName = "Container Quantity Record Count", Start = 282, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Container Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ContainerQuantityRecordCount", Order = 30)]
		[Required]
		public int ContainerQuantityRecordCount { get; set; }

		/// <summary>
		/// Container Quantity File Status (HDR-1127)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1127", FieldName = "Container Quantity File Status", Start = 290, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ContainerQuantityFileStatus", Order = 31)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ContainerQuantityFileStatus { get; set; }

		/// <summary>
		/// Package Quantity Record Count (HDR-1128)
		/// The number of Package Quantity records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1128", FieldName = "Package Quantity Record Count", Start = 291, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Package Quantity records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PackageQuantityRecordCount", Order = 32)]
		[Required]
		public int PackageQuantityRecordCount { get; set; }

		/// <summary>
		/// Package Quantity File Status (HDR-1129)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1129", FieldName = "Package Quantity File Status", Start = 299, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PackageQuantityFileStatus", Order = 33)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string PackageQuantityFileStatus { get; set; }

		/// <summary>
		/// Walk Sequence Record Count (HDR-1130)
		/// The number of Walk Sequence records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1130", FieldName = "Walk Sequence Record Count", Start = 300, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Walk Sequence records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceRecordCount", Order = 34)]
		[Required]
		public int WalkSequenceRecordCount { get; set; }

		/// <summary>
		/// Walk Sequence File Status (HDR-1131)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1131", FieldName = "Walk Sequence File Status", Start = 308, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceFileStatus", Order = 35)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string WalkSequenceFileStatus { get; set; }

		/// <summary>
		/// Seed Name Record Count (HDR-1132)
		/// The number of Seed Name records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1132", FieldName = "Seed Name Record Count", Start = 309, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Seed Name records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SeedNameRecordCount", Order = 36)]
		[Required]
		public int SeedNameRecordCount { get; set; }

		/// <summary>
		/// Seed Name File Status (HDR-1133)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1133", FieldName = "Seed Name File Status", Start = 317, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SeedNameFileStatus", Order = 37)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string SeedNameFileStatus { get; set; }

		/// <summary>
		/// IJ / C Relationship Record Count (HDR-1136)
		/// The number of Ink Jet/Container Relationship records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1136", FieldName = "IJ / C Relationship Record Count", Start = 318, Length = 8, Required = true, Key = false, DataType = "N", Description = "The number of Ink Jet/Container Relationship records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("IJCRelationshipRecordCount", Order = 38)]
		[Required]
		public int IJCRelationshipRecordCount { get; set; }

		/// <summary>
		/// IJ / C Relationship File Status (HDR-1137)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1137", FieldName = "IJ / C Relationship File Status", Start = 326, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("IJCRelationshipFileStatus", Order = 39)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string IJCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Piece Detail Record Count (HDR-1138)
		/// The number of Piece Detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1138", FieldName = "Piece Detail Record Count", Start = 327, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PieceDetailRecordCount", Order = 40)]
		[Required]
		public int PieceDetailRecordCount { get; set; }

		/// <summary>
		/// Piece Detail File Status (HDR-1139)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1139", FieldName = "Piece Detail File Status", Start = 337, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PieceDetailFileStatus", Order = 41)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string PieceDetailFileStatus { get; set; }

		/// <summary>
		/// Piece Barcode Record Count (HDR-1178)
		/// The number of Piece barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1178", FieldName = "Piece Barcode Record Count", Start = 338, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Piece barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PieceBarcodeRecordCount", Order = 42)]
		[Required]
		public int PieceBarcodeRecordCount { get; set; }

		/// <summary>
		/// Piece Barcode File Status (HDR-1179)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1179", FieldName = "Piece Barcode File Status", Start = 348, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PieceBarcodeFileStatus", Order = 43)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string PieceBarcodeFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Record Count (HDR-1140)
		/// The number of Special Fees/Charges records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1140", FieldName = "Special Fee/Charge Record Count", Start = 349, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SpecialFeeChargeRecordCount", Order = 44)]
		[Required]
		public int SpecialFeeChargeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge File Status (HDR-1141)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1141", FieldName = "Special Fee/Charge File Status", Start = 359, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SpecialFeeChargeFileStatus", Order = 45)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string SpecialFeeChargeFileStatus { get; set; }

		/// <summary>
		/// Postage Adjustment Record Count (HDR-1146)
		/// The number of Postage Adjustment records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1146", FieldName = "Postage Adjustment Record Count", Start = 360, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Postage Adjustment records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("PostageAdjustmentRecordCount", Order = 46)]
		[Required]
		public int PostageAdjustmentRecordCount { get; set; }

		/// <summary>
		/// Postage Adjustment File Status (HDR-1147)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1147", FieldName = "Postage Adjustment File Status", Start = 366, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("PostageAdjustmentFileStatus", Order = 47)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string PostageAdjustmentFileStatus { get; set; }

		/// <summary>
		/// Original Container Identification Record Count (HDR-1172)
		/// The number of Original Container Identification records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1172", FieldName = "Original Container Identification Record Count", Start = 367, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Original Container Identification records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("OriginalContainerIdentificationRecordCount", Order = 48)]
		[Required]
		public int OriginalContainerIdentificationRecordCount { get; set; }

		/// <summary>
		/// Original Container Identification File Status (HDR-1173)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1173", FieldName = "Original Container Identification File Status", Start = 373, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("OriginalContainerIdentificationFileStatus", Order = 49)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string OriginalContainerIdentificationFileStatus { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address Record Count (HDR-1184)
		/// The number of original Un-coded parcel address Records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1184", FieldName = "Un-Coded Parcel Address Record Count", Start = 374, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of original Un-coded parcel address Records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("UnCodedParcelAddressRecordCount", Order = 50)]
		[Required]
		public int UnCodedParcelAddressRecordCount { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address File Status (HDR-1185)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1185", FieldName = "Un-Coded Parcel Address File Status", Start = 380, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("UnCodedParcelAddressFileStatus", Order = 51)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string UnCodedParcelAddressFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Record Count (HDR-1186)
		/// The number of Special Fees/Charges Barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1186", FieldName = "Special Fee/Charge Barcode Record Count", Start = 381, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Special Fees/Charges Barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("SpecialFeeChargeBarcodeRecordCount", Order = 52)]
		[Required]
		public int SpecialFeeChargeBarcodeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Status (HDR-1187)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1187", FieldName = "Special Fee/Charge Barcode Status", Start = 391, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SpecialFeeChargeBarcodeStatus", Order = 53)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string SpecialFeeChargeBarcodeStatus { get; set; }

		/// <summary>
		/// Extra Piece Detail Record Count (HDR-1188)
		/// The number of Extra Piece Detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1188", FieldName = "Extra Piece Detail Record Count", Start = 392, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of Extra Piece Detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ExtraPieceDetailRecordCount", Order = 54)]
		[Required]
		public int ExtraPieceDetailRecordCount { get; set; }

		/// <summary>
		/// Extra Piece Detail Status (HDR-1189)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1189", FieldName = "Extra Piece Detail Status", Start = 402, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ExtraPieceDetailStatus", Order = 55)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ExtraPieceDetailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Record Count (HDR-1190)
		/// The number of referenceable mail records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1190", FieldName = "Referenceable Mail Record Count", Start = 403, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailRecordCount", Order = 56)]
		[Required]
		public int ReferenceableMailRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Status (HDR-1191)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1191", FieldName = "Referenceable Mail Status", Start = 413, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailStatus", Order = 57)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ReferenceableMailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Record Count (HDR-1193)
		/// The number of referenceable mail summary records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1193", FieldName = "Referenceable Mail Summary Record Count", Start = 414, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail summary records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailSummaryRecordCount", Order = 58)]
		[Required]
		public int ReferenceableMailSummaryRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Status (HDR-1194)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1194", FieldName = "Referenceable Mail Summary Status", Start = 424, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailSummaryStatus", Order = 59)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ReferenceableMailSummaryStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Record Count (HDR-1195)
		/// The number of referenceable mail barcode records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1195", FieldName = "Referenceable Mail Barcode Record Count", Start = 425, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of referenceable mail barcode records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ReferenceableMailBarcodeRecordCount", Order = 60)]
		[Required]
		public int ReferenceableMailBarcodeRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Status (HDR-1196)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1196", FieldName = "Referenceable Mail Barcode Status", Start = 435, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ReferenceableMailBarcodeStatus", Order = 61)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string ReferenceableMailBarcodeStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Header Record Count (HDR-1201)
		/// The number of Certificate of Mailing Header records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1201", FieldName = "Certificate of Mailing Header Record Count", Start = 436, Length = 6, Required = true, Key = false, DataType = "N", Description = "The number of Certificate of Mailing Header records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingHeaderRecordCount", Order = 62)]
		[Required]
		public int CertificateOfMailingHeaderRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Header Status (HDR-1202)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1202", FieldName = "Certificate of Mailing Header Status", Start = 442, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingHeaderStatus", Order = 63)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string CertificateOfMailingHeaderStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Record Count (HDR-1203)
		/// The number of certificate of mailing detail records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1203", FieldName = "Certificate of Mailing Detail Record Count", Start = 443, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing detail records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingDetailRecordCount", Order = 64)]
		[Required]
		public int CertificateOfMailingDetailRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Status (HDR-1204)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1204", FieldName = "Certificate of Mailing Detail Status", Start = 453, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingDetailStatus", Order = 65)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string CertificateOfMailingDetailStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Record Count (HDR-1205)
		/// The number of certificate of mailing bulk records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1205", FieldName = "Certificate of Mailing Bulk Record Count", Start = 454, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing bulk records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingBulkRecordCount", Order = 66)]
		[Required]
		public int CertificateOfMailingBulkRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Status (HDR-1206)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1206", FieldName = "Certificate of Mailing Bulk Status", Start = 464, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingBulkStatus", Order = 67)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string CertificateOfMailingBulkStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Record Count (HDR-1207)
		/// The number of certificate of mailing services records in this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1207", FieldName = "Certificate of Mailing Services Record Count", Start = 465, Length = 10, Required = true, Key = false, DataType = "N", Description = "The number of certificate of mailing services records in this Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("CertificateOfMailingServicesRecordCount", Order = 68)]
		[Required]
		public int CertificateOfMailingServicesRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Status (HDR-1208)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1208", FieldName = "Certificate of Mailing Services Status", Start = 475, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CertificateOfMailingServicesStatus", Order = 69)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "D", "N", "O", "R", "U")]
		public string CertificateOfMailingServicesStatus { get; set; }

		/// <summary>
		/// Mail.dat Presentation Category (HDR-1154)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1154", FieldName = "Mail.dat Presentation Category", Start = 476, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MailDatPresentationCategory", Order = 70)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("C", "E", "I", "M", "N", "P", "R")]
		public string MailDatPresentationCategory { get; set; }

		/// <summary>
		/// Original Software Vendor Name (HDR-1174)
		/// Originator company name of this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1174", FieldName = "Original Software Vendor Name", Start = 477, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator company name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVendorName", Order = 71)]
		[Required]
		[MaxLength(30)]
		public string OriginalSoftwareVendorName { get; set; }

		/// <summary>
		/// Original Software Products Name (HDR-1175)
		/// Originator product name of this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1175", FieldName = "Original Software Products Name", Start = 507, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Originator product name of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareProductsName", Order = 72)]
		[Required]
		[MaxLength(30)]
		public string OriginalSoftwareProductsName { get; set; }

		/// <summary>
		/// Original Software Version (HDR-1176)
		/// Originator software version of this Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1176", FieldName = "Original Software Version", Start = 537, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Originator software version of this Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVersion", Order = 73)]
		[Required]
		[MaxLength(10)]
		public string OriginalSoftwareVersion { get; set; }

		/// <summary>
		/// Original Software Vendor's Email (HDR-1177)
		/// Originator software company email address.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1177", FieldName = "Original Software Vendor's Email", Start = 547, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Originator software company email address.", Type = "string", Format = "leftjustify")]
		[Column("OriginalSoftwareVendorSEmail", Order = 74)]
		[Required]
		[MaxLength(60)]
		public string OriginalSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor Name (HDR-1150)
		/// May be name of in-house proprietary software. Name of Author of software creating the Mail.dat® as
		/// appended to this Respective .hdr record. This may be the name of the transmitting Agent, if they
		/// wrote their own proprietary home-grown software.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1150", FieldName = "Mail.dat Software Vendor Name", Start = 607, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "May be name of in-house proprietary software. Name of Author of software creating the Mail.dat® as appended to this Respective .hdr record. This may be the name of the transmitting Agent, if they wrote their own proprietary home-grown software.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVendorName", Order = 75)]
		[Required]
		[MaxLength(30)]
		public string MailDatSoftwareVendorName { get; set; }

		/// <summary>
		/// Mail.dat Software Product's Name (HDR-1155)
		/// Name of product creating this Header and applicable data in associated records.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1155", FieldName = "Mail.dat Software Product's Name", Start = 637, Length = 30, Required = true, Key = false, DataType = "A/N", Description = "Name of product creating this Header and applicable data in associated records.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareProductSName", Order = 76)]
		[Required]
		[MaxLength(30)]
		public string MailDatSoftwareProductSName { get; set; }

		/// <summary>
		/// Mail.dat Software Version (HDR-1151)
		/// Version of the software creating the transmitted Mail.dat.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1151", FieldName = "Mail.dat Software Version", Start = 667, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "Version of the software creating the transmitted Mail.dat.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVersion", Order = 77)]
		[Required]
		[MaxLength(10)]
		public string MailDatSoftwareVersion { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor's Email (HDR-1156)
		/// Email address of party creating product named above.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1156", FieldName = "Mail.dat Software Vendor's Email", Start = 677, Length = 60, Required = true, Key = false, DataType = "A/N", Description = "Email address of party creating product named above.", Type = "string", Format = "leftjustify")]
		[Column("MailDatSoftwareVendorSEmail", Order = 78)]
		[Required]
		[MaxLength(60)]
		public string MailDatSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Zone Matrix Date (HDR-1160)
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1160", FieldName = "Zone Matrix Date", Start = 737, Length = 8, Required = false, Key = false, DataType = "N", Type = "string", Format = "YYYYMMDD")]
		[Column("ZoneMatrixDate", Order = 79)]
		[MaxLength(8)]
		public string ZoneMatrixDate { get; set; }

		/// <summary>
		/// eDoc Sender CRID (HDR-1183)
		/// This USPS-assigned id, CRID, will be used by the USPS to Uniquely identify the submitter of
		/// electronic documentation to the PostalOne! system. This field will be used to identify a new
		/// Business role, called the eDoc submitter, which may be different From the mail preparer, mail owner,
		/// mail transporter, and Scheduler roles.  Only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1183", FieldName = "EDoc Sender CRID", Start = 745, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used by the USPS to Uniquely identify the submitter of electronic documentation to the PostalOne! system. This field will be used to identify a new Business role, called the eDoc submitter, which may be different From the mail preparer, mail owner, mail transporter, and Scheduler roles.  Only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("EDocSenderCRID", Order = 80)]
		[MaxLength(12)]
		public string EDocSenderCRID { get; set; }

		/// <summary>
		/// Information Exchange (HDR-1182)
		/// This field is for the exchange of private information between sender and catcher.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1182", FieldName = "Information Exchange", Start = 757, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "This field is for the exchange of private information between sender and catcher.", Type = "string", Format = "leftjustify")]
		[Column("InformationExchange", Order = 81)]
		[MaxLength(20)]
		public string InformationExchange { get; set; }

		/// <summary>
		/// User Option Field (HDR-1152)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-1152", FieldName = "User Option Field", Start = 777, Length = 1223, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 82)]
		[MaxLength(1223)]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Closing Character (HDR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "hdr", FieldCode = "HDR-9999", FieldName = "Closing Character", Start = 2000, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 83)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}