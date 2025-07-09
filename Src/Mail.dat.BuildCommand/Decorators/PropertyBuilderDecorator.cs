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
using Humanizer;
using Mail.dat.Json.Specification;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Provides extension methods for the <see cref="PropertyBuilder"/> class to facilitate
	/// the values for a specific property.
	/// </summary>
	public static class PropertyBuilderDecorator
	{
		/// <summary>
		/// Creates a class representing allowed values for a specified property and adds it to the project.
		/// </summary>
		/// <remarks>This method generates a class file that encapsulates the allowed values for a given property,
		/// based on the provided <paramref name="fileGroup"/> and <paramref name="recordDefinition"/>. The class is created
		/// in the specified <paramref name="filePath"/> and is part of the specified <paramref name="nameSpace"/>. The
		/// generated class includes methods to retrieve the associated Mail.dat file and field code.</remarks>
		/// <param name="propertyBuilder">The <see cref="PropertyBuilder"/> to which the values class will be added.</param>
		/// <param name="filePath">The file path where the class will be created. Cannot be null or empty.</param>
		/// <param name="propertyName">The name of the property for which the values class is being created. Cannot be null or empty.</param>
		/// <param name="nameSpace">The namespace in which the class will be defined. Cannot be null or empty.</param>
		/// <param name="fileGroup">The <see cref="FileGroup"/> containing allowed values and file extension information. Cannot be null.</param>
		/// <param name="recordDefinition">The <see cref="RecordDefinition"/> containing field code information. Cannot be null.</param>
		/// <returns>The original <see cref="PropertyBuilder"/> with the added values class.</returns>
		public static PropertyBuilder CreateValuesClass(this PropertyBuilder propertyBuilder, string filePath, string propertyName, string nameSpace, FileGroup fileGroup, RecordDefinition recordDefinition)
		{
			IEnumerable<AllowedValue> values = fileGroup.AllowedValues(recordDefinition);

			if (values.Count() > 0)
			{
				DirectoryInfo dir = new(Path.GetDirectoryName(filePath));
				dir.Create();

				ClassBuilder.Create(propertyName.Pluralize())
						.SetFileHeaderComments()
						.SetNameSpace(nameSpace)
						.AddUsing("Mail.dat.Abstractions")
						.SetSummary($"These are the allowed values for the property {propertyName} ({recordDefinition.FieldCode}).")
						.SetObjectType("class")
						.SetScope("public")
						.SetPartial(false)
						.AddImplements("MaildatValues")
						.AddAttributes(
							fileGroup.MaildatVersionsAttribute(),
							AttributeBuilder.Create("MaildatFieldLink")
								.AddParameter("File", fileGroup.FileExtension)
								.AddParameter("FieldCode", recordDefinition.FieldCode)
						)
						.AddMethod(MethodBuilder.Create("OnGetFieldCode")
							.SetScope("protected override")
							.SetReturnType("string")
							.SetSummary("Returns the Mail.dat file this set of values is lined to.")
							.AddCode($"return \"{fileGroup.FileExtension}\";"))
						.AddMethod(MethodBuilder.Create("OnGetFile")
							.SetScope("protected override")
							.SetReturnType("string")
							.SetSummary("Returns the field code that this set of values is linked to.")
							.AddCode($"return \"{recordDefinition.FieldCode}\";"))
						.AddMethod(MethodBuilder.Create("OnInitializeValues")
							.SetScope("protected override")
							.SetReturnType("void")
							.SetSummary("Initializes the values.")
							.AddCode([.. (from tbl in values
								select $"this.Add(new MaildatValue() {{ Version = \"{tbl.Version.Major}\", Key = \"{tbl.Key}\", FileExtension = \"{fileGroup.FileExtension}\", Description = \"{tbl.Value.Sanitize()}\", FieldCode = \"{recordDefinition.FieldCode}\", FieldName = \"{propertyName}\" }});")]))
						.Build(filePath, 1);
			}

			return propertyBuilder;
		}
	}
}
