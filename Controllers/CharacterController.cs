using System.Collections.Generic;
using System.Linq;
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
            new Character {Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(Characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(Characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);

            return Ok(Characters);
        }
    }
}