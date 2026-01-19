using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryTournamentDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("iconPrefab")]
    public string? IconPrefab { get; set; }

    [JsonPropertyName("detailImage")]
    public string? DetailImage { get; set; }

    [JsonPropertyName("territoryCategory")]
    public string? TerritoryCategory { get; set; }

    [JsonPropertyName("minimapPrefab")]
    public string? MinimapPrefab { get; set; }

    [JsonPropertyName("roundCount")]
    public int? RoundCount { get; set; }

    [JsonPropertyName("roundTallyDuration")]
    public int? RoundTallyDuration { get; set; }

    [JsonPropertyName("matchmakingDuration")]
    public int? MatchmakingDuration { get; set; }

    [JsonPropertyName("dynamicDescription")]
    public List<DynamicDescription> DynamicDescription { get; set; }

    [JsonPropertyName("completeRankRewardPreview")]
    public List<RankRewardPreview> CompleteRankRewardPreview { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("localNotifications")]
    public List<TerritoryLocalNote> LocalNotifications { get; set; }

    [JsonPropertyName("restrictSetupDuringAttackPhase")]
    public bool? RestrictSetupDuringAttackPhase { get; set; }

    [JsonPropertyName("conflictZoneDefinition")]
    public List<TerritoryTournamentConflictZoneDefinition> ConflictZoneDefinition { get; set; }

    [JsonPropertyName("duelZoneDefinition")]
    public List<TerritoryTournamentDuelZoneDefinition> DuelZoneDefinition { get; set; }

    [JsonPropertyName("noJoinDuration")]
    public int? NoJoinDuration { get; set; }

    [JsonPropertyName("defensiveCharacterDeployWarningThreshold")]
    public double? DefensiveCharacterDeployWarningThreshold { get; set; }

    [JsonPropertyName("defensiveShipDeployWarningThreshold")]
    public double? DefensiveShipDeployWarningThreshold { get; set; }

    [JsonPropertyName("matchCount")]
    public int? MatchCount { get; set; }

    [JsonPropertyName("roundRewardPreview")]
    public List<RankRewardPreview> RoundRewardPreview { get; set; }

    [JsonPropertyName("seasonPointsPerBannerPercent")]
    public int? SeasonPointsPerBannerPercent { get; set; }

    [JsonPropertyName("roundSeasonRewardTableId")]
    public string? RoundSeasonRewardTableId { get; set; }

    [JsonPropertyName("minimumBannerRoundRewardThreshold")]
    public int? MinimumBannerRoundRewardThreshold { get; set; }

    [JsonPropertyName("minimumBannerEventRewardThreshold")]
    public int? MinimumBannerEventRewardThreshold { get; set; }

    [JsonPropertyName("savedSquadConfigId")]
    public string? SavedSquadConfigId { get; set; }
}