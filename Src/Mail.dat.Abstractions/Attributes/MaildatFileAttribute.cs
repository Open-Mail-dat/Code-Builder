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
	/// Attribute to specify the characteristics of a Maildat fle.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class MaildatFileAttribute : Attribute
    {
        public MaildatFileAttribute()
        {
        }

		/// <summary>
		/// The Mail.dat version this code was generated from.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// The Mail.dat revision this code was generated from.
		/// </summary>
		public string Revision { get; set; }

		/// <summary>
		/// The extension of the file.
		/// </summary>
		public string Extension { get; set; }

		/// <summary>
		/// The long name of the file..
		/// </summary>
		public string File { get; set; }

		/// <summary>
		/// The description of the file.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The summary of the file.
		/// </summary>
		public string Summary { get; set; }

		/// <summary>
		/// The length of the line not including any line terminators.
		/// </summary>
		public int LineLength { get; set; }

		/// <summary>
		/// The charcater that marks the end of a line in the file.
		/// </summary>
		public string ClosingCharacter { get; set; }
	}
}
