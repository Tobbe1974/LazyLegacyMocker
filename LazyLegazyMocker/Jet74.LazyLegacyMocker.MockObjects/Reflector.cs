using System.Collections.Generic;
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

		internal static List<PropertyInfo> GetProperies<T>(T t) where T : class
		{
			return new List<PropertyInfo>(typeof(T).GetProperties(BINDING_FLAGS));
		}

		internal static bool PropertyDiffer<T>(T instance1, T instance2, string propertyName) where T : class
		{
			var property = typeof(T).GetProperty(propertyName, BINDING_FLAGS);
			return property.GetValue(instance1) != property.GetValue(instance2);
		}

	}
}
