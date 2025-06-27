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
using System.ComponentModel;

namespace Mail.dat
{
	/// <summary>
	/// Provides an extension method for retrieving a <see cref="ConverterContext"/> from an <see
	/// cref="ITypeDescriptorContext"/>.
	/// </summary>
	/// <remarks>This class contains a single extension method that allows callers to extract a <see
	/// cref="ConverterContext"/> from an <see cref="ITypeDescriptorContext"/> instance. If the provided context is not of
	/// type <see cref="ConverterContext"/>, an exception is thrown.</remarks>
	public static class ITypeDescriptorContextDecorator
	{
		/// <summary>
		/// Retrieves the <see cref="ConverterContext"/> instance from the specified <see cref="ITypeDescriptorContext"/>.
		/// </summary>
		/// <param name="context">The <see cref="ITypeDescriptorContext"/> to retrieve the <see cref="ConverterContext"/> from.</param>
		/// <returns>The <see cref="ConverterContext"/> instance if the specified context is of type <see cref="ConverterContext"/>.</returns>
		/// <exception cref="InvalidOperationException">Thrown if the specified <paramref name="context"/> is not a <see cref="ConverterContext"/>.</exception>
		public static ConverterContext Get(this ITypeDescriptorContext context)
		{
			//
			// Validate the input parameter
			//
			if (context is ConverterContext converterContext)
			{
				//
				// Return the ConverterContext if the context is of the correct type.
				//
				return converterContext;
			}
			else
			{
				//
				// Throw an exception if the context is not a ConverterContext.
				//
				throw new InvalidOperationException("The context is not a ConverterContext.");
			}
		}
	}
}
