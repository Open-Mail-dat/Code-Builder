namespace Mail.dat
{
    /// <summary>
    /// Attribute to specify the number of decimal places for a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class MaildatFileAttribute : Attribute
    {
        public MaildatFileAttribute()
        {
        }

		/// <summary>
		/// The Mail.dat version this code was generated from.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// The Mail.dat revision this code was generated from.
		/// </summary>
		public string Revision { get; set; }

		/// <summary>
		/// The extension of the file.
		/// </summary>
		public string Extension { get; set; }

		/// <summary>
		/// The long name of the file..
		/// </summary>
		public string File { get; set; }

		/// <summary>
		/// The description of the file.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The summary of the file.
		/// </summary>
		public string Summary { get; set; }
	}
}
