using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatZipCodeConverter : TypeConverter
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
				//
				// Space filled left-aligned.
				//
				returnValue = stringValue.PadRight(attribute.Length, ' ');
			}
			else
			{
				//
				// Default is space filled left-aligned.
				//
				returnValue = "".PadLeft(attribute.Length, ' ');
			}

			return returnValue;
		}
	}
}