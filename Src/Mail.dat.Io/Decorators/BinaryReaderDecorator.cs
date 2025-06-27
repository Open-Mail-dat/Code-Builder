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
using System.Runtime.CompilerServices;

namespace Mail.dat.Io
{
	/// <summary>
	/// Reads a binary file asynchronously, yielding each line as a tuple containing the line number and the line's
	/// content.
	/// </summary>
	/// <remarks>This method reads a binary file line by line, where each line is defined by a fixed length and
	/// specific line-ending characters. The method validates that each line ends with the specified closing character
	/// before yielding it. If the validation fails, an exception is thrown. The method supports cancellation via the
	/// <paramref name="cancellationToken"/>.</remarks>
	public static class BinaryReaderDecorator
	{
		/// <summary>
		/// Asynchronously reads lines from a mail.dat file and returns each line as a tuple containing the line number and
		/// its content.
		/// </summary>
		/// <remarks>This method reads lines from a mail.dat file based on the specified line length and line-ending
		/// characters. Each line is validated to ensure it ends with the specified closing character. If a line does not meet
		/// this requirement, an exception is thrown. The method supports cancellation via the <paramref
		/// name="cancellationToken"/>.</remarks>
		/// <param name="reader">The <see cref="BinaryReader"/> used to read the mail.dat file.</param>
		/// <param name="lineLength">The fixed length of each line, excluding line-ending characters.</param>
		/// <param name="lineEndingCharacters">The characters that terminate each line (e.g., "\r\n").</param>
		/// <param name="closingCharacter">The expected closing character for each line, used for validation.</param>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>An asynchronous stream of tuples, where each tuple contains the line number (starting at 1) and the line content
		/// as a byte array.</returns>
		/// <exception cref="Exception">Thrown if a line does not end with the specified closing character.</exception>
		public static async IAsyncEnumerable<(int, byte[])> ReadMaildatFileAsync(this BinaryReader reader, int lineLength, string lineEndingCharacters, string closingCharacter, [EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			await Task.Delay(0, cancellationToken);

			//
			// Track the line number for error logging.
			//
			int lineNumber = 1;

			//
			// Set the reading flag to true to enter the loop.
			//
			bool reading = true;

			do
			{
				if (cancellationToken.IsCancellationRequested)
				{
					//
					// The import was cancelled. Break out of the loop.
					//
					break;
				}

				//
				// Read the line based on the length defined in the specification
				// adding the line terminating character(s).
				//
				byte[] buffer = reader.ReadBytes(lineLength + lineEndingCharacters.Length);

				//
				// If we did not read anything, we are at the
				// end of the file.
				//
				if (buffer.Length > 0)
				{
					//
					// Validate the line; the last character must be the closing character.
					//
					if (buffer[buffer.Length - lineEndingCharacters.Length - 1] == closingCharacter[0])
					{
						yield return (lineNumber, buffer);
					}
					else
					{
						throw new Exception("Unexpected characters found in line.");
					}

					//
					// Increment the line number.
					//
					lineNumber++;
				}
				else
				{
					//
					// No data, the file is at the end.
					//
					reading = false;
				}

			} while (reading);
		}
	}
}
