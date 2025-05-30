using Newtonsoft.Json;

namespace Mail.dat.Json.Specification
{
	public class SpecificationFile
	{
		[JsonProperty("version")]
		public VersionInfo Version { get; set; }

		[JsonProperty("files")]
		public List<FileDefinition> Files { get; set; }
	}
}
