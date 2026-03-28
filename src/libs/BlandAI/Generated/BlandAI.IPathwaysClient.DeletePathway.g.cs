#nullable enable

namespace BlandAI
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// Delete Pathway<br/>
        /// Permanently delete a conversational pathway.
        /// </summary>
        /// <param name="pathwayId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> DeletePathwayAsync(
            string pathwayId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}