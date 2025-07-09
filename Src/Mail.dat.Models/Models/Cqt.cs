//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// This code was auto-generated on July 8th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
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
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "cqt", File = "Container Quantity Record", Summary = "Quantity/rates per 3 or 5 digit in each container.", Description = "Quantity/rates per 3 or 5 digit in each container.", LineLength = 86, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "cqt", File = "Container Quantity Record", Summary = "Quantity/rates per 3 or 5 digit in each container.", Description = "Quantity/rates per 3 or 5 digit in each container.", LineLength = 86, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "cqt", File = "Container Quantity Record", Summary = "Quantity/rates per 3 or 5 digit in each container.", Description = "Quantity/rates per 3 or 5 digit in each container.", LineLength = 86, ClosingCharacter = "#")]
	[MaildatImport(Order = 9, Version = "23-1")]
	[MaildatImport(Order = 9, Version = "24-1")]
	[MaildatImport(Order = 9, Version = "25-1")]
	[Table("Cqt", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Cqt : MaildatEntity, ICqt 
	{
		/// <summary>
		/// Job ID (CQT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CQT-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (CQT-1034)
		/// Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must
		/// be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force
		/// new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their
		/// fields the same (except the CQT Database ID). It is also permitted to merge records when their
		/// fields are the same.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their fields the same (except the CQT Database ID). It is also permitted to merge records when their fields are the same.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their fields the same (except the CQT Database ID). It is also permitted to merge records when their fields are the same.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "Mail.dat® Container Quantity unique number, used to link Mail.dat® CQT and PQT (and PDR) files. Must be mutually exclusive across a Job ID. All non-Key fields in the CQT records should be used to force new records; thus requiring a new CQT ID. It is permitted to have multiple records with all of their fields the same (except the CQT Database ID). It is also permitted to merge records when their fields are the same.", Type = "integer", Format = "zfill")]
		[Column("CqtDatabaseId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("CQT-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Container ID (CQT-1006)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1006", FieldName = "Container ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1006", FieldName = "Container ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1006", FieldName = "Container ID", Start = 17, Length = 6, Required = true, Key = false, DataType = "N", Description = "", Type = "integer", Format = "zfill", References = "CSM-1006")]
		[Column("ContainerId", Order = 4, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int ContainerId { get; set; }

		/// <summary>
		/// 3 Digit / 5 Digit Container Division (CQT-1007)
		/// 3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit
		/// represents those pieces within the container to a single 3 or 5 Digit; not presuming this set of
		/// pieces to be all of those going to the destination of the container. For example: Carrier Route Sack
		/// is described in one 3 Digit or 5 Digit Container Quantity Record; however, likely multiple records
		/// required to describe a Residual tray. there is generally no finer Zone or Destination Entry
		/// discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A
		/// value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record
		/// represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5
		/// Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those
		/// cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify
		/// the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting
		/// needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see
		/// following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN =
		/// (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; generate additional 5 Digit
		/// records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C
		/// use 5 Digit Division). In the event that no postal code is available, then the following default
		/// 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US =
		/// USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code)
		/// International: Use ISO3166 (2 position alpha Country Code).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1007", FieldName = "3 Digit / 5 Digit Container Division", Start = 23, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit represents those pieces within the container to a single 3 or 5 Digit; Not presuming this set of pieces to be all of those going to the destination of the container. For example: Carrier Route Sack is described in one 3 Digit or 5 Digit Container Quantity Record; However, likely multiple records required to describe a Residual tray. For First Class, Periodicals, or Standard Mail, this field within the CQT is to be a 3-Digit since There is generally no finer Zone or Destination Entry discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5 Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN = (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; Generate additional 5 Digit records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C use 5 Digit Division). In the event that no postal code is available, then the following default 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US = USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code) International: Use ISO3166 (2 position alpha Country Code).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1007", FieldName = "3 Digit / 5 Digit Container Division", Start = 23, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit represents those pieces within the container to a single 3 or 5 Digit; Not presuming this set of pieces to be all of those going to the destination of the container. For example: Carrier Route Sack is described in one 3 Digit or 5 Digit Container Quantity Record; However, likely multiple records required to describe a Residual tray. For First Class, Periodicals, or Standard Mail, this field within the CQT is to be a 3-Digit since There is generally no finer Zone or Destination Entry discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5 Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN = (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; Generate additional 5 Digit records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C use 5 Digit Division). In the event that no postal code is available, then the following default 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US = USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code) International: Use ISO3166 (2 position alpha Country Code).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1007", FieldName = "3 Digit / 5 Digit Container Division", Start = 23, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "3 or 5 Digit representing a portion or all of the pieces within the container. The 3 or 5 Digit represents those pieces within the container to a single 3 or 5 Digit; not presuming this set of pieces to be all of those going to the destination of the container. For example: Carrier Route Sack is described in one 3 Digit or 5 Digit Container Quantity Record; however, likely multiple records required to describe a Residual tray. there is generally no finer Zone or Destination Entry discrimination necessary. The exceptions for the preceding cases are when there is either: 1) A value representing DDU in field CQT - 1105 for the respective CQT record 2) When the CQT record represents a portion of a 5-Digit Scheme package. 3) For all Package Services CQT records. 4) A 5 Digit ZIP Code is required for products where zoning is determined at a 5-Digit level. In those cited cases, the 3 Digit / 5 Digit field for that container must have 5-Digit detail. Left Justify the 3 Digit; if applicable. The user can make divisions as appropriate to meet the USPS reporting needs. Only US Postal Service and Canada Post mail should have 3- or 5-byte values, all others see following. 3 Digit or 5 Digit Division as necessary. Example: US = (99999_), or (888___) CANADIAN = (A1A___), Left Justify 3 Digit (1C, 2C & 3C use 3 Digit Division; generate additional 5 Digit records, if a DDU in position 49 of .CSM or if record is a 5 Digit Scheme Package or Container ) (4C use 5 Digit Division). In the event that no postal code is available, then the following default 2-position alphas are to be used: Default if no ZIP or Postal Code: Left Justify; Space Added: US = USA CA = Canada MX = Mexico FOR = Foreign Mail: use ISO3166 (2 position alpha Country Code) International: Use ISO3166 (2 position alpha Country Code).", Type = "string", Format = "leftjustify")]
		[Column("ThreeDigit5DigitContainerDivision", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(5)]
		[Comment("CQT-1007")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ThreeDigit5DigitContainerDivision { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (CQT-1003)
		/// This ID will be used by the computer controlled equipment at the mailing facility to manufacture the
		/// specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists
		/// within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique.
		/// Must have some value, even if single edition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1003", FieldName = "Mail Piece Unit ID", Start = 28, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It must have some value, even if single edition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1003", FieldName = "Mail Piece Unit ID", Start = 28, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "This ID will be used by the computer controlled equipment at the mailing facility to Manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. It must have some value, even if single edition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1003", FieldName = "Mail Piece Unit ID", Start = 28, Length = 5, Required = true, Key = false, DataType = "A/N", Description = "This ID will be used by the computer controlled equipment at the mailing facility to manufacture the specific binding parts for this make-up within this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore, Segment/MPU is mutually exclusive. MPU alone is not unique. Must have some value, even if single edition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitId", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(5)]
		[Comment("CQT-1003")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string MailPieceUnitId { get; set; }

		/// <summary>
		/// Zone (CQT-1101)
		/// Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for
		/// more information.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1101", FieldName = "Zone", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for more information.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1101", FieldName = "Zone", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for more information.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1101", FieldName = "Zone", Start = 33, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Note: Refer to USPS DMM, USPS Notice 123, USPS Postage Statements, USPS Mail.dat Technical guide for more information.", Type = "enum", Format = "leftjustify")]
		[Column("Zone", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "D", "L", "N", "S", "V", "W")]
		[Comment("CQT-1101")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(Zones))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Zone { get; set; }

		/// <summary>
		/// Destination Entry (CQT-1105)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1105", FieldName = "Destination Entry", Start = 34, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1105", FieldName = "Destination Entry", Start = 34, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1105", FieldName = "Destination Entry", Start = 34, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("DestinationEntry", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("A", "B", "D", "H", "N", "O", "P", "S")]
		[Comment("CQT-1105")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(DestinationEntries))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string DestinationEntry { get; set; }

		/// <summary>
		/// Rate Category (CQT-1008)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1008", FieldName = "Rate Category", Start = 35, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1008", FieldName = "Rate Category", Start = 35, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1008", FieldName = "Rate Category", Start = 35, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("RateCategory", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("A", "A1", "B", "B1", "C", "C1", "D", "D1", "E", "FB", "FC", "FF", "FG", "FH", "FI", "FJ", "FN", "FS", "G", "H", "K", "L", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "N", "P7", "P8", "PM", "PO", "S", "SD", "X", "Z")]
		[Comment("CQT-1008")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(RateCategories))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string RateCategory { get; set; }

		/// <summary>
		/// Barcode Discount Or Surcharge Indicator (CQT-1009)
		/// For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard
		/// parcels that are not barcoded.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1009", FieldName = "Barcode Discount Or Surcharge Indicator", Start = 37, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or irregular parcels that are not barcoded.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1009", FieldName = "Barcode Discount Or Surcharge Indicator", Start = 37, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or irregular parcels that are not barcoded.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1009", FieldName = "Barcode Discount Or Surcharge Indicator", Start = 37, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "For Standard Mail that is not sorted to 5-digit there is a surcharge for machinable or nonstandard parcels that are not barcoded.", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeDiscountOrSurchargeIndicator", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("B", "D", "I", "O", "S")]
		[Comment("CQT-1009")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(BarcodeDiscountOrSurchargeIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string BarcodeDiscountOrSurchargeIndicator { get; set; }

		/// <summary>
		/// Periodicals: Sub/ Non-Sub/ Requester Indicator (CQT-1010)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1010", FieldName = "Periodicals: Sub/ Non-Sub/ Requester Indicator", Start = 38, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1010", FieldName = "Periodicals: Sub/ Non-Sub/ Requester Indicator", Start = 38, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1010", FieldName = "Periodicals: Sub/ Non-Sub/ Requester Indicator", Start = 38, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsSubNonSubRequesterIndicator", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "O", "R", "S")]
		[Comment("CQT-1010")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PeriodicalsSubNonSubRequesterIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalsSubNonSubRequesterIndicator { get; set; }

		/// <summary>
		/// Periodicals: Not County/In County (CQT-1011)
		/// Applicable to Periodicals.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1011", FieldName = "Periodicals: Not County/In County", Start = 39, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1011", FieldName = "Periodicals: Not County/In County", Start = 39, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1011", FieldName = "Periodicals: Not County/In County", Start = 39, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Applicable to Periodicals.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsNotCountyInCounty", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("I", "N", "O")]
		[Comment("CQT-1011")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PeriodicalsNotCountyInCounties))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalsNotCountyInCounty { get; set; }

		/// <summary>
		/// Number of Copies (CQT-1102)
		/// Total copies within the specified 3 or 5 digit of this record within the specific container.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1102", FieldName = "Number of Copies", Start = 40, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies within the specified 3 or 5 digit of this record within the specific container.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1102", FieldName = "Number of Copies", Start = 40, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies within the specified 3 or 5 digit of this record within the specific container.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1102", FieldName = "Number of Copies", Start = 40, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies within the specified 3 or 5 digit of this record within the specific container.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 13, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1102")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CQT-1103)
		/// Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number
		/// of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1103", FieldName = "Number of Pieces", Start = 48, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1103", FieldName = "Number of Pieces", Start = 48, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1103", FieldName = "Number of Pieces", Start = 48, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total pieces within the specified 3 or 5 digit of this record within the specific container. (Number of Pieces may be less than number of Copies in some Periodicals or Package Service mailings.).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 14, TypeName = "INTEGER")]
		[Required]
		[Comment("CQT-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Periodicals Co-Palletization Discount Indicator (CQT-1107)
		/// Value is set if new co-palletized piece; does not mean piece qualifies for rate.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1107", FieldName = "Periodicals Co-Palletization Discount Indicator", Start = 56, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Value is set if new co-palletized piece; does not mean piece qualifies for rate.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1107", FieldName = "Periodicals Co-Palletization Discount Indicator", Start = 56, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Value is set if new co-palletized piece; does not mean piece qualifies for rate.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1107", FieldName = "Periodicals Co-Palletization Discount Indicator", Start = 56, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "Value is set if new co-palletized piece; does not mean piece qualifies for rate.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsCoPalletizationDiscountIndicator", Order = 15, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("CQT-1107")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PeriodicalsCoPalletizationDiscountIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PeriodicalsCoPalletizationDiscountIndicator { get; set; }

		/// <summary>
		/// Container Charge Allocation (CQT-1111)
		/// Proportion, rounded This field is to be used for denoting the proportion of cost of its container
		/// that it's carrying.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1111", FieldName = "Container Charge Allocation", Start = 57, Length = 7, Required = false, Key = false, DataType = "N", Description = "Proportion, rounded This field is to be used for denoting the proportion of cost of its container that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1111", FieldName = "Container Charge Allocation", Start = 57, Length = 7, Required = false, Key = false, DataType = "N", Description = "Proportion, rounded This field is to be used for denoting the proportion of cost of its container that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1111", FieldName = "Container Charge Allocation", Start = 57, Length = 7, Required = false, Key = false, DataType = "N", Description = "Proportion, rounded This field is to be used for denoting the proportion of cost of its container that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("ContainerChargeAllocation", Order = 16, TypeName = "NUMERIC")]
		[Precision(6)]
		[Comment("CQT-1111")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? ContainerChargeAllocation { get; set; }

		/// <summary>
		/// Service Level Indicator (CQT-1112)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1112", FieldName = "Service Level Indicator", Start = 64, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1112", FieldName = "Service Level Indicator", Start = 64, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1112", FieldName = "Service Level Indicator", Start = 64, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("ServiceLevelIndicator", Order = 17, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("B", "F", "O", "P")]
		[Comment("CQT-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(ServiceLevelIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ServiceLevelIndicator { get; set; }

		/// <summary>
		/// Simplified Address Indicator (CQT-1113)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1113", FieldName = "Simplified Address Indicator", Start = 65, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1113", FieldName = "Simplified Address Indicator", Start = 65, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1113", FieldName = "Simplified Address Indicator", Start = 65, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SimplifiedAddressIndicator", Order = 18, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "B", "M", "R", "Y")]
		[Comment("CQT-1113")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(SimplifiedAddressIndicators))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string SimplifiedAddressIndicator { get; set; }

		/// <summary>
		/// CQT Record Status (CQT-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-2000", FieldName = "CQT Record Status", Start = 66, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-2000", FieldName = "CQT Record Status", Start = 66, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-2000", FieldName = "CQT Record Status", Start = 66, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CqtRecordStatus", Order = 19, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CQT-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CqtRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CqtRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CQT-1106)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-1106", FieldName = "Reserve", Start = 67, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-1106", FieldName = "Reserve", Start = 67, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-1106", FieldName = "Reserve", Start = 67, Length = 19, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCqt1106", Order = 20, TypeName = "TEXT")]
		[MaxLength(19)]
		[Comment("CQT-1106")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReserveCqt1106 { get; set; }

		/// <summary>
		/// Closing Character (CQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "cqt", FieldCode = "CQT-9999", FieldName = "Closing Character", Start = 86, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "cqt", FieldCode = "CQT-9999", FieldName = "Closing Character", Start = 86, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "cqt", FieldCode = "CQT-9999", FieldName = "Closing Character", Start = 86, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 21, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CQT-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Cqt, string>(version, p => p.JobId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Cqt, int>(version, p => p.CqtDatabaseId, returnValue);
			this.ContainerId = line.ParseForImport<Cqt, int>(version, p => p.ContainerId, returnValue);
			this.ThreeDigit5DigitContainerDivision = line.ParseForImport<Cqt, string>(version, p => p.ThreeDigit5DigitContainerDivision, returnValue);
			this.MailPieceUnitId = line.ParseForImport<Cqt, string>(version, p => p.MailPieceUnitId, returnValue);
			this.Zone = line.ParseForImport<Cqt, string>(version, p => p.Zone, returnValue);
			this.DestinationEntry = line.ParseForImport<Cqt, string>(version, p => p.DestinationEntry, returnValue);
			this.RateCategory = line.ParseForImport<Cqt, string>(version, p => p.RateCategory, returnValue);
			this.BarcodeDiscountOrSurchargeIndicator = line.ParseForImport<Cqt, string>(version, p => p.BarcodeDiscountOrSurchargeIndicator, returnValue);
			this.PeriodicalsSubNonSubRequesterIndicator = line.ParseForImport<Cqt, string>(version, p => p.PeriodicalsSubNonSubRequesterIndicator, returnValue);
			this.PeriodicalsNotCountyInCounty = line.ParseForImport<Cqt, string>(version, p => p.PeriodicalsNotCountyInCounty, returnValue);
			this.NumberOfCopies = line.ParseForImport<Cqt, int>(version, p => p.NumberOfCopies, returnValue);
			this.NumberOfPieces = line.ParseForImport<Cqt, int>(version, p => p.NumberOfPieces, returnValue);
			this.PeriodicalsCoPalletizationDiscountIndicator = line.ParseForImport<Cqt, string>(version, p => p.PeriodicalsCoPalletizationDiscountIndicator, returnValue);
			this.ContainerChargeAllocation = line.ParseForImport<Cqt, decimal?>(version, p => p.ContainerChargeAllocation, returnValue);
			this.ServiceLevelIndicator = line.ParseForImport<Cqt, string>(version, p => p.ServiceLevelIndicator, returnValue);
			this.SimplifiedAddressIndicator = line.ParseForImport<Cqt, string>(version, p => p.SimplifiedAddressIndicator, returnValue);
			this.CqtRecordStatus = line.ParseForImport<Cqt, string>(version, p => p.CqtRecordStatus, returnValue);
			this.ReserveCqt1106 = line.ParseForImport<Cqt, string>(version, p => p.ReserveCqt1106, returnValue);
			this.ClosingCharacter = line.ParseForImport<Cqt, string>(version, p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Cqt, string>(version, p => p.JobId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Cqt, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.ContainerId.FormatForExport<Cqt, int>(version, p => p.ContainerId));
			sb.Append(this.ThreeDigit5DigitContainerDivision.FormatForExport<Cqt, string>(version, p => p.ThreeDigit5DigitContainerDivision));
			sb.Append(this.MailPieceUnitId.FormatForExport<Cqt, string>(version, p => p.MailPieceUnitId));
			sb.Append(this.Zone.FormatForExport<Cqt, string>(version, p => p.Zone));
			sb.Append(this.DestinationEntry.FormatForExport<Cqt, string>(version, p => p.DestinationEntry));
			sb.Append(this.RateCategory.FormatForExport<Cqt, string>(version, p => p.RateCategory));
			sb.Append(this.BarcodeDiscountOrSurchargeIndicator.FormatForExport<Cqt, string>(version, p => p.BarcodeDiscountOrSurchargeIndicator));
			sb.Append(this.PeriodicalsSubNonSubRequesterIndicator.FormatForExport<Cqt, string>(version, p => p.PeriodicalsSubNonSubRequesterIndicator));
			sb.Append(this.PeriodicalsNotCountyInCounty.FormatForExport<Cqt, string>(version, p => p.PeriodicalsNotCountyInCounty));
			sb.Append(this.NumberOfCopies.FormatForExport<Cqt, int>(version, p => p.NumberOfCopies));
			sb.Append(this.NumberOfPieces.FormatForExport<Cqt, int>(version, p => p.NumberOfPieces));
			sb.Append(this.PeriodicalsCoPalletizationDiscountIndicator.FormatForExport<Cqt, string>(version, p => p.PeriodicalsCoPalletizationDiscountIndicator));
			sb.Append(this.ContainerChargeAllocation.FormatForExport<Cqt, decimal?>(version, p => p.ContainerChargeAllocation));
			sb.Append(this.ServiceLevelIndicator.FormatForExport<Cqt, string>(version, p => p.ServiceLevelIndicator));
			sb.Append(this.SimplifiedAddressIndicator.FormatForExport<Cqt, string>(version, p => p.SimplifiedAddressIndicator));
			sb.Append(this.CqtRecordStatus.FormatForExport<Cqt, string>(version, p => p.CqtRecordStatus));
			sb.Append(this.ReserveCqt1106.FormatForExport<Cqt, string>(version, p => p.ReserveCqt1106));
			sb.Append(this.ClosingCharacter.FormatForExport<Cqt, string>(version, p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}