using Newtonsoft.Json;

namespace Mail.dat.Json.Specification
{
	public class SpecificationFile
	{
		[JsonProperty("version")]
		public VersionInfo Version { get; set; }

		[JsonProperty("files")]
		private List<FileDefinition> _files = [];
		public List<FileDefinition> Files
		{
			get
			{
				return _files.OrderBy(t=>t.FileExtension).ToList();
			}
			set
			{
				_files = value;
			}
		}
	}
}
