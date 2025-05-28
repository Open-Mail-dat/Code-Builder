namespace Mail.dat.Io
{
	public enum ProgressMessageType
	{
		ImportExport,
		Message,
		Completed
	}

	public interface IProgressMessage
	{
		ProgressMessageType ItemAction { get; set; }
		string ItemName { get; set; }
		string ItemSource { get; set; }
		int ItemIndex { get; set; }
		int ItemCount { get; set; }
		string Message { get; set; }
	}
}