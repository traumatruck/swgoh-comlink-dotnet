using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CampaignNodeEncounter
{
    [JsonPropertyName("encounterCinematics")]
    public List<CampaignCinematic> EncounterCinematics { get; set; }

    [JsonPropertyName("environment")]
    public List<Environment> Environment { get; set; }

    [JsonPropertyName("encounterMessage")]
    public List<ContextualMessageGroup> EncounterMessage { get; set; }

    [JsonPropertyName("audioKey")]
    public string? AudioKey { get; set; }

    [JsonPropertyName("allowChanceMechanics")]
    public bool? AllowChanceMechanics { get; set; }

    [JsonPropertyName("firstTimeEncounterMessage")]
    public List<ContextualMessageGroup> FirstTimeEncounterMessage { get; set; }

    [JsonPropertyName("encounterIcon")]
    public string? EncounterIcon { get; set; }

    [JsonPropertyName("encounterDescKey")]
    public string? EncounterDescKey { get; set; }

    [JsonPropertyName("encounterIconPosition")]
    public int? EncounterIconPosition { get; set; }

    [JsonPropertyName("raidProgressColor")]
    public ColorType RaidProgressColor { get; set; }

    [JsonPropertyName("maxDeployedSquadSize")]
    public int? MaxDeployedSquadSize { get; set; }

    [JsonPropertyName("environmentCollectionId")]
    public string? EnvironmentCollectionId { get; set; }

    [JsonPropertyName("encounterId")]
    public string? EncounterId { get; set; }

    [JsonPropertyName("encounterDurationLimit")]
    public long? EncounterDurationLimit { get; set; }

    [JsonPropertyName("scoreToComplete")]
    public long? ScoreToComplete { get; set; }

    [JsonPropertyName("detailDescKey")]
    public string? DetailDescKey { get; set; }

    [JsonPropertyName("pointsToComplete")]
    public long? PointsToComplete { get; set; }

    [JsonPropertyName("audioVictoryKey")]
    public string? AudioVictoryKey { get; set; }

    [JsonPropertyName("displayableEnemyId")]
    public List<string?> DisplayableEnemyId { get; set; }

    [JsonPropertyName("displayableGrantedAbility")]
    public List<string?> DisplayableGrantedAbility { get; set; }
}