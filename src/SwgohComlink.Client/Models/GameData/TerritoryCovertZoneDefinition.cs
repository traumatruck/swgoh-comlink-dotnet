using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryCovertZoneDefinition
{
    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("victoryReward")]
    public List<BucketItem> VictoryReward { get; set; }

    [JsonPropertyName("disableRewardOnMap")]
    public bool? DisableRewardOnMap { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }
}