using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class SaveSquadConfig
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("descKey")]
    public string? DescKey { get; set; }

    [JsonPropertyName("tournamentMapDefinitionId")]
    public string? TournamentMapDefinitionId { get; set; }
}