using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SocialStatusTitle
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("playerTitleId")]
    public string? PlayerTitleId { get; set; }
}