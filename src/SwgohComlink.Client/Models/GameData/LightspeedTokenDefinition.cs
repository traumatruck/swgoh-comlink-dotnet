using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LightspeedTokenDefinition
{
    [JsonPropertyName("id")] public string? Id { get; set; }

    [JsonPropertyName("unitUpgrade")] public UnitUpgrade UnitUpgrade { get; set; }

    [JsonPropertyName("includeTag")] public List<string?> IncludeTag { get; set; }

    [JsonPropertyName("excludeTag")] public List<string?> ExcludeTag { get; set; }

    [JsonPropertyName("releaseEraTag")] public string? ReleaseEraTag { get; set; }

    [JsonPropertyName("dismantlingReward")]
    public List<BucketItem> DismantlingReward { get; set; }

    [JsonPropertyName("nameKey")] public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")] public string? DescriptionKey { get; set; }

    [JsonPropertyName("tokenTierLargeSprite")]
    public string? TokenTierLargeSprite { get; set; }

    [JsonPropertyName("tokenTierSmallSprite")]
    public string? TokenTierSmallSprite { get; set; }

    [JsonPropertyName("tokenImage")] public string? TokenImage { get; set; }

    [JsonPropertyName("combatType")] public CombatType CombatType { get; set; }

    [JsonPropertyName("applicableUnitDefs")]
    public List<string?> ApplicableUnitDefs { get; set; }

    [JsonPropertyName("lookupMission")] public List<LookupMission> LookupMission { get; set; }

    [JsonPropertyName("raidLookup")] public List<LookupMission> RaidLookup { get; set; }

    [JsonPropertyName("actionLinkLookup")] public List<LookupActionLink> ActionLinkLookup { get; set; }

    [JsonPropertyName("raidImmediateLookup")]
    public List<LookupMission> RaidImmediateLookup { get; set; }
}