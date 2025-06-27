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
	/// Provides methods for executing actions with built-in exception handling.
	/// </summary>
	/// <remarks>This class simplifies the process of executing code that may throw exceptions by allowing the
	/// caller to specify both the action to execute and a handler for any exceptions that occur.</remarks>
	public static class SafeExecutor
	{
		/// <summary>
		/// Executes the specified action within a try-catch block, allowing custom handling of exceptions.
		/// </summary>
		/// <remarks>This method provides a simplified way to handle exceptions by separating the logic for the main
		/// operation  and the exception handling. Ensure that <paramref name="tryAction"/> and <paramref name="catchAction"/>
		/// are not null  to avoid a <see cref="NullReferenceException"/>.</remarks>
		/// <param name="tryAction">The action to execute. This action is run within the try block.</param>
		/// <param name="catchAction">The action to execute if an exception is thrown. The exception is passed as a parameter to this action.</param>
		public static void Try(Action tryAction, Action<Exception> catchAction)
		{
			try
			{
				tryAction();
			}
			catch (Exception ex)
			{
				catchAction(ex);
			}
		}
	}
}
