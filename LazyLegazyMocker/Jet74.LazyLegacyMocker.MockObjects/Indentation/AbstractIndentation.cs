using System;

namespace Jet74.LazyLegacyMocker.MockObjects.Indentation
{
	internal abstract class AbstractIndentation : IIndentation
	{
		protected int _indentation = 0;
		protected abstract char IndentationChar();

		public string GetIndentation()
		{
			return new string(IndentationChar(), _indentation * MockObjectFactory.Properties.IndentationSize);
		}

		public void Increase()
		{
			_indentation++;
		}

		public void Decrease()
		{
			if(_indentation == 0)
				throw new InvalidOperationException("Indentation is cannot become zero");

			_indentation--;
		}
	}
}
