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
	/// <summary>
	/// Provides functionality to import Mail.dat files into a database context.
	/// </summary>
	/// <remarks>The <see cref="MaildatImport"/> class supports importing Mail.dat files, including handling zipped
	/// files, creating a database context, and processing entities in parallel. Progress updates can be reported using the
	/// <see cref="ProgressUpdate"/> delegate. Use the <see cref="Create()"/> or <see
	/// cref="Create(ProgressAsyncDelegate)"/> methods to instantiate this class.</remarks>
	public class MaildatImport : IMaildatImport
	{
		/// <summary>
		/// Gets or sets the delegate to report progress updates during an asynchronous operation.
		/// </summary>
		/// <remarks>Assign a delegate to this property to handle progress reporting for long-running asynchronous
		/// operations. The delegate will be called with progress information as the operation progresses.</remarks>
		public ProgressAsyncDelegate ProgressUpdate { get; set; }

		/// <summary>
		/// Prevents the instantiation of the <see cref="MaildatImport"/> class from outside the class.
		/// </summary>
		/// <remarks>This private constructor is used to restrict the creation of instances of the <see
		/// cref="MaildatImport"/> class, enforcing a specific design pattern, such as a static utility class or
		/// singleton.</remarks>
		private MaildatImport()
		{
		}

		/// <summary>
		/// Creates a new instance of an object that implements the <see cref="IMaildatImport"/> interface.
		/// </summary>
		/// <returns>An instance of a class that implements the <see cref="IMaildatImport"/> interface.</returns>
		public static IMaildatImport Create()
		{
			return new MaildatImport();
		}

		/// <summary>
		/// Creates a new instance of an object that implements the <see cref="IMaildatImport"/> interface.
		/// </summary>
		/// <param name="progressAction">A delegate that is invoked to report progress updates during the import process.</param>
		/// <returns>An instance of a class that implements the <see cref="IMaildatImport"/> interface.</returns>
		public static IMaildatImport Create(ProgressAsyncDelegate progressAction)
		{
			return new MaildatImport()
			{
				ProgressUpdate = progressAction
			};
		}

		/// <summary>
		/// Imports data from the specified source file into the target database asynchronously.
		/// </summary>
		/// <remarks>This method performs the following steps: <list type="bullet"> <item>Unzips the source file if it
		/// is compressed.</item> <item>Determines the version of the data to be imported.</item> <item>Creates and configures
		/// a database context for the target database.</item> <item>Deletes any existing database and creates a new
		/// one.</item> <item>Imports data entities in parallel, using a transaction to ensure consistency and improve
		/// performance.</item> </list> Progress updates are reported throughout the process via the <see
		/// cref="FireProgressUpdateAsync"/> method.</remarks>
		/// <param name="options">The options that configure the import process, including source file, target database, temporary directory, and
		/// cancellation token.</param>
		/// <returns>A tuple containing a boolean indicating whether the import was successful and a <see cref="MaildatContext"/>
		/// representing the database context for the imported data.</returns>
		/// <exception cref="Exception">Thrown if the source file cannot be unzipped or if other errors occur during the import process.</exception>
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
													.Select(t => new { EntityType = t, Atrribute = t.ClrType.GetCustomAttribute<MaildatExportAttribute>() })
													.Where(t => t.Atrribute.Version == version)
													.Select(t => t.EntityType)
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

		/// <summary>
		/// Asynchronously triggers a progress update event with the specified progress message.
		/// </summary>
		/// <param name="message">The progress message to be passed to the event handlers. Cannot be null.</param>
		/// <returns>A completed task representing the asynchronous operation.</returns>
		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdate.Invoke(message);
			return Task.CompletedTask;
		}
	}
}