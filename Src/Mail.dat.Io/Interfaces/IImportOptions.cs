using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public interface IImportOptions
	{
		IMaildatFile SourceFile { get; set; }
		string TemporaryDirectory { get; set; }
		string TargetFile { get; set; }
		bool SkipPbcFile { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
	}
}
