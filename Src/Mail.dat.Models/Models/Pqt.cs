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
	/// Quantity and destination per package.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.3", Extension = "pqt", File = "Package Quantity Record", Summary = "Quantity and destination per package.", Description = "Quantity and destination per package.", LineLength = 70, ClosingCharacter = "#")]
	[Table("Pqt", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 10)]
	public partial class Pqt : MaildatEntity, IPqt 
	{
		/// <summary>
		/// Job ID (PQT-1001)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("PQT-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// CQT Database ID (PQT-1034)
		/// See Container Quantity File's CQT Database ID definition.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1034", FieldName = "CQT Database ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "N", Description = "See Container Quantity File's CQT Database ID definition.", Type = "integer", Format = "zfill", References = "CQT-1034")]
		[Column("CQTDatabaseID", Order = 3, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("PQT-1034")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int CQTDatabaseID { get; set; }

		/// <summary>
		/// Package ID (PQT-1012)
		/// The unique code for this package within this container.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1012", FieldName = "Package ID", Start = 17, Length = 6, Required = true, Key = true, DataType = "A/N", Description = "The unique code for this package within this container.", Type = "string", Format = "zfillnumeric")]
		[Column("PackageID", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(6)]
		[Comment("PQT-1012")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageID { get; set; }

		/// <summary>
		/// Package ZIP Code (PQT-1013)
		/// The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left
		/// Justify. For a Package Service parcel presort the Parcel Piece is the package; therefore, populate
		/// with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP
		/// or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if
		/// for U.S. Domestic International: (ex: FRCDGA = FR CDG A).
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1013", FieldName = "Package ZIP Code", Start = 23, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit, 3-digit, 6-character or 6-alpha destination of the package defined in the record. Left Justify. For a Package Service parcel presort the Parcel Piece is the package; therefore, populate with the 5-digit of the parcel. US = 99999_, or 888___ CAN = A1A9Z9 Default for packages with no ZIP or Postal Code: CANADA = if Canadian AOFRGN = if all other foreign MEXICO = if for Mexico USA = if for U.S. Domestic International: (ex: FRCDGA = FR CDG A).", Type = "string", Format = "leftjustify")]
		[Column("PackageZIPCode", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("PQT-1013")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageZIPCode { get; set; }

		/// <summary>
		/// Package Carrier Route (PQT-1101)
		/// Example: C999, R999, B999, H999 as applicable.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1101", FieldName = "Package Carrier Route", Start = 29, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "Example: C999, R999, B999, H999 as applicable.", Type = "string", Format = "leftjustify")]
		[Column("PackageCarrierRoute", Order = 6, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("PQT-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PackageCarrierRoute { get; set; }

		/// <summary>
		/// Package Level (PQT-1102)
		/// See Below.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1102", FieldName = "Package Level", Start = 33, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Below.", Type = "enum", Format = "leftjustify")]
		[Column("PackageLevel", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("9", "A", "B", "C", "D", "F", "H", "I", "K", "L", "M", "R", "S", "T", "U", "V")]
		[Comment("PQT-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PackageLevel { get; set; }

		/// <summary>
		/// Number of Copies (PQT-1103)
		/// Number of copies within the specific package.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1103", FieldName = "Number of Copies", Start = 35, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of copies within the specific package.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 8, TypeName = "INTEGER")]
		[Required]
		[Comment("PQT-1103")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (PQT-1104)
		/// Number of pieces within this specific package. Note: First record within Firm Package or Multi-Piece
		/// Parcel has Piece Count = 1 subsequent records within same Package the piece count = 0 (see Scenarios
		/// for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than
		/// copies in some Periodical or 4C mailings).
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1104", FieldName = "Number of Pieces", Start = 40, Length = 5, Required = true, Key = false, DataType = "N", Description = "Number of pieces within this specific package. Note: First record within Firm Package or Multi-Piece Parcel has Piece Count = 1 subsequent records within same Package the piece count = 0 (see Scenarios for Firm Packages and Standard Mail combined in Fourth Class bundles) (Pieces may be less than copies in some Periodical or 4C mailings).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 9, TypeName = "INTEGER")]
		[Required]
		[Comment("PQT-1104")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Bundle Charge Allocation (PQT-1113)
		/// Proportion, rounded This field is to be used for denoting the proportion of cost of its bundle that
		/// it's carrying.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1113", FieldName = "Bundle Charge Allocation", Start = 45, Length = 7, Required = false, Key = false, DataType = "N", Description = "Proportion, rounded This field is to be used for denoting the proportion of cost of its bundle that it's carrying.", Type = "decimal", Format = "zfill", Precision = 6)]
		[Column("BundleChargeAllocation", Order = 10, TypeName = "NUMERIC")]
		[Precision(6)]
		[Comment("PQT-1113")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? BundleChargeAllocation { get; set; }

		/// <summary>
		/// Combo-Pack ID (PQT-1114)
		/// The unique code for this combo-pack within this package.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1114", FieldName = "Combo-Pack ID", Start = 52, Length = 6, Required = false, Key = false, DataType = "A/N", Description = "The unique code for this combo-pack within this package.", Type = "string", Format = "zfillnumeric")]
		[Column("ComboPackID", Order = 11, TypeName = "TEXT")]
		[MaxLength(6)]
		[Comment("PQT-1114")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ComboPackID { get; set; }

		/// <summary>
		/// PQT Record Status (PQT-2000)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-2000", FieldName = "PQT Record Status", Start = 58, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PQTRecordStatus", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("PQT-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PQTRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PQT-1105)
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-1105", FieldName = "Reserve", Start = 59, Length = 11, Required = false, Key = false, DataType = "A/N", Description = "", Type = "reserve", Format = "leftjustify")]
		[Column("ReservePQT1105", Order = 13, TypeName = "TEXT")]
		[MaxLength(11)]
		[Comment("PQT-1105")]
		[TypeConverter(typeof(MaildatReserveConverter))]
		public string ReservePQT1105 { get; set; }

		/// <summary>
		/// Closing Character (PQT-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "pqt", FieldCode = "PQT-9999", FieldName = "Closing Character", Start = 70, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 14, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("PQT-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Pqt, string>(p => p.JobID, returnValue);
			this.CQTDatabaseID = line.ParseForImport<Pqt, int>(p => p.CQTDatabaseID, returnValue);
			this.PackageID = line.ParseForImport<Pqt, string>(p => p.PackageID, returnValue);
			this.PackageZIPCode = line.ParseForImport<Pqt, string>(p => p.PackageZIPCode, returnValue);
			this.PackageCarrierRoute = line.ParseForImport<Pqt, string>(p => p.PackageCarrierRoute, returnValue);
			this.PackageLevel = line.ParseForImport<Pqt, string>(p => p.PackageLevel, returnValue);
			this.NumberOfCopies = line.ParseForImport<Pqt, int>(p => p.NumberOfCopies, returnValue);
			this.NumberOfPieces = line.ParseForImport<Pqt, int>(p => p.NumberOfPieces, returnValue);
			this.BundleChargeAllocation = line.ParseForImport<Pqt, decimal?>(p => p.BundleChargeAllocation, returnValue);
			this.ComboPackID = line.ParseForImport<Pqt, string>(p => p.ComboPackID, returnValue);
			this.PQTRecordStatus = line.ParseForImport<Pqt, string>(p => p.PQTRecordStatus, returnValue);
			this.ReservePQT1105 = line.ParseForImport<Pqt, string>(p => p.ReservePQT1105, returnValue);
			this.ClosingCharacter = line.ParseForImport<Pqt, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Pqt, string>(p => p.JobID));
			sb.Append(this.CQTDatabaseID.FormatForExport<Pqt, int>(p => p.CQTDatabaseID));
			sb.Append(this.PackageID.FormatForExport<Pqt, string>(p => p.PackageID));
			sb.Append(this.PackageZIPCode.FormatForExport<Pqt, string>(p => p.PackageZIPCode));
			sb.Append(this.PackageCarrierRoute.FormatForExport<Pqt, string>(p => p.PackageCarrierRoute));
			sb.Append(this.PackageLevel.FormatForExport<Pqt, string>(p => p.PackageLevel));
			sb.Append(this.NumberOfCopies.FormatForExport<Pqt, int>(p => p.NumberOfCopies));
			sb.Append(this.NumberOfPieces.FormatForExport<Pqt, int>(p => p.NumberOfPieces));
			sb.Append(this.BundleChargeAllocation.FormatForExport<Pqt, decimal?>(p => p.BundleChargeAllocation));
			sb.Append(this.ComboPackID.FormatForExport<Pqt, string>(p => p.ComboPackID));
			sb.Append(this.PQTRecordStatus.FormatForExport<Pqt, string>(p => p.PQTRecordStatus));
			sb.Append(this.ReservePQT1105.FormatForExport<Pqt, string>(p => p.ReservePQT1105));
			sb.Append(this.ClosingCharacter.FormatForExport<Pqt, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}