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
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property ServiceType (CFR-1004).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "cfr", FieldCode = "CFR-1004")]
	public class ServiceTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cfr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CFR-1004";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "cfr", Description = "USPS Tracking", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "cfr", Description = "USPS Tracking", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "cfr", Description = "USPS Tracking", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B2", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B2", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B2", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B3", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan + Signature Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B3", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan + Signature Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B3", FileExtension = "cfr", Description = "USPS Tracking Plus - Scan + Signature Retention", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "cfr", Description = "Signature Confirmation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "cfr", Description = "Signature Confirmation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "cfr", Description = "Signature Confirmation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C2", FileExtension = "cfr", Description = "Certified Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C2", FileExtension = "cfr", Description = "Certified Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C2", FileExtension = "cfr", Description = "Certified Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CA", FileExtension = "cfr", Description = "Certified Mail Adult Signature Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CA", FileExtension = "cfr", Description = "Certified Mail Adult Signature Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CA", FileExtension = "cfr", Description = "Certified Mail Adult Signature Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CD", FileExtension = "cfr", Description = "Certified Mail Adult Signature Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CD", FileExtension = "cfr", Description = "Certified Mail Adult Signature Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CD", FileExtension = "cfr", Description = "Certified Mail Adult Signature Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "cfr", Description = "Certified Mail", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "cfr", Description = "Certified Mail", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "cfr", Description = "Certified Mail", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "DP", FileExtension = "cfr", Description = "Day-Old Poultry (Live Animal)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "DP", FileExtension = "cfr", Description = "Day-Old Poultry (Live Animal)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "DP", FileExtension = "cfr", Description = "Day-Old Poultry (Live Animal)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "cfr", Description = "Insured", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "cfr", Description = "Insured", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "cfr", Description = "Insured", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E2", FileExtension = "cfr", Description = "Insurance Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E2", FileExtension = "cfr", Description = "Insurance Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E2", FileExtension = "cfr", Description = "Insurance Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "EB", FileExtension = "cfr", Description = "Insured (Bulk)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "EB", FileExtension = "cfr", Description = "Insured (Bulk)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "EB", FileExtension = "cfr", Description = "Insured (Bulk)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "cfr", Description = "Registered", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "cfr", Description = "Registered", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "cfr", Description = "Registered", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F2", FileExtension = "cfr", Description = "Registered Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F2", FileExtension = "cfr", Description = "Registered Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F2", FileExtension = "cfr", Description = "Registered Mail Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "cfr", Description = "Return Receipt (Electronic)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "cfr", Description = "Return Receipt (Electronic)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "cfr", Description = "Return Receipt (Electronic)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "HM", FileExtension = "cfr", Description = "Return Receipt (Form 3811)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "HM", FileExtension = "cfr", Description = "Return Receipt (Form 3811)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "HM", FileExtension = "cfr", Description = "Return Receipt (Form 3811)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "HZ", FileExtension = "cfr", Description = "Hazardous Material Transportation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "HZ", FileExtension = "cfr", Description = "Hazardous Material Transportation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "HZ", FileExtension = "cfr", Description = "Hazardous Material Transportation", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "cfr", Description = "COD", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "cfr", Description = "COD", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "cfr", Description = "COD", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J2", FileExtension = "cfr", Description = "COD Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J2", FileExtension = "cfr", Description = "COD Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J2", FileExtension = "cfr", Description = "COD Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "cfr", Description = "Certificate Of Mailing (Piece level / per piece)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "cfr", Description = "Certificate Of Mailing (Piece level / per piece)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "cfr", Description = "Certificate Of Mailing (Piece level / per piece)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "cfr", Description = "Customs Surcharge", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "cfr", Description = "Customs Surcharge", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "cfr", Description = "Customs Surcharge", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L1", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within first *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L1", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within first *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L1", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within first *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L2", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within second *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L2", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within second *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L2", FileExtension = "cfr", Description = "Nonstandard Fee if Dimension is within second *defined range (inches)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L3", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L3", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L3", FileExtension = "cfr", Description = "Reserve", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L4", FileExtension = "cfr", Description = "Nonstandard Fee if Package Volume is within *defined range (cu. Ft.)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L4", FileExtension = "cfr", Description = "Nonstandard Fee if Package Volume is within *defined range (cu. Ft.)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L4", FileExtension = "cfr", Description = "Nonstandard Fee if Package Volume is within *defined range (cu. Ft.)", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PP", FileExtension = "cfr", Description = "Picture Permit Imprint", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PP", FileExtension = "cfr", Description = "Picture Permit Imprint", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PP", FileExtension = "cfr", Description = "Picture Permit Imprint", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PR", FileExtension = "cfr", Description = "Perishables", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PR", FileExtension = "cfr", Description = "Perishables", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PR", FileExtension = "cfr", Description = "Perishables", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "SC", FileExtension = "cfr", Description = "Signature Confirmation Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "SC", FileExtension = "cfr", Description = "Signature Confirmation Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "SC", FileExtension = "cfr", Description = "Signature Confirmation Restricted Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "U", FileExtension = "cfr", Description = "Certified with Return Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "U", FileExtension = "cfr", Description = "Certified with Return Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "U", FileExtension = "cfr", Description = "Certified with Return Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "V", FileExtension = "cfr", Description = "Registered with Ret Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "V", FileExtension = "cfr", Description = "Registered with Ret Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "V", FileExtension = "cfr", Description = "Registered with Ret Receipt", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "cfr", Description = "Parcel Air Lift", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "cfr", Description = "Parcel Air Lift", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "cfr", Description = "Parcel Air Lift", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Y", FileExtension = "cfr", Description = "Day Certain Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Y", FileExtension = "cfr", Description = "Day Certain Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Y", FileExtension = "cfr", Description = "Day Certain Delivery", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z1", FileExtension = "cfr", Description = "Adult Signature 21 Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z1", FileExtension = "cfr", Description = "Adult Signature 21 Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z1", FileExtension = "cfr", Description = "Adult Signature 21 Required", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z2", FileExtension = "cfr", Description = "Adult Signature 21 Restricted", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z2", FileExtension = "cfr", Description = "Adult Signature 21 Restricted", FieldCode = "CFR-1004", FieldName = "ServiceType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z2", FileExtension = "cfr", Description = "Adult Signature 21 Restricted", FieldCode = "CFR-1004", FieldName = "ServiceType" });
		}
	}
}