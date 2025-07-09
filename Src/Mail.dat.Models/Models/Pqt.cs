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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
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
	/// Quantity and destination per package.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "pqt", File = "Package Quantity Record", Summary = "Quantity and destination per package.", Description = "Quantity and destination per package.", LineLength = 69, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "pqt", File = "Package Quantity Record", Summary = "Quantity and destination per package.", Description = "Quantity and destination per package.", LineLength = 70, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "pqt", File = "Package Quantity Record", Summary = "Quantity and destination per package.", Description = "Quantity and destination per package.", LineLength = 70, ClosingCharacter = "#")]
	[MaildatImport(Order = 10, Version = "23-1")]
	[MaildatImport(Order = 10, Version = "24-1")]
	[MaildatImport(Order = 10, Version = "25-1")]
	[Table("Pqt", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Pqt : MaildatEntity, IPqt 
	{
		/// <summary>
		/// Job ID (PQT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PQT-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// CQT Database ID (PQT-1034)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CqtDatabaseId", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PQT-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int CqtDatabaseId { get; set; }

		/// <summary>
		/// Package ID (PQT-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "Unique identifier for the package within the container.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "Unique identifier for the package within the container.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric")]
		[Column("PackageId", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("PQT-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageId { get; set; }

		/// <summary>
		/// Package ZIP Code (PQT-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. For a Package Service parcel presort the Parcel Piece is the package; therefore, populate
		/// with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP
		/// or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if
		/// for U.S. Domestic International: (ex: FRCDGA = FR CDG A).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1013", FieldName = "Package ZIP Code", Start = 23, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package Defined in the record. Left Justify. For a Package Service parcel presort the Parcel Piece is the package; Therefore, populate with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if for U.S. Domestic International: (ex: FRCDGA = FR CDG A).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1013", FieldName = "Package ZIP Code", Start = 23, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package Defined in the record. Left Justify. For a Package Service parcel presort the Parcel Piece is the package; Therefore, populate with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if for U.S. Domestic International: (ex: FRCDGA = FR CDG A).", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1013", FieldName = "Package ZIP Code", Start = 23, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left Justify. For a Package Service parcel presort the Parcel Piece is the package; therefore, populate with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if for U.S. Domestic International: (ex: FRCDGA = FR CDG A).", Type = "string", Format = "leftjustify")]
		[Column("PackageZipCode", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PQT-1013")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageZipCode { get; set; }

		/// <summary>
		/// Package Carrier Route (PQT-1101)
		/// Example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1101", FieldName = "Package Carrier Route", Start = 29, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1101", FieldName = "Package Carrier Route", Start = 29, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1101", FieldName = "Package Carrier Route", Start = 29, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCarrierRoute", Order = 6, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PQT-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageCarrierRoute { get; set; }

		/// <summary>
		/// Package Level (PQT-1102)
		/// See Below.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1102", FieldName = "Package Level", Start = 33, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Below.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1102", FieldName = "Package Level", Start = 33, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Below.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1102", FieldName = "Package Level", Start = 33, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Below.", Type = "enum", Format = "leftjustify")]
		[Column("PackageLevel", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("9", "A", "B", "C", "D", "F", "H", "I", "K", "L", "M", "R", "S", "T", "U", "V")]
		[Comment("PQT-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PackageLevels))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PackageLevel { get; set; }

		/// <summary>
		/// Number of Copies (PQT-1103)
		/// Number of copies within the specific package.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1103", FieldName = "Number of Copies", Start = 35, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of copies within the specific package.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1103", FieldName = "Number of Copies", Start = 36, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of copies within the specific package.", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1103", FieldName = "Number of Copies", Start = 35, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of copies within the specific package.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 8, TypeName = "INTEGER")]
		[Required]
		[Comment("PQT-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (PQT-1104)
		/// Number of pieces within this specific package. Note: First record within Firm Package or Multi-Piece
		/// Parcel has Piece Count = 1 subsequent records within same Package the piece count = 0 (see Scenarios
		/// for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than
		/// copies in some Periodical or 4C mailings).
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1104", FieldName = "Number of Pieces", Start = 40, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of pieces within this specific package. Note: First record Within Firm Package or Multi-Piece Parcel has Piece Count = 1 Subsequent records within same Package the piece count = 0 (see Scenarios for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than copies in some Periodical or 4C mailings).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1104", FieldName = "Number of Pieces", Start = 41, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of pieces within this specific package. Note: First record Within Firm Package or Multi-Piece Parcel has Piece Count = 1 Subsequent records within same Package the piece count = 0 (see Scenarios for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than copies in some Periodical or 4C mailings).", Type = "integer", Format = "zfill")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1104", FieldName = "Number of Pieces", Start = 40, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of pieces within this specific package. Note: First record within Firm Package or Multi-Piece Parcel has Piece Count = 1 subsequent records within same Package the piece count = 0 (see Scenarios for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than copies in some Periodical or 4C mailings).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 9, TypeName = "INTEGER")]
		[Required]
		[Comment("PQT-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Bundle Charge Allocation (PQT-1113)
		/// 9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the
		/// proportion of cost of its bundle that it's carrying.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1113", FieldName = "Bundle Charge Allocation", Start = 45, Length = 7, Required = false, Key = false, DataType = "N", Description = "9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the proportion of cost of its bundle that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1113", FieldName = "Bundle Charge Allocation", Start = 46, Length = 7, Required = false, Key = false, DataType = "N", Description = "9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the proportion of cost of its bundle that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1113", FieldName = "Bundle Charge Allocation", Start = 45, Length = 7, Required = false, Key = false, DataType = "N", Description = "9v999999 - proportion, rounded, (decimal point implied) This field is to be used for denoting the proportion of cost of its bundle that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("BundleChargeAllocation", Order = 10, TypeName = "NUMERIC")]
		[Precision(6)]
		[Comment("PQT-1113")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public decimal? BundleChargeAllocation { get; set; }

		/// <summary>
		/// Combo-Pack ID (PQT-1114)
		/// The unique code for this combo-pack within this package.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1114", FieldName = "Combo-Pack ID", Start = 52, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "The unique code for this combo-pack within this package.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1114", FieldName = "Combo-Pack ID", Start = 53, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "The unique code for this combo-pack within this package.", Type = "string", Format = "zfillnumeric")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1114", FieldName = "Combo-Pack ID", Start = 52, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "The unique code for this combo-pack within this package.", Type = "string", Format = "zfillnumeric")]
		[Column("ComboPackId", Order = 11, TypeName = "TEXT")]
		[MaxLength(6)]
		[Comment("PQT-1114")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComboPackId { get; set; }

		/// <summary>
		/// PQT Record Status (PQT-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-2000", FieldName = "PQT Record Status", Start = 58, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-2000", FieldName = "PQT Record Status", Start = 59, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-2000", FieldName = "PQT Record Status", Start = 58, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("PqtRecordStatus", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PQT-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PqtRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string PqtRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PQT-1105)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-1105", FieldName = "Reserve", Start = 59, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1105", FieldName = "Reserve", Start = 60, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-1105", FieldName = "Reserve", Start = 59, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReservePqt1105", Order = 13, TypeName = "TEXT")]
		[MaxLength(11)]
		[Comment("PQT-1105")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ReservePqt1105 { get; set; }

		/// <summary>
		/// Closing Character (PQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "pqt", FieldCode = "PQT-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "pqt", FieldCode = "PQT-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PQT-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Package Preparation Type (PQT-1115)
		/// Populate in the scenario when CSM Tray Preparation Type is set to M = Mixed).
		/// </summary>
		[MaildatField(Version = "24-1", Extension = "pqt", FieldCode = "PQT-1115", FieldName = "Package Preparation Type", Start = 35, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate in the scenario when CSM Tray Preparation Type is set to M = Mixed).", Type = "enum", Format = "leftjustify")]
		[Column("PackagePreparationType", Order = 15, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "L", "P")]
		[Comment("PQT-1115")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(PackagePreparationTypes))]
		[MaildatVersions("24-1")]
		public string PackagePreparationType { get; set; }

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Pqt, string>(version, p => p.JobId, returnValue);
			this.CqtDatabaseId = line.ParseForImport<Pqt, int>(version, p => p.CqtDatabaseId, returnValue);
			this.PackageId = line.ParseForImport<Pqt, string>(version, p => p.PackageId, returnValue);
			this.PackageZipCode = line.ParseForImport<Pqt, string>(version, p => p.PackageZipCode, returnValue);
			this.PackageCarrierRoute = line.ParseForImport<Pqt, string>(version, p => p.PackageCarrierRoute, returnValue);
			this.PackageLevel = line.ParseForImport<Pqt, string>(version, p => p.PackageLevel, returnValue);
			this.NumberOfCopies = line.ParseForImport<Pqt, int>(version, p => p.NumberOfCopies, returnValue);
			this.NumberOfPieces = line.ParseForImport<Pqt, int>(version, p => p.NumberOfPieces, returnValue);
			this.BundleChargeAllocation = line.ParseForImport<Pqt, decimal?>(version, p => p.BundleChargeAllocation, returnValue);
			this.ComboPackId = line.ParseForImport<Pqt, string>(version, p => p.ComboPackId, returnValue);
			this.PqtRecordStatus = line.ParseForImport<Pqt, string>(version, p => p.PqtRecordStatus, returnValue);
			this.ReservePqt1105 = line.ParseForImport<Pqt, string>(version, p => p.ReservePqt1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pqt, string>(version, p => p.ClosingCharacter, returnValue);
			this.PackagePreparationType = line.ParseForImport<Pqt, string>(version, p => p.PackagePreparationType, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Pqt, string>(version, p => p.JobId));
			sb.Append(this.CqtDatabaseId.FormatForExport<Pqt, int>(version, p => p.CqtDatabaseId));
			sb.Append(this.PackageId.FormatForExport<Pqt, string>(version, p => p.PackageId));
			sb.Append(this.PackageZipCode.FormatForExport<Pqt, string>(version, p => p.PackageZipCode));
			sb.Append(this.PackageCarrierRoute.FormatForExport<Pqt, string>(version, p => p.PackageCarrierRoute));
			sb.Append(this.PackageLevel.FormatForExport<Pqt, string>(version, p => p.PackageLevel));
			sb.Append(this.NumberOfCopies.FormatForExport<Pqt, int>(version, p => p.NumberOfCopies));
			sb.Append(this.NumberOfPieces.FormatForExport<Pqt, int>(version, p => p.NumberOfPieces));
			sb.Append(this.BundleChargeAllocation.FormatForExport<Pqt, decimal?>(version, p => p.BundleChargeAllocation));
			sb.Append(this.ComboPackId.FormatForExport<Pqt, string>(version, p => p.ComboPackId));
			sb.Append(this.PqtRecordStatus.FormatForExport<Pqt, string>(version, p => p.PqtRecordStatus));
			sb.Append(this.ReservePqt1105.FormatForExport<Pqt, string>(version, p => p.ReservePqt1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Pqt, string>(version, p => p.ClosingCharacter));
			sb.Append(this.PackagePreparationType.FormatForExport<Pqt, string>(version, p => p.PackagePreparationType));
			
			return Task.FromResult(sb.ToString());
		}
	}
}