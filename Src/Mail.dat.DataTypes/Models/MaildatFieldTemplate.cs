using System.ComponentModel.DataAnnotations.Schema;
using Diamond.Core.Repository;

namespace Mail.dat
{
	public abstract class MaildatFieldTemplate : Entity<int>
	{
		[Column("CreatedDateTime", Order = 9996)]
		public DateTimeOffset CreatedDateTime { get; set; }

		[Column("CreatedBy", Order = 9997)]
		public string CreatedBy { get; set; }

		[Column("ModifiedDateTime", Order = 9998)]
		public DateTimeOffset ModifiedDateTime { get; set; }

		[Column("ModifiedBy", Order = 9999)]
		public string ModifiedBy { get; set; }
	}
}
