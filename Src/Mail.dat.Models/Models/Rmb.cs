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
	/// Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat
	/// required files and structure. Records identify digital campaigns and enhance capabilities of the
	/// USPS Informed Delivery  program separate from the required file structure.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "rmb", File = "Referenceable Mail Barcode Record", Summary = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure.", Description = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure. Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program separate from the required file structure.", LineLength = 316, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "rmb", File = "Referenceable Mail Barcode Record", Summary = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure.", Description = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure. Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program separate from the required file structure.", LineLength = 316, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "rmb", File = "Referenceable Mail Barcode Record", Summary = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure.", Description = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure. Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program separate from the required file structure.", LineLength = 316, ClosingCharacter = "#")]
	[MaildatImport(Order = 23, Version = "23-1")]
	[MaildatImport(Order = 23, Version = "24-1")]
	[MaildatImport(Order = 23, Version = "25-1")]
	[Table("Rmb", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Rmb : MaildatEntity, IRmb 
	{
		/// <summary>
		/// Job ID (RMB-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMB-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// RMS ID (RMB-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[Column("RmsId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMB-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmsId { get; set; }

		/// <summary>
		/// Barcode (RMB-1003)
		/// IMb® for Informed Delivery.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1003", FieldName = "Barcode", Start = 17, Length = 34, Required = true, Key = true, DataType = "A/N", Description = "IMb® for Informed Delivery.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1003", FieldName = "Barcode", Start = 17, Length = 34, Required = true, Key = true, DataType = "A/N", Description = "IMb® for Informed Delivery.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1003", FieldName = "Barcode", Start = 17, Length = 34, Required = true, Key = true, DataType = "A/N", Description = "IMb® for Informed Delivery.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(34)]
		[Comment("RMB-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Barcode { get; set; }

		/// <summary>
		/// RMB Content Type (RMB-1004)
		/// Field to capture the type of RMB content. RMB content can either be a URL of a media image that is
		/// supported by browsers or a target URL that will be placed as a Hyperlink for the media/image.
		/// Details of the codes will be available in the USPS Technical Guide for Mail.dat.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1004", FieldName = "RMB Content Type", Start = 51, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMB content. RMB content can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image. Details of the codes will be available In the USPS Technical Guide for Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1004", FieldName = "RMB Content Type", Start = 51, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMB content. RMB content can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image. Details of the codes will be available In the USPS Technical Guide for Mail.dat.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1004", FieldName = "RMB Content Type", Start = 51, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMB content. RMB content can either be a URL of a media image that is supported by browsers or a target URL that will be placed as a Hyperlink for the media/image. Details of the codes will be available in the USPS Technical Guide for Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("RmbContentType", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C")]
		[Comment("RMB-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RmbContentTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmbContentType { get; set; }

		/// <summary>
		/// Original Job ID (RMB-1005)
		/// Job ID provided in another mailing job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1005", FieldName = "Original Job ID", Start = 52, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID provided in another mailing job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1005", FieldName = "Original Job ID", Start = 52, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID provided in another mailing job.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1005", FieldName = "Original Job ID", Start = 52, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID provided in another mailing job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalJobId", Order = 6, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("RMB-1005")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalJobId { get; set; }

		/// <summary>
		/// Original User License Code (RMB-1006)
		/// User License Code provided in another mailing job.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1006", FieldName = "Original User License Code", Start = 60, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1006", FieldName = "Original User License Code", Start = 60, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing job.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1006", FieldName = "Original User License Code", Start = 60, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalUserLicenseCode", Order = 7, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("RMB-1006")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// RMB Value (RMB-1007)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1007", FieldName = "RMB Value", Start = 64, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1007", FieldName = "RMB Value", Start = 64, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1007", FieldName = "RMB Value", Start = 64, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[Column("RmbValue", Order = 8, TypeName = "TEXT")]
		[MaxLength(250)]
		[Comment("RMB-1007")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmbValue { get; set; }

		/// <summary>
		/// RMB Template Code (RMB-1008)
		/// RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-1008", FieldName = "RMB Template Code", Start = 314, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-1008", FieldName = "RMB Template Code", Start = 314, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-1008", FieldName = "RMB Template Code", Start = 314, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.", Type = "string", Format = "leftjustify")]
		[Column("RmbTemplateCode", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("RMB-1008")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmbTemplateCode { get; set; }

		/// <summary>
		/// RMB Record Status (RMB-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-2000", FieldName = "RMB Record Status", Start = 315, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-2000", FieldName = "RMB Record Status", Start = 315, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-2000", FieldName = "RMB Record Status", Start = 315, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("RmbRecordStatus", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("RMB-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RmbRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RmbRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "rmb", FieldCode = "RMB-9999", FieldName = "Closing Character", Start = 316, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "rmb", FieldCode = "RMB-9999", FieldName = "Closing Character", Start = 316, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "rmb", FieldCode = "RMB-9999", FieldName = "Closing Character", Start = 316, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("RMB-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Rmb, string>(version, p => p.JobId, returnValue);
			this.RmsId = line.ParseForImport<Rmb, string>(version, p => p.RmsId, returnValue);
			this.Barcode = line.ParseForImport<Rmb, string>(version, p => p.Barcode, returnValue);
			this.RmbContentType = line.ParseForImport<Rmb, string>(version, p => p.RmbContentType, returnValue);
			this.OriginalJobId = line.ParseForImport<Rmb, string>(version, p => p.OriginalJobId, returnValue);
			this.OriginalUserLicenseCode = line.ParseForImport<Rmb, string>(version, p => p.OriginalUserLicenseCode, returnValue);
			this.RmbValue = line.ParseForImport<Rmb, string>(version, p => p.RmbValue, returnValue);
			this.RmbTemplateCode = line.ParseForImport<Rmb, string>(version, p => p.RmbTemplateCode, returnValue);
			this.RmbRecordStatus = line.ParseForImport<Rmb, string>(version, p => p.RmbRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Rmb, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Rmb, string>(version, p => p.JobId));
			sb.Append(this.RmsId.FormatForExport<Rmb, string>(version, p => p.RmsId));
			sb.Append(this.Barcode.FormatForExport<Rmb, string>(version, p => p.Barcode));
			sb.Append(this.RmbContentType.FormatForExport<Rmb, string>(version, p => p.RmbContentType));
			sb.Append(this.OriginalJobId.FormatForExport<Rmb, string>(version, p => p.OriginalJobId));
			sb.Append(this.OriginalUserLicenseCode.FormatForExport<Rmb, string>(version, p => p.OriginalUserLicenseCode));
			sb.Append(this.RmbValue.FormatForExport<Rmb, string>(version, p => p.RmbValue));
			sb.Append(this.RmbTemplateCode.FormatForExport<Rmb, string>(version, p => p.RmbTemplateCode));
			sb.Append(this.RmbRecordStatus.FormatForExport<Rmb, string>(version, p => p.RmbRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Rmb, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}