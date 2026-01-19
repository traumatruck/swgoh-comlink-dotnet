using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class UnitTierDef
{
    [JsonPropertyName("tier")]
    public UnitTier Tier { get; set; }

    [JsonPropertyName("equipmentSet")]
    public List<string?> EquipmentSet { get; set; }

    [JsonPropertyName("baseStat")]
    public StatDef BaseStat { get; set; }

}