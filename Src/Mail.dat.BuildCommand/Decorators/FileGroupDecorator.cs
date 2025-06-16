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

		public static string Description(this FileGroup fileGroup, string version)
		{
			string summary = fileGroup.Summary(version);
			string description = fileGroup.FileDefinition(version).FileDescription.Sanitize().Transform(To.SentenceCase).EndSentence();

			return $"{summary} {description}".Trim();
		}

		public static int Length(this FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			return fileGroup.Items.SelectMany(t => t.FileDefinition.RecordDefinitions)
								  .Where(t => t.ToPropertyName() == recordDefinition.ToPropertyName())
								  .Max(t => t.Length);
		}

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

		public static AttributeBuilder MaildatVersionsAttribute(this FileGroup fileGroup)
		{
			string[] versions = fileGroup.Items.Select(t => t.Version.Major).ToArray();
			string parameter = string.Join(", ", versions.Select(t => $"\"{t}\""));
			return AttributeBuilder.Create("MaildatVersions").AddParameter("", parameter, false);
		}

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
