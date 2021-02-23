using dev_to_dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dev_to_dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static readonly Character Knight = new();

        public IActionResult Get()
        {
            return Ok(Knight);
        }
    }
}