using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatDecimalConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			decimal returnValue = 0;

			if (value is string s)
			{
				if (s.Trim().Length > 0)
				{
					returnValue = Convert.ToDecimal(s.Trim());
				}
			}

			return returnValue;
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object returnValue = null;

			if (destinationType == typeof(string) && value is int dec)
			{
				returnValue = dec.ToString();
			}
			else
			{
				returnValue = base.ConvertTo(context, culture, value, destinationType);
			}

			return returnValue;
		}
	}
}