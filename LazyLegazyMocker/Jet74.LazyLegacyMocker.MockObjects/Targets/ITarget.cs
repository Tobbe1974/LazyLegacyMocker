using System.IO;
using System.Security.Cryptography.X509Certificates;
using Castle.DynamicProxy;

namespace Jet74.LazyLegacyMocker.MockObjects.Targets
{
	public interface ITarget
	{
		StreamWriter GetWriter(IInvocation invocation);
	}
}
