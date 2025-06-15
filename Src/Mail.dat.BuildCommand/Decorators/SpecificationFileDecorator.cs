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