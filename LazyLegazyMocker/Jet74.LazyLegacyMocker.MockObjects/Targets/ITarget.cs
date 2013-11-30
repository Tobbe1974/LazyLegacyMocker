using System.IO;
using Castle.DynamicProxy;

namespace Jet74.LazyLegacyMocker.MockObjects.Targets
{
	public interface ITarget
	{
		Stream GetTarget(IInvocation invocation);
	}
}
