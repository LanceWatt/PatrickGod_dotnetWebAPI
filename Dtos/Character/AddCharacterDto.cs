using PatrickGod_dotnetWebAPI.Models;

namespace PatrickGod_dotnetWebAPI.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "ShineHead";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public E_RPG Class { get; set; } = E_RPG.Knight;
    }
}