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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
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
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Segment ID (MCR-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MCR-1003)
		/// Left justify, must have some value, even if single edition.See MPU File's MPU ID definition.
		/// </summary>
		string MailPieceUnitId { get; set; }

		/// <summary>
		/// Component ID (MCR-1004)
		/// Left justify, must have some value, even if single edition. This ID represents a specific
		/// sub-portion (or the whole, as appropriate) of one or more Mail Piece Unit Make-ups within the
		/// production of the specific mailing described by the supplied Mail.dat®  file. The originator of the
		/// Mail.dat®  file must identify any postage differentiating Components with their own record. However,
		/// if no postage affecting differentiation exists within the various parts making up a Mail Piece Unit,
		/// then the originator of the specific Mail.dat® may choose to, and probably should, only identify the
		/// necessary detail and simply clone that which is in the Mail Piece Unit ID field. Therefore, there
		/// will always be at least one Component within any Mail Piece Unit.
		/// </summary>
		string ComponentId { get; set; }

		/// <summary>
		/// Primary MPA ID (MCR-1102)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		string PrimaryMpaId { get; set; }

		/// <summary>
		/// Additional Postage MPA ID (MCR-1103)
		/// From MPA - Unique Sequence/Grouping ID.
		/// </summary>
		string AdditionalPostageMpaId { get; set; }

		/// <summary>
		/// Host Statement Component ID (MCR-1104)
		/// List Code.
		/// </summary>
		string HostStatementComponentId { get; set; }

		/// <summary>
		/// Host Indicator of Ad Computation (MCR-1105)
		/// </summary>
		string HostIndicatorOfAdComputation { get; set; }

		/// <summary>
		/// Postage Adjustment MPA ID (MCR-1106)
		/// This field would be used by anyone (printers and letter shops) including MLOCR vendors requiring
		/// Postage Adjustments to be paid from a separate permit. Unique identifier for the respective MPA
		/// within an MPU. Establishes the set of MPU pieces on one Postage Statement.
		/// </summary>
		string PostageAdjustmentMpaId { get; set; }

		/// <summary>
		/// MCR Record Status (MCR-2000)
		/// O, D, I, U.
		/// </summary>
		string McrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (MCR-1101)
		/// Reserved for future use.
		/// </summary>
		string ReserveMcr1101 { get; set; }

		/// <summary>
		/// Closing Character (MCR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}