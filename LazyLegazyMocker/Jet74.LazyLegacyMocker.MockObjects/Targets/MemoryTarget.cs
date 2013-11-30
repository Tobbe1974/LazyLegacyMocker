using System.IO;
using Castle.DynamicProxy;

namespace Jet74.LazyLegacyMocker.MockObjects.Targets
{
	public class MemoryTarget : ITarget
	{
		private MemoryStream _stream = new MemoryStream();
		public Stream GetTarget(IInvocation invocation)
		{
			return _stream;
		}

		public StreamReader GetReader()
		{
			_stream.Position = 0;
			return new StreamReader(_stream);
		}
	}
}
