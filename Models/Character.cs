namespace PatrickGod_dotnetWebAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "ShineHead";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int UserId { get; set; }
        public User User { get; set; }
        public Weapon Weapon { get; set; }
        public E_RPG Class { get; set; } = E_RPG.Knight;
        public List<Skill> Skills { get; set; }

    }
}