// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 27th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 

namespace Mail.dat
{
	/// <summary>
	/// Table showing relationship of MPUs to Components.
	/// </summary>
	public interface IMcr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (MCR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Segment ID (MCR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		string SegmentID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MCR-1003)
		/// Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.
		/// </summary>
		string MailPieceUnitID { get; set; }

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
		string ComponentID { get; set; }

		/// <summary>
		/// Primary MPA ID (MCR-1102)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		string PrimaryMPAID { get; set; }

		/// <summary>
		/// Additional Postage MPA ID (MCR-1103)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		string AdditionalPostageMPAID { get; set; }

		/// <summary>
		/// Host Statement Component ID (MCR-1104)
		/// List Code.
		/// </summary>
		string HostStatementComponentID { get; set; }

		/// <summary>
		/// Host Indicator of Ad Computation (MCR-1105)
		/// </summary>
		string HostIndicatorOfAdComputation { get; set; }

		/// <summary>
		/// Postage Adjustment MPA ID (MCR-1106)
		/// This field would be used by anyone (printers and letter shops) Including MLOCR vendors requiring
		/// Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA
		/// within an MPU. Establishes the set of MPU pieces on one Postage Statement.
		/// </summary>
		string PostageAdjustmentMPAID { get; set; }

		/// <summary>
		/// MCR Record Status (MCR-2000)
		/// </summary>
		string MCRRecordStatus { get; set; }

		/// <summary>
		/// Reserve (MCR-1101)
		/// </summary>
		string ReserveMCR1101 { get; set; }

		/// <summary>
		/// Closing Character (MCR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}