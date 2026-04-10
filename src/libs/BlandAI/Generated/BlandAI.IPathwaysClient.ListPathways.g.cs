#nullable enable

namespace BlandAI
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// List All Pathways<br/>
        /// Retrieve information about all conversational pathways in your account, including name, description, nodes, and edges.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::BlandAI.Pathway>> ListPathwaysAsync(
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}