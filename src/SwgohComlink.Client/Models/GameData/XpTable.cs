using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class XpTable
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("row")]
    public List<XpTableRow> Row { get; set; }
}