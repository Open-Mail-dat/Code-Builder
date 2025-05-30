namespace Mail.dat.BuildCommand
{
	public interface ICodeBuilder<T>
	{
		T Build(string filePath, int indentLevel = 0);
	}
}
