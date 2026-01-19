using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ColiseumBossDefinition
{
    [JsonPropertyName("identifier")]
    public CampaignElementIdentifier Identifier { get; set; }

    [JsonPropertyName("unitPrefab")]
    public string? UnitPrefab { get; set; }

    [JsonPropertyName("environmentPrefab")]
    public string? EnvironmentPrefab { get; set; }

    [JsonPropertyName("bossRewardTable")]
    public List<ColiseumBossRewardTableDefinition> BossRewardTable { get; set; }

    [JsonPropertyName("cantinaPrefab")]
    public string? CantinaPrefab { get; set; }

    [JsonPropertyName("bossHighlightText")]
    public string? BossHighlightText { get; set; }

    [JsonPropertyName("shortIntroCinematic")]
    public string? ShortIntroCinematic { get; set; }

    [JsonPropertyName("mediumIntroCinematic")]
    public string? MediumIntroCinematic { get; set; }

    [JsonPropertyName("longIntroCinematic")]
    public string? LongIntroCinematic { get; set; }
}