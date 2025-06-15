using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public class ExportOptions : IExportOptions
	{
		public string SourceFile { get; set; }
		public string TaregtVersion { get; set; }
		public IMaildatFile TargetFile { get; set; }
		public Encoding Encoding { get; set; } = Encoding.UTF8;
		public string LineTerminator { get; set; } = Environment.NewLine;
		public ILogger<IImportOptions> Logger { get; set; }
		public CancellationToken CancellationToken { get; set; }
	}
}
