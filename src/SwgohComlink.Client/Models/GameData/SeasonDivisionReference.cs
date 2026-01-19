using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SeasonDivisionReference
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

}