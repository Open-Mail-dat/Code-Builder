using System.ComponentModel.DataAnnotations;

namespace Mail.dat.BuildCommand
{
	internal class CommandOptions
	{
		[Required]
		[Display(Order = 1, Name = "specification-files", ShortName = "s", Description = "A list of specification comma delimited files each containing the full or relative path to the Mail.dat JSON specification file.")]
		public string SpecificationFiles { get; set; }
		
		[Required]
		[Display(Order = 2, Name = "output-directory", ShortName = "c", Description = "The output directory where files are written.")]
		public DirectoryInfo OutputDirectory { get; set; }
	}
}