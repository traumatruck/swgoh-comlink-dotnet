using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Position
{
    [JsonPropertyName("x")]
    public string? X { get; set; }

    [JsonPropertyName("y")]
    public string? Y { get; set; }

    [JsonPropertyName("z")]
    public string? Z { get; set; }

}