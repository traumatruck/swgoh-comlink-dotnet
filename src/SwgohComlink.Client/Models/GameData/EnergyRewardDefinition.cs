using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EnergyRewardDefinition
{
    [JsonPropertyName("energyType")]
    public EnergyType EnergyType { get; set; }

    [JsonPropertyName("instance")]
    public List<EnergyRewardInstance> Instance { get; set; }

    [JsonPropertyName("claimableTitleKey")]
    public string? ClaimableTitleKey { get; set; }

    [JsonPropertyName("claimableDescKey")]
    public string? ClaimableDescKey { get; set; }

    [JsonPropertyName("upcomingTitleKey")]
    public string? UpcomingTitleKey { get; set; }

    [JsonPropertyName("upcomingDescKey")]
    public string? UpcomingDescKey { get; set; }

    [JsonPropertyName("showRequirement")]
    public Requirement ShowRequirement { get; set; }
}