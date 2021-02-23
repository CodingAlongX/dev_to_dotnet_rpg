using System.Collections.Generic;
using dev_to_dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dev_to_dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static readonly List<Character> Characters = new()
        {
            new Character(),
            new Character {Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(Characters);
        }

        public IActionResult GetSingle()
        {
            return Ok(Characters[0]);
        }
    }
}