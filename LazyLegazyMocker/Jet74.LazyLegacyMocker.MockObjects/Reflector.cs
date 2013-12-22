using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class Reflector
	{
		private const BindingFlags BINDING_FLAGS = (BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

		internal static List<MethodInfo> GetMethods<T>(T t) where T : class
		{
			return new List<MethodInfo>(typeof(T).GetMethods(BINDING_FLAGS));
		}

		internal static List<PropertyInfo> GetProperties<T>(T t) where T : class
		{
			return new List<PropertyInfo>(typeof(T).GetProperties(BINDING_FLAGS));
		}

		internal static bool PropertyDiffer<T>(T instance1, T instance2, string propertyName) where T : class
		{
			var property = typeof(T).GetProperty(propertyName, BINDING_FLAGS);
			var val1 = property.GetValue(instance1);
			var val2 = property.GetValue(instance2);
			
			if (property.PropertyType == typeof(Guid))
			{
				return !((Guid) val1).Equals((Guid) val2);
			}

			if (property.IsList() || property.IsCollection() || property.IsDictionary())
			{
				return !SequenceEqual((IEnumerable)val1, (IEnumerable)val2);
			}

			if (!property.PropertyType.IsAnsiClass)
				throw new Exception("Unknown type");


			return val1 != val2;
		}

		private static bool SequenceEqual<T>(T t1, T t2) where T : IEnumerable
		{
			var seq1 = ((T) t1).Cast<object>();
			var seq2 = ((T) t2).Cast<object>();

			return seq1.SequenceEqual(seq2);
		}
	}
}
