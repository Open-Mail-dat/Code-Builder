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
	/// Provides conversion between <see cref="DateOnly"/> and its string representation in the "yyyyMMdd" format,
	/// specifically for use with Mail.dat fields.
	/// </summary>
	/// <remarks>This converter is designed to handle the specific date format used in Mail.dat files. It supports
	/// converting from a string to a <see cref="DateOnly"/> object and vice versa. The string representation must be
	/// exactly 8 characters long and follow the "yyyyMMdd" format.</remarks>
	public class MaildatDateConverter : TypeConverter
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
		/// Converts the specified value to a <see cref="DateOnly"/> object using the provided context and culture
		/// information.
		/// </summary>
		/// <remarks>This method attempts to parse a string representation of a date in the "yyyyMMdd" format into a
		/// <see cref="DateOnly"/> object. If the input string is null, empty, or does not match the expected format, the
		/// method returns <see langword="null"/>.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be used to extract
		/// additional information about the environment from which this converter is invoked. May be <see langword="null"/>.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that provides culture-specific formatting information. If <see
		/// langword="null"/>, the current culture is used.</param>
		/// <param name="value">The value to convert. This is expected to be a <see cref="string"/> in the format "yyyyMMdd". If the value is not
		/// a valid string or does not match the expected format, the method returns <see langword="null"/>.</param>
		/// <returns>A <see cref="DateOnly"/> object representing the parsed date if the conversion is successful; otherwise, <see
		/// langword="null"/>.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			DateOnly? returnValue = null;

			if (value is string s)
			{
				if (!string.IsNullOrEmpty(s.Trim()) && s.Trim().Length == 8)
				{
					//
					// Parse the string as a date.
					//
					// yyyyMMdd
					//
					returnValue = DateOnly.ParseExact(s.ToString(), "yyyyMMdd", culture);
				}
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
		/// Converts the specified value to the desired destination type, applying formatting and length constraints based on
		/// the context and attributes.
		/// </summary>
		/// <remarks>If the value is not of type <see cref="DateOnly"/> or the destination type is not <see
		/// cref="string"/>, the method returns a blank string padded with spaces to the length specified by the <see
		/// cref="MaildatFieldAttribute"/>. The returned string is truncated to ensure it does not exceed the specified
		/// length.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides contextual information about the component and its
		/// environment. This is used to retrieve additional metadata, such as the <see cref="MaildatFieldAttribute"/>.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that specifies culture-specific formatting. This parameter is not used in the
		/// current implementation.</param>
		/// <param name="value">The value to convert. This must be of type <see cref="DateOnly"/> if the destination type is <see cref="string"/>.</param>
		/// <param name="destinationType">The type to which the value is being converted. This must be <see cref="string"/> for the conversion to succeed.</param>
		/// <returns>A <see cref="string"/> representation of the value, formatted as "yyyyMMdd" if the value is a <see
		/// cref="DateOnly"/>, or a blank string padded with spaces to match the length specified by the <see
		/// cref="MaildatFieldAttribute"/>.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;
			
			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is DateOnly dateValue)
			{
				returnValue = dateValue.ToString("yyyyMMdd");
			}
			else
			{
				//
				// Default is a blank string filled with spaces.
				//
				returnValue = "".PadLeft(attribute.Length, ' ');
			}

			//
			// Limit the return value to the specified length.
			//
			return returnValue.Limit(attribute.Length);
		}
	}
}