namespace Mail.dat.Json.Specification
{
	public static class RecordDefinitionDecorator
	{
		public static int TotalLineLength(this IEnumerable<RecordDefinition> items)
		{
			return items.Sum(t => t.Length);
		}
	}
}
