using System.Threading.Tasks;
using dev_to_dotnet_rpg.Dtos.Character;
using dev_to_dotnet_rpg.Dtos.Weapon;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}