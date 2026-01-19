using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetNameSpacesResponse
{
    [JsonPropertyName("nameSpace")]
    public List<string?> NameSpaceValue { get; set; }

}