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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Identifies specific mail list supplied for this job.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "seg", File = "Segment Record", Summary = "Identifies specific mail list supplied for this job.", Description = "Identifies specific mail list supplied for this job.", LineLength = 277, ClosingCharacter = "#")]
	[Table("Seg", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 2)]
	public partial class Seg : MaildatEntity, ISeg 
	{
		/// <summary>
		/// Job ID (SEG-1001)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("SEG-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

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
		[MaildatField(Extension = "seg", FieldCode = "SEG-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = true, DataType = "A/N", Description = "In the event of Multiple presorts supplied under common Job ID, the Segment ID Must differentiate each subordinate presorts from the others. A Segment is a mailing facility production run within a job. Therefore, the Segment ID is a code representing a version, String, list, etc. In general, the fewer the segments within a Mail.dat® the better. It is only appropriate to create a unique Segment when it is needed to separate part of a mailing for different Processing. For instance, a portion of a mailing might need to have An invoice attached in an off-line operation, or the bulk copies of A Periodical might need to be prepared in cartons. Another example Might be different versions of a catalog, which cannot be produced, In a selective binding process. In such cases, individual segments Could be appropriate. Segmenting should not be used to differentiate Among entry points unless they will need to be processed in some Fundamentally different fashion. Similarly, segmentation should not Be used to create reporting categories from information that is Otherwise available in the Mail.dat. A good example of proper Segmentation would be one segment for domestic mail and one segment For USPS International, not a separate Segment for each entry point.", Type = "string", Format = "zfillnumeric")]
		[Column("SegmentID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(4)]
		[Comment("SEG-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SegmentID { get; set; }

		/// <summary>
		/// Segment Description (SEG-1101)
		/// Segmentation should be at single mail stream level, (not higher or Lower specific hierarchy).
		/// Describe string, list, mail-stream Characteristics which this particular set of names exhibits.
		/// Example for a single list Segment: Spring - Remail, prospects, $10 Off Example of a selective bind
		/// Segment: Spring - Remail, all versions.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1101", FieldName = "Segment Description", Start = 13, Length = 60, Required = false, Key = false, DataType = "A/N", Description = "Segmentation should be at single mail stream level, (not higher or Lower specific hierarchy). Describe string, list, mail-stream Characteristics which this particular set of names exhibits. Example for a single list Segment: Spring - Remail, prospects, $10 Off Example of a selective bind Segment: Spring - Remail, all versions.", Type = "string", Format = "leftjustify")]
		[Column("SegmentDescription", Order = 4, TypeName = "TEXT")]
		[MaxLength(60)]
		[Comment("SEG-1101")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SegmentDescription { get; set; }

		/// <summary>
		/// Class Defining Preparation (SEG-1102)
		/// This is the USPS Class that will define preparation criteria as well As postage rates for pieces
		/// within this Mail.dat. Although generally Obvious, this needs to be specified especially for such
		/// instances as: Periodicals with Standard Mail Enclosure and Periodicals with First Class Enclosure.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1102", FieldName = "Class Defining Preparation", Start = 73, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This is the USPS Class that will define preparation criteria as well As postage rates for pieces within this Mail.dat. Although generally Obvious, this needs to be specified especially for such instances as: Periodicals with Standard Mail Enclosure and Periodicals with First Class Enclosure.", Type = "enum", Format = "leftjustify")]
		[Column("ClassDefiningPreparation", Order = 5, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("1", "2", "3", "4", "6", "9")]
		[Comment("SEG-1102")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ClassDefiningPreparation { get; set; }

		/// <summary>
		/// Principal Processing Category (SEG-1103)
		/// This label describes the physical processing category the mail piece(s) Qualify, which determines
		/// preparation and prices.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1103", FieldName = "Principal Processing Category", Start = 74, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "This label describes the physical processing category the mail piece(s) Qualify, which determines preparation and prices.", Type = "enum", Format = "leftjustify")]
		[Column("PrincipalProcessingCategory", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("CD", "CM", "FL", "IR", "LT", "MP", "PF")]
		[Comment("SEG-1103")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PrincipalProcessingCategory { get; set; }

		/// <summary>
		/// Substituted Container Prep (SEG-1110)
		/// This field notes if, for production reasons, an alternate container is Used for the preparation and
		/// submission of the mailing; such as, Sacking an automated Letter. (See Scenario).
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1110", FieldName = "Substituted Container Prep", Start = 76, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "This field notes if, for production reasons, an alternate container is Used for the preparation and submission of the mailing; such as, Sacking an automated Letter. (See Scenario).", Type = "enum", Format = "leftjustify")]
		[Column("SubstitutedContainerPrep", Order = 7, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("S", "T")]
		[Comment("SEG-1110")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string SubstitutedContainerPrep { get; set; }

		/// <summary>
		/// Periodicals Newspaper Treatment (SEG-1111)
		/// This field notes if the Periodicals publication is eligible for Newspaper handling.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1111", FieldName = "Periodicals Newspaper Treatment", Start = 77, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "This field notes if the Periodicals publication is eligible for Newspaper handling.", Type = "enum", Format = "leftjustify")]
		[Column("PeriodicalsNewspaperTreatment", Order = 8, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("SEG-1111")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PeriodicalsNewspaperTreatment { get; set; }

		/// <summary>
		/// Logical/Physical CONTAINER Indicator (SEG-1112)
		/// This field indicates the presence of logical container types in the CSM. When populated with L =
		/// Logical at least one container Must be logical (M, L) otherwise when populated with P, no Container
		/// type can be logical.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1112", FieldName = "Logical/Physical CONTAINER Indicator", Start = 78, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates the presence of logical container types in the CSM. When populated with L = Logical at least one container Must be logical (M, L) otherwise when populated with P, no Container type can be logical.", Type = "enum", Format = "leftjustify")]
		[Column("LogicalPhysicalCONTAINERIndicator", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("L", "P")]
		[Comment("SEG-1112")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string LogicalPhysicalCONTAINERIndicator { get; set; }

		/// <summary>
		/// Log/Phy PACKAGE Indicator (SEG-1113)
		/// This field indicates whether the package record within the Mail.dat® presents logical or physical
		/// packages. A logical package Would be one record representing the 108 pieces that are all going To
		/// the same carrier route. If presented as physical packages those Same 108 pieces might be presented
		/// as five records; representing 25, 25, 25, 17 and 16 pieces, respectively. This field is required,
		/// And must be completed even if the Package Quantity records are Not being transmitted for the
		/// particular Mail.dat.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1113", FieldName = "Log/Phy PACKAGE Indicator", Start = 79, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "This field indicates whether the package record within the Mail.dat® presents logical or physical packages. A logical package Would be one record representing the 108 pieces that are all going To the same carrier route. If presented as physical packages those Same 108 pieces might be presented as five records; representing 25, 25, 25, 17 and 16 pieces, respectively. This field is required, And must be completed even if the Package Quantity records are Not being transmitted for the particular Mail.dat.", Type = "enum", Format = "leftjustify")]
		[Column("LogPhyPACKAGEIndicator", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("L", "P")]
		[Comment("SEG-1113")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string LogPhyPACKAGEIndicator { get; set; }

		/// <summary>
		/// LOT Database Date (SEG-1116)
		/// YYYYMMDD (cannot be all zeros) Date of LOT database. This Field only to be populated if LOT step
		/// done in presort step. 00010101 will be the non-value if no date available. Must have a valid date
		/// for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of
		/// non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1116", FieldName = "LOT Database Date", Start = 80, Length = 8, Required = true, Key = false, DataType = "N", Description = "YYYYMMDD (cannot be all zeros) Date of LOT database. This Field only to be populated if LOT step done in presort step. 00010101 will be the non-value if no date available. Must have a valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.", Type = "date", Format = "YYYYMMDD")]
		[Column("LOTDatabaseDate", Order = 11, TypeName = "TEXT")]
		[Required]
		[Comment("SEG-1116")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly LOTDatabaseDate { get; set; }

		/// <summary>
		/// Verification Facility Name (SEG-1118)
		/// Name of Mailing Facility where verification occurs.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1118", FieldName = "Verification Facility Name", Start = 88, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "Name of Mailing Facility where verification occurs.", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityName", Order = 12, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("SEG-1118")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string VerificationFacilityName { get; set; }

		/// <summary>
		/// Verification Facility ZIP Code (SEG-1119)
		/// ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the
		/// DMU).
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1119", FieldName = "Verification Facility ZIP Code", Start = 118, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "ZIP Code of Post Office where postage statement will be finalized (the associated BMEU, not the DMU).", Type = "string", Format = "leftjustify")]
		[Column("VerificationFacilityZIPCode", Order = 13, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("SEG-1119")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string VerificationFacilityZIPCode { get; set; }

		/// <summary>
		/// L.O.T. Direction Indicator (SEG-1122)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1122", FieldName = "L.O.T. Direction Indicator", Start = 127, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("LOTDirectionIndicator", Order = 14, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("F", "R")]
		[Comment("SEG-1122")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string LOTDirectionIndicator { get; set; }

		/// <summary>
		/// Barcode Verifier Indicator (SEG-1123)
		/// (MLOCR indicator).
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1123", FieldName = "Barcode Verifier Indicator", Start = 128, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "(MLOCR indicator).", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeVerifierIndicator", Order = 15, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("SEG-1123")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string BarcodeVerifierIndicator { get; set; }

		/// <summary>
		/// Package Services Packaging Criteria (SEG-1128)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1128", FieldName = "Package Services Packaging Criteria", Start = 129, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("PackageServicesPackagingCriteria", Order = 16, TypeName = "TEXT")]
		[MaxLength(2)]
		[AllowedValues("CB", "PC", "PD")]
		[Comment("SEG-1128")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string PackageServicesPackagingCriteria { get; set; }

		/// <summary>
		/// Automation Coding Date (SEG-1129)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1129", FieldName = "Automation Coding Date", Start = 131, Length = 8, Required = true, Key = false, DataType = "N", Description = "YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.", Type = "date", Format = "YYYYMMDD")]
		[Column("AutomationCodingDate", Order = 17, TypeName = "TEXT")]
		[Required]
		[Comment("SEG-1129")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly AutomationCodingDate { get; set; }

		/// <summary>
		/// Carrier Route Coding Date (SEG-1130)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1130", FieldName = "Carrier Route Coding Date", Start = 139, Length = 8, Required = true, Key = false, DataType = "N", Description = "YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.", Type = "date", Format = "YYYYMMDD")]
		[Column("CarrierRouteCodingDate", Order = 18, TypeName = "TEXT")]
		[Required]
		[Comment("SEG-1130")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly CarrierRouteCodingDate { get; set; }

		/// <summary>
		/// Carrier Route Sequencing Date (SEG-1131)
		/// YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a
		/// valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101.
		/// Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1131", FieldName = "Carrier Route Sequencing Date", Start = 147, Length = 8, Required = true, Key = false, DataType = "N", Description = "YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of non- Value may jeopardize rate eligibility. In case of multiple dates, use The oldest date.", Type = "date", Format = "YYYYMMDD")]
		[Column("CarrierRouteSequencingDate", Order = 19, TypeName = "TEXT")]
		[Required]
		[Comment("SEG-1131")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly CarrierRouteSequencingDate { get; set; }

		/// <summary>
		/// Move Update Date (SEG-1134)
		/// Oldest date on which any portion of the mail file represented by This Segment was updated in accord
		/// with Move Update policy. YYYYMMDD (cannot be all zeros).
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1134", FieldName = "Move Update Date", Start = 155, Length = 8, Required = false, Key = false, DataType = "N", Description = "Oldest date on which any portion of the mail file represented by This Segment was updated in accord with Move Update policy. YYYYMMDD (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("MoveUpdateDate", Order = 20, TypeName = "TEXT")]
		[Comment("SEG-1134")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? MoveUpdateDate { get; set; }

		/// <summary>
		/// Detached Mailing Label Indicator (SEG-1136)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1136", FieldName = "Detached Mailing Label Indicator", Start = 163, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("DetachedMailingLabelIndicator", Order = 21, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B")]
		[Comment("SEG-1136")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string DetachedMailingLabelIndicator { get; set; }

		/// <summary>
		/// eDoc Sender CRID (SEG-1140)
		/// This USPS-assigned id, CRID, will be used by the industry to identify the Originator of the Segment.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1140", FieldName = "EDoc Sender CRID", Start = 164, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used by the industry to identify the Originator of the Segment.", Type = "string", Format = "leftjustify")]
		[Column("EDocSenderCRID", Order = 22, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("SEG-1140")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string EDocSenderCRID { get; set; }

		/// <summary>
		/// Container and Bundle Charge Method (SEG-1141)
		/// This field identifies how to calculate periodical charges.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1141", FieldName = "Container and Bundle Charge Method", Start = 176, Length = 1, Required = true, Key = false, DataType = "N", Description = "This field identifies how to calculate periodical charges.", Type = "enum", Format = "zfill")]
		[Column("ContainerAndBundleChargeMethod", Order = 23, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("0", "1", "2", "3")]
		[Comment("SEG-1141")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ContainerAndBundleChargeMethod { get; set; }

		/// <summary>
		/// MPA ID for Container and Bundle Charge Method (SEG-1142)
		/// MPA Identifier that will be used to allocate the container and bundle Charges for the segment if ALL
		/// containers and/or bundles are Charged to a single payer. Note: This value should only be entered if
		/// the Container and Bundle Charge Method is 1 or 2 Unique identifier for the respective MPA within an
		/// MPU. Establishes the set of MPU copies on one Postage Statement.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1142", FieldName = "MPA ID for Container and Bundle Charge Method", Start = 177, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "MPA Identifier that will be used to allocate the container and bundle Charges for the segment if ALL containers and/or bundles are Charged to a single payer. Note: This value should only be entered if the Container and Bundle Charge Method is 1 or 2 Unique identifier for the respective MPA within an MPU. Establishes the set of MPU copies on one Postage Statement.", Type = "string", Format = "zfillnumeric")]
		[Column("MPAIDForContainerAndBundleChargeMethod", Order = 24, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("SEG-1142")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string MPAIDForContainerAndBundleChargeMethod { get; set; }

		/// <summary>
		/// Less Than a Presort Segment Presentation (SEG-1145)
		/// This field identifies Full or partial presort segment presentation.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1145", FieldName = "Less Than a Presort Segment Presentation", Start = 187, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "This field identifies Full or partial presort segment presentation.", Type = "enum", Format = "leftjustify")]
		[Column("LessThanAPresortSegmentPresentation", Order = 25, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("SEG-1145")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string LessThanAPresortSegmentPresentation { get; set; }

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
		[MaildatField(Extension = "seg", FieldCode = "SEG-1146", FieldName = "Full-Service Participation Indicator", Start = 188, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Mixed (Basic and Full Mixed) Mail Owners/Mailing Agents will be required to use the Intelligent Mail® Barcode on their letter and flat mail pieces in place of the routing ZIP ® Barcode. At a minimum, this barcode will include the same delivery point Information that is included in the routing ZIP® barcode today, an assigned Mailer ID, the class of mail, and optional endorsement line (OEL) Information, if an OEL is printed on the mail piece. Mail Owners/Mailing Agents using pressure sensitive bar-coded presort labels will not be Required to include this information in the Intelligent Mail® barcode. For Basic-option the Mail Owners/Agents do not need to provide piece detail Electronic information. Full Service Option Under the Full Service option, Mail Owners/Mailing Agents will be Required to apply Intelligent Mail® barcodes on their letter and flat mail Pieces, trays and sacks, and other containers. Mailers will also be required To submit their postage statements and mailing documentation electronically. For drop-ship mailings and all origin-entered mail verified at A detached mail unit (DMU), Mail Owners/Mailing Agents will be required To schedule electronic appointments using the Facility Access and Shipment Tracking (FAST) system.", Type = "enum", Format = "leftjustify")]
		[Column("FullServiceParticipationIndicator", Order = 26, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "F", "M")]
		[Comment("SEG-1146")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string FullServiceParticipationIndicator { get; set; }

		/// <summary>
		/// Move Update Method (SEG-1147)
		/// This field is used to identify Move Update method at the postage statement level.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1147", FieldName = "Move Update Method", Start = 189, Length = 1, Required = false, Key = false, DataType = "N", Description = "This field is used to identify Move Update method at the postage statement level.", Type = "enum", Format = "zfill")]
		[Column("MoveUpdateMethod", Order = 27, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues("0", "1", "2", "4", "5", "6", "7", "8")]
		[Comment("SEG-1147")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MoveUpdateMethod { get; set; }

		/// <summary>
		/// Delivery Statistics File Date (SEG-1150)
		/// Required - YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must
		/// have a valid date for automation and/or carrier route mail, Otherwise populate with default value
		/// 00010101. Use of non- value may Jeopardize rate eligibility. Date when the Delivery Statistics file
		/// was used for Reporting on the postage statements. In the case of multiple delivery statistics File
		/// dates, the oldest date should be used for populating this field.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1150", FieldName = "Delivery Statistics File Date", Start = 190, Length = 8, Required = true, Key = false, DataType = "N", Description = "Required - YYYYMMDD (cannot be all zeros) 00010101 will be the non-value if no date available. Must have a valid date for automation and/or carrier route mail, Otherwise populate with default value 00010101. Use of non- value may Jeopardize rate eligibility. Date when the Delivery Statistics file was used for Reporting on the postage statements. In the case of multiple delivery statistics File dates, the oldest date should be used for populating this field.", Type = "date", Format = "YYYYMMDD")]
		[Column("DeliveryStatisticsFileDate", Order = 28, TypeName = "TEXT")]
		[Required]
		[Comment("SEG-1150")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly DeliveryStatisticsFileDate { get; set; }

		/// <summary>
		/// Informed Address Indicator (SEG-1187)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1187", FieldName = "Informed Address Indicator", Start = 198, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("InformedAddressIndicator", Order = 29, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("N", "Y")]
		[Comment("SEG-1187")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string InformedAddressIndicator { get; set; }

		/// <summary>
		/// Informed Address Expiration Date (SEG-1186)
		/// Should have a valid date when Informed Address pieces are in the mailing, in The YYYYMMDD format
		/// (Cannot be all zeroes). In case of multiple Expiration dates, use the oldest date.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1186", FieldName = "Informed Address Expiration Date", Start = 199, Length = 8, Required = false, Key = false, DataType = "N", Description = "Should have a valid date when Informed Address pieces are in the mailing, in The YYYYMMDD format (Cannot be all zeroes). In case of multiple Expiration dates, use the oldest date.", Type = "date", Format = "YYYYMMDD")]
		[Column("InformedAddressExpirationDate", Order = 30, TypeName = "TEXT")]
		[Comment("SEG-1186")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? InformedAddressExpirationDate { get; set; }

		/// <summary>
		/// Information Exchange (SEG-1182)
		/// See definition in HDR.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1182", FieldName = "Information Exchange", Start = 207, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "See definition in HDR.", Type = "string", Format = "leftjustify", References = "HDR-1182")]
		[Column("InformationExchange", Order = 31, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("SEG-1182")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string InformationExchange { get; set; }

		/// <summary>
		/// User Option Field (SEG-1126)
		/// Available for customer data for unique user application.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1126", FieldName = "User Option Field", Start = 227, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "Available for customer data for unique user application.", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 32, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("SEG-1126")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string UserOptionField { get; set; }

		/// <summary>
		/// Mailing Agreement Type (SEG-1139)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1139", FieldName = "Mailing Agreement Type", Start = 247, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("MailingAgreementType", Order = 33, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "A", "B", "C", "D", "E", "F", "G", "H")]
		[Comment("SEG-1139")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string MailingAgreementType { get; set; }

		/// <summary>
		/// FCM Letter Residual Preparation Indicator (SEG-1183)
		/// M = Mixed (the statements in the segment have residual pieces with less than or Equal to 3.5 ounces
		/// Blank = Separated or Not applicable (if the statements in the segment have Residual pieces with less
		/// than or equal to 3.5 oz then they are separated in Containers/trays; otherwise this field is not
		/// applicable.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1183", FieldName = "FCM Letter Residual Preparation Indicator", Start = 248, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "M = Mixed (the statements in the segment have residual pieces with less than or Equal to 3.5 ounces Blank = Separated or Not applicable (if the statements in the segment have Residual pieces with less than or equal to 3.5 oz then they are separated in Containers/trays; otherwise this field is not applicable.", Type = "enum", Format = "leftjustify")]
		[Column("FCMLetterResidualPreparationIndicator", Order = 34, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "M")]
		[Comment("SEG-1183")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string FCMLetterResidualPreparationIndicator { get; set; }

		/// <summary>
		/// Handling Unit Uniqueness Manager CRID (SEG-1184)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining
		/// handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1184", FieldName = "Handling Unit Uniqueness Manager CRID", Start = 249, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("HandlingUnitUniquenessManagerCRID", Order = 35, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("SEG-1184")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string HandlingUnitUniquenessManagerCRID { get; set; }

		/// <summary>
		/// Container Uniqueness Manager CRID (SEG-1185)
		/// This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining
		/// handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1185", FieldName = "Container Uniqueness Manager CRID", Start = 261, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "This USPS-assigned id, CRID, will be used to uniquely identify the party Responsible for maintaining handling unit uniqueness. Left justify, space padded To the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("ContainerUniquenessManagerCRID", Order = 36, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("SEG-1185")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ContainerUniquenessManagerCRID { get; set; }

		/// <summary>
		/// SEG Record Status (SEG-2000)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-2000", FieldName = "SEG Record Status", Start = 273, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("SEGRecordStatus", Order = 37, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("SEG-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string SEGRecordStatus { get; set; }

		/// <summary>
		/// Reserve (SEG-1127)
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-1127", FieldName = "Reserve", Start = 274, Length = 3, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("ReserveSEG1127", Order = 38, TypeName = "TEXT")]
		[MaxLength(3)]
		[Comment("SEG-1127")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReserveSEG1127 { get; set; }

		/// <summary>
		/// Closing Character (SEG-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "seg", FieldCode = "SEG-9999", FieldName = "Closing Character", Start = 277, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 39, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("SEG-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Seg, string>(p => p.JobID, returnValue);
			this.SegmentID = line.ParseForImport<Seg, string>(p => p.SegmentID, returnValue);
			this.SegmentDescription = line.ParseForImport<Seg, string>(p => p.SegmentDescription, returnValue);
			this.ClassDefiningPreparation = line.ParseForImport<Seg, string>(p => p.ClassDefiningPreparation, returnValue);
			this.PrincipalProcessingCategory = line.ParseForImport<Seg, string>(p => p.PrincipalProcessingCategory, returnValue);
			this.SubstitutedContainerPrep = line.ParseForImport<Seg, string>(p => p.SubstitutedContainerPrep, returnValue);
			this.PeriodicalsNewspaperTreatment = line.ParseForImport<Seg, string>(p => p.PeriodicalsNewspaperTreatment, returnValue);
			this.LogicalPhysicalCONTAINERIndicator = line.ParseForImport<Seg, string>(p => p.LogicalPhysicalCONTAINERIndicator, returnValue);
			this.LogPhyPACKAGEIndicator = line.ParseForImport<Seg, string>(p => p.LogPhyPACKAGEIndicator, returnValue);
			this.LOTDatabaseDate = line.ParseForImport<Seg, DateOnly>(p => p.LOTDatabaseDate, returnValue);
			this.VerificationFacilityName = line.ParseForImport<Seg, string>(p => p.VerificationFacilityName, returnValue);
			this.VerificationFacilityZIPCode = line.ParseForImport<Seg, string>(p => p.VerificationFacilityZIPCode, returnValue);
			this.LOTDirectionIndicator = line.ParseForImport<Seg, string>(p => p.LOTDirectionIndicator, returnValue);
			this.BarcodeVerifierIndicator = line.ParseForImport<Seg, string>(p => p.BarcodeVerifierIndicator, returnValue);
			this.PackageServicesPackagingCriteria = line.ParseForImport<Seg, string>(p => p.PackageServicesPackagingCriteria, returnValue);
			this.AutomationCodingDate = line.ParseForImport<Seg, DateOnly>(p => p.AutomationCodingDate, returnValue);
			this.CarrierRouteCodingDate = line.ParseForImport<Seg, DateOnly>(p => p.CarrierRouteCodingDate, returnValue);
			this.CarrierRouteSequencingDate = line.ParseForImport<Seg, DateOnly>(p => p.CarrierRouteSequencingDate, returnValue);
			this.MoveUpdateDate = line.ParseForImport<Seg, DateOnly?>(p => p.MoveUpdateDate, returnValue);
			this.DetachedMailingLabelIndicator = line.ParseForImport<Seg, string>(p => p.DetachedMailingLabelIndicator, returnValue);
			this.EDocSenderCRID = line.ParseForImport<Seg, string>(p => p.EDocSenderCRID, returnValue);
			this.ContainerAndBundleChargeMethod = line.ParseForImport<Seg, string>(p => p.ContainerAndBundleChargeMethod, returnValue);
			this.MPAIDForContainerAndBundleChargeMethod = line.ParseForImport<Seg, string>(p => p.MPAIDForContainerAndBundleChargeMethod, returnValue);
			this.LessThanAPresortSegmentPresentation = line.ParseForImport<Seg, string>(p => p.LessThanAPresortSegmentPresentation, returnValue);
			this.FullServiceParticipationIndicator = line.ParseForImport<Seg, string>(p => p.FullServiceParticipationIndicator, returnValue);
			this.MoveUpdateMethod = line.ParseForImport<Seg, string>(p => p.MoveUpdateMethod, returnValue);
			this.DeliveryStatisticsFileDate = line.ParseForImport<Seg, DateOnly>(p => p.DeliveryStatisticsFileDate, returnValue);
			this.InformedAddressIndicator = line.ParseForImport<Seg, string>(p => p.InformedAddressIndicator, returnValue);
			this.InformedAddressExpirationDate = line.ParseForImport<Seg, DateOnly?>(p => p.InformedAddressExpirationDate, returnValue);
			this.InformationExchange = line.ParseForImport<Seg, string>(p => p.InformationExchange, returnValue);
			this.UserOptionField = line.ParseForImport<Seg, string>(p => p.UserOptionField, returnValue);
			this.MailingAgreementType = line.ParseForImport<Seg, string>(p => p.MailingAgreementType, returnValue);
			this.FCMLetterResidualPreparationIndicator = line.ParseForImport<Seg, string>(p => p.FCMLetterResidualPreparationIndicator, returnValue);
			this.HandlingUnitUniquenessManagerCRID = line.ParseForImport<Seg, string>(p => p.HandlingUnitUniquenessManagerCRID, returnValue);
			this.ContainerUniquenessManagerCRID = line.ParseForImport<Seg, string>(p => p.ContainerUniquenessManagerCRID, returnValue);
			this.SEGRecordStatus = line.ParseForImport<Seg, string>(p => p.SEGRecordStatus, returnValue);
			this.ReserveSEG1127 = line.ParseForImport<Seg, string>(p => p.ReserveSEG1127, returnValue);
			this.ClosingCharacter = line.ParseForImport<Seg, string>(p => p.ClosingCharacter, returnValue);
				this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Seg, string>(p => p.JobID));
			sb.Append(this.SegmentID.FormatForExport<Seg, string>(p => p.SegmentID));
			sb.Append(this.SegmentDescription.FormatForExport<Seg, string>(p => p.SegmentDescription));
			sb.Append(this.ClassDefiningPreparation.FormatForExport<Seg, string>(p => p.ClassDefiningPreparation));
			sb.Append(this.PrincipalProcessingCategory.FormatForExport<Seg, string>(p => p.PrincipalProcessingCategory));
			sb.Append(this.SubstitutedContainerPrep.FormatForExport<Seg, string>(p => p.SubstitutedContainerPrep));
			sb.Append(this.PeriodicalsNewspaperTreatment.FormatForExport<Seg, string>(p => p.PeriodicalsNewspaperTreatment));
			sb.Append(this.LogicalPhysicalCONTAINERIndicator.FormatForExport<Seg, string>(p => p.LogicalPhysicalCONTAINERIndicator));
			sb.Append(this.LogPhyPACKAGEIndicator.FormatForExport<Seg, string>(p => p.LogPhyPACKAGEIndicator));
			sb.Append(this.LOTDatabaseDate.FormatForExport<Seg, DateOnly>(p => p.LOTDatabaseDate));
			sb.Append(this.VerificationFacilityName.FormatForExport<Seg, string>(p => p.VerificationFacilityName));
			sb.Append(this.VerificationFacilityZIPCode.FormatForExport<Seg, string>(p => p.VerificationFacilityZIPCode));
			sb.Append(this.LOTDirectionIndicator.FormatForExport<Seg, string>(p => p.LOTDirectionIndicator));
			sb.Append(this.BarcodeVerifierIndicator.FormatForExport<Seg, string>(p => p.BarcodeVerifierIndicator));
			sb.Append(this.PackageServicesPackagingCriteria.FormatForExport<Seg, string>(p => p.PackageServicesPackagingCriteria));
			sb.Append(this.AutomationCodingDate.FormatForExport<Seg, DateOnly>(p => p.AutomationCodingDate));
			sb.Append(this.CarrierRouteCodingDate.FormatForExport<Seg, DateOnly>(p => p.CarrierRouteCodingDate));
			sb.Append(this.CarrierRouteSequencingDate.FormatForExport<Seg, DateOnly>(p => p.CarrierRouteSequencingDate));
			sb.Append(this.MoveUpdateDate.FormatForExport<Seg, DateOnly?>(p => p.MoveUpdateDate));
			sb.Append(this.DetachedMailingLabelIndicator.FormatForExport<Seg, string>(p => p.DetachedMailingLabelIndicator));
			sb.Append(this.EDocSenderCRID.FormatForExport<Seg, string>(p => p.EDocSenderCRID));
			sb.Append(this.ContainerAndBundleChargeMethod.FormatForExport<Seg, string>(p => p.ContainerAndBundleChargeMethod));
			sb.Append(this.MPAIDForContainerAndBundleChargeMethod.FormatForExport<Seg, string>(p => p.MPAIDForContainerAndBundleChargeMethod));
			sb.Append(this.LessThanAPresortSegmentPresentation.FormatForExport<Seg, string>(p => p.LessThanAPresortSegmentPresentation));
			sb.Append(this.FullServiceParticipationIndicator.FormatForExport<Seg, string>(p => p.FullServiceParticipationIndicator));
			sb.Append(this.MoveUpdateMethod.FormatForExport<Seg, string>(p => p.MoveUpdateMethod));
			sb.Append(this.DeliveryStatisticsFileDate.FormatForExport<Seg, DateOnly>(p => p.DeliveryStatisticsFileDate));
			sb.Append(this.InformedAddressIndicator.FormatForExport<Seg, string>(p => p.InformedAddressIndicator));
			sb.Append(this.InformedAddressExpirationDate.FormatForExport<Seg, DateOnly?>(p => p.InformedAddressExpirationDate));
			sb.Append(this.InformationExchange.FormatForExport<Seg, string>(p => p.InformationExchange));
			sb.Append(this.UserOptionField.FormatForExport<Seg, string>(p => p.UserOptionField));
			sb.Append(this.MailingAgreementType.FormatForExport<Seg, string>(p => p.MailingAgreementType));
			sb.Append(this.FCMLetterResidualPreparationIndicator.FormatForExport<Seg, string>(p => p.FCMLetterResidualPreparationIndicator));
			sb.Append(this.HandlingUnitUniquenessManagerCRID.FormatForExport<Seg, string>(p => p.HandlingUnitUniquenessManagerCRID));
			sb.Append(this.ContainerUniquenessManagerCRID.FormatForExport<Seg, string>(p => p.ContainerUniquenessManagerCRID));
			sb.Append(this.SEGRecordStatus.FormatForExport<Seg, string>(p => p.SEGRecordStatus));
			sb.Append(this.ReserveSEG1127.FormatForExport<Seg, string>(p => p.ReserveSEG1127));
			sb.Append(this.ClosingCharacter.FormatForExport<Seg, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}