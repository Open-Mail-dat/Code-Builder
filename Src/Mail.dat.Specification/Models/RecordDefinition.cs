using Newtonsoft.Json;

namespace Mail.dat.Specification
{
	public class RecordDefinition
	{
		[JsonProperty("fieldCode")]
		public string FieldCode { get; set; }

		[JsonProperty("fieldName")]
		public string FieldName { get; set; }

		[JsonProperty("start")]
		public int Start { get; set; }

		[JsonProperty("length")]
		public int Length { get; set; }

		[JsonProperty("required")]
		public bool Required { get; set; }

		[JsonProperty("key")]
		public bool Key { get; set; }

		[JsonProperty("dataType")]
		public string DataType { get; set; }

		[JsonProperty("description")]
		public List<string> Description { get; set; }

		[JsonProperty("data")]
		public FieldData Data { get; set; }

		[JsonProperty("default")]
		public string Default { get; set; }
	}
}
