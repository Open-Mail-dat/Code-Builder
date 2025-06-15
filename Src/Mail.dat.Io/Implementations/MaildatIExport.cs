//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE (GNU Lesser General Public License)
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.Reflection;
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

			if (File.Exists(options.SourceFile))
			{
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Export", ItemAction = ProgressMessageType.Start, Message = "Export" });

				try
				{
					//
					// Generate a connection string using the database
					// path that was provided.
					//
					string connectionString = $"Data Source={options.SourceFile}";

					//
					// Create the DB Context options.
					//
					DbContextOptions<MaildatContext> contextOption = new DbContextOptionsBuilder<MaildatContext>()
						.UseSqlite(connectionString)
						.Options;

					//
					// Get a local only context.
					//
					using MaildatContext localContext = new(new NullLogger<MaildatContext>(), contextOption);

					//
					// Get the Mail.dat version.
					//
					string version = options.TaregtVersion;
					version ??= localContext.Hdr.Where(t=>t.HeaderHistoryStatus=="C").Single().MailDatVersion;

					//
					// Get all of the model entities.
					//
					IEnumerable<IEntityType> entities = localContext.Model.GetEntityTypes();

					//
					// Forward the progress events.
					//
					SingleFileExporter fileExporter = new()
					{
						ProgressUpdateAsync = async (item) =>
						{
							await this.FireProgressUpdateAsync(item);
						}
					};

					//
					// Get the ExportAsync method from the FileExporter class.
					//
					MethodInfo exportMethod = typeof(SingleFileExporter).GetMethod("ExportAsync");

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
							genericMethod.Invoke(fileExporter, [options, version, entityType, queryable.Cast<IMaildatEntity>().AsQueryable(), options.CancellationToken]);
						}
					});

					//
					// Check if the output should be zipped.
					//
					if (Path.GetExtension(options.TargetFile.FilePath).ToLower() == ".zip")
					{
						//
						// Zip the Mail.dat.
						//

					}
				}
				finally
				{
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Export", ItemAction = ProgressMessageType.Completed, Message = "Export" });
				}
			}
			else
			{
				throw new FileNotFoundException(options.SourceFile);
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