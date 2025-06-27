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
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
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
	/// Detail for each tracking program address. Identifies package/container of seed names within the
	/// presort.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "snr", File = "Seed Name Record", Summary = "Detail for each tracking program address.", Description = "Detail for each tracking program address. Identifies package/container of seed names within the presort.", LineLength = 160, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "snr", File = "Seed Name Record", Summary = "Detail for each tracking program address.", Description = "Detail for each tracking program address. Identifies package/container of seed names within the presort.", LineLength = 160, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "snr", File = "Seed Name Record", Summary = "Detail for each tracking program address.", Description = "Detail for each tracking program address. Identifies package/container of seed names within the presort.", LineLength = 160, ClosingCharacter = "#")]
	[MaildatImport(Order = 12, Version = "23-1")]
	[MaildatImport(Order = 12, Version = "24-1")]
	[MaildatImport(Order = 12, Version = "25-1")]
	[Table("Snr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Snr : MaildatEntity, ISnr 
	{
		/// <summary>
		/// Job ID (SNR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("SNR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Container ID (SNR-1006)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1006", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1006", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1006", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("SNR-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerId { get; set; }

		/// <summary>
		/// Package ID (SNR-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1012", FieldName = "Package ID", Start = 15, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1012", FieldName = "Package ID", Start = 15, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1012", FieldName = "Package ID", Start = 15, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[Column("PackageId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("SNR-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (SNR-1003)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1003", FieldName = "Mail Piece Unit ID", Start = 21, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1003", FieldName = "Mail Piece Unit ID", Start = 21, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1003", FieldName = "Mail Piece Unit ID", Start = 21, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("SNR-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitId { get; set; }

		/// <summary>
		/// Seed Name ID (SNR-1016)
		/// Since this file is only necessary to be used in the event that a list of specific and documented
		/// names for a tracking program, then this field is populated with the supplied ID for each specific
		/// name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be
		/// tracked. General seed lists (example: all managers at the catalog) will not require feedback of this
		/// nature from the list house.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1016", FieldName = "Seed Name ID", Start = 26, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Since this file is only necessary to be used in the event that a list of specific and documented names for a tracking program, then this field is populated with the supplied ID for each specific name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be tracked. General seed lists (example: all managers at the catalog) will not require feedback of this nature from the list house.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1016", FieldName = "Seed Name ID", Start = 26, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Since this file is only necessary to be used in the event that a list of specific and documented names for a tracking program, then this field is populated with the supplied ID for each specific name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be tracked. General seed lists (example: all managers at the catalog) will not require feedback of this nature from the list house.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1016", FieldName = "Seed Name ID", Start = 26, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Since this file is only necessary to be used in the event that a list of specific and documented names for a tracking program, then this field is populated with the supplied ID for each specific name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be tracked. General seed lists (example: all managers at the catalog) will not require feedback of this nature from the list house.", Type = "string", Format = "zfillnumeric")]
		[Column("SeedNameId", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(20)]
		[Comment("SNR-1016")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SeedNameId { get; set; }

		/// <summary>
		/// Version Key Code (SNR-1017)
		/// Derived from original seed information. As with the Seed Name ID, this information is derived from
		/// the supplied name/address/record data.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1017", FieldName = "Version Key Code", Start = 46, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Derived from original seed information. As with the Seed Name ID, this information is derived from the supplied name/address/record data.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1017", FieldName = "Version Key Code", Start = 46, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Derived from original seed information. As with the Seed Name ID, this information is derived from the supplied name/address/record data.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1017", FieldName = "Version Key Code", Start = 46, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Derived from original seed information. As with the Seed Name ID, this information is derived from the supplied name/address/record data.", Type = "string", Format = "leftjustify")]
		[Column("VersionKeyCode", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(20)]
		[Comment("SNR-1017")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string VersionKeyCode { get; set; }

		/// <summary>
		/// Seed Name Received Date (SNR-1101)
		/// The date the seed agent received the mail piece.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1101", FieldName = "Seed Name Received Date", Start = 66, Length = 8, Required = false, Key = false, DataType = "N", Default = "00010101", Description = "The date the seed agent received the mail piece.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1101", FieldName = "Seed Name Received Date", Start = 66, Length = 8, Required = false, Key = false, DataType = "N", Default = "00010101", Description = "The date the seed agent received the mail piece.", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1101", FieldName = "Seed Name Received Date", Start = 66, Length = 8, Required = false, Key = false, DataType = "N", Default = "00010101", Description = "The date the seed agent received the mail piece.", Type = "date", Format = "YYYYMMDD")]
		[Column("SeedNameReceivedDate", Order = 8, TypeName = "TEXT")]
		[Comment("SNR-1101")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly? SeedNameReceivedDate { get; set; }

		/// <summary>
		/// Seed Type (SNR-1104)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1104", FieldName = "Seed Type", Start = 74, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1104", FieldName = "Seed Type", Start = 74, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1104", FieldName = "Seed Type", Start = 74, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SeedType", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("B", "C", "R", "S")]
		[Comment("SNR-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SeedTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SeedType { get; set; }

		/// <summary>
		/// Piece Barcode (SNR-1105)
		/// 5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1105", FieldName = "Piece Barcode", Start = 75, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1105", FieldName = "Piece Barcode", Start = 75, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1105", FieldName = "Piece Barcode", Start = 75, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.", Type = "string", Format = "leftjustify")]
		[Column("PieceBarcode", Order = 10, TypeName = "TEXT")]
		[MaxLength(11)]
		[Comment("SNR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PieceBarcode { get; set; }

		/// <summary>
		/// Reported Seed Condition (SNR-1106)
		/// The condition of the seed as received by a seed reporter.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1106", FieldName = "Reported Seed Condition", Start = 86, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "The condition of the seed as received by a seed reporter.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1106", FieldName = "Reported Seed Condition", Start = 86, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "The condition of the seed as received by a seed reporter.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1106", FieldName = "Reported Seed Condition", Start = 86, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "The condition of the seed as received by a seed reporter.", Type = "enum", Format = "leftjustify")]
		[Column("ReportedSeedCondition", Order = 11, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("F", "G", "M", "P")]
		[Comment("SNR-1106")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ReportedSeedConditions))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReportedSeedCondition { get; set; }

		/// <summary>
		/// IM™ Barcode (SNR-1108)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain
		/// unique for 45 days.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1108", FieldName = "IM™ Barcode", Start = 87, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain unique for 45 days.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1108", FieldName = "IM™ Barcode", Start = 87, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain unique for 45 days.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1108", FieldName = "IM™ Barcode", Start = 87, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain unique for 45 days.", Type = "string", Format = "leftjustify")]
		[Column("ImBarcode", Order = 12, TypeName = "TEXT")]
		[MaxLength(34)]
		[Comment("SNR-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ImBarcode { get; set; }

		/// <summary>
		/// User Option Field (SNR-1110)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1110", FieldName = "User Option Field", Start = 121, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1110", FieldName = "User Option Field", Start = 121, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1110", FieldName = "User Option Field", Start = 121, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 13, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("SNR-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string UserOptionField { get; set; }

		/// <summary>
		/// SNR Record Status (SNR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-2000", FieldName = "SNR Record Status", Start = 141, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-2000", FieldName = "SNR Record Status", Start = 141, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-2000", FieldName = "SNR Record Status", Start = 141, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("SnrRecordStatus", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("SNR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SnrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SnrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SNR-1103)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-1103", FieldName = "Reserve", Start = 142, Length = 18, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-1103", FieldName = "Reserve", Start = 142, Length = 18, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-1103", FieldName = "Reserve", Start = 142, Length = 18, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveSnr1103", Order = 15, TypeName = "TEXT")]
		[MaxLength(18)]
		[Comment("SNR-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveSnr1103 { get; set; }

		/// <summary>
		/// Closing Character (SNR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "snr", FieldCode = "SNR-9999", FieldName = "Closing Character", Start = 160, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "snr", FieldCode = "SNR-9999", FieldName = "Closing Character", Start = 160, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "snr", FieldCode = "SNR-9999", FieldName = "Closing Character", Start = 160, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 16, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("SNR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Snr, string>(version, p => p.JobId, returnValue);
			this.ContainerId = line.ParseForImport<Snr, int>(version, p => p.ContainerId, returnValue);
			this.PackageId = line.ParseForImport<Snr, string>(version, p => p.PackageId, returnValue);
			this.MailPieceUnitId = line.ParseForImport<Snr, string>(version, p => p.MailPieceUnitId, returnValue);
			this.SeedNameId = line.ParseForImport<Snr, string>(version, p => p.SeedNameId, returnValue);
			this.VersionKeyCode = line.ParseForImport<Snr, string>(version, p => p.VersionKeyCode, returnValue);
			this.SeedNameReceivedDate = line.ParseForImport<Snr, DateOnly?>(version, p => p.SeedNameReceivedDate, returnValue);
			this.SeedType = line.ParseForImport<Snr, string>(version, p => p.SeedType, returnValue);
			this.PieceBarcode = line.ParseForImport<Snr, string>(version, p => p.PieceBarcode, returnValue);
			this.ReportedSeedCondition = line.ParseForImport<Snr, string>(version, p => p.ReportedSeedCondition, returnValue);
			this.ImBarcode = line.ParseForImport<Snr, string>(version, p => p.ImBarcode, returnValue);
			this.UserOptionField = line.ParseForImport<Snr, string>(version, p => p.UserOptionField, returnValue);
			this.SnrRecordStatus = line.ParseForImport<Snr, string>(version, p => p.SnrRecordStatus, returnValue);
			this.ReserveSnr1103 = line.ParseForImport<Snr, string>(version, p => p.ReserveSnr1103, returnValue);
			this.ClosingCharacter = line.ParseForImport<Snr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Snr, string>(version, p => p.JobId));
			sb.Append(this.ContainerId.FormatForExport<Snr, int>(version, p => p.ContainerId));
			sb.Append(this.PackageId.FormatForExport<Snr, string>(version, p => p.PackageId));
			sb.Append(this.MailPieceUnitId.FormatForExport<Snr, string>(version, p => p.MailPieceUnitId));
			sb.Append(this.SeedNameId.FormatForExport<Snr, string>(version, p => p.SeedNameId));
			sb.Append(this.VersionKeyCode.FormatForExport<Snr, string>(version, p => p.VersionKeyCode));
			sb.Append(this.SeedNameReceivedDate.FormatForExport<Snr, DateOnly?>(version, p => p.SeedNameReceivedDate));
			sb.Append(this.SeedType.FormatForExport<Snr, string>(version, p => p.SeedType));
			sb.Append(this.PieceBarcode.FormatForExport<Snr, string>(version, p => p.PieceBarcode));
			sb.Append(this.ReportedSeedCondition.FormatForExport<Snr, string>(version, p => p.ReportedSeedCondition));
			sb.Append(this.ImBarcode.FormatForExport<Snr, string>(version, p => p.ImBarcode));
			sb.Append(this.UserOptionField.FormatForExport<Snr, string>(version, p => p.UserOptionField));
			sb.Append(this.SnrRecordStatus.FormatForExport<Snr, string>(version, p => p.SnrRecordStatus));
			sb.Append(this.ReserveSnr1103.FormatForExport<Snr, string>(version, p => p.ReserveSnr1103));
			sb.Append(this.ClosingCharacter.FormatForExport<Snr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}