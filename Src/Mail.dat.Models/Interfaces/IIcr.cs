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