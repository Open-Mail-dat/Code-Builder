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
using Humanizer;

namespace Mail.dat.BuildCommand
{
	public static class ClassBuilderDecorator
	{
		/// <summary>
		/// Creates the HasKey() code for the database context class
		/// OnModlCreating() method.
		/// </summary>
		public static List<string> BuildContextHasKeyCode(this IEnumerable<ClassBuilder> classes)
		{
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
		public static List<string> BuildContextHasIndexCode(this IEnumerable<ClassBuilder> classes)
		{
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
		public static ClassBuilder SetFileHeaderComments(this ClassBuilder classBuilder)
		{
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
				"LICENSE (GNU Lesser General Public License)",
				"LICENSE-GPL3 (GNU General Public License)",
				"LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))",
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
