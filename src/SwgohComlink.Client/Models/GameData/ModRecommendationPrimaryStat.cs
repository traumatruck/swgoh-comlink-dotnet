using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ModRecommendationPrimaryStat
{
    [JsonPropertyName("slot")]
    public StatModSlot Slot { get; set; }

    [JsonPropertyName("stat")]
    public List<UnitStat> Stat { get; set; }

}