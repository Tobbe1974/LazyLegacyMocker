using System;
using Jet74.LazyLegacyMocker.MockObjects.Targets;

namespace Jet74.LazyLegacyMocker.MockObjects
{
	internal static class MockObjectFactory
	{
		public static MockObjectProperties Properties { get; set; }

		public static ITarget CreateTarget()
		{
			switch (Properties.TargetType)
			{
				case Target.File:
					return new FileTarget();
				case Target.Memory:
					return new MemoryTarget();
			}

			throw new ArgumentException("Unknown target type");
		}
	}
}