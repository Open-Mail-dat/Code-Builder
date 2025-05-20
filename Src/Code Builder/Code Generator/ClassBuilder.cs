namespace Mail.dat.CodeBuilder
{
	public class ClassBuilder : ICodeBuilder<ClassBuilder>
	{
		public string Name { get; internal set; }
		public List<AttributeBuilder> Attributes { get; } = [];
		public ImplementsBuilder Implements { get; set; }
		public List<string> Using { get; } = [];
		public string NameSpace { get; internal set; }
		public string ObjectType { get; internal set; }
		public string Scope { get; internal set; }
		public SummaryBuilder Summary { get; internal set; }
		public CommentBuilder HeaderComments { get; internal set; }
		public List<PropertyBuilder> Properties { get; } = [];
		public bool IsPartial { get; internal set; } = false;

		public static ClassBuilder Create(string className)
		{
			return new ClassBuilder() { Name = className };
		}

		public ClassBuilder AddAttributes(params IEnumerable<AttributeBuilder> attributes)
		{
			this.Attributes.AddRange(attributes);
			return this;
		}

		public ClassBuilder AddImplements(ImplementsBuilder implements)
		{
			this.Implements = implements;
			return this;
		}

		public ClassBuilder SetNameSpace(string nameSpace)
		{
			this.NameSpace = nameSpace;
			return this;
		}

		public ClassBuilder AddUsing(string usingStatement)
		{
			this.Using.Add(usingStatement);
			return this;
		}

		public ClassBuilder SetObjectType(string objectType)
		{
			this.ObjectType = objectType;
			return this;
		}

		public ClassBuilder SetScope(string scope)
		{
			this.Scope = scope;
			return this;
		}

		public ClassBuilder SetSummary(params List<string> lines)
		{
			this.Summary = SummaryBuilder.Create(lines);
			return this;
		}

		public ClassBuilder SetHeaderComments(params List<string> lines)
		{
			this.HeaderComments = CommentBuilder.Create(lines);
			return this;
		}

		public ClassBuilder SetPartial(bool isPartial = true)
		{
			this.IsPartial = isPartial;
			return this;
		}

		public ClassBuilder AddProperties(params IEnumerable<PropertyBuilder> properties)
		{
			this.Properties.AddRange(properties);
			return this;
		}

		public ClassBuilder Build(string filePath, int indentLevel = 0)
		{
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
				File.WriteAllText(filePath, "");
			}

			//
			// Write the header comments.
			//
			this.HeaderComments.Build(filePath, 0);

			//
			// Write the using statements.
			//
			foreach (string usingStatement in this.Using)
			{
				File.AppendAllLines(filePath, [$"using {usingStatement};"]);
			}

			//
			// Write the namespace.
			//
			File.AppendAllLines(filePath, [""]);
			File.AppendAllLines(filePath, [$"namespace {this.NameSpace}"]);
			File.AppendAllLines(filePath, ["{"]);

			//
			// Write the summary.
			//
			this.Summary.Build(filePath, indentLevel);

			//
			// Write the attributes.
			//
			foreach (AttributeBuilder attribute in this.Attributes)
			{
				attribute.Build(filePath, indentLevel);
			}

			//
			// Write the class definition.
			//
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}{this.Scope}{(this.IsPartial ? " partial " : " ")}{this.ObjectType} {this.Name}");
			this.Implements.Build(filePath);
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{{"]);

			//
			// Write the properties.
			//
			foreach (PropertyBuilder property in this.Properties)
			{
				property.Build(filePath, indentLevel + 1);

				if (property != this.Properties.Last())
				{
					File.AppendAllLines(filePath, [""]);
				}
			}

			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}}}"]);
			File.AppendAllText(filePath, "}");

			return this;
		}
	}
}
