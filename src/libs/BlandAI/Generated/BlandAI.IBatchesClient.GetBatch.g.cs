#nullable enable

namespace BlandAI
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Get Batch<br/>
        /// Retrieve metadata for a specific batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.DataResponseBatch> GetBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}