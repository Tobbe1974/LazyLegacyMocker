using Jet74.LazyLegacyMocker.Tests.Model.Entities;

namespace Jet74.LazyLegacyMocker.Tests.Model
{
	public class ModelFactory
	{
		private static IRecordableInterface _employees = new Recordable();
		public static IRecordableInterface IEmployees
		{
			get { return _employees; }
		}

	}
}