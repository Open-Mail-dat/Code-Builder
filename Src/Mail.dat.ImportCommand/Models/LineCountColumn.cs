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

namespace Mail.dat.ImportCommand
{
	/// <summary>
	/// Represents a progress column that displays the current value and maximum value of a progress task.
	/// </summary>
	/// <remarks>This column is designed to render a visual representation of a progress task's state, showing the
	/// current value and the maximum value in a formatted string. If the task's value is zero, an empty markup is
	/// rendered.</remarks>
	public class LineCountColumn : ProgressColumn
	{
		/// <summary>
		/// Renders a visual representation of the progress task's current value and maximum value.
		/// </summary>
		/// <param name="options">The rendering options that define how the output should be formatted.</param>
		/// <param name="task">The progress task whose value and maximum value are to be rendered.</param>
		/// <param name="deltaTime">The time elapsed since the last render, which can be used for animations or updates.</param>
		/// <returns>An <see cref="IRenderable"/> object representing the progress task's current state.  If the task's value is zero,
		/// an empty markup is returned; otherwise, a formatted string showing the current value and maximum value is
		/// returned.</returns>
		public override IRenderable Render(RenderOptions options, ProgressTask task, TimeSpan deltaTime)
		{
			//
			// Check if the current value of the task is zero.
			// If it is zero, do not display any progress information.
			//
			if (task.Value == 0)
			{
				//
				// Return an empty markup to indicate that no progress should be shown when the value is zero.
				//
				return new Markup("");
			}
			else
			{
				//
				// Format and display the current value and maximum value of the task.
				// The values are formatted with thousands separators and styled in white.
				// The output is left-justified and will use ellipsis if it overflows the available space.
				//
				return new Markup($"([white]{task.Value:#,###}[/] of [white]{task.MaxValue:#,###}[/])").Overflow(Overflow.Ellipsis).Justify(Justify.Left);
			}
		}
	}
}