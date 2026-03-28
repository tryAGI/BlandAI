#nullable enable

namespace BlandAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices<br/>
        /// Retrieve all available voices, including public and custom voices.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::BlandAI.Voice>> ListVoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}