using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Feat
{
    [JsonPropertyName("challengeId")]
    public string? ChallengeId { get; set; }

}