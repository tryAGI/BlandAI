#nullable enable

namespace BlandAI
{
    public partial interface INumbersClient
    {
        /// <summary>
        /// Number Details<br/>
        /// Retrieve configuration details for a specific inbound number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.InboundNumber> GetInboundNumberAsync(
            string phoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}