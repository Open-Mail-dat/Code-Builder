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
	/// Provides a type converter to convert between <see cref="string"/> and <see cref="int"/> values for Mail.dat fields,
	/// with support for custom formatting and padding based on field attributes.
	/// </summary>
	/// <remarks>This converter is designed to handle Mail.dat-specific formatting requirements, such as
	/// left-justified or zero-filled numeric strings, based on the <see cref="MaildatFieldAttribute"/> associated with the
	/// context. It supports conversions from <see cref="string"/> to <see cref="int"/> and vice versa, applying the
	/// appropriate formatting rules during the conversion process.</remarks>
	public class MaildatIntegerConverter : TypeConverter
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
		/// Converts the specified string representation of a number to an integer.
		/// </summary>
		/// <remarks>If the <paramref name="value"/> is not a string or is an empty or whitespace-only string, the
		/// method returns <see langword="null"/>.</remarks>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter is not used in the
		/// conversion.</param>
		/// <param name="culture">A <see cref="CultureInfo"/> object that provides culture-specific formatting information. This parameter is not
		/// used in the conversion.</param>
		/// <param name="value">The object to convert. Must be a non-null, non-empty string representing a valid integer.</param>
		/// <returns>An <see cref="int"/> representing the converted value if the input is a valid string representation of an integer;
		/// otherwise, <see langword="null"/>.</returns>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object returnValue = null;

			if (value is string s && s.Trim().Length > 0)
			{
				returnValue = Convert.ToInt32(s.Trim());
			}

			return returnValue;
		}

		/// <summary>
		/// Determines whether this converter can convert an object to the specified destination type.
		/// </summary>
		/// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be <see
		/// langword="null"/>.</param>
		/// <param name="destinationType">The <see cref="Type"/> to evaluate for conversion. This parameter cannot be <see langword="null"/>.</param>
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
		/// <remarks>The formatting behavior is determined by the <see cref="MaildatFieldAttribute"/> associated  with
		/// the context. Supported formatting options include left justification, zero-filling,  and space-filling, depending
		/// on the attribute's <c>DataType</c> and <c>Format</c> properties.  If the input value is not numeric when numeric
		/// formatting is required, a default space-filled  string is returned.</remarks>
		/// <param name="context">Provides contextual information about the component, including access to the  <see cref="MaildatFieldAttribute"/>
		/// that defines formatting rules such as data type,  alignment, and required length.</param>
		/// <param name="culture">An optional <see cref="CultureInfo"/> object that provides culture-specific formatting  information. This
		/// parameter is not used in the current implementation.</param>
		/// <param name="value">The value to be converted. Must be of type <see cref="int"/> or <see cref="string"/>  to be processed; otherwise,
		/// a default formatted string is returned.</param>
		/// <param name="destinationType">The type to which the value should be converted. This method supports conversion to  <see cref="string"/> only.</param>
		/// <returns>A formatted string representation of the input value, adhering to the rules specified  by the <see
		/// cref="MaildatFieldAttribute"/>. The returned string is padded or truncated  to match the required length and
		/// alignment.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && (value is int || value is string))
			{
				if (attribute.DataType == "A/N")
				{
					if (attribute.Format == "leftjustify")
					{
						//
						// Space filled left-aligned.
						//
						returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
					}
					else if (attribute.Format == "zfillnumeric")
					{
						if (Convert.ToString(value).IsNumeric())
						{
							if (attribute.Required)
							{
								//
								// Zero filled right-aligned.
								//
								returnValue = Convert.ToString(value).PadRight(attribute.Length, '0');
							}
							else
							{
								//
								// Space filled left-aligned.
								//
								returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
							}
						}
						else
						{
							//
							// Space filled left-aligned.
							//
							returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
						}
					}
					else
					{
						//
						// Space filled left-aligned.
						//
						returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
					}
				}
				else
				{
					if (attribute.Format == "leftjustify")
					{
						if (Convert.ToInt32(value) != 0)
						{
							//
							//
							// Space filled left-aligned.
							//
							returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
						}
						else
						{
							//
							// Default is a blank string filled with spaces.
							//
							returnValue = "".PadLeft(attribute.Length, ' ');
						}
					}
					else if (attribute.Format == "zfill")
					{
						if (Convert.ToString(value).IsNumeric())
						{
							if (attribute.Required)
							{
								//
								// Zero filled right-aligned.
								//
								returnValue = Convert.ToString(value).PadLeft(attribute.Length, '0');
							}
							else
							{
								if (!string.IsNullOrWhiteSpace(Convert.ToString(value)))
								{
									//
									// Zero filled right-aligned.
									//
									returnValue = Convert.ToString(value).PadLeft(attribute.Length, '0');
								}
								else
								{
									//
									// Default is a blank string filled with spaces.
									//
									returnValue = "".PadLeft(attribute.Length, ' ');
								}
							}
						}
						else
						{
							//
							// Space filled left-aligned.
							//
							returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
						}
					}
					else
					{
						//
						// Space filled left-aligned.
						//
						returnValue = Convert.ToString(value).PadRight(attribute.Length, ' ');
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