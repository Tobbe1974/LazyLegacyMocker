using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal static class PropertyInfoExtension
	{
		public static bool IsPrimitive(this PropertyInfo propertyInfo)
		{
			if (propertyInfo.PropertyType.IsPrimitive)
				return true;

			// TODO: Add more special types

			return false;
		}

		public static bool IsList(this PropertyInfo propertyInfo)
		{
			Type t = propertyInfo.PropertyType;

			return (t.IsGenericType &&
			        (t.GetGenericTypeDefinition() == typeof (List<>) || t.GetGenericTypeDefinition() == typeof (IList<>)));
		}

		public static bool IsCollection(this PropertyInfo propertyInfo)
		{
			Type t = propertyInfo.PropertyType;

			return (t.IsGenericType &&
					  (t.GetGenericTypeDefinition() == typeof(Collection<>) || t.GetGenericTypeDefinition() == typeof(ICollection<>)));
		}

		public static bool IsDictionary(this PropertyInfo propertyInfo)
		{
			Type t = propertyInfo.PropertyType;

			return (t.IsGenericType &&
					  (t.GetGenericTypeDefinition() == typeof(Dictionary<,>) || t.GetGenericTypeDefinition() == typeof(IDictionary<,>)));
		}

	}
}
