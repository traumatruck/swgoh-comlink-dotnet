using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildBannerColorDef
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tintColor")]
    public string? TintColor { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }
}