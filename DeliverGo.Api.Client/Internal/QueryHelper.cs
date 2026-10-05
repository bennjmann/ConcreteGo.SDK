using DeliverGo.Api.Client.Models;

namespace DeliverGo.Api.Client.Internal
{
    /// <summary>
    /// Builds relative request URIs including the URL-encoded LoopBack <c>filter</c> parameter.
    /// </summary>
    internal static class QueryHelper
    {
        /// <summary>
        /// Builds a relative URI for the supplied resource path and optional filter.
        /// </summary>
        public static string BuildUri(string path, DeliverGoFilter? filter)
        {
            if (filter is null || filter.IsEmpty)
            {
                return path;
            }

            string encoded = Uri.EscapeDataString(filter.ToJson());
            string separator = path.Contains('?', StringComparison.Ordinal) ? "&" : "?";
            return $"{path}{separator}filter={encoded}";
        }
    }
}
