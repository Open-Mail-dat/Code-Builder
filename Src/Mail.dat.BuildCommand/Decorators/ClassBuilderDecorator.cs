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
	}
}
