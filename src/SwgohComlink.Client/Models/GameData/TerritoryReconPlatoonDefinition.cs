using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryReconPlatoonDefinition
{
    [JsonPropertyName("id")] public string? Id { get; set; }

    [JsonPropertyName("nameKey")] public string? NameKey { get; set; }

    [JsonPropertyName("squad")] public List<TerritoryReconSquadDefinition> Squad { get; set; }

    [JsonPropertyName("reward")] public TerritoryReward Reward { get; set; }
}