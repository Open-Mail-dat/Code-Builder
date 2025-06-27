using Diamond.Core.CommandLine.Model;
using Humanizer;
using Mail.dat.Json.Specification;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Spectre.Console;

namespace Mail.dat.BuildCommand
{
	internal class BuildCommandHandler : ModelCommand<CommandOptions>
	{
		public BuildCommandHandler(ILogger<BuildCommandHandler> logger)
			: base(logger, "build", "Generates code from the JSON Mail.dat specification..")
		{
		}

		private const string NameSpace = "Mail.dat";
		private const string ContextName = "MaildatContext";

		protected override async Task<int> OnHandleCommand(CommandOptions options)
		{
			int returnValue = 0;

			//
			// Load the specifications.
			//
			Dictionary<string, SpecificationFile> specificationFiles = await options.SpecificationFiles.LoadSpecificationsAsync();

			//
			// Merge all the specifications into one.
			//
			IEnumerable<FileGroup> merged = await specificationFiles.MergeSpecificationsAsync();

			//
			// Create a list for the classes.
			//
			List<ClassBuilder> classes = [];
			List<ClassBuilder> interfaces = [];

			//
			// Build the output directories.
			//
			DirectoryInfo modelDirectory = new($"{options.OutputDirectory}/Models");
			DirectoryInfo interfaceDirectory = new($"{options.OutputDirectory}/Interfaces");
			DirectoryInfo contextDirectory = new($"{options.OutputDirectory}/Context");
			DirectoryInfo valuesDirectory = new($"{options.OutputDirectory}/Values");

			//
			// Remove all targets files now so that we do not get an error mid-way through the process.
			//
			modelDirectory.DeleteAllFiles("*.cs");
			interfaceDirectory.DeleteAllFiles("*.cs");
			contextDirectory.DeleteAllFiles("*.cs");
			valuesDirectory.DeleteAllFiles("*.cs");

			//
			// Iterate through each file and build the classes.
			//
			int index = 0;
			foreach (FileGroup fileGroup in merged)
			{
				index++;

				//
				// Get the newest version.
				//
				string maxVersion = fileGroup.Items.Max(t => t.Version.Major);

				//
				// Display the extension and and name to show progress.
				//
				Panel panel = new Panel($"[white]{fileGroup.FileExtension}[/] - [yellow]{fileGroup.Name(maxVersion)}[/] ({index} of {merged.Count()})").RoundedBorder().Expand();
				AnsiConsole.Write(panel);

				//
				// Mark the starting column order for specifying the filed order in the database.
				//
				int columnOrder = 2;

				//
				// Create a class for this file.
				//
				AnsiConsole.MarkupLine("\tBuilding [yellow]class[/] file.");
				classes.Add(ClassBuilder.Create(fileGroup.FileExtension.ToClassName())
					.SetFileHeaderComments()
					.SetNameSpace(NameSpace)
					.AddUsing("System.ComponentModel.DataAnnotations.Schema")
					.AddUsing("System.ComponentModel.DataAnnotations")
					.AddUsing("Microsoft.EntityFrameworkCore")
					.AddUsing("System.ComponentModel")
					.AddUsing("System.Text")
					.SetSummary(fileGroup.Description(maxVersion))
					.SetObjectType("class")
					.SetScope("public")
					.SetPartial(true)
					.AddAttributes(
						fileGroup.AddMaildatFileAttributes(),
						fileGroup.AddMaildatImportAttributes(),
						[
							AttributeBuilder.Create("Table")
								.AddParameter("", fileGroup.FileExtension.TruePascalize())
								.AddParameter("Schema", "Maildat"),
							AttributeBuilder.Create("PrimaryKey")
								.AddParameter("", "Id"),
							fileGroup.MaildatVersionsAttribute()
						])
					.AddImplements("MaildatEntity")
					.AddImplements($"I{fileGroup.FileExtension.ToClassName()}")
					.AddProperties(
					[..
						//
						// Add ALL properties from the specification files.
						//
						from tbl in fileGroup.RecordDefinitions()
						//
						// Read some of the variables so they can be used multiple times.
						//
						let propertyName = tbl.ToPropertyName()
						//
						// Create the class property. If the name is Reserve, then append the field code because a
						// class may have more than one reserve field.
						//
						select PropertyBuilder.Create(propertyName)
							//
							// All properties will be set to public.
							//
							.SetScope("public")
							//
							// Set the return type using a native .NET type.
							//
							.SetReturnType(fileGroup.ReturnType(tbl))
							//
							// Add a summary made up of the code, name and description.
							//
							.SetSummary($"{tbl.FieldName.Sanitize()} ({tbl.FieldCode})", tbl.Description())
							//
							// Set the default value of the clsoing character to #.
							//
							.SetDefaultValue(tbl.Data.Type == "closing" ? "\"#\"" : null)
							//
							// If decimal, set the field precision.
							//
							.SetPrecision(tbl.Data.Precision)
							//
							// Add the property attributes.
							//
							.AddAttributes(
							[
								//
								// Add a MaildatField attribute for each specification version.
								//
								fileGroup.AddMaildatFieldAttributes(tbl),
								[
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
									// Add a MaxLength attribute if this field is a string. Use the maxmium
									// length of the filed in all specificatios.
									//
									AttributeBuilder.CreateConditional(
										fileGroup.ReturnType(tbl) == "string",
										"MaxLength",
										AttributeParameter.Create("", fileGroup.Length(tbl))),
									//
									// Add the allowed values.
									//
									AttributeBuilder.CreateConditional(
										tbl.Data.Values != null && tbl.Data.Values.Count > 0,
										"AllowedValues",
										[.. (from tbl in fileGroup.AllowedValueKeys(tbl)
											 select AttributeParameter.Create("", tbl))]),
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
										AttributeParameter.Create("", typeof(MaildatZipCodeConverter))),
									//
									//
									//
									AttributeBuilder.CreateConditional(
										tbl.Data != null && tbl.Data.Values != null && tbl.Data.Values.Count != 0,
										"MaildatValues",
										AttributeParameter.Create("", $"typeof({propertyName.Pluralize()})", false)),
									fileGroup.MaildatVersionsAttribute(tbl)
								]
							])
							.CreateValuesClass(
									$"{valuesDirectory.FullName}/{propertyName.Pluralize()}.cs",
									propertyName,
									NameSpace,
									fileGroup,
									tbl)
					])
					.AddMethod(MethodBuilder.Create("OnImportDataAsync")
						.SetScope("protected override")
						.SetReturnType("Task<ILoadError[]>")
						.SetSummary("Sets property values from one line of an import file.")
						.AddParameter("string", "version")
						.AddParameter("int", "fileLineNumber")
						.AddParameter("ReadOnlySpan<byte>", "line")
						.AddCode("List<ILoadError> returnValue = [];")
						.AddCode("")
						.AddCode(
							[.. from tbl in fileGroup.RecordDefinitions()
									let propertyName = tbl.ToPropertyName()
									select $"this.{propertyName} = line.ParseForImport<{fileGroup.FileExtension.ToClassName()}, {fileGroup.ReturnType(tbl)}>(version, p => p.{propertyName}, returnValue);"
							]
						)
						.AddCode("this.FileLineNumber = fileLineNumber;")
						.AddCode("")
						.AddCode("return Task.FromResult(returnValue.ToArray());")
					)
					.AddMethod(MethodBuilder.Create("OnExportDataAsync")
						.SetScope("protected override")
						.SetReturnType("Task<string>")
						.SetSummary("Formats all property values into a single line suitable for export.")
						.AddParameter("string", "version")
						.AddCode("StringBuilder sb = new();")
						.AddCode("")
						.AddCode(
							[.. from tbl in fileGroup.RecordDefinitions()
									let propertyName = tbl.ToPropertyName()
									select $"sb.Append(this.{propertyName}.FormatForExport<{fileGroup.FileExtension.ToClassName()}, {fileGroup.ReturnType(tbl)}>(version, p => p.{propertyName}));"
							]
						)
						.AddCode("")
						.AddCode("return Task.FromResult(sb.ToString());")
					)
					.Build($"{modelDirectory.FullName}/{fileGroup.FileExtension.ToClassFileName()}", 1));

				//
				// Create an interface for this file.
				//
				AnsiConsole.MarkupLine("\tBuilding [yellow]interface[/] file.");
				interfaces.Add(ClassBuilder.Create($"{fileGroup.FileExtension.ToInterfaceName()}")
					.SetFileHeaderComments()
					.SetNameSpace(NameSpace)
					.SetSummary(fileGroup.Description(maxVersion))
					.SetObjectType("interface")
					.SetScope("public")
					.SetPartial(false)
					.AddImplements("IMaildatEntity")
					.AddProperties(
					[..
							//
							// Add the properties from the JSON file.
							//
							from tbl in fileGroup.RecordDefinitions()
							//
							// Read some of the variables so they can be used multiple times.
							//
							let propertyName = tbl.ToPropertyName()
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
								.SetReturnType(fileGroup.ReturnType(tbl))
								//
								// Add a summary made up of the code, name and description.
								//
								.SetSummary($"{tbl.FieldName.Sanitize()} ({tbl.FieldCode})", description)
								//
								// Make these fields read-only.
								//
								.SetReadOnly(tbl.Data.Type == "closing")
						])
					.Build($"{interfaceDirectory.FullName}/I{fileGroup.FileExtension.TruePascalize()}.cs", 1));

				AnsiConsole.MarkupLine($"\t[blue]{classes.Last().Properties.Count}[/] properties added.\r\n");
			}

			//
			// Build the database context.
			//
			AnsiConsole.MarkupLine("\r\nBuilding [yellow]database context[/] file.");
			ClassBuilder.Create(ContextName)
				.SetFileHeaderComments()
				.SetNameSpace(NameSpace)
				.AddUsing("Diamond.Core.Repository.EntityFrameworkCore")
				.AddUsing("Microsoft.EntityFrameworkCore")
				.AddUsing("Microsoft.Extensions.Logging")
				.SetSummary("Entity Framework Core database context for Mail.dat entities.")
				.SetObjectType("class")
				.SetScope("public")
				.SetPartial(true)
				.AddImplements($"RepositoryContext<{ContextName}>")
				.AddConstructor(MethodBuilder.Create(ContextName)
					.SetScope("public")
					.SetBase("base()")
				)
				.AddConstructor(MethodBuilder.Create(ContextName)
					.SetScope("public")
					.AddParameter($"ILogger<{ContextName}>", "logger")
					.AddParameter($"DbContextOptions<{ContextName}>", "options")
					.SetBase("base(logger, options)")
					.AddCode($"logger.LogDebug(\"Created {{context}}.\", nameof({ContextName}));")
				)
				.AddProperties(
				[..
					//
					// Add the properties from the JSON file.
					//
					from tbl in merged.OrderBy(t => t.Ordinal)
					select PropertyBuilder.Create(tbl.FileExtension.ToClassName())
						//
						// All properties will be set to public.
						//
						.SetScope("public")
						//
						// Set the return type using a native .NET type.
						//
						.SetReturnType($"DbSet<{tbl.FileExtension.ToClassName()}>")
						.AddAttributes(
							AttributeBuilder.Create("MaildatExport")
								.AddParameter("Order", tbl.Ordinal),
							tbl.MaildatVersionsAttribute()
						)
				])
				.AddProperties(
				[
					PropertyBuilder.Create("Errors")
							.SetScope("public")
							.SetReturnType($"DbSet<Error>")
				])
				.AddMethod(MethodBuilder.Create("OnModelCreating")
					.SetScope("protected override")
					.SetReturnType("void")
					.AddParameter("ModelBuilder", "modelBuilder")
					.AddCode($"this.Logger.LogDebug(\"OnModelCreating() called in {{context}}\", nameof({ContextName}));")
					.AddCode(classes.BuildContextHasKeyCode())
					.AddCode(classes.BuildContextHasIndexCode())
					.AddCode()
				)
				.Build($"{contextDirectory.FullName}/{ContextName}.cs", 1);

			//
			// Display the summary.
			//
			AnsiConsole.MarkupLine($"\r\n[green]{classes.Count}[/] classes built.");
			AnsiConsole.MarkupLine($"[green]{interfaces.Count}[/] interfaces built.");
			AnsiConsole.MarkupLine($"[green]1[/] context file built.");

			return returnValue;
		}
	}
}