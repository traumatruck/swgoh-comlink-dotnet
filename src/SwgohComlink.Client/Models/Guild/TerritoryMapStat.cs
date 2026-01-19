using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryMapStat
{
    [JsonPropertyName("mapStatId")]
    public string? MapStatId { get; set; }

    [JsonPropertyName("playerStat")]
    public List<TerritoryPlayerStat> PlayerStat { get; set; }
}