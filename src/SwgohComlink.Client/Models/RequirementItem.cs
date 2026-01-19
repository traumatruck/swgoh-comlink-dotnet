using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class RequirementItem
{
    [JsonPropertyName("type")]
    public RequirementType Type { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("value")]
    public int? Value { get; set; }

    [JsonPropertyName("locKey")]
    public string? LocKey { get; set; }

    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonPropertyName("rosterUnitType")]
    public RosterUnitType RosterUnitType { get; set; }
}