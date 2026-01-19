using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models;

public class EquipmentSlot
{
    [JsonPropertyName("equipmentId")]
    public string? EquipmentId { get; set; }

    [JsonPropertyName("slot")]
    public int? Slot { get; set; }
}