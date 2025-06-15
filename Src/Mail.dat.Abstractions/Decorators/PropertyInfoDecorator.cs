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
	public static class PropertyInfoExtensions
	{
		public static TAttribute GetAttribute<TAttribute>(this Type type)
			where TAttribute : Attribute
		{
			TAttribute returnValue = null;

			returnValue = type.GetCustomAttributes(typeof(TAttribute), inherit: true).FirstOrDefault() as TAttribute;

			return returnValue;
		}

		public static IEnumerable<PropertyInfo> GetPropertiesWithAttribute<TAttribute>(this Type type)
			where TAttribute : Attribute
		{
			return type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					   .Where(prop => Attribute.IsDefined(prop, typeof(TAttribute)));
		}

		public static TAttribute GetAttribute<TAttribute>(this PropertyInfo propertyInfo)
			where TAttribute : Attribute
		{
			return propertyInfo.GetCustomAttributes(typeof(TAttribute), inherit: true).FirstOrDefault() as TAttribute;
		}

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

		public static MaildatFieldAttribute GetMaildatFieldAttribute(this PropertyInfo propertyInfo, string version)
		{
			return propertyInfo.GetCustomAttributes<MaildatFieldAttribute>().Where(t => t.Version == version).SingleOrDefault();
		}

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
