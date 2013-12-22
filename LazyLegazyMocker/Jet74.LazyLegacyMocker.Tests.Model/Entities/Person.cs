using System;
using System.Collections.Generic;

namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public class Person
	{

		public Person()
		{
			PhoneNumbers = new List<PhoneNumber>();
		}

		public Guid Id { get; set; }
		public Address Address { get; set; }
		public List<PhoneNumber> PhoneNumbers { get; private set; }
	}
}
