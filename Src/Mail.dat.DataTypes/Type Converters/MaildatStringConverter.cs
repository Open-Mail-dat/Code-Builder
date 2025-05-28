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