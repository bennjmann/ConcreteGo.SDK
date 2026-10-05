using System.Net;
using System.Net.Http.Headers;

namespace DeliverGo.Api.Client.Authentication
{
    /// <summary>
    /// Attaches the Sysdyne ID bearer token to outgoing DeliverGo API requests and
    /// retries once with a freshly acquired token when the API responds with 401.
    /// </summary>
    public sealed class DeliverGoAuthenticationHandler : DelegatingHandler
    {
        private readonly IDeliverGoTokenProvider _tokenProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverGoAuthenticationHandler"/> class.
        /// </summary>
        public DeliverGoAuthenticationHandler(IDeliverGoTokenProvider tokenProvider)
        {
            ArgumentNullException.ThrowIfNull(tokenProvider);
            _tokenProvider = tokenProvider;
        }

        /// <inheritdoc />
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            string token = await _tokenProvider.GetAccessTokenAsync(false, cancellationToken).ConfigureAwait(false);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response.StatusCode != HttpStatusCode.Unauthorized)
            {
                return response;
            }

            response.Dispose();

            string refreshed = await _tokenProvider.GetAccessTokenAsync(true, cancellationToken).ConfigureAwait(false);

            using HttpRequestMessage retry = CloneRequest(request);
            retry.Headers.Authorization = new AuthenticationHeaderValue("Bearer", refreshed);

            return await base.SendAsync(retry, cancellationToken).ConfigureAwait(false);
        }

        private static HttpRequestMessage CloneRequest(HttpRequestMessage request)
        {
            var clone = new HttpRequestMessage(request.Method, request.RequestUri)
            {
                Version = request.Version,
                VersionPolicy = request.VersionPolicy,
                Content = request.Content,
            };

            foreach (KeyValuePair<string, IEnumerable<string>> header in request.Headers)
            {
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            foreach (KeyValuePair<string, object?> option in request.Options)
            {
                clone.Options.TryAdd(option.Key, option.Value);
            }

            return clone;
        }
    }
}
