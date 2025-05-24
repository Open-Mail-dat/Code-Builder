namespace Mail.dat
{
	public class LoadError : ILoadError
	{
		public MaildatFieldAttribute Attribute { get; set; }
		public string Value { get; set; }
		public string ErrorMessage { get; set; }
	}
}
