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
	/// Links new container with an original container. Allows customers to tie or link container
	/// information between Jobs from Mail.dat and Mail.XML.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "oci", File = "Original Container", Summary = "Links new container with an original container.", Description = "Links new container with an original container. Allows customers to tie or link container information between Jobs from Mail.dat and Mail.XML.", LineLength = 120, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "oci", File = "Original Container", Summary = "Links new container with an original container.", Description = "Links new container with an original container. Allows customers to tie or link container information between Jobs from Mail.dat and Mail.XML.", LineLength = 120, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "oci", File = "Original Container", Summary = "Links new container with an original container.", Description = "Links new container with an original container. Allows customers to tie or link container information between Jobs from Mail.dat and Mail.XML.", LineLength = 120, ClosingCharacter = "#")]
	[MaildatImport(Order = 19, Version = "23-1")]
	[MaildatImport(Order = 19, Version = "24-1")]
	[MaildatImport(Order = 19, Version = "25-1")]
	[Table("Oci", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Oci : MaildatEntity, IOci 
	{
		/// <summary>
		/// Job ID (OCI-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("OCI-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Container ID (OCI-1002)
		/// This file is not designed for Mother Pallets.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1002", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1002", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1002", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("OCI-1002")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerId { get; set; }

		/// <summary>
		/// Original Job ID (OCI-1101)
		/// Job Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1101", FieldName = "Original Job ID", Start = 15, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Job Id provided in another Mailing Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1101", FieldName = "Original Job ID", Start = 15, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Job Id provided in another Mailing Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1101", FieldName = "Original Job ID", Start = 15, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Job Id provided in another Mailing Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalJobId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("OCI-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalJobId { get; set; }

		/// <summary>
		/// Original User License Code (OCI-1102)
		/// User License Code provided in another mailing/Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1102", FieldName = "Original User License Code", Start = 23, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing/Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1102", FieldName = "Original User License Code", Start = 23, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing/Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1102", FieldName = "Original User License Code", Start = 23, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing/Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalUserLicenseCode", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[Comment("OCI-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// Original Segment ID (OCI-1103)
		/// Segment ID provided in another mailing/Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1103", FieldName = "Original Segment ID", Start = 27, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "Segment ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1103", FieldName = "Original Segment ID", Start = 27, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "Segment ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1103", FieldName = "Original Segment ID", Start = 27, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "Segment ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalSegmentId", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[Comment("OCI-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalSegmentId { get; set; }

		/// <summary>
		/// Original Container ID (OCI-1104)
		/// Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1104", FieldName = "Original Container ID", Start = 31, Length = 6, Required = true, Key = false, DataType = "N", Description = "Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1104", FieldName = "Original Container ID", Start = 31, Length = 6, Required = true, Key = false, DataType = "N", Description = "Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1104", FieldName = "Original Container ID", Start = 31, Length = 6, Required = true, Key = false, DataType = "N", Description = "Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill")]
		[Column("OriginalContainerId", Order = 7, TypeName = "INTEGER")]
		[Required]
		[Comment("OCI-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int OriginalContainerId { get; set; }

		/// <summary>
		/// Original Display Container ID (OCI-1105)
		/// Meaningful (external to Mail.dat) container ID as defined by specific production application; the
		/// Postal container label. Display Container ID provided in another mailing/Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1105", FieldName = "Original Display Container ID", Start = 37, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "Meaningful (external to Mail.dat) container ID as defined by specific production application; the Postal container label. Display Container ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1105", FieldName = "Original Display Container ID", Start = 37, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "Meaningful (external to Mail.dat) container ID as defined by specific production application; the Postal container label. Display Container ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1105", FieldName = "Original Display Container ID", Start = 37, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "Meaningful (external to Mail.dat) container ID as defined by specific production application; the Postal container label. Display Container ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalDisplayContainerId", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("OCI-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalDisplayContainerId { get; set; }

		/// <summary>
		/// Original Label: IM™ Container Or IM™ Tray Barcode (OCI-1106)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1106", FieldName = "Original Label: IM™ Container Or IM™ Tray Barcode", Start = 43, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1106", FieldName = "Original Label: IM™ Container Or IM™ Tray Barcode", Start = 43, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1106", FieldName = "Original Label: IM™ Container Or IM™ Tray Barcode", Start = 43, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("OriginalLabelImContainerOrImTrayBarcode", Order = 9, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("OCI-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalLabelImContainerOrImTrayBarcode { get; set; }

		/// <summary>
		/// Original Mail.XML Customer Group ID (OCI-1107)
		/// Mail.XML Customer Group ID provided in another Mailing Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1107", FieldName = "Original Mail.XML Customer Group ID", Start = 67, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Customer Group ID provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1107", FieldName = "Original Mail.XML Customer Group ID", Start = 67, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Customer Group ID provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1107", FieldName = "Original Mail.XML Customer Group ID", Start = 67, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Customer Group ID provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalMailXmlCustomerGroupId", Order = 10, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("OCI-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalMailXmlCustomerGroupId { get; set; }

		/// <summary>
		/// Original Mail.XML Mailing Group ID (OCI-1108)
		/// Mail.XML Mailing Group Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1108", FieldName = "Original Mail.XML Mailing Group ID", Start = 79, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Mailing Group Id provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1108", FieldName = "Original Mail.XML Mailing Group ID", Start = 79, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Mailing Group Id provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1108", FieldName = "Original Mail.XML Mailing Group ID", Start = 79, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Mailing Group Id provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalMailXmlMailingGroupId", Order = 11, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("OCI-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalMailXmlMailingGroupId { get; set; }

		/// <summary>
		/// Original Mail.XML Container ID (OCI-1109)
		/// Mail.XML Container Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1109", FieldName = "Original Mail.XML Container ID", Start = 91, Length = 12, Required = false, Key = false, DataType = "N", Description = "Mail.XML Container Id provided in another Mailing Job.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1109", FieldName = "Original Mail.XML Container ID", Start = 91, Length = 12, Required = false, Key = false, DataType = "N", Description = "Mail.XML Container Id provided in another Mailing Job.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1109", FieldName = "Original Mail.XML Container ID", Start = 91, Length = 12, Required = false, Key = false, DataType = "N", Description = "Mail.XML Container Id provided in another Mailing Job.", Type = "integer", Format = "zfill")]
		[Column("OriginalMailXmlContainerId", Order = 12, TypeName = "INTEGER")]
		[Comment("OCI-1109")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? OriginalMailXmlContainerId { get; set; }

		/// <summary>
		/// OCI Record Status (OCI-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-2000", FieldName = "OCI Record Status", Start = 103, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-2000", FieldName = "OCI Record Status", Start = 103, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-2000", FieldName = "OCI Record Status", Start = 103, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("OciRecordStatus", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("OCI-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(OciRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OciRecordStatus { get; set; }

		/// <summary>
		/// Reserve (OCI-1110)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-1110", FieldName = "Reserve", Start = 104, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-1110", FieldName = "Reserve", Start = 104, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-1110", FieldName = "Reserve", Start = 104, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveOci1110", Order = 14, TypeName = "TEXT")]
		[MaxLength(16)]
		[Comment("OCI-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveOci1110 { get; set; }

		/// <summary>
		/// Closing Character (OCI-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "oci", FieldCode = "OCI-9999", FieldName = "Closing Character", Start = 120, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "oci", FieldCode = "OCI-9999", FieldName = "Closing Character", Start = 120, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "oci", FieldCode = "OCI-9999", FieldName = "Closing Character", Start = 120, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("OCI-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Oci, string>(version, p => p.JobId, returnValue);
			this.ContainerId = line.ParseForImport<Oci, int>(version, p => p.ContainerId, returnValue);
			this.OriginalJobId = line.ParseForImport<Oci, string>(version, p => p.OriginalJobId, returnValue);
			this.OriginalUserLicenseCode = line.ParseForImport<Oci, string>(version, p => p.OriginalUserLicenseCode, returnValue);
			this.OriginalSegmentId = line.ParseForImport<Oci, string>(version, p => p.OriginalSegmentId, returnValue);
			this.OriginalContainerId = line.ParseForImport<Oci, int>(version, p => p.OriginalContainerId, returnValue);
			this.OriginalDisplayContainerId = line.ParseForImport<Oci, string>(version, p => p.OriginalDisplayContainerId, returnValue);
			this.OriginalLabelImContainerOrImTrayBarcode = line.ParseForImport<Oci, string>(version, p => p.OriginalLabelImContainerOrImTrayBarcode, returnValue);
			this.OriginalMailXmlCustomerGroupId = line.ParseForImport<Oci, string>(version, p => p.OriginalMailXmlCustomerGroupId, returnValue);
			this.OriginalMailXmlMailingGroupId = line.ParseForImport<Oci, string>(version, p => p.OriginalMailXmlMailingGroupId, returnValue);
			this.OriginalMailXmlContainerId = line.ParseForImport<Oci, int?>(version, p => p.OriginalMailXmlContainerId, returnValue);
			this.OciRecordStatus = line.ParseForImport<Oci, string>(version, p => p.OciRecordStatus, returnValue);
			this.ReserveOci1110 = line.ParseForImport<Oci, string>(version, p => p.ReserveOci1110, returnValue);
			this.ClosingCharacter = line.ParseForImport<Oci, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Oci, string>(version, p => p.JobId));
			sb.Append(this.ContainerId.FormatForExport<Oci, int>(version, p => p.ContainerId));
			sb.Append(this.OriginalJobId.FormatForExport<Oci, string>(version, p => p.OriginalJobId));
			sb.Append(this.OriginalUserLicenseCode.FormatForExport<Oci, string>(version, p => p.OriginalUserLicenseCode));
			sb.Append(this.OriginalSegmentId.FormatForExport<Oci, string>(version, p => p.OriginalSegmentId));
			sb.Append(this.OriginalContainerId.FormatForExport<Oci, int>(version, p => p.OriginalContainerId));
			sb.Append(this.OriginalDisplayContainerId.FormatForExport<Oci, string>(version, p => p.OriginalDisplayContainerId));
			sb.Append(this.OriginalLabelImContainerOrImTrayBarcode.FormatForExport<Oci, string>(version, p => p.OriginalLabelImContainerOrImTrayBarcode));
			sb.Append(this.OriginalMailXmlCustomerGroupId.FormatForExport<Oci, string>(version, p => p.OriginalMailXmlCustomerGroupId));
			sb.Append(this.OriginalMailXmlMailingGroupId.FormatForExport<Oci, string>(version, p => p.OriginalMailXmlMailingGroupId));
			sb.Append(this.OriginalMailXmlContainerId.FormatForExport<Oci, int?>(version, p => p.OriginalMailXmlContainerId));
			sb.Append(this.OciRecordStatus.FormatForExport<Oci, string>(version, p => p.OciRecordStatus));
			sb.Append(this.ReserveOci1110.FormatForExport<Oci, string>(version, p => p.ReserveOci1110));
			sb.Append(this.ClosingCharacter.FormatForExport<Oci, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}