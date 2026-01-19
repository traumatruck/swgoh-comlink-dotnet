using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class SquadCell
{
    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("unitDefId")]
    public string? UnitDefId { get; set; }

    [JsonPropertyName("cellIndex")]
    public int? CellIndex { get; set; }

    [JsonPropertyName("unitBattleStat")]
    public UnitBattleStat UnitBattleStat { get; set; }

    [JsonPropertyName("messageReticle")]
    public string? MessageReticle { get; set; }

    [JsonPropertyName("progressItem")]
    public bool? ProgressItem { get; set; }

    [JsonPropertyName("squadUnitType")]
    public SquadUnitType SquadUnitType { get; set; }

    [JsonPropertyName("crewBattleStat")]
    public List<UnitBattleStat> CrewBattleStat { get; set; }

    [JsonPropertyName("unitState")]
    public BattleUnitState UnitState { get; set; }

    [JsonPropertyName("selectable")]
    public bool? Selectable { get; set; }

    [JsonPropertyName("overkillItem")]
    public bool? OverkillItem { get; set; }

    [JsonPropertyName("inheritFromDefinitionId")]
    public string? InheritFromDefinitionId { get; set; }

    [JsonPropertyName("forcedUnitEraLevel")]
    public int? ForcedUnitEraLevel { get; set; }
}