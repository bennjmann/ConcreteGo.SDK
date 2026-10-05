using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Authentication
{
    /// <summary>
    /// Raw token payload returned by the Sysdyne ID token endpoint.
    /// </summary>
    internal sealed record TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; init; }

        [JsonPropertyName("token_type")]
        public string? TokenType { get; init; }

        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; init; }

        [JsonPropertyName("scope")]
        public string? Scope { get; init; }
    }
}
