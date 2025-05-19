// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 18th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 1.0.0
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mail.dat
{
	/// <summary>
	/// Provide detail to verify Saturation or High Density mailings.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "wsr", File = "Walk Sequence Record", Summary = "Detail for each Walk Sequence prepared Carrier Route.", Description = "Provide detail to verify Saturation or High Density mailings.")]
	[Table("Wsr", Schema = "Maildat")]
	public partial class Wsr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (WSR-1001)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (WSR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 2)]
		[Required]
		[Key]
		[MaxLength(4)]
		public string SegmentID { get; set; }

		/// <summary>
		/// Package ZIP Code (WSR-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left
		/// Justify. See package Quantity File's Package Zip Code field's definition.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1013", FieldName = "Package ZIP Code", Start = 13, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of The package defined in the record. Left Justify. See package Quantity File's Package Zip Code field's definition.", Type = "string", Format = "leftjustify", References = "PQT-1013")]
		[Column("PackageZIPCode", Order = 3)]
		[Required]
		[Key]
		[MaxLength(6)]
		public string PackageZIPCode { get; set; }

		/// <summary>
		/// Package CR Number (WSR-1014)
		/// Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1014", FieldName = "Package CR Number", Start = 19, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "Example: C999 or 9999 example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCRNumber", Order = 4)]
		[Required]
		[Key]
		[MaxLength(4)]
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
		[Column("CoPalletizationCode", Order = 5)]
		[Required]
		[Key]
		[MaxLength(2)]
		public string CoPalletizationCode { get; set; }

		/// <summary>
		/// Walk Sequence Type (WSR-1101)
		/// This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon
		/// the number of Total addresses or Residential Only addresses within the route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1101", FieldName = "Walk Sequence Type", Start = 25, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the calculation of Saturation Walk Sequence Eligibility is based upon the number of Total addresses or Residential Only addresses within the route.", Type = "enum", Format = "leftjustify")]
		[Column("WalkSequenceType", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("R", "T")]
		public string WalkSequenceType { get; set; }

		/// <summary>
		/// Walk Sequence Stops (WSR-1102)
		/// The number of unique addresses (not pieces delivered) for the carrier When delivering this specific
		/// route within the saturation eligible mailing. This value represents the total stops incurred while
		/// the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier
		/// Route.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1102", FieldName = "Walk Sequence Stops", Start = 26, Length = 4, Required = true, Key = false, DataType = "N", Description = "The number of unique addresses (not pieces delivered) for the carrier When delivering this specific route within the saturation eligible mailing. This value represents the total stops incurred while the applicable carrier Route within this package is delivered. Walk Sequence Stops for this Carrier Route.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceStops", Order = 7)]
		[Required]
		public int WalkSequenceStops { get; set; }

		/// <summary>
		/// Walk Sequence Denominator (WSR-1103)
		/// Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in
		/// the CR. Cannot be zero.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1103", FieldName = "Walk Sequence Denominator", Start = 30, Length = 4, Required = true, Key = false, DataType = "N", Description = "Target (Total or Residential ) of WS Circulation. Potential Total or Residential Only addresses in the CR. Cannot be zero.", Type = "integer", Format = "zfill")]
		[Column("WalkSequenceDenominator", Order = 8)]
		[Required]
		public int WalkSequenceDenominator { get; set; }

		/// <summary>
		/// Walk Sequence Database Date (WSR-1104)
		/// The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1104", FieldName = "Walk Sequence Database Date", Start = 34, Length = 8, Required = true, Key = false, DataType = "N", Description = "The date of the database from which the walk sequence was secured. YYYYMMDD (cannot be all zeros).", Type = "string", Format = "YYYYMMDD")]
		[Column("WalkSequenceDatabaseDate", Order = 9)]
		[Required]
		[MaxLength(8)]
		public string WalkSequenceDatabaseDate { get; set; }

		/// <summary>
		/// WSR Record Status (WSR-2000)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-2000", FieldName = "WSR Record Status", Start = 42, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("WSRRecordStatus", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string WSRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (WSR-1105)
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-1105", FieldName = "Reserve", Start = 43, Length = 7, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 11)]
		[MaxLength(7)]
		public string ReserveWSR1105 { get; set; }

		/// <summary>
		/// Closing Character (WSR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "wsr", FieldCode = "WSR-9999", FieldName = "Closing Character", Start = 50, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 12)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}