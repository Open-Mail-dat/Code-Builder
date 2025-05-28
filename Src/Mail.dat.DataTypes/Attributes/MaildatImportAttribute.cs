namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify that this property represents a Mail.dat import file.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class MaildatImportAttribute : Attribute
	{
		public MaildatImportAttribute()
		{
		}

		public int Order { get; set; }
	}
}
