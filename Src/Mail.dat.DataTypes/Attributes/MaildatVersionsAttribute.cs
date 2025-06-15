namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify the Mail.dat version supporting the given object.
	/// </summary>
	[AttributeUsage(AttributeTargets.All)]
	public class MaildatVersionsAttribute : Attribute
	{
		public MaildatVersionsAttribute(params string[] supportedVersions)
		{
			this.SupportedVersions = supportedVersions;
		}

		public IEnumerable<string> SupportedVersions { get; set; }
	}
}
