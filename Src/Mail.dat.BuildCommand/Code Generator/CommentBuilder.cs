namespace Mail.dat.BuildCommand
{
	public class CommentBuilder : ICodeBuilder<CommentBuilder>
	{
		public List<string> Lines { get; internal set; }
		public int MaximumLineLength { get; internal set; } = 100;

		public static CommentBuilder Create(params List<string> lines)
		{
			return new CommentBuilder() { Lines = lines };
		}

		public CommentBuilder SetMaximumLineLength(int maximumLineLength)
		{
			this.MaximumLineLength = maximumLineLength;
			return this;
		}

		public CommentBuilder AddComment(string comment)
		{
			this.Lines.Add(comment);
			return this;
		}

		public CommentBuilder AddComments(params List<string> lines)
		{
			this.Lines.AddRange(lines);
			return this;
		}

		public CommentBuilder Build(string filePath, int indentLevel = 0)
		{
			foreach (string line in this.Lines)
			{
				//IEnumerable<string> subLines = comment.Split(this.MaximumLineLength);

				//foreach (string subLine in subLines)
				//{
					File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}// {line.Trim()}"]);
				//}
			}

			return this;
		}
	}
}
