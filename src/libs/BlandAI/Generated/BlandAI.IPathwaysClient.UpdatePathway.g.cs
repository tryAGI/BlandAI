#nullable enable

namespace BlandAI
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// Update Pathway<br/>
        /// Update a conversational pathway's name, description, nodes, and edges.
        /// </summary>
        /// <param name="pathwayId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> UpdatePathwayAsync(
            string pathwayId,

            global::BlandAI.UpdatePathwayRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pathway<br/>
        /// Update a conversational pathway's name, description, nodes, and edges.
        /// </summary>
        /// <param name="pathwayId"></param>
        /// <param name="name">
        /// Name of the pathway
        /// </param>
        /// <param name="description">
        /// Description of the pathway
        /// </param>
        /// <param name="nodes">
        /// Array of node objects in the conversation flow
        /// </param>
        /// <param name="edges">
        /// Array of edge objects connecting nodes
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> UpdatePathwayAsync(
            string pathwayId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::BlandAI.PathwayNode>? nodes = default,
            global::System.Collections.Generic.IList<global::BlandAI.PathwayEdge>? edges = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}