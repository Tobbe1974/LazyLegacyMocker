using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.oRec.Tests.Model
{
    public class ModelFactory
    {
        private static IEmployees _employees = new Employees();
        public static IEmployees IEmployees
        {
            get
            {
                return _employees;
            }
        }
    }
}
