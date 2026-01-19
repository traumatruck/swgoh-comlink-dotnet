using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Readyz;

public class ErrorResponse
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}