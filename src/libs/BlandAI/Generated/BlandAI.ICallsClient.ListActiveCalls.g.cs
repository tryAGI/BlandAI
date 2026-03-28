#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// List Active Calls<br/>
        /// Returns all currently active calls for your account.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.ListActiveCallsResponse> ListActiveCallsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}