// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 30th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.3
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Provide detail to verify Saturation or High Density mailings.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Provide detail to verify Saturation or High Density mailings.", LineLength = 50, ClosingCharacter = "#")]
	[Table("Wsr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 11)]
	public partial class Wsr : MaildatEntity, IWsr 
	{
		/// <summary>
		/// Job ID (WSR-1001)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("WSR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (WSR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SegmentID { get; set; }

		/// <summary>
		/// Package ZIP Code (WSR-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. See package Quantity File's Package Zip Code field's definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[Column("PackageZIPCode", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("WSR-1013")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageZIPCode { get; set; }

		/// <summary>
		/// Package CR Number (WSR-1014)
		/// Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCRNumber", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1014")]
		[TypeConverter(typeof(MaildatStringConverter))]
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
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1015", FieldName = "Co-Palletization Code", Start = 23, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to allow association of Walk Sequence records with particular MPU records (*.mpu). For Co-palletization, it creates an efficient means to differentiate each of the possible job and sub-job entities within a co-palletization set-up. Can also be used to differentiate between simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for job swhere this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[Column("CoPalletizationCode", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[Comment("WSR-1015")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CoPalletizationCode { get; set; }

		/// <summary>
		/// Walk Sequence Type (WSR-1101)
		/// This field indicates whether the calculation of Saturation Walk Sequence eligibility is based upon
		/// the number of Total addresses or Residential Only addresses within the route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceType", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("R", "T")]
		[Comment("WSR-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string WalkSequenceType { get; set; }

		/// <summary>
		/// Walk Sequence Stops (WSR-1102)
		/// The number of unique addresses (not pieces delivered) for the carrier when delivering this specific
		/// route within the saturation eligible mailing. This value represents the total stops incurred while
		/// the applicable carrier route within this package is delivered. Walk Sequence Stops for this Carrier
		/// Route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier when delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceStops", Order = 8, TypeName = "INTEGER")]
		[Required]
		[Comment("WSR-1102")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int WalkSequenceStops { get; set; }

		/// <summary>
		/// Walk Sequence Denominator (WSR-1103)
		/// Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in
		/// the CR. Cannot be zero.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1103", FieldName = "Walk Sequence Denominator", Start = 30, Length = 4, Required = true, Key = false, DataType = "N", Description = "Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in the CR. Cannot be zero.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceDenominator", Order = 9, TypeName = "INTEGER")]
		[Required]
		[Comment("WSR-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int WalkSequenceDenominator { get; set; }

		/// <summary>
		/// Walk Sequence Database Date (WSR-1104)
		/// The date of the database from which the walk sequence was secured.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured.", Type = "date", Format = "YYYYMMDD")]
		[Column("WalkSequenceDatabaseDate", Order = 10, TypeName = "TEXT")]
		[Required]
		[Comment("WSR-1104")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly WalkSequenceDatabaseDate { get; set; }

		/// <summary>
		/// WSR Record Status (WSR-2000)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("WSRRecordStatus", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("WSR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string WSRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (WSR-1105)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Description = "", Type = "reserve", Format = "leftjustify")]
		[Column("ReserveWSR1105", Order = 12, TypeName = "TEXT")]
		[MaxLength(7)]
		[Comment("WSR-1105")]
		[TypeConverter(typeof(MaildatReserveConverter))]
		public string ReserveWSR1105 { get; set; }

		/// <summary>
		/// Closing Character (WSR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("WSR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Wsr, string>(p => p.JobID, returnValue);
			this.SegmentID = line.ParseForImport<Wsr, string>(p => p.SegmentID, returnValue);
			this.PackageZIPCode = line.ParseForImport<Wsr, string>(p => p.PackageZIPCode, returnValue);
			this.PackageCRNumber = line.ParseForImport<Wsr, string>(p => p.PackageCRNumber, returnValue);
			this.CoPalletizationCode = line.ParseForImport<Wsr, string>(p => p.CoPalletizationCode, returnValue);
			this.WalkSequenceType = line.ParseForImport<Wsr, string>(p => p.WalkSequenceType, returnValue);
			this.WalkSequenceStops = line.ParseForImport<Wsr, int>(p => p.WalkSequenceStops, returnValue);
			this.WalkSequenceDenominator = line.ParseForImport<Wsr, int>(p => p.WalkSequenceDenominator, returnValue);
			this.WalkSequenceDatabaseDate = line.ParseForImport<Wsr, DateOnly>(p => p.WalkSequenceDatabaseDate, returnValue);
			this.WSRRecordStatus = line.ParseForImport<Wsr, string>(p => p.WSRRecordStatus, returnValue);
			this.ReserveWSR1105 = line.ParseForImport<Wsr, string>(p => p.ReserveWSR1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Wsr, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Wsr, string>(p => p.JobID));
			sb.Append(this.SegmentID.FormatForExport<Wsr, string>(p => p.SegmentID));
			sb.Append(this.PackageZIPCode.FormatForExport<Wsr, string>(p => p.PackageZIPCode));
			sb.Append(this.PackageCRNumber.FormatForExport<Wsr, string>(p => p.PackageCRNumber));
			sb.Append(this.CoPalletizationCode.FormatForExport<Wsr, string>(p => p.CoPalletizationCode));
			sb.Append(this.WalkSequenceType.FormatForExport<Wsr, string>(p => p.WalkSequenceType));
			sb.Append(this.WalkSequenceStops.FormatForExport<Wsr, int>(p => p.WalkSequenceStops));
			sb.Append(this.WalkSequenceDenominator.FormatForExport<Wsr, int>(p => p.WalkSequenceDenominator));
			sb.Append(this.WalkSequenceDatabaseDate.FormatForExport<Wsr, DateOnly>(p => p.WalkSequenceDatabaseDate));
			sb.Append(this.WSRRecordStatus.FormatForExport<Wsr, string>(p => p.WSRRecordStatus));
			sb.Append(this.ReserveWSR1105.FormatForExport<Wsr, string>(p => p.ReserveWSR1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Wsr, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}