using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class ClientQualityData
{
    [JsonPropertyName("performanceLevel")]
    public PerformanceLevel PerformanceLevel { get; set; }

    [JsonPropertyName("memoryLevel")]
    public MemoryLevel MemoryLevel { get; set; }

    [JsonPropertyName("gcActivityLevel")]
    public GcActivityLevel GcActivityLevel { get; set; }

    [JsonPropertyName("vfxAllocationLevel")]
    public VfxAllocationLevel VfxAllocationLevel { get; set; }

    [JsonPropertyName("flag")]
    public List<string?> Flag { get; set; }
}