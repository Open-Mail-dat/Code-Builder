namespace Mail.dat.CodeBuilder
{
	public interface ICodeBuilder<T>
	{
		T Build(string filePath, int indentLevel = 0);
	}
}
