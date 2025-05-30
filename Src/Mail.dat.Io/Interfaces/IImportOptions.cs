using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public interface IImportOptions
	{
		IMaildatFile SourceFile { get; set; }
		string TemporaryDirectory { get; set; }
		string TargetFile { get; set; }
		bool SkipPbc { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
		bool FavorMemoryOverPerformance { get; set; }
		int MaxRecordsInMemory { get; set; }
	}
}
