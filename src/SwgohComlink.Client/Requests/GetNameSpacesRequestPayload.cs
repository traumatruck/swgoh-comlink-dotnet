using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetNameSpacesRequestPayload
{
    [JsonPropertyName("onlyCompatible")]
    public bool? OnlyCompatible { get; set; }

}