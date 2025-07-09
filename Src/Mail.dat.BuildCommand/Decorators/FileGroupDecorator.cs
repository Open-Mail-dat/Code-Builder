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
using Humanizer;
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Provides extension methods for working with <see cref="FileGroup"/> objects, enabling operations such as retrieving
	/// file definitions, generating attributes, and accessing metadata.
	/// </summary>
	/// <remarks>This static class contains a variety of helper methods designed to simplify common tasks related to
	/// <see cref="FileGroup"/> objects, such as retrieving file information, generating attributes for Mail.dat files, and
	/// working with record definitions. These methods are intended to enhance the usability of <see cref="FileGroup"/> by
	/// providing high-level abstractions for common operations.</remarks>
	public static class FileGroupDecorator
	{
		public static FileDefinition FileDefinition(this FileGroup fileGroup, string version)
		{
			return fileGroup.Items.Where(t => t.Version.Major == version).Single().FileDefinition;
		}

		public static string Name(this FileGroup fileGroup, string version)
		{
			return fileGroup.FileDefinition(version).FileName.Transform(To.LowerCase).Sanitize().Transform(To.TitleCase).AddRecord();
		}

		public static string FileExtension(this FileGroup fileGroup, string version)
		{
			return fileGroup.FileDefinition(version).FileExtension.ToLower();
		}

		public static string Summary(this FileGroup fileGroup, string version)
		{
			return fileGroup.FileDefinition(version).FileSummary.Sanitize().Transform(To.SentenceCase).EndSentence();
		}

		/// <summary>
		/// Generates a descriptive string for the specified <see cref="FileGroup"/> and version.
		/// </summary>
		/// <remarks>The returned description combines the summary and sanitized file description of the specified
		/// file group, formatted in sentence case and ending with proper punctuation.</remarks>
		/// <param name="fileGroup">The <see cref="FileGroup"/> instance for which the description is generated.</param>
		/// <param name="version">The version of the file group to use when generating the description.</param>
		/// <returns>A string containing the summary and description of the file group for the specified version.</returns>
		public static string Description(this FileGroup fileGroup, string version)
		{
			string summary = fileGroup.Summary(version);
			string description = fileGroup.FileDefinition(version).FileDescription.Sanitize().Transform(To.SentenceCase).EndSentence();

			return $"{summary} {description}".Trim();
		}

		/// <summary>
		/// Calculates the maximum length of records in the specified file group that match the given record definition.
		/// </summary>
		/// <param name="fileGroup">The file group containing the items to evaluate.</param>
		/// <param name="recordDefinition">The record definition to match against the file group's record definitions.</param>
		/// <returns>The maximum length of records that match the specified record definition.  If no matching records are found, the
		/// method throws an exception.</returns>
		public static int Length(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			return fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
								  .Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName())
								  .Max(t => t.Length);
		}

		/// <summary>
		/// Determines the .NET type representation for a record definition within the specified file group.
		/// </summary>
		/// <remarks>This method evaluates the record definitions within the provided file group to determine the
		/// appropriate .NET type for the specified record definition. It considers the data type, required status, and other
		/// attributes of the record definitions to compute the result. If multiple types are found, the method defaults to a
		/// string type.</remarks>
		/// <param name="fileGroup">The file group containing the record definitions to evaluate.</param>
		/// <param name="recordDefinition">The record definition for which the type is being determined.</param>
		/// <returns>A string representing the .NET type that corresponds to the specified record definition. If multiple types are
		/// found, the method defaults to a string representation.</returns>
		public static string ReturnType(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			string returnValue = null;

			IEnumerable<string> types = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
														.Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName())
														.Select(t => t.Data.Type)
														.GroupBy(g => g)
														.OrderBy(g => g.Key)
														.Select(g => g.Key);

			IEnumerable<bool> required = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
														.Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName() && t.Required)
														.Select(t => t.Required)
														.GroupBy(g => g)
														.OrderBy(g => g.Key)
														.Select(g => g.Key);

			IEnumerable<string> dataType = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
														.Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName())
														.Select(t => t.DataType)
														.GroupBy(g => g)
														.OrderBy(g => g.Key)
														.Select(g => g.Key);

			if (types.Count() > 1)
			{
				returnValue = "string".ToDotNetType("A/N", required.Any());
			}
			else
			{
				returnValue = types.Single().ToDotNetType(dataType.FirstOrDefault(), required.Any());
			}

			return returnValue;
		}

		/// <summary>
		/// Generates a collection of attributes representing the metadata of Mail.dat files in the specified file group.
		/// </summary>
		/// <remarks>This method iterates through the items in the provided <paramref name="fileGroup"/> and
		/// constructs an attribute for each Mail.dat file definition. The attributes include key metadata such as version,
		/// revision, and file-specific details. The caller can use the returned collection to process or analyze the Mail.dat
		/// file attributes.</remarks>
		/// <param name="fileGroup">The file group containing the Mail.dat file definitions and associated metadata.</param>
		/// <returns>A collection of <see cref="AttributeBuilder"/> objects, where each object represents the attributes of a Mail.dat
		/// file, including version, revision, file extension, file name, summary, description, line length, and closing
		/// character.</returns>
		public static IEnumerable<AttributeBuilder> AddMaildatFileAttributes(this FileGroup fileGroup)
		{
			IList<AttributeBuilder> returnValue = [];

			foreach (FileDefinitionList item in fileGroup.Items)
			{
				returnValue.Add(AttributeBuilder.Create("MaildatFile")
								.AddParameter("Version", item.Version.Major)
								.AddParameter("Revision", item.Version.Revision)
								.AddParameter("Extension", item.FileDefinition.FileExtension)
								.AddParameter("File", item.FileDefinition.FileName)
								.AddParameter("Summary", fileGroup.Summary(item.Version.Major))
								.AddParameter("Description", fileGroup.Description(item.Version.Major))
								.AddParameter("LineLength", item.FileDefinition.RecordDefinitions.TotalLineLength())
								.AddParameter("ClosingCharacter", "#"));
			}

			return returnValue;
		}

		/// <summary>
		/// Adds Mail.dat import attributes to the specified <see cref="FileGroup"/>.
		/// </summary>
		/// <remarks>This method iterates through the file definitions in the provided <paramref name="fileGroup"/>
		/// and creates an attribute named "MaildatImport" for each file definition. The attribute includes the file group's
		/// ordinal as the "Order" parameter and the major version of the file definition as the "Version"
		/// parameter.</remarks>
		/// <param name="fileGroup">The <see cref="FileGroup"/> containing the file definitions for which attributes will be added.</param>
		/// <returns>A collection of <see cref="AttributeBuilder"/> instances, each representing a Mail.dat import attribute with
		/// parameters for the file group's order and the major version of each file definition.</returns>
		public static IEnumerable<AttributeBuilder> AddMaildatImportAttributes(this FileGroup fileGroup)
		{
			IList<AttributeBuilder> returnValue = [];

			foreach (FileDefinitionList item in fileGroup.Items)
			{
				returnValue.Add(AttributeBuilder.Create("MaildatImport")
							.AddParameter("Order", fileGroup.Ordinal)
							.AddParameter("Version", item.Version.Major));
			}

			return returnValue;
		}

		/// <summary>
		/// Adds Mail.dat field attributes to the specified record definition based on the file group's data.
		/// </summary>
		/// <remarks>This method iterates through the file definitions in the provided <paramref name="fileGroup"/>
		/// and identifies fields that match the specified <paramref name="recordDefinition"/>. For each matching field, it
		/// creates an <see cref="AttributeBuilder"/> instance with parameters that preserve the Mail.dat specification
		/// values, such as field code, name, data type, and other metadata. These attributes can be used by developers to
		/// access and utilize the Mail.dat field specifications programmatically.</remarks>
		/// <param name="fileGroup">The file group containing the file definitions and associated metadata.</param>
		/// <param name="recordDefinition">The record definition for which Mail.dat field attributes are to be added.</param>
		/// <returns>A collection of <see cref="AttributeBuilder"/> instances representing the Mail.dat field attributes for the
		/// specified record definition. The collection will be empty if no matching fields are found.</returns>
		public static IEnumerable<AttributeBuilder> AddMaildatFieldAttributes(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			IList<AttributeBuilder> returnValue = [];

			foreach (FileDefinitionList item in fileGroup.Items)
			{
				RecordDefinition field = item.FileDefinition.RecordDefinitions.Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName()).FirstOrDefault();

				if (field != null)
				{
					//
					// Add the Mail.dat attribute to preserve the specification values
					// and make them available to developers.
					//
					returnValue.Add(AttributeBuilder.Create("MaildatField")
						.AddParameter("Version", item.Version.Major)
						.AddParameter("Extension", fileGroup.FileExtension)
						.AddParameter("FieldCode", field.FieldCode)
						.AddParameter("FieldName", field.FieldName.Sanitize().Transform(To.SentenceCase))
						.AddParameter("Start", field.Start)
						.AddParameter("Length", field.Length)
						.AddParameter("Required", field.Required)
						.AddParameter("Key", field.Key)
						.AddParameter("DataType", field.DataType)
						.AddParameter("Default", field.Default)
						.AddParameter("Description", field.Description())
						.AddParameter("Type", field.Data.Type)
						.AddParameter("Format", field.Data.Format)
						.AddConditionalParameter(field.Data.Precision.HasValue, "Precision", field.Data.Precision)
						.AddConditionalParameter(field.Data.References != null && field.Data.References.Count != 0, "References", string.Join(",", field.Data.References)));
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Retrieves a collection of <see cref="RecordDefinition"/> objects associated with the specified <see
		/// cref="FileGroup"/>.
		/// </summary>
		/// <remarks>This method processes the items in the provided <see cref="FileGroup"/> to extract and group
		/// record definitions by their property names. For each group, the most recent version of the record definition is
		/// selected based on the version information.</remarks>
		/// <param name="fileGroup">The <see cref="FileGroup"/> containing the items from which record definitions are extracted.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> of <see cref="RecordDefinition"/> objects. Each record definition represents the
		/// most recent version of a record definition grouped by its property name.</returns>
		public static IEnumerable<RecordDefinition> RecordDefinitions(this FileGroup fileGroup)
		{
			IList<RecordDefinition> returnValue = [];

			returnValue = fileGroup.Items
								.SelectMany(f => f.FileDefinition.RecordDefinitions.Select(rd => new
								{
									RecordDefinition = rd,
									f.Version,
									rd.FieldCode,
									rd.FieldName
								}))
								.GroupBy(x => x.RecordDefinition.ToPropertyName())
								.Select(g => g
									.OrderByDescending(x => x.Version, new VersionInfoComparer())
									.First().RecordDefinition)
								.ToList();

			return returnValue;
		}

		/// <summary>
		/// Retrieves a collection of allowed value keys for the specified <see cref="RecordDefinition"/> within the given
		/// <see cref="FileGroup"/>.
		/// </summary>
		/// <remarks>The method aggregates keys from all <see cref="RecordDefinition"/> instances in the <paramref
		/// name="fileGroup"/> that match the specified <paramref name="recordDefinition"/> based on their property names. The
		/// resulting keys are distinct and sorted in ascending order.</remarks>
		/// <param name="fileGroup">The <see cref="FileGroup"/> containing the items to evaluate.</param>
		/// <param name="recordDefinition">The <see cref="RecordDefinition"/> used to filter and identify the relevant value keys.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> of strings representing the distinct, ordered keys associated with the specified
		/// <paramref name="recordDefinition"/>.</returns>
		public static IEnumerable<string> AllowedValueKeys(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			IEnumerable<string> returnValue = [];

			returnValue = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
										 .Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName())
										 .SelectMany(t => t.Data.Values.Keys)
										 .GroupBy(g => g)
										 .OrderBy(g => g.Key)
										 .Select(g => g.Key);

			return returnValue;
		}

		/// <summary>
		/// Retrieves a collection of allowed values for the specified record definition within the given file group.
		/// </summary>
		/// <remarks>The method filters and processes the items in the file group to extract allowed values based on
		/// the provided record definition. The results are ordered first by key and then by the major version of the
		/// associated file.</remarks>
		/// <param name="fileGroup">The file group containing the items to evaluate.</param>
		/// <param name="recordDefinition">The record definition for which allowed values are retrieved.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> of <see cref="AllowedValue"/> objects, where each object represents a key-value
		/// pair and its associated version for the specified record definition.</returns>
		public static IEnumerable<AllowedValue> AllowedValues(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			IEnumerable<AllowedValue> returnValue = [];

			returnValue = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions.Select(s => new { t.Version, RecordDefinition = s }))
										 .Where(t => t.RecordDefinition.ToPropertyName() == recordDefinition.ToPropertyName())
										 .SelectMany(t => t.RecordDefinition.Data.Values.Select(s => new { t.Version, s.Key, s.Value }))
										 .OrderBy(g => g.Key)
										 .ThenBy(g => g.Version.Major)
										 .Select(g => new AllowedValue() { Version = g.Version, Key = g.Key, Value = g.Value })
										 .ToArray();

			return returnValue;
		}

		/// <summary>
		/// Creates a "MaildatVersions" attribute for the specified file group,  containing a list of the major version
		/// numbers of its items.
		/// </summary>
		/// <remarks>The generated attribute includes the major version numbers of all items in the file group, 
		/// formatted as a comma-separated string enclosed in double quotes.</remarks>
		/// <param name="fileGroup">The file group whose items' major versions will be included in the attribute.</param>
		/// <returns>An <see cref="AttributeBuilder"/> instance representing the "MaildatVersions" attribute,  with a parameter
		/// containing the major version numbers of the file group's items as a comma-separated string.</returns>
		public static AttributeBuilder MaildatVersionsAttribute(this FileGroup fileGroup)
		{
			string[] versions = fileGroup.Items.Select(t => t.Version.Major).ToArray();
			string parameter = string.Join(", ", versions.Select(t => $"\"{t}\""));
			return AttributeBuilder.Create("MaildatVersions").AddParameter("", parameter, false);
		}

		/// <summary>
		/// Creates a "MaildatVersions" attribute for the specified file group and record definition.
		/// </summary>
		/// <remarks>This method evaluates the versions of the record definitions within the file group,  filters them
		/// based on the provided record definition, and groups them by their major version.  The resulting major versions are
		/// included as a parameter in the created attribute.</remarks>
		/// <param name="fileGroup">The file group containing the items to evaluate.</param>
		/// <param name="recordDefinition">The record definition used to filter versions.</param>
		/// <returns>An <see cref="AttributeBuilder"/> instance representing the "MaildatVersions" attribute,  with a parameter
		/// containing the distinct major versions associated with the specified record definition.</returns>
		public static AttributeBuilder MaildatVersionsAttribute(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			string[] versions = fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions.Select(s => new { t.Version, RecordDefinition = s }))
										 .Where(t => t.RecordDefinition.ToPropertyName() == recordDefinition.ToPropertyName())
										 .Select(t => t.Version)
										 .GroupBy(g => g.Major)
										 .Select(g => g.Key)
										 .ToArray();

			string parameter = string.Join(", ", versions.Select(t => $"\"{t}\""));
			return AttributeBuilder.Create("MaildatVersions").AddParameter("", parameter, false);
		}
	}
}
