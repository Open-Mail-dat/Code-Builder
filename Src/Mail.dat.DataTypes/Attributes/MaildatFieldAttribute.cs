namespace Mail.dat
{
    /// <summary>
    /// Enumeration to specify the alignment of data in a field.
    /// </summary>
    public enum DataAlignment
    {
        /// <summary>
        /// Align data to the left.
        /// </summary>
        Left,
        /// <summary>
        /// Align data to the right.
        /// </summary>
        Right
    }

    /// <summary>
    /// Attribute to specify the number of decimal places for a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaildatFieldAttribute : Attribute
    {
        public MaildatFieldAttribute()
        {
        }

        /// <summary>
        /// The extension of the file this field is.
        /// </summary>
        public string Extension { get; set; }

		/// <summary>
		/// The unique identifier for the field.  The characters in front of the hyphen signify the file and the 
		/// characters after the hyphen uniquely identify the field in the file.
		/// </summary>
		public string FieldCode { get; set; }

		/// <summary>
		/// The human referencable name for the field.
		/// </summary>
		public string FieldName { get; set; }

		/// <summary>
		/// The 1 based position of the beginning of the field in the fixed width format.
		/// </summary>
		public int Start { get; set; }

		/// <summary>
		/// The number of characters the field utilizes in the fixed width format.
		/// </summary>
		public int Length { get; set; }

		/// <summary>
		/// True if the field must contain data; false if it can contain all spaces.
		/// </summary>
		public bool Required { get; set; } = false;

		/// <summary>
		/// True if the field must be unique amongst all records.
		/// </summary>
		public bool Key { get; set; } = false;

		/// <summary>
		/// Specifies whether the field is numeric only or alpha-numeric.  A word of caution is
		/// that this property is not to be used by software and may be deprecated in the future.
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// Specifies whether the field is numeric only or alpha-numeric.  A word of caution is
		/// that this property is not to be used by software and may be deprecated in the future.
		/// </summary>
		public string Default { get; set; }

		/// <summary>
		/// Information describing the field and its uses.
		/// </summary>
		public string Description { get; set; }

        /// <summary>
        /// The scalar data type.
        /// </summary>
        public string Type { get; set; }

		/// <summary>
		/// If a date or time format other than YYYYMMDD or HH:MM are needed, they must be added to this enum.
		/// </summary>
		public string Format { get; set; }

		/// <summary>
		/// The number of digits allowed after the decimal point. The precision property should only be 
		/// used if the value of type is decimal.
		/// </summary>
		public int Precision { get; set; } = 0;

		/// <summary>
		/// A list of fieldcodes that are related to this field.
		/// </summary>
		public string References { get; set; }
	}
}
