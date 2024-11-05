using System.Text.Json.Serialization;

namespace TphBlazorSpotlightExample.Models;

public class DiscordInvite
{
    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("expires_at")]
    public object ExpiresAt { get; set; }

    [JsonPropertyName("flags")]
    public int Flags { get; set; }

    [JsonPropertyName("guild")]
    public Guild Guild { get; set; }

    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; }

    [JsonPropertyName("approximate_member_count")]
    public int ApproximateMemberCount { get; set; }

    [JsonPropertyName("approximate_presence_count")]
    public int ApproximatePresenceCount { get; set; }
}