//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
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
// LICENSE.GPL3 (GNU General Public License)
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
	public class MaildatIntegerConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object returnValue = null;

			if (value is string s && s.Trim().Length > 0)
			{
				returnValue = Convert.ToInt32(s.Trim());
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