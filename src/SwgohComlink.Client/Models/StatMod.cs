using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class StatMod
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("definitionId")]
    public string? DefinitionId { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("tier")]
    public StatModTier Tier { get; set; }

    [JsonPropertyName("sellValue")]
    public CurrencyItem SellValue { get; set; }

    [JsonPropertyName("removeCost")]
    public CurrencyItem RemoveCost { get; set; }

    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    [JsonPropertyName("primaryStat")]
    public StatModStat PrimaryStat { get; set; }

    [JsonPropertyName("secondaryStat")]
    public List<StatModStat> SecondaryStat { get; set; }

    [JsonPropertyName("xp")]
    public int? Xp { get; set; }

    [JsonPropertyName("levelCost")]
    public CurrencyItem LevelCost { get; set; }

    [JsonPropertyName("bonusQuantity")]
    public int? BonusQuantity { get; set; }

    [JsonPropertyName("convertedItem")]
    public BucketItem ConvertedItem { get; set; }

    [JsonPropertyName("rerolledCount")]
    public int? RerolledCount { get; set; }

}