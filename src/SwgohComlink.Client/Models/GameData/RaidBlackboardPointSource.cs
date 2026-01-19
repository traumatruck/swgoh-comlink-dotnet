using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RaidBlackboardPointSource
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("locKey")]
    public string? LocKey { get; set; }

}