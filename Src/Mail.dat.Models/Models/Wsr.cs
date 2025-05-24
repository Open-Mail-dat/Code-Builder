// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 23rd, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Mail.dat
{
	/// <summary>
	/// Provide detail to verify Saturation or High Density mailings.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Provide detail to verify Saturation or High Density mailings.", LineLength = 50, ClosingCharacter = "#")]
	[Table("Wsr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	public partial class Wsr : MaildatEntity
	{
		/// <summary>
		/// Job ID (WSR-1001)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("WSR-1001")]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (WSR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 3)]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1002")]
		public string SegmentID { get; set; }

		/// <summary>
		/// Package ZIP Code (WSR-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left
		/// Justify. See package Quantity File's Package Zip Code field's definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[Column("PackageZIPCode", Order = 4)]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("WSR-1013")]
		public string PackageZIPCode { get; set; }

		/// <summary>
		/// Package CR Number (WSR-1014)
		/// Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCRNumber", Order = 5)]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("WSR-1014")]
		public string PackageCRNumber { get; set; }

		/// <summary>
		/// Co-Palletization Code (WSR-1015)
		/// Used to differentiate carrier route mail going to the same ZIP and Route that was coded and
		/// presorted independently, to Allow association of Walk Sequence records with particular MPU Records
		/// (*.mpu). For Co-palletization, it creates an efficient Means to differentiate each of the possible
		/// job and sub-job Entities within a co-palletization set-up. Can also be used to Differentiate between
		/// simplified and non-simplified addressed Pieces when combined in the same job. Populate with 01 for
		/// jobs Where this additional level of detail is not needed.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1015", FieldName = "Co-Palletization Code", Start = 23, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "Used to differentiate carrier route mail going to the same ZIP and Route that was coded and presorted independently, to Allow association of Walk Sequence records with particular MPU Records (*.mpu). For Co-palletization, it creates an efficient Means to differentiate each of the possible job and sub-job Entities within a co-palletization set-up. Can also be used to Differentiate between simplified and non-simplified addressed Pieces when combined in the same job. Populate with 01 for jobs Where this additional level of detail is not needed.", Type = "string", Format = "leftjustify")]
		[Column("CoPalletizationCode", Order = 6)]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[Comment("WSR-1015")]
		public string CoPalletizationCode { get; set; }

		/// <summary>
		/// Walk Sequence Type (WSR-1101)
		/// This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon
		/// the number of Total addresses or Residential Only addresses within the route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceType", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("R", "T")]
		[Comment("WSR-1101")]
		public string WalkSequenceType { get; set; }

		/// <summary>
		/// Walk Sequence Stops (WSR-1102)
		/// The number of unique addresses (not pieces delivered) for the carrier When delivering this specific
		/// route within the saturation eligible mailing. This value represents the total stops incurred while
		/// the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier
		/// Route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier When delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceStops", Order = 8)]
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
		[Column("WalkSequenceDenominator", Order = 9)]
		[Required]
		[Comment("WSR-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int WalkSequenceDenominator { get; set; }

		/// <summary>
		/// Walk Sequence Database Date (WSR-1104)
		/// The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).", Type = "string", Format = "YYYYMMDD")]
		[Column("WalkSequenceDatabaseDate", Order = 10)]
		[Required]
		[MaxLength(8)]
		[Comment("WSR-1104")]
		public string WalkSequenceDatabaseDate { get; set; }

		/// <summary>
		/// WSR Record Status (WSR-2000)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("WSRRecordStatus", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("WSR-2000")]
		public string WSRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (WSR-1105)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("ReserveWSR1105", Order = 12)]
		[MaxLength(7)]
		[Comment("WSR-1105")]
		public string ReserveWSR1105 { get; set; }

		/// <summary>
		/// Closing Character (WSR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("WSR-9999")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override ILoadError[] OnLoadData(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.FileLineNumber = fileLineNumber;
			this.JobID = line.Parse<Wsr, string>(p => p.JobID, returnValue);
			this.SegmentID = line.Parse<Wsr, string>(p => p.SegmentID, returnValue);
			this.PackageZIPCode = line.Parse<Wsr, string>(p => p.PackageZIPCode, returnValue);
			this.PackageCRNumber = line.Parse<Wsr, string>(p => p.PackageCRNumber, returnValue);
			this.CoPalletizationCode = line.Parse<Wsr, string>(p => p.CoPalletizationCode, returnValue);
			this.WalkSequenceType = line.Parse<Wsr, string>(p => p.WalkSequenceType, returnValue);
			this.WalkSequenceStops = line.Parse<Wsr, int>(p => p.WalkSequenceStops, returnValue);
			this.WalkSequenceDenominator = line.Parse<Wsr, int>(p => p.WalkSequenceDenominator, returnValue);
			this.WalkSequenceDatabaseDate = line.Parse<Wsr, string>(p => p.WalkSequenceDatabaseDate, returnValue);
			this.WSRRecordStatus = line.Parse<Wsr, string>(p => p.WSRRecordStatus, returnValue);
			this.ReserveWSR1105 = line.Parse<Wsr, string>(p => p.ReserveWSR1105, returnValue);
			this.ClosingCharacter = line.Parse<Wsr, string>(p => p.ClosingCharacter, returnValue);
			
			return returnValue.ToArray();
		}
	}
}