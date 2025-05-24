using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public enum SaveModeType
	{
		SaveAtEnd,
		SaveAfterEachFile
	}

	public interface IImportOptions
	{
		IMaildatFile File { get; set; }
		string TargetDirectory { get; set; }
		string DatabasePath { get; set; }
		bool SkipPbcFile { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
		SaveModeType SaveMode { get; set; }
	}
}
