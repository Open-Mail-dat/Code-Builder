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
namespace Mail.dat.Json.Specification
{
	/// <summary>
	/// Provides a comparison mechanism for <see cref="VersionInfo"/> objects based on their major, minor, and revision
	/// components.
	/// </summary>
	/// <remarks>This comparer is designed to compare <see cref="VersionInfo"/> objects in the following order:
	/// <list type="number"> <item><description>Major version numbers are compared first.</description></item>
	/// <item><description>If the major versions are equal, minor version numbers are compared.</description></item>
	/// <item><description>If both major and minor versions are equal, the revision strings are compared using a
	/// case-insensitive ordinal comparison.</description></item> </list> If either <see cref="VersionInfo"/> object being
	/// compared is <see langword="null"/>, it is treated as less than a non-<see langword="null"/> value.</remarks>
	public class VersionInfoComparer : IComparer<VersionInfo>
	{
		/// <summary>
		/// Compares two <see cref="VersionInfo"/> objects based on their major, minor, and revision components.
		/// </summary>
		/// <remarks>The comparison is performed in the following order: <list type="number"> <item>Major version
		/// numbers are compared first.</item> <item>If the major versions are equal, minor version numbers are
		/// compared.</item> <item>If both major and minor versions are equal, the revision strings are compared using a
		/// case-insensitive ordinal comparison.</item> </list> If either <paramref name="x"/> or <paramref name="y"/> is <see
		/// langword="null"/>, it is treated as less than a non-<see langword="null"/> value.</remarks>
		/// <param name="x">The first <see cref="VersionInfo"/> object to compare. Can be <see langword="null"/>.</param>
		/// <param name="y">The second <see cref="VersionInfo"/> object to compare. Can be <see langword="null"/>.</param>
		/// <returns>A signed integer that indicates the relative order of the two objects: <list type="bullet"> <item> <description>A
		/// value less than zero if <paramref name="x"/> is less than <paramref name="y"/>.</description> </item> <item>
		/// <description>Zero if <paramref name="x"/> is equal to <paramref name="y"/>.</description> </item> <item>
		/// <description>A value greater than zero if <paramref name="x"/> is greater than <paramref name="y"/>.</description>
		/// </item> </list></returns>
		public int Compare(VersionInfo x, VersionInfo y)
		{
			(int xMajor, int xMinor) = ParseMajor(x?.Major);
			(int yMajor, int yMinor) = ParseMajor(y?.Major);

			int majorCompare = xMajor.CompareTo(yMajor);
			
			if (majorCompare != 0)
			{
				return majorCompare;
			}

			int minorCompare = xMinor.CompareTo(yMinor);
			
			if (minorCompare != 0)
			{
				return minorCompare;
			}

			// Optional: add revision comparison if needed
			return string.Compare(x?.Revision, y?.Revision, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Parses a version string into its major and minor components.
		/// </summary>
		/// <param name="version">A string representing the version in the format "major-minor".  The major and minor components must be integers
		/// separated by a hyphen.</param>
		/// <returns>A tuple containing the major and minor version numbers as integers.  If the input string is null, empty, consists
		/// only of whitespace, or is not in the expected format,  the method returns (0, 0).</returns>
		private static (int Major, int Minor) ParseMajor(string version)
		{
			if (string.IsNullOrWhiteSpace(version))
			{
				return (0, 0);
			}

			string[] parts = version.Split('-');
			
			if (parts.Length == 2 &&
				int.TryParse(parts[0], out int major) &&
				int.TryParse(parts[1], out int minor))
			{
				return (major, minor);
			}

			return (0, 0);
		}
	}
}
