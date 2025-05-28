using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public class ExportOptions : IExportOptions
	{
		public IMaildatFile File { get; set; }
		public string DatabasePath { get; set; }
		public Encoding Encoding { get; set; } = Encoding.UTF8;
		public string LineTerminator { get; set; } = Environment.NewLine;
		public ILogger<IImportOptions> Logger { get; set; }
		public CancellationToken CancellationToken { get; set; }
	}
}
