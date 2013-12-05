using System;
using System.Diagnostics;
using Jet74.LazyLegacyMocker.MockObjects.Targets;
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
		public void CanWriteToString()
		{
			var repo = GetMemfileRepository();

			repo.Properties.OnlyWriteNoneDefaultProperties = true;
			using (var target = new StringTarget())
			{
				repo.Properties.SpecifiedTarget = target;

				var proxy = repo.AddObjectPrinter(ModelFactory.IEmployees);
				proxy.GetPersonById(Guid.NewGuid());

				string result = target.GetResult();
				Assert.True(result.Length > 0);
			}
		}


		private Repository GetMemfileRepository()
		{
			var repo = new Repository();
			repo.Properties.TargetType = Target.UserDefined;
			return repo;
		}
	}
}
