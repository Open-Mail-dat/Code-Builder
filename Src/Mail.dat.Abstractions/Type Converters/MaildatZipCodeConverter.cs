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
	/// Provides conversion logic for handling Mail.dat ZIP code fields, enabling conversion between string representations
	/// and their formatted equivalents.
	/// </summary>
	/// <remarks>This class is designed to handle the specific formatting requirements of Mail.dat ZIP code fields.
	/// It supports converting from and to string types, ensuring proper trimming and padding as needed to meet the
	/// expected format. The conversion behavior is influenced by the <see cref="MaildatFieldAttribute"/> associated with
	/// the context, which specifies the required field length.</remarks>
	public class MaildatZipCodeConverter : TypeConverter
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
		/// <param name="value">The value to convert. Must be a <see cref="string"/> or <see langword="null"/>.</param>
		/// <returns>A trimmed <see cref="string"/> if the input value is a non-empty string; otherwise, <see langword="null"/>.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string returnValue = null;

			if (value is string s && !string.IsNullOrWhiteSpace(s.Trim()))
			{
				returnValue = s.Trim();
			}

			return returnValue;
		}

		/// <summary>
		/// Determines whether this converter can convert an object to the specified destination type.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.</param>
		/// <param name="destinationType">The <see cref="Type"/> representing the desired type to convert to. This parameter cannot be null.</param>
		/// <returns><see langword="true"/> if the converter can convert to the specified <paramref name="destinationType"/>;
		/// otherwise, <see langword="false"/>.</returns>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		/// <summary>
		/// Converts the specified value to the desired destination type, applying formatting rules based on the <see
		/// cref="MaildatFieldAttribute"/> associated with the context.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides contextual information about the component and its
		/// environment. This is used to retrieve the <see cref="MaildatFieldAttribute"/> that defines formatting rules.</param>
		/// <param name="culture">An optional <see cref="CultureInfo"/> object that provides culture-specific formatting information. This parameter
		/// is not used in the current implementation.</param>
		/// <param name="value">The object to convert. Must be a <see cref="string"/> if the destination type is <see cref="string"/>.</param>
		/// <param name="destinationType">The <see cref="Type"/> to which the value should be converted. Only <see cref="string"/> is supported as the
		/// destination type.</param>
		/// <returns>A <see cref="string"/> that represents the converted value, formatted as a space-filled, left-aligned string with
		/// a length defined by the <see cref="MaildatFieldAttribute.Length"/> property. If the input value is not a string or
		/// the destination type is not <see cref="string"/>, a default space-filled string of the specified length is
		/// returned.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is string stringValue)
			{
				//
				// Space filled left-aligned.
				//
				returnValue = stringValue.PadRight(attribute.Length, ' ');
			}
			else
			{
				//
				// Default is space filled left-aligned.
				//
				returnValue = "".PadLeft(attribute.Length, ' ');
			}

			return returnValue;
		}
	}
}