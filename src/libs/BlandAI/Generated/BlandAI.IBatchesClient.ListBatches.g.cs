#nullable enable

namespace BlandAI
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List Batches<br/>
        /// Retrieve all batches created by your organization.
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.DataResponseBatchList> ListBatchesAsync(
            int? take = default,
            int? skip = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}