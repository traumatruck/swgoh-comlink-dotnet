using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CalendarVisuals
{
    [JsonPropertyName("background")]
    public string? Background { get; set; }

    [JsonPropertyName("button")]
    public string? Button { get; set; }

}