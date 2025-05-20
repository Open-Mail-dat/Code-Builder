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
	}
}
