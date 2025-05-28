using Newtonsoft.Json;

namespace Mai.dat.Specification
{
	public class FieldData
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("format")]
		public string Format { get; set; }

		[JsonProperty("precision")]
		public int? Precision { get; set; }

		[JsonProperty("references")]
		public List<string> References { get; set; } = [];

		[JsonProperty("values")]
		public Dictionary<string, string> Values { get; set; } = [];
	}
}
