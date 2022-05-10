using System.Text.Json.Serialization;

namespace PatrickGod_dotnetWebAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum E_RPG
    {
        Knight,
        Mage,
        Cleric,
        Warlock,
        Hunter,
        Druid
    }
}