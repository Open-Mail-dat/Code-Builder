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
// LICENSE (GNU Lesser General Public License)
// LICENSE-GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
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
	public class MaildatStringConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string returnValue = null;

			if (value is string s && !string.IsNullOrWhiteSpace(s.Trim()))
			{
				returnValue = s.Trim();
			}

			return returnValue;
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

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