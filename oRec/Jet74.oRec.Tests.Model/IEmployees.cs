using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet74.oRec.Tests.Model
{
    public interface IEmployees
    {
        Person GetPersonById(int id);
    }
}
