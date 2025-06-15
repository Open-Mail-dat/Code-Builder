//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
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
namespace Mail.dat.BuildCommand
{
	public class MethodParameter
	{
		public string Type { get; set; }
		public string Name { get; set; }
	}

	public class MethodBuilder : ICodeBuilder<MethodBuilder>
	{
		public string Name { get; internal set; }
		public List<MethodParameter> Parameters { get; } = [];
		public List<string> Code { get; } = [];
		public string ObjectType { get; internal set; }
		public string Scope { get; internal set; }
		public string ReturnType { get; internal set; }
		public SummaryBuilder Summary { get; internal set; }
		public List<AttributeBuilder> Attributes { get; } = [];
		public string BaseType { get; internal set; }

		public static MethodBuilder Create(string name)
		{
			return new MethodBuilder() { Name = name };
		}

		public MethodBuilder AddParameter(string type, string name)
		{
			this.Parameters.Add(new MethodParameter() { Type = type, Name = name });
			return this;
		}

		public MethodBuilder AddCode(string code)
		{
			this.Code.Add(code);
			return this;
		}

		public MethodBuilder AddCode(params List<string> code)
		{
			this.Code.AddRange(code);
			return this;
		}

		public MethodBuilder SetObjectType(string objectType)
		{
			this.ObjectType = objectType;
			return this;
		}

		public MethodBuilder SetScope(string scope)
		{
			this.Scope = scope;
			return this;
		}

		public MethodBuilder SetSummary(params List<string> lines)
		{
			this.Summary = SummaryBuilder.Create(lines);
			return this;
		}

		public MethodBuilder SetReturnType(string returnType)
		{
			this.ReturnType = returnType;
			return this;
		}

		public MethodBuilder SetAttributes(params IEnumerable<AttributeBuilder> attributes)
		{
			((List<AttributeBuilder>)this.Attributes).AddRange(attributes);
			return this;
		}

		public MethodBuilder SetBase(string baseType)
		{
			this.BaseType = baseType;
			return this;
		}

		public MethodBuilder Build(string filePath, int indentLevel = 0)
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
			// Write the method name
			//
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}{(this.Scope ?? "")} {(this.ReturnType ?? "")} {this.Name}(");

			if (this.Parameters != null)
			{
				foreach (MethodParameter parameter in this.Parameters)
				{
					File.AppendAllText(filePath, $"{parameter.Type} {parameter.Name}");

					if (parameter != this.Parameters.Last())
					{
						File.AppendAllText(filePath, ", ");
					}
				}
			}

			File.AppendAllLines(filePath, [")"]);

			if (this.BaseType != null)
			{
				File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)} : {this.BaseType}"]);
			}

			//
			// Write the method body.
			//
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{{"]);

			foreach (string line in this.Code)
			{
				File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}{line}"]);
			}

			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}}}"]);

			return this;
		}
	}
}
