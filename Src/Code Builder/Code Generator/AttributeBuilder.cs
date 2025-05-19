namespace Mail.dat.CodeBuilder
{
	public class AttributeParameter
	{
		public string Name { get; set; }
		public string Value { get; set; }
		public bool Quoted { get; set; }
	}

	public class AttributeBuilder : ICodeBuilder<AttributeBuilder>
	{
		public string Name { get; internal set; }
		public List<AttributeParameter> Parameters { get; } = [];

		public static AttributeBuilder Create(string attributeName)
		{
			return new AttributeBuilder() { Name = attributeName };
		}

		public AttributeBuilder AddParameter(string name, string value, bool quoted = true)
		{
			this.Parameters.Add(new AttributeParameter() { Name = name, Value= value, Quoted	= quoted });
			return this;
		}

		public AttributeBuilder AddParameter(AttributeParameter item)
		{
			this.Parameters.Add(item);
			return this;
		}

		public AttributeBuilder AddParameters(params IEnumerable<AttributeParameter> items)
		{
			this.Parameters.AddRange(items);
			return this;
		}

		public AttributeBuilder Build(string filePath, int indentLevel = 0)
		{
			string attributeString = $"[{this.Name}";

			if (this.Parameters.Any())
			{
				attributeString += "(";
			}

			IList<string> fields = [];

			foreach (AttributeParameter parameter in this.Parameters)
			{
				if (!string.IsNullOrWhiteSpace(parameter.Value))
				{
					if (string.IsNullOrWhiteSpace(parameter.Name))
					{
						fields.Add($"{(parameter.Quoted ? "\"" : "")}{parameter.Value}{(parameter.Quoted ? "\"" : "")}");
					}
					else
					{
						fields.Add($"{parameter.Name} = {(parameter.Quoted ? "\"" : "")}{parameter.Value}{(parameter.Quoted ? "\"" : "")}");
					}
				}
			}

			attributeString += string.Join(", ", fields);

			if (this.Parameters.Any())
			{
				attributeString += ")";
			}

			attributeString += "]";

			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{attributeString}"]);

			return this;
		}
	}
}
