using System;
using System.Collections.Generic;
using System.Reflection;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class Reflector
	{
		internal static List<MethodInfo> GetMethods<T>(T t) where T : class
		{
			Type type = typeof (T);
			return
				new List<MethodInfo>(
					type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
		}

		internal static List<PropertyInfo> GetProperies<T>(T t) where T : class
		{
			Type type = typeof(T);
			return
				new List<PropertyInfo>(
					type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
		}

	}
}
