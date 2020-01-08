using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.Models;


namespace WebApplication2.Data.mocks
{
    public class MockPersons : IPersons
    {
        private static List<Person> _persons = new List<Person>
                {
                    new Person {
                        id=1,
                        firstName="ADAM",
                        lastName="BOJIY",
                        age=33,
                        city="EDEM",
                        salary=5000
                    },

                    new Person {
                        id=2,
                        firstName="qqq",
                        lastName="rewrwe",
                        age=11,
                        city="hhhhh",
                        salary=6000
                    },

                    new Person {
                        id=3,
                        firstName="ivan",
                        lastName="ivanov",
                        age=99,
                        city="tver",
                        salary=11000
                    },

                    new Person {
                        id=4,
                        firstName="123",
                        lastName="qwerty",
                        age=50,
                        city="kompik",
                        salary=1
                    }
                };

        public IEnumerable<Person> Persons
        {
            get
            {
                return _persons;
            }
        }

        public void AddPerson(Person p)
        {
            _persons.Add(p);
        }

        public void DeletePerson(int id)
        {
            Person p = null;
            foreach (var item in _persons)
            {
                if (item.id == id)
                {
                    p = item;
                }
            }

            if (p != null)
            {
                _persons.Remove(p);
            }
            
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _persons;
        }

        public Person GetPersonById(int id)
        {
            foreach (var item in _persons)
            {

                if (item.id == id)
                {
                    return item;
                }  
            }
            return null;
        }

        public void UpdatePerson(int id, Person p)
        {
            foreach (var item in _persons)
            {
                if (item.id == id)
                {
                    item.lastName = p.lastName;
                    item.firstName = p.firstName;
                    item.city = p.city;
                    item.age = p.age;
                }
            }
        }
    }

}
