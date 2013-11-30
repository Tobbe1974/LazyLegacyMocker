using Jet74.LazyLegacyMocker.Tests.Model.Entities;

namespace Jet74.LazyLegacyMocker.Tests.Model
{
	public class ModelFactory
	{
		private static IEmployees _employees = new Employees();

		public static IEmployees IEmployees
		{
			get { return _employees; }
		}
	}
}