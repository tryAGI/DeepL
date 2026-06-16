#nullable enable

namespace DeepL
{
    public partial interface IQualityEvaluationClient
    {
        /// <summary>
        /// Poll for the evaluation result<br/>
        /// Returns the current state of an evaluation job. While the job is in progress the response contains only status information. Once complete the response includes the full evaluation report.
        /// </summary>
        /// <param name="jobId">
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>> PollQualityEvaluationAsync(
            global::System.Guid jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll for the evaluation result<br/>
        /// Returns the current state of an evaluation job. While the job is in progress the response contains only status information. Once complete the response includes the full evaluation report.
        /// </summary>
        /// <param name="jobId">
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>>> PollQualityEvaluationAsResponseAsync(
            global::System.Guid jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}