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
	/// Characteristics of a component. Allows mailers to identify surcharges, incentive and specific
	/// contents that are part of the mail piece.
	/// </summary>
	[MaildatFile(Version = "23-1", Revision = "0.5", Extension = "ccr", File = "Component Characteristics Record", Summary = "Characteristics of a component.", Description = "Characteristics of a component. Allows mailers to identify surcharges, incentive and specific contents that are part of the mail piece.", LineLength = 21, ClosingCharacter = "#")]
	[MaildatFile(Version = "24-1", Revision = "1.5", Extension = "ccr", File = "Component Characteristics Record", Summary = "Characteristics of a component.", Description = "Characteristics of a component. Allows mailers to identify surcharges, incentive and specific contents that are part of the mail piece.", LineLength = 21, ClosingCharacter = "#")]
	[MaildatFile(Version = "25-1", Revision = "0.4", Extension = "ccr", File = "Component Characteristics Record", Summary = "Characteristics of a component.", Description = "Characteristics of a component. Allows mailers to identify surcharges, incentive and specific contents that are part of the mail piece.", LineLength = 52, ClosingCharacter = "#")]
	[MaildatImport(Order = 7, Version = "23-1")]
	[MaildatImport(Order = 7, Version = "24-1")]
	[MaildatImport(Order = 7, Version = "25-1")]
	[Table("Ccr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class Ccr : MaildatEntity, ICcr 
	{
		/// <summary>
		/// Job ID (CCR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "(Zero fill prior to numeric, if numeric only). See Header File’s Job Id.", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobId", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CCR-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string JobId { get; set; }

		/// <summary>
		/// Component ID (CCR-1004)
		/// Unique Record ID - foreign Key to CPT.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique Record ID - foreign Key to CPT.", Type = "string", Format = "zfillnumeric", References = "CPT-1004")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique Record ID - foreign Key to CPT.", Type = "string", Format = "zfillnumeric", References = "CPT-1004")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1004", FieldName = "Component ID", Start = 9, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Unique Record ID - foreign Key to CPT.", Type = "string", Format = "zfillnumeric", References = "CPT-1004")]
		[Column("ComponentId", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CCR-1004")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ComponentId { get; set; }

		/// <summary>
		/// Characteristic Type (CCR-1005)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-1005", FieldName = "Characteristic Type", Start = 17, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-1005", FieldName = "Characteristic Type", Start = 17, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1005", FieldName = "Characteristic Type", Start = 17, Length = 1, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CharacteristicType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(1)]
		[AllowedValues("A", "C", "F", "I")]
		[Comment("CCR-1005")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CharacteristicTypes))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CharacteristicType { get; set; }

		/// <summary>
		/// Characteristic (CCR-1002)
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-1002", FieldName = "Characteristic", Start = 18, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-1002", FieldName = "Characteristic", Start = 18, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1002", FieldName = "Characteristic", Start = 18, Length = 2, Required = true, Key = true, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("Characteristic", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(2)]
		[AllowedValues("0X", "1X", "2X", "3X", "4X", "5X", "6X", "7X", "8X", "9X", "AD", "CB", "CC", "CO", "CP", "CR", "CT", "DC", "EB", "EM", "EN", "FA", "FG", "GS", "HD", "IT", "IV", "ME", "MG", "MI", "MM", "MT", "NF", "NP", "OS", "P1", "P2", "P3", "P4", "P5", "PI", "PM", "PP", "PS", "RE", "RG", "RR", "RT", "SB", "SS", "ST", "VP", "VV")]
		[Comment("CCR-1002")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(Characteristics))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string Characteristic { get; set; }

		/// <summary>
		/// CCR Record Status (CCR-2000)
		/// O, D, I, U.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-2000", FieldName = "CCR Record Status", Start = 20, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-2000", FieldName = "CCR Record Status", Start = 20, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-2000", FieldName = "CCR Record Status", Start = 51, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "O, D, I, U.", Type = "enum", Format = "leftjustify")]
		[Column("CcrRecordStatus", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CCR-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		[MaildatValues(typeof(CcrRecordStatuses))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string CcrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CCR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Version = "23-1", Extension = "ccr", FieldCode = "CCR-9999", FieldName = "Closing Character", Start = 21, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "24-1", Extension = "ccr", FieldCode = "CCR-9999", FieldName = "Closing Character", Start = 21, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-9999", FieldName = "Closing Character", Start = 52, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 7, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CCR-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		[MaildatVersions("23-1", "24-1", "25-1")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Pre-Denominated Maximum Credit Amount (CCR-1101)
		/// Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the
		/// postage amount. The postage amount representing the pieces associated with the component record.
		/// Should be used in conjunction with the CCR for Credit Redemption. If the field is blank or zero
		/// filled, do not apply any limit to the credit amount used. Note: multiple components may be tied to
		/// one/same Permit in MPA record Note: if the need is to entirely remove the Credit Redemption, remove
		/// the CCR record claiming the Credit Redemption or populate the field with the minimum value
		/// (00000000001), as a zero filled will not limit the credit amount used.
		/// </summary>
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1101", FieldName = "Pre-Denominated Maximum Credit Amount", Start = 20, Length = 11, Required = false, Key = false, DataType = "N", Description = "Dollars/cents, rounded (decimal implied) Maximum Credit Redemption Amount to be applied towards the postage amount. The postage amount representing the pieces associated with the component record. Should be used in conjunction with the CCR for Credit Redemption. If the field is blank or zero filled, do not apply any limit to the credit amount used. Note: multiple components may be tied to one/same Permit in MPA record Note: if the need is to entirely remove the Credit Redemption, remove the CCR record claiming the Credit Redemption or populate the field with the minimum value (00000000001), as a zero filled will not limit the credit amount used.", Type = "decimal", Format = "zfill", Precision = 3)]
		[Column("PreDenominatedMaximumCreditAmount", Order = 8, TypeName = "NUMERIC")]
		[Precision(3)]
		[Comment("CCR-1101")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		[MaildatVersions("25-1")]
		public decimal? PreDenominatedMaximumCreditAmount { get; set; }

		/// <summary>
		/// Reserve (CCR-1102)
		/// Reserved for future use.
		/// </summary>
		[MaildatField(Version = "25-1", Extension = "ccr", FieldCode = "CCR-1102", FieldName = "Reserve", Start = 31, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Reserved for future use.", Type = "string", Format = "leftjustify")]
		[Column("ReserveCcr1102", Order = 9, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CCR-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		[MaildatVersions("25-1")]
		public string ReserveCcr1102 { get; set; }

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(string version, int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobId = line.ParseForImport<Ccr, string>(version, p => p.JobId, returnValue);
			this.ComponentId = line.ParseForImport<Ccr, string>(version, p => p.ComponentId, returnValue);
			this.CharacteristicType = line.ParseForImport<Ccr, string>(version, p => p.CharacteristicType, returnValue);
			this.Characteristic = line.ParseForImport<Ccr, string>(version, p => p.Characteristic, returnValue);
			this.CcrRecordStatus = line.ParseForImport<Ccr, string>(version, p => p.CcrRecordStatus, returnValue);
			this.ClosingCharacter = line.ParseForImport<Ccr, string>(version, p => p.ClosingCharacter, returnValue);
			this.PreDenominatedMaximumCreditAmount = line.ParseForImport<Ccr, decimal?>(version, p => p.PreDenominatedMaximumCreditAmount, returnValue);
			this.ReserveCcr1102 = line.ParseForImport<Ccr, string>(version, p => p.ReserveCcr1102, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync(string version)
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobId.FormatForExport<Ccr, string>(version, p => p.JobId));
			sb.Append(this.ComponentId.FormatForExport<Ccr, string>(version, p => p.ComponentId));
			sb.Append(this.CharacteristicType.FormatForExport<Ccr, string>(version, p => p.CharacteristicType));
			sb.Append(this.Characteristic.FormatForExport<Ccr, string>(version, p => p.Characteristic));
			sb.Append(this.CcrRecordStatus.FormatForExport<Ccr, string>(version, p => p.CcrRecordStatus));
			sb.Append(this.ClosingCharacter.FormatForExport<Ccr, string>(version, p => p.ClosingCharacter));
			sb.Append(this.PreDenominatedMaximumCreditAmount.FormatForExport<Ccr, decimal?>(version, p => p.PreDenominatedMaximumCreditAmount));
			sb.Append(this.ReserveCcr1102.FormatForExport<Ccr, string>(version, p => p.ReserveCcr1102));
			
			return Task.FromResult(sb.ToString());
		}
	}
}