using System.Collections.Generic;
using System.Threading.Tasks;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacter();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character character);
    }
}