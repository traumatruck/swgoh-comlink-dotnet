using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class CantinaCharacterDialog
{
    [JsonPropertyName("texture")]
    public string? Texture { get; set; }
}