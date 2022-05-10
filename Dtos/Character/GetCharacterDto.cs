using PatrickGod_dotnetWebAPI.Dtos.Skill;
using PatrickGod_dotnetWebAPI.Dtos.Weapon;
using PatrickGod_dotnetWebAPI.Models;

namespace PatrickGod_dotnetWebAPI.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "ShineHead";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public E_RPG Class { get; set; } = E_RPG.Knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
    }
}