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
namespace Mail.dat
{
	/// <summary>
	/// Executes multiple actions asynchronously and waits for all of them to complete.
	/// </summary>
	/// <remarks>This method runs each action in the <paramref name="actions"/> collection on a separate task  and
	/// waits for all tasks to complete. If the <paramref name="actions"/> collection is empty,  the method completes
	/// immediately.</remarks>
	public static class TaskExtensions
	{
		/// <summary>
		/// Executes multiple actions concurrently in an asynchronous context.
		/// </summary>
		/// <remarks>This method runs all provided actions concurrently using <see cref="Task.Run(Action)"/>.  If any
		/// of the actions throw an exception, the method will propagate the exception after all tasks have
		/// completed.</remarks>
		/// <param name="maildatEntity">The <see cref="MaildatEntity"/> instance on which the method is invoked. This parameter is not used within the
		/// method but is required for extension method syntax.</param>
		/// <param name="actions">A collection of actions to be executed concurrently. Each action is run on a separate task.</param>
		/// <returns>A completed <see cref="Task"/> that represents the asynchronous operation.</returns>
		public static Task MultipleActionsAsync(this MaildatEntity maildatEntity, params IEnumerable<Action> actions)
		{
			Task.WaitAll(actions.Select(a => Task.Run(a)).ToArray());
			return Task.CompletedTask;
		}
	}
}
