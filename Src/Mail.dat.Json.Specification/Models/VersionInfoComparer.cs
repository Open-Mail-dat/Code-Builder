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
// LICENSE-GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
namespace Mail.dat.Json.Specification
{
	public class VersionInfoComparer : IComparer<VersionInfo>
	{
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
