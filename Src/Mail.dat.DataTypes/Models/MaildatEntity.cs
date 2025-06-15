using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Diamond.Core.Repository;

namespace Mail.dat
{
	public abstract class MaildatEntity : Entity, IMaildatEntity
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Column("FileLineNumber", Order = 1)]
		public int FileLineNumber { get; set; }

		public virtual Task<ILoadError[]> ImportDataAsync(string version,int lineNumber, ReadOnlySpan<byte> line)
		{
			return this.OnImportDataAsync(version, lineNumber, line);
		}

		public virtual Task<string> ExportDataAsync(string version)
		{
			return this.OnExportDataAsync(version);
		}

		protected virtual Task<ILoadError[]> OnImportDataAsync(string version, int lineNumber, ReadOnlySpan<byte> line)
		{
			return Task.FromResult<ILoadError[]>([]);
		}

		protected virtual Task<string> OnExportDataAsync(string version)
		{
			return Task.FromResult<string>(null);
		}
	}
}
