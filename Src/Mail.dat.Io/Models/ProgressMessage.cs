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
namespace Mail.dat.Io.Models
{
	/// <summary>
	/// Represents a message that provides progress information for an operation.
	/// </summary>
	/// <remarks>This class is used to convey details about the progress of an operation, including the type of
	/// action being performed, the current item's name and source, and the overall progress state. It can also include
	/// additional context information relevant to the operation.</remarks>
	internal class ProgressMessage : IProgressMessage
	{
		/// <summary>
		/// Gets or sets the type of action being performed on the item.
		/// </summary>
		public ProgressMessageType ItemAction { get; set; }

		/// <summary>
		/// Gets or sets the message associated with the current operation or context.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the name of the item.
		/// </summary>
		public string ItemName { get; set; }

		/// <summary>
		/// Gets or sets the source identifier for the item.
		/// </summary>
		public string ItemSource { get; set; }

		/// <summary>
		/// Gets or sets the index of the current item in a collection.
		/// </summary>
		public int ItemIndex { get; set; }

		/// <summary>
		/// Gets or sets the number of items in the collection.
		/// </summary>
		public int ItemCount { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether progress will be displayed during the operation.
		/// </summary>
		public bool WillShowProgress { get; set; }

		/// <summary>
		/// Gets or sets the context object associated with the current operation.
		/// </summary>
		public object Context { get; set; }
	}
}
