using System.ComponentModel.DataAnnotations;

namespace Mail.dat.ExportCommand
{
	internal class CommandOptions
	{
		[Required]
		[Display(Order = 1, Name = "source-file-path", ShortName = "s", Description = "Specifies the full target file path for the Sqlite database.")]
		public FileInfo SourceFilePath { get; set; }

		[Required]
		[Display(Order = 2, Name = "target-file-path", ShortName = "t", Description = "Specifies the full path to the Mail.dat file to Export. The path should point to a ZIP file or the HDR file.")]
		public FileInfo TargetFilePath { get; set; }
	}
}
