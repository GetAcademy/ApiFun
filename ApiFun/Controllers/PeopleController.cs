using System.Collections.Generic;
using ApiFun.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return new Person[]
            {
                new Person{Id=1, Name="Per", Age=17},
                new Person{Id=2, Name="Pål", Age=18},
                new Person{Id=3, Name="Espen", Age=19},
            };
        }
    }
}
