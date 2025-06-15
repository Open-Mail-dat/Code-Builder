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
				$"Copyright (c) {DateTime.Now.Year} Open Mail.dat",
				"",
				"This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.",
				"",
				$"This code was auto-generated on {DateTime.Now.ToOrdinalWords()}.",
				"by the Open Mail.dat Code Generator.",
				"",
				"Author: Daniel M porrey",
				""
			);

			return classBuilder;
		}
	}
}
