using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Requirement
{
    [JsonPropertyName("evalType")]
    public EvaluationType EvalType { get; set; }

    [JsonPropertyName("requirementItem")]
    public List<RequirementItem> RequirementItem { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

}