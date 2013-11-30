using System;
using System.Collections.Generic;
using Jet74.LazyLegacyMocker.MockObjects.Printers;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	public class Repository
	{
		public MockObjectProperties Properties { get; set; }
		public List<String> AdditionalNamespaces { get; private set; }

		public Repository()
		{
			AdditionalNamespaces = new List<string>();
		}

		public T AddObjectPrinter<T>(T i) where T : class
		{
			return new Interceptor<T, ObjectPrinter>(i).Proxy;
		}

		public T AddObjectPrinter<T>(T i, ITarget target) where T : class
		{
			return new Interceptor<T, ObjectPrinter>(i, target).Proxy;
		}
	}
}
