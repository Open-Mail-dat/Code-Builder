using System.Runtime.CompilerServices;
using Microsoft.Extensions.Primitives;

namespace Mail.dat
{
	public static class StringDecorator
	{
		/// <summary>
		/// Limits a string to the given length by truncating characters. If
		/// the string is less than the given length, the string is unmodified.
		/// </summary>
		/// <param name="text">The string to be truncated.</param>
		/// <param name="maxLength">The maximum length in characters of the string.</param>
		/// <returns>A new string that is no longer than maxLength in characters.</returns>
		public static string Limit(this string text, int maxLength)
		{
			string returnValue = string.Empty;

			if (!string.IsNullOrEmpty(text))
			{
				if (text.Length > maxLength)
				{
					returnValue = text[..maxLength];
				}
				else
				{
					returnValue = text;
				}
			}

			return returnValue;
		}

		public static bool IsNumeric(this string value)
		{
			return int.TryParse(value, out int _);
		}
	}
}
