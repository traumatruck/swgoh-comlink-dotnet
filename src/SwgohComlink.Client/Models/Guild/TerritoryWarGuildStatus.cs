using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.Guild;

public class TerritoryWarGuildStatus
{
    [JsonPropertyName("profile")] public TerritoryGuildProfile Profile { get; set; }

    [JsonPropertyName("conflictStatus")] public List<TerritoryWarConflictZoneStatus> ConflictStatus { get; set; }

    [JsonPropertyName("reconStatus")] public List<TerritoryReconZoneStatus> ReconStatus { get; set; }
}