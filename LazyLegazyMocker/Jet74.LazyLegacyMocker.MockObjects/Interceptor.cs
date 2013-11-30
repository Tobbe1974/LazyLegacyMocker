using System;
using Castle.DynamicProxy;
using Jet74.LazyLegacyMocker.MockObjects.Printers;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal class Interceptor<T, TS>
		where T : class
		where TS : IInterceptor, IObjectPrinter, new()
	{
		public T OriginalType { get; private set; }
		public T Proxy { get; private set; }
		public TS Printer { get; private set; }

		internal Interceptor(T t)
		{
			Initialize(t);	
		}

		internal Interceptor(T t, ITarget target)
		{
			Initialize(t);
			Printer.Target = target;
		}

		private void Initialize(T t)
		{
			OriginalType = t;
			var type = typeof(T);

			Printer = new TS();
			Printer.Target = new FileTarget();
			CreateProxy(t, type);
		}

		private void CreateProxy(T t, Type type)
		{
			var proxyGenerator = new ProxyGenerator();
			if (type.IsInterface)
			{
				Proxy = proxyGenerator.CreateInterfaceProxyWithTargetInterface(t, Printer);
				return;
			}

			if (type.IsClass)
			{
				if (type.IsSealed)
					throw new NotSupportedException("Sealed class not supported");

				Proxy = proxyGenerator.CreateClassProxyWithTarget(t, Printer);
				return;
			}
			throw new NotSupportedException("Type is not supported");
		}
	}
}
