using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class Table
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("row")]
    public List<TableRow> Row { get; set; }
}