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

		public virtual Task<ILoadError[]> ImportDataAsync(int lineNumber, ReadOnlySpan<byte> line)
		{
			return this.OnImportDataAsync(lineNumber, line);
		}

		public virtual Task<string> ExportDataAsync()
		{
			return this.OnExportDataAsync();
		}

		protected virtual Task<ILoadError[]> OnImportDataAsync(int lineNumber, ReadOnlySpan<byte> line)
		{
			return Task.FromResult<ILoadError[]>([]);
		}

		protected virtual Task<string> OnExportDataAsync()
		{
			return Task.FromResult<string>(null);
		}
	}
}
