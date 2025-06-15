namespace Mail.dat.BuildCommand
{
	public static class DirectoryDecorator
	{
		public static void DeleteAllFiles(this DirectoryInfo directory, string pattern)
		{
			directory.Create();
			FileInfo[] files = directory.GetFiles(pattern, SearchOption.TopDirectoryOnly);

			foreach (FileInfo file in files)
			{
				file.Delete();
			}
		}
	}
}
