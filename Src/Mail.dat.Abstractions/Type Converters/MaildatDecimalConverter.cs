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
	/// Provides conversion between <see cref="string"/> and <see cref="decimal"/> values for Mail.dat fields, applying
	/// precision and formatting rules defined by the associated <see cref="MaildatFieldAttribute"/>.
	/// </summary>
	/// <remarks>This converter is designed to handle Mail.dat-specific decimal formatting requirements, including
	/// precision adjustments, zero-filling, and alignment based on the attribute's configuration. It supports both
	/// converting from a string to a decimal and converting from a decimal to a formatted string.</remarks>
	public class MaildatDecimalConverter : TypeConverter
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
		/// Converts the specified value to a decimal object, applying precision adjustments based on the context.
		/// </summary>
		/// <remarks>The method retrieves the <see cref="MaildatFieldAttribute"/> from the provided context to
		/// determine the precision to apply during the conversion. The input string is trimmed before processing, and the
		/// precision is applied by dividing the numeric value by 10 raised to the power of the precision.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides contextual information about the component being converted.
		/// The context is used to retrieve the <see cref="MaildatFieldAttribute"/> containing precision details.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that provides culture-specific formatting information. This parameter is not
		/// used in the conversion.</param>
		/// <param name="value">The value to convert. This must be a non-empty <see cref="string"/> that represents a numeric value.</param>
		/// <returns>A <see cref="decimal"/> object representing the converted value, adjusted for precision as specified in the
		/// context. Returns <see langword="null"/> if the input value is not a valid non-empty string.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			decimal? returnValue = null;

			if (value is string s && s.Trim().Length > 0)
			{
				//
				// Get attribute from the context.
				//
				MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

				//
				// Convert the value using the precision.
				//
				returnValue = Convert.ToDecimal(s.Trim()) / (decimal)Math.Pow(10, attribute.Precision);
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
		/// Converts the specified value to the desired destination type, applying formatting rules defined by the <see
		/// cref="MaildatFieldAttribute"/> associated with the context.
		/// </summary>
		/// <remarks>This method applies specific formatting rules based on the <see cref="MaildatFieldAttribute"/>:
		/// <list type="bullet"> <item> <description> If the attribute's format is "zfill" and the value is zero, the method
		/// returns a zero-padded  string of the specified length. The alignment depends on whether the attribute is marked as
		/// required. </description> </item> <item> <description> If the value is a decimal, it is rounded to the precision
		/// specified in the attribute, and the  resulting string is padded to the specified length. </description> </item>
		/// <item> <description> If the value does not meet the above conditions, a blank string filled with spaces is
		/// returned. </description> </item> </list></remarks>
		/// <param name="context">Provides contextual information about the component, including access to the  <see cref="MaildatFieldAttribute"/>
		/// that defines formatting rules such as length, precision,  and alignment.</param>
		/// <param name="culture">An optional <see cref="CultureInfo"/> object that provides culture-specific formatting  information. This
		/// parameter is not used in the current implementation.</param>
		/// <param name="value">The value to convert. Must be a <see cref="decimal"/> if the destination type is a string.</param>
		/// <param name="destinationType">The type to which the value is being converted. This method supports conversion to  <see cref="string"/>.</param>
		/// <returns>A string representation of the value formatted according to the rules specified in the  <see
		/// cref="MaildatFieldAttribute"/>. If the value is not a <see cref="decimal"/> or the  destination type is not <see
		/// cref="string"/>, a blank string filled with spaces is returned.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is decimal decimalValue)
			{
				if (attribute.Format == "zfill" && decimalValue == 0)
				{
					if (attribute.Required)
					{
						//
						// Space filled right-aligned.
						//
						returnValue = "".PadLeft(attribute.Length, '0');
					}
					else
					{
						//
						// Space filled left-aligned.
						//
						returnValue = "".PadRight(attribute.Length, ' ');
					}
				}
				else
				{
					//
					// Round the decimal number using the precision specified in the attribute.
					//
					decimal roundedValue = Math.Round(decimalValue, attribute.Precision);

					//
					// Split the decimal value into the integer and fractional parts. 
					//
					string[] parts = roundedValue.ToString().Split(".");

					if (parts.Length == 1)
					{
						//
						// No decimal part, just the integer part.
						//
						returnValue = $"{parts[0]}{"".PadRight(attribute.Precision, '0')}".PadLeft(attribute.Length, '0');
					}
					else
					{
						//
						// Has a decimal part, so we need to handle it.
						//
						returnValue = $"{parts[0]}{parts[1].PadRight(attribute.Precision, '0')}".PadLeft(attribute.Length, '0');
					}
				}
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