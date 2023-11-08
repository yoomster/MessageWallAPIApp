using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SayHiController : ControllerBase
    {
        // GET: api/<MessageWallController>
        [HttpGet]
        public string Get(PersonDto person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrWhiteSpace(person.LastName)) 
                return "Incorrect, fill both";

            return $"Hi {person.FirstName} {person.LastName}";
        }

        //// POST api/<MessageWallController>
        //[HttpPost]
        //public void Post([FromBody] PersonDto person)
        //{
        //}
    }

    //public record PersonDto([property: Required] string FirstName, string LastName);


}
