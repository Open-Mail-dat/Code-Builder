using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatDecimalConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}

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