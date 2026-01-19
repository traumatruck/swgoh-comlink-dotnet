using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class DatacronBattleStat
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("setId")]
    public int? SetId { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("tag")]
    public List<string?> Tag { get; set; }

    [JsonPropertyName("affix")]
    public List<DatacronAffix> Affix { get; set; }

    [JsonPropertyName("highestTierApplied")]
    public int? HighestTierApplied { get; set; }
}