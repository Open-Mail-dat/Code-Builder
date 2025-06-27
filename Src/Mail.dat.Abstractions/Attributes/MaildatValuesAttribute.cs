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
	/// Attribute to specify that this property has a list of values.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class MaildatValuesAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MaildatValuesAttribute"/> class with the specified type.
		/// </summary>
		/// <param name="type">The type associated with the attribute. This value cannot be <see langword="null"/>.</param>
		public MaildatValuesAttribute(Type type)
		{
			this.Type = type;
		}

		/// <summary>
		/// Gets or sets the type of the object represented by this instance.
		/// </summary>
		public Type Type { get; set; }
	}
}
