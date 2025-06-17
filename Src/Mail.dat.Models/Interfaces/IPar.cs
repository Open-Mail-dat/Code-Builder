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
	/// Technique and amount for adjustment per container. Notes technique and reports postage adjustment
	/// per container.
	/// </summary>
	public interface IPar : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (PAR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Segment ID (PAR-1002)
		/// </summary>
		string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (PAR-1003)
		/// </summary>
		string MailPieceUnitId { get; set; }

		/// <summary>
		/// Component ID (PAR-1004)
		/// </summary>
		string ComponentId { get; set; }

		/// <summary>
		/// Sequence Number (PAR-1024)
		/// A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.
		/// </summary>
		int SequenceNumber { get; set; }

		/// <summary>
		/// Date (PAR-1101)
		/// Adjustment Date (cannot be all zeros).
		/// </summary>
		DateOnly Date { get; set; }

		/// <summary>
		/// Adjustment Type (PAR-1102)
		/// </summary>
		string AdjustmentType { get; set; }

		/// <summary>
		/// Adjustment Amount (PAR-1103)
		/// Dollars.
		/// </summary>
		decimal AdjustmentAmount { get; set; }

		/// <summary>
		/// Credit/Debit Indicator (PAR-1104)
		/// </summary>
		string CreditDebitIndicator { get; set; }

		/// <summary>
		/// Total Pieces Affected (PAR-1106)
		/// (0 [zero] is a permitted value).
		/// </summary>
		int? TotalPiecesAffected { get; set; }

		/// <summary>
		/// User Comments (PAR-1105)
		/// Free form field for user notes.
		/// </summary>
		string UserComments { get; set; }

		/// <summary>
		/// Adjustment Status (PAR-1108)
		/// </summary>
		string AdjustmentStatus { get; set; }

		/// <summary>
		/// MPA - Unique Sequence/Grouping ID (PAR-1109)
		/// Unique identifier for the respective MPA within an MPU. Establishes the set of MPU pieces on one
		/// Postage Statement.
		/// </summary>
		string MpaUniqueSequenceGroupingId { get; set; }

		/// <summary>
		/// User Option Field (PAR-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// PAR Record Status (PAR-2000)
		/// O, D, I, U.
		/// </summary>
		string ParRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PAR-1107)
		/// Reserved for future use.
		/// </summary>
		string ReservePar1107 { get; set; }

		/// <summary>
		/// Closing Character (PAR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}