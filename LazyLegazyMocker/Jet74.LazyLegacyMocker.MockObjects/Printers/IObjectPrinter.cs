using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects.Printers
{
	interface IObjectPrinter
	{
		ITarget Target { get; set; }
	}
}
