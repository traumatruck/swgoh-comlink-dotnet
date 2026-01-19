using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaidSim
{
    [JsonPropertyName("simReward")]
    public List<BucketItem> SimReward { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("requirementId")]
    public string? RequirementId { get; set; }

}