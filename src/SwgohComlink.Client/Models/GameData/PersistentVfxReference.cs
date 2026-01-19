using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class PersistentVfxReference
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

}