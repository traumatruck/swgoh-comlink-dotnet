using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryWarDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("roundCount")]
    public int? RoundCount { get; set; }

    [JsonPropertyName("iconPrefab")]
    public string? IconPrefab { get; set; }

    [JsonPropertyName("detailImage")]
    public string? DetailImage { get; set; }

    [JsonPropertyName("roundTallyDuration")]
    public int? RoundTallyDuration { get; set; }

    [JsonPropertyName("dynamicDescription")]
    public List<DynamicDescription> DynamicDescription { get; set; }

    [JsonPropertyName("firstRewardPreview")]
    public List<RankRewardPreview> FirstRewardPreview { get; set; }

    [JsonPropertyName("secondRewardPreview")]
    public List<RankRewardPreview> SecondRewardPreview { get; set; }

    [JsonPropertyName("matchmakingDuration")]
    public int? MatchmakingDuration { get; set; }

    [JsonPropertyName("setupDuration")]
    public int? SetupDuration { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("joinEventActionCapKey")]
    public string? JoinEventActionCapKey { get; set; }

    [JsonPropertyName("minParticipants")]
    public int? MinParticipants { get; set; }

    [JsonPropertyName("terrainPrefabName")]
    public string? TerrainPrefabName { get; set; }

    [JsonPropertyName("maxParticipants")]
    public int? MaxParticipants { get; set; }

    [JsonPropertyName("minScoreRequirement")]
    public long? MinScoreRequirement { get; set; }

    [JsonPropertyName("warConflictZoneDefinition")]
    public List<TerritoryWarConflictZoneDefinition> WarConflictZoneDefinition { get; set; }

    [JsonPropertyName("reconZoneDefinition")]
    public List<TerritoryReconZoneDefinition> ReconZoneDefinition { get; set; }

    [JsonPropertyName("statCategory")]
    public List<TerritoryMapStatCategory> StatCategory { get; set; }

    [JsonPropertyName("rewardStructure")]
    public TerritoryRewardStructure RewardStructure { get; set; }

    [JsonPropertyName("uniqueJoinId")]
    public string? UniqueJoinId { get; set; }

    [JsonPropertyName("hideLeaderboard")]
    public bool? HideLeaderboard { get; set; }

    [JsonPropertyName("localNotifications")]
    public List<TerritoryLocalNote> LocalNotifications { get; set; }

    [JsonPropertyName("minMemberLevelForReportingOpponent")]
    public GuildMemberLevel MinMemberLevelForReportingOpponent { get; set; }

    [JsonPropertyName("minMemberLevelForCommandingGuild")]
    public GuildMemberLevel MinMemberLevelForCommandingGuild { get; set; }

    [JsonPropertyName("commandNotificationCooldownDuration")]
    public int? CommandNotificationCooldownDuration { get; set; }

    [JsonPropertyName("mapTypeNameKey")]
    public string? MapTypeNameKey { get; set; }

    [JsonPropertyName("showTimerOnEvent")]
    public bool? ShowTimerOnEvent { get; set; }

    [JsonPropertyName("restrictSetupDuringAttackPhase")]
    public bool? RestrictSetupDuringAttackPhase { get; set; }

    [JsonPropertyName("defaultCharacterBattleEnvironments")]
    public List<Environment> DefaultCharacterBattleEnvironments { get; set; }

    [JsonPropertyName("defaultShipBattleEnvironments")]
    public List<Environment> DefaultShipBattleEnvironments { get; set; }

    [JsonPropertyName("minimapPrefab")]
    public string? MinimapPrefab { get; set; }

    [JsonPropertyName("defensiveCharacterDeployWarningThreshold")]
    public double? DefensiveCharacterDeployWarningThreshold { get; set; }

    [JsonPropertyName("defensiveShipDeployWarningThreshold")]
    public double? DefensiveShipDeployWarningThreshold { get; set; }

    [JsonPropertyName("leaderboardKey")]
    public string? LeaderboardKey { get; set; }

    [JsonPropertyName("minPlayerScoreRequirement")]
    public int? MinPlayerScoreRequirement { get; set; }

}