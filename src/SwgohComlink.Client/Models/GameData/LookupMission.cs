using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LookupMission
{
    [JsonPropertyName("missionIdentifier")]
    public CampaignElementIdentifier MissionIdentifier { get; set; }

    [JsonPropertyName("requirementId")]
    public List<string?> RequirementId { get; set; }
}