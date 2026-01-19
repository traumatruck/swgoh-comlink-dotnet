using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class UnitBattleStat
{
    [JsonPropertyName("actionCountMin")]
    public int? ActionCountMin { get; set; }

    [JsonPropertyName("actionCountMax")]
    public int? ActionCountMax { get; set; }

    [JsonPropertyName("battleStat")]
    public StatDef BattleStat { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("equipment")]
    public List<EquipmentSlot> Equipment { get; set; }

    [JsonPropertyName("skill")]
    public List<Skill> Skill { get; set; }

    [JsonPropertyName("statMod")]
    public List<StatMod> StatMod { get; set; }

    [JsonPropertyName("unitDefId")]
    public string? UnitDefId { get; set; }

    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("unitRelicTier")]
    public RelicTier UnitRelicTier { get; set; }

    [JsonPropertyName("purchasedAbilityId")]
    public List<string?> PurchasedAbilityId { get; set; }

    [JsonPropertyName("overrideAllStatsMultiplier")]
    public double? OverrideAllStatsMultiplier { get; set; }

    [JsonPropertyName("overrideStatMultiplier")]
    public List<Stat> OverrideStatMultiplier { get; set; }

    [JsonPropertyName("skipStatsOverwrite")]
    public bool? SkipStatsOverwrite { get; set; }

    [JsonPropertyName("enableLeaderAbility")]
    public bool? EnableLeaderAbility { get; set; }

    [JsonPropertyName("threatLevelOverride")]
    public ThreatLevel ThreatLevelOverride { get; set; }

    [JsonPropertyName("overrideAllStatsTable")]
    public string? OverrideAllStatsTable { get; set; }

    [JsonPropertyName("eraLevel")]
    public int? EraLevel { get; set; }
}