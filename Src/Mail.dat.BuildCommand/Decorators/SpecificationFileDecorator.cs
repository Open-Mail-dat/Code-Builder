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
// LICENSE-GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using Mail.dat.Json.Specification;
using Mail.dat.Json.Specification.Models;
using Newtonsoft.Json;

namespace Mail.dat.BuildCommand
{
	public static class SpecificationFileDecorator
	{
		public static Task<Dictionary<string, SpecificationFile>> LoadSpecificationsAsync(this string parameter)
		{
			Dictionary<string, SpecificationFile> returnValue = [];

			//
			// Get the files.
			//
			IEnumerable<FileInfo> files = from tbl in parameter.Split(',')
										  select new FileInfo(tbl);

			foreach (FileInfo file in files)
			{
				if (file.Exists)
				{
					//
					// Read the file contents into a string.
					//
					string jsonContent = File.ReadAllText(file.FullName);

					//
					// Deserialize the JSON into a SpecificationFile.
					//
					SpecificationFile specificationFile = JsonConvert.DeserializeObject<SpecificationFile>(jsonContent);

					//
					// Add the file.
					//
					returnValue.Add(specificationFile.Version.Major, specificationFile);
				}
				else
				{
					throw new FileNotFoundException(file.FullName);
				}
			}

			return Task.FromResult(returnValue.OrderBy(t => t.Key).ToDictionary());
		}

		public static Task<IEnumerable<FileGroup>> MergeSpecificationsAsync(this Dictionary<string, SpecificationFile> specificationFiles)
		{
			IEnumerable<FileGroup> returnValue = [];

			returnValue = specificationFiles
							.SelectMany(t => t.Value.Files.Select(x => new 
							{ 
								t.Value.Version, 
								x.FileExtension, 
								FileDefinition = x 
							}))
							.GroupBy(g => g.FileExtension)
							.Join(FileOrdering.List,
								fileGroup => fileGroup.Key,
								ordering => ordering.Extension,
								(fileGroup, ordering) => new { FileGroup = fileGroup, ordering.Ordinal })
							.Select(s => new FileGroup
							{
								FileExtension = s.FileGroup.Key,
								Ordinal = s.Ordinal,
								Items = s.FileGroup.Select(y => new FileDefinitionList
								{
									Version = y.Version,
									FileDefinition = y.FileDefinition
								})
							})
							.OrderBy(x => x.Ordinal)
							.Select(x => x);

			return Task.FromResult(returnValue);
		}
	}
}