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
// Author: Daniel M porrey
//
namespace Mail.dat
{
	/// <summary>
	/// Represents an error encountered during the processing of a maildat entity.
	/// </summary>
	/// <remarks>This interface provides detailed information about an error, including its location, type, and
	/// associated data. It is intended to be implemented by classes that encapsulate error details for diagnostic or
	/// logging purposes.</remarks>
	public interface IError : IMaildatEntity
	{
		/// <summary>
		/// Gets or sets the process identifier or name associated with the current operation.
		/// </summary>
		string Process { get; set; }

		/// <summary>
		/// Gets or sets the file path associated with the operation.
		/// </summary>
		string File { get; set; }

		/// <summary>
		/// Gets or sets the name of the field where the error occurred.
		/// </summary>
		string FieldName { get; set; }

		/// <summary>
		/// Gets or sets the code of the field where the error occurred.
		/// </summary>
		string FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the data type of the field where the error occurred.
		/// </summary>
		string DataType { get; set; }

		/// <summary>
		/// Gets or sets the type of error encountered.
		/// </summary>
		string Type { get; set; }

		/// <summary>
		/// Gets or sets the starting position of the error within the data.
		/// </summary>
		int LineNumber { get; set; }

		/// <summary>
		/// Gets or sets the starting position of the error within the data.
		/// </summary>
		int StartPosition { get; set; }

		/// <summary>
		/// Gets or sets the length of the error in the data.
		/// </summary>
		int Length { get; set; }

		/// <summary>
		/// Gets or sets the value associated with the error.
		/// </summary>
		string Value { get; set; }

		/// <summary>
		/// Gets or sets the error message associated with the error.
		/// </summary>
		string ErrorMessage { get; set; }
	}
}