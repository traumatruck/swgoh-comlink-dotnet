using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetMetaDataResponse
{
    [JsonPropertyName("config")]
    public List<ConfigEntry> Config { get; set; }

    [JsonPropertyName("assetVersion")]
    public int? AssetVersion { get; set; }

    [JsonPropertyName("assetSubpath")]
    public string? AssetSubpath { get; set; }

    [JsonPropertyName("texFormat")]
    public string? TexFormat { get; set; }

    [JsonPropertyName("serverTimestamp")]
    public long? ServerTimestamp { get; set; }

    [JsonPropertyName("debugMode")]
    public bool? DebugMode { get; set; }

    [JsonPropertyName("latestLocalizationBundleVersion")]
    public string? LatestLocalizationBundleVersion { get; set; }

    [JsonPropertyName("latestGamedataVersion")]
    public string? LatestGamedataVersion { get; set; }

    [JsonPropertyName("resourceCacheMemoryLimit")]
    public int? ResourceCacheMemoryLimit { get; set; }

    [JsonPropertyName("gamedataRevision")]
    public string? GamedataRevision { get; set; }

    [JsonPropertyName("monoExtraMemoryAllocationDivisor")]
    public int? MonoExtraMemoryAllocationDivisor { get; set; }

    [JsonPropertyName("qualityData")]
    public ClientQualityData QualityData { get; set; }

    [JsonPropertyName("latestLocalizationRevision")]
    public string? LatestLocalizationRevision { get; set; }

    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    [JsonPropertyName("clientCache")]
    public List<ClientCacheEntry> ClientCache { get; set; }

    [JsonPropertyName("eadpParameters")]
    public EADPParameters EadpParameters { get; set; }

    [JsonPropertyName("latestSegmentedContentVersion")]
    public string? LatestSegmentedContentVersion { get; set; }

}