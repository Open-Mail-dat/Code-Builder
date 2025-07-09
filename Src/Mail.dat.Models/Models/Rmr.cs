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
// This code was auto-generated on July 8th, 2025 by the Open Mail.dat Code Generator.
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
	/// Reference-able Mail to provide digital content at the piece or version level. Records identify
	/// digital campaigns and enhances capabilities of the USPS Informed Delivery program.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "rmr", File = "Referenceable Mail Record", Summary = "Reference-able Mail to provide digital content at the piece or version level.", Description = "Reference-able Mail to provide digital content at the piece or version level.", LineLength = 311, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "rmr", File = "Referenceable Mail Record", Summary = "Reference-able Mail to provide digital content at the piece or version level.", Description = "Reference-able Mail to provide digital content at the piece or version level.", LineLength = 311, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "rmr", File = "Referenceable Mail Record", Summary = "Reference-able Mail to provide digital content at the piece or version level.", Description = "Reference-able Mail to provide digital content at the piece or version level. Records identify digital campaigns and enhances capabilities of the USPS Informed Delivery program.", LineLength = 311, ClosingCharacter = "#")]
	[MaildatImport(Order = 22, Version = "23-1")]
	[MaildatImport(Order = 22, Version = "24-1")]
	[MaildatImport(Order = 22, Version = "25-1")]
	[Table("Rmr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Rmr : MaildatEntity, IRmr 
	{
		/// <summary>
		/// Job ID (RMR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// RMR ID (RMR-1002)
		/// Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record
		/// should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right
		/// justify and zero fill; PDR - Piece ID; CPT - Component ID.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1002", FieldName = "RMR ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID; CPT - Component ID .(zero fill prior to numeric, if numeric only).", Type = "string", Format = "zfillnumeric", References = "PBC-1002,PDR-1018,CPT-1004")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1002", FieldName = "RMR ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID; CPT - Component ID .(zero fill prior to numeric, if numeric only).", Type = "string", Format = "zfillnumeric", References = "PBC-1002,PDR-1018,CPT-1004")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1002", FieldName = "RMR ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID; CPT - Component ID.", Type = "string", Format = "zfillnumeric", References = "PBC-1002,PDR-1018,CPT-1004")]
		[Column("RmrId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("RMR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrId { get; set; }

		/// <summary>
		/// RMR ID Type (RMR-1003)
		/// Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record
		/// (CPT, PDR/PBC) that the RMR ID (this record) represents.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1003", FieldName = "RMR ID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record (CPT, PDR/PBC) that the RMR ID (this record) represents.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1003", FieldName = "RMR ID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record (CPT, PDR/PBC) that the RMR ID (this record) represents.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1003", FieldName = "RMR ID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record (CPT, PDR/PBC) that the RMR ID (this record) represents.", Type = "enum", Format = "leftjustify")]
		[Column("RmrIdType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("B", "C", "P")]
		[Comment("RMR-1003")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RmrIdTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrIdType { get; set; }

		/// <summary>
		/// RMS ID (RMR-1009)
		/// RMS ID of the Campaign Summary record.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1009", FieldName = "RMS ID", Start = 32, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "RMS ID of the Campaign Summary record.", Type = "string", Format = "leftjustify", References = "RMS-1002")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1009", FieldName = "RMS ID", Start = 32, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "RMS ID of the Campaign Summary record.", Type = "string", Format = "leftjustify", References = "RMS-1002")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1009", FieldName = "RMS ID", Start = 32, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "RMS ID of the Campaign Summary record.", Type = "string", Format = "leftjustify", References = "RMS-1002")]
		[Column("RmsId", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("RMR-1009")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmsId { get; set; }

		/// <summary>
		/// RMR Content Type (RMR-1004)
		/// Field to capture the type of RMR content. RMR content can either be a URL of a media image that is
		/// supported by browsers or a target URL that will be placed as a Hyperlink for the media/image.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1004", FieldName = "RMR Content Type", Start = 40, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMR content. RMR content Can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1004", FieldName = "RMR Content Type", Start = 40, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMR content. RMR content Can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1004", FieldName = "RMR Content Type", Start = 40, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMR content. RMR content can either be a URL of a media image that is supported by browsers or a target URL that will be placed as a Hyperlink for the media/image.", Type = "enum", Format = "leftjustify")]
		[Column("RmrContentType", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C")]
		[Comment("RMR-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RmrContentTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrContentType { get; set; }

		/// <summary>
		/// CQT Database ID (RMR-1010)
		/// See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR.
		/// Field must be blank for RMR ID type of Component.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1010", FieldName = "CQT Database ID", Start = 41, Length = 8, Required = false, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR. Field must be blank for RMR ID type of Component.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1010", FieldName = "CQT Database ID", Start = 41, Length = 8, Required = false, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR. Field must be blank for RMR ID type of Component.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1010", FieldName = "CQT Database ID", Start = 41, Length = 8, Required = false, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR. Field must be blank for RMR ID type of Component.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 7, TypeName = "INTEGER")]
		[Comment("RMR-1010")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int? CqtDatabaseId { get; set; }

		/// <summary>
		/// RMR Value (RMR-1005)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1005", FieldName = "RMR Value", Start = 49, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or Target/HREF document (could be a webpage, or image/media Driven by the RMR Content Type field); Leave BLANK if piece Wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1005", FieldName = "RMR Value", Start = 49, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or Target/HREF document (could be a webpage, or image/media Driven by the RMR Content Type field); Leave BLANK if piece Wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1005", FieldName = "RMR Value", Start = 49, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[Column("RmrValue", Order = 8, TypeName = "TEXT")]
		[MaxLength(250)]
		[Comment("RMR-1005")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrValue { get; set; }

		/// <summary>
		/// RMR Template Code (RMR-1008)
		/// RMR Template Code, one of many templates provided by Postal Service, Possible values can be A
		/// through Z.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1008", FieldName = "RMR Template Code", Start = 299, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMR Template Code, one of many templates provided by Postal Service, Possible values can be A through Z.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1008", FieldName = "RMR Template Code", Start = 299, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMR Template Code, one of many templates provided by Postal Service, Possible values can be A through Z.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1008", FieldName = "RMR Template Code", Start = 299, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMR Template Code, one of many templates provided by Postal Service, Possible values can be A through Z.", Type = "string", Format = "leftjustify")]
		[Column("RmrTemplateCode", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("RMR-1008")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrTemplateCode { get; set; }

		/// <summary>
		/// Reserve (RMR-1011)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-1011", FieldName = "Reserve", Start = 300, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-1011", FieldName = "Reserve", Start = 300, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-1011", FieldName = "Reserve", Start = 300, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveRmr1011", Order = 10, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("RMR-1011")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveRmr1011 { get; set; }

		/// <summary>
		/// RMR Record Status (RMR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-2000", FieldName = "RMR Record Status", Start = 310, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-2000", FieldName = "RMR Record Status", Start = 310, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-2000", FieldName = "RMR Record Status", Start = 310, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("RmrRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("RMR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RmrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmr", FieldCode = "RMR-9999", FieldName = "Closing Character", Start = 311, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmr", FieldCode = "RMR-9999", FieldName = "Closing Character", Start = 311, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmr", FieldCode = "RMR-9999", FieldName = "Closing Character", Start = 311, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("RMR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Rmr, string>(version, p => p.JobId, returnValue);
			this.RmrId = line.ParseForImport<Rmr, string>(version, p => p.RmrId, returnValue);
			this.RmrIdType = line.ParseForImport<Rmr, string>(version, p => p.RmrIdType, returnValue);
			this.RmsId = line.ParseForImport<Rmr, string>(version, p => p.RmsId, returnValue);
			this.RmrContentType = line.ParseForImport<Rmr, string>(version, p => p.RmrContentType, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Rmr, int?>(version, p => p.CqtDatabaseId, returnValue);
			this.RmrValue = line.ParseForImport<Rmr, string>(version, p => p.RmrValue, returnValue);
			this.RmrTemplateCode = line.ParseForImport<Rmr, string>(version, p => p.RmrTemplateCode, returnValue);
			this.ReserveRmr1011 = line.ParseForImport<Rmr, string>(version, p => p.ReserveRmr1011, returnValue);
			this.RmrRecordStatus = line.ParseForImport<Rmr, string>(version, p => p.RmrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Rmr, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Rmr, string>(version, p => p.JobId));
			sb.Append(this.RmrId.FormatForExport<Rmr, string>(version, p => p.RmrId));
			sb.Append(this.RmrIdType.FormatForExport<Rmr, string>(version, p => p.RmrIdType));
			sb.Append(this.RmsId.FormatForExport<Rmr, string>(version, p => p.RmsId));
			sb.Append(this.RmrContentType.FormatForExport<Rmr, string>(version, p => p.RmrContentType));
			sb.Append(this.CqtDatabaseId.FormatForExport<Rmr, int?>(version, p => p.CqtDatabaseId));
			sb.Append(this.RmrValue.FormatForExport<Rmr, string>(version, p => p.RmrValue));
			sb.Append(this.RmrTemplateCode.FormatForExport<Rmr, string>(version, p => p.RmrTemplateCode));
			sb.Append(this.ReserveRmr1011.FormatForExport<Rmr, string>(version, p => p.ReserveRmr1011));
			sb.Append(this.RmrRecordStatus.FormatForExport<Rmr, string>(version, p => p.RmrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Rmr, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}