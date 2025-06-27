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
	/// Provides conversion between <see cref="TimeOnly"/> and <see cref="string"/> representations in the format "hh:mm",
	/// specifically for use with Mail.dat fields.
	/// </summary>
	/// <remarks>This converter is designed to handle time values in the "hh:mm" format, ensuring compatibility with
	/// Mail.dat field requirements. It supports converting from a string to a <see cref="TimeOnly"/> instance and vice
	/// versa. The conversion process enforces specific formatting rules and truncates or pads strings as needed to meet
	/// field length constraints.</remarks>
	public class MaildatTimeConverter : TypeConverter
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
		/// Converts the specified value to a <see cref="TimeOnly"/> object.
		/// </summary>
		/// <remarks>This method attempts to parse a string representation of a time in the "hh:mm" format into a <see
		/// cref="TimeOnly"/> object.  The input string must be non-empty, trimmed, and exactly 5 characters long. If the
		/// input does not meet these criteria,  the method returns <see langword="null"/>.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be used to  extract
		/// additional information about the environment from which this converter is invoked. May be <see langword="null"/>.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that specifies the culture to use during conversion. If <see langword="null"/>,
		/// the current culture is used.</param>
		/// <param name="value">The value to convert. This is expected to be a <see cref="string"/> in the format "hh:mm".</param>
		/// <returns>A <see cref="TimeOnly"/> object representing the parsed time if the conversion is successful; otherwise, <see
		/// langword="null"/>.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			TimeOnly? returnValue = null;

			if (value is string s)
			{
				if (!string.IsNullOrEmpty(s.Trim()) && s.Trim().Length == 5)
				{
					//
					// Parse the string as a time.
					//
					// 00:00 - 23:59
					// 12:00 - 12:59
					// 01:00 - 01:59
					//
					// hh:mm
					//
					returnValue = TimeOnly.ParseExact(s.ToString(), "hh:mm", culture);
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
		/// Converts the specified value to the desired destination type, using the provided context and culture information.
		/// </summary>
		/// <remarks>The method uses the <see cref="MaildatFieldAttribute"/> associated with the context to determine
		/// the length of the output string. If the value is a <see cref="TimeOnly"/>, it is formatted as "hh:mm". Otherwise,
		/// a blank string of the specified length is returned. The resulting string is truncated or padded to match the
		/// length defined by the attribute.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides contextual information about the component or property being
		/// converted.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that specifies culture-specific formatting information. If null, the current
		/// culture is used.</param>
		/// <param name="value">The object to convert. This must be of a type compatible with the conversion logic, such as <see
		/// cref="TimeOnly"/>.</param>
		/// <param name="destinationType">The <see cref="Type"/> to which the value should be converted. This must be a valid type, such as <see
		/// cref="string"/>.</param>
		/// <returns>A <see cref="string"/> representation of the converted value. If the value is a <see cref="TimeOnly"/>, it is
		/// formatted as "hh:mm". If the conversion is not applicable, a blank string padded to the length specified by the
		/// <see cref="MaildatFieldAttribute.Length"/> is returned.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is TimeOnly timeValue)
			{
				//
				// For the time as hh:mm.
				//
				returnValue = timeValue.ToString("hh:mm");
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