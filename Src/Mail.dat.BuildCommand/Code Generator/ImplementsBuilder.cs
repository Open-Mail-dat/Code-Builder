namespace Mail.dat.BuildCommand
{
	public class ImplementsBuilder : ICodeBuilder<ImplementsBuilder>
	{
		public List<string> Items { get; } = [];

		public ImplementsBuilder Add(string item)
		{
			this.Items.Add(item);
			return this;
		}

		public ImplementsBuilder Build(string filePath, int indentLevel = 0)
		{
			if (this.Items.Count != 0)
			{
				//
				// Get the first item that does not start with "I".
				//
				string classItem = this.Items.FirstOrDefault(item => !item.StartsWith("I", StringComparison.OrdinalIgnoreCase));

				//
				// Get the items that start with an "I".
				//
				IEnumerable<string> interfaces = this.Items.Where(item => item.StartsWith("I", StringComparison.OrdinalIgnoreCase));

				//
				// Create a new list with the class first and the interfaces after.
				//
				IEnumerable<string> items = (new string[] { classItem }).Union(interfaces).Where(t => t != null);

				//
				// Combine all of the itmes as a comma separated list.
				//
				string list = string.Join(", ", items);

				//
				// Write the name.
				//
				File.AppendAllLines(filePath, [$" : {list} "]);
			}
			else
			{
				File.AppendAllLines(filePath, [""]);
			}

			return this;
		}
	}
}
