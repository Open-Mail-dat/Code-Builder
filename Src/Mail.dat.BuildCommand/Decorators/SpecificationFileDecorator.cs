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
using Mail.dat.Json.Specification;
using Mail.dat.Json.Specification.Models;
using Newtonsoft.Json;

namespace Mail.dat.BuildCommand
{
	public static class SpecificationFileDecorator
	{
		//
		// Loads specification files from a comma-separated list of file paths.
		// Each file is deserialized into a SpecificationFile object and added to the dictionary by its major version.
		//
		public static Task<Dictionary<string, SpecificationFile>> LoadSpecificationsAsync(this string parameter)
		{
			Dictionary<string, SpecificationFile> returnValue = [];

			//
			// Split the input string by commas to get individual file paths.
			//
			IEnumerable<FileInfo> files = from tbl in parameter.Split(',')
										  select new FileInfo(tbl);

			//
			// Iterate through each file and process it.
			//
			foreach (FileInfo file in files)
			{
				if (file.Exists)
				{
					//
					// Read the file contents into a string.
					//
					string jsonContent = File.ReadAllText(file.FullName);

					//
					// Deserialize the JSON into a SpecificationFile object.
					//
					SpecificationFile specificationFile = JsonConvert.DeserializeObject<SpecificationFile>(jsonContent);

					//
					// Add the specification file to the dictionary using its major version as the key.
					//
					returnValue.Add(specificationFile.Version.Major, specificationFile);
				}
				else
				{
					//
					// Throw an exception if the file does not exist.
					//
					throw new FileNotFoundException(file.FullName);
				}
			}

			//
			// Return the dictionary ordered by key.
			//
			return Task.FromResult(returnValue.OrderBy(t => t.Key).ToDictionary());
		}

		//
		// Merges multiple specification files into groups by file extension and orders them.
		// Each group contains file definitions for a specific extension across all versions.
		//
		public static Task<IEnumerable<FileGroup>> MergeSpecificationsAsync(this Dictionary<string, SpecificationFile> specificationFiles)
		{
			IEnumerable<FileGroup> returnValue = [];

			//
			// Flatten the file definitions, group them by file extension, and join with the ordering list.
			//
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

			//
			// Return the grouped and ordered file definitions.
			//
			return Task.FromResult(returnValue);
		}
	}
}