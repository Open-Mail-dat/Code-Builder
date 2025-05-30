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

		[Display(Order = 3, Name = "skip-pbc", ShortName = "p", Description = "Specifies whether or not to skip the PBC file on import. The default is false.")]
		public bool SkipPbc { get; set; } = false;

		[Display(Order = 4, Name = "favor-memory-over-performance", ShortName = "f", Description = "Uses less memory at the cost of performance. When true, the import will take about 40% lobger but use much less memory. The default is false.")]
		public bool FavorMemoryOverPerformance { get; set; } = false;

		[Display(Order = 5, Name = "max-records-in-memory", ShortName = "m", Description = "When favor-memory-over-performance = true, sets the maxmimum number of records held in memory before writing to the databae and clearing memory. Smaller numbers uses less memory but result in slower performance. Higher numbers will use more memory but increase performance. The default is 10,000.")]
		public int MaxRecordsInMemory { get; set; } = 10_000;
	}
}