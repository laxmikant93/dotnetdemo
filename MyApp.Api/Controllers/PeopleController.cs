// MyApp.Api/Controllers/PeopleController.cs
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private static List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "John Doe" },
            new Person { Id = 2, Name = "Jane Smith" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return Ok(people);
        }
    }
}
