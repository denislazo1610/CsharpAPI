using System.Text.Json.Serialization;

namespace CsharpAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        knight = 1,
        Mage = 2,
        Cleric = 3

    }
}