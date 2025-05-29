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
	/// A description of the applicable component.
	/// </summary>
	public interface ICpt : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CPT-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Component ID (CPT-1004)
		/// See MPU/C Component ID definition.
		/// </summary>
		string ComponentID { get; set; }

		/// <summary>
		/// Component Description (CPT-1101)
		/// This is a unique name or code for each specific sub- or whole-portion of The mail piece. This field,
		/// if used, can carry an absolute reference to The Component in question while the Component ID is
		/// practical shorthand For reference to the Component's role within the mailing facilities postage
		/// Analysis. Left justify. If used, must have some value, even if single edition.
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
		/// Length of a copy 999v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentLength { get; set; }

		/// <summary>
		/// Component - Width (CPT-1106)
		/// Width of a copy 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentWidth { get; set; }

		/// <summary>
		/// Component - Thickness (CPT-1107)
		/// Thickness of a copy 99v9999; inches, rounded (decimal point implied).
		/// </summary>
		decimal? ComponentThickness { get; set; }

		/// <summary>
		/// Component - Periodical Ad Percentage (CPT-1108)
		/// Ad percentage of a copy 999v99, rounded (decimal point implied) Example (if there is a two page
		/// Periodical supplement having 50% Ad and the Periodical Is 48 pages having 40% Ad, then in the
		/// mail.dat file the ad percent of the supplement is (2/50)x.5 = 2.0% and the ad percent of the
		/// Periodical is (48/50)x.4 =38.40%. The sum is 40.40% Field is necessary for Periodicals Enclosures.
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
		string MailerIDOfMailOwner { get; set; }

		/// <summary>
		/// CRID of Mail Owner (CPT-1149)
		/// USPS ID Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string CRIDOfMailOwner { get; set; }

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
		/// User license code of a component of common weight and ad %. Used in Conjunction with Equivalent Job
		/// ID and Equivalent Component ID to link Together components with common book weight and ad %.
		/// </summary>
		string EquivalentUserLicenseCode { get; set; }

		/// <summary>
		/// Equivalent Mail.dat Job ID (CPT-1145)
		/// See above note.
		/// </summary>
		string EquivalentMailDatJobID { get; set; }

		/// <summary>
		/// Equivalent Component ID (CPT-1146)
		/// See note for Equivalent User License Code field.
		/// </summary>
		string EquivalentComponentID { get; set; }

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
		/// The CSR or PCSC ruling number approving the mailing of a specific Style/design of mail piece. These
		/// new designs could include but not Limited to automation, non-rectangular, non-paper mail pieces.
		/// </summary>
		int? ApprovedPieceDesign { get; set; }

		/// <summary>
		/// User Option Field (CPT-1150)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// CPT Record Status (CPT-2000)
		/// </summary>
		string CPTRecordStatus { get; set; }

		/// <summary>
		/// eMailpiece Sample Group ID (CPT-1159)
		/// This USPS-assigned id, will be used to uniquely identify a group of Mailpiece samples loaded to USPS
		/// Business Customer Gateway and Referenced here for promotion eligibility. Left Justify. Field Format
		/// will Be validated by PostalOne!.
		/// </summary>
		string EMailpieceSampleGroupID { get; set; }

		/// <summary>
		/// Reserve (CPT-1130)
		/// </summary>
		string ReserveCPT1130 { get; set; }

		/// <summary>
		/// Closing Character (CPT-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}