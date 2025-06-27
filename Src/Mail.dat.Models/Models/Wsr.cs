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
	/// Detail for each Walk Sequence prepared Carrier Route. Provide detail to verify Saturation or High
	/// Density mailings.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Detail for each Walk Sequence prepared Carrier Route. Provide detail to verify Saturation or High Density mailings.", LineLength = 50, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Detail for each Walk Sequence prepared Carrier Route. Provide detail to verify Saturation or High Density mailings.", LineLength = 50, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Detail for each Walk Sequence prepared Carrier Route. Provide detail to verify Saturation or High Density mailings.", LineLength = 50, ClosingCharacter = "#")]
	[MaildatImport(Order = 11, Version = "23-1")]
	[MaildatImport(Order = 11, Version = "24-1")]
	[MaildatImport(Order = 11, Version = "25-1")]
	[Table("Wsr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Wsr : MaildatEntity, IWsr 
	{
		/// <summary>
		/// Job ID (WSR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("WSR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Segment ID (WSR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SegmentId { get; set; }

		/// <summary>
		/// Package ZIP Code (WSR-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. See package Quantity File's Package Zip Code field's definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[Column("PackageZipCode", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("WSR-1013")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageZipCode { get; set; }

		/// <summary>
		/// Package CR Number (WSR-1014)
		/// Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCRNumber", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1014")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageCRNumber { get; set; }

		/// <summary>
		/// Co-Palletization Code (WSR-1015)
		/// Used to differentiate carrier route mail going to the same ZIP and Route that was coded and
		/// presorted independently, to allow association of Walk Sequence records with particular MPU records
		/// (*.mpu). For Co-palletization, it creates an efficient means to differentiate each of the possible
		/// job and sub-job entities within a co-palletization set-up. Can also be used to differentiate between
		/// simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for
		/// job swhere this additional level of detail is not needed.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1015", FieldName = "Co-Palletization Code", Start = 23, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to Allow association of Walk Sequence records with particular MPU Records (*.mpu). For Co-palletization, it creates an efficient Means to differentiate each of the possible job and sub-job Entities within a co-palletization set-up. Can also be used to Differentiate between simplified and non-simplified addressed Pieces when combined in the same job. Populate with 01 for jobs Where this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1015", FieldName = "Co-Palletization Code", Start = 23, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to Allow association of Walk Sequence records with particular MPU Records (*.mpu). For Co-palletization, it creates an efficient Means to differentiate each of the possible job and sub-job Entities within a co-palletization set-up. Can also be used to Differentiate between simplified and non-simplified addressed Pieces when combined in the same job. Populate with 01 for jobs Where this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1015", FieldName = "Co-Palletization Code", Start = 23, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to allow association of Walk Sequence records with particular MPU records (*.mpu). For Co-palletization, it creates an efficient means to differentiate each of the possible job and sub-job entities within a co-palletization set-up. Can also be used to differentiate between simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for job swhere this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[Column("CoPalletizationCode", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[Comment("WSR-1015")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CoPalletizationCode { get; set; }

		/// <summary>
		/// Walk Sequence Type (WSR-1101)
		/// This field indicates whether the calculation of Saturation Walk Sequence eligibility is based upon
		/// the number of Total addresses or Residential Only addresses within the route.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceType", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("R", "T")]
		[Comment("WSR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(WalkSequenceTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string WalkSequenceType { get; set; }

		/// <summary>
		/// Walk Sequence Stops (WSR-1102)
		/// The number of unique addresses (not pieces delivered) for the carrier when delivering this specific
		/// route within the saturation eligible mailing. This value represents the total stops incurred while
		/// the applicable carrier route within this package is delivered. Walk Sequence Stops for this Carrier
		/// Route.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier When delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier When delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier when delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceStops", Order = 8, TypeName = "INTEGER")]
		[Required]
		[Comment("WSR-1102")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int WalkSequenceStops { get; set; }

		/// <summary>
		/// Walk Sequence Denominator (WSR-1103)
		/// Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in
		/// the CR. Cannot be zero.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1103", FieldName = "Walk Sequence Denominator", Start = 30, Length = 4, Required = true, Key = false, DataType = "N", Description = "Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in the CR. Cannot be zero.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1103", FieldName = "Walk Sequence Denominator", Start = 30, Length = 4, Required = true, Key = false, DataType = "N", Description = "Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in the CR. Cannot be zero.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1103", FieldName = "Walk Sequence Denominator", Start = 30, Length = 4, Required = true, Key = false, DataType = "N", Description = "Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in the CR. Cannot be zero.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceDenominator", Order = 9, TypeName = "INTEGER")]
		[Required]
		[Comment("WSR-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int WalkSequenceDenominator { get; set; }

		/// <summary>
		/// Walk Sequence Database Date (WSR-1104)
		/// The date of the database from which the walk sequence was secured.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured.", Type = "date", Format = "YYYYMMDD")]
		[Column("WalkSequenceDatabaseDate", Order = 10, TypeName = "TEXT")]
		[Required]
		[Comment("WSR-1104")]
		[TypeConverter(typeof(MaildatDateConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public DateOnly WalkSequenceDatabaseDate { get; set; }

		/// <summary>
		/// WSR Record Status (WSR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("WsrRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("WSR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(WsrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string WsrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (WSR-1105)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveWsr1105", Order = 12, TypeName = "TEXT")]
		[MaxLength(7)]
		[Comment("WSR-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveWsr1105 { get; set; }

		/// <summary>
		/// Closing Character (WSR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("WSR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Wsr, string>(version, p => p.JobId, returnValue);
			this.SegmentId = line.ParseForImport<Wsr, string>(version, p => p.SegmentId, returnValue);
			this.PackageZipCode = line.ParseForImport<Wsr, string>(version, p => p.PackageZipCode, returnValue);
			this.PackageCRNumber = line.ParseForImport<Wsr, string>(version, p => p.PackageCRNumber, returnValue);
			this.CoPalletizationCode = line.ParseForImport<Wsr, string>(version, p => p.CoPalletizationCode, returnValue);
			this.WalkSequenceType = line.ParseForImport<Wsr, string>(version, p => p.WalkSequenceType, returnValue);
			this.WalkSequenceStops = line.ParseForImport<Wsr, int>(version, p => p.WalkSequenceStops, returnValue);
			this.WalkSequenceDenominator = line.ParseForImport<Wsr, int>(version, p => p.WalkSequenceDenominator, returnValue);
			this.WalkSequenceDatabaseDate = line.ParseForImport<Wsr, DateOnly>(version, p => p.WalkSequenceDatabaseDate, returnValue);
			this.WsrRecordStatus = line.ParseForImport<Wsr, string>(version, p => p.WsrRecordStatus, returnValue);
			this.ReserveWsr1105 = line.ParseForImport<Wsr, string>(version, p => p.ReserveWsr1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Wsr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Wsr, string>(version, p => p.JobId));
			sb.Append(this.SegmentId.FormatForExport<Wsr, string>(version, p => p.SegmentId));
			sb.Append(this.PackageZipCode.FormatForExport<Wsr, string>(version, p => p.PackageZipCode));
			sb.Append(this.PackageCRNumber.FormatForExport<Wsr, string>(version, p => p.PackageCRNumber));
			sb.Append(this.CoPalletizationCode.FormatForExport<Wsr, string>(version, p => p.CoPalletizationCode));
			sb.Append(this.WalkSequenceType.FormatForExport<Wsr, string>(version, p => p.WalkSequenceType));
			sb.Append(this.WalkSequenceStops.FormatForExport<Wsr, int>(version, p => p.WalkSequenceStops));
			sb.Append(this.WalkSequenceDenominator.FormatForExport<Wsr, int>(version, p => p.WalkSequenceDenominator));
			sb.Append(this.WalkSequenceDatabaseDate.FormatForExport<Wsr, DateOnly>(version, p => p.WalkSequenceDatabaseDate));
			sb.Append(this.WsrRecordStatus.FormatForExport<Wsr, string>(version, p => p.WsrRecordStatus));
			sb.Append(this.ReserveWsr1105.FormatForExport<Wsr, string>(version, p => p.ReserveWsr1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Wsr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}