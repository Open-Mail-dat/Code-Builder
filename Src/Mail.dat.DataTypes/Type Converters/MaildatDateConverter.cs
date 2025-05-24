using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatDateConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			DateOnly? returnValue = null;

			if (value is string s)
			{
				if (!string.IsNullOrEmpty(s.Trim()) && s.Trim().Length == 8)
				{
					//
					// Parse the string as a date.
					//
					// yyyyMMdd
					//
					returnValue = DateOnly.ParseExact(s.ToString(), "yyyyMMdd", culture);
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

			if (destinationType == typeof(string) && value is DateOnly date)
			{
				returnValue = date.ToString("yyyyMMdd");
			}
			else
			{
				returnValue = "        ";
			}

			return returnValue;
		}
	}
}