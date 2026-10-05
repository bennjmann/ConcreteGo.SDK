namespace DeliverGo.Api.Client.Configuration
{
    /// <summary>
    /// Configuration for the DeliverGo (iSTRADA.net) API client and its OAuth 2.0
    /// client-credentials authentication against Sysdyne ID.
    /// </summary>
    public sealed class DeliverGoOptions
    {
        /// <summary>
        /// Name of the configuration section these options are typically bound from.
        /// </summary>
        public const string SectionName = "DeliverGo";

        /// <summary>
        /// OAuth 2.0 client identifier issued by Sysdyne.
        /// </summary>
        public string ClientId { get; set; } = string.Empty;

        /// <summary>
        /// OAuth 2.0 client secret issued by Sysdyne.
        /// </summary>
        public string ClientSecret { get; set; } = string.Empty;

        /// <summary>
        /// Scopes requested when acquiring a token, for example <c>ticket:read</c> or <c>truck:read</c>.
        /// </summary>
        public IList<string> Scopes { get; set; } = new List<string>();

        /// <summary>
        /// Sysdyne ID token endpoint.
        /// </summary>
        public Uri TokenEndpoint { get; set; } = new("https://id.sysdyne.cloud/token");

        /// <summary>
        /// Base address of the iSTRADA API. Must end with a trailing slash.
        /// </summary>
        public Uri BaseAddress { get; set; } = new("https://api.istrada.net/api/");

        /// <summary>
        /// Value sent as the <c>resource</c> parameter of the token request.
        /// Defaults to the API base address without its trailing slash.
        /// </summary>
        public Uri? Resource { get; set; }

        /// <summary>
        /// How long before actual expiry a cached token is considered stale and refreshed.
        /// </summary>
        public TimeSpan TokenRefreshSkew { get; set; } = TimeSpan.FromSeconds(60);

        /// <summary>
        /// Fallback token lifetime used when the token endpoint does not return <c>expires_in</c>.
        /// </summary>
        public TimeSpan DefaultTokenLifetime { get; set; } = TimeSpan.FromMinutes(5);

        /// <summary>
        /// Timeout applied to API and token requests.
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(100);

        /// <summary>
        /// Default <c>limit</c> applied to collection requests when the caller does not supply one.
        /// The API has no rate limiting, so unbounded queries should be avoided.
        /// </summary>
        public int? DefaultLimit { get; set; } = 100;

        /// <summary>
        /// Space-delimited scope string sent to the token endpoint.
        /// </summary>
        public string ScopeValue => string.Join(' ', Scopes);

        /// <summary>
        /// Resource value sent to the token endpoint.
        /// </summary>
        public string ResourceValue =>
            (Resource ?? BaseAddress).AbsoluteUri.TrimEnd('/');

        /// <summary>
        /// Throws when required configuration values are missing or invalid.
        /// </summary>
        /// <exception cref="InvalidOperationException">A required value is missing or invalid.</exception>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(ClientId))
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(ClientId)} must be configured.");
            }

            if (string.IsNullOrWhiteSpace(ClientSecret))
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(ClientSecret)} must be configured.");
            }

            if (Scopes.Count == 0)
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(Scopes)} must contain at least one scope.");
            }

            if (!BaseAddress.AbsoluteUri.EndsWith('/'))
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(BaseAddress)} must end with a trailing slash.");
            }

            if (Timeout <= TimeSpan.Zero)
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(Timeout)} must be greater than zero.");
            }

            if (TokenRefreshSkew < TimeSpan.Zero)
            {
                throw new InvalidOperationException($"{nameof(DeliverGoOptions)}.{nameof(TokenRefreshSkew)} cannot be negative.");
            }
        }
    }
}
