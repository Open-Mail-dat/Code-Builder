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
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
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

			await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Import", ItemAction = ProgressMessageType.Start, Message = "Import" });

			try
			{
				//
				// Unzip the files.
				//
				if (options.SourceFile.IsZipped)
				{
					if (!await options.SourceFile.Unzip(options.TemporaryDirectory))
					{
						throw new Exception($"The file '{options.SourceFile.FilePath}' could not be unzipped.");
					}
				}

				//
				// Get the version.
				//
				string version = (from tbl in File.ReadAllLines(options.SourceFile.HeaderFilePath)
								  let ver = tbl.Substring(8, 4)
								  let status = tbl.Substring(16, 1)
								  where status == "C"
								  select ver).SingleOrDefault();

				//
				// Generate a connection string using the database
				// path that was provided.
				//
				string connectionString = $"Data Source={options.TargetFile}";

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
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "CreatingDatabase", ItemAction = ProgressMessageType.Start, Message = "Creating Database" });
				await context.EnsureDeletedAsync();
				await context.EnsureCreatedAsync();
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "CreatingDatabase", ItemAction = ProgressMessageType.Completed, Message = "Creating Database" });

				//
				// Get all of the model entities.
				//
				IEnumerable<IEntityType> entities = context.Model.GetEntityTypes()
													.Where(t => t.ClrType.GetAttribute<MaildatImportAttribute>() != null)
													.OrderBy(t => t.ClrType.GetAttribute<MaildatImportAttribute>().Order);

				//
				// Forward the progress events.
				//
				SingleFileImporter fileImporter = new()
				{
					ProgressUpdateAsync = async (item) =>
					{
						await this.FireProgressUpdateAsync(item);
					}
				};

				//
				// Get the ImportAsync method from the FileImporter class.
				//
				MethodInfo method = typeof(SingleFileImporter).GetMethod("ImportAsync");

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
							genericMethod.Invoke(fileImporter, [options, version, context, options.CancellationToken]);
						}
					});
				}
				finally
				{
					//
					// Commit the transaction to save all changes to the database.
					//
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "SavingDatabase", ItemAction = ProgressMessageType.Start, Message = "Committing Transactions" });
					transaction.Commit();
					await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "SavingDatabase", ItemAction = ProgressMessageType.Completed, Message = "Committing Transactions" });
				}
			}
			finally
			{
				//
				// Fire a progress update indicating that the import is completed.
				//
				await this.FireProgressUpdateAsync(new ProgressMessage() { ItemName = "Import", ItemAction = ProgressMessageType.Completed, Message = "Import" });
			}

			return (returnValue, context);
		}

		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdate.Invoke(message);
			return Task.CompletedTask;
		}
	}
}