using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GuildRaidLockout
{
    [JsonPropertyName("lockoutStartTime")]
    public long? LockoutStartTime { get; set; }

    [JsonPropertyName("lockoutEndTime")]
    public long? LockoutEndTime { get; set; }

}