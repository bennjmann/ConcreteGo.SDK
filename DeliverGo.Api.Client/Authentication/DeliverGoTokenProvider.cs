using System.Net.Http.Json;
using DeliverGo.Api.Client.Configuration;
using DeliverGo.Api.Client.Exceptions;
using Microsoft.Extensions.Options;

namespace DeliverGo.Api.Client.Authentication
{
    /// <summary>
    /// Default <see cref="IDeliverGoTokenProvider"/> implementation. Caches the acquired
    /// token in memory and refreshes it shortly before expiry.
    /// </summary>
    public sealed class DeliverGoTokenProvider : IDeliverGoTokenProvider, IDisposable
    {
        /// <summary>
        /// Name of the <see cref="HttpClient"/> used to talk to the token endpoint.
        /// </summary>
        public const string HttpClientName = "DeliverGo.Auth";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly DeliverGoOptions _options;
        private readonly SemaphoreSlim _refreshLock = new(1, 1);
        private readonly TimeProvider _timeProvider;

        private string? _accessToken;
        private DateTimeOffset _expiresAt = DateTimeOffset.MinValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverGoTokenProvider"/> class.
        /// </summary>
        public DeliverGoTokenProvider(
            IHttpClientFactory httpClientFactory,
            IOptions<DeliverGoOptions> options,
            TimeProvider? timeProvider = null)
        {
            ArgumentNullException.ThrowIfNull(httpClientFactory);
            ArgumentNullException.ThrowIfNull(options);

            _httpClientFactory = httpClientFactory;
            _options = options.Value;
            _timeProvider = timeProvider ?? TimeProvider.System;
        }

        /// <inheritdoc />
        public async Task<string> GetAccessTokenAsync(bool forceRefresh = false, CancellationToken cancellationToken = default)
        {
            if (!forceRefresh && TryGetCachedToken(out string? cached))
            {
                return cached;
            }

            await _refreshLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                if (!forceRefresh && TryGetCachedToken(out string? cachedAfterWait))
                {
                    return cachedAfterWait;
                }

                return await AcquireTokenAsync(cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _refreshLock.Release();
            }
        }

        private bool TryGetCachedToken(out string token)
        {
            string? current = _accessToken;
            if (!string.IsNullOrEmpty(current) && _timeProvider.GetUtcNow() < _expiresAt)
            {
                token = current;
                return true;
            }

            token = string.Empty;
            return false;
        }

        private async Task<string> AcquireTokenAsync(CancellationToken cancellationToken)
        {
            _options.Validate();

            HttpClient client = _httpClientFactory.CreateClient(HttpClientName);

            using var request = new HttpRequestMessage(HttpMethod.Post, _options.TokenEndpoint)
            {
                Content = new FormUrlEncodedContent(
                [
                    new KeyValuePair<string, string>("client_id", _options.ClientId),
                    new KeyValuePair<string, string>("client_secret", _options.ClientSecret),
                    new KeyValuePair<string, string>("scope", _options.ScopeValue),
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("resource", _options.ResourceValue),
                ]),
            };

            using HttpResponseMessage response = await client
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                throw new DeliverGoApiException(
                    "Failed to acquire a DeliverGo access token from Sysdyne ID.",
                    response.StatusCode,
                    _options.TokenEndpoint,
                    body);
            }

            TokenResponse? token = await response.Content
                .ReadFromJsonAsync<TokenResponse>(cancellationToken)
                .ConfigureAwait(false);

            if (token is null || string.IsNullOrWhiteSpace(token.AccessToken))
            {
                throw new DeliverGoApiException(
                    "The Sysdyne ID token response did not contain an access token.",
                    response.StatusCode,
                    _options.TokenEndpoint,
                    responseBody: null);
            }

            TimeSpan lifetime = token.ExpiresIn is > 0
                ? TimeSpan.FromSeconds(token.ExpiresIn.Value)
                : _options.DefaultTokenLifetime;

            TimeSpan effective = lifetime - _options.TokenRefreshSkew;
            if (effective <= TimeSpan.Zero)
            {
                effective = lifetime;
            }

            _accessToken = token.AccessToken;
            _expiresAt = _timeProvider.GetUtcNow().Add(effective);

            return _accessToken;
        }

        /// <inheritdoc />
        public void Dispose() => _refreshLock.Dispose();
    }
}
