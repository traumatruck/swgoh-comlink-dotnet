using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class RaidModifier
{
    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("grantedAbility")]
    public List<MissionGrantedAbility> GrantedAbility { get; set; }

    [JsonPropertyName("scoreMultiplierUnscaled")]
    public long? ScoreMultiplierUnscaled { get; set; }

    [JsonPropertyName("requiredUnitTier")]
    public UnitTier RequiredUnitTier { get; set; }

    [JsonPropertyName("requiredRelicTier")]
    public RelicTier RequiredRelicTier { get; set; }

    [JsonPropertyName("abilityOverride")]
    public List<RaidAbilityOverride> AbilityOverride { get; set; }

    [JsonPropertyName("overrideRelicTier")]
    public RelicTier OverrideRelicTier { get; set; }

}