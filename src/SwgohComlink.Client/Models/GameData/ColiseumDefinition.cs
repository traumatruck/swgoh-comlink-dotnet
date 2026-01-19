using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ColiseumDefinition
{
    [JsonPropertyName("dailyRankRewardTableId")]
    public string? DailyRankRewardTableId { get; set; }

    [JsonPropertyName("bossDefinition")]
    public List<ColiseumBossDefinition> BossDefinition { get; set; }

    [JsonPropertyName("dailyRankRewardPreview")]
    public List<RankRewardPreview> DailyRankRewardPreview { get; set; }

    [JsonPropertyName("bossSchedule")]
    public List<ColiseumBossSchedule> BossSchedule { get; set; }

}