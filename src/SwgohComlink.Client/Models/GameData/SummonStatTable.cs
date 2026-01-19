using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SummonStatTable
{
    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("statTable")]
    public string? StatTable { get; set; }

}