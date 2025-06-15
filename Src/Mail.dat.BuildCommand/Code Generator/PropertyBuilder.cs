using Humanizer;
using Mail.dat.Json.Specification;
using Microsoft.Extensions.Options;

namespace Mail.dat.BuildCommand
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

		public PropertyBuilder AddAttributes(params IEnumerable<IEnumerable<AttributeBuilder>> attributes)
		{
			this.Attributes.AddRange(attributes.SelectMany(t => t));
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

		public PropertyBuilder CreateValuesClass(string filePath, string propertyName, string nameSpace, FileGroup fileGroup, string fieldCode)
		{
			IEnumerable<AllowedValue> values = fileGroup.AllowedValues(fieldCode);

			if (values.Count() > 0)
			{
				DirectoryInfo dir = new(Path.GetDirectoryName(filePath));
				dir.Create();

				ClassBuilder.Create(propertyName.Pluralize())
						.SetFileHeaderComments()
						.SetNameSpace(nameSpace)
						.AddUsing("Mail.dat.Abstractions")
						.SetSummary($"These are the allowed values for the property {propertyName} ({fieldCode}).")
						.SetObjectType("class")
						.SetScope("public")
						.SetPartial(false)
						.AddImplements("MaildatValues")
						.AddAttributes(
							fileGroup.MaildatVersionsAttribute(),
							AttributeBuilder.Create("MaildatFieldLink")
								.AddParameter("File", fileGroup.FileExtension)
								.AddParameter("FieldCode", fieldCode)
						)
						.AddMethod(MethodBuilder.Create("OnGetFieldCode")
							.SetScope("protected override")
							.SetReturnType("string")
							.SetSummary("Returns the Mail.dat file this set of values is lined to.")
							.AddCode($"return \"{fileGroup.FileExtension}\";"))
						.AddMethod(MethodBuilder.Create("OnGetFile")
							.SetScope("protected override")
							.SetReturnType("string")
							.SetSummary("Returns the field code that this set of values is linked to.")
							.AddCode($"return \"{fieldCode}\";"))
						.AddMethod(MethodBuilder.Create("OnInitializeValues")
							.SetScope("protected override")
							.SetReturnType("void")
							.SetSummary("Initializes the values.")
							.AddCode([.. (from tbl in values
								select $"this.Add(new MaildatValue() {{ Version = \"{tbl.Version.Major}\", Key = \"{tbl.Key}\", FileExtension = \"{fileGroup.FileExtension}\", Description = \"{tbl.Value.Sanitize()}\", FieldCode = \"{fieldCode}\", FieldName = \"{propertyName}\" }});")]))
						.Build(filePath, 1);
			}

			return this;
		}
	}
}
