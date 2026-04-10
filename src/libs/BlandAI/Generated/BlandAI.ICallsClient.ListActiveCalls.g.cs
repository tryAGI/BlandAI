#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// List Active Calls<br/>
        /// Returns all currently active calls for your account.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.ListActiveCallsResponse> ListActiveCallsAsync(
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}