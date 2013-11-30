using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class InstanceComparer
	{
		internal IEnumerable<PropertyInfo> GetPropertiesThatDiffer<T>(T instance) where T : class, new()
		{
			var def = (T) Activator.CreateInstance(typeof (T));
			var properies = Reflector.GetProperies(instance);

			return properies.Where(p => Reflector.PropertyDiffer(def, instance, p.Name));
		}

	}
}
