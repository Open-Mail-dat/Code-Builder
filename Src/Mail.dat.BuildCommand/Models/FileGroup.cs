using System.Diagnostics;

namespace Mail.dat.BuildCommand
{
	[DebuggerDisplay("Extension = {Extension}, Ordinal = {Ordinal}")]
	public class FileGroup
	{
		public int Ordinal { get; set; }
		public string FileExtension { get; set; }
		public IEnumerable<FileDefinitionList> Items { get; set; }
	}
}