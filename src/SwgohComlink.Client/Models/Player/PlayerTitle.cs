using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class PlayerTitle
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

}