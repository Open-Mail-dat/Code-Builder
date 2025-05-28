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
	/// Quantity, weights and destination per container.
	/// </summary>
	public interface ICsm : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (CSM-1001)
		/// </summary>
		string JobID { get; set; }

		/// <summary>
		/// Segment ID (CSM-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		string SegmentID { get; set; }

		/// <summary>
		/// Container Type (CSM-1005)
		/// See Scenario for Logical/Physical Tray and Pallets in CSM, under Scenarios. (for description of Air
		/// Box, see Mail.dat Air box scenario).
		/// </summary>
		string ContainerType { get; set; }

		/// <summary>
		/// Container ID (CSM-1006)
		/// Mail.dat® container serial number, used to link Mail.dat® files. Must be mutually exclusive across
		/// all Segments and Container Types of a Job ID. A unique numeric code for this container within this
		/// Job, exclusive of Container Type. This is a serial number for this container in this Mail.dat® for
		/// this Job and, as such, will be used to link to other Mail.dat® files. Must be mutually exclusive
		/// within Job. Repetitive Display Container IDs are at the discretion of the production facility
		/// receiving the respective Mail.dat.
		/// </summary>
		int ContainerID { get; set; }

		/// <summary>
		/// Display Container ID (CSM-1101)
		/// Meaningful (external to Mail.dat) container ID as defined by specific production application; the
		/// Postal container label.
		/// </summary>
		string DisplayContainerID { get; set; }

		/// <summary>
		/// Container Grouping Description (CSM-1102)
		/// User Defined Grouping A value that associates multiple containers for the convenience of the mailing
		/// facility.
		/// </summary>
		string ContainerGroupingDescription { get; set; }

		/// <summary>
		/// Container Destination Zip (CSM-1103)
		/// The 5-digit or 3-digit destination of container defined in this record. These are the same as
		/// destination 5-digit or 3-digit sack or tray label. 99999_ or 888___ CAN = A1A9Z9 Default if no ZIP
		/// or Postal Code: Left Justify; Space Added: US = USA, OT = Other These ZIP defaults are provided for
		/// use in the event that no pre-identified postal code is available. Example: newsstand or bulk copy
		/// distribution.
		/// </summary>
		string ContainerDestinationZip { get; set; }

		/// <summary>
		/// Container Level (CSM-1104)
		/// Eligible Types: S = Sack, T = Tray, P = Pallet If single character, left justify, space added.
		/// </summary>
		string ContainerLevel { get; set; }

		/// <summary>
		/// Entry Point for Entry Discount - PostalCode (CSM-1105)
		/// 99999_, or 888___ The postal code (5-digit, or 3-digit) of the facility where the specified
		/// container is planned to enter into the Postal System. Use Labeling Lists facility's Destination
		/// Line. This information may not be known by the list processing facility. If known, the 5 or 3
		/// position value is to be left justified with space added. Default if no Code: Left Justify; Space
		/// Added: US = USA, OT = Other If the ultimate planned Entry Point is not known (example, as would be
		/// the case with a list supplier of a Standard Mail (A) job which will be included in a Destination
		/// Entry pool), then the Origin Zip (as indicated on the Entry Point Line of the Container Label) would
		/// be used for this field.
		/// </summary>
		string EntryPointForEntryDiscountPostalCode { get; set; }

		/// <summary>
		/// Entry Point for Entry Discount - Facility Type (CSM-1106)
		/// Entry Point for Container Handling, used for container entry charge. The type of facility where the
		/// container is planned to enter. In some cases, this is a description of the transportation
		/// work-sharing potential. For many List Processors, Not-determined is the option. In the above values,
		/// Origin XXX (C, E, J, K, L, Q) is used to describe the facility of a specific type (XXX), which is
		/// not the destination XXX, but rather the XXX facility where mail is entering the USPS channel for
		/// induction.
		/// </summary>
		string EntryPointForEntryDiscountFacilityType { get; set; }

		/// <summary>
		/// Entry Point - Actual / Delivery -Locale Key (CSM-1167)
		/// US = LOCA12345 (LOC plus 6 bytes of the Locale key from the drop ship product); 'ORIGIN' for origin
		/// entered mail; OT = Other The field can have a Locale key for origin entered mail when USPS Pick Up
		/// is equal to N. See Scenarios and Definitions Sections for alternatives for populating this field.
		/// Use value of 'ORIGIN' for Origin/DMU Entered mail OR for US Drop Ship, Zone Skipped, and BMEU
		/// entered Mail use the Locale Key (LOC in the first 3 bytes, balance is the 6-byte of the USPS
		/// dropsite key, also known as the Locale Key).
		/// </summary>
		string EntryPointActualDeliveryLocaleKey { get; set; }

		/// <summary>
		/// Entry Point - Actual / Delivery -Postal Code (CSM-1168)
		/// ZIP + 4 of building receiving the mail; ZIP + 4 of DMU for DMU entered mail The ZIP + 4 shall be the
		/// Delivery address ZIP + 4 from the USPS Drop Ship Product. Either the Locale Key reference field
		/// (CSM-1167), or the Correct ZIP + 4 is required in this field for USPS full-service automation rates.
		/// This information helps USPS calculate and measure service performance.
		/// </summary>
		string EntryPointActualDeliveryPostalCode { get; set; }

		/// <summary>
		/// Parent Container Reference ID (CSM-1109)
		/// (use numeric populated in 14/6 of .CSM of Parent record) Container ID of the Parent Container in
		/// which this Child Container resides, if such relationship exists, blank if no such relationship.
		/// Parent Containers may have Parent Containers themselves. This is not prohibited; ex: a carton in a
		/// sack upon a pallet. The Container Id of the Parent Container in which this child container resides;
		/// such as a tray on a pallet. Populate field with numeric from Container ID CSM-1006 of parent
		/// container's .CSM If no child/parent relationship exists for this container, then field is blank.
		/// Populated ONLY for those child containers linked to a parent container; if container is parent only,
		/// then field is blank.
		/// </summary>
		int? ParentContainerReferenceID { get; set; }

		/// <summary>
		/// Truck or Dispatch Number (CSM-1110)
		/// As available, the truck ID, trailer ID, or applicable dispatch information.
		/// </summary>
		string TruckOrDispatchNumber { get; set; }

		/// <summary>
		/// Stop Designator (CSM-1111)
		/// Stop order and stop 1 will be the first stop (i.e., what is loaded in the tail).
		/// </summary>
		string StopDesignator { get; set; }

		/// <summary>
		/// Reservation Number (CSM-1112)
		/// As available, the appointment number for the specified container in this record.
		/// </summary>
		string ReservationNumber { get; set; }

		/// <summary>
		/// Actual Container Ship Date (CSM-1113)
		/// As available, date when the container releases from mailing facility or agent's facility. YYYYMMDD
		/// (cannot be all zeros). Unscheduled DMU verified/USPS Transported.
		/// </summary>
		DateOnly? ActualContainerShipDate { get; set; }

		/// <summary>
		/// Actual Container Ship Time (CSM-1164)
		/// As available, time when the container releases from mailing facility or agent's facility. HH:MM (EX:
		/// 18:12). Unscheduled DMU verified/USPS Transported.
		/// </summary>
		TimeOnly? ActualContainerShipTime { get; set; }

		/// <summary>
		/// Scheduled Pick Up Date (CSM-1177)
		/// Scheduled pick up date.
		/// </summary>
		DateOnly? ScheduledPickUpDate { get; set; }

		/// <summary>
		/// Scheduled Pick Up Time (CSM-1178)
		/// Scheduled pick up time.
		/// </summary>
		TimeOnly? ScheduledPickUpTime { get; set; }

		/// <summary>
		/// Scheduled In-Home Date (CSM-1115)
		/// The first, or only date of the ranged targeted for in-home delivery. YYYYMMDD (cannot be all zeros)
		/// (first date in range).
		/// </summary>
		DateOnly? ScheduledInHomeDate { get; set; }

		/// <summary>
		/// Additional In-Home Range (CSM-1116)
		/// Additional days in In-Home Range (values = 0,1,2,3,4,5,6,7,8,9).
		/// </summary>
		int? AdditionalInHomeRange { get; set; }

		/// <summary>
		/// Scheduled Induction Start Date (CSM-1117)
		/// That start date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot
		/// be all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be
		/// before or equal to the end date.
		/// </summary>
		DateOnly? ScheduledInductionStartDate { get; set; }

		/// <summary>
		/// Scheduled Induction Start Time (CSM-1118)
		/// That hour of the scheduled start date on which the mail is to be transferred to the consignee for
		/// processing. HH:MM (EX: 18:12).
		/// </summary>
		TimeOnly? ScheduledInductionStartTime { get; set; }

		/// <summary>
		/// Scheduled Induction End Date (CSM-2001)
		/// That end date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot be
		/// all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be
		/// before or equal to the end date.
		/// </summary>
		DateOnly? ScheduledInductionEndDate { get; set; }

		/// <summary>
		/// Scheduled Induction End Time (CSM-2002)
		/// That hour of the scheduled end date on which the mail is to be transferred to the consignee for
		/// processing. HH:MM (EX: 18:12).
		/// </summary>
		TimeOnly? ScheduledInductionEndTime { get; set; }

		/// <summary>
		/// Actual induction Date (CSM-1179)
		/// Actual date when mail was inducted.
		/// </summary>
		DateOnly? ActualInductionDate { get; set; }

		/// <summary>
		/// Actual Induction Time (CSM-1180)
		/// Actual time when mail was inducted.
		/// </summary>
		TimeOnly? ActualInductionTime { get; set; }

		/// <summary>
		/// Postage Statement Mailing Date (CSM-1184)
		/// YYYYMMDD (cannot be all zeros). The date on which postage is paid to the USPS and verification is
		/// completed.
		/// </summary>
		DateOnly? PostageStatementMailingDate { get; set; }

		/// <summary>
		/// Postage Statement Mailing Time (CSM-1183)
		/// HH:MM (EX: 18:12). The time on which postage is paid to the USPS and verification is completed.
		/// </summary>
		TimeOnly? PostageStatementMailingTime { get; set; }

		/// <summary>
		/// Number of Copies (CSM-1120)
		/// Total copies on the container represented by this record.
		/// </summary>
		int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CSM-1121)
		/// Total Pieces on the container represented by this record. (see Scenarios for Firm Packages and
		/// Package Services Multi-Piece Parcel bundles) (pieces may be less than copies in some Periodical or
		/// Package Services mailings).
		/// </summary>
		int NumberOfPieces { get; set; }

		/// <summary>
		/// Total Weight (product only) (CSM-1122)
		/// 99999999v9999 pounds, (decimal point implied). International = Gross Weight.
		/// </summary>
		decimal TotalWeightProductOnly { get; set; }

		/// <summary>
		/// User Container ID (CSM-1123)
		/// </summary>
		string UserContainerID { get; set; }

		/// <summary>
		/// Container Status (CSM-1124)
		/// A Deleted Container Cannot be reused like the C Flag, where a C can be changed to Blank and then to
		/// R or X or T) Deleted Containers' IM Barcode(s), Container, Tray, and Piece cannot be re-used for 45
		/// days, per USPS, after a Deleted status is sent to USPS. Examples Blank = From List House to Mailing
		/// Facility Blank = From Mailing Facility to USPS (preliminary) Ready = From Mailing Facility to USPS
		/// (final for specific container) This would be in conjunction with a U Status for .csm File in Header
		/// Record Closed = From Mailing Facility to USPS (after this container is paid, if transmit full .csm
		/// file).
		/// </summary>
		string ContainerStatus { get; set; }

		/// <summary>
		/// Included In Other Documentation (CSM-1181)
		/// This field indicates if the container is co-palletized. O means this container is the Container from
		/// the Originator's site and shall show up on another Mail.dat as a linked container and I means this
		/// container is the Container from the Originator's site and is co-palletized at the same originator
		/// plant and shall show up on another Mail.dat as a linked container with a value of L.
		/// </summary>
		string IncludedInOtherDocumentation { get; set; }

		/// <summary>
		/// Tray Preparation Type (CSM-1126)
		/// </summary>
		string TrayPreparationType { get; set; }

		/// <summary>
		/// Trans-Ship Bill of Lading Number (CSM-1130)
		/// Multi-carrier load connection.
		/// </summary>
		string TransShipBillOfLadingNumber { get; set; }

		/// <summary>
		/// Sibling Container Indicator (CSM-1132)
		/// Y indicates that this .CSM record represents an additional container that, due to a severe error in
		/// the piece measurement, is created during the course of production to contain those pieces that could
		/// not be included as part of the original container defined by the presort. If there is a Sibling
		/// Container ONLY the following fields in the Sibling .CSM record are populated: Job ID field - Segment
		/// ID field - The Container ID of the Sibling Container - User Container ID - Container Type field -
		/// Sibling Container Indicator field - The Sibling Container Reference ID field (Container ID of the
		/// original container requiring the sibling) - Supplemental Physical Container ID field (optional) -
		/// All fields that start with word 'label' and associated with Container Label data No other fields
		/// shall be populated; all other values are shared across this pair of associated containers.
		/// </summary>
		string SiblingContainerIndicator { get; set; }

		/// <summary>
		/// Sibling Container Reference ID (CSM-1133)
		/// (use numeric populated in 14/6 of .CSM of original container) In the event of a Sibling Container,
		/// then the Mail.dat® Container ID of the original affected container must be populated in this field.
		/// A Sibling Container is one necessitated by a severe under-estimate of the piece weight; thereby
		/// requiring the mailing facility to create another (the Sibling) container to accept the overflow.
		/// Identifies the original container with which this Sibling Container is associated, if such
		/// relationship exists. Blank if no such relationship.
		/// </summary>
		int? SiblingContainerReferenceID { get; set; }

		/// <summary>
		/// Postage Grouping ID (CSM-1136)
		/// Identifies that group of containers for which a single Postage Payment was made.
		/// </summary>
		string PostageGroupingID { get; set; }

		/// <summary>
		/// Container Gross Weight (CSM-1137)
		/// 99999999v9999, (decimal point implied) Inclusive of mail and container.
		/// </summary>
		decimal? ContainerGrossWeight { get; set; }

		/// <summary>
		/// Container Height (CSM-1139)
		/// (value in inches, no decimal) (inclusive of mail and container).
		/// </summary>
		int? ContainerHeight { get; set; }

		/// <summary>
		/// EMD - 8125 ASN Barcode (CSM-1141)
		/// See EMD Scenario.
		/// </summary>
		string EMD8125ASNBarcode { get; set; }

		/// <summary>
		/// Transportation Carrier ID (CSM-1142)
		/// USPS CRID identifying the transporter of mail. Left justify, space padded to the right, only digits
		/// 0 - 9 acceptable.
		/// </summary>
		string TransportationCarrierID { get; set; }

		/// <summary>
		/// FAST Content ID (CSM-1162)
		/// USPS FAST CONTENT ID. This ID identifies the contents (one or more IMcbs) going to an entry point.
		/// </summary>
		string FASTContentID { get; set; }

		/// <summary>
		/// FAST Scheduler ID (CSM-1163)
		/// USPS CRID identifying the SCHEDULER of FAST appointments. Schedulers are allowed to file
		/// transportation updates on behalf of the mailer. When populated, this party becomes the responsible
		/// CRID for eInduction errors invoicing on mis-shipped errors in excess of scorecard thresholds. Left
		/// justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		int? FASTSchedulerID { get; set; }

		/// <summary>
		/// USPS Pick Up (CSM-1171)
		/// </summary>
		string USPSPickUp { get; set; }

		/// <summary>
		/// CSA Separation ID (CSM-1175)
		/// The CSA Separation ID is the separation number as defined in the USPS Guide to Customer/Supplier
		/// Agreements.
		/// </summary>
		int? CSASeparationID { get; set; }

		/// <summary>
		/// Scheduled Ship Date (CSM-1172)
		/// Date of Dispatch based upon CSA agreement. DMU verified/USPS Transported.
		/// </summary>
		DateOnly? ScheduledShipDate { get; set; }

		/// <summary>
		/// Scheduled Ship Time (CSM-1173)
		/// (EX: 18:12) - Time of Dispatch based upon CSA agreement. DMU verified/USPS Transported.
		/// </summary>
		TimeOnly? ScheduledShipTime { get; set; }

		/// <summary>
		/// DMM Section Defining Container Preparation (CSM-1147)
		/// Full DMM applicable reference including subsections Example: DMM 300 section 705.8 could be
		/// represented as 705.8 Section 711.2.1 would be 711.2.1. Minimum value is 3 bytes; example 702.
		/// </summary>
		string DMMSectionDefiningContainerPreparation { get; set; }

		/// <summary>
		/// Label: IM™ Container Or IM™ Tray Barcode - Final (CSM-1150)
		/// Final IMtb or IMcb used on delivered trays or containers to the USPS by the consolidator or
		/// logistics company. If not specified, then leave field blank. If populated in original Mail.dat use
		/// same data as CSM-1198. Also see 'Container Barcode Required for Sibling Containers' scenario under
		/// scenarios section. Also, if the container is 'Deleted' through a Container Status of 'D', then the
		/// Container barcode shall not be used/re-used for 45 days after a 'D' flag has been sent to USPS.
		/// </summary>
		string LabelIMContainerOrIMTrayBarcodeFinal { get; set; }

		/// <summary>
		/// Label: IM™ Container Or IM™ Tray Barcode- Original (CSM-1198)
		/// Original IMtb or IMcb barcode provided by Preparer to a Consolidator or Logistics company. Left
		/// justify, blank fill. If not specified, then leave field blank. Also see 'Container Barcode Required
		/// for Sibling Containers' scenario under scenarios section. Also, if the container is 'Deleted'
		/// through a Container Status of 'D', then the Container barcode shall not be used/re-used for 45 days
		/// after a 'D' flag has been sent to USPS.
		/// </summary>
		string LabelIMContainerOrIMTrayBarcodeOriginal { get; set; }

		/// <summary>
		/// Label: Destination Line 1 (CSM-1152)
		/// </summary>
		string LabelDestinationLine1 { get; set; }

		/// <summary>
		/// Label: Destination Line 2 (CSM-1153)
		/// </summary>
		string LabelDestinationLine2 { get; set; }

		/// <summary>
		/// Label: Contents - Line 1 (CSM-1154)
		/// </summary>
		string LabelContentsLine1 { get; set; }

		/// <summary>
		/// Label: Contents - Line 2 (CSM-1155)
		/// (overflow of line 1).
		/// </summary>
		string LabelContentsLine2 { get; set; }

		/// <summary>
		/// Label: Entry (Origin) Point Line (CSM-1156)
		/// </summary>
		string LabelEntryOriginPointLine { get; set; }

		/// <summary>
		/// Label: User Information Line 1 (CSM-1157)
		/// User defined or client requested information.
		/// </summary>
		string LabelUserInformationLine1 { get; set; }

		/// <summary>
		/// Label: User Information Line 2 (CSM-1158)
		/// </summary>
		string LabelUserInformationLine2 { get; set; }

		/// <summary>
		/// Label: Container Label CIN Code (CSM-1159)
		/// </summary>
		string LabelContainerLabelCINCode { get; set; }

		/// <summary>
		/// User Option Field (CSM-1176)
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// eInduction Indicator (CSM-1186)
		/// This shall serve as a flag as to whether an e8125/e8017 needs to be generated for eInduction.
		/// Default value shall be Blank.
		/// </summary>
		string EInductionIndicator { get; set; }

		/// <summary>
		/// CSA Agreement ID (CSM-1187)
		/// Agreement Number generated by the USPS.
		/// </summary>
		string CSAAgreementID { get; set; }

		/// <summary>
		/// Presort Labeling List Effective Date (CSM-1189)
		/// (cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be
		/// the non-value when date is not applicable.
		/// </summary>
		DateOnly PresortLabelingListEffectiveDate { get; set; }

		/// <summary>
		/// Last Used Labeling List Effective Date (CSM-1190)
		/// (cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be
		/// the non-value when date is not applicable. For the initial presort, this will have the same value as
		/// Presort Labeling List Effective Date field.
		/// </summary>
		DateOnly LastUsedLabelingListEffectiveDate { get; set; }

		/// <summary>
		/// Presort City-State Publication Date (CSM-1191)
		/// (cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value
		/// when date is not applicable.
		/// </summary>
		DateOnly PresortCityStatePublicationDate { get; set; }

		/// <summary>
		/// Last Used City-State Publication Date (CSM-1192)
		/// (cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value
		/// when the date is not applicable. For the initial presort, this will have the same value as Presort
		/// City-State Publication Date.
		/// </summary>
		DateOnly LastUsedCityStatePublicationDate { get; set; }

		/// <summary>
		/// Presort Zone Chart Matrix Publication Date (CSM-1193)
		/// (cannot be all zeros) 00010101 will be the non-value when date is not applicable.
		/// </summary>
		DateOnly PresortZoneChartMatrixPublicationDate { get; set; }

		/// <summary>
		/// Last Used Zone Chart Matrix Publication Date (CSM-1194)
		/// (cannot be all zeros) 00010101 will be the non-value when the date is not applicable. For the
		/// initial presort, this will have the same value as Presort Zone Chart Matrix Publication Date.
		/// </summary>
		DateOnly LastUsedZoneChartMatrixPublicationDate { get; set; }

		/// <summary>
		/// Last Used Mail Direction Publication Date (CSM-1195)
		/// (cannot be all zeros) 00010101 will be the non-value when the date is not applicable.
		/// </summary>
		DateOnly LastUsedMailDirectionPublicationDate { get; set; }

		/// <summary>
		/// Supplemental Physical Container ID (CSM-1196)
		/// (use CSM-1006 of Physical Parent record) This field can be used in two ways, both of which are
		/// optional. The first definition is meant for use in logical tray scenarios or overflow scenarios,
		/// where the field can be used to describe the relationship between a physical tray and its physical
		/// parent container. The second definition is meant for use with logical bundle-based mailings, where
		/// the field can be used to describe the relationship between logical trays when bundles of mail are
		/// relocated. These two models of usage do not conflict with each other because the first definition
		/// can only be used for a physical or sibling tray, and the second definition can only be used for a
		/// logical tray. If neither of these usage models applies for your mailing, the field should remain
		/// blank in your CSM records. Definition 1: (For linkage between physical trays and physical parent
		/// containers, use CSM-1006 of the physical parent container on which the physical tray resides)
		/// Container ID of the Physical Parent Container in which this physical tray or sibling tray resides,
		/// if such relationship exists. Blank if no such relationship This is an optional field and can be used
		/// to associate either a physical or a sibling handling unit to the actual container that it is on but
		/// only under specific circumstances: When the container it is on is a sibling to either a logical or
		/// physical master container. When the container that it is on is a physical container that has at
		/// least one sibling (as in an overflow scenario). The child-to-parent container relationship
		/// established through the use of the Parent Container Reference ID must also be used to link the
		/// master handling unit (not the sibling) to a parent. It is only through that relationship that pieces
		/// can be associated to logical container groups or physical containers with siblings. Note, when used,
		/// this describes which handling units are on which containers and does not provide any indication of
		/// which mail pieces are in which handling units or on which containers Definition 2: This definition
		/// is for FCM MLOCR bundle-based preparation. (For linkage between logical trays when using
		/// bundle-based mail and some mail bundles are relocated between two different logical trays, use
		/// CSM-1006 of the logical tray into which mail is being relocated) Container ID of another logical
		/// tray into which some mail from this logical tray has been relocated, if such relationship exists.
		/// Blank if no such relationship. This is an optional field and can be used to associate a logical tray
		/// to another logical tray when some mail has been relocated within a bundle-based mailing. The purpose
		/// is to identify such related trays in order to assist with the verification of a mailing. Note, when
		/// used, this describes relocation for an indeterminate quantity of mail, and does not provide any
		/// indication of which mail pieces are relocated into the other logical tray. Unless the original
		/// logical tray record ceases to exist because all of its mail is relocated into a different logical
		/// tray, the tallying for the quantity of mail will remain with the original logical tray, and
		/// relocated mail does not add to the accumulated amount in the target logical tray for the following
		/// fields Number of Copies (CSM-1120) Number of Pieces (CSM-1121) Total Weight (CSM-1122) Container
		/// Gross Weight (CSM-1137) Note also that this means a target logical tray which receives such
		/// relocations may possibly have values of zero for the aforementioned fields, if it exists solely for
		/// the purpose of receiving such relocations.
		/// </summary>
		int? SupplementalPhysicalContainerID { get; set; }

		/// <summary>
		/// Accept Misshipped (CSM-1188)
		/// USPS field for eInduction misshipped processing support.
		/// </summary>
		string AcceptMisshipped { get; set; }

		/// <summary>
		/// Referenceable Mail Start Date (CSM-1199)
		/// Start date for the Referenceable Mail. Default to blank spaces when no constraint requested;
		/// YYYYMMDD (cannot be all zeros).
		/// </summary>
		DateOnly? ReferenceableMailStartDate { get; set; }

		/// <summary>
		/// Referenceable Mail End Date (CSM-1200)
		/// End date for the Referenceable Mail. Default to blank spaces when no constraint requested; YYYYMMDD
		/// (cannot be all zeros).
		/// </summary>
		DateOnly? ReferenceableMailEndDate { get; set; }

		/// <summary>
		/// CSM Record Status (CSM-2000)
		/// </summary>
		string CSMRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CSM-1134)
		/// </summary>
		string ReserveCSM1134 { get; set; }

		/// <summary>
		/// Closing Character (CSM-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}