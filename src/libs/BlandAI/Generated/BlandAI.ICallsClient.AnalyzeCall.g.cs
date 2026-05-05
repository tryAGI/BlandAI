#nullable enable

namespace BlandAI
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Analyze Call with AI<br/>
        /// Use AI to analyze a completed call's transcript and extract structured answers.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AnalyzeCallResponse> AnalyzeCallAsync(
            string callId,

            global::BlandAI.AnalyzeCallRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze Call with AI<br/>
        /// Use AI to analyze a completed call's transcript and extract structured answers.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlandAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AutoSDKHttpResponse<global::BlandAI.AnalyzeCallResponse>> AnalyzeCallAsResponseAsync(
            string callId,

            global::BlandAI.AnalyzeCallRequest request,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze Call with AI<br/>
        /// Use AI to analyze a completed call's transcript and extract structured answers.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="goal">
        /// Overall purpose of the call, providing context for AI analysis
        /// </param>
        /// <param name="questions">
        /// Array of question-answer pairs. Each entry is [question_text, expected_type].
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlandAI.AnalyzeCallResponse> AnalyzeCallAsync(
            string callId,
            string goal,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> questions,
            global::BlandAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}