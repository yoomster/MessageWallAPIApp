using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        //// GET: api/<AddressController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] AddressDto address)
        {

        }
    }

    public record AddressDto (string AddressInfo, string Zipcode, string City);

}


