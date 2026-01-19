using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class CrewMember
{
    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("slot")]
    public int? Slot { get; set; }

    [JsonPropertyName("skillReference")]
    public List<SkillDefinitionReference> SkillReference { get; set; }

    [JsonPropertyName("skilllessCrewAbilityId")]
    public string? SkilllessCrewAbilityId { get; set; }

}