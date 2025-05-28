namespace Mail.dat.Io.Models
{
	internal class ProgressMessage : IProgressMessage
	{
		public ProgressMessageType ItemAction { get; set; }
		public string Message { get; set; }
		public string ItemName { get; set; }
		public string ItemSource { get; set; }
		public int ItemIndex { get; set; }
		public int ItemCount { get; set; }
	}
}
