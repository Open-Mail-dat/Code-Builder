using System.Text;

namespace Mail.dat.Io
{
	public static class LineEndingDetector
	{
		public static string DetectLineEnding(this string filePath)
		{
			string returnValue = null;

			using (StreamReader reader = new(filePath))
			{
				for (int i = 0; i < 2 && !reader.EndOfStream; i++)
				{
					string line = ReadRawLine(reader, out string lineEnding);

					if (!string.IsNullOrEmpty(lineEnding))
					{
						returnValue= lineEnding;
						break;
					}
				}
			}

			return returnValue;
		}

		private static string ReadRawLine(StreamReader reader, out string lineEnding)
		{
			StringBuilder result = new StringBuilder();
			lineEnding = "";

			while (reader.Peek() >= 0)
			{
				char c = (char)reader.Read();
				if (c == '\r')
				{
					if (reader.Peek() == '\n')
					{
						reader.Read(); // consume \n
						lineEnding = "\r\n";
					}
					else
					{
						lineEnding = "\r";
					}
					break;
				}
				else if (c == '\n')
				{
					lineEnding = "\n";
					break;
				}
				else
				{
					result.Append(c);
				}
			}

			return result.ToString();
		}
	}
}