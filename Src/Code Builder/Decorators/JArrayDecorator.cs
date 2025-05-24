using Newtonsoft.Json.Linq;

namespace Mail.dat.CodeBuilder
{
	public static class JArrayDecorator
	{
		public static int GetLineLenth(this JObject item)
		{
			return ((JArray)item["recordDefinitions"]).Sum(t => Convert.ToInt32(t["length"]));
		}

		public static string GetInvalidFields(JArray attributes)
		{
			IEnumerable<string> fields = attributes
				.Cast<JObject>()
				.Select(c => new
				{
					File = c["file"].ToString(),
					RecordDefinitions = c["recordDefinitions"]
				})
				.SelectMany(t => t.RecordDefinitions
				.Select(r => new
				{
					t.File,
					RecordDefinitions = r,
					Property = r["fieldName"]?.ToString(),
					Code = r["fieldCode"]?.ToString()
				})
				.Where(x => x.RecordDefinitions["dataType"]?.ToString() == "A/N")
				.Select(x => new
				{
					x.Property,
					x.Code,
					Type = x.RecordDefinitions["data"]["type"].ToString(),
					DataType = x.RecordDefinitions["dataType"].ToString(),
					x.File
				})
				.Where(x => x.Type == "integer")
				.Select(x => $"[{x.Code}] {x.File} -> {x.Property} -> {x.DataType} = {x.Type}"))
				.ToList();

			return string.Join(Environment.NewLine, fields);
		}
	}
}
