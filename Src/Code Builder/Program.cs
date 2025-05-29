using CommandLine;
using Humanizer;
using Mai.dat.Specification;
using Mai.dat.Specification.Models;
using Mail.dat.CodeBuilder.Decorators;
using Newtonsoft.Json;
using Spectre.Console;

namespace Mail.dat.CodeBuilder
{
	internal class Program
	{
		static Task<int> Main(string[] args)
		{
			int returnValue = 0;

			//
			// Parse the command arguments.
			//
			ParserResult<CommandOptions> result = Parser.Default.ParseArguments<CommandOptions>(args);
			CommandOptions options = result.Value;

			//
			// Check for parse errors.
			//
			if (!result.Errors.Any())
			{
				//
				// Remove all targets files now so that we do not get an error mid-way through the process.
				//
				(new DirectoryInfo(options.ClassOutputDirectory)).DeleteAllFiles("*.cs");
				(new DirectoryInfo(options.InterfaceOutputDirectory)).DeleteAllFiles("*.cs");
				(new DirectoryInfo(options.ContextOutputDirectory)).DeleteAllFiles("*.cs");

				//
				// Read the file contents into a string.
				//
				string jsonContent = File.ReadAllText(options.SpecificationFile);

				//
				// Deserialize the JSON into a SpecificationFile.
				//
				SpecificationFile specificationFile = JsonConvert.DeserializeObject<SpecificationFile>(jsonContent);


				var items = specificationFile.Files.SelectMany(t => t.RecordDefinitions)
												   .GroupBy(t => new { t.DataType, t.Data.Type, t.Data.Format })
												   .OrderBy(t => t.Key.Type)
												   .Select(t => new { t.Key.Type, t.Key.DataType, t.Key.Format,  });



				//
				// Get the proper file ordering.
				//
				FileOrdering fileOrdering = [];

				//
				// Assign the file ordering.
				//
				foreach (FileDefinition fileDefinition in specificationFile.Files)
				{
					fileDefinition.Ordinal = fileOrdering.Where(t => t.Extension == fileDefinition.FileExtension).Select(t => t.Ordinal).SingleOrDefault();
				}

				//
				// Create a list for the classes.
				//
				List<ClassBuilder> classes = [];
				List<ClassBuilder> interfaces = [];

				//
				// Iterate through each file and build the classes.
				//
				foreach (FileDefinition fileDefinition in specificationFile.Files.OrderBy(t => t.Ordinal))
				{
					string file = fileDefinition.File.Transform(To.LowerCase).Sanitize().Transform(To.TitleCase).AddRecord();
					string fileExtension = fileDefinition.FileExtension;
					string fileSummary = fileDefinition.FileSummary.Sanitize().Transform(To.SentenceCase).EndSentence();
					string fileDescription = fileDefinition.FileDescription.Sanitize().Transform(To.SentenceCase).EndSentence() ?? fileSummary;
					fileDescription = string.IsNullOrEmpty(fileDescription) ? fileSummary : fileDescription;

					Panel panel = new Panel($"[yellow]{fileExtension} - {file}[/]").RoundedBorder().Expand();
					AnsiConsole.Write(panel);

					int columnOrder = 2;

					//
					// Create a class for this file.
					//
					AnsiConsole.MarkupLine("\tBuilding [yellow]class[/] file.");
					classes.Add(ClassBuilder.Create(fileExtension.ToClassName())
						.SetHeaderComments(
						[
							"",
							"Copyright (c) 2025 Open Mail.dat",
							"",
							"This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.",
							"",
							$"This code was auto-generated on {DateTime.Now.ToOrdinalWords()}.",
							"by the Open Mail.dat Code Generator.",
							"",
							"Author: Daniel M porrey",
							$"Version {specificationFile.Version.Major.Replace("-", ".")}.{specificationFile.Version.Revision}",
							""
						])
						.SetNameSpace("Mail.dat")
						.AddUsing("System.ComponentModel.DataAnnotations.Schema")
						.AddUsing("System.ComponentModel.DataAnnotations")
						.AddUsing("Microsoft.EntityFrameworkCore")
						.AddUsing("System.ComponentModel")
						.AddUsing("System.Text")
						.SetSummary(fileDescription)
						.SetObjectType("class")
						.SetScope("public")
						.SetPartial(true)
						.AddAttributes(
						[
							AttributeBuilder.Create("MaildatFile")
								.AddParameter("Version", specificationFile.Version.Major)
								.AddParameter("Revision", specificationFile.Version.Revision)
								.AddParameter("Extension", fileExtension)
								.AddParameter("File", file)
								.AddParameter("Summary", fileSummary)
								.AddParameter("Description", fileDescription)
								.AddParameter("LineLength", fileDefinition.RecordDefinitions.TotalLineLength())
								.AddParameter("ClosingCharacter", "#"),
							AttributeBuilder.Create("Table")
								.AddParameter("", fileExtension.Pascalize())
								.AddParameter("Schema", "Maildat"),
							AttributeBuilder.Create("PrimaryKey")
								.AddParameter("", "Id"),
							AttributeBuilder.Create("MaildatImport")
								.AddParameter("Order", fileDefinition.Ordinal)
						])
						.AddImplements("MaildatEntity")
						.AddImplements($"I{fileExtension.ToClassName()}")
						.AddProperties(
						[..
							//
							// Add the properties from the JSON file.
							//
							from tbl in fileDefinition.RecordDefinitions
							//
							// Read some of the variables so they can be used multiple times.
							//
							let propertyName = tbl.FieldName.ToPropertyName(tbl.FieldCode)
							let description = string.Join(" ", tbl.Description.Select(t => t.Sanitize().Transform(To.SentenceCase))).EndSentence()
							//
							// Create the class property. If the name is Reserve, then append th field code because a
							// class may have more than one reserve field.
							//
							select PropertyBuilder.Create(propertyName)
								//
								// All properties will be set to public.
								//
								.SetScope("public")
								//
								// Set the return type using a ntive .NET type.
								//
								.SetReturnType(tbl.Data.Type.ToDotNetType(tbl.DataType, tbl.Required))
								//
								// Add a summary made up of the code, name and description.
								//
								.SetSummary($"{tbl.FieldName.Sanitize()} ({tbl.FieldCode})", description)
								//
								// Set the default value of the clsoing character to #.
								//
								.SetDefaultValue(tbl.Data.Type == "closing" ? "\"#\"" : null)
								//
								// 
								//
								.SetPrecision(tbl.Data.Precision)
								//
								// Add the property attributes.
								//
								.AddAttributes(
								[
									//
									// Add the Mail.dat attribute to preserve the specification values
									// and make them available to developers.
									//
									AttributeBuilder.Create("MaildatField")
										.AddParameter("Extension", fileExtension)
										.AddParameter("FieldCode", tbl.FieldCode)
										.AddParameter("FieldName", tbl.FieldName.Sanitize().Transform(To.SentenceCase))
										.AddParameter("Start", tbl.Start)
										.AddParameter("Length", tbl.Length)
										.AddParameter("Required", tbl.Required)
										.AddParameter("Key",  tbl.Key)
										.AddParameter("DataType", tbl.DataType)
										.AddParameter("Default", tbl.Default)
										.AddParameter("Description", description)
										.AddParameter("Type", tbl.Data.Type)
										.AddParameter("Format", tbl.Data.Format)
										.AddConditionalParameter(tbl.Data.Precision.HasValue, "Precision", tbl.Data.Precision)
										.AddConditionalParameter(tbl.Data.References != null && tbl.Data.References.Count != 0, "References", string.Join(",", tbl.Data.References)),
									//
									// Add the column attribute for compatibility to EF Core.
									//
									AttributeBuilder.Create("Column")
										.AddParameter("", propertyName)
										.AddParameter("Order", columnOrder++)
										.AddParameter("TypeName", tbl.Data.Type.ToSqliteType(tbl.DataType)),
									//
									// Add a Required attribute if this field is required.
									//
									AttributeBuilder.CreateConditional(
										tbl.Required,
										"Required"),
									//
									// Add a Key attribute if this field is a key.
									//
									AttributeBuilder.CreateConditional(
										tbl.Key,
										"MaildatKey"),
									//
									// Add a MaxLength attribute if this field is a string.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type.ToDotNetType(tbl.DataType, tbl.Required) == "string",
										"MaxLength",
										AttributeParameter.Create("", tbl.Length)),
									//
									// Add the allowed values.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Values != null && tbl.Data.Values.Count != 0,
										"AllowedValues",
										[.. (from tbl in tbl.Data.Values
										 select AttributeParameter.Create("", tbl.Key))]),
									//
									// Add allowed values for the closing field.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type=="closing",
										"AllowedValues",
										AttributeParameter.Create("", "#")),
									//
									// Add the precision attribute if this field has a precision value.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Precision.HasValue,
										"Precision",
										AttributeParameter.Create("", tbl.Data.Precision)),
									//
									// Add the comment attribute to preserve the field code and name.
									//
									AttributeBuilder.Create("Comment")
										.AddParameter("", tbl.FieldCode),
									//
									// Add the type converter for date fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "date",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatDateConverter))),
									//
									// Add the type converter for time fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "time",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatTimeConverter))),
									//
									// Add the type converter for integer fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "integer" && tbl.DataType == "N",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatIntegerConverter))),
									//
									// Add the type converter for decimal fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "decimal",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatDecimalConverter))),
									//
									// Add the type converter for string fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "string",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatStringConverter))),
									//
									// Add the type converter for closing fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "closing",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatClosingConverter))),
									//
									// Add the type converter for enum fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "enum",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatEnumConverter))),
									//
									// Add the type converter for reserve fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "reserve",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatReserveConverter))),
									//
									// Add the type converter for reserve fields.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Type == "zipcode",
										"TypeConverter",
										AttributeParameter.Create("", typeof(MaildatZipCodeConverter)))
								])
						])
						.AddMethod(MethodBuilder.Create("OnImportDataAsync")
							.SetScope("protected override ")
							.SetReturnType("Task<ILoadError[]>")
							.SetSummary("Sets property values from one line of an import file.")
							.AddParameter("int", "fileLineNumber")
							.AddParameter("ReadOnlySpan<byte>", "line")
							.AddCode("List<ILoadError> returnValue = [];")
							.AddCode("")
							.AddCode(
								[.. from tbl in fileDefinition.RecordDefinitions
									let propertyName = tbl.FieldName.ToPropertyName(tbl.FieldCode)
									select $"this.{propertyName} = line.ParseForImport<{fileExtension.ToClassName()}, {tbl.Data.Type.ToDotNetType(tbl.DataType, tbl.Required)}>(p => p.{propertyName}, returnValue);"
								]
							)
							.AddCode("this.FileLineNumber = fileLineNumber;")
							.AddCode("")
							.AddCode("return Task.FromResult<ILoadError[]>(returnValue.ToArray());")
						)
						.AddMethod(MethodBuilder.Create("OnExportDataAsync")
							.SetScope("protected override ")
							.SetReturnType("Task<string>")
							.SetSummary("Formats all property values into a single line suitable for export.")
							.AddCode("StringBuilder sb = new();")
							.AddCode("")
							.AddCode(
								[.. from tbl in fileDefinition.RecordDefinitions
									let propertyName = tbl.FieldName.ToPropertyName(tbl.FieldCode)
									select $"sb.Append(this.{propertyName}.FormatForExport<{fileExtension.ToClassName()}, {tbl.Data.Type.ToDotNetType(tbl.DataType, tbl.Required)}>(p => p.{propertyName}));"
								]
							)
							.AddCode("")
							.AddCode("return Task.FromResult(sb.ToString());")
						)
						.Build($"{options.ClassOutputDirectory}/{fileExtension.ToClassFileName()}", 1));

					//
					// Create an interface for this file.
					//
					AnsiConsole.MarkupLine("\tBuilding [yellow]interface[/] file.");
					interfaces.Add(ClassBuilder.Create($"{fileExtension.ToInterfaceName()}")
						.SetHeaderComments(
						[
							"",
							"Copyright (c) 2025 Open Mail.dat",
							"",
							"This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.",
							"",
							$"This code was auto-generated on {DateTime.Now.ToOrdinalWords()}.",
							"by the Open Mail.dat Code Generator.",
							"",
							"Author: Daniel M porrey",
							$"Version {specificationFile.Version.Major.Replace("-", ".")}.{specificationFile.Version.Revision}",
							""
						])
						.SetNameSpace("Mail.dat")
						.SetSummary(fileDescription)
						.SetObjectType("interface")
						.SetScope("public")
						.SetPartial(false)
						.AddImplements("IMaildatEntity")
						.AddProperties(
						[..
							//
							// Add the properties from the JSON file.
							//
							from tbl in fileDefinition.RecordDefinitions
							//
							// Read some of the variables so they can be used multiple times.
							//
							let propertyName = tbl.FieldName.ToPropertyName(tbl.FieldCode)
							let description = string.Join(" ", tbl.Description.Select(t => t.Sanitize().Transform(To.SentenceCase))).EndSentence()
							//
							// Create the class property. If the name is Reserve, then append th field code because a
							// class may have more than one reserve field.
							//
							select PropertyBuilder.Create(propertyName)
								//
								// All properties will be set to public.
								//
								.SetScope(null)
								//
								// Set the return type using a ntive .NET type.
								//
								.SetReturnType(tbl.Data.Type.ToDotNetType(tbl.DataType, tbl.Required))
								//
								// Add a summary made up of the code, name and description.
								//
								.SetSummary($"{tbl.FieldName.Sanitize()} ({tbl.FieldCode})", description)
								//
								// Make these fields read-only.
								//
								.SetReadOnly(tbl.Data.Type == "closing")
							])
						.Build($"{options.InterfaceOutputDirectory}/I{fileExtension.Pascalize()}.cs", 1));

					AnsiConsole.MarkupLine($"\t[blue]{classes.Last().Properties.Count}[/] properties added.\r\n");
				}

				//
				// Build the database context.
				//
				AnsiConsole.MarkupLine("\r\nBuilding [yellow]database context[/] file.");
				ClassBuilder.Create(options.DatabaseContextName)
					.SetHeaderComments(
					[
						"",
						"Copyright (c) 2025 Open Mail.dat",
						"",
						"This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.",
						"",
						$"This code was auto-generated on {DateTime.Now.ToOrdinalWords()}.",
						"by the Open Mail.dat Code Generator.",
						"",
						"Author: Daniel M porrey",
						$"Version {specificationFile.Version.Major.Replace("-", ".")}.{specificationFile.Version.Revision}",
						""
					])
					.SetNameSpace("Mail.dat")
					.AddUsing("Diamond.Core.Repository.EntityFrameworkCore")
					.AddUsing("Microsoft.EntityFrameworkCore")
					.AddUsing("Microsoft.Extensions.Logging")
					.SetSummary("Entity Framework Core database context for Mail.dat entities.")
					.SetObjectType("class")
					.SetScope("public")
					.SetPartial(true)
					.AddImplements($"RepositoryContext<{options.DatabaseContextName}>")
					.AddConstructor(MethodBuilder.Create(options.DatabaseContextName)
						.SetScope("public")
						.SetBase("base()")
					)
					.AddConstructor(MethodBuilder.Create(options.DatabaseContextName)
						.SetScope("public")
						.AddParameter($"ILogger<{options.DatabaseContextName}>", "logger")
						.AddParameter($"DbContextOptions<{options.DatabaseContextName}>", "options")
						.SetBase("base(logger, options)")
						.AddCode($"logger.LogDebug(\"Created {{context}}.\", nameof({options.DatabaseContextName}));")
					)
					.AddProperties(
						[..
						//
						// Add the properties from the JSON file.
						//
						from tbl in specificationFile.Files.OrderBy(t => t.Ordinal)
						select PropertyBuilder.Create(tbl.FileExtension.ToClassName())
							//
							// All properties will be set to public.
							//
							.SetScope("public")
							//
							// Set the return type using a ntive .NET type.
							//
							.SetReturnType($"DbSet<{tbl.FileExtension.ToClassName()}>")
							.AddAttributes(
								AttributeBuilder.Create("MaildatExport")
									.AddParameter("Order", tbl.Ordinal)
							)
						])
					.AddProperties(
					[
						PropertyBuilder.Create("Errors")
							.SetScope("public")
							.SetReturnType($"DbSet<Error>")
					])
					.AddMethod(MethodBuilder.Create("OnModelCreating")
						.SetScope("protected override void")
						.AddParameter("ModelBuilder", "modelBuilder")
						.AddCode($"this.Logger.LogDebug(\"OnModelCreating() called in {{context}}\", nameof({options.DatabaseContextName}));")
						.AddCode(classes.BuildContextHasKeyCode())
						.AddCode(classes.BuildContextHasIndexCode())
						.AddCode()
					)
					.Build($"{options.ContextOutputDirectory}/{options.DatabaseContextName}.cs", 1);

				//
				// Display the summary.
				//
				AnsiConsole.MarkupLine($"\r\n[green]{classes.Count}[/] classes built.");
				AnsiConsole.MarkupLine($"[green]{interfaces.Count}[/] interfaces built.");
				AnsiConsole.MarkupLine($"[green]1[/] context file built.");
			}
			else
			{
				foreach (CommandLine.Error error in result.Errors)
				{
					AnsiConsole.MarkupLine($"[red]Error:[/] '[white]{error}[/]'");
				}

				returnValue = 1;
			}

			return Task.FromResult(returnValue);
		}
	}
}
