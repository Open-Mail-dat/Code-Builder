// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program
	/// separate from the required file structure.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "rmb", File = "Referenceable Mail Barcode Record", Summary = "Reference-able Mail Barcode to provide digital content at the piece level outside of the Mail.dat required files and structure.", Description = "Records identify digital campaigns and enhance capabilities of the USPS Informed Delivery  program separate from the required file structure.")]
	[Table("Rmb", Schema = "Maildat")]
	public partial class Rmb : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (RMB-1001)
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// RMS ID (RMB-1002)
		/// Unique ID of individual Campaign.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1002", FieldName = "RMS ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual Campaign.", Type = "string", Format = "leftjustify")]
		[Column("RMSID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string RMSID { get; set; }

		/// <summary>
		/// Barcode (RMB-1003)
		/// IMb® for Informed Delivery.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1003", FieldName = "Barcode", Start = 17, Length = 34, Required = true, Key = true, DataType = "A/N", Description = "IMb® for Informed Delivery.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 3)]
		[Required]
		[Key]
		[MaxLength(34)]
		public string Barcode { get; set; }

		/// <summary>
		/// RMB Content Type (RMB-1004)
		/// Field to capture the type of RMB content. RMB content can either be a URL of a media image that is
		/// supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.
		/// Details of the codes will be available In the USPS Technical Guide for Mail.dat.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1004", FieldName = "RMB Content Type", Start = 51, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMB content. RMB content can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image. Details of the codes will be available In the USPS Technical Guide for Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("RMBContentType", Order = 4)]
		[Required]
		[Key]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C")]
		public string RMBContentType { get; set; }

		/// <summary>
		/// Original Job ID (RMB-1005)
		/// Job ID provided in another mailing job.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1005", FieldName = "Original Job ID", Start = 52, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Job ID provided in another mailing job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalJobID", Order = 5)]
		[MaxLength(8)]
		public string OriginalJobID { get; set; }

		/// <summary>
		/// Original User License Code (RMB-1006)
		/// User License Code provided in another mailing job.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1006", FieldName = "Original User License Code", Start = 60, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalUserLicenseCode", Order = 6)]
		[MaxLength(4)]
		public string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// RMB Value (RMB-1007)
		/// Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or
		/// image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1007", FieldName = "RMB Value", Start = 64, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or target/HREF document (could be a webpage, or image/media driven by the RMR Content Type field); Leave BLANK if piece wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[Column("RMBValue", Order = 7)]
		[MaxLength(250)]
		public string RMBValue { get; set; }

		/// <summary>
		/// RMB Template Code (RMB-1008)
		/// RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-1008", FieldName = "RMB Template Code", Start = 314, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMB Template Code, one of many templates provided by Postal Service. Possible values A through Z.", Type = "string", Format = "leftjustify")]
		[Column("RMBTemplateCode", Order = 8)]
		[MaxLength(1)]
		public string RMBTemplateCode { get; set; }

		/// <summary>
		/// RMB Record Status (RMB-2000)
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-2000", FieldName = "RMB Record Status", Start = 315, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("RMBRecordStatus", Order = 9)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string RMBRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "rmb", FieldCode = "RMB-9999", FieldName = "Closing Character", Start = 316, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}