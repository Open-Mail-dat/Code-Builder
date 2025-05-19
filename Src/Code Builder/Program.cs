using System.Reflection;
using Humanizer;
using Newtonsoft.Json.Linq;

namespace Mail.dat.CodeBuilder
{
	internal class Program
	{
		static Task<int> Main(string[] args)
		{
			int returnValue = 0;

			//
			// Output path.
			//
			string outputPath = "../../../../Mail.dat.Models/Models";

			//
			// Create a path to the local JSON file.
			//
			string jsonFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Specification/mail-dat.json");

			//
			// Read the file contents into a string.
			//
			string jsonContent = File.ReadAllText(jsonFilePath);

			//
			// Parse the JSON string into a JObject.
			//
			JObject specification = JObject.Parse(jsonContent);

			//
			// Get the version and revision.
			//
			string version = specification["version"]["major"].ToString();
			string revision = specification["version"]["revision"].ToString();

			//
			// Parse the JSON.
			//
			JArray attributes = (JArray)specification["files"];

			//
			// Create a list for the classes.
			//
			List<ClassBuilder> classes = [];

			//
			// Iterate through each file and build the classes.
			//
			foreach (JObject attribute in attributes.Cast<JObject>())
			{
				string file = attribute["file"].ToString().Transform(To.LowerCase).Sanitize().Transform(To.TitleCase).AddRecord();
				string fileExtension = attribute["fileExtension"].ToString();
				string fileSummary = attribute["fileSummary"].ToString().Sanitize().Transform(To.SentenceCase).EndSentence();
				string fileDescription = attribute["fileDescription"].ToString().Sanitize().Transform(To.SentenceCase).EndSentence() ?? fileSummary;
				fileDescription = string.IsNullOrEmpty(fileDescription) ? fileSummary : fileDescription;

				Console.WriteLine($"Building {fileExtension}...");

				string fileName = $"{outputPath}/{fileExtension.Pascalize()}.cs";
				int columnOrder = 0; ;

				//
				// Create a class for this file.
				//
				classes.Add(ClassBuilder.Create(fileExtension.Pascalize())
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
						"Version 1.0.0",
						""
					])
					.SetNameSpace("Mail.dat")
					.AddUsing("System.ComponentModel.DataAnnotations.Schema")
					.AddUsing("System.ComponentModel.DataAnnotations")
					.SetSummary(fileDescription)
					.SetObjectType("class")
					.SetClassScope("public")
					.SetPartial(true)
					.AddAttributes(
					[
						AttributeBuilder.Create("MaildatFile")
							.AddParameter("Version", version)
							.AddParameter("Revision", revision)
							.AddParameter("Extension", fileExtension)
							.AddParameter("File", file)
							.AddParameter("Summary", fileSummary)
							.AddParameter("Description", fileDescription),
						AttributeBuilder.Create("Table")
							.AddParameter("", fileExtension.Pascalize())
							.AddParameter("Schema", "Maildat")
					])
					.AddImplements(ImplementsBuilder.Create("MaildatFieldTemplate"))
					.AddProperties(
					[..
						//
						// Add an Id property to every class.
						//
						new PropertyBuilder[]
						{
							PropertyBuilder.Create("Id")
								.SetClassScope("public new")
								.SetReturnType("int")
								.SetSummary("The unique identifier for the record.")
								.AddAttributes(
								[
									AttributeBuilder.Create("Key"),
									AttributeBuilder.Create("Column")
										.AddParameter("", "Id")
										.AddParameter("Order", (columnOrder++).ToString(), false),
									AttributeBuilder.Create("DatabaseGenerated")
										.AddParameter("", "DatabaseGeneratedOption.Identity", false)
								])
						}
						.Union
						(
							//
							// Add the properties from the JSON file.
							//
							from tbl in (JArray)attribute["recordDefinitions"]
							//
							// Read some of the variables so they can be used multiple times.
							//
							let propertyName = tbl["fieldName"].ToString().Dehumanize().Pascalize().KeywordSanitize()
							let fieldCode = tbl["fieldCode"].ToString()
							let isRequired = tbl["required"].ToString().ToLower() =="true"
							let isKey = tbl["key"].ToString().ToLower() =="true"
							let description = string.Join(" ", tbl["description"].Select(t => t.ToString().Sanitize().Transform(To.SentenceCase))).EndSentence()
							let type = tbl["data"]["type"].ToString()
							let length = tbl["length"].ToString()
							let precision = tbl["data"]["precision"]?.ToString()
							let values = !string.IsNullOrWhiteSpace(tbl["data"]["values"]?.ToString()) ? tbl["data"]["values"].ToObject<Dictionary<string, string>>() : []
							let references = !string.IsNullOrWhiteSpace(tbl["data"]["references"]?.ToString()) ? tbl["data"]["references"].ToObject<List<string>>() : []
							//
							// Create the class property. If the name is Reserve, then append th field code because a
							// class may have more than one reserve field.
							//
							select PropertyBuilder.Create(propertyName == "Reserve" ? $"{propertyName}{fieldCode.Dehumanize().Pascalize().KeywordSanitize()}" : propertyName)
								//
								// All properties will be set to public.
								//
								.SetClassScope("public")
								//
								// Set the return type using a ntive .NET type.
								//
								.SetReturnType(type.ToDotNetType())
								//
								// Add a summary made up of the code, name and description.
								//
								.SetSummary($"{tbl["fieldName"].ToString().Sanitize()} ({tbl["fieldCode"]})", description)
								//
								// Make these fields read-only.
								//
								.SetReadOnly(type == "closing")
								//
								// Set the default value of the clsoing character to #.
								//
								.SetDefaultValue(type == "closing" ? "\"#\"" : null)
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
										.AddParameter("FieldCode", tbl["fieldCode"].ToString())
										.AddParameter("FieldName", tbl["fieldName"].ToString().Sanitize().Transform(To.SentenceCase))
										.AddParameter("Start", tbl["start"].ToString(), false)
										.AddParameter("Length", length, false)
										.AddParameter("Required", tbl["required"].ToString().ToLower(), false)
										.AddParameter("Key",  tbl["key"].ToString().ToLower(), false)
										.AddParameter("DataType", tbl["dataType"].ToString())
										.AddParameter("Default", tbl["default"]?.ToString())
										.AddParameter("Description", description)
										.AddParameter("Type", type)
										.AddParameter("Format", tbl["data"]["format"]?.ToString())
										.AddParameter("Precision", precision, false)
										.AddParameter("References", string.Join(",", references)),
									//
									// Add the column attribute for compatibility to EF Core.
									//
									AttributeBuilder.Create("Column")
										.AddParameter("", propertyName)
										.AddParameter("Order", (columnOrder++).ToString(), false),
									//
									// Add a Required attribute if this field is required.
									//
									isRequired ? AttributeBuilder.Create("Required") : null,
									//
									// Add a Key attribute if this field is a key.
									//
									isKey ? AttributeBuilder.Create("Key") : null,
									//
									// Add a MaxLength attribute if this field is a string.
									//
									type.ToDotNetType() == "string" ? AttributeBuilder.Create("MaxLength").AddParameter("", length, false) : null,
									//
									// Add the allowed values.
									//
									values.Count != 0 ?
										AttributeBuilder.Create("AllowedValues")
											.AddParameters(values.Select(t => new AttributeParameter() { Name="", Value = t.Key, Quoted = true }).ToList())
									: null,
									//
									// Add allowed values for the closing field.
									//
									type=="closing" ?
										AttributeBuilder.Create("AllowedValues")
											.AddParameter("", "#")
									: null
								])
						)
					])
					.Build(fileName, 1));
			}

			Console.WriteLine($"{classes.Count} classes built.");

			return Task.FromResult(returnValue);
		}
	}
}
