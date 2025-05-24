namespace Mail.dat.Io.Models
{
	internal class ImportMessage : IImportMessage
	{
		public ImportMessageType Type { get; set; }
		public string Message { get; set; }
		public string Name { get; set; }
		public string File { get; set; }
		public int LineNumber { get; set; }
		public int LineCount { get; set; }
	}
}
