using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class CampaignElementIdentifier
{
    [JsonPropertyName("campaignId")]
    public string? CampaignId { get; set; }

    [JsonPropertyName("campaignMapId")]
    public string? CampaignMapId { get; set; }

    [JsonPropertyName("campaignNodeId")]
    public string? CampaignNodeId { get; set; }

    [JsonPropertyName("campaignNodeDifficulty")]
    public CampaignNodeDifficulty CampaignNodeDifficulty { get; set; }

    [JsonPropertyName("campaignMissionId")]
    public string? CampaignMissionId { get; set; }

}