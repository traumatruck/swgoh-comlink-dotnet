using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class Squad
{
    [JsonPropertyName("cell")]
    public List<SquadCell> Cell { get; set; }

    [JsonPropertyName("targetingTactic")]
    public BattleTargetingTactic TargetingTactic { get; set; }

    [JsonPropertyName("squadType")]
    public SquadType SquadType { get; set; }

    [JsonPropertyName("targetingSetId")]
    public string? TargetingSetId { get; set; }

    [JsonPropertyName("expireTime")]
    public long? ExpireTime { get; set; }

    [JsonPropertyName("lastSaveTime")]
    public long? LastSaveTime { get; set; }

    [JsonPropertyName("supportInheritFromDefinitionId")]
    public string? SupportInheritFromDefinitionId { get; set; }

    [JsonPropertyName("datacron")]
    public DatacronBattleStat Datacron { get; set; }
}