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
	/// Records identify digital campaigns and enhances capabilities of the USPS Informed Delivery program.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "rmr", File = "Referenceable Mail Record", Summary = "Reference-able Mail to provide digital content at the piece or version level.", Description = "Records identify digital campaigns and enhances capabilities of the USPS Informed Delivery program.", LineLength = 311, ClosingCharacter = "#")]
	[Table("Rmr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 22)]
	public partial class Rmr : MaildatEntity, IRmr 
	{
		/// <summary>
		/// Job ID (RMR-1001)
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("RMR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// RMR ID (RMR-1002)
		/// Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record
		/// should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right
		/// justify and zero fill; PDR - Piece ID; CPT - Component ID.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1002", FieldName = "RMR ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Key field, same ID data/value as the key fields for CPT or PDR, or PBC record that this record should be linked to. One of the following three values can be used: PBC - PBC Unique ID, right justify and zero fill; PDR - Piece ID; CPT - Component ID.", Type = "string", Format = "zfillnumeric", References = "PBC-1002,PDR-1018,CPT-1004")]
		[Column("RMRID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("RMR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMRID { get; set; }

		/// <summary>
		/// RMR ID Type (RMR-1003)
		/// Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record
		/// (CPT, PDR/PBC) that the RMR ID (this record) represents.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1003", FieldName = "RMR ID Type", Start = 31, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to link to a piece through PDR or PBC or to link to a version through CPT. Type of the record (CPT, PDR/PBC) that the RMR ID (this record) represents.", Type = "enum", Format = "leftjustify")]
		[Column("RMRIDType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("B", "C", "P")]
		[Comment("RMR-1003")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RMRIDType { get; set; }

		/// <summary>
		/// RMS ID (RMR-1009)
		/// RMS ID of the Campaign Summary record.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1009", FieldName = "RMS ID", Start = 32, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "RMS ID of the Campaign Summary record.", Type = "string", Format = "leftjustify", References = "RMS-1002")]
		[Column("RMSID", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("RMR-1009")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMSID { get; set; }

		/// <summary>
		/// RMR Content Type (RMR-1004)
		/// Field to capture the type of RMR content. RMR content Can either be a URL of a media image that is
		/// supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1004", FieldName = "RMR Content Type", Start = 40, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "Field to capture the type of RMR content. RMR content Can either be a URL of a media image that is supported by Browsers or a target URL that will be placed as a Hyperlink For the media/image.", Type = "enum", Format = "leftjustify")]
		[Column("RMRContentType", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C")]
		[Comment("RMR-1004")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RMRContentType { get; set; }

		/// <summary>
		/// CQT Database ID (RMR-1010)
		/// See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR.
		/// Field must be blank for RMR ID type of Component.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1010", FieldName = "CQT Database ID", Start = 41, Length = 8, Required = false, Key = false, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition. Required for RMR ID type of PBC and PDR. Field must be blank for RMR ID type of Component.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 7, TypeName = "INTEGER")]
		[Comment("RMR-1010")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? CQTDatabaseID { get; set; }

		/// <summary>
		/// RMR Value (RMR-1005)
		/// Value/Content URL for the Referenceable Mail media or Target/HREF document (could be a webpage, or
		/// image/media Driven by the RMR Content Type field); Leave BLANK if piece Wishes to be Opt out of Real
		/// Mail Program with RMR Content Type of O, else the field is required.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1005", FieldName = "RMR Value", Start = 49, Length = 250, Required = false, Key = false, DataType = "A/N", Description = "Value/Content URL for the Referenceable Mail media or Target/HREF document (could be a webpage, or image/media Driven by the RMR Content Type field); Leave BLANK if piece Wishes to be Opt out of Real Mail Program with RMR Content Type of O, else the field is required.", Type = "string", Format = "leftjustify")]
		[Column("RMRValue", Order = 8, TypeName = "TEXT")]
		[MaxLength(250)]
		[Comment("RMR-1005")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMRValue { get; set; }

		/// <summary>
		/// RMR Template Code (RMR-1008)
		/// RMR Template Code, one of many templates provided by Postal Service, Possible values can be A
		/// through Z.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1008", FieldName = "RMR Template Code", Start = 299, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "RMR Template Code, one of many templates provided by Postal Service, Possible values can be A through Z.", Type = "string", Format = "leftjustify")]
		[Column("RMRTemplateCode", Order = 9, TypeName = "TEXT")]
		[MaxLength(1)]
		[Comment("RMR-1008")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string RMRTemplateCode { get; set; }

		/// <summary>
		/// Reserve (RMR-1011)
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-1011", FieldName = "Reserve", Start = 300, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveRMR1011", Order = 10, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("RMR-1011")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveRMR1011 { get; set; }

		/// <summary>
		/// RMR Record Status (RMR-2000)
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-2000", FieldName = "RMR Record Status", Start = 310, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("RMRRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("RMR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RMRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (RMR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "rmr", FieldCode = "RMR-9999", FieldName = "Closing Character", Start = 311, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("RMR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Rmr, string>(p => p.JobID, returnValue);
			this.RMRID = line.ParseForImport<Rmr, string>(p => p.RMRID, returnValue);
			this.RMRIDType = line.ParseForImport<Rmr, string>(p => p.RMRIDType, returnValue);
			this.RMSID = line.ParseForImport<Rmr, string>(p => p.RMSID, returnValue);
			this.RMRContentType = line.ParseForImport<Rmr, string>(p => p.RMRContentType, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Rmr, int?>(p => p.CQTDatabaseID, returnValue);
			this.RMRValue = line.ParseForImport<Rmr, string>(p => p.RMRValue, returnValue);
			this.RMRTemplateCode = line.ParseForImport<Rmr, string>(p => p.RMRTemplateCode, returnValue);
			this.ReserveRMR1011 = line.ParseForImport<Rmr, string>(p => p.ReserveRMR1011, returnValue);
			this.RMRRecordStatus = line.ParseForImport<Rmr, string>(p => p.RMRRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Rmr, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Rmr, string>(p => p.JobID));
			sb.Append(this.RMRID.FormatForExport<Rmr, string>(p => p.RMRID));
			sb.Append(this.RMRIDType.FormatForExport<Rmr, string>(p => p.RMRIDType));
			sb.Append(this.RMSID.FormatForExport<Rmr, string>(p => p.RMSID));
			sb.Append(this.RMRContentType.FormatForExport<Rmr, string>(p => p.RMRContentType));
			sb.Append(this.CQTDatabaseID.FormatForExport<Rmr, int?>(p => p.CQTDatabaseID));
			sb.Append(this.RMRValue.FormatForExport<Rmr, string>(p => p.RMRValue));
			sb.Append(this.RMRTemplateCode.FormatForExport<Rmr, string>(p => p.RMRTemplateCode));
			sb.Append(this.ReserveRMR1011.FormatForExport<Rmr, string>(p => p.ReserveRMR1011));
			sb.Append(this.RMRRecordStatus.FormatForExport<Rmr, string>(p => p.RMRRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Rmr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}