using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.oRec.Tests.Model
{
    public class Employees : IEmployees
    {
        public Person GetPersonById(int id)
        {
            return new Person();
        }
    }
}
