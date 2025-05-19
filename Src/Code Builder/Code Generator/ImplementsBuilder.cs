namespace Mail.dat.CodeBuilder
{
	public class ImplementsBuilder : ICodeBuilder<ImplementsBuilder>
	{
		public List<string> Items { get; internal set; }

		public static ImplementsBuilder Create(params List<string> items)
		{
			return new ImplementsBuilder() { Items = items };
		}

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
				// Write the name.
				//
				foreach (string item in this.Items)
				{
					if (item == this.Items.First())
					{
						File.AppendAllText(filePath, " : ");
					}

					if (item != this.Items.Last())
					{
						File.AppendAllText(filePath, item);
						File.AppendAllText(filePath, ", ");
					}
					else
					{
						File.AppendAllLines(filePath, [item]);
					}
				}
			}
			else
			{
				File.AppendAllLines(filePath, [""]);
			}

			return this;
		}
	}
}
