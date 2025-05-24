using System.Reflection;
using Mail.dat.Io.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	public delegate Task ProgressUpdateAsyncDelegate(IImportMessage message);

	public class MaildatImport : IMaildatImport
	{
		public ProgressUpdateAsyncDelegate ProgressUpdate { get; set; }

		private MaildatImport()
		{
		}

		public static IMaildatImport Create()
		{
			return new MaildatImport();
		}

		public static IMaildatImport Create(ProgressUpdateAsyncDelegate progressUpdate)
		{
			return new MaildatImport()
			{
				ProgressUpdate = progressUpdate
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
				// Get all of the model entities.
				//
				IEnumerable<IEntityType> entities = context.Model.GetEntityTypes();

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

				MethodInfo method = typeof(FileImporter).GetMethod(nameof(ImportAsync));

				Parallel.ForEach(context.Model.GetEntityTypes(), (entityType) =>
				{
					if (!options.CancellationToken.IsCancellationRequested)
					{
						Type clrType = entityType.ClrType;
						MethodInfo genericMethod = method.MakeGenericMethod(clrType);
						genericMethod.Invoke(fileImporter, [options, context, options.CancellationToken]);
					}
				});

				if (!options.CancellationToken.IsCancellationRequested)
				{
					//
					// Delete the database if it exists and create a new one.
					//
					await this.FireProgressUpdateAsync(new ImportMessage() { Type = ImportMessageType.Message, Message = "Creating the database." });
					await context.EnsureDeletedAsync();
					await context.EnsureCreatedAsync();

					//
					// Save the changes to the database.
					//
					await this.FireProgressUpdateAsync(new ImportMessage() { Type = ImportMessageType.Message, Message = "Updating the database." });

					lock (context)
					{
						context.SaveChanges();
					}
				}
			}
			finally
			{
				await this.FireProgressUpdateAsync(new ImportMessage() { Type = ImportMessageType.Completed, Message = "Import completed." });
			}

			return (returnValue, context);
		}

		protected Task FireProgressUpdateAsync(IImportMessage message)
		{
			this.ProgressUpdate?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}