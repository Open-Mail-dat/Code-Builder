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
// This code was auto-generated on June 15th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// A description of the applicable component.
	/// </summary>
	public interface ICpt : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CPT-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Component ID (CPT-1004)
		/// See MPU/C Component ID definition.
		/// </summary>
		string ComponentId { get; set; }

		/// <summary>
		/// Component Description (CPT-1101)
		/// This is a unique name or code for each specific sub- or whole-portion of the mail piece. This field,
		/// if used, can carry an absolute reference to the Component in question while the Component ID is
		/// practical shorthand for reference to the Component's role within the mailing facilities postage
		/// analysis. Left justify. If used, must have some value, even if single edition.
		/// </summary>
		string ComponentDescription { get; set; }

		/// <summary>
		/// Component - Weight (CPT-1102)
		/// 99v9999; pounds, rounded (decimal point implied).
		/// </summary>
		decimal ComponentWeight { get; set; }

		/// <summary>
		/// Component - Weight: Source (CPT-1103)
		/// Source of Piece Weight.
		/// </summary>
		string ComponentWeightSource { get; set; }

		/// <summary>
		/// Component - Weight: Status (CPT-1104)
		/// Status of weight data.
		/// </summary>
		string ComponentWeightStatus { get; set; }

		/// <summary>
		/// Component - Length (CPT-1105)
		/// Length of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentLength { get; set; }

		/// <summary>
		/// Component - Width (CPT-1106)
		/// Width of a copy; inches, rounded 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentWidth { get; set; }

		/// <summary>
		/// Component - Thickness (CPT-1107)
		/// Thickness of a copy; inches, rounded 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentThickness { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage (CPT-1108)
		/// Ad percentage of a copy, rounded Example (if there is a two page Periodical supplement having 50% Ad
		/// and the Periodical is 48 pages having 40% Ad, then in the mail.dat file the ad percent of the
		/// supplement is (2/50)x.5 = 2.0% and the ad percent of the Periodical is (48/50)x.4 =38.40%. The sum
		/// is 40.40% Field is necessary for Periodicals Enclosures.
		/// </summary>
		decimal? ComponentPeriodicalAdPercentage { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage: Status (CPT-1109)
		/// Status of % data.
		/// </summary>
		string ComponentPeriodicalAdPercentageStatus { get; set; }

		/// <summary>
		/// Component - Class (CPT-1110)
		/// The Postal Class of this Mail Piece Unit within Mail.dat.
		/// </summary>
		string ComponentClass { get; set; }

		/// <summary>
		/// Component - Rate Type (CPT-1111)
		/// </summary>
		string ComponentRateType { get; set; }

		/// <summary>
		/// Component -Processing Category (CPT-1112)
		/// See MPU Processing Category for details.
		/// </summary>
		string ComponentProcessingCategory { get; set; }

		/// <summary>
		/// Mailer ID of Mail Owner (CPT-1148)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string MailerIdOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (CPT-1149)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string CridOfMailOwner { get; set; }

		/// <summary>
		/// Periodical Ad% Treatment (CPT-1138)
		/// </summary>
		string PeriodicalAdTreatment { get; set; }

		/// <summary>
		/// Periodical Volume Number (CPT-1139)
		/// </summary>
		string PeriodicalVolumeNumber { get; set; }

		/// <summary>
		/// Periodical Issue Number (CPT-1140)
		/// </summary>
		string PeriodicalIssueNumber { get; set; }

		/// <summary>
		/// Periodical Issue Date (CPT-1141)
		/// YYYYMMDD- date on which periodical is issued (can't be all zeros).
		/// </summary>
		DateOnly? PeriodicalIssueDate { get; set; }

		/// <summary>
		/// Periodical Frequency (CPT-1142)
		/// Number of times published per year.
		/// </summary>
		int? PeriodicalFrequency { get; set; }

		/// <summary>
		/// Equivalent User License Code (CPT-1144)
		/// User license code of a component of common weight and ad %. Used in conjunction with Equivalent Job
		/// ID and Equivalent Component ID to link together components with common book weight and ad %.
		/// </summary>
		string EquivalentUserLicenseCode { get; set; }

		/// <summary>
		/// Equivalent Mail.dat Job ID (CPT-1145)
		/// See above note.
		/// </summary>
		string EquivalentMailDatJobId { get; set; }

		/// <summary>
		/// Equivalent Component ID (CPT-1146)
		/// See note for Equivalent User License Code field.
		/// </summary>
		string EquivalentComponentId { get; set; }

		/// <summary>
		/// Equivalent Component Type (CPT-1151)
		/// Only to be used for periodical mailings when Equivalent fields have values in them.
		/// </summary>
		string EquivalentComponentType { get; set; }

		/// <summary>
		/// Ad % Basis (CPT-1152)
		/// 9999v99 implied 2 decimal places.
		/// </summary>
		decimal? AdBasis { get; set; }

		/// <summary>
		/// Component Title (CPT-1147)
		/// Title information A more appropriate place for title information.
		/// </summary>
		string ComponentTitle { get; set; }

		/// <summary>
		/// Standard Parcel Type (CPT-1156)
		/// See definition in MPU.
		/// </summary>
		string StandardParcelType { get; set; }

		/// <summary>
		/// Approved Piece Design Type (CPT-1157)
		/// Indicator for CSR or PCSC ruling type.
		/// </summary>
		string ApprovedPieceDesignType { get; set; }

		/// <summary>
		/// Approved Piece Design (CPT-1158)
		/// The CSR or PCSC ruling number approving the mailing of a specific style/design of mail piece. These
		/// new designs could include but not limited to automation, non-rectangular, non-paper mail pieces.
		/// </summary>
		int? ApprovedPieceDesign { get; set; }

		/// <summary>
		/// User Option Field (CPT-1150)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// CPT Record Status (CPT-2000)
		/// O, D, I, U.
		/// </summary>
		string CptRecordStatus { get; set; }

		/// <summary>
		/// eMailpiece Sample Group ID (CPT-1159)
		/// This USPS-assigned id, will be used to uniquely identify a group of mailpiece samples loaded to USPS
		/// Business Customer Gateway and referenced here for promotion eligibility. Left Justify. Field Format
		/// will be validated by PostalOne!.
		/// </summary>
		string EMailpieceSampleGroupId { get; set; }

		/// <summary>
		/// Reserve (CPT-1130)
		/// Reserved for future use.
		/// </summary>
		string ReserveCpt1130 { get; set; }

		/// <summary>
		/// Closing Character (CPT-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}