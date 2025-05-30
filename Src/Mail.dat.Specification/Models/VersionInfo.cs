using Newtonsoft.Json;

namespace Mail.dat.Specification
{
	public class VersionInfo
	{
		[JsonProperty("major")]
		public string Major { get; set; }

		[JsonProperty("revision")]
		public string Revision { get; set; }
	}
}
