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
namespace Mail.dat.Io
{
	/// <summary>
	/// Provides extension methods for working with file and directory paths.
	/// </summary>
	/// <remarks>This class includes utility methods for normalizing and manipulating paths to ensure consistency
	/// across different operating systems or environments.</remarks>
	public static class PathDecorator
	{
		/// <summary>
		/// Converts all backslashes in the specified file path to forward slashes.
		/// </summary>
		/// <param name="path">The file path to normalize. Can be <see langword="null"/>.</param>
		/// <returns>A new string with all backslashes ('\') replaced by forward slashes ('/'),  or <see langword="null"/> if <paramref
		/// name="path"/> is <see langword="null"/>.</returns>
		public static string NormalizePath(this string path)
		{
			return path?.Replace('\\', '/');
		}
	}
}
