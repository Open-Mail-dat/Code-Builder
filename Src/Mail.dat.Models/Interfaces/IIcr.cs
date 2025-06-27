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
// This code was auto-generated on June 22nd, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Relates containers to associated ink jet output tapes/files.
	/// </summary>
	public interface IIcr : IMaildatEntity 
	{
		/// <summary>
		/// Job ID (ICR-1001)
		/// (Zero fill prior to numeric, if numeric only). See Header File’s Job Id.
		/// </summary>
		string JobId { get; set; }

		/// <summary>
		/// File Name (ICR-1101)
		/// The agreed file name describing the content of the single transmitted file within which this
		/// container exists.
		/// </summary>
		string FileName { get; set; }

		/// <summary>
		/// Tape ID (ICR-1102)
		/// The identifying A/N string for the tape within which this container exists. Use arbitrary sequence
		/// number if non-inkjet transmission.
		/// </summary>
		string TapeId { get; set; }

		/// <summary>
		/// Container ID (ICR-1006)
		/// See Container Summary File's Container ID definition.
		/// </summary>
		int ContainerId { get; set; }

		/// <summary>
		/// Beginning Record (ICR-1103)
		/// The record number of the first address on the file/tape that is for the container defined within
		/// this record.
		/// </summary>
		int? BeginningRecord { get; set; }

		/// <summary>
		/// Ending Record (ICR-1104)
		/// The record number of the last address on the file/tape that is for the container defined within this
		/// record.
		/// </summary>
		int? EndingRecord { get; set; }

		/// <summary>
		/// ICR Record Status (ICR-2000)
		/// O, D, I, U.
		/// </summary>
		string IcrRecordStatus { get; set; }

		/// <summary>
		/// Reserve (ICR-1105)
		/// Reserved for future use.
		/// </summary>
		string ReserveIcr1105 { get; set; }

		/// <summary>
		/// Closing Character (ICR-9999)
		/// Must be the # sign.
		/// </summary>
		string ClosingCharacter { get; }
	}
}