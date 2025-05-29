// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 29th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 

namespace Mail.dat
{
	/// <summary>
	/// Provides the bulk form information that is present on the Certificate of Mailing Forms.
	/// </summary>
	public interface ICbr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CBR-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Certificate Of Mailing Header ID (CBR-1002)
		/// Unique ID of the Certificate of Mailing Header Record.
		/// </summary>
		string CertificateOfMailingHeaderID { get; set; }

		/// <summary>
		/// Bulk Record ID (CBR-1003)
		/// Unique ID of the Certificate of Mailing Bulk Record.
		/// </summary>
		string BulkRecordID { get; set; }

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
		/// </summary>
		string ReserveCBR1110 { get; set; }

		/// <summary>
		/// CBR Record Status (CBR-2000)
		/// </summary>
		string CBRRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (CBR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}