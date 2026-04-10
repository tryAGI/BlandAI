#nullable enable

namespace BlandAI
{
    public partial interface INumbersClient
    {
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Purchase a new phone number for inbound calls ($15/mo subscription).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> PurchaseNumberAsync(

            global::BlandAI.PurchaseNumberRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Purchase a new phone number for inbound calls ($15/mo subscription).
        /// </summary>
        /// <param name="areaCode">
        /// Three-digit area code for the phone number<br/>
        /// Default Value: 415
        /// </param>
        /// <param name="countryCode">
        /// Country code (US or CA; contact support for others)<br/>
        /// Default Value: US
        /// </param>
        /// <param name="phoneNumber">
        /// Exact number in E.164 format (overrides area_code if provided)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.StatusResponse> PurchaseNumberAsync(
            string? areaCode = default,
            global::BlandAI.PurchaseNumberRequestCountryCode? countryCode = default,
            string? phoneNumber = default,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}