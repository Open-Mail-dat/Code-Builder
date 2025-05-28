using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public interface IExportOptions
	{
		IMaildatFile File { get; set; }
		string DatabasePath { get; set; }
		Encoding Encoding { get; set; }
		string LineTerminator { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
	}
}
