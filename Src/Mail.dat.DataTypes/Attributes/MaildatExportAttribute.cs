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

		public int Order { get; set; }
	}
}
