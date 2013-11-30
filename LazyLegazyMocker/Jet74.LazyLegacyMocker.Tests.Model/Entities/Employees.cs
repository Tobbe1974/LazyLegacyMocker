namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public class Employees : IEmployees
	{
		public Person GetPersonById(int id)
		{
			return new Person
			       {
				       Id = id,
				       Address = new Address
				                 {
					                 Postalcode = "11111",
					                 Street = "Street X"
				                 },
			       };
		}
	}
}