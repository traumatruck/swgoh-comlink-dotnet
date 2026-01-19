using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestVisibility
{
    [JsonPropertyName("type")]
    public ConquestNodeType Type { get; set; }

    [JsonPropertyName("distance")]
    public int? Distance { get; set; }

}