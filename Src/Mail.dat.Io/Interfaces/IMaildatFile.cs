namespace Mail.dat.Io
{
	public interface IMaildatFile
	{
		bool Exists { get; }
		string FilePath { get; }
		bool IsZipped { get; }
		string HeaderFilePath { get; }
		string GetFile(string extension);
		string UnzippedDirectory { get; }
		Task<bool> Unzip(string targetDirectory);
		Task<bool> Zip(string targetFilePath);
	}
}
