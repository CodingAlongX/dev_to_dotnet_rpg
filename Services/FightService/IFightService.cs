using System.Threading.Tasks;
using dev_to_dotnet_rpg.Dtos.Fight;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}