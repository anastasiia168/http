using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.mocks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api")]
    [ApiController]
    public class WebApiController : ControllerBase
    {

        private readonly IPersons _Persons;

        public WebApiController(IPersons iPersons)
        {
            _Persons = iPersons;
        }

        [Route("persons")]
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return _Persons.GetAllPersons();
        }

        [Route("persons/{id}")]
        [HttpGet]
        public Person Get(int id)
        {
          return  _Persons.GetPersonById(id);
        }
        [Route("person")]
        [HttpPost]
        public void Post([FromBody]Person item)
        {
            _Persons.AddPerson(item);
        }
        [Route("persons/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
             _Persons.DeletePerson(id);
        }

        [Route("persons/{id}")]
        [HttpPut]
        public void Put([FromBody]Person item,int id)
        {
            _Persons.UpdatePerson(id,item);
        }
    }

}