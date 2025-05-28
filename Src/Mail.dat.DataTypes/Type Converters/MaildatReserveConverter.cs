using System.ComponentModel;
using System.Globalization;

namespace Mail.dat
{
	public class MaildatReserveConverter : TypeConverter
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
			//
			// Get attribute from the context.
			//
			MaildatFieldAttribute attribute = context.Get().MaildatFieldAttribute;

			//
			// Preserve any value entered into thsi field.
			//
			return Convert.ToString(value).PadRight(attribute.Length, ' ');
		}
	}
}