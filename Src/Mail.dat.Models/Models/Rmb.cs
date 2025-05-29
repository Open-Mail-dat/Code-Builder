// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 27th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program
	/// separate from the required file structure.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "rmb", File = "Referenceable Mail Barcode Record", Summary = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure.", Description = "Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program separate from the required file structure.", LineLength = 316, ClosingCharacter = "#")]
	[Table("Rmb", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 23)]
	public partial class Rmb : MaildatEntity, IRmb 
	{
		/// <summary>
		/// Job ID (RMB-1001)
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMB-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// RMS ID (RMB-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[Column("RMSID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMB-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMSID { get; set; }

		/// <summary>
		/// Barcode (RMB-1003)
		/// IMb® for Informed Delivery.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1003", FieldName = "Barcode", Start = 17, Length = 34, Required = true, Key = true, DataType = "A/N", Description = "IMb® for Informed Delivery.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(34)]
		[Comment("RMB-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string Barcode { get; set; }

		/// <summary>
		/// RMB Content Type (RMB-1004)
		/// Field to capture the type of RMB content. RMB content can either be a URL of a media image that is
		/// supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.
		/// Details of the codes will be available In the USPS Technical Guide for Mail.dat.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1004", FieldName = "RMB Content Type", Start = 51, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMB content. RMB content can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image. Details of the codes will be available In the USPS Technical Guide for Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("RMBContentType", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C")]
		[Comment("RMB-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RMBContentType { get; set; }

		/// <summary>
		/// Original Job ID (RMB-1005)
		/// Job ID provided in another mailing job.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1005", FieldName = "Original Job ID", Start = 52, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID provided in another mailing job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalJobID", Order = 6, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("RMB-1005")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalJobID { get; set; }

		/// <summary>
		/// Original User License Code (RMB-1006)
		/// User License Code provided in another mailing job.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1006", FieldName = "Original User License Code", Start = 60, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalUserLicenseCode", Order = 7, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("RMB-1006")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// RMB Value (RMB-1007)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1007", FieldName = "RMB Value", Start = 64, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[Column("RMBValue", Order = 8, TypeName = "TEXT")]
		[MaxLength(250)]
		[Comment("RMB-1007")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMBValue { get; set; }

		/// <summary>
		/// RMB Template Code (RMB-1008)
		/// RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1008", FieldName = "RMB Template Code", Start = 314, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.", Type = "string", Format = "leftjustify")]
		[Column("RMBTemplateCode", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("RMB-1008")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMBTemplateCode { get; set; }

		/// <summary>
		/// RMB Record Status (RMB-2000)
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-2000", FieldName = "RMB Record Status", Start = 315, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("RMBRecordStatus", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("RMB-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RMBRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-9999", FieldName = "Closing Character", Start = 316, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("RMB-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Rmb, string>(p => p.JobID, returnValue);
			this.RMSID = line.ParseForImport<Rmb, string>(p => p.RMSID, returnValue);
			this.Barcode = line.ParseForImport<Rmb, string>(p => p.Barcode, returnValue);
			this.RMBContentType = line.ParseForImport<Rmb, string>(p => p.RMBContentType, returnValue);
			this.OriginalJobID = line.ParseForImport<Rmb, string>(p => p.OriginalJobID, returnValue);
			this.OriginalUserLicenseCode = line.ParseForImport<Rmb, string>(p => p.OriginalUserLicenseCode, returnValue);
			this.RMBValue = line.ParseForImport<Rmb, string>(p => p.RMBValue, returnValue);
			this.RMBTemplateCode = line.ParseForImport<Rmb, string>(p => p.RMBTemplateCode, returnValue);
			this.RMBRecordStatus = line.ParseForImport<Rmb, string>(p => p.RMBRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Rmb, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Rmb, string>(p => p.JobID));
			sb.Append(this.RMSID.FormatForExport<Rmb, string>(p => p.RMSID));
			sb.Append(this.Barcode.FormatForExport<Rmb, string>(p => p.Barcode));
			sb.Append(this.RMBContentType.FormatForExport<Rmb, string>(p => p.RMBContentType));
			sb.Append(this.OriginalJobID.FormatForExport<Rmb, string>(p => p.OriginalJobID));
			sb.Append(this.OriginalUserLicenseCode.FormatForExport<Rmb, string>(p => p.OriginalUserLicenseCode));
			sb.Append(this.RMBValue.FormatForExport<Rmb, string>(p => p.RMBValue));
			sb.Append(this.RMBTemplateCode.FormatForExport<Rmb, string>(p => p.RMBTemplateCode));
			sb.Append(this.RMBRecordStatus.FormatForExport<Rmb, string>(p => p.RMBRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Rmb, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}