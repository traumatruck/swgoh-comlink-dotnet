using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetGuildsRequestPayload
{
    [JsonPropertyName("filterType")]
    public double? FilterType { get; set; }

}