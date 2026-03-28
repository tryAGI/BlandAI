#nullable enable

namespace BlandAI
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Account Details<br/>
        /// Retrieve your account status, billing information, and total call count.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AccountDetails> GetAccountDetailsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}