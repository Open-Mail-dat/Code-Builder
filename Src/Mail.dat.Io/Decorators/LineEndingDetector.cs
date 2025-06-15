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
// LICENSE (GNU Lesser General Public License)
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
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