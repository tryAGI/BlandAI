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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> StopCallAsync(
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}