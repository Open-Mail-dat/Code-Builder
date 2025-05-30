using Spectre.Console;
using Spectre.Console.Rendering;

namespace Mail.dat.ExportCommand
{
	public class LineCountColumn : ProgressColumn
	{
		public override IRenderable Render(RenderOptions options, ProgressTask task, TimeSpan deltaTime)
		{
			if (task.Value == 0)
			{
				return new Markup("");
			}
			else
			{
				return new Markup($"([white]{task.Value:#,###}[/] of [white]{task.MaxValue:#,###}[/])").Overflow(Overflow.Ellipsis).Justify(Justify.Left);
			}
		}
	}
}