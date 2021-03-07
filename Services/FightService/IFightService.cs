using System.Collections.Generic;
using System.Threading.Tasks;
using dev_to_dotnet_rpg.Dtos.Fight;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
    }
}