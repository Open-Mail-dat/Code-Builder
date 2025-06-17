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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property MailPieceUnitRateType (MPU-1112).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "mpu", FieldCode = "MPU-1112")]
	public class MailPieceUnitRateTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "mpu";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "MPU-1112";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "mpu", Description = "Bound Printed Matter", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "mpu", Description = "Bound Printed Matter", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "mpu", Description = "Bound Printed Matter", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "mpu", Description = "Classroom", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "mpu", Description = "Classroom", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "mpu", Description = "Classroom", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D", FileExtension = "mpu", Description = "Parcel Select Destination Entry", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D", FileExtension = "mpu", Description = "Parcel Select Destination Entry", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D", FileExtension = "mpu", Description = "Parcel Select Destination Entry", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D0", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D0", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D0", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 10", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D1", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D1", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D1", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D2", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D2", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D2", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D3", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D3", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D3", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D4", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D4", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D4", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D5", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D5", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D5", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D6", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D6", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D6", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 6", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D7", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D7", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D7", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 7", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D8", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D8", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D8", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 8", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "D9", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "D9", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "D9", FileExtension = "mpu", Description = "USPS Ground Advantage - Cubic Tier 9", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E", FileExtension = "mpu", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E", FileExtension = "mpu", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E", FileExtension = "mpu", Description = "Priority Mail Flat Rate Envelopes (12-1/2 x 9-1/2 or smaller)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E1", FileExtension = "mpu", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E1", FileExtension = "mpu", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E1", FileExtension = "mpu", Description = "Priority Mail Legal Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E2", FileExtension = "mpu", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E2", FileExtension = "mpu", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E2", FileExtension = "mpu", Description = "Priority Mail Padded Flat Rate Envelope", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "E7", FileExtension = "mpu", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "E7", FileExtension = "mpu", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "E7", FileExtension = "mpu", Description = "Priority Mail Medium Flat Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "F", FileExtension = "mpu", Description = "Media", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "F", FileExtension = "mpu", Description = "Media", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "F", FileExtension = "mpu", Description = "Media", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "G", FileExtension = "mpu", Description = "Priority Mail Flat (Fixed) Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "G", FileExtension = "mpu", Description = "Reserved", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "G", FileExtension = "mpu", Description = "Reserved", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "J", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "J", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "J", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "K", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "K", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "K", FileExtension = "mpu", Description = "Priority Mail Flat - Large Box APO/FPO", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "L", FileExtension = "mpu", Description = "Library", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "L", FileExtension = "mpu", Description = "Library", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "L", FileExtension = "mpu", Description = "Library", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "N", FileExtension = "mpu", Description = "Nonprofit", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "N", FileExtension = "mpu", Description = "Nonprofit", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "N", FileExtension = "mpu", Description = "Nonprofit", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "O", FileExtension = "mpu", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "O", FileExtension = "mpu", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "O", FileExtension = "mpu", Description = "Priority Mail Small Flat-Rate Box", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "P", FileExtension = "mpu", Description = "Parcel Select LW", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "R", FileExtension = "mpu", Description = "Regular (US/MEX/CAN)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "R", FileExtension = "mpu", Description = "Regular (US/MEX/CAN)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "R", FileExtension = "mpu", Description = "Regular (US/MEX/CAN)", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "S", FileExtension = "mpu", Description = "Science of Agriculture", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "S", FileExtension = "mpu", Description = "Science of Agriculture", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "S", FileExtension = "mpu", Description = "Science of Agriculture", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T", FileExtension = "mpu", Description = "Priority", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T", FileExtension = "mpu", Description = "Priority", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T", FileExtension = "mpu", Description = "Priority", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T1", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T1", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T1", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 1", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T2", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T2", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T2", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 2", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T3", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T3", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T3", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 3", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T4", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T4", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T4", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 4", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "T5", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "T5", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "T5", FileExtension = "mpu", Description = "Priority Mail Cubic - Tier 5", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "W", FileExtension = "mpu", Description = "Science of Agriculture Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "W", FileExtension = "mpu", Description = "Science of Agriculture Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "W", FileExtension = "mpu", Description = "Science of Agriculture Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "X", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "X", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "X", FileExtension = "mpu", Description = "Other", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "Y", FileExtension = "mpu", Description = "Regular Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "Y", FileExtension = "mpu", Description = "Regular Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "Y", FileExtension = "mpu", Description = "Regular Limited Circulation", FieldCode = "MPU-1112", FieldName = "MailPieceUnitRateType" });
		}
	}
}