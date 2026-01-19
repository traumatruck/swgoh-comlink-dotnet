using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ChallengeStyle
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("buttonIcon")]
    public string? ButtonIcon { get; set; }

    [JsonPropertyName("characterIcon")]
    public string? CharacterIcon { get; set; }

    [JsonPropertyName("characterNameKey")]
    public string? CharacterNameKey { get; set; }

    [JsonPropertyName("characterRewardIcon")]
    public string? CharacterRewardIcon { get; set; }

    [JsonPropertyName("completeKey")]
    public string? CompleteKey { get; set; }

    [JsonPropertyName("audioKey")]
    public string? AudioKey { get; set; }

    [JsonPropertyName("questTitleKey")]
    public string? QuestTitleKey { get; set; }

}