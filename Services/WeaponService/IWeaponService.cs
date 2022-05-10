using PatrickGod_dotnetWebAPI.Dtos.Character;
using PatrickGod_dotnetWebAPI.Dtos.Weapon;
using PatrickGod_dotnetWebAPI.Models;

namespace PatrickGod_dotnetWebAPI.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}