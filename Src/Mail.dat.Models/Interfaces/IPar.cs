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
	/// Notes technique and reports postage adjustment per container.
	/// </summary>
	public interface IPar : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (PAR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Segment ID (PAR-1002)
		/// </summary>
		string SegmentID { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (PAR-1003)
		/// </summary>
		string MailPieceUnitID { get; set; }

		/// <summary>
		/// Component ID (PAR-1004)
		/// </summary>
		string ComponentID { get; set; }

		/// <summary>
		/// Sequence Number (PAR-1024)
		/// A unique number differentiating this PAR record from any other for this JOB, SEG, MPU and CPT.
		/// </summary>
		int SequenceNumber { get; set; }

		/// <summary>
		/// Date (PAR-1101)
		/// Adjustment Date.
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
		/// </summary>
		string MPAUniqueSequenceGroupingID { get; set; }

		/// <summary>
		/// User Option Field (PAR-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// PAR Record Status (PAR-2000)
		/// </summary>
		string PARRecordStatus { get; set; }

		/// <summary>
		/// Reserve (PAR-1107)
		/// </summary>
		string ReservePAR1107 { get; set; }

		/// <summary>
		/// Closing Character (PAR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}