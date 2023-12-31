﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using NuGet.Protocol.Core.Types;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private readonly ILogger<MessageWallController> _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController>
        [HttpGet]
        public IEnumerable<string> Get([FromBody] MessageDto message)
        {
            List<string> output = new List<string>
            {
                "Hello World",
                "Bla bla "
            };

            if (string.IsNullOrWhiteSpace(message.Message) == false)
            {
                output.Add(message.Message);
            }
            return output;
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] string message)
        {
            _logger.LogInformation("Message was {Message}", message);
        }
    }
    
    public record MessageDto (string Message);
}
