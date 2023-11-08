using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //// GET: api/<MessageWallController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] PersonDto person)
        {
            Console.WriteLine($"Hi {person.FirstName} {person.LastName}");
        }
    }
    public record PersonDto(string FirstName, string LastName);
}
