using Humanizer;
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{
	public static class RecordDefinitionDecorator
	{
		public static string Description(this RecordDefinition recordDefinition)
		{
			return string.Join(" ", recordDefinition.Description.Select(t => t.Sanitize().Transform(To.SentenceCase))).EndSentence();
		}
	}
}
