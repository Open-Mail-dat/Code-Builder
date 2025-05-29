using System.Reflection;
using Mail.dat.Io.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	public class MaildatImport : IMaildatImport
	{
		public ProgressAsyncDelegate ProgressUpdate { get; set; }

		private MaildatImport()
		{
		}

		public static IMaildatImport Create()
		{
			return new MaildatImport();
		}

		public static IMaildatImport Create(ProgressAsyncDelegate progressAction)
		{
			return new MaildatImport()
			{
				ProgressUpdate = progressAction
			};
		}

		public async Task<(bool, MaildatContext)> ImportAsync(IImportOptions options)
		{
			(bool returnValue, MaildatContext context) = (true, null);

			try
			{
				//
				// Unzip the files.
				//
				if (options.File.IsZipped)
				{
					if (!await options.File.Unzip(options.TargetDirectory))
					{
						throw new Exception($"The file '{options.File.FilePath}' could not be unzipped.");
					}
				}

				//
				// Generate a connection string using the database
				// path that was provided.
				//
				string connectionString = $"Data Source={options.DatabasePath}";

				//
				// Create the DB Context options.
				//
				DbContextOptions<MaildatContext> contextOption = new DbContextOptionsBuilder<MaildatContext>()
					.UseSqlite(connectionString)
					.Options;

				//
				// Create the DB Context.
				//
				context = new MaildatContext(new NullLogger<MaildatContext>(), contextOption);

				//
				// Help to improve performace.
				//
				context.ChangeTracker.AutoDetectChangesEnabled = false;
				context.Database.ExecuteSqlRaw("PRAGMA synchronous = OFF;");
				context.Database.ExecuteSqlRaw("PRAGMA journal_mode = MEMORY;");
				context.Database.ExecuteSqlRaw("PRAGMA temp_store = MEMORY;");

				//
				// Delete the database if it exists and create a new one.
				//
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemAction = ProgressMessageType.Message, Message = "Creating the database." });
				await context.EnsureDeletedAsync();
				await context.EnsureCreatedAsync();
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemAction = ProgressMessageType.Completed, Message = "Database Created." });

				//
				// Get all of the model entities.
				//
				IEnumerable<IEntityType> entities = context.Model.GetEntityTypes()
													.Where(t => t.ClrType.GetAttribute<MaildatImportAttribute>() != null)
													.OrderBy(t => t.ClrType.GetAttribute<MaildatImportAttribute>().Order);

				//
				// Forward the progress events.
				//
				FileImporter fileImporter = new()
				{
					ProgressUpdateAsync = async (item) =>
					{
						await this.FireProgressUpdateAsync(item);
					}
				};

				//
				// Get the ImportAsync method from the FileImporter class.
				//
				MethodInfo method = typeof(FileImporter).GetMethod("ImportAsync");

				//
				// Using a transaction boosts performance.
				//
				using IDbContextTransaction transaction = context.Database.BeginTransaction();

				try
				{
					//
					// Use Parallel.ForEach to import each entity type.
					//
					// new ParallelOptions() { MaxDegreeOfParallelism = 1 },
					Parallel.ForEach(entities, (entityType) =>
					{
						//
						// Check if the cancellation token has been requested.
						//
						if (!options.CancellationToken.IsCancellationRequested)
						{
							//
							// Get the type and create the genic method for ImportAsync.
							//
							Type clrType = entityType.ClrType;
							MethodInfo genericMethod = method.MakeGenericMethod(clrType);

							//
							// Invoke the generic method with the fileImporter instance and the options.
							//
							genericMethod.Invoke(fileImporter, [options, context, options.CancellationToken]);
						}
					});
				}
				finally
				{
					//
					// Commit the transaction to save all changes to the database.
					//
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemAction = ProgressMessageType.Message, Message = "Committing transactions to the database." });
					transaction.Commit();
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemAction = ProgressMessageType.Completed, Message = "Database update complete." });

				}
			}
			finally
			{
				//
				// Fire a progress update indicating that the import is completed.
				//
				await this.FireProgressUpdateAsync(new ProgressMessage() {ItemAction = ProgressMessageType.Completed, Message = "Import completed." });
			}

			return (returnValue, context);
		}

		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdate?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}