using System;

namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public class Address
	{
		public Address()
		{
			Id = Guid.Empty;
		}

		public Guid Id { get; set; }
		public string Street { get; set; }
		public string Postalcode { get; set; }
	}
}
