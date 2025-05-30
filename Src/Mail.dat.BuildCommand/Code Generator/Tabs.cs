namespace Mail.dat.BuildCommand
{
	public class Tabs
	{
		public static string Create(int indentLevel = 1)
		{
			return new string('\t', indentLevel);
		}
	}
}
