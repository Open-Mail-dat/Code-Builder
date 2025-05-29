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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Quantity, weights and destination per container.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "csm", File = "Container Summary Record", Summary = "Quantity, weights and destination per container.", Description = "Quantity, weights and destination per container.", LineLength = 790, ClosingCharacter = "#")]
	[Table("Csm", Schema = "Maildat")]
	[PrimaryKey("Id")]
	[MaildatImport(Order = 8)]
	public partial class Csm : MaildatEntity, ICsm 
	{
		/// <summary>
		/// Job ID (CSM-1001)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Description = "", Type = "string", Format = "zfillnumeric")]
		[Column("JobID", Order = 2, TypeName = "TEXT")]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("CSM-1001")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string JobID { get; set; }

		/// <summary>
		/// Segment ID (CSM-1002)
		/// See Segment File's Segment ID definition.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1002", FieldName = "Segment ID", Start = 9, Length = 4, Required = true, Key = false, DataType = "A/N", Description = "See Segment File's Segment ID definition.", Type = "string", Format = "zfillnumeric")]
		[Column("SegmentID", Order = 3, TypeName = "TEXT")]
		[Required]
		[MaxLength(4)]
		[Comment("CSM-1002")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string SegmentID { get; set; }

		/// <summary>
		/// Container Type (CSM-1005)
		/// See Scenario for Logical/Physical Tray and Pallets in CSM, under Scenarios. (for description of Air
		/// Box, see Mail.dat Air box scenario).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1005", FieldName = "Container Type", Start = 13, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "See Scenario for Logical/Physical Tray and Pallets in CSM, under Scenarios. (for description of Air Box, see Mail.dat Air box scenario).", Type = "enum", Format = "leftjustify")]
		[Column("ContainerType", Order = 4, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("1", "2", "3", "4", "5", "A", "AB", "B", "C", "CT", "D", "E", "F", "G", "H", "L", "M", "O", "P", "R", "S", "T", "U", "V", "W", "Z")]
		[Comment("CSM-1005")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ContainerType { get; set; }

		/// <summary>
		/// Container ID (CSM-1006)
		/// Mail.dat® container serial number, used to link Mail.dat® files. Must be mutually exclusive across
		/// all Segments and Container Types of a Job ID. A unique numeric code for this container within this
		/// Job, exclusive of Container Type. This is a serial number for this container in this Mail.dat® for
		/// this Job and, as such, will be used to link to other Mail.dat® files. Must be mutually exclusive
		/// within Job. Repetitive Display Container IDs are at the discretion of the production facility
		/// receiving the respective Mail.dat.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1006", FieldName = "Container ID", Start = 15, Length = 6, Required = true, Key = true, DataType = "N", Description = "Mail.dat® container serial number, used to link Mail.dat® files. Must be mutually exclusive across all Segments and Container Types of a Job ID. A unique numeric code for this container within this Job, exclusive of Container Type. This is a serial number for this container in this Mail.dat® for this Job and, as such, will be used to link to other Mail.dat® files. Must be mutually exclusive within Job. Repetitive Display Container IDs are at the discretion of the production facility receiving the respective Mail.dat.", Type = "integer", Format = "zfill")]
		[Column("ContainerID", Order = 5, TypeName = "INTEGER")]
		[Required]
		[MaildatKey]
		[Comment("CSM-1006")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int ContainerID { get; set; }

		/// <summary>
		/// Display Container ID (CSM-1101)
		/// Meaningful (external to Mail.dat) container ID as defined by specific production application; the
		/// Postal container label.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1101", FieldName = "Display Container ID", Start = 21, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "Meaningful (external to Mail.dat) container ID as defined by specific production application; the Postal container label.", Type = "integer", Format = "zfillnumeric")]
		[Column("DisplayContainerID", Order = 6, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("CSM-1101")]
		public string DisplayContainerID { get; set; }

		/// <summary>
		/// Container Grouping Description (CSM-1102)
		/// User Defined Grouping A value that associates multiple containers for the convenience of the mailing
		/// facility.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1102", FieldName = "Container Grouping Description", Start = 27, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "User Defined Grouping A value that associates multiple containers for the convenience of the mailing facility.", Type = "string", Format = "leftjustify")]
		[Column("ContainerGroupingDescription", Order = 7, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CSM-1102")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ContainerGroupingDescription { get; set; }

		/// <summary>
		/// Container Destination Zip (CSM-1103)
		/// The 5-digit or 3-digit destination of container defined in this record. These are the same as
		/// destination 5-digit or 3-digit sack or tray label. 99999_ or 888___ CAN = A1A9Z9 Default if no ZIP
		/// or Postal Code: Left Justify; Space Added: US = USA, OT = Other These ZIP defaults are provided for
		/// use in the event that no pre-identified postal code is available. Example: newsstand or bulk copy
		/// distribution.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1103", FieldName = "Container Destination Zip", Start = 36, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "The 5-digit or 3-digit destination of container defined in this record. These are the same as destination 5-digit or 3-digit sack or tray label. 99999_ or 888___ CAN = A1A9Z9 Default if no ZIP or Postal Code: Left Justify; Space Added: US = USA, OT = Other These ZIP defaults are provided for use in the event that no pre-identified postal code is available. Example: newsstand or bulk copy distribution.", Type = "zipcode", Format = "leftjustify")]
		[Column("ContainerDestinationZip", Order = 8, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("CSM-1103")]
		[TypeConverter(typeof(MaildatZipCodeConverter))]
		public string ContainerDestinationZip { get; set; }

		/// <summary>
		/// Container Level (CSM-1104)
		/// Eligible Types: S = Sack, T = Tray, P = Pallet If single character, left justify, space added.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1104", FieldName = "Container Level", Start = 42, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "Eligible Types: S = Sack, T = Tray, P = Pallet If single character, left justify, space added.", Type = "enum", Format = "leftjustify")]
		[Column("ContainerLevel", Order = 9, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("A", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "B", "C", "D", "G", "H", "I", "J", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "Z")]
		[Comment("CSM-1104")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ContainerLevel { get; set; }

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
		[MaildatField(Extension = "csm", FieldCode = "CSM-1105", FieldName = "Entry Point for Entry Discount - PostalCode", Start = 44, Length = 6, Required = true, Key = false, DataType = "A/N", Description = "99999_, or 888___ The postal code (5-digit, or 3-digit) of the facility where the specified container is planned to enter into the Postal System. Use Labeling Lists facility's Destination Line. This information may not be known by the list processing facility. If known, the 5 or 3 position value is to be left justified with space added. Default if no Code: Left Justify; Space Added: US = USA, OT = Other If the ultimate planned Entry Point is not known (example, as would be the case with a list supplier of a Standard Mail (A) job which will be included in a Destination Entry pool), then the Origin Zip (as indicated on the Entry Point Line of the Container Label) would be used for this field.", Type = "zipcode", Format = "leftjustify")]
		[Column("EntryPointForEntryDiscountPostalCode", Order = 10, TypeName = "TEXT")]
		[Required]
		[MaxLength(6)]
		[Comment("CSM-1105")]
		[TypeConverter(typeof(MaildatZipCodeConverter))]
		public string EntryPointForEntryDiscountPostalCode { get; set; }

		/// <summary>
		/// Entry Point for Entry Discount - Facility Type (CSM-1106)
		/// Entry Point for Container Handling, used for container entry charge. The type of facility where the
		/// container is planned to enter. In some cases, this is a description of the transportation
		/// work-sharing potential. For many List Processors, Not-determined is the option. In the above values,
		/// Origin XXX (C, E, J, K, L, Q) is used to describe the facility of a specific type (XXX), which is
		/// not the destination XXX, but rather the XXX facility where mail is entering the USPS channel for
		/// induction.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1106", FieldName = "Entry Point for Entry Discount - Facility Type", Start = 50, Length = 2, Required = true, Key = false, DataType = "A/N", Description = "Entry Point for Container Handling, used for container entry charge. The type of facility where the container is planned to enter. In some cases, this is a description of the transportation work-sharing potential. For many List Processors, Not-determined is the option. In the above values, Origin XXX (C, E, J, K, L, Q) is used to describe the facility of a specific type (XXX), which is not the destination XXX, but rather the XXX facility where mail is entering the USPS channel for induction.", Type = "enum", Format = "leftjustify")]
		[Column("EntryPointForEntryDiscountFacilityType", Order = 11, TypeName = "TEXT")]
		[Required]
		[MaxLength(2)]
		[AllowedValues("A", "B", "C", "D", "E", "H", "J", "K", "L", "N", "O", "OT", "Q", "R", "S", "T")]
		[Comment("CSM-1106")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string EntryPointForEntryDiscountFacilityType { get; set; }

		/// <summary>
		/// Entry Point - Actual / Delivery -Locale Key (CSM-1167)
		/// US = LOCA12345 (LOC plus 6 bytes of the Locale key from the drop ship product); 'ORIGIN' for origin
		/// entered mail; OT = Other The field can have a Locale key for origin entered mail when USPS Pick Up
		/// is equal to N. See Scenarios and Definitions Sections for alternatives for populating this field.
		/// Use value of 'ORIGIN' for Origin/DMU Entered mail OR for US Drop Ship, Zone Skipped, and BMEU
		/// entered Mail use the Locale Key (LOC in the first 3 bytes, balance is the 6-byte of the USPS
		/// dropsite key, also known as the Locale Key).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1167", FieldName = "Entry Point - Actual / Delivery -Locale Key", Start = 52, Length = 9, Required = true, Key = false, DataType = "A/N", Description = "US = LOCA12345 (LOC plus 6 bytes of the Locale key from the drop ship product); 'ORIGIN' for origin entered mail; OT = Other The field can have a Locale key for origin entered mail when USPS Pick Up is equal to N. See Scenarios and Definitions Sections for alternatives for populating this field. Use value of 'ORIGIN' for Origin/DMU Entered mail OR for US Drop Ship, Zone Skipped, and BMEU entered Mail use the Locale Key (LOC in the first 3 bytes, balance is the 6-byte of the USPS dropsite key, also known as the Locale Key).", Type = "string", Format = "leftjustify")]
		[Column("EntryPointActualDeliveryLocaleKey", Order = 12, TypeName = "TEXT")]
		[Required]
		[MaxLength(9)]
		[Comment("CSM-1167")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string EntryPointActualDeliveryLocaleKey { get; set; }

		/// <summary>
		/// Entry Point - Actual / Delivery -Postal Code (CSM-1168)
		/// ZIP + 4 of building receiving the mail; ZIP + 4 of DMU for DMU entered mail The ZIP + 4 shall be the
		/// Delivery address ZIP + 4 from the USPS Drop Ship Product. Either the Locale Key reference field
		/// (CSM-1167), or the Correct ZIP + 4 is required in this field for USPS full-service automation rates.
		/// This information helps USPS calculate and measure service performance.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1168", FieldName = "Entry Point - Actual / Delivery -Postal Code", Start = 61, Length = 9, Required = true, Key = false, DataType = "A/N", Description = "ZIP + 4 of building receiving the mail; ZIP + 4 of DMU for DMU entered mail The ZIP + 4 shall be the Delivery address ZIP + 4 from the USPS Drop Ship Product. Either the Locale Key reference field (CSM-1167), or the Correct ZIP + 4 is required in this field for USPS full-service automation rates. This information helps USPS calculate and measure service performance.", Type = "zipcode", Format = "leftjustify")]
		[Column("EntryPointActualDeliveryPostalCode", Order = 13, TypeName = "TEXT")]
		[Required]
		[MaxLength(9)]
		[Comment("CSM-1168")]
		[TypeConverter(typeof(MaildatZipCodeConverter))]
		public string EntryPointActualDeliveryPostalCode { get; set; }

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
		[MaildatField(Extension = "csm", FieldCode = "CSM-1109", FieldName = "Parent Container Reference ID", Start = 70, Length = 6, Required = false, Key = false, DataType = "N", Description = "(use numeric populated in 14/6 of .CSM of Parent record) Container ID of the Parent Container in which this Child Container resides, if such relationship exists, blank if no such relationship. Parent Containers may have Parent Containers themselves. This is not prohibited; ex: a carton in a sack upon a pallet. The Container Id of the Parent Container in which this child container resides; such as a tray on a pallet. Populate field with numeric from Container ID CSM-1006 of parent container's .CSM If no child/parent relationship exists for this container, then field is blank. Populated ONLY for those child containers linked to a parent container; if container is parent only, then field is blank.", Type = "integer", Format = "zfill")]
		[Column("ParentContainerReferenceID", Order = 14, TypeName = "INTEGER")]
		[Comment("CSM-1109")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? ParentContainerReferenceID { get; set; }

		/// <summary>
		/// Truck or Dispatch Number (CSM-1110)
		/// As available, the truck ID, trailer ID, or applicable dispatch information.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1110", FieldName = "Truck or Dispatch Number", Start = 76, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "As available, the truck ID, trailer ID, or applicable dispatch information.", Type = "string", Format = "leftjustify")]
		[Column("TruckOrDispatchNumber", Order = 15, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CSM-1110")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string TruckOrDispatchNumber { get; set; }

		/// <summary>
		/// Stop Designator (CSM-1111)
		/// Stop order and stop 1 will be the first stop (i.e., what is loaded in the tail).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1111", FieldName = "Stop Designator", Start = 96, Length = 2, Required = false, Key = false, DataType = "A/N", Description = "Stop order and stop 1 will be the first stop (i.e., what is loaded in the tail).", Type = "string", Format = "leftjustify")]
		[Column("StopDesignator", Order = 16, TypeName = "TEXT")]
		[MaxLength(2)]
		[Comment("CSM-1111")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string StopDesignator { get; set; }

		/// <summary>
		/// Reservation Number (CSM-1112)
		/// As available, the appointment number for the specified container in this record.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1112", FieldName = "Reservation Number", Start = 98, Length = 15, Required = false, Key = false, DataType = "A/N", Description = "As available, the appointment number for the specified container in this record.", Type = "string", Format = "leftjustify")]
		[Column("ReservationNumber", Order = 17, TypeName = "TEXT")]
		[MaxLength(15)]
		[Comment("CSM-1112")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string ReservationNumber { get; set; }

		/// <summary>
		/// Actual Container Ship Date (CSM-1113)
		/// As available, date when the container releases from mailing facility or agent's facility. YYYYMMDD
		/// (cannot be all zeros). Unscheduled DMU verified/USPS Transported.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1113", FieldName = "Actual Container Ship Date", Start = 113, Length = 8, Required = false, Key = false, DataType = "N", Description = "As available, date when the container releases from mailing facility or agent's facility. YYYYMMDD (cannot be all zeros). Unscheduled DMU verified/USPS Transported.", Type = "date", Format = "YYYYMMDD")]
		[Column("ActualContainerShipDate", Order = 18, TypeName = "TEXT")]
		[Comment("CSM-1113")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ActualContainerShipDate { get; set; }

		/// <summary>
		/// Actual Container Ship Time (CSM-1164)
		/// As available, time when the container releases from mailing facility or agent's facility. HH:MM (EX:
		/// 18:12). Unscheduled DMU verified/USPS Transported.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1164", FieldName = "Actual Container Ship Time", Start = 121, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "As available, time when the container releases from mailing facility or agent's facility. HH:MM (EX: 18:12). Unscheduled DMU verified/USPS Transported.", Type = "time", Format = "HH:MM")]
		[Column("ActualContainerShipTime", Order = 19, TypeName = "TEXT")]
		[Comment("CSM-1164")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ActualContainerShipTime { get; set; }

		/// <summary>
		/// Scheduled Pick Up Date (CSM-1177)
		/// Scheduled pick up date.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1177", FieldName = "Scheduled Pick Up Date", Start = 126, Length = 8, Required = false, Key = false, DataType = "N", Description = "Scheduled pick up date.", Type = "date", Format = "YYYYMMDD")]
		[Column("ScheduledPickUpDate", Order = 20, TypeName = "TEXT")]
		[Comment("CSM-1177")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ScheduledPickUpDate { get; set; }

		/// <summary>
		/// Scheduled Pick Up Time (CSM-1178)
		/// Scheduled pick up time.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1178", FieldName = "Scheduled Pick Up Time", Start = 134, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "Scheduled pick up time.", Type = "time", Format = "HH:MM")]
		[Column("ScheduledPickUpTime", Order = 21, TypeName = "TEXT")]
		[Comment("CSM-1178")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ScheduledPickUpTime { get; set; }

		/// <summary>
		/// Scheduled In-Home Date (CSM-1115)
		/// The first, or only date of the ranged targeted for in-home delivery. YYYYMMDD (cannot be all zeros)
		/// (first date in range).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1115", FieldName = "Scheduled In-Home Date", Start = 139, Length = 8, Required = false, Key = false, DataType = "N", Description = "The first, or only date of the ranged targeted for in-home delivery. YYYYMMDD (cannot be all zeros) (first date in range).", Type = "date", Format = "YYYYMMDD")]
		[Column("ScheduledInHomeDate", Order = 22, TypeName = "TEXT")]
		[Comment("CSM-1115")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ScheduledInHomeDate { get; set; }

		/// <summary>
		/// Additional In-Home Range (CSM-1116)
		/// Additional days in In-Home Range (values = 0,1,2,3,4,5,6,7,8,9).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1116", FieldName = "Additional In-Home Range", Start = 147, Length = 1, Required = false, Key = false, DataType = "N", Description = "Additional days in In-Home Range (values = 0,1,2,3,4,5,6,7,8,9).", Type = "integer", Format = "zfill")]
		[Column("AdditionalInHomeRange", Order = 23, TypeName = "INTEGER")]
		[Comment("CSM-1116")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? AdditionalInHomeRange { get; set; }

		/// <summary>
		/// Scheduled Induction Start Date (CSM-1117)
		/// That start date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot
		/// be all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be
		/// before or equal to the end date.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1117", FieldName = "Scheduled Induction Start Date", Start = 148, Length = 8, Required = false, Key = false, DataType = "N", Description = "That start date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot be all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be before or equal to the end date.", Type = "date", Format = "YYYYMMDD")]
		[Column("ScheduledInductionStartDate", Order = 24, TypeName = "TEXT")]
		[Comment("CSM-1117")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ScheduledInductionStartDate { get; set; }

		/// <summary>
		/// Scheduled Induction Start Time (CSM-1118)
		/// That hour of the scheduled start date on which the mail is to be transferred to the consignee for
		/// processing. HH:MM (EX: 18:12).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1118", FieldName = "Scheduled Induction Start Time", Start = 156, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "That hour of the scheduled start date on which the mail is to be transferred to the consignee for processing. HH:MM (EX: 18:12).", Type = "time", Format = "HH:MM")]
		[Column("ScheduledInductionStartTime", Order = 25, TypeName = "TEXT")]
		[Comment("CSM-1118")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ScheduledInductionStartTime { get; set; }

		/// <summary>
		/// Scheduled Induction End Date (CSM-2001)
		/// That end date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot be
		/// all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be
		/// before or equal to the end date.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-2001", FieldName = "Scheduled Induction End Date", Start = 161, Length = 8, Required = false, Key = false, DataType = "N", Description = "That end date on which the mail is transferred to the consignee for processing. YYYYMMDD (cannot be all zeros). If both Scheduled Induction Start and End Dates are populated, the start date must be before or equal to the end date.", Type = "date", Format = "YYYYMMDD")]
		[Column("ScheduledInductionEndDate", Order = 26, TypeName = "TEXT")]
		[Comment("CSM-2001")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ScheduledInductionEndDate { get; set; }

		/// <summary>
		/// Scheduled Induction End Time (CSM-2002)
		/// That hour of the scheduled end date on which the mail is to be transferred to the consignee for
		/// processing. HH:MM (EX: 18:12).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-2002", FieldName = "Scheduled Induction End Time", Start = 169, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "That hour of the scheduled end date on which the mail is to be transferred to the consignee for processing. HH:MM (EX: 18:12).", Type = "time", Format = "HH:MM")]
		[Column("ScheduledInductionEndTime", Order = 27, TypeName = "TEXT")]
		[Comment("CSM-2002")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ScheduledInductionEndTime { get; set; }

		/// <summary>
		/// Actual induction Date (CSM-1179)
		/// Actual date when mail was inducted.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1179", FieldName = "Actual induction Date", Start = 174, Length = 8, Required = false, Key = false, DataType = "N", Description = "Actual date when mail was inducted.", Type = "date", Format = "YYYYMMDD")]
		[Column("ActualInductionDate", Order = 28, TypeName = "TEXT")]
		[Comment("CSM-1179")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ActualInductionDate { get; set; }

		/// <summary>
		/// Actual Induction Time (CSM-1180)
		/// Actual time when mail was inducted.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1180", FieldName = "Actual Induction Time", Start = 182, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "Actual time when mail was inducted.", Type = "time", Format = "HH:MM")]
		[Column("ActualInductionTime", Order = 29, TypeName = "TEXT")]
		[Comment("CSM-1180")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ActualInductionTime { get; set; }

		/// <summary>
		/// Postage Statement Mailing Date (CSM-1184)
		/// YYYYMMDD (cannot be all zeros). The date on which postage is paid to the USPS and verification is
		/// completed.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1184", FieldName = "Postage Statement Mailing Date", Start = 187, Length = 8, Required = false, Key = false, DataType = "N", Description = "YYYYMMDD (cannot be all zeros). The date on which postage is paid to the USPS and verification is completed.", Type = "date", Format = "YYYYMMDD")]
		[Column("PostageStatementMailingDate", Order = 30, TypeName = "TEXT")]
		[Comment("CSM-1184")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? PostageStatementMailingDate { get; set; }

		/// <summary>
		/// Postage Statement Mailing Time (CSM-1183)
		/// HH:MM (EX: 18:12). The time on which postage is paid to the USPS and verification is completed.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1183", FieldName = "Postage Statement Mailing Time", Start = 195, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "HH:MM (EX: 18:12). The time on which postage is paid to the USPS and verification is completed.", Type = "time", Format = "HH:MM")]
		[Column("PostageStatementMailingTime", Order = 31, TypeName = "TEXT")]
		[Comment("CSM-1183")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? PostageStatementMailingTime { get; set; }

		/// <summary>
		/// Number of Copies (CSM-1120)
		/// Total copies on the container represented by this record.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1120", FieldName = "Number of Copies", Start = 200, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total copies on the container represented by this record.", Type = "integer", Format = "zfill")]
		[Column("NumberOfCopies", Order = 32, TypeName = "INTEGER")]
		[Required]
		[Comment("CSM-1120")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfCopies { get; set; }

		/// <summary>
		/// Number of Pieces (CSM-1121)
		/// Total Pieces on the container represented by this record. (see Scenarios for Firm Packages and
		/// Package Services Multi-Piece Parcel bundles) (pieces may be less than copies in some Periodical or
		/// Package Services mailings).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1121", FieldName = "Number of Pieces", Start = 208, Length = 8, Required = true, Key = false, DataType = "N", Description = "Total Pieces on the container represented by this record. (see Scenarios for Firm Packages and Package Services Multi-Piece Parcel bundles) (pieces may be less than copies in some Periodical or Package Services mailings).", Type = "integer", Format = "zfill")]
		[Column("NumberOfPieces", Order = 33, TypeName = "INTEGER")]
		[Required]
		[Comment("CSM-1121")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int NumberOfPieces { get; set; }

		/// <summary>
		/// Total Weight (product only) (CSM-1122)
		/// 99999999v9999 pounds, (decimal point implied). International = Gross Weight.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1122", FieldName = "Total Weight (product only)", Start = 216, Length = 12, Required = true, Key = false, DataType = "N", Description = "99999999v9999 pounds, (decimal point implied). International = Gross Weight.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("TotalWeightProductOnly", Order = 34, TypeName = "NUMERIC")]
		[Required]
		[Precision(4)]
		[Comment("CSM-1122")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal TotalWeightProductOnly { get; set; }

		/// <summary>
		/// User Container ID (CSM-1123)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1123", FieldName = "User Container ID", Start = 228, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "", Type = "integer", Format = "zfillnumeric")]
		[Column("UserContainerID", Order = 35, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("CSM-1123")]
		public string UserContainerID { get; set; }

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
		[MaildatField(Extension = "csm", FieldCode = "CSM-1124", FieldName = "Container Status", Start = 240, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "A Deleted Container Cannot be reused like the C Flag, where a C can be changed to Blank and then to R or X or T) Deleted Containers' IM Barcode(s), Container, Tray, and Piece cannot be re-used for 45 days, per USPS, after a Deleted status is sent to USPS. Examples Blank = From List House to Mailing Facility Blank = From Mailing Facility to USPS (preliminary) Ready = From Mailing Facility to USPS (final for specific container) This would be in conjunction with a U Status for .csm File in Header Record Closed = From Mailing Facility to USPS (after this container is paid, if transmit full .csm file).", Type = "enum", Format = "leftjustify")]
		[Column("ContainerStatus", Order = 36, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "C", "D", "P", "R", "T", "X")]
		[Comment("CSM-1124")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string ContainerStatus { get; set; }

		/// <summary>
		/// Included In Other Documentation (CSM-1181)
		/// This field indicates if the container is co-palletized. O means this container is the Container from
		/// the Originator's site and shall show up on another Mail.dat as a linked container and I means this
		/// container is the Container from the Originator's site and is co-palletized at the same originator
		/// plant and shall show up on another Mail.dat as a linked container with a value of L.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1181", FieldName = "Included In Other Documentation", Start = 241, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "This field indicates if the container is co-palletized. O means this container is the Container from the Originator's site and shall show up on another Mail.dat as a linked container and I means this container is the Container from the Originator's site and is co-palletized at the same originator plant and shall show up on another Mail.dat as a linked container with a value of L.", Type = "enum", Format = "leftjustify")]
		[Column("IncludedInOtherDocumentation", Order = 37, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "I", "L", "O")]
		[Comment("CSM-1181")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string IncludedInOtherDocumentation { get; set; }

		/// <summary>
		/// Tray Preparation Type (CSM-1126)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1126", FieldName = "Tray Preparation Type", Start = 242, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("TrayPreparationType", Order = 38, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("L", "N", "P", "S")]
		[Comment("CSM-1126")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string TrayPreparationType { get; set; }

		/// <summary>
		/// Trans-Ship Bill of Lading Number (CSM-1130)
		/// Multi-carrier load connection.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1130", FieldName = "Trans-Ship Bill of Lading Number", Start = 243, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Multi-carrier load connection.", Type = "string", Format = "leftjustify")]
		[Column("TransShipBillOfLadingNumber", Order = 39, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("CSM-1130")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string TransShipBillOfLadingNumber { get; set; }

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
		[MaildatField(Extension = "csm", FieldCode = "CSM-1132", FieldName = "Sibling Container Indicator", Start = 253, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Y indicates that this .CSM record represents an additional container that, due to a severe error in the piece measurement, is created during the course of production to contain those pieces that could not be included as part of the original container defined by the presort. If there is a Sibling Container ONLY the following fields in the Sibling .CSM record are populated: Job ID field - Segment ID field - The Container ID of the Sibling Container - User Container ID - Container Type field - Sibling Container Indicator field - The Sibling Container Reference ID field (Container ID of the original container requiring the sibling) - Supplemental Physical Container ID field (optional) - All fields that start with word 'label' and associated with Container Label data No other fields shall be populated; all other values are shared across this pair of associated containers.", Type = "enum", Format = "leftjustify")]
		[Column("SiblingContainerIndicator", Order = 40, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("CSM-1132")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string SiblingContainerIndicator { get; set; }

		/// <summary>
		/// Sibling Container Reference ID (CSM-1133)
		/// (use numeric populated in 14/6 of .CSM of original container) In the event of a Sibling Container,
		/// then the Mail.dat® Container ID of the original affected container must be populated in this field.
		/// A Sibling Container is one necessitated by a severe under-estimate of the piece weight; thereby
		/// requiring the mailing facility to create another (the Sibling) container to accept the overflow.
		/// Identifies the original container with which this Sibling Container is associated, if such
		/// relationship exists. Blank if no such relationship.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1133", FieldName = "Sibling Container Reference ID", Start = 254, Length = 6, Required = false, Key = false, DataType = "N", Description = "(use numeric populated in 14/6 of .CSM of original container) In the event of a Sibling Container, then the Mail.dat® Container ID of the original affected container must be populated in this field. A Sibling Container is one necessitated by a severe under-estimate of the piece weight; thereby requiring the mailing facility to create another (the Sibling) container to accept the overflow. Identifies the original container with which this Sibling Container is associated, if such relationship exists. Blank if no such relationship.", Type = "integer", Format = "zfill")]
		[Column("SiblingContainerReferenceID", Order = 41, TypeName = "INTEGER")]
		[Comment("CSM-1133")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? SiblingContainerReferenceID { get; set; }

		/// <summary>
		/// Postage Grouping ID (CSM-1136)
		/// Identifies that group of containers for which a single Postage Payment was made.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1136", FieldName = "Postage Grouping ID", Start = 260, Length = 8, Required = false, Key = false, DataType = "A/N", Description = "Identifies that group of containers for which a single Postage Payment was made.", Type = "string", Format = "zfillnumeric")]
		[Column("PostageGroupingID", Order = 42, TypeName = "TEXT")]
		[MaxLength(8)]
		[Comment("CSM-1136")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string PostageGroupingID { get; set; }

		/// <summary>
		/// Container Gross Weight (CSM-1137)
		/// 99999999v9999, (decimal point implied) Inclusive of mail and container.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1137", FieldName = "Container Gross Weight", Start = 268, Length = 12, Required = false, Key = false, DataType = "N", Description = "99999999v9999, (decimal point implied) Inclusive of mail and container.", Type = "decimal", Format = "zfill", Precision = 4)]
		[Column("ContainerGrossWeight", Order = 43, TypeName = "NUMERIC")]
		[Precision(4)]
		[Comment("CSM-1137")]
		[TypeConverter(typeof(MaildatDecimalConverter))]
		public decimal? ContainerGrossWeight { get; set; }

		/// <summary>
		/// Container Height (CSM-1139)
		/// (value in inches, no decimal) (inclusive of mail and container).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1139", FieldName = "Container Height", Start = 280, Length = 3, Required = false, Key = false, DataType = "N", Description = "(value in inches, no decimal) (inclusive of mail and container).", Type = "integer", Format = "zfill")]
		[Column("ContainerHeight", Order = 44, TypeName = "INTEGER")]
		[Comment("CSM-1139")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? ContainerHeight { get; set; }

		/// <summary>
		/// EMD - 8125 ASN Barcode (CSM-1141)
		/// See EMD Scenario.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1141", FieldName = "EMD - 8125 ASN Barcode", Start = 283, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "See EMD Scenario.", Type = "string", Format = "leftjustify")]
		[Column("EMD8125ASNBarcode", Order = 45, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CSM-1141")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string EMD8125ASNBarcode { get; set; }

		/// <summary>
		/// Transportation Carrier ID (CSM-1142)
		/// USPS CRID identifying the transporter of mail. Left justify, space padded to the right, only digits
		/// 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1142", FieldName = "Transportation Carrier ID", Start = 303, Length = 15, Required = false, Key = false, DataType = "A/N", Description = "USPS CRID identifying the transporter of mail. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "string", Format = "leftjustify")]
		[Column("TransportationCarrierID", Order = 46, TypeName = "TEXT")]
		[MaxLength(15)]
		[Comment("CSM-1142")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string TransportationCarrierID { get; set; }

		/// <summary>
		/// FAST Content ID (CSM-1162)
		/// USPS FAST CONTENT ID. This ID identifies the contents (one or more IMcbs) going to an entry point.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1162", FieldName = "FAST Content ID", Start = 318, Length = 9, Required = false, Key = false, DataType = "A/N", Description = "USPS FAST CONTENT ID. This ID identifies the contents (one or more IMcbs) going to an entry point.", Type = "string", Format = "leftjustify")]
		[Column("FASTContentID", Order = 47, TypeName = "TEXT")]
		[MaxLength(9)]
		[Comment("CSM-1162")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string FASTContentID { get; set; }

		/// <summary>
		/// FAST Scheduler ID (CSM-1163)
		/// USPS CRID identifying the SCHEDULER of FAST appointments. Schedulers are allowed to file
		/// transportation updates on behalf of the mailer. When populated, this party becomes the responsible
		/// CRID for eInduction errors invoicing on mis-shipped errors in excess of scorecard thresholds. Left
		/// justify, space padded to the right, only digits 0 - 9 acceptable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1163", FieldName = "FAST Scheduler ID", Start = 327, Length = 12, Required = false, Key = false, DataType = "N", Description = "USPS CRID identifying the SCHEDULER of FAST appointments. Schedulers are allowed to file transportation updates on behalf of the mailer. When populated, this party becomes the responsible CRID for eInduction errors invoicing on mis-shipped errors in excess of scorecard thresholds. Left justify, space padded to the right, only digits 0 - 9 acceptable.", Type = "integer", Format = "leftjustify")]
		[Column("FASTSchedulerID", Order = 48, TypeName = "INTEGER")]
		[Comment("CSM-1163")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? FASTSchedulerID { get; set; }

		/// <summary>
		/// USPS Pick Up (CSM-1171)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1171", FieldName = "USPS Pick Up", Start = 339, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("USPSPickUp", Order = 49, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "N", "Y")]
		[Comment("CSM-1171")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string USPSPickUp { get; set; }

		/// <summary>
		/// CSA Separation ID (CSM-1175)
		/// The CSA Separation ID is the separation number as defined in the USPS Guide to Customer/Supplier
		/// Agreements.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1175", FieldName = "CSA Separation ID", Start = 340, Length = 3, Required = false, Key = false, DataType = "N", Description = "The CSA Separation ID is the separation number as defined in the USPS Guide to Customer/Supplier Agreements.", Type = "integer", Format = "zfill")]
		[Column("CSASeparationID", Order = 50, TypeName = "INTEGER")]
		[Comment("CSM-1175")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? CSASeparationID { get; set; }

		/// <summary>
		/// Scheduled Ship Date (CSM-1172)
		/// Date of Dispatch based upon CSA agreement. DMU verified/USPS Transported.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1172", FieldName = "Scheduled Ship Date", Start = 343, Length = 8, Required = false, Key = false, DataType = "N", Description = "Date of Dispatch based upon CSA agreement. DMU verified/USPS Transported.", Type = "date", Format = "YYYYMMDD")]
		[Column("ScheduledShipDate", Order = 51, TypeName = "TEXT")]
		[Comment("CSM-1172")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ScheduledShipDate { get; set; }

		/// <summary>
		/// Scheduled Ship Time (CSM-1173)
		/// (EX: 18:12) - Time of Dispatch based upon CSA agreement. DMU verified/USPS Transported.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1173", FieldName = "Scheduled Ship Time", Start = 351, Length = 5, Required = false, Key = false, DataType = "A/N", Description = "(EX: 18:12) - Time of Dispatch based upon CSA agreement. DMU verified/USPS Transported.", Type = "time", Format = "HH:MM")]
		[Column("ScheduledShipTime", Order = 52, TypeName = "TEXT")]
		[Comment("CSM-1173")]
		[TypeConverter(typeof(MaildatTimeConverter))]
		public TimeOnly? ScheduledShipTime { get; set; }

		/// <summary>
		/// DMM Section Defining Container Preparation (CSM-1147)
		/// Full DMM applicable reference including subsections Example: DMM 300 section 705.8 could be
		/// represented as 705.8 Section 711.2.1 would be 711.2.1. Minimum value is 3 bytes; example 702.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1147", FieldName = "DMM Section Defining Container Preparation", Start = 356, Length = 12, Required = false, Key = false, DataType = "A/N", Description = "Full DMM applicable reference including subsections Example: DMM 300 section 705.8 could be represented as 705.8 Section 711.2.1 would be 711.2.1. Minimum value is 3 bytes; example 702.", Type = "string", Format = "leftjustify")]
		[Column("DMMSectionDefiningContainerPreparation", Order = 53, TypeName = "TEXT")]
		[MaxLength(12)]
		[Comment("CSM-1147")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string DMMSectionDefiningContainerPreparation { get; set; }

		/// <summary>
		/// Label: IM™ Container Or IM™ Tray Barcode - Final (CSM-1150)
		/// Final IMtb or IMcb used on delivered trays or containers to the USPS by the consolidator or
		/// logistics company. If not specified, then leave field blank. If populated in original Mail.dat use
		/// same data as CSM-1198. Also see 'Container Barcode Required for Sibling Containers' scenario under
		/// scenarios section. Also, if the container is 'Deleted' through a Container Status of 'D', then the
		/// Container barcode shall not be used/re-used for 45 days after a 'D' flag has been sent to USPS.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1150", FieldName = "Label: IM™ Container Or IM™ Tray Barcode - Final", Start = 368, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "Final IMtb or IMcb used on delivered trays or containers to the USPS by the consolidator or logistics company. If not specified, then leave field blank. If populated in original Mail.dat use same data as CSM-1198. Also see 'Container Barcode Required for Sibling Containers' scenario under scenarios section. Also, if the container is 'Deleted' through a Container Status of 'D', then the Container barcode shall not be used/re-used for 45 days after a 'D' flag has been sent to USPS.", Type = "string", Format = "leftjustify")]
		[Column("LabelIMContainerOrIMTrayBarcodeFinal", Order = 54, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("CSM-1150")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelIMContainerOrIMTrayBarcodeFinal { get; set; }

		/// <summary>
		/// Label: IM™ Container Or IM™ Tray Barcode- Original (CSM-1198)
		/// Original IMtb or IMcb barcode provided by Preparer to a Consolidator or Logistics company. Left
		/// justify, blank fill. If not specified, then leave field blank. Also see 'Container Barcode Required
		/// for Sibling Containers' scenario under scenarios section. Also, if the container is 'Deleted'
		/// through a Container Status of 'D', then the Container barcode shall not be used/re-used for 45 days
		/// after a 'D' flag has been sent to USPS.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1198", FieldName = "Label: IM™ Container Or IM™ Tray Barcode- Original", Start = 392, Length = 24, Required = false, Key = false, DataType = "A/N", Description = "Original IMtb or IMcb barcode provided by Preparer to a Consolidator or Logistics company. Left justify, blank fill. If not specified, then leave field blank. Also see 'Container Barcode Required for Sibling Containers' scenario under scenarios section. Also, if the container is 'Deleted' through a Container Status of 'D', then the Container barcode shall not be used/re-used for 45 days after a 'D' flag has been sent to USPS.", Type = "string", Format = "leftjustify")]
		[Column("LabelIMContainerOrIMTrayBarcodeOriginal", Order = 55, TypeName = "TEXT")]
		[MaxLength(24)]
		[Comment("CSM-1198")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelIMContainerOrIMTrayBarcodeOriginal { get; set; }

		/// <summary>
		/// Label: Destination Line 1 (CSM-1152)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1152", FieldName = "Label: Destination Line 1", Start = 416, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("LabelDestinationLine1", Order = 56, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CSM-1152")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelDestinationLine1 { get; set; }

		/// <summary>
		/// Label: Destination Line 2 (CSM-1153)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1153", FieldName = "Label: Destination Line 2", Start = 446, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "rightjustify")]
		[Column("LabelDestinationLine2", Order = 57, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CSM-1153")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelDestinationLine2 { get; set; }

		/// <summary>
		/// Label: Contents - Line 1 (CSM-1154)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1154", FieldName = "Label: Contents - Line 1", Start = 476, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("LabelContentsLine1", Order = 58, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CSM-1154")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelContentsLine1 { get; set; }

		/// <summary>
		/// Label: Contents - Line 2 (CSM-1155)
		/// (overflow of line 1).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1155", FieldName = "Label: Contents - Line 2", Start = 506, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "(overflow of line 1).", Type = "string", Format = "rightjustify")]
		[Column("LabelContentsLine2", Order = 59, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CSM-1155")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelContentsLine2 { get; set; }

		/// <summary>
		/// Label: Entry (Origin) Point Line (CSM-1156)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1156", FieldName = "Label: Entry (Origin) Point Line", Start = 526, Length = 30, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("LabelEntryOriginPointLine", Order = 60, TypeName = "TEXT")]
		[MaxLength(30)]
		[Comment("CSM-1156")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelEntryOriginPointLine { get; set; }

		/// <summary>
		/// Label: User Information Line 1 (CSM-1157)
		/// User defined or client requested information.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1157", FieldName = "Label: User Information Line 1", Start = 556, Length = 40, Required = false, Key = false, DataType = "A/N", Description = "User defined or client requested information.", Type = "string", Format = "leftjustify")]
		[Column("LabelUserInformationLine1", Order = 61, TypeName = "TEXT")]
		[MaxLength(40)]
		[Comment("CSM-1157")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelUserInformationLine1 { get; set; }

		/// <summary>
		/// Label: User Information Line 2 (CSM-1158)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1158", FieldName = "Label: User Information Line 2", Start = 596, Length = 40, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("LabelUserInformationLine2", Order = 62, TypeName = "TEXT")]
		[MaxLength(40)]
		[Comment("CSM-1158")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelUserInformationLine2 { get; set; }

		/// <summary>
		/// Label: Container Label CIN Code (CSM-1159)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1159", FieldName = "Label: Container Label CIN Code", Start = 636, Length = 4, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("LabelContainerLabelCINCode", Order = 63, TypeName = "TEXT")]
		[MaxLength(4)]
		[Comment("CSM-1159")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string LabelContainerLabelCINCode { get; set; }

		/// <summary>
		/// User Option Field (CSM-1176)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1176", FieldName = "User Option Field", Start = 640, Length = 20, Required = false, Key = false, DataType = "A/N", Description = "", Type = "string", Format = "leftjustify")]
		[Column("UserOptionField", Order = 64, TypeName = "TEXT")]
		[MaxLength(20)]
		[Comment("CSM-1176")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string UserOptionField { get; set; }

		/// <summary>
		/// eInduction Indicator (CSM-1186)
		/// This shall serve as a flag as to whether an e8125/e8017 needs to be generated for eInduction.
		/// Default value shall be Blank.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1186", FieldName = "EInduction Indicator", Start = 660, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "This shall serve as a flag as to whether an e8125/e8017 needs to be generated for eInduction. Default value shall be Blank.", Type = "enum", Format = "leftjustify")]
		[Column("EInductionIndicator", Order = 65, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("CSM-1186")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string EInductionIndicator { get; set; }

		/// <summary>
		/// CSA Agreement ID (CSM-1187)
		/// Agreement Number generated by the USPS.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1187", FieldName = "CSA Agreement ID", Start = 661, Length = 10, Required = false, Key = false, DataType = "A/N", Description = "Agreement Number generated by the USPS.", Type = "string", Format = "leftjustify")]
		[Column("CSAAgreementID", Order = 66, TypeName = "TEXT")]
		[MaxLength(10)]
		[Comment("CSM-1187")]
		[TypeConverter(typeof(MaildatStringConverter))]
		public string CSAAgreementID { get; set; }

		/// <summary>
		/// Presort Labeling List Effective Date (CSM-1189)
		/// (cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be
		/// the non-value when date is not applicable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1189", FieldName = "Presort Labeling List Effective Date", Start = 671, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be the non-value when date is not applicable.", Type = "date", Format = "YYYYMMDD")]
		[Column("PresortLabelingListEffectiveDate", Order = 67, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1189")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly PresortLabelingListEffectiveDate { get; set; }

		/// <summary>
		/// Last Used Labeling List Effective Date (CSM-1190)
		/// (cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be
		/// the non-value when date is not applicable. For the initial presort, this will have the same value as
		/// Presort Labeling List Effective Date field.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1190", FieldName = "Last Used Labeling List Effective Date", Start = 679, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) For containers created with a CSA, use CSA effective date. 00010101 will be the non-value when date is not applicable. For the initial presort, this will have the same value as Presort Labeling List Effective Date field.", Type = "date", Format = "YYYYMMDD")]
		[Column("LastUsedLabelingListEffectiveDate", Order = 68, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1190")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly LastUsedLabelingListEffectiveDate { get; set; }

		/// <summary>
		/// Presort City-State Publication Date (CSM-1191)
		/// (cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value
		/// when date is not applicable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1191", FieldName = "Presort City-State Publication Date", Start = 687, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value when date is not applicable.", Type = "date", Format = "YYYYMMDD")]
		[Column("PresortCityStatePublicationDate", Order = 69, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1191")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly PresortCityStatePublicationDate { get; set; }

		/// <summary>
		/// Last Used City-State Publication Date (CSM-1192)
		/// (cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value
		/// when the date is not applicable. For the initial presort, this will have the same value as Presort
		/// City-State Publication Date.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1192", FieldName = "Last Used City-State Publication Date", Start = 695, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) Use 01 for day if only Year and Month provided. 00010101 will be the non-value when the date is not applicable. For the initial presort, this will have the same value as Presort City-State Publication Date.", Type = "date", Format = "YYYYMMDD")]
		[Column("LastUsedCityStatePublicationDate", Order = 70, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1192")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly LastUsedCityStatePublicationDate { get; set; }

		/// <summary>
		/// Presort Zone Chart Matrix Publication Date (CSM-1193)
		/// (cannot be all zeros) 00010101 will be the non-value when date is not applicable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1193", FieldName = "Presort Zone Chart Matrix Publication Date", Start = 703, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) 00010101 will be the non-value when date is not applicable.", Type = "date", Format = "YYYYMMDD")]
		[Column("PresortZoneChartMatrixPublicationDate", Order = 71, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1193")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly PresortZoneChartMatrixPublicationDate { get; set; }

		/// <summary>
		/// Last Used Zone Chart Matrix Publication Date (CSM-1194)
		/// (cannot be all zeros) 00010101 will be the non-value when the date is not applicable. For the
		/// initial presort, this will have the same value as Presort Zone Chart Matrix Publication Date.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1194", FieldName = "Last Used Zone Chart Matrix Publication Date", Start = 711, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) 00010101 will be the non-value when the date is not applicable. For the initial presort, this will have the same value as Presort Zone Chart Matrix Publication Date.", Type = "date", Format = "YYYYMMDD")]
		[Column("LastUsedZoneChartMatrixPublicationDate", Order = 72, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1194")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly LastUsedZoneChartMatrixPublicationDate { get; set; }

		/// <summary>
		/// Last Used Mail Direction Publication Date (CSM-1195)
		/// (cannot be all zeros) 00010101 will be the non-value when the date is not applicable.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1195", FieldName = "Last Used Mail Direction Publication Date", Start = 719, Length = 8, Required = true, Key = false, DataType = "N", Description = "(cannot be all zeros) 00010101 will be the non-value when the date is not applicable.", Type = "date", Format = "YYYYMMDD")]
		[Column("LastUsedMailDirectionPublicationDate", Order = 73, TypeName = "TEXT")]
		[Required]
		[Comment("CSM-1195")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly LastUsedMailDirectionPublicationDate { get; set; }

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
		[MaildatField(Extension = "csm", FieldCode = "CSM-1196", FieldName = "Supplemental Physical Container ID", Start = 727, Length = 6, Required = false, Key = false, DataType = "N", Description = "(use CSM-1006 of Physical Parent record) This field can be used in two ways, both of which are optional. The first definition is meant for use in logical tray scenarios or overflow scenarios, where the field can be used to describe the relationship between a physical tray and its physical parent container. The second definition is meant for use with logical bundle-based mailings, where the field can be used to describe the relationship between logical trays when bundles of mail are relocated. These two models of usage do not conflict with each other because the first definition can only be used for a physical or sibling tray, and the second definition can only be used for a logical tray. If neither of these usage models applies for your mailing, the field should remain blank in your CSM records. Definition 1: (For linkage between physical trays and physical parent containers, use CSM-1006 of the physical parent container on which the physical tray resides) Container ID of the Physical Parent Container in which this physical tray or sibling tray resides, if such relationship exists. Blank if no such relationship This is an optional field and can be used to associate either a physical or a sibling handling unit to the actual container that it is on but only under specific circumstances: When the container it is on is a sibling to either a logical or physical master container. When the container that it is on is a physical container that has at least one sibling (as in an overflow scenario). The child-to-parent container relationship established through the use of the Parent Container Reference ID must also be used to link the master handling unit (not the sibling) to a parent. It is only through that relationship that pieces can be associated to logical container groups or physical containers with siblings. Note, when used, this describes which handling units are on which containers and does not provide any indication of which mail pieces are in which handling units or on which containers Definition 2: This definition is for FCM MLOCR bundle-based preparation. (For linkage between logical trays when using bundle-based mail and some mail bundles are relocated between two different logical trays, use CSM-1006 of the logical tray into which mail is being relocated) Container ID of another logical tray into which some mail from this logical tray has been relocated, if such relationship exists. Blank if no such relationship. This is an optional field and can be used to associate a logical tray to another logical tray when some mail has been relocated within a bundle-based mailing. The purpose is to identify such related trays in order to assist with the verification of a mailing. Note, when used, this describes relocation for an indeterminate quantity of mail, and does not provide any indication of which mail pieces are relocated into the other logical tray. Unless the original logical tray record ceases to exist because all of its mail is relocated into a different logical tray, the tallying for the quantity of mail will remain with the original logical tray, and relocated mail does not add to the accumulated amount in the target logical tray for the following fields Number of Copies (CSM-1120) Number of Pieces (CSM-1121) Total Weight (CSM-1122) Container Gross Weight (CSM-1137) Note also that this means a target logical tray which receives such relocations may possibly have values of zero for the aforementioned fields, if it exists solely for the purpose of receiving such relocations.", Type = "integer", Format = "zfill")]
		[Column("SupplementalPhysicalContainerID", Order = 74, TypeName = "INTEGER")]
		[Comment("CSM-1196")]
		[TypeConverter(typeof(MaildatIntegerConverter))]
		public int? SupplementalPhysicalContainerID { get; set; }

		/// <summary>
		/// Accept Misshipped (CSM-1188)
		/// USPS field for eInduction misshipped processing support.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1188", FieldName = "Accept Misshipped", Start = 733, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "USPS field for eInduction misshipped processing support.", Type = "enum", Format = "leftjustify")]
		[Column("AcceptMisshipped", Order = 75, TypeName = "TEXT")]
		[MaxLength(1)]
		[AllowedValues(" ", "Y")]
		[Comment("CSM-1188")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string AcceptMisshipped { get; set; }

		/// <summary>
		/// Referenceable Mail Start Date (CSM-1199)
		/// Start date for the Referenceable Mail. Default to blank spaces when no constraint requested;
		/// YYYYMMDD (cannot be all zeros).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1199", FieldName = "Referenceable Mail Start Date", Start = 734, Length = 8, Required = false, Key = false, DataType = "N", Description = "Start date for the Referenceable Mail. Default to blank spaces when no constraint requested; YYYYMMDD (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("ReferenceableMailStartDate", Order = 76, TypeName = "TEXT")]
		[Comment("CSM-1199")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ReferenceableMailStartDate { get; set; }

		/// <summary>
		/// Referenceable Mail End Date (CSM-1200)
		/// End date for the Referenceable Mail. Default to blank spaces when no constraint requested; YYYYMMDD
		/// (cannot be all zeros).
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1200", FieldName = "Referenceable Mail End Date", Start = 742, Length = 8, Required = false, Key = false, DataType = "N", Description = "End date for the Referenceable Mail. Default to blank spaces when no constraint requested; YYYYMMDD (cannot be all zeros).", Type = "date", Format = "YYYYMMDD")]
		[Column("ReferenceableMailEndDate", Order = 77, TypeName = "TEXT")]
		[Comment("CSM-1200")]
		[TypeConverter(typeof(MaildatDateConverter))]
		public DateOnly? ReferenceableMailEndDate { get; set; }

		/// <summary>
		/// CSM Record Status (CSM-2000)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-2000", FieldName = "CSM Record Status", Start = 750, Length = 1, Required = true, Key = false, DataType = "A/N", Description = "", Type = "enum", Format = "leftjustify")]
		[Column("CSMRecordStatus", Order = 78, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("CSM-2000")]
		[TypeConverter(typeof(MaildatEnumConverter))]
		public string CSMRecordStatus { get; set; }

		/// <summary>
		/// Reserve (CSM-1134)
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-1134", FieldName = "Reserve", Start = 751, Length = 39, Required = false, Key = false, DataType = "A/N", Description = "", Type = "reserve", Format = "leftjustify")]
		[Column("ReserveCSM1134", Order = 79, TypeName = "TEXT")]
		[MaxLength(39)]
		[Comment("CSM-1134")]
		[TypeConverter(typeof(MaildatReserveConverter))]
		public string ReserveCSM1134 { get; set; }

		/// <summary>
		/// Closing Character (CSM-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "csm", FieldCode = "CSM-9999", FieldName = "Closing Character", Start = 790, Length = 1, Required = true, Key = false, DataType = "", Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 80, TypeName = "TEXT")]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("CSM-9999")]
		[TypeConverter(typeof(MaildatClosingConverter))]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override Task<ILoadError[]> OnImportDataAsync(int fileLineNumber, ReadOnlySpan<byte> line)
		{
			List<ILoadError> returnValue = [];
			
			this.JobID = line.ParseForImport<Csm, string>(p => p.JobID, returnValue);
			this.SegmentID = line.ParseForImport<Csm, string>(p => p.SegmentID, returnValue);
			this.ContainerType = line.ParseForImport<Csm, string>(p => p.ContainerType, returnValue);
			this.ContainerID = line.ParseForImport<Csm, int>(p => p.ContainerID, returnValue);
			this.DisplayContainerID = line.ParseForImport<Csm, string>(p => p.DisplayContainerID, returnValue);
			this.ContainerGroupingDescription = line.ParseForImport<Csm, string>(p => p.ContainerGroupingDescription, returnValue);
			this.ContainerDestinationZip = line.ParseForImport<Csm, string>(p => p.ContainerDestinationZip, returnValue);
			this.ContainerLevel = line.ParseForImport<Csm, string>(p => p.ContainerLevel, returnValue);
			this.EntryPointForEntryDiscountPostalCode = line.ParseForImport<Csm, string>(p => p.EntryPointForEntryDiscountPostalCode, returnValue);
			this.EntryPointForEntryDiscountFacilityType = line.ParseForImport<Csm, string>(p => p.EntryPointForEntryDiscountFacilityType, returnValue);
			this.EntryPointActualDeliveryLocaleKey = line.ParseForImport<Csm, string>(p => p.EntryPointActualDeliveryLocaleKey, returnValue);
			this.EntryPointActualDeliveryPostalCode = line.ParseForImport<Csm, string>(p => p.EntryPointActualDeliveryPostalCode, returnValue);
			this.ParentContainerReferenceID = line.ParseForImport<Csm, int?>(p => p.ParentContainerReferenceID, returnValue);
			this.TruckOrDispatchNumber = line.ParseForImport<Csm, string>(p => p.TruckOrDispatchNumber, returnValue);
			this.StopDesignator = line.ParseForImport<Csm, string>(p => p.StopDesignator, returnValue);
			this.ReservationNumber = line.ParseForImport<Csm, string>(p => p.ReservationNumber, returnValue);
			this.ActualContainerShipDate = line.ParseForImport<Csm, DateOnly?>(p => p.ActualContainerShipDate, returnValue);
			this.ActualContainerShipTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ActualContainerShipTime, returnValue);
			this.ScheduledPickUpDate = line.ParseForImport<Csm, DateOnly?>(p => p.ScheduledPickUpDate, returnValue);
			this.ScheduledPickUpTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ScheduledPickUpTime, returnValue);
			this.ScheduledInHomeDate = line.ParseForImport<Csm, DateOnly?>(p => p.ScheduledInHomeDate, returnValue);
			this.AdditionalInHomeRange = line.ParseForImport<Csm, int?>(p => p.AdditionalInHomeRange, returnValue);
			this.ScheduledInductionStartDate = line.ParseForImport<Csm, DateOnly?>(p => p.ScheduledInductionStartDate, returnValue);
			this.ScheduledInductionStartTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ScheduledInductionStartTime, returnValue);
			this.ScheduledInductionEndDate = line.ParseForImport<Csm, DateOnly?>(p => p.ScheduledInductionEndDate, returnValue);
			this.ScheduledInductionEndTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ScheduledInductionEndTime, returnValue);
			this.ActualInductionDate = line.ParseForImport<Csm, DateOnly?>(p => p.ActualInductionDate, returnValue);
			this.ActualInductionTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ActualInductionTime, returnValue);
			this.PostageStatementMailingDate = line.ParseForImport<Csm, DateOnly?>(p => p.PostageStatementMailingDate, returnValue);
			this.PostageStatementMailingTime = line.ParseForImport<Csm, TimeOnly?>(p => p.PostageStatementMailingTime, returnValue);
			this.NumberOfCopies = line.ParseForImport<Csm, int>(p => p.NumberOfCopies, returnValue);
			this.NumberOfPieces = line.ParseForImport<Csm, int>(p => p.NumberOfPieces, returnValue);
			this.TotalWeightProductOnly = line.ParseForImport<Csm, decimal>(p => p.TotalWeightProductOnly, returnValue);
			this.UserContainerID = line.ParseForImport<Csm, string>(p => p.UserContainerID, returnValue);
			this.ContainerStatus = line.ParseForImport<Csm, string>(p => p.ContainerStatus, returnValue);
			this.IncludedInOtherDocumentation = line.ParseForImport<Csm, string>(p => p.IncludedInOtherDocumentation, returnValue);
			this.TrayPreparationType = line.ParseForImport<Csm, string>(p => p.TrayPreparationType, returnValue);
			this.TransShipBillOfLadingNumber = line.ParseForImport<Csm, string>(p => p.TransShipBillOfLadingNumber, returnValue);
			this.SiblingContainerIndicator = line.ParseForImport<Csm, string>(p => p.SiblingContainerIndicator, returnValue);
			this.SiblingContainerReferenceID = line.ParseForImport<Csm, int?>(p => p.SiblingContainerReferenceID, returnValue);
			this.PostageGroupingID = line.ParseForImport<Csm, string>(p => p.PostageGroupingID, returnValue);
			this.ContainerGrossWeight = line.ParseForImport<Csm, decimal?>(p => p.ContainerGrossWeight, returnValue);
			this.ContainerHeight = line.ParseForImport<Csm, int?>(p => p.ContainerHeight, returnValue);
			this.EMD8125ASNBarcode = line.ParseForImport<Csm, string>(p => p.EMD8125ASNBarcode, returnValue);
			this.TransportationCarrierID = line.ParseForImport<Csm, string>(p => p.TransportationCarrierID, returnValue);
			this.FASTContentID = line.ParseForImport<Csm, string>(p => p.FASTContentID, returnValue);
			this.FASTSchedulerID = line.ParseForImport<Csm, int?>(p => p.FASTSchedulerID, returnValue);
			this.USPSPickUp = line.ParseForImport<Csm, string>(p => p.USPSPickUp, returnValue);
			this.CSASeparationID = line.ParseForImport<Csm, int?>(p => p.CSASeparationID, returnValue);
			this.ScheduledShipDate = line.ParseForImport<Csm, DateOnly?>(p => p.ScheduledShipDate, returnValue);
			this.ScheduledShipTime = line.ParseForImport<Csm, TimeOnly?>(p => p.ScheduledShipTime, returnValue);
			this.DMMSectionDefiningContainerPreparation = line.ParseForImport<Csm, string>(p => p.DMMSectionDefiningContainerPreparation, returnValue);
			this.LabelIMContainerOrIMTrayBarcodeFinal = line.ParseForImport<Csm, string>(p => p.LabelIMContainerOrIMTrayBarcodeFinal, returnValue);
			this.LabelIMContainerOrIMTrayBarcodeOriginal = line.ParseForImport<Csm, string>(p => p.LabelIMContainerOrIMTrayBarcodeOriginal, returnValue);
			this.LabelDestinationLine1 = line.ParseForImport<Csm, string>(p => p.LabelDestinationLine1, returnValue);
			this.LabelDestinationLine2 = line.ParseForImport<Csm, string>(p => p.LabelDestinationLine2, returnValue);
			this.LabelContentsLine1 = line.ParseForImport<Csm, string>(p => p.LabelContentsLine1, returnValue);
			this.LabelContentsLine2 = line.ParseForImport<Csm, string>(p => p.LabelContentsLine2, returnValue);
			this.LabelEntryOriginPointLine = line.ParseForImport<Csm, string>(p => p.LabelEntryOriginPointLine, returnValue);
			this.LabelUserInformationLine1 = line.ParseForImport<Csm, string>(p => p.LabelUserInformationLine1, returnValue);
			this.LabelUserInformationLine2 = line.ParseForImport<Csm, string>(p => p.LabelUserInformationLine2, returnValue);
			this.LabelContainerLabelCINCode = line.ParseForImport<Csm, string>(p => p.LabelContainerLabelCINCode, returnValue);
			this.UserOptionField = line.ParseForImport<Csm, string>(p => p.UserOptionField, returnValue);
			this.EInductionIndicator = line.ParseForImport<Csm, string>(p => p.EInductionIndicator, returnValue);
			this.CSAAgreementID = line.ParseForImport<Csm, string>(p => p.CSAAgreementID, returnValue);
			this.PresortLabelingListEffectiveDate = line.ParseForImport<Csm, DateOnly>(p => p.PresortLabelingListEffectiveDate, returnValue);
			this.LastUsedLabelingListEffectiveDate = line.ParseForImport<Csm, DateOnly>(p => p.LastUsedLabelingListEffectiveDate, returnValue);
			this.PresortCityStatePublicationDate = line.ParseForImport<Csm, DateOnly>(p => p.PresortCityStatePublicationDate, returnValue);
			this.LastUsedCityStatePublicationDate = line.ParseForImport<Csm, DateOnly>(p => p.LastUsedCityStatePublicationDate, returnValue);
			this.PresortZoneChartMatrixPublicationDate = line.ParseForImport<Csm, DateOnly>(p => p.PresortZoneChartMatrixPublicationDate, returnValue);
			this.LastUsedZoneChartMatrixPublicationDate = line.ParseForImport<Csm, DateOnly>(p => p.LastUsedZoneChartMatrixPublicationDate, returnValue);
			this.LastUsedMailDirectionPublicationDate = line.ParseForImport<Csm, DateOnly>(p => p.LastUsedMailDirectionPublicationDate, returnValue);
			this.SupplementalPhysicalContainerID = line.ParseForImport<Csm, int?>(p => p.SupplementalPhysicalContainerID, returnValue);
			this.AcceptMisshipped = line.ParseForImport<Csm, string>(p => p.AcceptMisshipped, returnValue);
			this.ReferenceableMailStartDate = line.ParseForImport<Csm, DateOnly?>(p => p.ReferenceableMailStartDate, returnValue);
			this.ReferenceableMailEndDate = line.ParseForImport<Csm, DateOnly?>(p => p.ReferenceableMailEndDate, returnValue);
			this.CSMRecordStatus = line.ParseForImport<Csm, string>(p => p.CSMRecordStatus, returnValue);
			this.ReserveCSM1134 = line.ParseForImport<Csm, string>(p => p.ReserveCSM1134, returnValue);
			this.ClosingCharacter = line.ParseForImport<Csm, string>(p => p.ClosingCharacter, returnValue);
			this.FileLineNumber = fileLineNumber;
			
			return Task.FromResult<ILoadError[]>(returnValue.ToArray());
		}

		/// <summary>
		/// Formats all property values into a single line suitable for export.
		/// </summary>
		protected override Task<string> OnExportDataAsync()
		{
			StringBuilder sb = new();
			
			sb.Append(this.JobID.FormatForExport<Csm, string>(p => p.JobID));
			sb.Append(this.SegmentID.FormatForExport<Csm, string>(p => p.SegmentID));
			sb.Append(this.ContainerType.FormatForExport<Csm, string>(p => p.ContainerType));
			sb.Append(this.ContainerID.FormatForExport<Csm, int>(p => p.ContainerID));
			sb.Append(this.DisplayContainerID.FormatForExport<Csm, string>(p => p.DisplayContainerID));
			sb.Append(this.ContainerGroupingDescription.FormatForExport<Csm, string>(p => p.ContainerGroupingDescription));
			sb.Append(this.ContainerDestinationZip.FormatForExport<Csm, string>(p => p.ContainerDestinationZip));
			sb.Append(this.ContainerLevel.FormatForExport<Csm, string>(p => p.ContainerLevel));
			sb.Append(this.EntryPointForEntryDiscountPostalCode.FormatForExport<Csm, string>(p => p.EntryPointForEntryDiscountPostalCode));
			sb.Append(this.EntryPointForEntryDiscountFacilityType.FormatForExport<Csm, string>(p => p.EntryPointForEntryDiscountFacilityType));
			sb.Append(this.EntryPointActualDeliveryLocaleKey.FormatForExport<Csm, string>(p => p.EntryPointActualDeliveryLocaleKey));
			sb.Append(this.EntryPointActualDeliveryPostalCode.FormatForExport<Csm, string>(p => p.EntryPointActualDeliveryPostalCode));
			sb.Append(this.ParentContainerReferenceID.FormatForExport<Csm, int?>(p => p.ParentContainerReferenceID));
			sb.Append(this.TruckOrDispatchNumber.FormatForExport<Csm, string>(p => p.TruckOrDispatchNumber));
			sb.Append(this.StopDesignator.FormatForExport<Csm, string>(p => p.StopDesignator));
			sb.Append(this.ReservationNumber.FormatForExport<Csm, string>(p => p.ReservationNumber));
			sb.Append(this.ActualContainerShipDate.FormatForExport<Csm, DateOnly?>(p => p.ActualContainerShipDate));
			sb.Append(this.ActualContainerShipTime.FormatForExport<Csm, TimeOnly?>(p => p.ActualContainerShipTime));
			sb.Append(this.ScheduledPickUpDate.FormatForExport<Csm, DateOnly?>(p => p.ScheduledPickUpDate));
			sb.Append(this.ScheduledPickUpTime.FormatForExport<Csm, TimeOnly?>(p => p.ScheduledPickUpTime));
			sb.Append(this.ScheduledInHomeDate.FormatForExport<Csm, DateOnly?>(p => p.ScheduledInHomeDate));
			sb.Append(this.AdditionalInHomeRange.FormatForExport<Csm, int?>(p => p.AdditionalInHomeRange));
			sb.Append(this.ScheduledInductionStartDate.FormatForExport<Csm, DateOnly?>(p => p.ScheduledInductionStartDate));
			sb.Append(this.ScheduledInductionStartTime.FormatForExport<Csm, TimeOnly?>(p => p.ScheduledInductionStartTime));
			sb.Append(this.ScheduledInductionEndDate.FormatForExport<Csm, DateOnly?>(p => p.ScheduledInductionEndDate));
			sb.Append(this.ScheduledInductionEndTime.FormatForExport<Csm, TimeOnly?>(p => p.ScheduledInductionEndTime));
			sb.Append(this.ActualInductionDate.FormatForExport<Csm, DateOnly?>(p => p.ActualInductionDate));
			sb.Append(this.ActualInductionTime.FormatForExport<Csm, TimeOnly?>(p => p.ActualInductionTime));
			sb.Append(this.PostageStatementMailingDate.FormatForExport<Csm, DateOnly?>(p => p.PostageStatementMailingDate));
			sb.Append(this.PostageStatementMailingTime.FormatForExport<Csm, TimeOnly?>(p => p.PostageStatementMailingTime));
			sb.Append(this.NumberOfCopies.FormatForExport<Csm, int>(p => p.NumberOfCopies));
			sb.Append(this.NumberOfPieces.FormatForExport<Csm, int>(p => p.NumberOfPieces));
			sb.Append(this.TotalWeightProductOnly.FormatForExport<Csm, decimal>(p => p.TotalWeightProductOnly));
			sb.Append(this.UserContainerID.FormatForExport<Csm, string>(p => p.UserContainerID));
			sb.Append(this.ContainerStatus.FormatForExport<Csm, string>(p => p.ContainerStatus));
			sb.Append(this.IncludedInOtherDocumentation.FormatForExport<Csm, string>(p => p.IncludedInOtherDocumentation));
			sb.Append(this.TrayPreparationType.FormatForExport<Csm, string>(p => p.TrayPreparationType));
			sb.Append(this.TransShipBillOfLadingNumber.FormatForExport<Csm, string>(p => p.TransShipBillOfLadingNumber));
			sb.Append(this.SiblingContainerIndicator.FormatForExport<Csm, string>(p => p.SiblingContainerIndicator));
			sb.Append(this.SiblingContainerReferenceID.FormatForExport<Csm, int?>(p => p.SiblingContainerReferenceID));
			sb.Append(this.PostageGroupingID.FormatForExport<Csm, string>(p => p.PostageGroupingID));
			sb.Append(this.ContainerGrossWeight.FormatForExport<Csm, decimal?>(p => p.ContainerGrossWeight));
			sb.Append(this.ContainerHeight.FormatForExport<Csm, int?>(p => p.ContainerHeight));
			sb.Append(this.EMD8125ASNBarcode.FormatForExport<Csm, string>(p => p.EMD8125ASNBarcode));
			sb.Append(this.TransportationCarrierID.FormatForExport<Csm, string>(p => p.TransportationCarrierID));
			sb.Append(this.FASTContentID.FormatForExport<Csm, string>(p => p.FASTContentID));
			sb.Append(this.FASTSchedulerID.FormatForExport<Csm, int?>(p => p.FASTSchedulerID));
			sb.Append(this.USPSPickUp.FormatForExport<Csm, string>(p => p.USPSPickUp));
			sb.Append(this.CSASeparationID.FormatForExport<Csm, int?>(p => p.CSASeparationID));
			sb.Append(this.ScheduledShipDate.FormatForExport<Csm, DateOnly?>(p => p.ScheduledShipDate));
			sb.Append(this.ScheduledShipTime.FormatForExport<Csm, TimeOnly?>(p => p.ScheduledShipTime));
			sb.Append(this.DMMSectionDefiningContainerPreparation.FormatForExport<Csm, string>(p => p.DMMSectionDefiningContainerPreparation));
			sb.Append(this.LabelIMContainerOrIMTrayBarcodeFinal.FormatForExport<Csm, string>(p => p.LabelIMContainerOrIMTrayBarcodeFinal));
			sb.Append(this.LabelIMContainerOrIMTrayBarcodeOriginal.FormatForExport<Csm, string>(p => p.LabelIMContainerOrIMTrayBarcodeOriginal));
			sb.Append(this.LabelDestinationLine1.FormatForExport<Csm, string>(p => p.LabelDestinationLine1));
			sb.Append(this.LabelDestinationLine2.FormatForExport<Csm, string>(p => p.LabelDestinationLine2));
			sb.Append(this.LabelContentsLine1.FormatForExport<Csm, string>(p => p.LabelContentsLine1));
			sb.Append(this.LabelContentsLine2.FormatForExport<Csm, string>(p => p.LabelContentsLine2));
			sb.Append(this.LabelEntryOriginPointLine.FormatForExport<Csm, string>(p => p.LabelEntryOriginPointLine));
			sb.Append(this.LabelUserInformationLine1.FormatForExport<Csm, string>(p => p.LabelUserInformationLine1));
			sb.Append(this.LabelUserInformationLine2.FormatForExport<Csm, string>(p => p.LabelUserInformationLine2));
			sb.Append(this.LabelContainerLabelCINCode.FormatForExport<Csm, string>(p => p.LabelContainerLabelCINCode));
			sb.Append(this.UserOptionField.FormatForExport<Csm, string>(p => p.UserOptionField));
			sb.Append(this.EInductionIndicator.FormatForExport<Csm, string>(p => p.EInductionIndicator));
			sb.Append(this.CSAAgreementID.FormatForExport<Csm, string>(p => p.CSAAgreementID));
			sb.Append(this.PresortLabelingListEffectiveDate.FormatForExport<Csm, DateOnly>(p => p.PresortLabelingListEffectiveDate));
			sb.Append(this.LastUsedLabelingListEffectiveDate.FormatForExport<Csm, DateOnly>(p => p.LastUsedLabelingListEffectiveDate));
			sb.Append(this.PresortCityStatePublicationDate.FormatForExport<Csm, DateOnly>(p => p.PresortCityStatePublicationDate));
			sb.Append(this.LastUsedCityStatePublicationDate.FormatForExport<Csm, DateOnly>(p => p.LastUsedCityStatePublicationDate));
			sb.Append(this.PresortZoneChartMatrixPublicationDate.FormatForExport<Csm, DateOnly>(p => p.PresortZoneChartMatrixPublicationDate));
			sb.Append(this.LastUsedZoneChartMatrixPublicationDate.FormatForExport<Csm, DateOnly>(p => p.LastUsedZoneChartMatrixPublicationDate));
			sb.Append(this.LastUsedMailDirectionPublicationDate.FormatForExport<Csm, DateOnly>(p => p.LastUsedMailDirectionPublicationDate));
			sb.Append(this.SupplementalPhysicalContainerID.FormatForExport<Csm, int?>(p => p.SupplementalPhysicalContainerID));
			sb.Append(this.AcceptMisshipped.FormatForExport<Csm, string>(p => p.AcceptMisshipped));
			sb.Append(this.ReferenceableMailStartDate.FormatForExport<Csm, DateOnly?>(p => p.ReferenceableMailStartDate));
			sb.Append(this.ReferenceableMailEndDate.FormatForExport<Csm, DateOnly?>(p => p.ReferenceableMailEndDate));
			sb.Append(this.CSMRecordStatus.FormatForExport<Csm, string>(p => p.CSMRecordStatus));
			sb.Append(this.ReserveCSM1134.FormatForExport<Csm, string>(p => p.ReserveCSM1134));
			sb.Append(this.ClosingCharacter.FormatForExport<Csm, string>(p => p.ClosingCharacter));
			
			return Task.FromResult(sb.ToString());
		}
	}
}