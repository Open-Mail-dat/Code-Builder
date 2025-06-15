namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify that this property has a list of values.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class MaildatFieldLinkAttribute : Attribute
	{
		public MaildatFieldLinkAttribute()
		{
		}

		public string File { get; set; }
		public string FieldCode { get; set; }
	}
}
