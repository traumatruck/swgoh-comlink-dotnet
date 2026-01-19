using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class LoanedUnitEraDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("expireTime")]
    public long? ExpireTime { get; set; }
}