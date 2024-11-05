using System.Text.Json.Serialization;

namespace TphBlazorSpotlightExample.Models;

public class Guild
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("splash")]
    public string Splash { get; set; }

    [JsonPropertyName("banner")]
    public string Banner { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("features")]
    public List<string> Features { get; set; }

    [JsonPropertyName("verification_level")]
    public int VerificationLevel { get; set; }

    [JsonPropertyName("vanity_url_code")]
    public string VanityUrlCode { get; set; }

    [JsonPropertyName("nsfw_level")]
    public int NsfwLevel { get; set; }

    [JsonPropertyName("nsfw")]
    public bool Nsfw { get; set; }

    [JsonPropertyName("premium_subscription_count")]
    public int PremiumSubscriptionCount { get; set; }
}