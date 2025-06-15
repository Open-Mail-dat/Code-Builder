namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify the characteristics of a Maildat fle.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
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

		/// <summary>
		/// The length of the line not including any line terminators.
		/// </summary>
		public int LineLength { get; set; }

		/// <summary>
		/// The charcater that marks the end of a line in the file.
		/// </summary>
		public string ClosingCharacter { get; set; }
	}
}
