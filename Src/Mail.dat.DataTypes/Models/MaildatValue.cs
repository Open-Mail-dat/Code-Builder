using System.ComponentModel.DataAnnotations;

namespace Mail.dat.Abstractions
{
	public class MaildatValue
	{
		[Key]
		public string Version { get; set; }

		[Key]
		public string Key { get; set; }

		public string FileExtension { get; set; }
		public string Description { get; set; }
		public string FieldCode { get; set; }
		public string FieldName { get; set; }
	}
}
