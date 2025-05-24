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

namespace Mail.dat
{
	/// <summary>
	/// Identifies specific mail list supplied for this job.
	/// </summary>
	public interface IISeg : IMaildatEntity
	{
		/// <summary>
		/// Job ID (SEG-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Segment ID (SEG-1002)
		/// In the event of Multiple presorts supplied under common Job ID, the Segment ID Must differentiate
		/// each subordinate presorts from the others. A Segment is a mailing facility production run within a
		/// job. Therefore, the Segment ID is a code representing a version, String, list, etc. In general, the
		/// fewer the segments within a Mail.dat® the better. It is only appropriate to create a unique Segment
		/// when it is needed to separate part of a mailing for different Processing. For instance, a portion of
		/// a mailing might need to have An invoice attached in an off-line operation, or the bulk copies of A
		/// Periodical might need to be prepared in cartons. Another example Might be different versions of a
		/// catalog, which cannot be produced, In a selective binding process. In such cases, individual
		/// segments Could be appropriate. Segmenting should not be used to differentiate Among entry points
		/// unless they will need to be processed in some Fundamentally different fashion. Similarly,
		/// segmentation should not Be used to create reporting categories from information that is Otherwise
		/// available in the Mail.dat. A good example of proper Segmentation would be one segment for domestic
		/// mail and one segment For USPS International, not a separate Segment for each entry point.
		/// </summary>
		string SegmentID { get; set; }

		/// <summary>
		/// Segment Description (SEG-1101)
		/// Segmentation should be at single mail stream level, (not higher or Lower specific hierarchy).
		/// Describe string, list, mail-stream Characteristics which this particular set of names exhibits.
		/// Example for a single list Segment: Spring - Remail, prospects, $10 Off Example of a selective bind
		/// Segment: Spring - Remail, all versions.
		/// </summary>
		string SegmentDescription { get; set; }

		/// <summary>
		/// Class Defining Preparation (SEG-1102)
		/// This is the USPS Class that will define preparation criteria as well As postage rates for pieces
		/// within this Mail.dat. Although generally Obvious, this needs to be specified especially for such
		/// instances as: Periodicals with Standard Mail Enclosure and Periodicals with First Class Enclosure.
		/// </summary>
		string ClassDefiningPreparation { get; set; }

		/// <summary>
		/// Principal Processing Category (SEG-1103)
		/// This label describes the physical processing category the mail piece(s) Qualify, which determines
		/// preparation and prices.
		/// </summary>
		string PrincipalProcessingCategory { get; set; }

		/// <summary>
		/// Substituted Container Prep (SEG-1110)
		/// This field notes if, for production reasons, an alternate container is Used for the preparation and
		/// submission of the mailing; such as, Sacking an automated Letter. (See Scenario).
		/// </summary>
		string SubstitutedContainerPrep { get; set; }

		/// <summary>
		/// Periodicals Newspaper Treatment (SEG-1111)
		/// This field notes if the Periodicals publication is eligible for Newspaper handling.
		/// </summary>
		string PeriodicalsNewspaperTreatment { get; set; }

		/// <summary>
		/// Logical/Physical CONTAINER Indicator (SEG-1112)
		/// This field indicates the presence of logical container types in the CSM. When populated with L =
		/// Logical at least one container Must be logical (M, L) otherwise when populated with P, no Container
		/// type can be logical.
		/// </summary>
		string LogicalPhysicalCONTAINERIndicator { get; set; }

		/// <summary>
		/// Log/Phy PACKAGE Indicator (SEG-1113)
		/// This field indicates whether the package record within the Mail.dat® presents logical or physical
		/// packages. A logical package Would be one record representing the 108 pieces that are all going To
		/// the same carrier route. If presented as physical packages those Same 108 pieces might be presented
		/// as five records; representing 25, 25, 25, 17 and 16 pieces, respectively. This field is required,
		/// And must be completed even if the Package Quantity records are Not being transmitted for the
		/// particular Mail.dat.
		/// </summary>
		string LogPhyPACKAGEIndicator { get; set; }

		/// <summary>
		/// LOT Database Date (SEG-1116)
		/// YYYYMMDD (cannot be all zeros) Date of LOT database. This Field only to be populated if LOT step
		/// done in presort step. 00010101 will be the non-value if no date available. Must have a valid date
		/// for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of
		/// non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		DateOnly LOTDatabaseDate { get; set; }

		/// <summary>
		/// Verification Facility Name (SEG-1118)
		/// Name of Mailing Facility where verification occurs.
		/// </summary>
		string VerificationFacilityName { get; set; }

		/// <summary>
		/// Verification Facility ZIP Code (SEG-1119)
		/// ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the
		/// DMU).
		/// </summary>
		string VerificationFacilityZIPCode { get; set; }

		/// <summary>
		/// L.O.T. Direction Indicator (SEG-1122)
		/// </summary>
		string LOTDirectionIndicator { get; set; }

		/// <summary>
		/// Barcode Verifier Indicator (SEG-1123)
		/// (MLOCR indicator).
		/// </summary>
		string BarcodeVerifierIndicator { get; set; }

		/// <summary>
		/// Package Services Packaging Criteria (SEG-1128)
		/// </summary>
		string PackageServicesPackagingCriteria { get; set; }

		/// <summary>
		/// Automation Coding Date (SEG-1129)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		DateOnly AutomationCodingDate { get; set; }

		/// <summary>
		/// Carrier Route Coding Date (SEG-1130)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		DateOnly CarrierRouteCodingDate { get; set; }

		/// <summary>
		/// Carrier Route Sequencing Date (SEG-1131)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		DateOnly CarrierRouteSequencingDate { get; set; }

		/// <summary>
		/// Move Update Date (SEG-1134)
		/// Oldest date on which any portion of the mail file represented by This Segment was updated in accord
		/// with Move Update policy. YYYYMMDD (cannot be all zeros).
		/// </summary>
		DateOnly? MoveUpdateDate { get; set; }

		/// <summary>
		/// Detached Mailing Label Indicator (SEG-1136)
		/// </summary>
		string DetachedMailingLabelIndicator { get; set; }

		/// <summary>
		/// eDoc Sender CRID (SEG-1140)
		/// This USPS-assigned id, CRID, will be used by the industry to identify the Originator of the Segment.
		/// </summary>
		string EDocSenderCRID { get; set; }

		/// <summary>
		/// Container and Bundle Charge Method (SEG-1141)
		/// This field identifies how to calculate periodical charges.
		/// </summary>
		string ContainerAndBundleChargeMethod { get; set; }

		/// <summary>
		/// MPA ID for Container and Bundle Charge Method (SEG-1142)
		/// MPA Identifier that will be used to allocate the container and bundle Charges for the segment if ALL
		/// containers and/or bundles are Charged to a single payer. Note: This value should only be entered if
		/// the Container and Bundle Charge Method is 1 or 2 Unique identifier for the respective MPA within an
		/// MPU. Establishes the set of MPU copies on one Postage Statement.
		/// </summary>
		string MPAIDForContainerAndBundleChargeMethod { get; set; }

		/// <summary>
		/// Less Than a Presort Segment Presentation (SEG-1145)
		/// This field identifies Full or partial presort segment presentation.
		/// </summary>
		string LessThanAPresortSegmentPresentation { get; set; }

		/// <summary>
		/// Full-Service Participation Indicator (SEG-1146)
		/// Mixed (Basic and Full Mixed) Mail Owners/Mailing Agents will be required to use the Intelligent
		/// Mail® Barcode on their letter and flat mail pieces in place of the routing ZIP ® Barcode. At a
		/// minimum, this barcode will include the same delivery point Information that is included in the
		/// routing ZIP® barcode today, an assigned Mailer ID, the class of mail, and optional endorsement line
		/// (OEL) Information, if an OEL is printed on the mail piece. Mail Owners/Mailing Agents using pressure
		/// sensitive bar-coded presort labels will not be Required to include this information in the
		/// Intelligent Mail® barcode. For Basic-option the Mail Owners/Agents do not need to provide piece
		/// detail Electronic information. Full Service Option Under the Full Service option, Mail
		/// Owners/Mailing Agents will be Required to apply Intelligent Mail® barcodes on their letter and flat
		/// mail Pieces, trays and sacks, and other containers. Mailers will also be required To submit their
		/// postage statements and mailing documentation electronically. For drop-ship mailings and all
		/// origin-entered mail verified at A detached mail unit (DMU), Mail Owners/Mailing Agents will be
		/// required To schedule electronic appointments using the Facility Access and Shipment Tracking (FAST)
		/// system.
		/// </summary>
		string FullServiceParticipationIndicator { get; set; }

		/// <summary>
		/// Move Update Method (SEG-1147)
		/// This field is used to identify Move Update method at the postage statement level.
		/// </summary>
		string MoveUpdateMethod { get; set; }

		/// <summary>
		/// Delivery Statistics File Date (SEG-1150)
		/// Required - YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must
		/// have a valid date for automation and/or carrier route mail, Otherwise populate with default value
		/// 00010101. Use of non- value may Jeopardize rate eligibility. Date when the Delivery Statistics file
		/// was used for Reporting on the postage statements. In the case of multiple delivery statistics File
		/// dates, the oldest date should be used for populating this field.
		/// </summary>
		DateOnly DeliveryStatisticsFileDate { get; set; }

		/// <summary>
		/// Informed Address Indicator (SEG-1187)
		/// </summary>
		string InformedAddressIndicator { get; set; }

		/// <summary>
		/// Informed Address Expiration Date (SEG-1186)
		/// Should have a valid date when Informed Address pieces are in the mailing, in The YYYYMMDD format
		/// (Cannot be all zeroes). In case of multiple Expiration dates, use the oldest date.
		/// </summary>
		DateOnly? InformedAddressExpirationDate { get; set; }

		/// <summary>
		/// Information Exchange (SEG-1182)
		/// See definition in HDR.
		/// </summary>
		string InformationExchange { get; set; }

		/// <summary>
		/// User Option Field (SEG-1126)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// Mailing Agreement Type (SEG-1139)
		/// </summary>
		string MailingAgreementType { get; set; }

		/// <summary>
		/// FCM Letter Residual Preparation Indicator (SEG-1183)
		/// M = Mixed (the statements in the segment have residual pieces with less than or Equal to 3.5 ounces
		/// Blank = Separated or Not applicable (if the statements in the segment have Residual pieces with less
		/// than or equal to 3.5 oz then they are separated in Containers/trays; otherwise this field is not
		/// applicable.
		/// </summary>
		string FCMLetterResidualPreparationIndicator { get; set; }

		/// <summary>
		/// Handling Unit Uniqueness Manager CRID (SEG-1184)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining
		/// handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.
		/// </summary>
		string HandlingUnitUniquenessManagerCRID { get; set; }

		/// <summary>
		/// Container Uniqueness Manager CRID (SEG-1185)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining
		/// handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.
		/// </summary>
		string ContainerUniquenessManagerCRID { get; set; }

		/// <summary>
		/// SEG Record Status (SEG-2000)
		/// </summary>
		string SEGRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SEG-1127)
		/// </summary>
		string ReserveSEG1127 { get; set; }

		/// <summary>
		/// Closing Character (SEG-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}