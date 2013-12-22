using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.LazyLegacyMocker.Tests.Model.Entities
{
	public enum PhoneType
	{
		Mobile = 0,
		Home = 1,
		Work = 2,
	}

	public class PhoneNumber
	{
		public PhoneType Type { get; set; }
		public string Number { get; set; }
	}
}
