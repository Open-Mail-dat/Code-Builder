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
using System.ComponentModel;

namespace Mail.dat
{
	/// <summary>
	/// Provides contextual information for type conversion operations, including the instance being converted and metadata
	/// about the associated field.
	/// </summary>
	/// <remarks>This class implements <see cref="ITypeDescriptorContext"/> to supply additional context during type
	/// conversion processes. It encapsulates the instance being converted, the associated property descriptor (if any),
	/// and metadata provided by the <see cref="MaildatFieldAttribute"/>.</remarks>
	public class ConverterContext : ITypeDescriptorContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConverterContext"/> class with the specified object instance and
		/// Maildat field attribute.
		/// </summary>
		/// <param name="instance">The object instance associated with this context. Cannot be <see langword="null"/>.</param>
		/// <param name="attribute">The <see cref="MaildatFieldAttribute"/> that provides metadata for the associated field. Cannot be <see
		/// langword="null"/>.</param>
		public ConverterContext(object instance, MaildatFieldAttribute attribute)
		{
			this.Instance = instance;
			this.PropertyDescriptor = null;
			this.MaildatFieldAttribute = attribute;
		}

		/// <summary>
		/// Gets the instance of the object associated with this member.
		/// </summary>
		public object Instance { get; protected set; }

		/// <summary>
		/// Gets the descriptor that provides metadata about the property.
		/// </summary>
		public PropertyDescriptor PropertyDescriptor { get; protected set; }

		/// <summary>
		/// Gets the container that provides access to the application's dependency injection services.
		/// </summary>
		/// <remarks>Use this property to resolve services or dependencies registered in the application's dependency
		/// injection container. Ensure that the container is properly initialized before accessing this property to avoid
		/// unexpected behavior.</remarks>
		public IContainer Container => null;

		/// <summary>
		/// Gets the Maildat field attribute associated with this instance.
		/// </summary>
		public MaildatFieldAttribute MaildatFieldAttribute { get; protected set; }

		/// <summary>
		/// Retrieves a service object of the specified type.
		/// </summary>
		/// <param name="serviceType">The <see cref="Type"/> of the service to retrieve.</param>
		/// <returns>An object that represents the requested service, or <see langword="null"/> if the service cannot be found.</returns>
		public object GetService(Type serviceType) => null;

		/// <summary>
		/// Notifies the container that a component has been modified.
		/// </summary>
		/// <remarks>This method is typically called to signal that a component's state has changed,  allowing the
		/// container to respond accordingly, such as updating its state or  triggering related events. This method does not
		/// take any parameters and does not  return a value.</remarks>
		public void OnComponentChanged() { }

		/// <summary>
		/// Notifies that a component is about to be changed.
		/// </summary>
		/// <returns><see langword="true"/> to indicate that the change can proceed.</returns>
		public bool OnComponentChanging() => true;
	}
}
