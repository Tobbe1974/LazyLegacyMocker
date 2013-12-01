namespace Jet74.LazyLegacyMocker.MockObjects.Indentation
{
	internal class Tabs : AbstractIndentation
	{
		protected override char IndentationChar()
		{
			return '\t';
		}
	}
}
