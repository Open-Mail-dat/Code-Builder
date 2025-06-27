//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.Text;
using Humanizer;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Provides string extension methods for sanitization, formatting, and type conversion used throughout the Mail.dat build process.
	/// </summary>
	public static class StringDecorator
	{
		/// <summary>
		/// Sanitizes a string by removing quotes, carriage returns, and newlines, then trims whitespace.
		/// </summary>
		public static string Sanitize(this string value)
		{
			return value.Replace("\"", "").Replace("\r", "").Replace("\n", "").Trim();
		}

		/// <summary>
		/// Sanitizes the input string by removing specific characters and formatting it for use as a keyword.
		/// </summary>
		/// <remarks>This method removes the following characters from the input string: '/', '-', and '''.  It also
		/// trims leading and trailing whitespace. If the first character of the sanitized string  is a number, it is
		/// converted to its word representation (e.g., '1' becomes "One") and  capitalized before being prepended to the rest
		/// of the string.</remarks>
		/// <param name="value">The input string to sanitize. Cannot be null or whitespace.</param>
		/// <returns>A sanitized version of the input string with specific characters removed and formatted.  If the first character is
		/// a number, it is converted to its word representation. Returns an empty string if the input is null or whitespace.</returns>
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

		/// <summary>
		/// Ensures that the specified string ends with a period ('.').
		/// </summary>
		/// <param name="value">The string to process. If <paramref name="value"/> is <see langword="null"/>, empty, or consists only of
		/// whitespace, it is returned unchanged.</param>
		/// <returns>A string that ends with a period ('.') if <paramref name="value"/> is non-empty and does not already end with a
		/// period;  otherwise, the original <paramref name="value"/>.</returns>
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

		/// <summary>
		/// Appends the word "Record" to the end of the specified string if it does not already end with "Record".
		/// </summary>
		/// <param name="value">The input string to which "Record" may be appended. Must not be null or whitespace.</param>
		/// <returns>A string that ends with "Record". If the input string is null, whitespace, or already ends with "Record",  the
		/// original string is returned unchanged.</returns>
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

		/// <summary>
		/// Splits the input string into a list of substrings, ensuring that each substring does not exceed the specified
		/// maximum length.
		/// </summary>
		/// <remarks>This method splits the input string by spaces to preserve word boundaries where possible. If a
		/// single word exceeds the specified <paramref name="maxLength"/>, it is further split into smaller
		/// substrings.</remarks>
		/// <param name="input">The input string to be split. Cannot be null, empty, or consist only of whitespace.</param>
		/// <param name="maxLength">The maximum length of each substring. Must be greater than zero.</param>
		/// <returns>A list of substrings where each substring is no longer than <paramref name="maxLength"/>. If the input string is
		/// null, empty, or consists only of whitespace, an empty list is returned.</returns>
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

		/// <summary>
		/// Converts a specified type, data type, and required flag into an equivalent .NET type representation.
		/// </summary>
		/// <remarks>The method maps specific input types to their corresponding .NET types based on predefined rules.
		/// For example: <list type="bullet"> <item><description>If <paramref name="type"/> is "decimal" and <paramref
		/// name="required"/> is <see langword="true"/>, the result is "decimal"; otherwise, "decimal?".</description></item>
		/// <item><description>If <paramref name="type"/> is "integer" and <paramref name="dataType"/> is "A/N", the result is
		/// "string".</description></item> <item><description>If <paramref name="type"/> is "date", the result is "DateOnly"
		/// or "DateOnly?" depending on <paramref name="required"/>.</description></item> </list> For unsupported or
		/// unrecognized types, the method defaults to returning "string".</remarks>
		/// <param name="type">The type to be converted, such as "decimal", "string", "integer", or other predefined types.</param>
		/// <param name="dataType">Additional information about the data type, such as "A/N" for alphanumeric types. This may influence the resulting
		/// .NET type for certain input types.</param>
		/// <param name="required">A boolean value indicating whether the type is required. If <see langword="true"/>, the resulting .NET type will
		/// be non-nullable where applicable; otherwise, it will be nullable.</param>
		/// <returns>A string representing the equivalent .NET type. For example, "decimal", "int", "string", "DateOnly", or their
		/// nullable counterparts (e.g., "decimal?", "int?") depending on the input parameters.</returns>
		public static string ToDotNetType(this string type, string dataType, bool required)
		{
			string returnValue = "string";

			switch (type)
			{
				case "decimal":
					if (required)
					{
						returnValue = "decimal";
					}
					else
					{
						returnValue = "decimal?";
					}
					break;
				case "string":
					returnValue = "string";
					break;
				case "enum":
					returnValue = "string";
					break;
				case "integer":
					if (dataType == "A/N")
					{
						returnValue = "string";
					}
					else
					{
						if (required)
						{
							returnValue = "int";
						}
						else
						{
							returnValue = "int?";
						}
					}
					break;
				case "zipcode":
					returnValue = "string";
					break;
				case "time":
					if (required)
					{
						returnValue = "TimeOnly";
					}
					else
					{
						returnValue = "TimeOnly?";
					}
					break;
				case "date":
					if (required)
					{
						returnValue = "DateOnly";
					}
					else
					{
						returnValue = "DateOnly?";
					}
					break;
				case "reserve":
					returnValue = "string";
					break;
				case "closing":
					returnValue = "string";
					break;
				default:
					returnValue = "string";
					break;
			}

			return returnValue;
		}

		/// <summary>
		/// Converts a given type name to its corresponding SQLite data type.
		/// </summary>
		/// <remarks>This method maps common type names to SQLite-compatible data types based on predefined rules. If
		/// the provided <paramref name="type"/> does not match any known type, the method defaults to returning
		/// "TEXT".</remarks>
		/// <param name="type">The type name to convert (e.g., "decimal", "string", "integer").</param>
		/// <param name="dataType">An additional data type specifier used for certain conversions. For example, if <paramref name="type"/> is
		/// "integer" and <paramref name="dataType"/> is "A/N", the method returns "TEXT"; otherwise, it returns "INTEGER".</param>
		/// <returns>A string representing the SQLite data type corresponding to the provided <paramref name="type"/>. Returns
		/// "NUMERIC" for "decimal", "TEXT" for "string" and other text-based types, and "INTEGER" for "integer" unless
		/// <paramref name="dataType"/> specifies otherwise.</returns>
		public static string ToSqliteType(this string type, string dataType)
		{
			string returnValue = type;

			switch (type)
			{
				case "decimal":
					returnValue = "NUMERIC";
					break;
				case "string":
					returnValue = "TEXT";
					break;
				case "enum":
					returnValue = "TEXT";
					break;
				case "integer":
					if (dataType == "A/N")
					{
						returnValue = "TEXT";
					}
					else
					{
						returnValue = "INTEGER";
					}
					break;
				case "zipcode":
					returnValue = "TEXT";
					break;
				case "time":
					returnValue = "TEXT";
					break;
				case "date":
					returnValue = "TEXT";
					break;
				case "reserve":
					returnValue = "TEXT";
					break;
				case "closing":
					returnValue = "TEXT";
					break;
				default:
					returnValue = "TEXT";
					break;
			}

			return returnValue;
		}

		/// <summary>
		/// Provides a mapping of specific acronyms to their corrected casing.
		/// </summary>
		/// <remarks>This dictionary is used to standardize the casing of acronyms in strings.  For example, "CBR" is
		/// mapped to "Cbr", and "URL" is mapped to "Url".  The keys represent the original acronyms, and the values represent
		/// their corrected forms.</remarks>
		private static readonly Dictionary<string, string> AcronymFixes = new()
		{
			{ "CBR", "Cbr" },
			{ "CCR", "Ccr" },
			{ "CDR", "Cdr" },
			{ "CFR", "Cfr" },
			{ "CHR", "Chr" },
			{ "CPT", "Cpt" },
			{ "CQT", "Cqt" },
			{ "CSM", "Csm" },
			{ "EPD", "Epd" },
			{ "HDR", "Hdr" },
			{ "ICR", "Icr" },
			{ "MCR", "Mcr" },
			{ "MPA", "Mpa" },
			{ "MPU", "Mpu" },
			{ "OCI", "Oci" },
			{ "PAR", "Par" },
			{ "PBC", "Pbc" },
			{ "PDR", "Pdr" },
			{ "PQT", "Pqt" },
			{ "RMB", "Rmb" },
			{ "RMR", "Rmr" },
			{ "RMS", "Rms" },
			{ "SEG", "Seg" },
			{ "SFB", "Sfb" },
			{ "SFR", "Sfr" },
			{ "SNR", "Snr" },
			{ "UPA", "Upa" },
			{ "WSR", "Wsr" },
			{ "EMD", "Emd"  },
			{ "CSA", "Csa"  },
			{ "ASN", "Asn"  },
			{ "DMM", "Dmm"  },
			{ "CIN", "Cin"  },
			{ "IM", "Im"  },
			{ "FAST", "Fast"  },
			{ "FCM", "Fcm"  },
			{ "CRID", "Crid" },
			{ "MID", "Mid" },
			{ "COM", "Com" },
			{ "ZIP", "Zip" },
			{ "ID", "Id" },
			{ "URL", "Url" },
			{ "HTTP", "Http" },
			{ "XML", "Xml"  }
		};

		/// <summary>
		/// Converts the specified string to PascalCase, ensuring proper handling of acronyms.
		/// </summary>
		/// <remarks>This method first applies standard PascalCase conversion to the input string and then adjusts
		/// specific acronyms to ensure they are properly capitalized. Acronym corrections are based on predefined
		/// mappings.</remarks>
		/// <param name="input">The input string to be converted to PascalCase. Cannot be <see langword="null"/>.</param>
		/// <returns>A new string in PascalCase format, with acronyms correctly capitalized.</returns>
		public static string TruePascalize(this string input)
		{
			string result = input.Pascalize();

			foreach (KeyValuePair<string, string> kvp in AcronymFixes)
			{
				result = result.Replace(kvp.Key, kvp.Value, StringComparison.Ordinal);
			}

			return result;
		}
	}
}
