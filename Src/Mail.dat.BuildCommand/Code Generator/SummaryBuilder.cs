namespace Mail.dat.BuildCommand
{
	public class SummaryBuilder : ICodeBuilder<SummaryBuilder>
	{
		public List<string> Lines { get; internal set; }
		public int MaximumLineLength { get; internal set; } = 100;

		public static SummaryBuilder Create(params List<string> lines)
		{
			return new SummaryBuilder() { Lines = lines };
		}

		public SummaryBuilder SetMaximumLineLength(int maximumLineLength)
		{
			this.MaximumLineLength = maximumLineLength;
			return this;
		}

		public SummaryBuilder Build(string filePath, int indentLevel = 0)
		{
			//
			// Write the summary.
			//
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}/// <summary>"]);

			foreach (string line in this.Lines)
			{
				IEnumerable<string> subLines = line.Split(this.MaximumLineLength);

				foreach (string subLine in subLines)
				{
					File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}/// {subLine.Trim()}"]);
				}
			}

			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}/// </summary>"]);
			return this;
		}
	}
}
