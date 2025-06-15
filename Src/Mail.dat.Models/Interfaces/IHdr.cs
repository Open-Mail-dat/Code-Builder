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
	/// Who, what and when of this job.
	/// </summary>
	public interface IHdr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (HDR-1001)
		/// A Job ID (the Mail.dat® serial number) should be unique compared to all other supplied Job IDs
		/// provided by the same source. The Job ID assigned to any new Mail.dat® is that transmission; it is
		/// the Historical Job ID that retains the initial ID throughout its existence. Job IDs are user
		/// managed, but must remain unique within one User License Code.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Mail.dat Version (HDR-1101)
		/// </summary>
		string MailDatVersion { get; set; }

		/// <summary>
		/// Header History Sequence Number (HDR-1025)
		/// First Header created with initial iteration of this Mail.dat® = 9999, next iteration of this
		/// Mail.dat® as it is successively processed would have a Header with a History Sequence number = 9998,
		/// etc. Current Active Header would be next in the series, hence the record with the lowest History
		/// Sequence value. Header History Status field (see next) also denotes current active header.
		/// </summary>
		string HeaderHistorySequenceNumber { get; set; }

		/// <summary>
		/// Header History Status (HDR-1148)
		/// Transmit all history records with subsequent transmissions. C = Current (this .hdr record is
		/// applicable to current transmission) H = History (this .hdr record predates and is associated with,
		/// but not specifically applicable to, current Mail.dat® transmission) All .HDR records received for a
		/// specific Mail.dat® must be forwarded with that Mail.dat, or portion thereof, if such transmission
		/// occurs. As applicable, the received Header is updated by the Mail.dat® processor with an H in this
		/// field as it is passed along with the new Current Active Header to next recipient.
		/// </summary>
		string HeaderHistoryStatus { get; set; }

		/// <summary>
		/// Historical Job ID (HDR-1153)
		/// Populated with the applicable Job ID by party creating the currently active Header. Successive
		/// processors do not disturb this field. Successive processors will only change the Header History
		/// Status field in this record from C to H.
		/// </summary>
		string HistoricalJobId { get; set; }

		/// <summary>
		/// Licensed User's Job Number (HDR-1102)
		/// The Licensed User's (who created this iteration of Mail.dat) internal Job Number.
		/// </summary>
		string LicensedUserSJobNumber { get; set; }

		/// <summary>
		/// Job Name/Title & Issue (HDR-1103)
		/// Applicable Job, Title-Issue, Campaign Name, or description.
		/// </summary>
		string JobNameTitleIssue { get; set; }

		/// <summary>
		/// File Source (HDR-1104)
		/// Name of the originator supplying the files.
		/// </summary>
		string FileSource { get; set; }

		/// <summary>
		/// User License Code (HDR-1105)
		/// ULC of party creating this iteration of Mail.dat Must - begin with an alpha, be four characters,
		/// have no spaces, have no special characters, not be case sensitive.
		/// </summary>
		string UserLicenseCode { get; set; }

		/// <summary>
		/// Contact Name (HDR-1106)
		/// Ex: John Smith. Name of individual for contact support at originator of this file.
		/// </summary>
		string ContactName { get; set; }

		/// <summary>
		/// Contact Telephone Number (HDR-1107)
		/// Phone of individual listed in Contact Name (ex: 9999999999) Ex: 9999999999.
		/// </summary>
		string ContactTelephoneNumber { get; set; }

		/// <summary>
		/// Contact Email (HDR-1157)
		/// Email address of who created this iteration of Mail.dat.
		/// </summary>
		string ContactEmail { get; set; }

		/// <summary>
		/// Date Prepared (HDR-1108)
		/// Date originator transmitted this file.
		/// </summary>
		DateOnly DatePrepared { get; set; }

		/// <summary>
		/// Time Prepared (HDR-1109)
		/// (Ex: 18:12). Time of Day originator transmitted this file (ex 19:34).
		/// </summary>
		TimeOnly TimePrepared { get; set; }

		/// <summary>
		/// Mail.dat Revision (HDR-1192)
		/// </summary>
		string MailDatRevision { get; set; }

		/// <summary>
		/// Segment Record Count (HDR-1111)
		/// The number of Segment records in this Mail.dat. Transmitting multiple Segments within one Mail.dat®
		/// is an expected behavior within this specification.
		/// </summary>
		int SegmentRecordCount { get; set; }

		/// <summary>
		/// Segment File Status (HDR-1112)
		/// In this field, and all following Status fields, O, D, R and N describe action upon an entire file. C
		/// and U indicate that only individual records are modified.
		/// </summary>
		string SegmentFileStatus { get; set; }

		/// <summary>
		/// Mail Piece Unit Record Count (HDR-1113)
		/// The number of Mail Piece Unit records in this Mail.dat.
		/// </summary>
		int MailPieceUnitRecordCount { get; set; }

		/// <summary>
		/// Mail Piece Unit File Status (HDR-1114)
		/// </summary>
		string MailPieceUnitFileStatus { get; set; }

		/// <summary>
		/// MPU / C Relationship Record Count (HDR-1115)
		/// The number of MPU / C Relationship records in this Mail.dat.
		/// </summary>
		int MpuCRelationshipRecordCount { get; set; }

		/// <summary>
		/// MPU / C Relationship File Status (HDR-1116)
		/// </summary>
		string MpuCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Mailer Postage Account Record Count (HDR-1158)
		/// The number of Mailer's Postage Account records in this Mail.dat.
		/// </summary>
		int MailerPostageAccountRecordCount { get; set; }

		/// <summary>
		/// Mailer Postage Account File Status (HDR-1159)
		/// </summary>
		string MailerPostageAccountFileStatus { get; set; }

		/// <summary>
		/// Component Record Count (HDR-1118)
		/// The number of Component records in this Mail.dat.
		/// </summary>
		int ComponentRecordCount { get; set; }

		/// <summary>
		/// Component File Status (HDR-1119)
		/// </summary>
		string ComponentFileStatus { get; set; }

		/// <summary>
		/// Component Characteristic Record Count (HDR-1181)
		/// The number of Component Characteristics records in this Mail.dat.
		/// </summary>
		int ComponentCharacteristicRecordCount { get; set; }

		/// <summary>
		/// Component Characteristic File Status (HDR-1180)
		/// </summary>
		string ComponentCharacteristicFileStatus { get; set; }

		/// <summary>
		/// Container Summary Record Count (HDR-1120)
		/// The number of Container Summary records in this Mail.dat.
		/// </summary>
		int ContainerSummaryRecordCount { get; set; }

		/// <summary>
		/// Container Summary File Status (HDR-1121)
		/// </summary>
		string ContainerSummaryFileStatus { get; set; }

		/// <summary>
		/// Container Quantity Record Count (HDR-1126)
		/// The number of Container Quantity records in this Mail.dat.
		/// </summary>
		int ContainerQuantityRecordCount { get; set; }

		/// <summary>
		/// Container Quantity File Status (HDR-1127)
		/// </summary>
		string ContainerQuantityFileStatus { get; set; }

		/// <summary>
		/// Package Quantity Record Count (HDR-1128)
		/// The number of Package Quantity records in this Mail.dat.
		/// </summary>
		int PackageQuantityRecordCount { get; set; }

		/// <summary>
		/// Package Quantity File Status (HDR-1129)
		/// </summary>
		string PackageQuantityFileStatus { get; set; }

		/// <summary>
		/// Walk Sequence Record Count (HDR-1130)
		/// The number of Walk Sequence records in this Mail.dat.
		/// </summary>
		int WalkSequenceRecordCount { get; set; }

		/// <summary>
		/// Walk Sequence File Status (HDR-1131)
		/// </summary>
		string WalkSequenceFileStatus { get; set; }

		/// <summary>
		/// Seed Name Record Count (HDR-1132)
		/// The number of Seed Name records in this Mail.dat.
		/// </summary>
		int SeedNameRecordCount { get; set; }

		/// <summary>
		/// Seed Name File Status (HDR-1133)
		/// </summary>
		string SeedNameFileStatus { get; set; }

		/// <summary>
		/// IJ / C Relationship Record Count (HDR-1136)
		/// The number of Ink Jet/Container Relationship records in this Mail.dat.
		/// </summary>
		int IJCRelationshipRecordCount { get; set; }

		/// <summary>
		/// IJ / C Relationship File Status (HDR-1137)
		/// </summary>
		string IJCRelationshipFileStatus { get; set; }

		/// <summary>
		/// Piece Detail Record Count (HDR-1138)
		/// The number of Piece Detail records in this Mail.dat.
		/// </summary>
		int PieceDetailRecordCount { get; set; }

		/// <summary>
		/// Piece Detail File Status (HDR-1139)
		/// </summary>
		string PieceDetailFileStatus { get; set; }

		/// <summary>
		/// Piece Barcode Record Count (HDR-1178)
		/// The number of Piece barcode records in this Mail.dat.
		/// </summary>
		int PieceBarcodeRecordCount { get; set; }

		/// <summary>
		/// Piece Barcode File Status (HDR-1179)
		/// </summary>
		string PieceBarcodeFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Record Count (HDR-1140)
		/// The number of Special Fees/Charges records in this Mail.dat.
		/// </summary>
		int SpecialFeeChargeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge File Status (HDR-1141)
		/// </summary>
		string SpecialFeeChargeFileStatus { get; set; }

		/// <summary>
		/// Postage Adjustment Record Count (HDR-1146)
		/// The number of Postage Adjustment records in this Mail.dat.
		/// </summary>
		int PostageAdjustmentRecordCount { get; set; }

		/// <summary>
		/// Postage Adjustment File Status (HDR-1147)
		/// </summary>
		string PostageAdjustmentFileStatus { get; set; }

		/// <summary>
		/// Original Container Identification Record Count (HDR-1172)
		/// The number of Original Container Identification records in this Mail.dat.
		/// </summary>
		int OriginalContainerIdentificationRecordCount { get; set; }

		/// <summary>
		/// Original Container Identification File Status (HDR-1173)
		/// </summary>
		string OriginalContainerIdentificationFileStatus { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address Record Count (HDR-1184)
		/// The number of original Un-coded parcel address Records in this Mail.dat.
		/// </summary>
		int UnCodedParcelAddressRecordCount { get; set; }

		/// <summary>
		/// Un-Coded Parcel Address File Status (HDR-1185)
		/// </summary>
		string UnCodedParcelAddressFileStatus { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Record Count (HDR-1186)
		/// The number of Special Fees/Charges Barcode records in this Mail.dat.
		/// </summary>
		int SpecialFeeChargeBarcodeRecordCount { get; set; }

		/// <summary>
		/// Special Fee/Charge Barcode Status (HDR-1187)
		/// </summary>
		string SpecialFeeChargeBarcodeStatus { get; set; }

		/// <summary>
		/// Extra Piece Detail Record Count (HDR-1188)
		/// The number of Extra Piece Detail records in this Mail.dat.
		/// </summary>
		int ExtraPieceDetailRecordCount { get; set; }

		/// <summary>
		/// Extra Piece Detail Status (HDR-1189)
		/// </summary>
		string ExtraPieceDetailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Record Count (HDR-1190)
		/// The number of referenceable mail records in this Mail.dat.
		/// </summary>
		int ReferenceableMailRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Status (HDR-1191)
		/// </summary>
		string ReferenceableMailStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Record Count (HDR-1193)
		/// The number of referenceable mail summary records in this Mail.dat.
		/// </summary>
		int ReferenceableMailSummaryRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Summary Status (HDR-1194)
		/// </summary>
		string ReferenceableMailSummaryStatus { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Record Count (HDR-1195)
		/// The number of referenceable mail barcode records in this Mail.dat.
		/// </summary>
		int ReferenceableMailBarcodeRecordCount { get; set; }

		/// <summary>
		/// Referenceable Mail Barcode Status (HDR-1196)
		/// </summary>
		string ReferenceableMailBarcodeStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Header Record Count (HDR-1201)
		/// The number of Certificate of Mailing Header records in this Mail.dat.
		/// </summary>
		int CertificateOfMailingHeaderRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Header Status (HDR-1202)
		/// </summary>
		string CertificateOfMailingHeaderStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Record Count (HDR-1203)
		/// The number of certificate of mailing detail records in this Mail.dat.
		/// </summary>
		int CertificateOfMailingDetailRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Detail Status (HDR-1204)
		/// </summary>
		string CertificateOfMailingDetailStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Record Count (HDR-1205)
		/// The number of certificate of mailing bulk records in this Mail.dat.
		/// </summary>
		int CertificateOfMailingBulkRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Bulk Status (HDR-1206)
		/// </summary>
		string CertificateOfMailingBulkStatus { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Record Count (HDR-1207)
		/// The number of certificate of mailing services records in this Mail.dat.
		/// </summary>
		int CertificateOfMailingServicesRecordCount { get; set; }

		/// <summary>
		/// Certificate of Mailing Services Status (HDR-1208)
		/// </summary>
		string CertificateOfMailingServicesStatus { get; set; }

		/// <summary>
		/// Mail.dat Presentation Category (HDR-1154)
		/// </summary>
		string MailDatPresentationCategory { get; set; }

		/// <summary>
		/// Original Software Vendor Name (HDR-1174)
		/// Originator company name of this Mail.dat.
		/// </summary>
		string OriginalSoftwareVendorName { get; set; }

		/// <summary>
		/// Original Software Products Name (HDR-1175)
		/// Originator product name of this Mail.dat.
		/// </summary>
		string OriginalSoftwareProductsName { get; set; }

		/// <summary>
		/// Original Software Version (HDR-1176)
		/// Originator software version of this Mail.dat.
		/// </summary>
		string OriginalSoftwareVersion { get; set; }

		/// <summary>
		/// Original Software Vendor's Email (HDR-1177)
		/// Originator software company email address.
		/// </summary>
		string OriginalSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor Name (HDR-1150)
		/// May be name of in-house proprietary software. Name of author of software creating the Mail.dat® as
		/// appended to this respective .hdr record. This may be the name of the transmitting agent, if they
		/// wrote their own proprietary home-grown software.
		/// </summary>
		string MailDatSoftwareVendorName { get; set; }

		/// <summary>
		/// Mail.dat Software Product's Name (HDR-1155)
		/// Name of product creating this Header and applicable data in associated records.
		/// </summary>
		string MailDatSoftwareProductSName { get; set; }

		/// <summary>
		/// Mail.dat Software Version (HDR-1151)
		/// Version of the software creating the transmitted Mail.dat.
		/// </summary>
		string MailDatSoftwareVersion { get; set; }

		/// <summary>
		/// Mail.dat Software Vendor's Email (HDR-1156)
		/// Email address of party creating product named above.
		/// </summary>
		string MailDatSoftwareVendorSEmail { get; set; }

		/// <summary>
		/// Zone Matrix Date (HDR-1160)
		/// (cannot be all zeros).
		/// </summary>
		string ZoneMatrixDate { get; set; }

		/// <summary>
		/// eDoc Sender CRID (HDR-1183)
		/// This USPS-assigned id, CRID, will be used by the USPS to uniquely identify the submitter of
		/// electronic documentation to the PostalOne! system. This field will be used to identify a new
		/// business role, called the eDoc submitter, which may be different from the mail preparer, mail owner,
		/// mail transporter, and scheduler roles. Only digits 0-9 acceptable.
		/// </summary>
		string EDocSenderCrid { get; set; }

		/// <summary>
		/// Information Exchange (HDR-1182)
		/// This field is for the exchange of private information between sender and catcher.
		/// </summary>
		string InformationExchange { get; set; }

		/// <summary>
		/// User Option Field (HDR-1152)
		/// Available for customer data for unique user application.
		/// </summary>
		string UserOptionField { get; set; }

		/// <summary>
		/// Closing Character (HDR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}