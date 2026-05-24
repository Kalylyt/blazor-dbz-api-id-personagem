using System.Text.Json.Serialization;

namespace BlazorDragonBallApi.Models
{
    public class Character
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("originPlanet")]
        public OriginPlanet? OriginPlanet { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformation>? Transformations { get; set; }
    }

    public class OriginPlanet
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class Transformation
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}