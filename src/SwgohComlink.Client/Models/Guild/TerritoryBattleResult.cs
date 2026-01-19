using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryBattleResult
{
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("totalStars")]
    public long? TotalStars { get; set; }

    [JsonPropertyName("finalStat")]
    public List<TerritoryMapStat> FinalStat { get; set; }

}