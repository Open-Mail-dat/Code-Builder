using Humanizer;
using Mail.dat.BuildCommand;

namespace Mail.dat.BuildCommand
{
	public static class KeyNamesDecorator
	{
		public static string ToClassName(this string value)
		{
			return value.TruePascalize();
		}

		public static string ToInterfaceName(this string value)
		{
			return $"I{value.ToClassName()}";
		}

		public static string ToClassFileName(this string value)
		{
			return $"{value.TruePascalize()}.cs";
		}

		public static string ToPropertyName(this object value, object fieldCode)
		{
			string returnValue = null;

			if (value is null)
			{
				throw new ArgumentNullException(nameof(value), "Field name cannot be null.");
			}

			returnValue = value.ToString().Dehumanize().TruePascalize().KeywordSanitize();

			if (returnValue == "Reserve")
			{
				returnValue = $"{returnValue}{fieldCode.ToString().Dehumanize().TruePascalize().KeywordSanitize()}";
			}

			return returnValue;
		}
	}
}
