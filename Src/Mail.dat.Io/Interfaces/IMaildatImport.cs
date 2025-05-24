namespace Mail.dat.Io
{
	public interface IMaildatImport
	{
		Task<(bool, MaildatContext)> ImportAsync(IImportOptions options);
	}
}
