using Spectre.Console;
using Spectre.Console.Rendering;

namespace Test
{
	public class LineCountColumn : ProgressColumn
	{
		public override IRenderable Render(RenderOptions options, ProgressTask task, TimeSpan deltaTime)
		{
			return new Markup($"([white]{task.Value:#,###}[/] of [white]{task.MaxValue:#,###}[/])").Overflow(Overflow.Ellipsis).Justify(Justify.Left);
		}
	}
}