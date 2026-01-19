using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ChallengeTask
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("actionLinkDef")]
    public ActionLink ActionLinkDef { get; set; }

    [JsonPropertyName("hideToast")]
    public bool? HideToast { get; set; }
}