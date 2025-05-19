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
	/// Identifies package/container of seed names within the presort.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "snr", File = "Seed Name Record", Summary = "Detail for each tracking program address.", Description = "Identifies package/container of seed names within the presort.")]
	[Table("Snr", Schema = "Maildat")]
	public partial class Snr : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (SNR-1001)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// Container ID (SNR-1006)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1006", FieldName = "Container ID", Start = 9, Length = 6, Required = true, Key = true, DataType = "N", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 2)]
		[Required]
		[Key]
		public int ContainerID { get; set; }

		/// <summary>
		/// Package ID (SNR-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1012", FieldName = "Package ID", Start = 15, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric", References = "PQT-1012")]
		[Column("PackageID", Order = 3)]
		[Required]
		[Key]
		[MaxLength(6)]
		public string PackageID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (SNR-1003)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1003", FieldName = "Mail Piece Unit ID", Start = 21, Length = 5, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 4)]
		[Required]
		[Key]
		[MaxLength(5)]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Seed Name ID (SNR-1016)
		/// Since this file is only necessary to be used in the event that a list of specific and documented
		/// names for a tracking program, then this field is populated with the supplied ID for each specific
		/// name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be
		/// tracked. General seed lists (example: all managers at the catalog) will not require feedback of this
		/// nature from the list house.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1016", FieldName = "Seed Name ID", Start = 26, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Since this file is only necessary to be used in the event that a list of specific and documented names for a tracking program, then this field is populated with the supplied ID for each specific name/address. Therefore, there will be one Seed Name Record for each supplied seed name to be tracked. General seed lists (example: all managers at the catalog) will not require feedback of this nature from the list house.", Type = "string", Format = "zfillnumeric")]
		[Column("SeedNameID", Order = 5)]
		[Required]
		[Key]
		[MaxLength(20)]
		public string SeedNameID { get; set; }

		/// <summary>
		/// Version Key Code (SNR-1017)
		/// Derived from original seed information. As with the Seed Name ID, this information is derived from
		/// the supplied name/address/record data.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1017", FieldName = "Version Key Code", Start = 46, Length = 20, Required = true, Key = true, DataType = "A/N", Description = "Derived from original seed information. As with the Seed Name ID, this information is derived from the supplied name/address/record data.", Type = "string", Format = "leftjustify")]
		[Column("VersionKeyCode", Order = 6)]
		[Required]
		[Key]
		[MaxLength(20)]
		public string VersionKeyCode { get; set; }

		/// <summary>
		/// Seed Name Received Date (SNR-1101)
		/// The date the seed agent received the mail piece.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1101", FieldName = "Seed Name Received Date", Start = 66, Length = 8, Required = false, Key = false, DataType = "N", Default = "00010101", Description = "The date the seed agent received the mail piece.", Type = "date", Format = "YYYYMMDD")]
		[Column("SeedNameReceivedDate", Order = 7)]
		public DateOnly SeedNameReceivedDate { get; set; }

		/// <summary>
		/// Seed Type (SNR-1104)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1104", FieldName = "Seed Type", Start = 74, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SeedType", Order = 8)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("B", "C", "R", "S")]
		public string SeedType { get; set; }

		/// <summary>
		/// Piece Barcode (SNR-1105)
		/// 5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1105", FieldName = "Piece Barcode", Start = 75, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "5-Digit, 9-Digit, 11-Digit routing ZIP barcode numeric.", Type = "string", Format = "leftjustify")]
		[Column("PieceBarcode", Order = 9)]
		[MaxLength(11)]
		public string PieceBarcode { get; set; }

		/// <summary>
		/// Reported Seed Condition (SNR-1106)
		/// The condition of the seed as received by a seed reporter.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1106", FieldName = "Reported Seed Condition", Start = 86, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "The condition of the seed as received by a seed reporter.", Type = "enum", Format = "leftjustify")]
		[Column("ReportedSeedCondition", Order = 10)]
		[MaxLength(1)]
		[AllowedValues("F", "G", "M", "P")]
		public string ReportedSeedCondition { get; set; }

		/// <summary>
		/// IM™ Barcode (SNR-1108)
		/// To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use
		/// the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain
		/// unique for 45 days.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1108", FieldName = "IM™ Barcode", Start = 87, Length = 34, Required = false, Key = false, DataType = "A/N", Description = "To be used for IM™ barcode only. This field not to be used to specify routing ZIP Barcode alone; use the Piece Barcode field identified above for routing ZIP barcode alone. The IM™ Barcode shall remain unique for 45 days.", Type = "string", Format = "leftjustify")]
		[Column("IMBarcode", Order = 11)]
		[MaxLength(34)]
		public string IMBarcode { get; set; }

		/// <summary>
		/// User Option Field (SNR-1110)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1110", FieldName = "User Option Field", Start = 121, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 12)]
		[MaxLength(20)]
		public string UserOptionField { get; set; }

		/// <summary>
		/// SNR Record Status (SNR-2000)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-2000", FieldName = "SNR Record Status", Start = 141, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SNRRecordStatus", Order = 13)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string SNRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SNR-1103)
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-1103", FieldName = "Reserve", Start = 142, Length = 18, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 14)]
		[MaxLength(18)]
		public string ReserveSNR1103 { get; set; }

		/// <summary>
		/// Closing Character (SNR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "snr", FieldCode = "SNR-9999", FieldName = "Closing Character", Start = 160, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 15)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}