using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Skill
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

}