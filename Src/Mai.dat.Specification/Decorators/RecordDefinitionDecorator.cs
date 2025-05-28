namespace Mai.dat.Specification
{
	public static class RecordDefinitionDecorator
	{
		public static int TotalLineLength(this IEnumerable<RecordDefinition> items)
		{
			return items.Sum(t => t.Length);
		}
	}
}
