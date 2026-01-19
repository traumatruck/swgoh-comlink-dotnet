using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class PlayerSkillRating
{
    [JsonPropertyName("skillRating")]
    public int? SkillRating { get; set; }

}