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
using Humanizer;
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{	
	/// <summary>
	/// Provides extension methods for converting strings and <see cref="RecordDefinition"/> objects  into various naming
	/// conventions, such as PascalCase class names, interface names, and property names.
	/// </summary>
	/// <remarks>This static class is designed to assist with generating consistent and valid names for classes, 
	/// interfaces, and properties based on input strings or record definitions. It includes methods  for applying Pascal
	/// casing, prefixing interface names, and appending file extensions.</remarks>
	public static class KeyNamesDecorator
	{
		/// <summary>
		/// Converts the specified string to a PascalCase class name.
		/// </summary>
		/// <param name="value">The string to convert. Cannot be <see langword="null"/> or empty.</param>
		/// <returns>A PascalCase representation of the input string, suitable for use as a class name.</returns>
		public static string ToClassName(this string value)
		{
			return value.TruePascalize();
		}

		/// <summary>
		/// Converts the specified string to an interface name by prefixing it with "I"  and applying class name formatting
		/// conventions.
		/// </summary>
		/// <param name="value">The string to convert. Cannot be null.</param>
		/// <returns>A string representing the interface name, prefixed with "I".</returns>
		public static string ToInterfaceName(this string value)
		{
			return $"I{value.ToClassName()}";
		}

		/// <summary>
		/// Converts the specified string to a Pascal-cased class file name with a ".cs" extension.
		/// </summary>
		/// <remarks>This method applies Pascal casing to the input string and appends the ".cs" file extension. Use
		/// this method to generate class file names from entity or class names.</remarks>
		/// <param name="value">The string to convert. Typically represents the name of a class or entity.</param>
		/// <returns>A string representing the Pascal-cased class file name with a ".cs" extension.</returns>
		public static string ToClassFileName(this string value)
		{
			return $"{value.TruePascalize()}.cs";
		}

		/// <summary>
		/// Converts a <see cref="RecordDefinition"/> to a property name.	
		/// </summary>
		/// <param name="recordDefintion">The <see cref="RecordDefinition"/> to convert. Cannot be null.</param>
		/// <returns>A string representing the property name derived from the record definition.</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static string ToPropertyName(this RecordDefinition recordDefintion)
		{
			string returnValue = null;

			if (recordDefintion is not null)
			{
				returnValue = recordDefintion.FieldName.ToString().Dehumanize().TruePascalize().KeywordSanitize();

				if (returnValue == "Reserve")
				{
					returnValue = $"{returnValue}{recordDefintion.FieldCode.ToString().Dehumanize().TruePascalize().KeywordSanitize()}";
				}
			}
			else
			{
				throw new ArgumentNullException(nameof(recordDefintion), "RecordDefinition cannot be null.");
			}

			return returnValue;
		}
	}
}
