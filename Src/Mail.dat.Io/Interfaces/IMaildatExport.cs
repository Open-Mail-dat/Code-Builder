namespace Mail.dat.Io
{
	public interface IMaildatExport
	{
		Task<bool> ExportAsync(IExportOptions options);
	}
}
