using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class ModifierLocation
{
    [JsonPropertyName("type")]
    public ModifierLocationType Type { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

}