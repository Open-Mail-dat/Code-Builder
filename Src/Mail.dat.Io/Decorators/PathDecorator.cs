namespace Mail.dat.Io
{
	public static class PathDecorator
	{
		public static string NormalizePath(this string path)
		{
			return path?.Replace('\\', '/');
		}
	}
}
