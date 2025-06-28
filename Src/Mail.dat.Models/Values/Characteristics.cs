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
// This code was auto-generated on June 28th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property Characteristic (CCR-1002).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "ccr", FieldCode = "CCR-1002")]
	public class Characteristics : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "ccr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CCR-1002";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "0X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "0X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "0X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "1X", FileExtension = "ccr", Description = "Enhanced Emerging Technology", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "1X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "1X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "2X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "2X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "2X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "3X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "3X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "3X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "4X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "4X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "4X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "5X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "5X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "5X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "6X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "6X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "6X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "7X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "7X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "7X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "8X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "8X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "8X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "9X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "9X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "9X", FileExtension = "ccr", Description = "User Option", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "AD", FileExtension = "ccr", Description = "Advertising", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "AD", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CB", FileExtension = "ccr", Description = "Certificate of Bulk Mailing", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CB", FileExtension = "ccr", Description = "Certificate of Bulk Mailing", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CB", FileExtension = "ccr", Description = "Certificate of Bulk Mailing", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CC", FileExtension = "ccr", Description = "Continuous Contact", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CC", FileExtension = "ccr", Description = "Continuous Contact", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CC", FileExtension = "ccr", Description = "Continuous Contact", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CO", FileExtension = "ccr", Description = "Coupon Promotion", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CO", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CP", FileExtension = "ccr", Description = "Personalized Color Transpromo", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CP", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CR", FileExtension = "ccr", Description = "Personalized Color Transpromo with Reply”", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CR", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "CT", FileExtension = "ccr", Description = "Catalog", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "CT", FileExtension = "ccr", Description = "Catalog", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "CT", FileExtension = "ccr", Description = "Catalog", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "DC", FileExtension = "ccr", Description = "DVD/CD or other disk", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "DC", FileExtension = "ccr", Description = "DVD/CD or other disk", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "DC", FileExtension = "ccr", Description = "DVD/CD or other disk", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "EB", FileExtension = "ccr", Description = "Election Mail Official Ballots", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "EB", FileExtension = "ccr", Description = "Election Mail Official Ballots", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "EB", FileExtension = "ccr", Description = "Election Mail Official Ballots", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "EM", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "EM", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "EN", FileExtension = "ccr", Description = "Election Mail Non-Ballot Materials", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "EN", FileExtension = "ccr", Description = "Election Mail Non-Ballot Materials", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "EN", FileExtension = "ccr", Description = "Election Mail Non-Ballot Materials", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FA", FileExtension = "ccr", Description = "Advertising for First-Class Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FA", FileExtension = "ccr", Description = "Advertising for First-Class Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FA", FileExtension = "ccr", Description = "Advertising for First-Class Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "FG", FileExtension = "ccr", Description = "First-Class Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "FG", FileExtension = "ccr", Description = "First-Class Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "FG", FileExtension = "ccr", Description = "First-Class Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "GS", FileExtension = "ccr", Description = "Geographic Surcharge", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "GS", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "HD", FileExtension = "ccr", Description = "High Density", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "HD", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "IT", FileExtension = "ccr", Description = "Integrated Technology", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "IT", FileExtension = "ccr", Description = "Integrated Technology", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "IT", FileExtension = "ccr", Description = "Integrated Technology", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "IV", FileExtension = "ccr", Description = "Invoice", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "IV", FileExtension = "ccr", Description = "Invoice", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "IV", FileExtension = "ccr", Description = "Invoice", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "ME", FileExtension = "ccr", Description = "Emerging Mobile Technology", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "ME", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MG", FileExtension = "ccr", Description = "USPS Marketing Mail Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MG", FileExtension = "ccr", Description = "USPS Marketing Mail Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "MG", FileExtension = "ccr", Description = "USPS Marketing Mail Growth Incentive Credit Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MI", FileExtension = "ccr", Description = "Reserved", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MI", FileExtension = "ccr", Description = "Reserved", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MM", FileExtension = "ccr", Description = "Marriage Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MM", FileExtension = "ccr", Description = "Marriage Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "MM", FileExtension = "ccr", Description = "Marriage Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "MT", FileExtension = "ccr", Description = "A/B Testing Redemption", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "MT", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "NF", FileExtension = "ccr", Description = "Contents NOT required to be mailed FCM", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "NF", FileExtension = "ccr", Description = "Contents NOT required to be mailed FCM", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "NF", FileExtension = "ccr", Description = "Contents NOT required to be mailed FCM", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "NP", FileExtension = "ccr", Description = "PACT act", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "NP", FileExtension = "ccr", Description = "PACT act", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "NP", FileExtension = "ccr", Description = "PACT act", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "OS", FileExtension = "ccr", Description = "Operational Surcharge", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "OS", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P1", FileExtension = "ccr", Description = "Cylindrical Tubes or Rolls", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P1", FileExtension = "ccr", Description = "Cylindrical Tubes or Rolls", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P2", FileExtension = "ccr", Description = "A Can, or Wooden or Metal box", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P2", FileExtension = "ccr", Description = "A Can, or Wooden or Metal box", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P3", FileExtension = "ccr", Description = "A Parcel Containing More Than 24 Ounces of Liquid in Glass Containers, or 1 Gallon or More of Liquid in Metal or Plasti Ccontainers (see DMM 601.3.4)", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P3", FileExtension = "ccr", Description = "A Parcel Containing More Than 24 Ounces of Liquid in Glass Containers, or 1 Gallon or More of Liquid in Metal or Plasti Ccontainers (see DMM 601.3.4)", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P4", FileExtension = "ccr", Description = "Other characteristics such as parcels prepared under DMM sections 601.3.0 and 601.4.0 with contents that may cause the parcel to roll or not maintain the integrity of the packaging during processing are considered nonstandard.", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P4", FileExtension = "ccr", Description = "Other characteristics such as parcels prepared under DMM sections 601.3.0 and 601.4.0 with contents that may cause the parcel to roll or not maintain the integrity of the packaging during processing are considered nonstandard.", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "P5", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "P5", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PI", FileExtension = "ccr", Description = "Informed Delivery Campaign", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PI", FileExtension = "ccr", Description = "Informed Delivery Campaign", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PI", FileExtension = "ccr", Description = "Informed Delivery Campaign", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PM", FileExtension = "ccr", Description = "Political Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PM", FileExtension = "ccr", Description = "Political Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PM", FileExtension = "ccr", Description = "Political Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PP", FileExtension = "ccr", Description = "Picture Permit Indicia", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PP", FileExtension = "ccr", Description = "Picture Permit Indicia", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "PP", FileExtension = "ccr", Description = "Picture Permit Indicia", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "PS", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "PS", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "RE", FileExtension = "ccr", Description = "Revenue", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "RE", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "RG", FileExtension = "ccr", Description = "Retargeted Mail", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "RG", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "RR", FileExtension = "ccr", Description = "Reply Envelope or Reply Card", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "RR", FileExtension = "ccr", Description = "Reply Envelope or Reply Card", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "RR", FileExtension = "ccr", Description = "Reply Envelope or Reply Card", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "RT", FileExtension = "ccr", Description = "Round Trip ONLY: One DVD/CD or other disk (can be LT or FL)", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "RT", FileExtension = "ccr", Description = "Round Trip ONLY: One DVD/CD or other disk (can be LT or FL)", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "RT", FileExtension = "ccr", Description = "Round Trip ONLY: One DVD/CD or other disk (can be LT or FL)", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "SB", FileExtension = "ccr", Description = "Small Bus w/% off", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "SB", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "SS", FileExtension = "ccr", Description = "Tactile Sensory and Interactive", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "SS", FileExtension = "ccr", Description = "Tactile Sensory and Interactive", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "SS", FileExtension = "ccr", Description = "Tactile Sensory and Interactive", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "ST", FileExtension = "ccr", Description = "Sustainability", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "ST", FileExtension = "ccr", Description = "Sustainability", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "ST", FileExtension = "ccr", Description = "Sustainability", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "VP", FileExtension = "ccr", Description = "Volume w/price off", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "VP", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "VV", FileExtension = "ccr", Description = "Volume w/% off", FieldCode = "CCR-1002", FieldName = "Characteristic" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "VV", FileExtension = "ccr", Description = "Reserve", FieldCode = "CCR-1002", FieldName = "Characteristic" });
		}
	}
}