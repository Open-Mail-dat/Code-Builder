using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatDateConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
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
			return destinationType == typeof(string);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			string returnValue = null;
			
			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			if (destinationType == typeof(string) && value is DateOnly dateValue)
			{
				returnValue = dateValue.ToString("yyyyMMdd");
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