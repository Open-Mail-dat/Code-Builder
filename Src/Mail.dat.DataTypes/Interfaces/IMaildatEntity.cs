using Diamond.Core.Repository;

namespace Mail.dat
{
	public interface IMaildatEntity : IEntity<int>
	{
		int FileLineNumber { get; set; }

		string CreatedBy { get; set; }
		DateTimeOffset CreatedDateTime { get; set; }
		string ModifiedBy { get; set; }
		DateTimeOffset ModifiedDateTime { get; set; }

		Task<ILoadError[]> ImportDataAsync(int lineNumber, ReadOnlySpan<byte> line);
		Task<string> ExportDataAsync();
	}
}