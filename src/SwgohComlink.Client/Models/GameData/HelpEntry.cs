using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class HelpEntry
{
    [JsonPropertyName("id")]
    public HelpType Id { get; set; }

    [JsonPropertyName("tile")]
    public List<HelpTile> Tile { get; set; }
}