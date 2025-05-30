using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public interface IExportOptions
	{
		IMaildatFile TargetFile { get; set; }
		string SourceFile { get; set; }
		Encoding Encoding { get; set; }
		string LineTerminator { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
	}
}
