#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Stop Active Call<br/>
        /// Terminates a specific active call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> StopCallAsync(
            string callId,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Active Call<br/>
        /// Terminates a specific active call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AutoSDKHttpResponse<global::BlandAI.StatusResponse>> StopCallAsResponseAsync(
            string callId,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}