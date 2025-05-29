using System.Reflection;
using System.Runtime.Serialization;
using Mail.dat.Io.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	public class MaildatExport : IMaildatExport
	{
		public ProgressAsyncDelegate ProgressUpdate { get; set; }

		private MaildatExport()
		{
		}

		public static IMaildatExport Create()
		{
			return new MaildatExport();
		}

		public static IMaildatExport Create(ProgressAsyncDelegate progressAction)
		{
			return new MaildatExport()
			{
				ProgressUpdate = progressAction
			};
		}

		public async Task<bool> ExportAsync(IExportOptions options)
		{
			bool returnValue = true;

			if (File.Exists(options.DatabasePath))
			{
				try
				{
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
					// Get a local onl context.
					//
					using MaildatContext localContext = new(new NullLogger<MaildatContext>(), contextOption);

					//
					// Get all of the model entities.
					//
					IEnumerable<IEntityType> entities = localContext.Model.GetEntityTypes();

					//
					// Forward the progress events.
					//
					FileExporter fileExporter = new()
					{
						ProgressUpdateAsync = async (item) =>
						{
							await this.FireProgressUpdateAsync(item);
						}
					};

					//
					// Get the ExportAsync method from the FileExporter class.
					//
					MethodInfo exportMethod = typeof(FileExporter).GetMethod("ExportAsync");

					//
					// Get all of the properties of the context.
					//
					PropertyInfo[] properties = localContext.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
												.Where(t => t.GetCustomAttribute<MaildatExportAttribute>() != null)
												.ToArray();

					//
					// Iterate through each property in the context.
					//
					// new ParallelOptions() { MaxDegreeOfParallelism = 1 },
					Parallel.ForEach(properties, (property) =>
					{
						//
						// Get the property type.
						//
						Type propertyType = property.PropertyType;

						//
						// If the property is a DbSet<T>, we can get the items from it.
						//
						if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
						{
							//
							// Get the entity type from the DbSet<T>.
							//
							Type entityType = propertyType.GetGenericArguments()[0];

							//
							// Get the items from the DbSet<T> using reflection.
							//
							MethodInfo setMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
							MethodInfo genericSetMethod = setMethod.MakeGenericMethod(entityType);

							//
							// Create a new context for each file so that we can run in parallel.
							//
							//
							using MaildatContext exportContext = new(new NullLogger<MaildatContext>(), contextOption);
							object dbSetObject = genericSetMethod.Invoke(exportContext, null);

							//
							// Get a queryable for the DB Set.
							//
							IQueryable queryable = dbSetObject as IQueryable;

							//
							// Get the type and create the genic method for ImportAsync.
							//
							MethodInfo genericMethod = exportMethod.MakeGenericMethod(entityType);

							//
							// Invoke the generic method with the fileExporter instance and the options.
							//
							genericMethod.Invoke(fileExporter, [options, entityType, queryable.Cast<IMaildatEntity>().AsQueryable(), options.CancellationToken]);
						}
					});

					//
					// Check if the output should be zipped.
					//
					if (Path.GetExtension(options.File.FilePath).ToLower() == ".zip")
					{
						//
						// Zip the Mail.dat.
						//

					}
				}
				finally
				{
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemAction = ProgressMessageType.Completed, Message = "Export completed." });
				}
			}
			else
			{
				throw new FileNotFoundException(options.DatabasePath);
			}

			return returnValue;
		}

		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdate?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}