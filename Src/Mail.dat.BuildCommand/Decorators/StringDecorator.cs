using System.Text;
using System.Text.RegularExpressions;
using Humanizer;

namespace Mail.dat.BuildCommand
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

		public static string TruePascalize(this string input)
		{
			string result = input.Pascalize();

			foreach (KeyValuePair<string, string> kvp in AcronymFixes)
			{
				result = result.Replace(kvp.Key, kvp.Value);
			}

			return result;
		}
	}
}
