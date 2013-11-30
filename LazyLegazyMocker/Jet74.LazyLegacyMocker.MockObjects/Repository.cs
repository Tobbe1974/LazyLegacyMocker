using System;
using System.Collections.Generic;

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
	}
}
