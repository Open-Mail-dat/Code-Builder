using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatTimeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
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
			return destinationType == typeof(string);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;

			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is TimeOnly timeValue)
			{
				//
				// For the time as hh:mm.
				//
				returnValue = timeValue.ToString("hh:mm");
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