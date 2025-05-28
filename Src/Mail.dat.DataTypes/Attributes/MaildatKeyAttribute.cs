namespace Mail.dat
{
    /// <summary>
    /// Attribute to specify the field is a Mail.dat Key.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaildatKeyAttribute : Attribute
    {
        public MaildatKeyAttribute()
        {
        }
	}
}
