using System;
using System.Collections.Generic;
using Jet74.LazyLegacyMocker.MockObjects.Printers;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	public class Repository
	{
		public MockObjectProperties Properties { get; private set; }
		public List<String> AdditionalNamespaces { get; private set; }

		public Repository()
		{
			AdditionalNamespaces = new List<string>();
			Properties = new MockObjectProperties();
		}

		public T AddObjectPrinter<T>(T i) where T : class
		{
			InitFactory();
			return new Interceptor<T, ObjectPrinter>(i).Proxy;
		}

		private void InitFactory()
		{
			MockObjectFactory.Properties = Properties;
		}
	}
}
