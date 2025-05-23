﻿using System.Text;
using Humanizer;

namespace Mail.dat.CodeBuilder
{
	public static class StringDecorator
	{
		public static string Sanitize(this string value)
		{
			return value.Replace("\"", "").Replace("\r", "").Replace("\n", "").Trim();
		}

		public static string KeywordSanitize(this string value)
		{
			string returnValue = value;

			if (!string.IsNullOrWhiteSpace(value))
			{
				returnValue = value.Sanitize().Replace("/", "").Replace("-", "").Replace("'", "").Trim();

				//
				// Check if the first character is a number.
				//
				if (char.IsNumber(returnValue[0]))
				{
					string x = Convert.ToInt32(returnValue[0].ToString()).ToWords().Titleize();
					returnValue = $"{x}{returnValue.Substring(1, returnValue.Length - 1)}";
				}
			}

			return returnValue;
		}

		public static string EndSentence(this string value)
		{
			string returnValue = value;

			if (!string.IsNullOrWhiteSpace(value))
			{
				if (!value.EndsWith('.'))
				{
					returnValue = $"{value}.";
				}
			}

			return returnValue;
		}

		public static string AddRecord(this string value)
		{
			string returnValue = value;

			if (!string.IsNullOrWhiteSpace(value))
			{
				if (!value.EndsWith(" Record"))
				{
					returnValue = $"{value} Record";
				}
			}

			return returnValue;
		}

		public static List<string> Split(this string input, int maxLength)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				return [];
			}

			string[] words = input.Split(' ');
			List<string> lines = [];
			StringBuilder currentLine = new();

			foreach (string word in words)
			{
				if (currentLine.Length > 0)
				{
					if (currentLine.Length + 1 + word.Length <= maxLength)
					{
						currentLine.Append(' ').Append(word);
					}
					else
					{
						lines.Add(currentLine.ToString());
						currentLine.Clear();

						if (word.Length <= maxLength)
						{
							currentLine.Append(word);
						}
						else
						{
							// Split the long word
							int index = 0;
							while (index < word.Length)
							{
								int length = Math.Min(maxLength, word.Length - index);
								lines.Add(word.Substring(index, length));
								index += length;
							}
						}
					}
				}
				else
				{
					if (word.Length <= maxLength)
					{
						currentLine.Append(word);
					}
					else
					{
						// Split the long word
						int index = 0;
						while (index < word.Length)
						{
							int length = Math.Min(maxLength, word.Length - index);
							lines.Add(word.Substring(index, length));
							index += length;
						}
					}
				}
			}

			if (currentLine.Length > 0)
			{
				lines.Add(currentLine.ToString());
			}

			return lines;
		}

		public static string ToDotNetType(this string type)
		{
			string returnValue = type;

			switch (type)
			{
				case "enum":
					returnValue = "string";
					break;
				case "integer":
					returnValue = "int";
					break;
				case "zipcode":
					returnValue = "string";
					break;
				case "time":
					returnValue = "TimeOnly";
					break;
				case "date":
					returnValue = "DateOnly";
					break;
				case "reserve":
					returnValue = "string";
					break;
				case "closing":
					returnValue = "string";
					break;
				default:
					returnValue = type;
					break;
			}

			return returnValue;
		}
	}
}
