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
// This code was auto-generated on July 9th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Provide summary of transportation trucks.
	/// </summary>
	public interface ITsr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (TSR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// Transportation ID (TSR-1002 )
		/// Unique ID of Transportation records. (zero fill prior to numeric, if numeric only) Key field. To
		/// link to the Transportation Summary Record to all of the Transportation Detail Records Transportation
		/// Geo-data Records, and Transportation Container Records if they exist in the submission.
		/// </summary>
		string TransportationId { get; set; }

		/// <summary>
		/// Load / Truck Dispatch Number (TSR-1101)
		/// Value used by transportation to represent the, ransportation associated. As available, the
		/// applicable transportation information.
		/// </summary>
		string LoadTruckDispatchNumber { get; set; }

		/// <summary>
		/// Target Ship Date/Time (TSR-1102)
		/// Date/Time transportation schedule to ship. In ISO-8601 Format YYYY-MM-DDThh:mm:ssTZD YYYY =
		/// four-digit year MM   = two-digit month (01=January, etc.) DD   = two-digit day of month (01 through
		/// 31) Hh   = two digits of hour (00 through 23) (am/pm NOT allowed) Mm   = two digits of minute (00
		/// through 59) Ss   = two digits of second (00 through 59) TZD  = time zone designator (Z = UTC
		/// designator Or +hh:mm or -hh:mm to express the local Time offset) Note that the T appears literally
		/// in the string, to indicate The beginning of the time element. Example: November 5, 1994, 8:15:30 am,
		/// US Eastern Standard Time. Expressed as local time: 1994-11-05T08:15:30-05:00 Expressed as UTC:
		/// 1994-11-05T13:15:30Z.
		/// </summary>
		string TargetShipDateTime { get; set; }

		/// <summary>
		/// TSR Record Status (TSR-2000)
		/// O, D, I, U.
		/// </summary>
		string TSRRecordStatus { get; set; }

		/// <summary>
		/// Reserved (TSR-1104)
		/// </summary>
		string Reserved { get; set; }

		/// <summary>
		/// Closing Character (TSR-1101)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}