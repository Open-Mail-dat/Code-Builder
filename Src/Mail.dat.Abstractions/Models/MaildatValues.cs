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
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// Represents a list of values that are valid for a given field.
	/// </summary>
	public abstract class MaildatValues : List<MaildatValue>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MaildatValues"/> class.
		/// </summary>
		/// <remarks>This constructor sets up the initial state of the <see cref="MaildatValues"/> instance by
		/// invoking the <see cref="OnInitializeValues"/> method to perform any necessary initialization logic.</remarks>
		public MaildatValues()
		{
			this.OnInitializeValues();
		}

		/// <summary>
		/// Gets the file extension associated with the current file.
		/// </summary>
		public string FileExtension => this.OnGetFile();

		/// <summary>
		/// Gets the field code associated with the current instance.
		/// </summary>
		public string FieldCode => this.OnGetFieldCode();

		/// <summary>
		/// Gets the collection of <see cref="MaildatValue"/> objects that match the specified version.
		/// </summary>
		/// <remarks>This indexer allows filtering the collection of <see cref="MaildatValue"/> objects by their
		/// <c>Version</c> property.</remarks>
		/// <param name="version">The version to filter the collection by. This value is case-sensitive.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> containing all <see cref="MaildatValue"/> objects with the specified version. If
		/// no matches are found, the collection will be empty.</returns>
		public IEnumerable<MaildatValue> this[string version]
		{
			get
			{
				return this.Where(t => t.Version == version);
			}
		}

		/// <summary>
		/// Provides an extension point for initializing values during the object's setup process.
		/// </summary>
		/// <remarks>This method is intended to be overridden in derived classes to perform custom initialization
		/// logic. The base implementation does nothing. Ensure that any overridden implementation does not throw exceptions
		/// unless necessary, as this method may be called during critical initialization phases.</remarks>
		protected virtual void OnInitializeValues()
		{
		}

		/// <summary>
		/// Retrieves the file path or name associated with the current operation.
		/// </summary>
		/// <remarks>This method is intended to be overridden in a derived class to provide the specific file path or
		/// name. The default implementation throws a <see cref="NotImplementedException"/>.</remarks>
		/// <returns>A <see cref="string"/> representing the file path or name. The exact value depends on the implementation in the
		/// derived class.</returns>
		/// <exception cref="NotImplementedException">Thrown if the method is not overridden in a derived class.</exception>
		protected virtual string OnGetFile()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves the code representation of a field.
		/// </summary>
		/// <remarks>This method is intended to be overridden in a derived class to provide a custom implementation
		/// for generating the code representation of a field. The default implementation throws a  <see
		/// cref="NotImplementedException"/>.</remarks>
		/// <returns>A <see cref="string"/> containing the code representation of the field.</returns>
		/// <exception cref="NotImplementedException">Thrown if the method is not overridden in a derived class.</exception>
		protected virtual string OnGetFieldCode()
		{
			throw new NotImplementedException();
		}
	}
}