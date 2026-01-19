using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class DatacronAffixTemplateSet
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("affix")]
    public List<DatacronAffixTemplate> Affix { get; set; }
}