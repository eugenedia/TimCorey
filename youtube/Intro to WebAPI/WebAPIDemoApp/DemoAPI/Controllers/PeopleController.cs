using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give your all information about my peeps.
    /// </summary>
    public class PeopleController : ApiController
    {
        static List<Person>  people = new List<Person>();
         static PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName = "Eugene", LastName = "Petrov" });
            people.Add(new Person { Id = 2, FirstName = "Dmitrii", LastName = "Mendeleev" });
            people.Add(new Person { Id = 3, FirstName = "John", LastName = "Seagul" });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">The unique identifier for this person.</param>
        /// <param name="Age">We want to know how old they are.</param>
        /// <returns>A list of first names...duh</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{Age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int Age)
        {
            List<string> output = new List<string>();

            foreach(var person in people)
            {
                output.Add(person.FirstName);
            }

            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
