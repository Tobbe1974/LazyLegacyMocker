using System;
using Jet74.LazyLegacyMocker.Tests.Model.Entities;

namespace Jet74.LazyLegacyMocker.Tests.Model
{
	public interface IEmployees
	{
		Person GetPersonById(Guid id);
		Address GetAddressWithStreetChanged();
	}
}
