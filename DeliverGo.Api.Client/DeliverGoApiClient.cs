using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using DeliverGo.Api.Client.Authentication;
using DeliverGo.Api.Client.Configuration;
using DeliverGo.Api.Client.Exceptions;
using DeliverGo.Api.Client.Internal;
using DeliverGo.Api.Client.Models;
using Microsoft.Extensions.Options;

namespace DeliverGo.Api.Client
{
    /// <summary>
    /// Default <see cref="IDeliverGoApiClient"/> implementation backed by a typed
    /// <see cref="HttpClient"/> whose pipeline supplies the bearer token.
    /// </summary>
    public sealed class DeliverGoApiClient : IDeliverGoApiClient, IDisposable
    {
        internal static readonly JsonSerializerOptions SerializerOptions = new(JsonSerializerDefaults.Web)
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
        };

        private readonly HttpClient _httpClient;
        private readonly DeliverGoOptions _options;
        private readonly IDisposable[]? _ownedResources;

        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverGoApiClient"/> class.
        /// </summary>
        public DeliverGoApiClient(HttpClient httpClient, IOptions<DeliverGoOptions> options)
            : this(httpClient, options, ownedResources: null)
        {
        }

        private DeliverGoApiClient(HttpClient httpClient, IOptions<DeliverGoOptions> options, IDisposable[]? ownedResources)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            ArgumentNullException.ThrowIfNull(options);

            _httpClient = httpClient;
            _options = options.Value;
            _ownedResources = ownedResources;

            _httpClient.BaseAddress ??= _options.BaseAddress;
        }

        /// <summary>
        /// Creates a fully configured, self-contained client for console applications and other
        /// scenarios without dependency injection. The returned instance owns its
        /// <see cref="HttpClient"/> and authentication pipeline, so it must be disposed.
        /// </summary>
        /// <remarks>
        /// Create the client once and reuse it for the lifetime of the application; creating many
        /// instances can exhaust available sockets. The supplied <paramref name="options"/> instance
        /// is used as-is, so later mutations affect the created client.
        /// </remarks>
        /// <param name="options">Configuration used for authentication and API requests.</param>
        /// <exception cref="ArgumentNullException"><paramref name="options"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">A required configuration value is missing or invalid.</exception>
        public static DeliverGoApiClient Create(DeliverGoOptions options)
        {
            ArgumentNullException.ThrowIfNull(options);
            options.Validate();

            IOptions<DeliverGoOptions> wrapped = Options.Create(options);

            var tokenClientFactory = new SingleHttpClientFactory(options);
            var tokenProvider = new DeliverGoTokenProvider(tokenClientFactory, wrapped);

            var authenticationHandler = new DeliverGoAuthenticationHandler(tokenProvider)
            {
                InnerHandler = new SocketsHttpHandler(),
            };

            var httpClient = new HttpClient(authenticationHandler, disposeHandler: true)
            {
                BaseAddress = options.BaseAddress,
                Timeout = options.Timeout,
            };

            return new DeliverGoApiClient(httpClient, wrapped, [httpClient, tokenProvider, tokenClientFactory]);
        }

        /// <summary>
        /// Releases the resources owned by clients created through <see cref="Create(DeliverGoOptions)"/>.
        /// Instances resolved from a dependency injection container own nothing and dispose is a no-op.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _disposed = true;

            if (_ownedResources is null)
            {
                return;
            }

            foreach (IDisposable resource in _ownedResources)
            {
                resource.Dispose();
            }
        }

        /// <inheritdoc />
        public Task<IReadOnlyList<SnailTrail>> GetSnailTrailsAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetCollectionAsync<SnailTrail>("snailTrails", filter, cancellationToken);

        /// <inheritdoc />
        public Task<SnailTrail?> GetSnailTrailAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetByIdAsync<SnailTrail>("snailTrails", id, filter, cancellationToken);

        /// <inheritdoc />
        public Task<IReadOnlyList<Ticket>> GetTicketsAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetCollectionAsync<Ticket>("tickets", filter, cancellationToken);

        /// <inheritdoc />
        public Task<Ticket?> GetTicketAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetByIdAsync<Ticket>("tickets", id, filter, cancellationToken);

        /// <inheritdoc />
        public Task<IReadOnlyList<Truck>> GetTrucksAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetCollectionAsync<Truck>("trucks", filter, cancellationToken);

        /// <inheritdoc />
        public Task<Truck?> GetTruckAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetByIdAsync<Truck>("trucks", id, filter, cancellationToken);

        /// <inheritdoc />
        public Task<IReadOnlyList<Order>> GetOrdersAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetCollectionAsync<Order>("orders", filter, cancellationToken);

        /// <inheritdoc />
        public Task<Order?> GetOrderAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default)
            => GetByIdAsync<Order>("orders", id, filter, cancellationToken);

        /// <inheritdoc />
        public Task<Order> CreateOrderAsync(Order order, CancellationToken cancellationToken = default)
            => CreateAsync("orders", order, cancellationToken);

        /// <inheritdoc />
        public Task<Order> UpdateOrderAsync(string id, Order order, CancellationToken cancellationToken = default)
            => UpdateAsync("orders", id, order, cancellationToken);

        /// <inheritdoc />
        public Task DeleteOrderAsync(string id, CancellationToken cancellationToken = default)
            => DeleteAsync("orders", id, cancellationToken);

        private async Task<IReadOnlyList<T>> GetCollectionAsync<T>(string path, DeliverGoFilter? filter, CancellationToken cancellationToken)
        {
            DeliverGoFilter? effective = ApplyDefaultLimit(filter);
            string uri = QueryHelper.BuildUri(path, effective);

            List<T>? result = await SendAsync<List<T>>(HttpMethod.Get, uri, body: null, treatNotFoundAsNull: true, cancellationToken).ConfigureAwait(false);
            return result ?? [];
        }

        private async Task<T?> GetByIdAsync<T>(string path, string id, DeliverGoFilter? filter, CancellationToken cancellationToken)
            where T : class
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(id);

            string uri = QueryHelper.BuildUri($"{path}/{Uri.EscapeDataString(id)}", filter);
            return await SendAsync<T>(HttpMethod.Get, uri, body: null, treatNotFoundAsNull: true, cancellationToken).ConfigureAwait(false);
        }

        private async Task<T> CreateAsync<T>(string path, T payload, CancellationToken cancellationToken)
            where T : class
        {
            ArgumentNullException.ThrowIfNull(payload);

            T? result = await SendAsync<T>(HttpMethod.Post, path, payload, treatNotFoundAsNull: false, cancellationToken).ConfigureAwait(false);
            return result ?? payload;
        }

        private async Task<T> UpdateAsync<T>(string path, string id, T payload, CancellationToken cancellationToken)
            where T : class
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(id);
            ArgumentNullException.ThrowIfNull(payload);

            string uri = $"{path}/{Uri.EscapeDataString(id)}";
            T? result = await SendAsync<T>(HttpMethod.Patch, uri, payload, treatNotFoundAsNull: false, cancellationToken).ConfigureAwait(false);
            return result ?? payload;
        }

        private Task DeleteAsync(string path, string id, CancellationToken cancellationToken)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(id);

            string uri = $"{path}/{Uri.EscapeDataString(id)}";
            return SendAsync<JsonElement>(HttpMethod.Delete, uri, body: null, treatNotFoundAsNull: false, cancellationToken);
        }

        private DeliverGoFilter? ApplyDefaultLimit(DeliverGoFilter? filter)
        {
            if (_options.DefaultLimit is not > 0)
            {
                return filter;
            }

            if (filter is null)
            {
                return new DeliverGoFilter { Limit = _options.DefaultLimit };
            }

            if (filter.Limit is not null)
            {
                return filter;
            }

            DeliverGoFilter clone = filter.Clone();
            clone.Limit = _options.DefaultLimit;
            return clone;
        }

        private async Task<T?> SendAsync<T>(HttpMethod method, string relativeUri, object? body, bool treatNotFoundAsNull, CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(method, relativeUri);
            if (body is not null)
            {
                request.Content = JsonContent.Create(body, body.GetType(), options: SerializerOptions);
            }

            using HttpResponseMessage response = await _httpClient
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .ConfigureAwait(false);

            if (treatNotFoundAsNull && response.StatusCode == HttpStatusCode.NotFound)
            {
                return default;
            }

            if (!response.IsSuccessStatusCode)
            {
                string errorBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                throw new DeliverGoApiException(
                    $"The DeliverGo API request to '{relativeUri}' failed with status {(int)response.StatusCode} ({response.StatusCode}).",
                    response.StatusCode,
                    response.RequestMessage?.RequestUri,
                    errorBody);
            }

            if (response.StatusCode == HttpStatusCode.NoContent || response.Content.Headers.ContentLength == 0)
            {
                return default;
            }

            try
            {
                return await response.Content
                    .ReadFromJsonAsync<T>(SerializerOptions, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (JsonException ex)
            {
                throw new DeliverGoApiException(
                    $"The DeliverGo API response for '{relativeUri}' could not be deserialized.",
                    response.StatusCode,
                    response.RequestMessage?.RequestUri,
                    responseBody: null,
                    ex);
            }
        }
    }
}
