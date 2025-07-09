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
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using Humanizer;
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{
	public class PropertyBuilder : ICodeBuilder<PropertyBuilder>
	{
		public string Name { get; set; }
		public List<AttributeBuilder> Attributes { get; } = [];
		public string ReturnType { get; internal set; }
		public string Scope { get; internal set; }
		public SummaryBuilder Summary { get; internal set; }
		public string DefaultOrExpressionValue { get; internal set; }
		public bool ReadOnly { get; internal set; } = false;
		public bool IsExpression { get; set; }

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
			this.DefaultOrExpressionValue = defaultValue;
			return this;
		}

		public PropertyBuilder SetExpression(string expressionValue)
		{
			this.IsExpression = true;
			this.DefaultOrExpressionValue = expressionValue;
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

		public PropertyBuilder AddAttributes(params IEnumerable<IEnumerable<AttributeBuilder>> attributes)
		{
			this.Attributes.AddRange(attributes.SelectMany(t => t));
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

			if (this.IsExpression)
			{
				File.AppendAllText(filePath, $" => {this.DefaultOrExpressionValue};");
			}
			else
			{
				if (!string.IsNullOrWhiteSpace(this.DefaultOrExpressionValue))
				{
					File.AppendAllText(filePath, $" {{ get;{(!this.ReadOnly ? " set;" : null)} }} = {this.DefaultOrExpressionValue};");
				}
				else
				{
					File.AppendAllText(filePath, $" {{ get;{(!this.ReadOnly ? " set;" : null)} }}");
				}
			}

			return this;
		}
	}
}
