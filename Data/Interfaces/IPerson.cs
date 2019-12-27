using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data.interfaces
{
    public interface IPersons
    {
        public IEnumerable<Person> Persons { get; }
    }
}
