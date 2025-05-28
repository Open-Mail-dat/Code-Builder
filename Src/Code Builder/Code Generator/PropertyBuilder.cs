namespace Mail.dat.CodeBuilder
{
	public class PropertyBuilder : ICodeBuilder<PropertyBuilder>
	{
		public string Name { get; set; }
		public List<AttributeBuilder> Attributes { get; } = [];
		public string ReturnType { get; internal set; }
		public string Scope { get; internal set; }
		public SummaryBuilder Summary { get; internal set; }
		public string DefaultValue { get; internal set; }
		public bool ReadOnly { get; internal set; } = false;
		public int? Precision { get; internal set; } = null;

		public static PropertyBuilder Create(string name)
		{
			return new PropertyBuilder() { Name = name };
		}

		public PropertyBuilder SetReturnType(string returnType)
		{
			this.ReturnType = returnType;
			return this;
		}

		public PropertyBuilder SetScope(string scope)
		{
			this.Scope = scope;
			return this;
		}

		public PropertyBuilder SetDefaultValue(string defaultValue)
		{
			this.DefaultValue = defaultValue;
			return this;
		}

		public PropertyBuilder SetSummary(params List<string> lines)
		{
			this.Summary = SummaryBuilder.Create(lines);
			return this;
		}

		public PropertyBuilder SetReadOnly(bool readOnly = true)
		{
			this.ReadOnly = readOnly;
			return this;
		}

		public PropertyBuilder AddAttributes(params IEnumerable<AttributeBuilder> attributes)
		{
			((List<AttributeBuilder>)this.Attributes).AddRange(attributes);
			return this;
		}

		public PropertyBuilder SetPrecision(int? precision)
		{
			this.Precision = precision;
			return this;
		}

		public PropertyBuilder Build(string filePath, int indentLevel = 0)
		{
			//
			// Write the summary.
			//
			this.Summary?.Build(filePath, indentLevel);

			//
			// Write the attributes.
			//
			foreach (AttributeBuilder attribute in this.Attributes.Where(t => t != null))
			{
				attribute.Build(filePath, indentLevel);
			}

			//
			// Write the property.
			//
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}{(this.Scope != null ? $"{this.Scope} " : "")}{this.ReturnType} {this.Name}");

			if (!string.IsNullOrWhiteSpace(this.DefaultValue))
			{
				File.AppendAllText(filePath, $" {{ get;{(!this.ReadOnly ? " set;" : null)} }} = {this.DefaultValue};");
			}
			else
			{
				File.AppendAllText(filePath, $" {{ get;{(!this.ReadOnly ? " set;" : null)} }}");
			}

			return this;
		}
	}
}
