using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class ClassStructure
	{
		public Type T { get; set; }
		public List<PropertyInfo> PrimitiveProperties { get; set; }
		public List<ClassStructure> Children;
	}
}
