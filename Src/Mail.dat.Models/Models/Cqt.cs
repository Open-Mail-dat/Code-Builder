// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 29th, 2025.
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
	/// Quantity/rates per 3 or 5 digit in each container.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "cqt", File = "Container Quantity Record", Summary = "Quantity/rates per 3 or 5 digit in each container.", Description = "Quantity/rates per 3 or 5 digit in each container.", LineLength = 86, ClosingCharacter = "#")]
	[Table("Cqt", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 9)]
	public partial class Cqt : MaildatEntity, ICqt 
	{
		/// <summary>
		/// Job ID (CQT-1001)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CQT-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
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
		[Column("CQTDatabaseID", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("CQT-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Container ID (CQT-1006)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1006", FieldName = "Container ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerID", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
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
		[Column("ThreeDigit5DigitContainerDivision", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(5)]
		[Comment("CQT-1007")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ThreeDigit5DigitContainerDivision { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (CQT-1003)
		/// This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the
		/// specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists
		/// within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It
		/// must have some value, even if single edition.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1003", FieldName = "Mail Piece Unit ID", Start = 28, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It must have some value, even if single edition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(5)]
		[Comment("CQT-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Zone (CQT-1101)
		/// Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for
		/// more information.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1101", FieldName = "Zone", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for more information.", Type = "enum", Format = "leftjustify")]
		[Column("Zone", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "D", "L", "N", "S", "V", "W")]
		[Comment("CQT-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string Zone { get; set; }

		/// <summary>
		/// Destination Entry (CQT-1105)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1105", FieldName = "Destination Entry", Start = 34, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("DestinationEntry", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "B", "D", "H", "N", "P", "S")]
		[Comment("CQT-1105")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string DestinationEntry { get; set; }

		/// <summary>
		/// Rate Category (CQT-1008)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1008", FieldName = "Rate Category", Start = 35, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("RateCategory", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("A", "A1", "B", "B1", "C", "C1", "D", "D1", "E", "FB", "FC", "FF", "FG", "FH", "FI", "FJ", "FN", "FS", "G", "H", "K", "L", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "N", "P7", "P8", "PM", "PO", "S", "SD", "X", "Z")]
		[Comment("CQT-1008")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string RateCategory { get; set; }

		/// <summary>
		/// Barcode Discount Or Surcharge Indicator (CQT-1009)
		/// For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard
		/// parcels that are not barcoded.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1009", FieldName = "Barcode Discount Or Surcharge Indicator", Start = 37, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard parcels that are not barcoded.", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeDiscountOrSurchargeIndicator", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("B", "D", "I", "O", "S")]
		[Comment("CQT-1009")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string BarcodeDiscountOrSurchargeIndicator { get; set; }

		/// <summary>
		/// Periodicals: Sub/ Non-Sub/ Requester Indicator (CQT-1010)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1010", FieldName = "Periodicals: Sub/ Non-Sub/ Requester Indicator", Start = 38, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsSubNonSubRequesterIndicator", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "O", "R", "S")]
		[Comment("CQT-1010")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PeriodicalsSubNonSubRequesterIndicator { get; set; }

		/// <summary>
		/// Periodicals: Not County/In County (CQT-1011)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1011", FieldName = "Periodicals: Not County/In County", Start = 39, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsNotCountyInCounty", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("I", "N", "O")]
		[Comment("CQT-1011")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PeriodicalsNotCountyInCounty { get; set; }

		/// <summary>
		/// Number of Copies (CQT-1102)
		/// Total copies within the specified 3 or 5 digit of this record within the specific container.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1102", FieldName = "Number of Copies", Start = 40, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies within the specified 3 or 5 digit of this record within the specific container.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 13, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1102")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CQT-1103)
		/// Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number
		/// of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1103", FieldName = "Number of Pieces", Start = 48, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 14, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Periodicals Co-Palletization Discount Indicator (CQT-1107)
		/// Value is set if new co-palletized piece; does not mean piece qualifies for rate.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1107", FieldName = "Periodicals Co-Palletization Discount Indicator", Start = 56, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Value is set if new co-palletized piece; does not mean piece qualifies for rate.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsCoPalletizationDiscountIndicator", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("CQT-1107")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PeriodicalsCoPalletizationDiscountIndicator { get; set; }

		/// <summary>
		/// Container Charge Allocation (CQT-1111)
		/// This field is to be used for denoting the proportion of cost of its container that it's carrying.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1111", FieldName = "Container Charge Allocation", Start = 57, Length = 7, Required = false, Key = false, DataType = "N", Description = "This field is to be used for denoting the proportion of cost of its container that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("ContainerChargeAllocation", Order = 16, TypeName = "NUMERIC")]
		[Precision(6)]
		[Comment("CQT-1111")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? ContainerChargeAllocation { get; set; }

		/// <summary>
		/// Service Level Indicator (CQT-1112)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1112", FieldName = "Service Level Indicator", Start = 64, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ServiceLevelIndicator", Order = 17, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("B", "F", "O")]
		[Comment("CQT-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ServiceLevelIndicator { get; set; }

		/// <summary>
		/// Simplified Address Indicator (CQT-1113)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1113", FieldName = "Simplified Address Indicator", Start = 65, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SimplifiedAddressIndicator", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "B", "M", "R", "Y")]
		[Comment("CQT-1113")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string SimplifiedAddressIndicator { get; set; }

		/// <summary>
		/// CQT Record Status (CQT-2000)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-2000", FieldName = "CQT Record Status", Start = 66, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CQTRecordStatus", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CQT-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CQTRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CQT-1106)
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-1106", FieldName = "Reserve", Start = 67, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveCQT1106", Order = 20, TypeName = "TEXT")]
		[MaxLength(19)]
		[Comment("CQT-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveCQT1106 { get; set; }

		/// <summary>
		/// Closing Character (CQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "cqt", FieldCode = "CQT-9999", FieldName = "Closing Character", Start = 86, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 21, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CQT-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Cqt, string>(p => p.JobID, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Cqt, int>(p => p.CQTDatabaseID, returnValue);
			this.ContainerID = line.ParseForImport<Cqt, int>(p => p.ContainerID, returnValue);
			this.ThreeDigit5DigitContainerDivision = line.ParseForImport<Cqt, string>(p => p.ThreeDigit5DigitContainerDivision, returnValue);
			this.MailPieceUnitID = line.ParseForImport<Cqt, string>(p => p.MailPieceUnitID, returnValue);
			this.Zone = line.ParseForImport<Cqt, string>(p => p.Zone, returnValue);
			this.DestinationEntry = line.ParseForImport<Cqt, string>(p => p.DestinationEntry, returnValue);
			this.RateCategory = line.ParseForImport<Cqt, string>(p => p.RateCategory, returnValue);
			this.BarcodeDiscountOrSurchargeIndicator = line.ParseForImport<Cqt, string>(p => p.BarcodeDiscountOrSurchargeIndicator, returnValue);
			this.PeriodicalsSubNonSubRequesterIndicator = line.ParseForImport<Cqt, string>(p => p.PeriodicalsSubNonSubRequesterIndicator, returnValue);
			this.PeriodicalsNotCountyInCounty = line.ParseForImport<Cqt, string>(p => p.PeriodicalsNotCountyInCounty, returnValue);
			this.NumberOfCopies = line.ParseForImport<Cqt, int>(p => p.NumberOfCopies, returnValue);
			this.NumberOfPieces = line.ParseForImport<Cqt, int>(p => p.NumberOfPieces, returnValue);
			this.PeriodicalsCoPalletizationDiscountIndicator = line.ParseForImport<Cqt, string>(p => p.PeriodicalsCoPalletizationDiscountIndicator, returnValue);
			this.ContainerChargeAllocation = line.ParseForImport<Cqt, decimal?>(p => p.ContainerChargeAllocation, returnValue);
			this.ServiceLevelIndicator = line.ParseForImport<Cqt, string>(p => p.ServiceLevelIndicator, returnValue);
			this.SimplifiedAddressIndicator = line.ParseForImport<Cqt, string>(p => p.SimplifiedAddressIndicator, returnValue);
			this.CQTRecordStatus = line.ParseForImport<Cqt, string>(p => p.CQTRecordStatus, returnValue);
			this.ReserveCQT1106 = line.ParseForImport<Cqt, string>(p => p.ReserveCQT1106, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cqt, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Cqt, string>(p => p.JobID));
			sb.Append(this.CQTDatabaseID.FormatForExport<Cqt, int>(p => p.CQTDatabaseID));
			sb.Append(this.ContainerID.FormatForExport<Cqt, int>(p => p.ContainerID));
			sb.Append(this.ThreeDigit5DigitContainerDivision.FormatForExport<Cqt, string>(p => p.ThreeDigit5DigitContainerDivision));
			sb.Append(this.MailPieceUnitID.FormatForExport<Cqt, string>(p => p.MailPieceUnitID));
			sb.Append(this.Zone.FormatForExport<Cqt, string>(p => p.Zone));
			sb.Append(this.DestinationEntry.FormatForExport<Cqt, string>(p => p.DestinationEntry));
			sb.Append(this.RateCategory.FormatForExport<Cqt, string>(p => p.RateCategory));
			sb.Append(this.BarcodeDiscountOrSurchargeIndicator.FormatForExport<Cqt, string>(p => p.BarcodeDiscountOrSurchargeIndicator));
			sb.Append(this.PeriodicalsSubNonSubRequesterIndicator.FormatForExport<Cqt, string>(p => p.PeriodicalsSubNonSubRequesterIndicator));
			sb.Append(this.PeriodicalsNotCountyInCounty.FormatForExport<Cqt, string>(p => p.PeriodicalsNotCountyInCounty));
			sb.Append(this.NumberOfCopies.FormatForExport<Cqt, int>(p => p.NumberOfCopies));
			sb.Append(this.NumberOfPieces.FormatForExport<Cqt, int>(p => p.NumberOfPieces));
			sb.Append(this.PeriodicalsCoPalletizationDiscountIndicator.FormatForExport<Cqt, string>(p => p.PeriodicalsCoPalletizationDiscountIndicator));
			sb.Append(this.ContainerChargeAllocation.FormatForExport<Cqt, decimal?>(p => p.ContainerChargeAllocation));
			sb.Append(this.ServiceLevelIndicator.FormatForExport<Cqt, string>(p => p.ServiceLevelIndicator));
			sb.Append(this.SimplifiedAddressIndicator.FormatForExport<Cqt, string>(p => p.SimplifiedAddressIndicator));
			sb.Append(this.CQTRecordStatus.FormatForExport<Cqt, string>(p => p.CQTRecordStatus));
			sb.Append(this.ReserveCQT1106.FormatForExport<Cqt, string>(p => p.ReserveCQT1106));
			sb.Append(this.ClosingCharacter.FormatForExport<Cqt, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}