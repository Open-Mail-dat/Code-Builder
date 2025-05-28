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
			int? returnValue = null;

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