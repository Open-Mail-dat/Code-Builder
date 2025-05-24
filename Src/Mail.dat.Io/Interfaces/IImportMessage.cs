namespace Mail.dat.Io
{
	public enum ImportMessageType
	{
		Progress,
		Message,
		Completed
	}

	public interface IImportMessage
	{
		ImportMessageType Type { get; set; }
		string Message { get; set; }
		string Name { get; set; }
		string File { get; set; }
		int LineNumber { get; set; }
		int LineCount { get; set; }
	}
}
