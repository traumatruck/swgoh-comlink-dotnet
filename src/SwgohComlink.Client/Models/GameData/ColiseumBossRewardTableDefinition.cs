using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ColiseumBossRewardTableDefinition
{
    [JsonPropertyName("missionId")]
    public string? MissionId { get; set; }

    [JsonPropertyName("bossProgressionRewardTableId")]
    public string? BossProgressionRewardTableId { get; set; }

    [JsonPropertyName("bossProgressionRewardPreview")]
    public List<RankRewardPreview> BossProgressionRewardPreview { get; set; }
}