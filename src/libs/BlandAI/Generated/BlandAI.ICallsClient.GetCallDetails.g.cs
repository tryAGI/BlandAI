#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Details<br/>
        /// Retrieve detailed information, metadata, and transcripts for a specific call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.CallDetails> GetCallDetailsAsync(
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}