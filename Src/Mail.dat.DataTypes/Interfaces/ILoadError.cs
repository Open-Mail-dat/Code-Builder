namespace Mail.dat
{
	public interface ILoadError
	{
		MaildatFieldAttribute Attribute { get; set; }
		string Value { get; set; }
		string ErrorMessage { get; set; }
		// $"Could not convert from string to '{p.Property.DeclaringType.Name}'.",
	}
}
