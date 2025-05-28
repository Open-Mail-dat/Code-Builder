namespace Mail.dat.CodeBuilder.Decorators
{
	public static class DirectoryDecorator
	{
		public static void DeleteAllFiles(this DirectoryInfo directory, string pattern)
		{
			FileInfo[] files = directory.GetFiles(pattern, SearchOption.TopDirectoryOnly);

			foreach (FileInfo file in files)
			{
				file.Delete();
			}
		}
	}
}
