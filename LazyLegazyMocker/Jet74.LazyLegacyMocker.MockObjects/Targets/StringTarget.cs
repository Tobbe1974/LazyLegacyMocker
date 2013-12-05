using System;
using System.IO;
using Castle.DynamicProxy;

namespace Jet74.LazyLegacyMocker.MockObjects.Targets
{
	public class StringTarget : ITarget, IDisposable
	{
		private readonly MemoryStream _stream;
		private readonly StreamWriter _writer;

		public StringTarget()
		{
			_stream = new MemoryStream();
			_writer = new StreamWriter(_stream);
		}

		public StreamWriter GetWriter(IInvocation invocation)
		{
			return _writer;
		}

		public string GetResult()
		{
			_writer.Flush();
			_stream.Position = 0;
			return new StreamReader(_stream).ReadToEnd();
		}

		public void Dispose()
		{
			_stream.Dispose();
			_writer.Dispose();
		}
	}
}
