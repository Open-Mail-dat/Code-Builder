namespace Mail.dat
{
    /// <summary>
    /// Attribute to specify the number of decimal places for a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaildatKeyAttribute : Attribute
    {
        public MaildatKeyAttribute()
        {
        }
	}
}
