namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify that this property represents a Mail.dat import file.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public class MaildatImportAttribute : Attribute
	{
		public MaildatImportAttribute()
		{
		}

		/// <summary>
		/// The Mail.dat version this code was generated from.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int Order { get; set; }
	}
}
