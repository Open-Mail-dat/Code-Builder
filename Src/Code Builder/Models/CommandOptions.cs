using CommandLine;

namespace Mail.dat.CodeBuilder
{
	public class CommandOptions
	{
		[Option('s', "specification-file", Required = true, HelpText = "The full or relative path to the Mail.dat JSON specification file.")]
		public string SpecificationFile { get; set; }

		[Option('c', "class-output-directory", Required = true, HelpText = "The directory where class files are written.")]
		public string ClassOutputDirectory { get; set; }

		[Option('i', "interface-output-directory", Required = true, HelpText = "The directory where interface files are written.")]
		public string InterfaceOutputDirectory { get; set; }

		[Option('x', "context-output-directory", Required = true, HelpText = "The directory where the context file is written.")]
		public string ContextOutputDirectory { get; set; }

		[Option('m', "add-tracking-fields", Required = true, HelpText = "When true, CreatedDateTime, CreatedBy, ModifiedDateTime and ModifiedBy fields are added to every class definition. The default is false.")]
		public bool AddTrackingFields { get; set; }

		[Option('m', "database-context-name", Required = true, HelpText = "Specifies the name of the Entity Framework Core context class name.")]
		public string DatabaseContextName { get; set; }
	}
}
