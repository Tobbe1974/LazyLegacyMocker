using System;
using Jet74.LazyLegacyMocker.Tests.Model;
using Xunit;

namespace Jet74.LazyLegacyMocker.InterfaceRecorder.Test
{
	public class PrinterTests : IDisposable
	{
		private Repository _repo;

		public PrinterTests()
		{
			_repo = new Repository();
		}

		#region IDisposable

		public void Dispose()
		{
		}

		#endregion

		[Fact]
		public void PrinterDoesIncluedNameSpace()
		{
		}
	}
}