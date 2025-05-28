using System.ComponentModel;

namespace Mail.dat.CodeBuilder
{
	public class AttributeParameter
	{
		public AttributeParameter()
		{
		}

		public AttributeParameter(string name, object value)
		{
			this.Name = name;
			this.Value = value;
			this.Quoted = (value is string);
		}

		public static AttributeParameter Create(string name, object value)
		{
			return new AttributeParameter()
			{
				Name = name,
				Value = value,
				Quoted = (value is string)
			};
		}

		public string Name { get; set; }
		public object Value { get; set; }
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

		public static AttributeBuilder CreateConditional(bool condition, string attributeName, params IEnumerable<AttributeParameter> items)
		{
			AttributeBuilder returnValue = null;

			if (condition)
			{
				returnValue = new AttributeBuilder()
				{
					Name = attributeName
				};

				returnValue.Parameters.AddRange(items);
			}

			return returnValue;
		}

		public AttributeBuilder AddParameter(string name, object value)
		{
			this.Parameters.Add(AttributeParameter.Create(name, value));
			return this;
		}

		public AttributeBuilder AddConditionalParameter(bool condition, string name, object value)
		{
			if (condition)
			{
				this.AddParameter(name, value);
			}

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
				if (parameter.Value != null)
				{
					TypeConverter converter = TypeDescriptor.GetConverter(parameter.Value.GetType());
					string stringValue = Convert.ToString(parameter.Value);

					//
					// Perform special conversions for certain types.
					//
					if (parameter.Value is bool)
					{
						stringValue = stringValue.ToLower();
					}
					else if (parameter.Value is Type type)
					{
						stringValue = $"typeof({type.Name})";
					}

					//
					// Put quotes around the value if the parameter is quoted.
					//
					if (parameter.Quoted)
					{
						stringValue = $"\"{stringValue}\"";
					}

					//
					// If the parameter has no name, just use the value.
					//
					if (string.IsNullOrWhiteSpace(parameter.Name))
					{
						fields.Add(stringValue);
					}
					else
					{
						fields.Add($"{parameter.Name} = {stringValue}");
					}
				}
			}

			attributeString += string.Join(", ", fields);

			if (this.Parameters.Count != 0)
			{
				attributeString += ")";
			}

			attributeString += "]";

			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{attributeString}"]);

			return this;
		}
	}
}
