using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class TerritoryZoneDefinition
{
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    [JsonPropertyName("prefabName")]
    public string? PrefabName { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("linkedConflictId")]
    public string? LinkedConflictId { get; set; }

    [JsonPropertyName("maxAttemptsAllowed")]
    public int? MaxAttemptsAllowed { get; set; }

    [JsonPropertyName("unlockRequirement")]
    public Requirement UnlockRequirement { get; set; }

    [JsonPropertyName("maxUnitCountPerPlayer")]
    public int? MaxUnitCountPerPlayer { get; set; }

    [JsonPropertyName("grantedAbilities")]
    public List<MissionGrantedAbility> GrantedAbilities { get; set; }

    [JsonPropertyName("detailViewIconOverrideName")]
    public string? DetailViewIconOverrideName { get; set; }

    [JsonPropertyName("mapIconOverrideName")]
    public string? MapIconOverrideName { get; set; }

}