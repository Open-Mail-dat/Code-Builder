using Newtonsoft.Json;

namespace Mail.dat.Specification
{
	public class FileDefinition
	{
		[JsonIgnore]
		public int Ordinal { get; set; }

		[JsonProperty("file")]
		public string File { get; set; }

		[JsonProperty("fileExtension")]
		public string FileExtension { get; set; }

		[JsonProperty("fileSummary")]
		public string FileSummary { get; set; }

		[JsonProperty("fileDescription")]
		public string FileDescription { get; set; }

		[JsonProperty("recordDefinitions")]
		public List<RecordDefinition> RecordDefinitions { get; set; }
	}
}
