using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public interface IImportOptions
	{
		IMaildatFile File { get; set; }
		string TargetDirectory { get; set; }
		string DatabasePath { get; set; }
		bool SkipPbcFile { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
	}
}
