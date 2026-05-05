#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Get Call Recording<br/>
        /// Retrieve the audio recording for a completed call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="contentType">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetCallRecordingAsync(
            string callId,
            global::BlandAI.GetCallRecordingContentType? contentType = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Call Recording<br/>
        /// Retrieve the audio recording for a completed call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="contentType">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetCallRecordingAsStreamAsync(
            string callId,
            global::BlandAI.GetCallRecordingContentType? contentType = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Call Recording<br/>
        /// Retrieve the audio recording for a completed call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="contentType">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AutoSDKHttpResponse<byte[]>> GetCallRecordingAsResponseAsync(
            string callId,
            global::BlandAI.GetCallRecordingContentType? contentType = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}