using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class EADPParameters
{
    [JsonPropertyName("eadpBaseUrl")]
    public string? EadpBaseUrl { get; set; }

    [JsonPropertyName("eaMobileClientId")]
    public string? EaMobileClientId { get; set; }

    [JsonPropertyName("eadpBaseUrlClient")]
    public string? EadpBaseUrlClient { get; set; }

    [JsonPropertyName("eadpAllowedCryptKey")]
    public string? EadpAllowedCryptKey { get; set; }

    [JsonPropertyName("eadpClientId")]
    public string? EadpClientId { get; set; }

    [JsonPropertyName("eadpWindowsEncryptSeed")]
    public string? EadpWindowsEncryptSeed { get; set; }

    [JsonPropertyName("eadpWindowsContentId")]
    public string? EadpWindowsContentId { get; set; }

    [JsonPropertyName("eadpWindowsMultiplayerId")]
    public string? EadpWindowsMultiplayerId { get; set; }

    [JsonPropertyName("eadpWindowsTitle")]
    public string? EadpWindowsTitle { get; set; }

    [JsonPropertyName("eadpWindowsCommerceGroupName")]
    public string? EadpWindowsCommerceGroupName { get; set; }

    [JsonPropertyName("eadpClientSecret")]
    public string? EadpClientSecret { get; set; }

    [JsonPropertyName("eadpEnv")]
    public string? EadpEnv { get; set; }

    [JsonPropertyName("eadpWindowsAchievementCode")]
    public string? EadpWindowsAchievementCode { get; set; }
}