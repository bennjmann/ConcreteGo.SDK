namespace DeliverGo.Api.Client.Authentication
{
    /// <summary>
    /// Supplies bearer tokens for the DeliverGo API using the OAuth 2.0
    /// client-credentials grant against Sysdyne ID.
    /// </summary>
    public interface IDeliverGoTokenProvider
    {
        /// <summary>
        /// Gets a valid access token, acquiring or refreshing it when necessary.
        /// </summary>
        /// <param name="forceRefresh">When <see langword="true"/>, any cached token is discarded first.</param>
        /// <param name="cancellationToken">Token used to cancel the operation.</param>
        /// <returns>A bearer access token.</returns>
        Task<string> GetAccessTokenAsync(bool forceRefresh = false, CancellationToken cancellationToken = default);
    }
}
