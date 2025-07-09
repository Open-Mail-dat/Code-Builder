using Diamond.Core.CommandLine.Model;
using Humanizer;
using Mail.dat.Json.Specification;
using Microsoft.Extensions.Logging;
using Spectre.Console;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Handles the build command for generating code from the JSON Mail.dat specification.
	/// </summary>
	internal class BuildCommandHandler : ModelCommand<CommandOptions>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuildCommandHandler"/> class.
		/// </summary>
		/// <param name="logger">The logger instance used for logging.</param>
		public BuildCommandHandler(ILogger<BuildCommandHandler> logger)
			: base(logger, "build", "Generates code from the JSON Mail.dat specification..")
		{
		}

		/// <summary>
		/// Represents the namespace used for Mail.dat-related operations.
		/// </summary>
		private const string NameSpace = "Mail.dat";

		/// <summary>
		/// Represents the name of the database context used for Maildat operations.
		/// </summary>
		private const string ContextName = "MaildatContext";

		/// <summary>
		/// Handles the execution of the command by processing the provided options, generating classes, interfaces, and
		/// database context files based on the specifications, and managing the output directories.
		/// </summary>
		/// <remarks>This method performs the following operations: <list type="bullet"> <item><description>Loads and
		/// merges specification files into a unified structure.</description></item> <item><description>Generates class and
		/// interface files based on the specifications.</description></item> <item><description>Builds a database context
		/// file for Entity Framework Core integration.</description></item> <item><description>Manages output directories by
		/// clearing existing files to avoid conflicts.</description></item> </list> The method provides progress updates and
		/// ensures that all generated files adhere to the specified structure and naming conventions.</remarks>
		/// <param name="options">The command options containing input specifications, output directory paths, and other configuration settings.</param>
		/// <returns>A task that represents the asynchronous operation. The task result contains an integer indicating the success or
		/// failure of the command execution. A value of 0 typically indicates success.</returns>
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
			DirectoryInfo modelDirectory = new($"{options.ModelsDirectory}/Models");
			DirectoryInfo interfaceDirectory = new($"{options.ModelsDirectory}/Interfaces");
			DirectoryInfo contextDirectory = new($"{options.ModelsDirectory}/Context");
			DirectoryInfo valuesDirectory = new($"{options.ModelsDirectory}/Values");
			DirectoryInfo repositoriesDirectory = new($"{options.ModelsDirectory}/Repositories");
			DirectoryInfo hostingDirectory = new($"{options.HostingDirectory}/Hosting");

			//
			// Remove all targets files now so that we do not get an error mid-way through the process.
			//
			modelDirectory.DeleteAllFiles("*.cs");
			interfaceDirectory.DeleteAllFiles("*.cs");
			contextDirectory.DeleteAllFiles("*.cs");
			valuesDirectory.DeleteAllFiles("*.cs");
			repositoriesDirectory.DeleteAllFiles("*.cs");

			//
			// Iterate through each file and build the classes.
			//
			int index = 0;
			foreach (FileGroup fileGroup in merged)
			{
				index++;

				//	//
				//	// Get the newest version.
				//	//
				string maxVersion = fileGroup.Items.Max(t => t.Version.Major);

				//	//
				//	// Display the extension and and name to show progress.
				//	//
				Panel panel = new Panel($"[white]{fileGroup.FileExtension}[/] - [yellow]{fileGroup.Name(maxVersion)}[/] ({index} of {merged.Count()})").RoundedBorder().Expand();
				AnsiConsole.Write(panel);

				//	//
				//	// Mark the starting column order for specifying the filed order in the database.
				//	//
				int columnOrder = 2;

				//	//
				//	// Create a class for this file.
				//	//
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

				//	//
				//	// Create an interface for this file.
				//	//
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
			// Build the repository files.
			//
			AnsiConsole.MarkupLine("\r\nBuilding [yellow]repository[/] files.");
			foreach (FileGroup fileGroup in merged)
			{
				string objectName = fileGroup.FileExtension.ToClassName();
				string interfaceName = fileGroup.FileExtension.ToInterfaceName();

				ClassBuilder.Create($"{objectName}Repository")
					.SetFileHeaderComments()
					.SetNameSpace(NameSpace)
					.AddUsing("Diamond.Core.Repository")
					.AddUsing("Diamond.Core.Repository.EntityFrameworkCore")
					.AddUsing("Microsoft.EntityFrameworkCore")
					.AddAttributes(fileGroup.MaildatVersionsAttribute())
					.SetObjectType("class")
					.SetScope("public")
					.SetPartial(true)
					.SetSummary($"Repository for the <see cref=\"{objectName}\"/> entity.")
					.AddImplements($"EntityFrameworkRepository<{interfaceName}, {objectName}, {ContextName}>")
					.AddConstructor(MethodBuilder.Create($"{objectName}Repository")
						.SetScope("public")
						.SetSummary($"Creates and instance of the <see cref=\"{objectName}Repository\"/> class with the specified context and entity factory.")
						.AddParameter($"IEntityFactory<{interfaceName}>", "entityFactory")
						.SetBase("base(entityFactory)")
					)
					.AddConstructor(MethodBuilder.Create($"{objectName}Repository")
						.SetScope("public")
						.SetSummary($"Creates and instance of the <see cref=\"{objectName}Repository\"/> class with the specified context and entity factory.")
						.AddParameter(ContextName, "context")
						.AddParameter($"IEntityFactory<{interfaceName}>", "entityFactory")
						.SetBase("base(context, entityFactory)")
					)
					.AddMethod(MethodBuilder.Create("MyDbSet")
						.SetScope("protected override")
						.SetReturnType($"DbSet<{objectName}>")
						.SetSummary($"Returns the DbSet for the <see cref=\"{objectName}\"/> entity.")
						.AddParameter(ContextName, "context")
						.SetExpression($"context.{objectName}")
					)
					.Build($"{repositoriesDirectory.FullName}/{objectName}Repository.cs", 1);
			}

			//
			// Build the host extensions class.
			//
			AnsiConsole.MarkupLine("\r\nBuilding [yellow]hosting extensions[/] file.");
			ClassBuilder.Create("ModelExtensions")
					.SetFileHeaderComments()
					.SetNameSpace(NameSpace)
					.AddUsing("Diamond.Core.Repository")
					.AddUsing("Microsoft.Extensions.DependencyInjection")
					.SetScope("public static")
					.SetObjectType("class")
					.AddMethod(MethodBuilder.Create("AddOpenMaildatModels")
						.SetScope("public static")
						.SetReturnType("IServiceCollection")
						.AddParameter("this IServiceCollection", "services")
						.SetSummary("Adds the Open Mail.dat services to the specified service collection.")
						.AddCode([.. (from tbl in merged
								  let objectName = tbl.FileExtension.ToClassName()
								  let interfaceName = tbl.FileExtension.ToInterfaceName()
								  select new string[]
								  {
									"//",
									$"// {objectName}",
									"//",
									$"services.AddTransient<IEntityFactory<{interfaceName}>, EntityFactory<{interfaceName}, {objectName}>>();",
									$"services.AddTransient<IRepository<{interfaceName}>, {objectName}Repository>();",
									""
								  }).SelectMany(t => t)])
						  .AddCode("return services;")
					)
					.Build($"{hostingDirectory.FullName}/ModelExtensions.cs", 1);

			//
			// Build the JSON services file for the models.
			//
			AnsiConsole.MarkupLine("\r\nBuilding [yellow]JSON services[/] file.");
			ServiceFileBuilder.Create()
				.AddAliases((from tbl in merged
							 let interfaceName = tbl.FileExtension.ToInterfaceName()
							 let objectName = tbl.FileExtension.ToClassName()
							 select new AliasBuilder[]
							 {
								 AliasBuilder.Create(
									interfaceName,
									AssemblyReferenceBuilder.Create(interfaceName, NameSpace, $"{NameSpace}.Models")),
								 AliasBuilder.Create(
									objectName,
									AssemblyReferenceBuilder.Create(objectName, NameSpace, $"{NameSpace}.Models"))
							 }
							).SelectMany(t => t).ToList())
				.AddServices((from tbl in merged
							  let objectName = tbl.FileExtension.ToClassName()
							  let interfaceName = tbl.FileExtension.ToInterfaceName()
							  select new ServiceBuilder[]
							  {
								  ServiceBuilder.Create(
									 AssemblyReferenceBuilder.Create($"IEntityFactory`1[[<{interfaceName}>]]", "Diamond.Core.Repository", $"Diamond.Core.Repository.Abstractions"),
									 AssemblyReferenceBuilder.Create($"EntityFactory`2[[<{interfaceName}>], [<{objectName}>]]", "Diamond.Core.Repository", $"Diamond.Core.Repository"),
									 "Transient"),
								  ServiceBuilder.Create(
									 AssemblyReferenceBuilder.Create($"IRepository`1[[<{interfaceName}>]]", "Diamond.Core.Repository", $"Diamond.Core.Repository.Abstractions"),
									 AssemblyReferenceBuilder.Create($"{objectName}Repository", NameSpace, $"{NameSpace}.Models"),
									 "Transient")
							  }
							).SelectMany(t => t).ToList())
				.Build($"{options.ModelsDirectory}/Services/Mail.dat.Models.json", 0);


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