using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class StatDef
{
    [JsonPropertyName("stat")]
    public List<Stat> Stat { get; set; }
}