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
	/// Allows customers to tie or link container information between Jobs from Mail.dat and Mail.XML.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "oci", File = "Original Container Record", Summary = "Links new container with an original container.", Description = "Allows customers to tie or link container information between Jobs from Mail.dat and Mail.XML.", LineLength = 120, ClosingCharacter = "#")]
	[Table("Oci", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 19)]
	public partial class Oci : MaildatEntity, IOci 
	{
		/// <summary>
		/// Job ID (OCI-1001)
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("OCI-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Container ID (OCI-1002)
		/// This file is not designed for Mother Pallets.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1002", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Description = "This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("OCI-1002")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int ContainerID { get; set; }

		/// <summary>
		/// Original Job ID (OCI-1101)
		/// Job Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1101", FieldName = "Original Job ID", Start = 15, Length = 8, Required = true, Key = false, DataType = "A/N", Description = "Job Id provided in another Mailing Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalJobID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(8)]
		[Comment("OCI-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalJobID { get; set; }

		/// <summary>
		/// Original User License Code (OCI-1102)
		/// User License Code provided in another mailing/Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1102", FieldName = "Original User License Code", Start = 23, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "User License Code provided in another mailing/Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalUserLicenseCode", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[Comment("OCI-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalUserLicenseCode { get; set; }

		/// <summary>
		/// Original Segment ID (OCI-1103)
		/// Segment ID provided in another mailing/Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1103", FieldName = "Original Segment ID", Start = 27, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "Segment ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalSegmentID", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[Comment("OCI-1103")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalSegmentID { get; set; }

		/// <summary>
		/// Original Container ID (OCI-1104)
		/// Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1104", FieldName = "Original Container ID", Start = 31, Length = 6, Required = true, Key = false, DataType = "N", Description = "Container ID provided in another mailing/Job. This file is not designed for Mother Pallets.", Type = "integer", Format = "zfill")]
		[Column("OriginalContainerID", Order = 7, TypeName = "INTEGER")]
		[Required]
		[Comment("OCI-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int OriginalContainerID { get; set; }

		/// <summary>
		/// Original Display Container ID (OCI-1105)
		/// Meaningful (external to Mail.dat) container ID as defined by specific production application; the
		/// Postal container label. Display Container ID provided in another mailing/Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1105", FieldName = "Original Display Container ID", Start = 37, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "Meaningful (external to Mail.dat) container ID as defined by specific production application; the Postal container label. Display Container ID provided in another mailing/Job.", Type = "string", Format = "zfillnumeric")]
		[Column("OriginalDisplayContainerID", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("OCI-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalDisplayContainerID { get; set; }

		/// <summary>
		/// Original Label: IM™ Container Or IM™ Tray Barcode (OCI-1106)
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1106", FieldName = "Original Label: IM™ Container Or IM™ Tray Barcode", Start = 43, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("OriginalLabelIMContainerOrIMTrayBarcode", Order = 9, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("OCI-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalLabelIMContainerOrIMTrayBarcode { get; set; }

		/// <summary>
		/// Original Mail.XML Customer Group ID (OCI-1107)
		/// Mail.XML Customer Group ID provided in another Mailing Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1107", FieldName = "Original Mail.XML Customer Group ID", Start = 67, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Customer Group ID provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalMailXMLCustomerGroupID", Order = 10, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("OCI-1107")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalMailXMLCustomerGroupID { get; set; }

		/// <summary>
		/// Original Mail.XML Mailing Group ID (OCI-1108)
		/// Mail.XML Mailing Group Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1108", FieldName = "Original Mail.XML Mailing Group ID", Start = 79, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Mail.XML Mailing Group Id provided in another Mailing Job.", Type = "string", Format = "leftjustify")]
		[Column("OriginalMailXMLMailingGroupID", Order = 11, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("OCI-1108")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string OriginalMailXMLMailingGroupID { get; set; }

		/// <summary>
		/// Original Mail.XML Container ID (OCI-1109)
		/// Mail.XML Container Id provided in another Mailing Job.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1109", FieldName = "Original Mail.XML Container ID", Start = 91, Length = 12, Required = false, Key = false, DataType = "N", Description = "Mail.XML Container Id provided in another Mailing Job.", Type = "integer", Format = "zfill")]
		[Column("OriginalMailXMLContainerID", Order = 12, TypeName = "INTEGER")]
		[Comment("OCI-1109")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? OriginalMailXMLContainerID { get; set; }

		/// <summary>
		/// OCI Record Status (OCI-2000)
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-2000", FieldName = "OCI Record Status", Start = 103, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("OCIRecordStatus", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("OCI-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string OCIRecordStatus { get; set; }

		/// <summary>
		/// Reserve (OCI-1110)
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-1110", FieldName = "Reserve", Start = 104, Length = 16, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveOCI1110", Order = 14, TypeName = "TEXT")]
		[MaxLength(16)]
		[Comment("OCI-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveOCI1110 { get; set; }

		/// <summary>
		/// Closing Character (OCI-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "oci", FieldCode = "OCI-9999", FieldName = "Closing Character", Start = 120, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("OCI-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Oci, string>(p => p.JobID, returnValue);
			this.ContainerID = line.ParseForImport<Oci, int>(p => p.ContainerID, returnValue);
			this.OriginalJobID = line.ParseForImport<Oci, string>(p => p.OriginalJobID, returnValue);
			this.OriginalUserLicenseCode = line.ParseForImport<Oci, string>(p => p.OriginalUserLicenseCode, returnValue);
			this.OriginalSegmentID = line.ParseForImport<Oci, string>(p => p.OriginalSegmentID, returnValue);
			this.OriginalContainerID = line.ParseForImport<Oci, int>(p => p.OriginalContainerID, returnValue);
			this.OriginalDisplayContainerID = line.ParseForImport<Oci, string>(p => p.OriginalDisplayContainerID, returnValue);
			this.OriginalLabelIMContainerOrIMTrayBarcode = line.ParseForImport<Oci, string>(p => p.OriginalLabelIMContainerOrIMTrayBarcode, returnValue);
			this.OriginalMailXMLCustomerGroupID = line.ParseForImport<Oci, string>(p => p.OriginalMailXMLCustomerGroupID, returnValue);
			this.OriginalMailXMLMailingGroupID = line.ParseForImport<Oci, string>(p => p.OriginalMailXMLMailingGroupID, returnValue);
			this.OriginalMailXMLContainerID = line.ParseForImport<Oci, int?>(p => p.OriginalMailXMLContainerID, returnValue);
			this.OCIRecordStatus = line.ParseForImport<Oci, string>(p => p.OCIRecordStatus, returnValue);
			this.ReserveOCI1110 = line.ParseForImport<Oci, string>(p => p.ReserveOCI1110, returnValue);
			this.ClosingCharacter = line.ParseForImport<Oci, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Oci, string>(p => p.JobID));
			sb.Append(this.ContainerID.FormatForExport<Oci, int>(p => p.ContainerID));
			sb.Append(this.OriginalJobID.FormatForExport<Oci, string>(p => p.OriginalJobID));
			sb.Append(this.OriginalUserLicenseCode.FormatForExport<Oci, string>(p => p.OriginalUserLicenseCode));
			sb.Append(this.OriginalSegmentID.FormatForExport<Oci, string>(p => p.OriginalSegmentID));
			sb.Append(this.OriginalContainerID.FormatForExport<Oci, int>(p => p.OriginalContainerID));
			sb.Append(this.OriginalDisplayContainerID.FormatForExport<Oci, string>(p => p.OriginalDisplayContainerID));
			sb.Append(this.OriginalLabelIMContainerOrIMTrayBarcode.FormatForExport<Oci, string>(p => p.OriginalLabelIMContainerOrIMTrayBarcode));
			sb.Append(this.OriginalMailXMLCustomerGroupID.FormatForExport<Oci, string>(p => p.OriginalMailXMLCustomerGroupID));
			sb.Append(this.OriginalMailXMLMailingGroupID.FormatForExport<Oci, string>(p => p.OriginalMailXMLMailingGroupID));
			sb.Append(this.OriginalMailXMLContainerID.FormatForExport<Oci, int?>(p => p.OriginalMailXMLContainerID));
			sb.Append(this.OCIRecordStatus.FormatForExport<Oci, string>(p => p.OCIRecordStatus));
			sb.Append(this.ReserveOCI1110.FormatForExport<Oci, string>(p => p.ReserveOCI1110));
			sb.Append(this.ClosingCharacter.FormatForExport<Oci, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}