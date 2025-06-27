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
	/// Provides a custom type converter for handling the conversion of Mail.dat reserve fields.
	/// </summary>
	/// <remarks>This converter is designed to handle the conversion of Mail.dat reserve fields to and from strings.
	/// It ensures that input strings are trimmed of whitespace and that output strings are padded to a specified length,
	/// as defined by the <see cref="MaildatFieldAttribute"/> associated with the context.</remarks>
	public class MaildatReserveConverter : TypeConverter
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
		/// <param name="value">The value to convert. Must be a non-null string.</param>
		/// <returns>A trimmed string if the input is a non-empty string; otherwise, <see langword="null"/>.</returns>
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
		/// Converts the specified value to the specified destination type, applying formatting based on the context and
		/// culture.
		/// </summary>
		/// <remarks>This method retrieves the <see cref="MaildatFieldAttribute"/> from the provided context to
		/// determine the required padding length. The resulting string is right-padded with spaces to match the specified
		/// length.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides contextual information about the component and its
		/// environment. This is used to retrieve the <see cref="MaildatFieldAttribute"/> associated with the conversion.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that specifies the culture to use during the conversion. If null, the current
		/// culture is used.</param>
		/// <param name="value">The object to convert. This value is formatted and padded based on the associated <see
		/// cref="MaildatFieldAttribute"/>.</param>
		/// <param name="destinationType">The <see cref="Type"/> to which the value is being converted. This must be a string type for this implementation.</param>
		/// <returns>A <see cref="string"/> representation of the input value, padded to the length specified by the <see
		/// cref="MaildatFieldAttribute"/>.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			//
			// Preserve any value entered into thsi field.
			//
			return Convert.ToString(value).PadRight(attribute.Length, ' ');
		}
	}
}