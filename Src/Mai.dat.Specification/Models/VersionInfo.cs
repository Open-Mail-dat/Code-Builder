using Newtonsoft.Json;

namespace Mai.dat.Specification
{
	public class VersionInfo
	{
		[JsonProperty("major")]
		public string Major { get; set; }

		[JsonProperty("revision")]
		public string Revision { get; set; }
	}
}
