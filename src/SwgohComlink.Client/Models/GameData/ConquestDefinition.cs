using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ConquestDefinition
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameKey")]
    public string? NameKey { get; set; }

    [JsonPropertyName("descriptionKey")]
    public string? DescriptionKey { get; set; }

    [JsonPropertyName("conquestDifficulty")]
    public List<ConquestDifficulty> ConquestDifficulty { get; set; }

    [JsonPropertyName("staminaStatAllowlist")]
    public string? StaminaStatAllowlist { get; set; }

    [JsonPropertyName("consumableDetail")]
    public List<ConsumableDetails> ConsumableDetail { get; set; }

    [JsonPropertyName("visibility")]
    public List<ConquestVisibility> Visibility { get; set; }

    [JsonPropertyName("miscEntry")]
    public List<ConquestPurchasePassMiscTextEntry> MiscEntry { get; set; }

}