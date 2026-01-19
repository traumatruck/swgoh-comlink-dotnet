using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronSet
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("expirationTimeMs")]
    public long? ExpirationTimeMs { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("tier")]
    public List<DatacronSetTier> Tier { get; set; }

    [JsonPropertyName("detailPrefab")]
    public string? DetailPrefab { get; set; }

    [JsonPropertyName("setMaterial")]
    public List<DatacronSetMaterial> SetMaterial { get; set; }

    [JsonPropertyName("focusedTier")]
    public List<DatacronSetTier> FocusedTier { get; set; }
}