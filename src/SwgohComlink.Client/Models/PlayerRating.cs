using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class PlayerRating
{
    [JsonPropertyName("playerSkillRating")]
    public PlayerSkillRating PlayerSkillRating { get; set; }

    [JsonPropertyName("playerRankStatus")]
    public PlayerRankStatus PlayerRankStatus { get; set; }
}