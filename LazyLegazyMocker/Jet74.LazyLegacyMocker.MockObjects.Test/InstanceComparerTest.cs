using System;
using System.Collections.Generic;
using System.Linq;
using Jet74.LazyLegacyMocker.Tests.Model.Entities;
using Xunit;

namespace Jet74.LazyLegacyMocker.MockObjects.Test
{
	public class InstanceComparerTest
	{
		[Fact]
		public void DetectsChangedPostalCode()
		{
			var address = new Address {Postalcode = "11111"};

			var result = InstanceComparer.GetPropertiesThatDiffer(address).ToList();
			
			Assert.True(result.Count() == 1);
			Assert.True(result[0].Name == "Postalcode");
		}

		[Fact]
		public void DetectsChangedId()
		{
			var address = new Address {Id = Guid.NewGuid()};

			var result = InstanceComparer.GetPropertiesThatDiffer(address).ToList();

			Assert.True(result.Count() == 1);
			Assert.True(result[0].Name == "Id");
		}

		[Fact]
		public void DetectsChangeInSubClass()
		{
			var person = new Person() {Address = new Address() {Postalcode = "1"}};

			var result = InstanceComparer.GetPropertiesThatDiffer(person).ToList();

			Assert.True(result.Count() == 1);
			Assert.True(result[0].Name == "Address");
		}

		[Fact]
		public void DetectsChangeArray()
		{
			var person = new Person();
			person.PhoneNumbers.Add(new PhoneNumber {Number = "1", Type = PhoneType.Home});

			var result = InstanceComparer.GetPropertiesThatDiffer(person).ToList();

			Assert.True(result.Count() == 1);
			Assert.True(result[0].Name == "PhoneNumbers");
		}

		[Fact]
		public void DeepItemShouldBeDetected()
		{
			var sc = new SomeClass();
			var sc2 = new SomeClass();
			sc.DeepList.Add(new List<List<int>>
				{
					new List<int> {1}
				});

			var result = Reflector.PropertyDiffer(sc, sc2, "DeepList");

			Assert.True(result);
		}

		[Fact]
		public void DetectChangeInDictionary()
		{
			var sc = new SomeClass();
			var sc2 = new SomeClass();
			sc.StringDictionary.Add("1", "1");

			var result = Reflector.PropertyDiffer(sc, sc2, "StringDictionary");

			Assert.True(result);
		}
	}
}
