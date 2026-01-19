using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class MandatoryDatacron
{
    [JsonPropertyName("minLevel")]
    public int? MinLevel { get; set; }

    [JsonPropertyName("setId")]
    public int? SetId { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

}