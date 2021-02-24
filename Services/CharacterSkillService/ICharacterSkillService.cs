using System.Threading.Tasks;
using dev_to_dotnet_rpg.Dtos.Character;
using dev_to_dotnet_rpg.Dtos.CharacterSkill;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}