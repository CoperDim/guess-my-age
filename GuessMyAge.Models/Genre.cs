using System.Text.Json.Serialization;

namespace GuessMyAge.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Genre
    {
        Man,
        Woman
    }
}
