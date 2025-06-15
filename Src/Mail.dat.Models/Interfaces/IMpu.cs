//
// Copyright (c) 2025 Open Mail.dat
//
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
//
// This code was auto-generated on June 14th, 2025.
// by the Open Mail.dat Code Generator.
//
// Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// A common code for set of components in a mail piece.
	/// </summary>
	public interface IMpu : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (MPU-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Segment ID (MPU-1002)
		/// </summary>
		string SegmentId { get; set; }

		/// <summary>
		/// Mail Piece Unit ID (MPU-1003)
		/// Must have some value, even if single edition. This ID will be used by the computer controlled
		/// equipment at the mailing facility to manufacture the specific binding parts for this make-up within
		/// this particular mailing. Any Mail Piece Unit exists within a specific Segment. Therefore,
		/// Segment/MPU is mutually exclusive. MPU alone is not unique.
		/// </summary>
		string MailPieceUnitId { get; set; }

		/// <summary>
		/// Mail Piece Unit Name (MPU-1101)
		/// The name used to identify a specific marketing version within a list, bind and distribution
		/// environment. This name may be on-going as a description from issue to issue, as opposed to the job
		/// to job alpha and/or numeric Selective Bind Code that will control the binding machine. The Mail
		/// Piece Unit Name, more traditionally in Periodicals, may be a meaningful identifier; such as S-S NW
		/// Metro. Whether in Periodicals or other classes, the MPU Name field is a defined location where
		/// downstream users can find the MPU's meaningful Name for this job, regardless of the arbitrary MPU
		/// ID. If, as may often be the case in non-Periodical, there is no benefit derived from special naming
		/// then the Book Make-up Name can be the same as the MPU ID. The MPU Name will be the source for mail
		/// owner's name on Postage Payment forms or their electronic equivalents. Suggested convention for
		/// carrying the identity of the base book: - Example MPU Name Value:Exxxxxxx_BRO -- E (hard coded)
		/// stands for edition; -- xxxxxxx (only as many as necessary) represents base book edition; -- _
		/// (underline) separates edition & suffix; -- B/R/O (solo or BO or RO) --- B = Bill, R = Renewal, O=
		/// Other H = Periodicals Ride-Along - Additional Examples: E9711COM_B or E1997S_O or E01_RO.
		/// </summary>
		string MailPieceUnitName { get; set; }

		/// <summary>
		/// Mail Piece Unit Description (MPU-1102)
		/// This is a unique name or code for each specific version being created within this mailing. However,
		/// as a differentiation from the Mail Piece Unit Name, this may be a meaningful descriptor of a broader
		/// significance than just this mailing. Therefore, this field is an opportunity to have absolute, as
		/// well as of relative, information in this record. This offers information for enhanced quality
		/// assurance and reduced error. For example: A periodical has a Metro Northwest Superspot edition that
		/// is run every issue. Therefore, the Mail Piece Unit ID to drive the machine in the bindery might be B
		/// for one issue and Q a month later. However, the Mail Piece Unit Name would always be S-S NW Metro
		/// and the Mail Piece Unit Description would always be Metro Northwest Superspot A 3C campaign may not
		/// have repeating market target names; or they may. So, the Mail Piece Unit IDs for a mailing may be A,
		/// B, and C. For that campaign, the MPU Descriptions may be A, B, and C., or the MPU Descriptions could
		/// be RHF, RHS, and RHT, if those were meaningful codes carrying over from one job to another. The
		/// originator of the Mail.dat® file, as agreed by receiving mailing facilities, can choose to the
		/// finest level of detail in the preceding two fields or simply clone that which is in the Mail Piece
		/// Unit ID field.
		/// </summary>
		string MailPieceUnitDescription { get; set; }

		/// <summary>
		/// Mail Piece Unit - Weight (MPU-1103)
		/// Weight of a copy in pounds, rounded. Presort Facilities default to 1 ounce, if Metered Mail.
		/// </summary>
		decimal MailPieceUnitWeight { get; set; }

		/// <summary>
		/// MPU - Weight: Source (MPU-1104)
		/// Source of Piece Weight.
		/// </summary>
		string MpuWeightSource { get; set; }

		/// <summary>
		/// MPU - Weight: Status (MPU-1105)
		/// Status of weight data.
		/// </summary>
		string MpuWeightStatus { get; set; }

		/// <summary>
		/// Mail Piece Unit - Length (MPU-1106)
		/// Length of a copy in inches, rounded.
		/// </summary>
		decimal? MailPieceUnitLength { get; set; }

		/// <summary>
		/// Mail Piece Unit - Width (MPU-1107)
		/// Width of a copy in inches, rounded.
		/// </summary>
		decimal? MailPieceUnitWidth { get; set; }

		/// <summary>
		/// Mail Piece Unit - Thickness (MPU-1108)
		/// Thickness of a copy in inches.
		/// </summary>
		decimal? MailPieceUnitThickness { get; set; }

		/// <summary>
		/// Mail Piece Unit - Class (MPU-1111)
		/// The Postal Class of this Mail Piece Unit within Mail.dat.
		/// </summary>
		string MailPieceUnitClass { get; set; }

		/// <summary>
		/// Mail Piece Unit - Rate Type (MPU-1112)
		/// The special rate type that applies to this Mail Piece Unit.
		/// </summary>
		string MailPieceUnitRateType { get; set; }

		/// <summary>
		/// Rate Schedule (MPU-1128)
		/// </summary>
		string RateSchedule { get; set; }

		/// <summary>
		/// Mail Piece Unit - Processing Category (MPU-1113)
		/// The processing category for which this Mail Piece Unit is eligible.
		/// </summary>
		string MailPieceUnitProcessingCategory { get; set; }

		/// <summary>
		/// MPU Surcharge (MPU-1115)
		/// Surcharges applicable to the this MPU. Regarding Machinability; a single MPU will be used to
		/// describe the nature of the mail piece: - The MPU - Surcharge field to indicate overall nature of the
		/// piece's physical characteristics. - Two MPUs (and associated CPTs) may be necessary to communicate a
		/// mailing, not just CPTs.
		/// </summary>
		string MpuSurcharge { get; set; }

		/// <summary>
		/// Co-Palletization Code (MPU-1116)
		/// Used to differentiate carrier route mail going to the same ZIP and Route that was coded and
		/// presorted independently, to allow association with a subset of the Walk Sequence Records (*.wsr).
		/// For Co-palletization, it creates an efficient means to differentiate each of the possible job and
		/// sub-job entities within a co-palletization set-up. Can also be used to differentiate between
		/// simplified and non-simplified addressed pieces when combined in the same job. Populate with 01 for
		/// jobs where this additional level of detail is not needed.
		/// </summary>
		string CoPalletizationCode { get; set; }

		/// <summary>
		/// Machinability Indicator (MPU-1123)
		/// </summary>
		string MachinabilityIndicator { get; set; }

		/// <summary>
		/// Pre-Denominated Amount (MPU-1124)
		/// Cents.
		/// </summary>
		decimal? PreDenominatedAmount { get; set; }

		/// <summary>
		/// Postage Affixed Type (MPU-1125)
		/// </summary>
		string PostageAffixedType { get; set; }

		/// <summary>
		/// Standard Parcel Type (MPU-1132)
		/// </summary>
		string StandardParcelType { get; set; }

		/// <summary>
		/// User Option Field (MPU-1129)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// Move Update Supplier CRID (MPU-1130)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for compliance
		/// with USPS move update requirements. Only digits 0 - 9 acceptable.
		/// </summary>
		string MoveUpdateSupplierCrid { get; set; }

		/// <summary>
		/// Piece Uniqueness Manager CRID (MPU-1131)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party responsible for maintaining
		/// piece IMb® uniqueness. Left justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		string PieceUniquenessManagerCrid { get; set; }

		/// <summary>
		/// MPU Record Status (MPU-2000)
		/// </summary>
		string MpuRecordStatus { get; set; }

		/// <summary>
		/// Grouped Extra Service Type (MPU-1133)
		/// Identifies the type of Grouped Extra Service.
		/// </summary>
		string GroupedExtraServiceType { get; set; }

		/// <summary>
		/// Grouped Extra Service Barcode (MPU-1134)
		/// Identifies IMpb® (Intelligent Mail Package Barcode).
		/// </summary>
		string GroupedExtraServiceBarcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (MPU-1135)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb®. Industry has agreed that for IMpb®, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		string ImpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// Reserve (MPU-1121)
		/// Reserved for future use.
		/// </summary>
		string ReserveMpu1121 { get; set; }

		/// <summary>
		/// Closing Character (MPU-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}