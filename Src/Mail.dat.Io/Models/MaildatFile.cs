using System.IO.Compression;

namespace Mail.dat.Io
{
	public class MaildatFile : IMaildatFile
	{
		public string FilePath { get; internal set; }
		public string UnzippedDirectory { get; internal set; }
		public bool Exists => File.Exists(this.FilePath) || Directory.Exists(this.FilePath);

		public bool IsZipped
		{
			get
			{
				bool returnValue = false;

				if (Path.GetExtension(this.FilePath).ToLower().Equals(".zip"))
				{
					if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
					{
						DirectoryInfo dir = new(this.UnzippedDirectory);
						returnValue = !dir.GetFiles().Where(t => t.Extension == ".hdr").Any();
					}
					else
					{
						returnValue = true;
					}
				}
				else
				{
					returnValue = false;
				}

				return returnValue;
			}
		}

		public string HeaderFilePath
		{
			get
			{
				string extension = typeof(Hdr).GetAttribute<MaildatFileAttribute>().Extension;
				return this.GetFile(extension);
			}
		}

		public string GetFile(string extension)
		{
			string returnValue = null;

			if (!Path.GetExtension(this.FilePath).ToLower().Equals(".zip"))
			{
				if (!string.IsNullOrWhiteSpace(this.FilePath))
				{
					DirectoryInfo dir = new(this.FilePath);

					if (dir.Exists)
					{
						returnValue = dir.GetFiles().Where(t => t.Extension.Equals($".{extension}", StringComparison.CurrentCultureIgnoreCase)).Select(t => t.FullName).SingleOrDefault();
					}
				}
			}
			else
			{
				if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
				{
					DirectoryInfo dir = new(this.UnzippedDirectory);

					if (dir.Exists)
					{
						returnValue = dir.GetFiles().Where(t => t.Extension.Equals($".{extension}", StringComparison.CurrentCultureIgnoreCase)).Select(t => t.FullName).SingleOrDefault();
					}
				}
			}

			return returnValue.NormalizePath();
		}

		public Task<bool> Unzip(string targetDirectory)
		{
			bool returnValue = false;

			//
			// Save the unzip path.
			//
			this.UnzippedDirectory = targetDirectory;

			if (!string.IsNullOrWhiteSpace(this.UnzippedDirectory))
			{
				DirectoryInfo dir = new(this.UnzippedDirectory);
				dir.Create();
				ZipFile.ExtractToDirectory(this.FilePath, targetDirectory, true);
				returnValue = true;
			}

			return Task.FromResult(returnValue);
		}

		public Task<bool> Zip(string targetFilePath)
		{
			bool returnValue = false;


			return Task.FromResult(returnValue);
		}

		public static IMaildatFile Create(string filePath)
		{
			return new MaildatFile() { FilePath = filePath.NormalizePath() };
		}
	}
}
