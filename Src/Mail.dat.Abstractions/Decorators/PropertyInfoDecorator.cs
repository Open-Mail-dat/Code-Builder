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
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Mail.dat
{
	/// <summary>
	/// Provides extension methods for working with <see cref="Type"/> and <see cref="PropertyInfo"/> objects, enabling
	/// retrieval of attributes, property metadata, and type conversion functionality.
	/// </summary>
	/// <remarks>This static class includes utility methods for common reflection-based operations, such as
	/// retrieving custom attributes, filtering properties by attribute, and handling type conversion for property values.
	/// It is designed to simplify and streamline reflection tasks in .NET applications.</remarks>
	public static class PropertyInfoExtensions
	{
		/// <summary>
		/// Retrieves the first custom attribute of the specified type applied to the given type.
		/// </summary>
		/// <remarks>This method searches for the specified attribute type in the inheritance hierarchy of the given
		/// type. If multiple attributes of the specified type are applied, only the first one is returned.</remarks>
		/// <typeparam name="TAttribute">The type of the attribute to retrieve. Must derive from <see cref="System.Attribute"/>.</typeparam>
		/// <param name="type">The type to inspect for the specified attribute. Cannot be <see langword="null"/>.</param>
		/// <returns>An instance of <typeparamref name="TAttribute"/> if the attribute is found; otherwise, <see langword="null"/>.</returns>
		public static TAttribute GetAttribute<TAttribute>(this Type type)
			where TAttribute : Attribute
		{
			TAttribute returnValue = null;

			returnValue = type.GetCustomAttributes(typeof(TAttribute), inherit: true).FirstOrDefault() as TAttribute;

			return returnValue;
		}

		/// <summary>
		/// Retrieves all public instance properties of the specified type that are decorated with the specified attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The type of the attribute to search for. Must derive from <see cref="Attribute"/>.</typeparam>
		/// <param name="type">The type whose properties are to be inspected. Cannot be <see langword="null"/>.</param>
		/// <returns>An enumerable collection of <see cref="PropertyInfo"/> objects representing the properties that are decorated with
		/// the specified attribute. Returns an empty collection if no such properties are found.</returns>
		public static IEnumerable<PropertyInfo> GetPropertiesWithAttribute<TAttribute>(this Type type)
			where TAttribute : Attribute
		{
			return type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					   .Where(prop => Attribute.IsDefined(prop, typeof(TAttribute)));
		}

		/// <summary>
		/// Retrieves a custom attribute of the specified type that is applied to the given property.
		/// </summary>
		/// <remarks>This method searches for the specified attribute type in the custom attributes of the property,
		/// including inherited attributes.</remarks>
		/// <typeparam name="TAttribute">The type of the attribute to retrieve. Must derive from <see cref="System.Attribute"/>.</typeparam>
		/// <param name="propertyInfo">The <see cref="System.Reflection.PropertyInfo"/> object representing the property to inspect.</param>
		/// <returns>An instance of the specified attribute type if it is found; otherwise, <see langword="null"/>.</returns>
		public static TAttribute GetAttribute<TAttribute>(this PropertyInfo propertyInfo)
			where TAttribute : Attribute
		{
			return propertyInfo.GetCustomAttributes(typeof(TAttribute), inherit: true).FirstOrDefault() as TAttribute;
		}

		/// <summary>
		/// Retrieves the <see cref="TypeConverter"/> associated with the specified property.
		/// </summary>
		/// <remarks>This method uses reflection to check for a <see cref="TypeConverterAttribute"/> on the property.
		/// If the attribute is present, it attempts to create an instance of the specified type converter. If no attribute is
		/// found, a default converter for <see cref="string"/> is returned.</remarks>
		/// <param name="propertyInfo">The <see cref="PropertyInfo"/> representing the property for which to retrieve the type converter.</param>
		/// <returns>A <see cref="TypeConverter"/> instance for the property. If the property has a <see
		/// cref="TypeConverterAttribute"/>, the converter specified by the attribute is returned; otherwise, a default
		/// converter for <see cref="string"/> is returned.</returns>
		public static TypeConverter GetTypeConverter(this PropertyInfo propertyInfo)
		{
			TypeConverter returnValue = TypeDescriptor.GetConverter(typeof(string));

			TypeConverterAttribute attr = propertyInfo.GetCustomAttribute<TypeConverterAttribute>();

			if (attr != null)
			{
				Type converterType = Type.GetType(attr.ConverterTypeName);
				returnValue = (TypeConverter)Activator.CreateInstance(converterType);
			}

			return returnValue;
		}

		/// <summary>
		/// Retrieves the <see cref="MaildatFieldAttribute"/> associated with the specified property for the given version.
		/// </summary>
		/// <param name="propertyInfo">The property for which to retrieve the attribute.</param>
		/// <param name="version">The version of the attribute to match.</param>
		/// <returns>The <see cref="MaildatFieldAttribute"/> that matches the specified version, or <see langword="null"/> if no
		/// matching attribute is found.</returns>
		public static MaildatFieldAttribute GetMaildatFieldAttribute(this PropertyInfo propertyInfo, string version)
		{
			return propertyInfo.GetCustomAttributes<MaildatFieldAttribute>().Where(t => t.Version == version).SingleOrDefault();
		}

		/// <summary>
		/// Parses a line of data and converts a specified property value using the provided type converter.
		/// </summary>
		/// <remarks>This method uses metadata attributes defined on the property to determine how to extract and
		/// convert the value  from the provided line of data. If the conversion fails, an error is added to the <paramref
		/// name="errors"/> collection.</remarks>
		/// <typeparam name="TModel">The type of the model containing the property to parse.</typeparam>
		/// <typeparam name="TValue">The type of the property value to be returned.</typeparam>
		/// <param name="line">The line of data to parse, represented as a <see cref="ReadOnlySpan{T}"/> of bytes.</param>
		/// <param name="version">The version of the specification to use when determining the field's attributes.</param>
		/// <param name="propertyExpression">An expression identifying the property of <typeparamref name="TModel"/> to parse.  This must be a simple property
		/// access expression (e.g., <c>x => x.PropertyName</c>).</param>
		/// <param name="errors">A collection to which any errors encountered during parsing or conversion will be added.  This collection is
		/// updated in a thread-safe manner.</param>
		/// <returns>The parsed and converted value of the specified property, or the default value of <typeparamref name="TValue"/> 
		/// if parsing or conversion fails.</returns>
		public static TValue ParseForImport<TModel, TValue>(this ReadOnlySpan<byte> line, string version, Expression<Func<TModel, TValue>> propertyExpression, IList<ILoadError> errors)
		{
			TValue returnValue = default;

			//
			// Get PropertyInfo from the expression.
			//
			if (propertyExpression.Body is MemberExpression memberExpr && memberExpr.Member is PropertyInfo propInfo)
			{
				//
				// Get attribute from the property.
				//
				MaildatFieldAttribute attribute = propInfo.GetMaildatFieldAttribute(version);

				if (attribute != null)
				{
					//
					// Get the type converter defined in the property attribute.
					//
					TypeConverter typeConverter = propInfo.GetTypeConverter();

					//
					// Convert the string value to the property type using the type converter.
					//
					string value = Encoding.ASCII.GetString(line.Slice(attribute.Start - 1, attribute.Length)).Trim();

					try
					{
						//
						// Try to convert to an object.
						//
						object convertedValue = typeConverter.ConvertFrom(new ConverterContext(value, attribute), CultureInfo.CurrentCulture, value);

						//
						// If a field was defined as a string due to multiple specifications
						// with differing return types, we will convert the result to a string.
						//
						if (typeof(TValue) == typeof(string))
						{
							//
							// Convert the value to a string.
							//
							convertedValue = Convert.ToString(convertedValue);
						}

						//
						// Cast the object value to the return type.
						//
						returnValue = (TValue)convertedValue;
					}
					catch (Exception ex)
					{
						//
						// If the conversion fails, set the load error.
						//
						lock (errors)
						{
							errors.Add(new LoadError()
							{
								Attribute = attribute,
								Value = value,
								ErrorMessage = ex.Message
							});
						}
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Formats the specified value for export based on the provided version and property expression.
		/// </summary>
		/// <remarks>This method uses metadata from the property specified in the <paramref
		/// name="propertyExpression"/> to determine the appropriate formatting rules, including any custom type converters
		/// defined for the property. If no metadata or type converter is found, the method returns <see
		/// langword="null"/>.</remarks>
		/// <typeparam name="TModel">The type of the model containing the property.</typeparam>
		/// <typeparam name="TValue">The type of the value to be formatted.</typeparam>
		/// <param name="value">The value to be formatted for export.</param>
		/// <param name="version">The version identifier used to determine the formatting rules.</param>
		/// <param name="propertyExpression">An expression that identifies the property of the model to which the value corresponds.</param>
		/// <returns>A string representation of the formatted value, or <see langword="null"/> if the value cannot be formatted.</returns>
		public static string FormatForExport<TModel, TValue>(this TValue value, string version, Expression<Func<TModel, TValue>> propertyExpression)
		{
			string returnValue = null;

			//
			// Get PropertyInfo from the expression.
			//
			if (propertyExpression.Body is MemberExpression memberExpr && memberExpr.Member is PropertyInfo propInfo)
			{
				MaildatFieldAttribute attribute = propInfo.GetMaildatFieldAttribute(version);

				if (attribute != null)
				{
					//
					// Get the type converter defined in the property attribute.
					//
					TypeConverter typeConverter = propInfo.GetTypeConverter();

					try
					{
						//
						// Try to convert.
						//
						returnValue = typeConverter.ConvertToString(new ConverterContext(value, attribute), value);
					}
					catch
					{

					}
				}
			}

			return returnValue;
		}
	}
}
