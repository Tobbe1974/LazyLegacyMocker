using System;

namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public class Recordable : IEmployees
	{
		public Person GetPersonById(Guid id)
		{
			return new Person
			       {
				       Id = Guid.NewGuid(),
				       Address = new Address
				                 {
					                 Postalcode = "11111",
					                 Street = "Street X"
				                 },
			       };
		}


		public Address GetAddressWithStreetChanged()
		{
			return new Address
			       {
				       Street = "A",
			       };
		}
	}
}