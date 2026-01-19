using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryStrikeZoneDefinition
{
    [JsonPropertyName("campaignElementIdentifier")]
    public CampaignElementIdentifier CampaignElementIdentifier { get; set; }

    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("encounterRewardTableId")]
    public string? EncounterRewardTableId { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }
}