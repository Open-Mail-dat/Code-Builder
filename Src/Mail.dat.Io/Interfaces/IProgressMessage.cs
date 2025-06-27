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
namespace Mail.dat.Io
{
	/// <summary>
	/// Represents the type of a progress message in a process or operation.
	/// </summary>
	/// <remarks>This enumeration is typically used to indicate the state or stage of a process.</remarks>
	public enum ProgressMessageType
	{
		/// <summary>
		/// Represents the progress of an operation or task.
		/// </summary>
		/// <remarks>This type can be used to track and report the progress of a long-running operation. It may
		/// include additional details such as the percentage completed or a description of the current step.</remarks>
		Progress,
		/// <summary>
		/// Starts the operation or process associated with this instance.
		/// </summary>
		/// <remarks>This method initiates the operation and transitions the instance into an active state. Ensure
		/// that any required preconditions are met before calling this method.</remarks>
		Start,
		/// <summary>
		/// Represents the state of an operation that has been completed successfully.
		/// </summary>
		/// <remarks>This value is typically used to indicate that a process or task has finished execution and no
		/// further action is required.</remarks>
		Completed
	}

	/// <summary>
	/// Represents a message that provides progress information for an operation involving multiple items.
	/// </summary>
	/// <remarks>This interface is designed to encapsulate details about the progress of an operation, such as the 
	/// current item's name, source, index, and total count, as well as a descriptive message and the type  of action being
	/// performed. It can be used to communicate progress updates in scenarios such as  batch processing or long-running
	/// tasks.</remarks>
	public interface IProgressMessage
	{
		/// <summary>
		/// Gets or sets the type of action associated with the progress message.
		/// </summary>
		ProgressMessageType ItemAction { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether progress will be displayed during the operation.
		/// </summary>
		bool WillShowProgress { get; set; }

		/// <summary>
		/// Gets or sets the name of the item.
		/// </summary>
		string ItemName { get; set; }

		/// <summary>
		/// Gets or sets the source of items used by the component.
		/// </summary>
		/// <remarks>The format and interpretation of the value depend on the specific implementation of the
		/// component. Ensure the value is valid and accessible based on the context in which the component is used.</remarks>
		string ItemSource { get; set; }

		/// <summary>
		/// Gets or sets the index of the current item in a collection.
		/// </summary>
		/// <remarks>Ensure the value is within the valid range of the collection's indices. Setting an invalid index
		/// may result in undefined behavior.</remarks>
		int ItemIndex { get; set; }

		/// <summary>
		/// Gets or sets the number of items in the collection.
		/// </summary>
		int ItemCount { get; set; }

		/// <summary>
		/// Gets or sets the message associated with the current operation or context.
		/// </summary>
		string Message { get; set; }
	}
}