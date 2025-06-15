using Diamond.Core.Repository;

namespace Mail.dat
{
	public interface IMaildatEntity : IEntity<int>
	{
		int FileLineNumber { get; set; }

		Task<ILoadError[]> ImportDataAsync(string version, int lineNumber, ReadOnlySpan<byte> line);
		Task<string> ExportDataAsync(string version);
	}
}