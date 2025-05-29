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

		[Column("CreatedDateTime", Order = 9996)]
		public DateTimeOffset CreatedDateTime { get; set; }

		[Column("CreatedBy", Order = 9997)]
		public string CreatedBy { get; set; }

		[Column("ModifiedDateTime", Order = 9998)]
		public DateTimeOffset ModifiedDateTime { get; set; }

		[Column("ModifiedBy", Order = 9999)]
		public string ModifiedBy { get; set; }

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
