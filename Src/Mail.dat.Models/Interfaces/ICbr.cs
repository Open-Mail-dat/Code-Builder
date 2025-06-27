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
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Is used to capture the bulk form information that is present on the Certificate of Mailing Forms.
	/// Provides the bulk form information that is present on the Certificate of Mailing Forms.
	/// </summary>
	public interface ICbr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CBR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CBR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		string CertificateOfMailingHeaderId { get; set; }

		/// <summary>
		/// Bulk Record ID (CBR-1003)
		/// Unique ID of the Certificate of Mailing Bulk Record.
		/// </summary>
		string BulkRecordId { get; set; }

		/// <summary>
		/// Number of Identical Pieces (CBR-1101)
		/// Total identical pieces represented by this record.
		/// </summary>
		int NumberOfIdenticalPieces { get; set; }

		/// <summary>
		/// Class of Mail (CBR-1102)
		/// The Postal Class of pieces included in this record.
		/// </summary>
		string ClassOfMail { get; set; }

		/// <summary>
		/// Number of Pieces to the Pound (CBR-1103)
		/// Number of pieces per pound.
		/// </summary>
		decimal NumberOfPiecesToThePound { get; set; }

		/// <summary>
		/// Total Number of Pounds (CBR-1104)
		/// Pounds International = Gross Weight.
		/// </summary>
		decimal TotalNumberOfPounds { get; set; }

		/// <summary>
		/// Fee Paid (CBR-1105)
		/// Fee for Certificate of Bulk Mailing; dollars.
		/// </summary>
		decimal? FeePaid { get; set; }

		/// <summary>
		/// Total Postage Paid for Mailpieces (CBR-1106)
		/// Dollars.
		/// </summary>
		decimal TotalPostagePaidForMailpieces { get; set; }

		/// <summary>
		/// Flex Option A (CBR-1107)
		/// Reserve Option.
		/// </summary>
		string FlexOptionA { get; set; }

		/// <summary>
		/// Flex Option B (CBR-1108)
		/// Reserve Option.
		/// </summary>
		string FlexOptionB { get; set; }

		/// <summary>
		/// Flex Option C (CBR-1109)
		/// Reserve Option.
		/// </summary>
		string FlexOptionC { get; set; }

		/// <summary>
		/// Reserve (CBR-1110)
		/// Reserved for future use.
		/// </summary>
		string ReserveCbr1110 { get; set; }

		/// <summary>
		/// CBR Record Status (CBR-2000)
		/// O, D, I, U.
		/// </summary>
		string CbrRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CBR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}