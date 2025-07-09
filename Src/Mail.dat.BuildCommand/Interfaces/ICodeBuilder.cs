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
namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Defines a contract for a code builder that constructs an object of type <typeparamref name="T"/> from a file path.
	/// </summary>
	/// <typeparam name="T">Type of the object to be built.</typeparam>
	public interface ICodeBuilder<T>
	{
		/// <summary>
		/// Builds an object of type <typeparamref name="T"/> from the specified file.
		/// </summary>
		/// <param name="filePath">The path to the file from which the object will be built. Cannot be null or empty.</param>
		/// <param name="indentLevel">The level of indentation to apply during the build process. Defaults to 0.</param>
		/// <returns>An instance of type <typeparamref name="T"/> constructed from the specified file.</returns>
		T Build(string filePath, int indentLevel = 0);
	}
}
