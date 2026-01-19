using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class MandatoryRosterUnit
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("slot")]
    public int? Slot { get; set; }

}