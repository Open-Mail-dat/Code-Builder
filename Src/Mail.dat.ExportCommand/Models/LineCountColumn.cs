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
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Mail.dat.ExportCommand
{
	/// <summary>
	/// Represents a progress column that displays the current line count and the maximum line count for a task.
	/// </summary>
	/// <remarks>This column is typically used in progress displays to show the progress of a task in terms of lines
	/// processed. The output format includes the current value and the maximum value, formatted with thousands
	/// separators.</remarks>
	public class LineCountColumn : ProgressColumn
	{
		/// <summary>
		/// Renders a visual representation of the progress task's current value and maximum value.
		/// </summary>
		/// <param name="options">The rendering options that define how the output should be formatted.</param>
		/// <param name="task">The progress task whose value and maximum value are to be rendered.</param>
		/// <param name="deltaTime">The time elapsed since the last render, which can be used for animations or updates.</param>
		/// <returns>An <see cref="IRenderable"/> object representing the progress task's current state.  If the task's value is 0, an
		/// empty markup is returned; otherwise, a formatted string showing the current and maximum values is returned.</returns>
		public override IRenderable Render(RenderOptions options, ProgressTask task, TimeSpan deltaTime)
		{
			//
			// If the task's value is 0, return an empty markup.
			//
			if (task.Value == 0)
			{
				return new Markup("");
			}
			else
			{
				//
				// Return a formatted markup showing the current value and maximum value of the task.
				//
				return new Markup($"([white]{task.Value:#,###}[/] of [white]{task.MaxValue:#,###}[/])").Overflow(Overflow.Ellipsis).Justify(Justify.Left);
			}
		}
	}
}