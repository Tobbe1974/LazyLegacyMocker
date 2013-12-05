using Jet74.LazyLegacyMocker.MockObjects.Printers;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	public class Repository
	{
		public MockObjectProperties Properties { get; private set; }

		public Repository()
		{
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
