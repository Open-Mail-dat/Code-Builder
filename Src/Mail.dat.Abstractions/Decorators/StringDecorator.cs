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
namespace Mail.dat
{
	/// <summary>
	/// Provides extension methods for string manipulation, such as truncating strings to a specified length or determining
	/// if a string represents a numeric value.
	/// </summary>
	/// <remarks>This static class contains utility methods that extend the functionality of the <see
	/// cref="string"/> type. These methods are designed to simplify common string operations, such as limiting the length
	/// of a string or checking if a string can be parsed as a numeric value.</remarks>
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

		/// <summary>
		/// Determines whether the specified string represents a numeric value.
		/// </summary>
		/// <param name="value">The string to evaluate.</param>
		/// <returns><see langword="true"/> if the string can be parsed as an integer; otherwise, <see langword="false"/>.</returns>
		public static bool IsNumeric(this string value)
		{
			return int.TryParse(value, out int _);
		}
	}
}
