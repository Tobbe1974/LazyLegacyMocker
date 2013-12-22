using System.Collections.Generic;

namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public class SomeClass
	{
		public SomeClass()
		{
			DeepList = new List<List<List<int>>>();
			StringDictionary = new Dictionary<string, string>();
		}
		public List<List<List<int>>> DeepList { get; private set; }
		public Dictionary<string, string> StringDictionary { get; private set; }
	}
}
