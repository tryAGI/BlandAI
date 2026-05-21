#nullable enable

namespace BlandAI
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// Create Pathway<br/>
        /// Create a new conversational pathway.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.CreatePathwayResponse> CreatePathwayAsync(

            global::BlandAI.CreatePathwayRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pathway<br/>
        /// Create a new conversational pathway.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AutoSDKHttpResponse<global::BlandAI.CreatePathwayResponse>> CreatePathwayAsResponseAsync(

            global::BlandAI.CreatePathwayRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pathway<br/>
        /// Create a new conversational pathway.
        /// </summary>
        /// <param name="name">
        /// Name of the conversational pathway
        /// </param>
        /// <param name="description">
        /// Description of the pathway
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.CreatePathwayResponse> CreatePathwayAsync(
            string name,
            string? description = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}