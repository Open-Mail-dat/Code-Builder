using System.ComponentModel;

namespace Mail.dat
{
	public class ConverterContext : ITypeDescriptorContext
	{
		public ConverterContext(object instance, MaildatFieldAttribute attribute)
		{
			this.Instance = instance;
			this.PropertyDescriptor = null;
			this.MaildatFieldAttribute = attribute;
		}

		public object Instance { get; protected set; }
		public PropertyDescriptor PropertyDescriptor { get; protected set; }
		public IContainer Container => null;
		public MaildatFieldAttribute MaildatFieldAttribute { get; protected set; }

		public object GetService(Type serviceType) => null;
		public void OnComponentChanged() { }
		public bool OnComponentChanging() => true;
	}
}
