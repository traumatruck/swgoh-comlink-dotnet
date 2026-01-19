using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryBattleDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("roundDuration")]
    public long? RoundDuration { get; set; }

    [JsonPropertyName("roundCount")]
    public int? RoundCount { get; set; }

    [JsonPropertyName("conflictZoneDefinition")]
    public List<TerritoryBattleConflictZoneDefinition> ConflictZoneDefinition { get; set; }

    [JsonPropertyName("strikeZoneDefinition")]
    public List<TerritoryStrikeZoneDefinition> StrikeZoneDefinition { get; set; }

    [JsonPropertyName("reconZoneDefinition")]
    public List<TerritoryReconZoneDefinition> ReconZoneDefinition { get; set; }

    [JsonPropertyName("iconPrefab")]
    public string? IconPrefab { get; set; }

    [JsonPropertyName("rankRewardPreview")]
    public List<RankRewardPreview> RankRewardPreview { get; set; }

    [JsonPropertyName("detailImage")]
    public string? DetailImage { get; set; }

    [JsonPropertyName("dynamicDescription")]
    public List<DynamicDescription> DynamicDescription { get; set; }

    [JsonPropertyName("covertZoneDefinition")]
    public List<TerritoryCovertZoneDefinition> CovertZoneDefinition { get; set; }

    [JsonPropertyName("statCategory")]
    public List<TerritoryMapStatCategory> StatCategory { get; set; }

    [JsonPropertyName("territoryCategory")]
    public string? TerritoryCategory { get; set; }

    [JsonPropertyName("roundTallyDuration")]
    public int? RoundTallyDuration { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("localNotifications")]
    public List<TerritoryLocalNote> LocalNotifications { get; set; }

    [JsonPropertyName("minMemberLevelForCommandingGuild")]
    public GuildMemberLevel MinMemberLevelForCommandingGuild { get; set; }

    [JsonPropertyName("commandNotificationCooldownDuration")]
    public int? CommandNotificationCooldownDuration { get; set; }

    [JsonPropertyName("minimapPrefab")]
    public string? MinimapPrefab { get; set; }

    [JsonPropertyName("searchImage")]
    public string? SearchImage { get; set; }

    [JsonPropertyName("infoImage")]
    public string? InfoImage { get; set; }

    [JsonPropertyName("forceAlignment")]
    public ForceAlignment ForceAlignment { get; set; }

    [JsonPropertyName("environmentNameKey")]
    public string? EnvironmentNameKey { get; set; }

    [JsonPropertyName("environmentPrefab")]
    public string? EnvironmentPrefab { get; set; }

    [JsonPropertyName("territoryBattleVersion_3")]
    public bool? TerritoryBattleVersion3 { get; set; }

    [JsonPropertyName("bonusZoneDefinition")]
    public List<TerritoryBonusZoneDefinition> BonusZoneDefinition { get; set; }
}