using DeliverGo.Api.Client.Configuration;

namespace DeliverGo.Api.Client.Internal
{
    /// <summary>
    /// Minimal <see cref="IHttpClientFactory"/> used by standalone (non dependency injection)
    /// scenarios. Always returns the same configured <see cref="HttpClient"/> instance.
    /// </summary>
    internal sealed class SingleHttpClientFactory : IHttpClientFactory, IDisposable
    {
        private readonly HttpClient _httpClient;

        public SingleHttpClientFactory(DeliverGoOptions options)
        {
            ArgumentNullException.ThrowIfNull(options);

            _httpClient = new HttpClient(new SocketsHttpHandler(), disposeHandler: true)
            {
                Timeout = options.Timeout,
            };
        }

        public HttpClient CreateClient(string name) => _httpClient;

        public void Dispose() => _httpClient.Dispose();
    }
}
