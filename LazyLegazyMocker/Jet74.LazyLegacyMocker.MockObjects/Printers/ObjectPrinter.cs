using System.IO;
using Castle.DynamicProxy;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects.Printers
{
	internal class ObjectPrinter : IInterceptor, IObjectPrinter
	{
		public ITarget Target { get; private set; }

		public void Intercept(IInvocation invocation)
		{
			Target = MockObjectFactory.CreateTarget();

			invocation.Proceed();

			PrintObjectTree(invocation);
		}

		private void PrintObjectTree(IInvocation invocation)
		{
			var target = Target.GetWriter(invocation);
			target.WriteLine("1");
		}
	}
}