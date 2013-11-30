using System.IO;
using Castle.DynamicProxy;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects.Printers
{
	internal class ObjectPrinter : IInterceptor, IObjectPrinter
	{
		public ITarget Target { get; set; }

		public void Intercept(IInvocation invocation)
		{
			invocation.Proceed();

			PrintObjectTree(invocation);
		}

		private void PrintObjectTree(IInvocation invocation)
		{
			using (Stream output = Target.GetTarget(invocation))
			{
				
			}
		}
	}
}