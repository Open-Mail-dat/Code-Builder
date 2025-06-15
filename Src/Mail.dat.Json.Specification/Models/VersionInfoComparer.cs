namespace Mail.dat.Json.Specification
{
	public class VersionInfoComparer : IComparer<VersionInfo>
	{
		public int Compare(VersionInfo x, VersionInfo y)
		{
			(int xMajor, int xMinor) = ParseMajor(x?.Major);
			(int yMajor, int yMinor) = ParseMajor(y?.Major);

			int majorCompare = xMajor.CompareTo(yMajor);
			
			if (majorCompare != 0)
			{
				return majorCompare;
			}

			int minorCompare = xMinor.CompareTo(yMinor);
			
			if (minorCompare != 0)
			{
				return minorCompare;
			}

			// Optional: add revision comparison if needed
			return string.Compare(x?.Revision, y?.Revision, StringComparison.OrdinalIgnoreCase);
		}

		private static (int Major, int Minor) ParseMajor(string version)
		{
			if (string.IsNullOrWhiteSpace(version))
			{
				return (0, 0);
			}

			string[] parts = version.Split('-');
			
			if (parts.Length == 2 &&
				int.TryParse(parts[0], out int major) &&
				int.TryParse(parts[1], out int minor))
			{
				return (major, minor);
			}

			return (0, 0);
		}
	}
}
