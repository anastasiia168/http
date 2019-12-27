using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersons _Persons;

        public PersonsController(IPersons iPersons)
        {
            _Persons = iPersons;
        }

        public IActionResult List()
        {
            IEnumerable<Person> Persons = _Persons.Persons;
            return View(Persons);
        }
    }
}