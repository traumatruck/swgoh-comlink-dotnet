using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DailyLoginRewardDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("defaultBucketItem")]
    public BucketItem DefaultBucketItem { get; set; }

    [JsonPropertyName("reward")]
    public List<BucketItem> Reward { get; set; }

    [JsonPropertyName("monthly")]
    public bool? Monthly { get; set; }

    [JsonPropertyName("missedConsequence")]
    public CalendarMissedConsequence MissedConsequence { get; set; }

    [JsonPropertyName("completionBehavior")]
    public CalendarCompletionBehavior CompletionBehavior { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("delayFirstReward")]
    public bool? DelayFirstReward { get; set; }

    [JsonPropertyName("catchUp")]
    public CalendarCatchUp CatchUp { get; set; }

    [JsonPropertyName("expiry")]
    public CalendarExpiry Expiry { get; set; }

    [JsonPropertyName("visualOverride")]
    public CalendarVisuals VisualOverride { get; set; }

    [JsonPropertyName("catchupCost")]
    public BucketItem CatchupCost { get; set; }
}