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
	/// Table showing relationship of MPUs to Components.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "mcr", File = "Mpu / C - Relationship Record", Summary = "Table showing relationship of MPUs to Components.", Description = "Table showing relationship of MPUs to Components.", LineLength = 100, ClosingCharacter = "#")]
	[Table("Mcr", Schema = "Maildat")]
	[PrimaryKey("Id")]
	public partial class Mcr : MaildatEntity
	{
		/// <summary>
		/// Job ID (MCR-1001)
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MCR-1001")]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (MCR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric", References = "SEG-1002")]
		[Column("SegmentID", Order = 3)]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("MCR-1002")]
		public string SegmentID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MCR-1003)
		/// Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1003", FieldName = "Mail Piece Unit ID", Start = 13, Length = 5, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.", Type = "string", Format = "zfillnumeric", References = "MPU-1003")]
		[Column("MailPieceUnitID", Order = 4)]
		[Required]
		[MaildatKey]
		[MaxLength(5)]
		[Comment("MCR-1003")]
		public string MailPieceUnitID { get; set; }

		/// <summary>
		/// Component ID (MCR-1004)
		/// Left justify, must have some value, even if single edition. This ID represents a specific
		/// sub-portion (or the whole, as appropriate) of one Or more Mail Piece Unit Make-ups within the
		/// production of the Specific mailing described by the supplied Mail.dat®  file. The originator of the
		/// Mail.dat®  file must identify any postage Differentiating Components with their own record. However,
		/// if no Postage affecting differentiation exists within the various parts making Up a Mail Piece Unit,
		/// then the originator of the specific Mail.dat® May choose to, and probably should, only identify the
		/// necessary detail And simply clone that which is in the Mail Piece Unit ID field. Therefore, there
		/// will always be at least one Component within any Mail Piece Unit.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1004", FieldName = "Component ID", Start = 18, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "Left justify, must have some value, even if single edition. This ID represents a specific sub-portion (or the whole, as appropriate) of one Or more Mail Piece Unit Make-ups within the production of the Specific mailing described by the supplied Mail.dat®  file. The originator of the Mail.dat®  file must identify any postage Differentiating Components with their own record. However, if no Postage affecting differentiation exists within the various parts making Up a Mail Piece Unit, then the originator of the specific Mail.dat® May choose to, and probably should, only identify the necessary detail And simply clone that which is in the Mail Piece Unit ID field. Therefore, there will always be at least one Component within any Mail Piece Unit.", Type = "string", Format = "zfillnumeric")]
		[Column("ComponentID", Order = 5)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("MCR-1004")]
		public string ComponentID { get; set; }

		/// <summary>
		/// Primary MPA ID (MCR-1102)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1102", FieldName = "Primary MPA ID", Start = 26, Length = 10, Required = true, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[Column("PrimaryMPAID", Order = 6)]
		[Required]
		[MaxLength(10)]
		[Comment("MCR-1102")]
		public string PrimaryMPAID { get; set; }

		/// <summary>
		/// Additional Postage MPA ID (MCR-1103)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1103", FieldName = "Additional Postage MPA ID", Start = 36, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "From MPA - Unique Sequence/Grouping ID.", Type = "string", Format = "leftjustify", References = "MPA-1002")]
		[Column("AdditionalPostageMPAID", Order = 7)]
		[MaxLength(10)]
		[Comment("MCR-1103")]
		public string AdditionalPostageMPAID { get; set; }

		/// <summary>
		/// Host Statement Component ID (MCR-1104)
		/// List Code.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1104", FieldName = "Host Statement Component ID", Start = 46, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "List Code.", Type = "string", Format = "zfillnumeric")]
		[Column("HostStatementComponentID", Order = 8)]
		[MaxLength(8)]
		[Comment("MCR-1104")]
		public string HostStatementComponentID { get; set; }

		/// <summary>
		/// Host Indicator of Ad Computation (MCR-1105)
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1105", FieldName = "Host Indicator of Ad Computation", Start = 54, Length = 1, Required = false, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("HostIndicatorOfAdComputation", Order = 9)]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("MCR-1105")]
		public string HostIndicatorOfAdComputation { get; set; }

		/// <summary>
		/// Postage Adjustment MPA ID (MCR-1106)
		/// This field would be used by anyone (printers and letter shops) Including MLOCR vendors requiring
		/// Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA
		/// within an MPU. Establishes the set of MPU pieces on one Postage Statement.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1106", FieldName = "Postage Adjustment MPA ID", Start = 55, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "This field would be used by anyone (printers and letter shops) Including MLOCR vendors requiring Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one Postage Statement.", Type = "string", Format = "leftjustify")]
		[Column("PostageAdjustmentMPAID", Order = 10)]
		[MaxLength(10)]
		[Comment("MCR-1106")]
		public string PostageAdjustmentMPAID { get; set; }

		/// <summary>
		/// MCR Record Status (MCR-2000)
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-2000", FieldName = "MCR Record Status", Start = 65, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("MCRRecordStatus", Order = 11)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("MCR-2000")]
		public string MCRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (MCR-1101)
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-1101", FieldName = "Reserve", Start = 66, Length = 34, Required = false, Key = false, DataType = "A/N", Type = "string", Format = "leftjustify")]
		[Column("ReserveMCR1101", Order = 12)]
		[MaxLength(34)]
		[Comment("MCR-1101")]
		public string ReserveMCR1101 { get; set; }

		/// <summary>
		/// Closing Character (MCR-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "mcr", FieldCode = "MCR-9999", FieldName = "Closing Character", Start = 100, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 13)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("MCR-9999")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override ILoadError[] OnLoadData(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.FileLineNumber = fileLineNumber;
			this.JobID = line.Parse<Mcr, string>(p => p.JobID, returnValue);
			this.SegmentID = line.Parse<Mcr, string>(p => p.SegmentID, returnValue);
			this.MailPieceUnitID = line.Parse<Mcr, string>(p => p.MailPieceUnitID, returnValue);
			this.ComponentID = line.Parse<Mcr, string>(p => p.ComponentID, returnValue);
			this.PrimaryMPAID = line.Parse<Mcr, string>(p => p.PrimaryMPAID, returnValue);
			this.AdditionalPostageMPAID = line.Parse<Mcr, string>(p => p.AdditionalPostageMPAID, returnValue);
			this.HostStatementComponentID = line.Parse<Mcr, string>(p => p.HostStatementComponentID, returnValue);
			this.HostIndicatorOfAdComputation = line.Parse<Mcr, string>(p => p.HostIndicatorOfAdComputation, returnValue);
			this.PostageAdjustmentMPAID = line.Parse<Mcr, string>(p => p.PostageAdjustmentMPAID, returnValue);
			this.MCRRecordStatus = line.Parse<Mcr, string>(p => p.MCRRecordStatus, returnValue);
			this.ReserveMCR1101 = line.Parse<Mcr, string>(p => p.ReserveMCR1101, returnValue);
			this.ClosingCharacter = line.Parse<Mcr, string>(p => p.ClosingCharacter, returnValue);
			
			return returnValue.ToArray();
		}
	}
}