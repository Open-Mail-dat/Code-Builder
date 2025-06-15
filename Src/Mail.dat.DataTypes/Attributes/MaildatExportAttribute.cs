namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify that this property represents a Mail.dat export file.
	/// </summary>
	[AttributeUsage(AttributeTargets.All)]
    public class MaildatExportAttribute : Attribute
    {
        public MaildatExportAttribute()
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
