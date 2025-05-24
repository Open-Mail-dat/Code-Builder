using Diamond.Core.Repository;

namespace Mail.dat
{
	public interface IMaildatEntity : IEntity<int>
	{
		string CreatedBy { get; set; }
		DateTimeOffset CreatedDateTime { get; set; }
		string ModifiedBy { get; set; }
		DateTimeOffset ModifiedDateTime { get; set; }

		ILoadError[] LoadData(int lineNumber, byte[] line);
	}
}