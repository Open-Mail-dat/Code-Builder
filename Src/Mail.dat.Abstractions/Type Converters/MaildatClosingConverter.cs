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
using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	/// <summary>
	/// Provides a type converter to handle conversions between strings and the Mail.dat closing tag format.
	/// </summary>
	/// <remarks>This converter is specifically designed to process the closing tag for Mail.dat files, which is
	/// always represented as "#". It supports converting from and to string types, ensuring proper handling of the
	/// Mail.dat closing tag format.</remarks>
	public class MaildatClosingConverter : TypeConverter
	{
		/// <summary>
		/// Determines whether the converter can convert an object of the specified type to the type of this converter.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="sourceType">The <see cref="Type"/> representing the type to evaluate for conversion.</param>
		/// <returns><see langword="true"/> if the <paramref name="sourceType"/> is <see cref="string"/>; otherwise, <see
		/// langword="false"/>.</returns>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}

		/// <summary>
		/// Converts the specified value to a trimmed string.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that provides culture-specific information. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="value">The value to convert. Must be of type <see cref="string"/>.</param>
		/// <returns>A <see cref="string"/> that is the trimmed version of the input value, or <see langword="null"/> if the input
		/// value is <see langword="null"/> or not a string.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string returnValue = null;

			if (value is string s)
			{
				returnValue = s.Trim();
			}

			return returnValue;
		}

		/// <summary>
		/// Determines whether this converter can convert an object to the specified destination type.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.</param>
		/// <param name="destinationType">The <see cref="Type"/> representing the type to evaluate for conversion. This parameter cannot be null.</param>
		/// <returns><see langword="true"/> if the converter can convert to the specified <paramref name="destinationType"/>;
		/// otherwise, <see langword="false"/>.</returns>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		/// <summary>
		/// Converts the specified value to the desired type, overriding the default behavior.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that specifies the culture to use during conversion. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="value">The object to convert. This parameter is not used in this implementation.</param>
		/// <param name="destinationType">The <see cref="Type"/> to which the value is being converted. This parameter is not used in this implementation.</param>
		/// <returns>A <see cref="string"/> representing the closing tag for Mail.dat files, which is always "#".</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			//
			// The closing tag for Mail.dat files is always "#".
			//
			return "#"; 
		}
	}
}