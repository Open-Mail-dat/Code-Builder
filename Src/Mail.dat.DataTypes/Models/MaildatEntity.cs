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

		public virtual ILoadError[] LoadData(int lineNumber, byte[] line)
		{
			return this.OnLoadData(lineNumber, line);
		}

		protected virtual ILoadError[] OnLoadData(int lineNumber, byte[] line)
		{
			return [];
		}
	}
}
