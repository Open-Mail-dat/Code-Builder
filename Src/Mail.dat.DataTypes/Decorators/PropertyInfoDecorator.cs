using System;
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

		public static TValue ParseForImport<TModel, TValue>(this ReadOnlySpan<byte> line, Expression<Func<TModel, TValue>> propertyExpression, IList<ILoadError> errors)
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
				MaildatFieldAttribute attribute = propInfo.GetCustomAttribute<MaildatFieldAttribute>();

				//
				// Get the type converter defined in the property attribute.
				//
				TypeConverter typeConverter = propInfo.GetTypeConverter();

				//
				// Convert the string value to the property type using the type converter.
				//
				string value = Encoding.ASCII.GetString(line.Slice(attribute.Start - 1, attribute.Length)).Trim(); 
				// Encoding.UTF8.GetString(line, attribute.Start - 1, attribute.Length);

				try
				{
					//
					// try to convert.
					//
					returnValue = (TValue)typeConverter.ConvertFrom(new ConverterContext(value, propInfo.GetCustomAttribute<MaildatFieldAttribute>()), CultureInfo.CurrentCulture, value);
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

			return returnValue;
		}

		public static string FormatForExport<TModel, TValue>(this TValue value, Expression<Func<TModel, TValue>> propertyExpression)
		{
			string returnValue = null;

			//
			// Get PropertyInfo from the expression.
			//
			if (propertyExpression.Body is MemberExpression memberExpr && memberExpr.Member is PropertyInfo propInfo)
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
					returnValue = typeConverter.ConvertToString(new ConverterContext(value, propInfo.GetCustomAttribute<MaildatFieldAttribute>()), value);
				}
				catch
				{

				}
			}

			return returnValue;
		}
	}
}
