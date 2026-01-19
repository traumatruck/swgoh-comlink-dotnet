using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class QuestPreview
{
    [JsonPropertyName("challengeId")]
    public string? ChallengeId { get; set; }

    [JsonPropertyName("unlockTime")]
    public long? UnlockTime { get; set; }
}