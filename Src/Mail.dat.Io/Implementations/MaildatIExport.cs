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
using Microsoft.Extensions.Logging.Abstractions;

namespace Mail.dat.Io
{
	/// <summary>
	/// Provides functionality to export Mail.dat files based on the specified options.
	/// </summary>
	/// <remarks>This class supports creating instances with or without a progress update delegate.  Use the <see
	/// cref="Create()"/> or <see cref="Create(ProgressAsyncDelegate)"/> methods to instantiate the class. The <see
	/// cref="ExportAsync(IExportOptions)"/> method performs the export operation,  and progress updates can be reported
	/// via the provided delegate, if specified.</remarks>
	public class MaildatExport : IMaildatExport
	{
		/// <summary>
		/// Gets or sets the delegate to report progress updates during an asynchronous operation.
		/// </summary>
		/// <remarks>Assign a delegate to this property to handle progress reporting for long-running asynchronous
		/// operations. The delegate will be called with progress information as the operation progresses.</remarks>
		public ProgressAsyncDelegate ProgressUpdate { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="MaildatExport"/> class.
		/// </summary>
		/// <remarks>This constructor is private, indicating that instances of the <see cref="MaildatExport"/> class
		/// cannot be created directly from outside the class. Use the appropriate factory methods or public members provided
		/// by the class to obtain an instance, if applicable.</remarks>
		private MaildatExport()
		{
		}

		/// <summary>
		/// Creates a new instance of an object that implements the <see cref="IMaildatExport"/> interface.
		/// </summary>
		/// <returns>An instance of a class that implements the <see cref="IMaildatExport"/> interface.</returns>
		public static IMaildatExport Create()
		{
			return new MaildatExport();
		}

		/// <summary>
		/// Creates a new instance of an object that implements the <see cref="IMaildatExport"/> interface.
		/// </summary>
		/// <param name="progressAction">A delegate to report progress asynchronously during the export process. Can be <see langword="null"/> if progress
		/// reporting is not required.</param>
		/// <returns>An instance of a class that implements the <see cref="IMaildatExport"/> interface.</returns>
		public static IMaildatExport Create(ProgressAsyncDelegate progressAction)
		{
			return new MaildatExport()
			{
				ProgressUpdate = progressAction
			};
		}

		/// <summary>
		/// Exports data from a source file to a target file in the specified format asynchronously.
		/// </summary>
		/// <remarks>This method processes data from the source file specified in the <paramref name="options"/>
		/// parameter and exports it to the target file. The export process includes generating a connection to the source
		/// database, retrieving data entities, and optionally compressing the output if the target file extension is ".zip".
		/// Progress updates are reported during the operation.</remarks>
		/// <param name="options">The export options, including source file path, target file path, target version, and cancellation token.</param>
		/// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the export
		/// operation completes successfully.</returns>
		/// <exception cref="FileNotFoundException">Thrown if the source file specified in <paramref name="options"/> does not exist.</exception>
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
					version ??= localContext.Hdr.Where(t => t.HeaderHistoryStatus == "C").Single().MailDatVersion;

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
					// Get all of the properties of the context that suport the Mail.dat version being exported.
					//
					PropertyInfo[] properties = localContext.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
												.Where(t => t.GetCustomAttribute<MaildatExportAttribute>() != null)
												.Select(t => new { Property = t, Atrribute = t.GetCustomAttribute<MaildatExportAttribute>() })
												.Where(t => t.Atrribute.Version == version)
												.Select(t => t.Property)
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

		/// <summary>
		/// Triggers the <see cref="ProgressUpdate"/> event with the specified progress message.
		/// </summary>
		/// <remarks>This method invokes the <see cref="ProgressUpdate"/> event if it has any subscribers.  The
		/// provided <paramref name="message"/> is passed to all event handlers.</remarks>
		/// <param name="message">The progress message to be passed to the event handlers. Cannot be <see langword="null"/>.</param>
		/// <returns>A completed <see cref="Task"/> representing the asynchronous operation.</returns>
		protected Task FireProgressUpdateAsync(IProgressMessage message)
		{
			this.ProgressUpdate?.Invoke(message);
			return Task.CompletedTask;
		}
	}
}