using AutoMapper;
using PatrickGod_dotnetWebAPI.Dtos.Character;
using PatrickGod_dotnetWebAPI.Dtos.Skill;
using PatrickGod_dotnetWebAPI.Dtos.Weapon;
using PatrickGod_dotnetWebAPI.Models;

namespace PatrickGod_dotnetWebAPI
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}