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

        public void AddPerson(Person p);
        public void UpdatePerson(int id, Person p);
        public void DeletePerson(int id);
        public IEnumerable<Person> GetAllPersons();
        public Person GetPersonById(int id);
    }
    

}
