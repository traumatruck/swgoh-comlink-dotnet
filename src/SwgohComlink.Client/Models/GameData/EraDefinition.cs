using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EraDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("episode")]
    public List<string?> Episode { get; set; }

    [JsonPropertyName("eraShardCount")]
    public int? EraShardCount { get; set; }

    [JsonPropertyName("coliseum")]
    public ColiseumDefinition Coliseum { get; set; }

    [JsonPropertyName("eraUnitId")]
    public List<string?> EraUnitId { get; set; }

    [JsonPropertyName("expectedEraUnitCount")]
    public int? ExpectedEraUnitCount { get; set; }

    [JsonPropertyName("startTimeMs")]
    public long? StartTimeMs { get; set; }

    [JsonPropertyName("endTimeMs")]
    public long? EndTimeMs { get; set; }

    [JsonPropertyName("eraLevel")]
    public List<EraLevelDefinition> EraLevel { get; set; }

    [JsonPropertyName("totalEraLevelsRewardPreview")]
    public List<RankRewardPreview> TotalEraLevelsRewardPreview { get; set; }

    [JsonPropertyName("eraStartJourneyUnitTexture")]
    public string? EraStartJourneyUnitTexture { get; set; }

    [JsonPropertyName("eraStartMarqueeTexture")]
    public string? EraStartMarqueeTexture { get; set; }

    [JsonPropertyName("journeyUnit")]
    public string? JourneyUnit { get; set; }

    [JsonPropertyName("eraStartMarqueeTextureBackground")]
    public string? EraStartMarqueeTextureBackground { get; set; }

    [JsonPropertyName("eraFrameTable")]
    public string? EraFrameTable { get; set; }

    [JsonPropertyName("eraSummaryTexture")]
    public string? EraSummaryTexture { get; set; }

    [JsonPropertyName("eraSummaryTextureBackground")]
    public string? EraSummaryTextureBackground { get; set; }

    [JsonPropertyName("loanedUnit")]
    public List<LoanedUnitEraDefinition> LoanedUnit { get; set; }

    [JsonPropertyName("startingLoanedUnitEraLevel")]
    public int? StartingLoanedUnitEraLevel { get; set; }

    [JsonPropertyName("maxLoanedUnitEraLevel")]
    public int? MaxLoanedUnitEraLevel { get; set; }

    [JsonPropertyName("missingJourneyUnit")]
    public bool? MissingJourneyUnit { get; set; }
}