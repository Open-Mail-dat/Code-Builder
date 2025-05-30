using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	public class ImportOptions : IImportOptions
	{
		public IMaildatFile SourceFile { get; set; }
		public string TargetFile { get; set; }
		public string TemporaryDirectory { get; set; }
		public CancellationToken CancellationToken { get; set; } = CancellationToken.None;
		public ILogger<IImportOptions> Logger { get; set; } = new NullLogger<IImportOptions>();
		public bool SkipPbcFile { get; set; } = false;
	}
}
