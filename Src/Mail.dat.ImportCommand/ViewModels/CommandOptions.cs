using System.ComponentModel.DataAnnotations;

namespace Mail.dat.ImportCommand
{
	internal class CommandOptions
	{
		[Required]
		[Display(Order = 1, Name = "source-file-path", ShortName = "s", Description = "Specifies the full path to the Mail.dat file to import. The path should point to a ZIP file to the HDR file.")]
		public FileInfo SourceFilePath { get; set; }

		[Required]
		[Display(Order = 2, Name = "target-file-path", ShortName = "t", Description = "Specifies the full target file path for the Sqlite database.")]
		public FileInfo TargetFilePath { get; set; }

		[Display(Order = 4, Name = "skip-pbc", ShortName = "p", Description = "Specifies whether or not to skip the PBC file on import.")]
		public bool SkipPbc { get; set; }
	}
}
