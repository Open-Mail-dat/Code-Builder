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
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.ComponentModel;

namespace Mail.dat.BuildCommand
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

		public static AttributeParameter Create(string name, object value, bool quoted)
		{
			return new AttributeParameter()
			{
				Name = name,
				Value = value,
				Quoted = quoted
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

		public AttributeBuilder AddParameter(string name, object value, bool quoted)
		{
			this.Parameters.Add(AttributeParameter.Create(name, value, quoted));
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
