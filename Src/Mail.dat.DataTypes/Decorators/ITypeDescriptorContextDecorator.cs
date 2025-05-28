using System.ComponentModel;

namespace Mail.dat
{
	public static class ITypeDescriptorContextDecorator
	{
		public static ConverterContext Get(this ITypeDescriptorContext context)
		{
			if (context is ConverterContext converterContext)
			{
				return converterContext;
			}
			else
			{
				throw new InvalidOperationException("The context is not a ConverterContext.");
			}
		}
	}
}
