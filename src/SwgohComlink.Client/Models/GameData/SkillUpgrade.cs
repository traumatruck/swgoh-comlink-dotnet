using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SkillUpgrade
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

    [JsonPropertyName("unlocked")]
    public bool? Unlocked { get; set; }

}