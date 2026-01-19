using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class Datacron
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

    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    [JsonPropertyName("rerollIndex")]
    public int? RerollIndex { get; set; }

    [JsonPropertyName("rerollOption")]
    public List<DatacronAffix> RerollOption { get; set; }

    [JsonPropertyName("rerollCount")]
    public int? RerollCount { get; set; }

    [JsonPropertyName("focused")]
    public bool? Focused { get; set; }

}