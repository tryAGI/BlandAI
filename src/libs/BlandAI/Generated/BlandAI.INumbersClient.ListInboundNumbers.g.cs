#nullable enable

namespace BlandAI
{
    public partial interface INumbersClient
    {
        /// <summary>
        /// List Numbers<br/>
        /// Retrieve a list of all inbound phone numbers configured for your account, along with their associated settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.ListInboundNumbersResponse> ListInboundNumbersAsync(
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}