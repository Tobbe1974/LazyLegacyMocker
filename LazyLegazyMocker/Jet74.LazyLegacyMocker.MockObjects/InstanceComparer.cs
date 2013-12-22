using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class InstanceComparer
	{
		internal static IEnumerable<PropertyInfo> GetPropertiesThatDiffer<T>(T instance) where T : class, new()
		{
			var def = (T)Activator.CreateInstance(typeof(T));
			var properies = Reflector.GetProperties(instance);

#if DEBUG
			foreach (var propertyInfo in properies)
			{
				var differ = Reflector.PropertyDiffer(def, instance, propertyInfo.Name);
				Console.WriteLine("{0} Differs: {1} ", propertyInfo.Name, differ ? "YES" : "NO");
			}
#endif

			return properies.Where(p => Reflector.PropertyDiffer(def, instance, p.Name));
		}

		internal static ClassStructure BuildClassTree<T>(T instance) where T : class, new()
		{
			var current = new ClassStructure() { T = typeof(T) };
			var changedProperties = GetPropertiesThatDiffer(instance);
			foreach (var changedProperty in changedProperties)
			{
				if (changedProperty.IsPrimitive())
				{
					current.PrimitiveProperties.Add(changedProperty);
				}
				else if (changedProperty.IsList())
				{
					if (changedProperty.PropertyType.GetGenericArguments()[0].IsPrimitive)
					{

					}
				}
				else
				{
					// Recurse
					// current.Children.Add(BuildClassTree());

				}
			}

			return current;
		}

	}
}
