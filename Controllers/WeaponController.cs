using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PatrickGod_dotnetWebAPI.Dtos.Character;
using PatrickGod_dotnetWebAPI.Dtos.Weapon;
using PatrickGod_dotnetWebAPI.Models;
using PatrickGod_dotnetWebAPI.Services.WeaponService;

namespace PatrickGod_dotnetWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }




    }
}