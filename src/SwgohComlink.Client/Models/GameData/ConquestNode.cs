using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestNode
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public ConquestNodeType Type { get; set; }

    [JsonPropertyName("conquestMissionId")]
    public string? ConquestMissionId { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("enemyUnitPreview")]
    public List<CampaignMissionEnemyPreview> EnemyUnitPreview { get; set; }

    [JsonPropertyName("conquestCompletionNode")]
    public bool? ConquestCompletionNode { get; set; }

    [JsonPropertyName("unlockRequirementId")]
    public string? UnlockRequirementId { get; set; }

    [JsonPropertyName("style")]
    public ConquestNodeStyle Style { get; set; }

    [JsonPropertyName("finishSector")]
    public bool? FinishSector { get; set; }
}