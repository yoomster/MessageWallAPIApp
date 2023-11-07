using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SayHiController : ControllerBase
    {
        // GET: api/<MessageWallController>
        [HttpGet]
        public string Get([FromBody] PersonDto person)
        {

            if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrWhiteSpace(person.LastName))
                return "incorrect, fill both!";
            
            return $"Hi {person.FirstName} {person.LastName}";
        }
    }

    public record PersonDto (string FirstName, string LastName);
}
