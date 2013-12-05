using System;
using Jet74.LazyLegacyMocker.Tests.Model;
using Xunit;

namespace Jet74.LazyLegacyMocker.MockObjects.Test
{
	public class PrinterTests : IDisposable
	{
		#region IDisposable

		public void Dispose()
		{
		}

		#endregion

		[Fact]
		public void PrinterDoesOnlyPrintChangedProperties()
		{
			var repo = GetMemfileRepository();
			repo.Properties.OnlyWriteNoneDefaultProperties = true;

			repo.AddObjectPrinter(ModelFactory.IEmployees);

			var emp = ModelFactory.IEmployees.GetPersonById(Guid.Empty);

		}


		private Repository GetMemfileRepository()
		{
			var repo = new Repository();
			repo.Properties.TargetType = Target.Memory;
			return repo;
		}
	}
}
