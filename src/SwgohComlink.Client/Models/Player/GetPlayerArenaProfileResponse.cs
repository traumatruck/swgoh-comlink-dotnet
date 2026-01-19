using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Player;

public class GetPlayerArenaProfileResponse
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("allyCode")]
    public long? AllyCode { get; set; }

    [JsonPropertyName("playerId")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("pvpProfile")]
    public List<PlayerPvpProfile> PvpProfile { get; set; }

    [JsonPropertyName("localTimeZoneOffsetMinutes")]
    public int? LocalTimeZoneOffsetMinutes { get; set; }

    [JsonPropertyName("lifetimeSeasonScore")]
    public long? LifetimeSeasonScore { get; set; }

    [JsonPropertyName("playerRating")]
    public PlayerRating PlayerRating { get; set; }

    [JsonPropertyName("nucleusId")]
    public string? NucleusId { get; set; }
}