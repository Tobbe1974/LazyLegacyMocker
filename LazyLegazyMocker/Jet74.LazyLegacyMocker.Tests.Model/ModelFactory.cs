using Jet74.LazyLegacyMocker.Tests.Model.Entities;

namespace Jet74.LazyLegacyMocker.Tests.Model
{
	public class ModelFactory
	{
		private static readonly IEmployees _employees = new Recordable();
		public static IEmployees IEmployees
		{
			get { return _employees; }
		}

	}
}
