using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Requests;

public class GetMetaDataRequestPayload
{
    [JsonPropertyName("clientSpecs")]
    public GetMetaDataRequestPayloadClientSpecs ClientSpecs { get; set; }

}