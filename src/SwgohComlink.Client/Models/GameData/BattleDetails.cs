using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class BattleDetails
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("entryCategoryAllowed")]
    public EntryCategoryAllowed EntryCategoryAllowed { get; set; }

    [JsonPropertyName("battleEncounter")]
    public List<CampaignNodeEncounter> BattleEncounter { get; set; }

    [JsonPropertyName("battleDurationLimit")]
    public long? BattleDurationLimit { get; set; }

    [JsonPropertyName("grantedAbility")]
    public List<MissionGrantedAbility> GrantedAbility { get; set; }

    [JsonPropertyName("autoBattleEnabled")]
    public bool? AutoBattleEnabled { get; set; }

    [JsonPropertyName("battleSpeedAdjustable")]
    public bool? BattleSpeedAdjustable { get; set; }

    [JsonPropertyName("retreatEnabled")]
    public bool? RetreatEnabled { get; set; }

    [JsonPropertyName("audioKey")]
    public string? AudioKey { get; set; }

    [JsonPropertyName("combatType")]
    public CombatType CombatType { get; set; }

    [JsonPropertyName("pveDatacronAllowed")]
    public bool? PveDatacronAllowed { get; set; }

}