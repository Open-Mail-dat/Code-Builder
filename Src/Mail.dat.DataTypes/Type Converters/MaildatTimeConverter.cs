using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatTimeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

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

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object returnValue = null;

			if (destinationType == typeof(string) && value is TimeOnly date)
			{
				returnValue = date.ToString("hh:mm");
			}
			else
			{
				returnValue = "    ";
			}

			return returnValue;
		}
	}
}