using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ColiseumBossSchedule
{
    [JsonPropertyName("bossIndex")]
    public int? BossIndex { get; set; }

    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    [JsonPropertyName("reviewTime")]
    public long? ReviewTime { get; set; }

    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    [JsonPropertyName("eraDayIndex")]
    public int? EraDayIndex { get; set; }
}