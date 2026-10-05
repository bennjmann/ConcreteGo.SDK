using System.Net;

namespace DeliverGo.Api.Client.Exceptions
{
    /// <summary>
    /// Thrown when the DeliverGo API or the Sysdyne ID token endpoint returns a
    /// non-success response or an unusable payload.
    /// </summary>
    public sealed class DeliverGoApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverGoApiException"/> class.
        /// </summary>
        public DeliverGoApiException(
            string message,
            HttpStatusCode statusCode,
            Uri? requestUri,
            string? responseBody,
            Exception? innerException = null)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            RequestUri = requestUri;
            ResponseBody = responseBody;
        }

        /// <summary>
        /// HTTP status code returned by the service.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// URI of the failed request, when known.
        /// </summary>
        public Uri? RequestUri { get; }

        /// <summary>
        /// Raw response body, when available.
        /// </summary>
        public string? ResponseBody { get; }
    }
}
