using System.Runtime.CompilerServices;

namespace Mail.dat.Io
{
	public static class BinaryReaderDecorator
	{
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
