using System.ComponentModel.DataAnnotations;

namespace Mail.dat.BuildCommand
{
	internal class CommandOptions
	{
		[Required]
		[Display(Order = 1, Name = "specification-file", ShortName = "s", Description = "The full or relative path to the Mail.dat JSON specification file.")]
		public FileInfo SpecificationFile { get; set; }

		[Required]
		[Display(Order = 2, Name = "class-output-directory", ShortName = "c", Description = "The directory where class files are written.")]
		public DirectoryInfo ClassOutputDirectory { get; set; }

		[Required]
		[Display(Order = 3, Name = "interface-output-directory", ShortName = "i", Description = "The directory where interface files are written.")]
		public DirectoryInfo InterfaceOutputDirectory { get; set; }

		[Required]
		[Display(Order = 4, Name = "context-output-directory", ShortName = "x", Description = "The directory where the context file is written.")]
		public DirectoryInfo ContextOutputDirectory { get; set; }
	}
}