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
	/// Provides custom conversion logic for handling string values in the context of Maildat fields.
	/// </summary>
	/// <remarks>This class extends <see cref="TypeConverter"/> to enable conversion between string values and 
	/// their formatted representations based on Maildat field attributes. It supports trimming input  strings and applying
	/// specific formatting rules, such as zero-padding or alignment, as defined  by the <see
	/// cref="MaildatFieldAttribute"/> associated with the context.</remarks>
	public class MaildatStringConverter : TypeConverter
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
		/// <remarks>This method applies specific formatting rules based on the <see cref="MaildatFieldAttribute"/>:
		/// <list type="bullet"> <item> <description> If the data type is "A/N" (alphanumeric), the value is padded with
		/// spaces or zeros depending on the specified format (e.g., "zfillnumeric", "leftjustify", "rightjustify").
		/// </description> </item> <item> <description> If the data type is "N" (numeric), additional rules such as
		/// zero-filling or date-specific formatting (e.g., "YYYYMMDD") are applied. </description> </item> <item>
		/// <description> If the input value does not meet the expected format or data type, a default blank string of the
		/// specified length is returned. </description> </item> </list> The returned string is always truncated or padded to
		/// match the length specified in the <see cref="MaildatFieldAttribute"/>.</remarks>
		/// <param name="context">Provides contextual information about the component, including the associated <see cref="MaildatFieldAttribute"/>
		/// that defines formatting rules such as data type, length, and alignment.</param>
		/// <param name="culture">An optional <see cref="CultureInfo"/> object that provides culture-specific formatting information. This parameter
		/// is not used in the current implementation.</param>
		/// <param name="value">The value to be converted. Must be a <see cref="string"/> if the destination type is <see cref="string"/>.</param>
		/// <param name="destinationType">The type to which the value should be converted. This method supports conversion to <see cref="string"/> only.</param>
		/// <returns>A formatted <see cref="string"/> representation of the input value, adjusted according to the rules defined in the
		/// <see cref="MaildatFieldAttribute"/>. If the input value is not a string or the destination type is not <see
		/// cref="string"/>, a blank string of the specified length is returned.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is string stringValue)
			{
				if (attribute.DataType == "A/N")
				{
					if (attribute.Format == "zfillnumeric")
					{
						if (stringValue.IsNumeric())
						{
							//
							// Zero filled right-aligned.
							//
							returnValue = stringValue.PadLeft(attribute.Length, '0');
						}
						else
						{
							//
							// Space filled left-aligned.
							//
							returnValue = stringValue.PadRight(attribute.Length, ' ');
						}
					}
					else if (attribute.Format == "leftjustify")
					{
						//
						// Space filled left-aligned.
						//
						returnValue = stringValue.PadRight(attribute.Length, ' ');
					}
					else if (attribute.Format == "rightjustify")
					{
						//
						// Space filled right-aligned.
						//
						returnValue = stringValue.PadLeft(attribute.Length, ' ');
					}
					else
					{
						//
						// Default space filled right-aligned.
						//
						returnValue = stringValue.PadRight(attribute.Length, ' ');
					}
				}
				else if (attribute.DataType == "N")
				{
					if (attribute.Format == "zfill")
					{
						if (stringValue.IsNumeric())
						{
							//
							// Zero filled right-aligned.
							//
							returnValue = stringValue.PadLeft(attribute.Length, '0');
						}
						else
						{
							//
							// Space filled left-aligned.
							//
							returnValue = stringValue.PadRight(attribute.Length, ' ');
						}
					}
					else if (attribute.Format == "YYYYMMDD")
					{
						//
						// Cannot be all 0's.
						//
						if (stringValue == "00000000")
						{
							//
							// Default is a blank string fill with spaces.
							//
							returnValue = "".PadLeft(attribute.Length, ' ');
						}
						else
						{
							//
							// Space filled left-aligned.
							//
							returnValue = stringValue.PadRight(attribute.Length, ' ');
						}
					}
					else
					{
						//
						// Space filled left-aligned.
						//
						returnValue = stringValue.PadRight(attribute.Length, ' ');
					}
				}
				else
				{
					//
					// Most likely a reserved field mis-marked. Default left-aligned.
					//
					returnValue = stringValue.PadRight(attribute.Length, ' ');
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