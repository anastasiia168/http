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
        public IEnumerable<Person> Persons
        {
            get
            {
                return new List<Person>
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
            }
        }
    }

}
