namespace Mail.dat
{
	/// <summary>
	/// Attribute to specify that this property has a list of values.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class MaildatValuesAttribute : Attribute
	{
		public MaildatValuesAttribute(Type type)
		{
			this.Type = type;
		}

		public Type Type { get; set; }
	}
}
