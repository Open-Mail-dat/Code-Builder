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
namespace Mail.dat.BuildCommand
{
	public class ImplementsBuilder : ICodeBuilder<ImplementsBuilder>
	{
		public List<string> Items { get; } = [];

		public ImplementsBuilder Add(string item)
		{
			this.Items.Add(item);
			return this;
		}

		public ImplementsBuilder Build(string filePath, int indentLevel = 0)
		{
			if (this.Items.Count != 0)
			{
				//
				// Get the first item that does not start with "I".
				//
				string classItem = this.Items.FirstOrDefault(item => !item.StartsWith("I", StringComparison.OrdinalIgnoreCase));

				//
				// Get the items that start with an "I".
				//
				IEnumerable<string> interfaces = this.Items.Where(item => item.StartsWith("I", StringComparison.OrdinalIgnoreCase));

				//
				// Create a new list with the class first and the interfaces after.
				//
				IEnumerable<string> items = (new string[] { classItem }).Union(interfaces).Where(t => t != null);

				//
				// Combine all of the itmes as a comma separated list.
				//
				string list = string.Join(", ", items);

				//
				// Write the name.
				//
				File.AppendAllLines(filePath, [$" : {list} "]);
			}
			else
			{
				File.AppendAllLines(filePath, [""]);
			}

			return this;
		}
	}
}
