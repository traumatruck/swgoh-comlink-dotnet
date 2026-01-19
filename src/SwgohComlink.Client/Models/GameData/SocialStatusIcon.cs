using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SocialStatusIcon
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("texture")]
    public string? Texture { get; set; }
}