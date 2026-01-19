using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Relic
{
    [JsonPropertyName("currentTier")]
    public RelicTier CurrentTier { get; set; }
}