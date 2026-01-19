using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryTournamentDuelZoneDefinition
{
    [JsonPropertyName("zoneDefinition")]
    public TerritoryZoneDefinition ZoneDefinition { get; set; }

    [JsonPropertyName("duelImage")]
    public string? DuelImage { get; set; }

    [JsonPropertyName("duelRequirement")]
    public string? DuelRequirement { get; set; }

    [JsonPropertyName("duelDetail")]
    public string? DuelDetail { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("defenseEntryCategoryAllowed")]
    public EntryCategoryAllowed DefenseEntryCategoryAllowed { get; set; }

    [JsonPropertyName("battleEnvironments")]
    public List<Environment> BattleEnvironments { get; set; }

    [JsonPropertyName("pointStructure")]
    public TerritoryWarPointStructure PointStructure { get; set; }

    [JsonPropertyName("saveSquadZoneNumber")]
    public int? SaveSquadZoneNumber { get; set; }

}