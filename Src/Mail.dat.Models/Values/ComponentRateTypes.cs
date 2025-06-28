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
	/// These are the allowed values for the property ComponentRateType (CPT-1111).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "cpt", FieldCode = "CPT-1111")]
	public class ComponentRateTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "cpt";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "CPT-1111";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "cpt", Description = "Bound Printed Matter", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "cpt", Description = "Bound Printed Matter", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "cpt", Description = "Bound Printed Matter", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "cpt", Description = "Classroom", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "cpt", Description = "Classroom", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "cpt", Description = "Classroom", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "cpt", Description = "Parcel Select Destination Entry", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "cpt", Description = "Parcel Select Destination Entry", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "cpt", Description = "Parcel Select Destination Entry", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D0", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D0", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D0", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D1", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D1", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D1", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D2", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D2", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D2", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D3", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D3", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D3", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D4", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D4", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D4", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D5", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D5", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D5", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D6", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D6", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D6", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D7", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D7", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D7", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D8", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D8", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D8", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D9", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D9", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D9", FileExtension = "cpt", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "cpt", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "cpt", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "cpt", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E1", FileExtension = "cpt", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E1", FileExtension = "cpt", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E1", FileExtension = "cpt", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E2", FileExtension = "cpt", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E2", FileExtension = "cpt", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E2", FileExtension = "cpt", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E7", FileExtension = "cpt", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E7", FileExtension = "cpt", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E7", FileExtension = "cpt", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "cpt", Description = "Media Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "cpt", Description = "Media Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "cpt", Description = "Media Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "cpt", Description = "Priority Mail Flat (Fixed) Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "cpt", Description = "Reserve", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "cpt", Description = "Reserve", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "H", FileExtension = "cpt", Description = "Per Ride-Along", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "H", FileExtension = "cpt", Description = "Per Ride-Along", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "H", FileExtension = "cpt", Description = "Per Ride-Along", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "I", FileExtension = "cpt", Description = "First Class Permit Reply Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "I", FileExtension = "cpt", Description = "First Class Permit Reply Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "I", FileExtension = "cpt", Description = "First Class Permit Reply Mail", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "cpt", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "cpt", Description = "Library", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "cpt", Description = "Library", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "cpt", Description = "Library", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "M", FileExtension = "cpt", Description = "Repositional Component", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "M", FileExtension = "cpt", Description = "Repositional Component", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "M", FileExtension = "cpt", Description = "Repositional Component", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "cpt", Description = "Nonprofit", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "cpt", Description = "Nonprofit", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "cpt", Description = "Nonprofit", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "cpt", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "cpt", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "cpt", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "cpt", Description = "Parcel Select LW", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "cpt", Description = "Regular (US/MEX/CAN)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "cpt", Description = "Regular (US/MEX/CAN)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "cpt", Description = "Regular (US/MEX/CAN)", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "cpt", Description = "Science of Agriculture", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "cpt", Description = "Science of Agriculture", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "cpt", Description = "Science of Agriculture", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "cpt", Description = "Priority", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "cpt", Description = "Priority", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "cpt", Description = "Priority", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T1", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T1", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T1", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 1", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T2", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T2", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T2", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 2", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T3", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T3", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T3", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 3", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T4", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T4", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T4", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 4", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T5", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T5", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T5", FileExtension = "cpt", Description = "Priority Mail Cubic - Tier 5", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "W", FileExtension = "cpt", Description = "Science of Agriculture Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "W", FileExtension = "cpt", Description = "Science of Agriculture Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "W", FileExtension = "cpt", Description = "Science of Agriculture Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "cpt", Description = "Other", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "cpt", Description = "Other", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "cpt", Description = "Other", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Y", FileExtension = "cpt", Description = "Regular Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Y", FileExtension = "cpt", Description = "Regular Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Y", FileExtension = "cpt", Description = "Regular Limited Circulation", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Z", FileExtension = "cpt", Description = "Included, part of host postage", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Z", FileExtension = "cpt", Description = "Included, part of host postage", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Z", FileExtension = "cpt", Description = "Included, part of host postage", FieldCode = "CPT-1111", FieldName = "ComponentRateType" });
		}
	}
}