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
	/// Quantity/rates per 3 or 5 digit in each container.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cqt", File = "Container Quantity Record", Summary = "Quantity/rates per 3 or 5 digit in each container.", Description = "Quantity/rates per 3 or 5 digit in each container.")]
	[Table("Cqt", Schema = "Maildat")]
	public partial class Cqt : MaildatFieldTemplate
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public new int Id { get; set; }

		/// <summary>
		/// Job ID (CQT-1001)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 1)]
		[Required]
		[Key]
		[MaxLength(8)]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (CQT-1034)
		/// Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must
		/// be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force
		/// new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their
		/// fields the same (except the CQT Database ID). It is also permitted to merge records when their
		/// fields are the same.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their fields the same (except the CQT Database ID). It is also permitted to merge records when their fields are the same.", Type = "integer", Format = "zfill")]
		[Column("CQTDatabaseID", Order = 2)]
		[Required]
		[Key]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Container ID (CQT-1006)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1006", FieldName = "Container ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "N", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 3)]
		[Required]
		public int ContainerID { get; set; }

		/// <summary>
		/// 3 Digit / 5 Digit Container Division (CQT-1007)
		/// 3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit
		/// represents those pieces within the container to a single 3 or 5 Digit; Not presuming this set of
		/// pieces to be all of those going to the destination of the container. For example: Carrier Route Sack
		/// is described in one 3 Digit or 5 Digit Container Quantity Record; However, likely multiple records
		/// required to describe a Residual tray. For First Class, Periodicals, or Standard Mail, this field
		/// within the CQT is to be a 3-Digit since There is generally no finer Zone or Destination Entry
		/// discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A
		/// value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record
		/// represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5
		/// Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those
		/// cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify
		/// the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting
		/// needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see
		/// following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN =
		/// (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; Generate additional 5 Digit
		/// records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C
		/// use 5 Digit Division). In the event that no postal code is available, then the following default
		/// 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US =
		/// USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code)
		/// International: Use ISO3166 (2 position alpha Country Code).
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1007", FieldName = "3 Digit / 5 Digit Container Division", Start = 23, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit represents those pieces within the container to a single 3 or 5 Digit; Not presuming this set of pieces to be all of those going to the destination of the container. For example: Carrier Route Sack is described in one 3 Digit or 5 Digit Container Quantity Record; However, likely multiple records required to describe a Residual tray. For First Class, Periodicals, or Standard Mail, this field within the CQT is to be a 3-Digit since There is generally no finer Zone or Destination Entry discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5 Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN = (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; Generate additional 5 Digit records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C use 5 Digit Division). In the event that no postal code is available, then the following default 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US = USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code) International: Use ISO3166 (2 position alpha Country Code).", Type = "string", Format = "leftjustify")]
		[Column("ThreeDigit5DigitContainerDivision", Order = 4)]
		[Required]
		[MaxLength(5)]
		public string ThreeDigit5DigitContainerDivision { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (CQT-1003)
		/// This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the
		/// specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists
		/// within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It
		/// must have some value, even if single edition.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1003", FieldName = "Mail Piece Unit ID", Start = 28, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It must have some value, even if single edition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 5)]
		[Required]
		[MaxLength(5)]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Zone (CQT-1101)
		/// Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for
		/// more information.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1101", FieldName = "Zone", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for more information.", Type = "enum", Format = "leftjustify")]
		[Column("Zone", Order = 6)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "D", "L", "N", "S", "V", "W")]
		public string Zone { get; set; }

		/// <summary>
		/// Destination Entry (CQT-1105)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1105", FieldName = "Destination Entry", Start = 34, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("DestinationEntry", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "B", "D", "H", "N", "P", "S")]
		public string DestinationEntry { get; set; }

		/// <summary>
		/// Rate Category (CQT-1008)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1008", FieldName = "Rate Category", Start = 35, Length = 2, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("RateCategory", Order = 8)]
		[Required]
		[MaxLength(2)]
		[AllowedValues("A", "A1", "B", "B1", "C", "C1", "D", "D1", "E", "FB", "FC", "FF", "FG", "FH", "FI", "FJ", "FN", "FS", "G", "H", "K", "L", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "N", "P7", "P8", "PM", "PO", "S", "SD", "X", "Z")]
		public string RateCategory { get; set; }

		/// <summary>
		/// Barcode Discount Or Surcharge Indicator (CQT-1009)
		/// For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard
		/// parcels that are not barcoded.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1009", FieldName = "Barcode Discount Or Surcharge Indicator", Start = 37, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard parcels that are not barcoded.", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeDiscountOrSurchargeIndicator", Order = 9)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("B", "D", "I", "O", "S")]
		public string BarcodeDiscountOrSurchargeIndicator { get; set; }

		/// <summary>
		/// Periodicals: Sub/ Non-Sub/ Requester Indicator (CQT-1010)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1010", FieldName = "Periodicals: Sub/ Non-Sub/ Requester Indicator", Start = 38, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsSubNonSubRequesterIndicator", Order = 10)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "O", "R", "S")]
		public string PeriodicalsSubNonSubRequesterIndicator { get; set; }

		/// <summary>
		/// Periodicals: Not County/In County (CQT-1011)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1011", FieldName = "Periodicals: Not County/In County", Start = 39, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsNotCountyInCounty", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("I", "N", "O")]
		public string PeriodicalsNotCountyInCounty { get; set; }

		/// <summary>
		/// Number of Copies (CQT-1102)
		/// Total copies within the specified 3 or 5 digit of this record within the specific container.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1102", FieldName = "Number of Copies", Start = 40, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies within the specified 3 or 5 digit of this record within the specific container.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 12)]
		[Required]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CQT-1103)
		/// Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number
		/// of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1103", FieldName = "Number of Pieces", Start = 48, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 13)]
		[Required]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Periodicals Co-Palletization Discount Indicator (CQT-1107)
		/// Value is set if new co-palletized piece; does not mean piece qualifies for rate.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1107", FieldName = "Periodicals Co-Palletization Discount Indicator", Start = 56, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Value is set if new co-palletized piece; does not mean piece qualifies for rate.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsCoPalletizationDiscountIndicator", Order = 14)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		public string PeriodicalsCoPalletizationDiscountIndicator { get; set; }

		/// <summary>
		/// Container Charge Allocation (CQT-1111)
		/// This field is to be used for denoting the proportion of cost of its container that it's carrying.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1111", FieldName = "Container Charge Allocation", Start = 57, Length = 7, Required = false, Key = false, DataType = "N", Description = "This field is to be used for denoting the proportion of cost of its container that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("ContainerChargeAllocation", Order = 15)]
		public decimal ContainerChargeAllocation { get; set; }

		/// <summary>
		/// Service Level Indicator (CQT-1112)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1112", FieldName = "Service Level Indicator", Start = 64, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("ServiceLevelIndicator", Order = 16)]
		[MaxLength(1)]
		[AllowedValues("B", "F", "O")]
		public string ServiceLevelIndicator { get; set; }

		/// <summary>
		/// Simplified Address Indicator (CQT-1113)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1113", FieldName = "Simplified Address Indicator", Start = 65, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SimplifiedAddressIndicator", Order = 17)]
		[MaxLength(1)]
		[AllowedValues("B", "M", "R", "Y")]
		public string SimplifiedAddressIndicator { get; set; }

		/// <summary>
		/// CQT Record Status (CQT-2000)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-2000", FieldName = "CQT Record Status", Start = 66, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("CQTRecordStatus", Order = 18)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		public string CQTRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CQT-1106)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1106", FieldName = "Reserve", Start = 67, Length = 19, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("Reserve", Order = 19)]
		[MaxLength(19)]
		public string ReserveCQT1106 { get; set; }

		/// <summary>
		/// Closing Character (CQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-9999", FieldName = "Closing Character", Start = 86, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 20)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		public string ClosingCharacter { get; } = "#";
	}
}