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

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Provides extension methods for building code snippets and file headers for ClassBuilder objects.
	/// </summary>
	public static class ClassBuilderDecorator
	{
		/// <summary>
		/// Creates the HasKey() code for the database context class
		/// OnModlCreating() method.
		/// </summary>
		/// <param name="classes">A collection of ClassBuilder objects representing entity classes.</param>
		/// <returns>A list of strings containing the HasKey() code lines for each class.</returns>
		public static List<string> BuildContextHasKeyCode(this IEnumerable<ClassBuilder> classes)
		{
			//
			// Generate code to specify the key properties for each entity class.
			//
			return
			[
				"",
				"//",
				"// Specify the Key properties",
				"//",
				.. classes.OrderBy(c => c.Name)
					.Select(c => $"modelBuilder.Entity<{c.Name}>().HasKey(t => t.Id);")
					.ToList()
			];
		}

		/// <summary>
		/// Creates the HasIndex() code for the database context class
		/// OnModlCreating() method.
		/// </summary>
		/// <param name="classes">A collection of ClassBuilder objects representing entity classes.</param>
		/// <returns>A list of strings containing the HasIndex() code lines for each indexed property.</returns>
		public static List<string> BuildContextHasIndexCode(this IEnumerable<ClassBuilder> classes)
		{
			//
			// Generate code to add indices for properties marked with the MaildatKey attribute.
			//
			return
			[
				"",
				"//",
				"// Add indices for the Key properties.",
				"//",
				.. classes.OrderBy(c => c.Name)
					.SelectMany(c => c.Properties
					.Where(p => p.Attributes.Any(a => a != null && a.Name == "MaildatKey"))
					.Select(p => $"modelBuilder.Entity<{c.Name}>().HasIndex(t => t.{p.Name});"))
					.ToList()
			];
		}

		/// <summary>
		/// Create the static file header comments.
		/// </summary>
		/// <param name="classBuilder">The ClassBuilder instance to add header comments to.</param>
		/// <returns>The same ClassBuilder instance with updated header comments.</returns>
		public static ClassBuilder SetFileHeaderComments(this ClassBuilder classBuilder)
		{
			//
			// Add standard Open Mail.dat license and attribution comments to the file header.
			//
			classBuilder.HeaderComments.AddComments(
				"",
				"This file is part of Open Mail.dat.",
				$"Copyright (c) {(DateTime.Now.Year > 2025 ? $"2025-{DateTime.Now.Year}" : "2025")} Open Mail.dat. All rights reserved.",
				"",
				"************************************************************************************************************************",
				"License Agreement:",
				"",
				"Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the ",
				"GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3 ",
				"of the License, or (at your option) any later version.",
				"Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without ",
				"even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the ",
				"GNU LESSER GENERAL PUBLIC LICENSE for more details.",
				"You should have received three files as part of the license agreemen for Open Mail.dat. ",
				"",
				"LICENSE.md (GNU Lesser General Public License)",
				"LICENSE-GPL3.md (GNU General Public License)",
				"LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))",
				"",
				"If not, see <https://www.gnu.org/licenses/>.",
				"************************************************************************************************************************",
				"",
				$"This code was auto-generated on {DateTime.Now.ToOrdinalWords()} by the Open Mail.dat Code Generator.",
				"Code Generator Author: Daniel M porrey",
				""
			);

			return classBuilder;
		}
	}
}
